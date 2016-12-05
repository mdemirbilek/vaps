using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess; // namespace that Csv reader lives in
using System.Data;
using System.Net;
using System.Configuration;


namespace DoorDataProcessor
{
    class Program
    {

        static void Main(string[] args)
        {
            string op = "";
            int y = 0;
            int m = 0;
            int d = 0;
            int dateDiffAsDay = -1;
            DateTime opDate = DateTime.Today;

            try
            {
                op = args[0].Trim().ToString();
            }
            catch (Exception ex)
            {
                op = "";
            }

            try
            {
                y = int.Parse(args[1].Trim().ToString());
                m = int.Parse(args[2].Trim().ToString());
                d = int.Parse(args[3].Trim().ToString());
            }
            catch (Exception ex)
            {
                y = 0;
                m = 0;
                d = 0;
            }
            try
            {
                dateDiffAsDay = int.Parse(args[4].Trim().ToString());
            }
            catch (Exception ex)
            {
                dateDiffAsDay = -1;
            }

            if (y > 0 && m > 0 && d > 0)
            {
                try
                {
                    opDate = DateTime.Parse(y.ToString() + "-" + m.ToString() + "-" + d.ToString());

                }
                catch (Exception)
                {
                    opDate = DateTime.Today;
                }
            }

            opDate = opDate.AddDays(dateDiffAsDay); // Hep bir önceki günün işlemi yapılacağı için hani.. yani genelde..

            if (op == "parseload")
            {
                ParseAndLoadData(opDate);
            }
            else if (op == "calculate")
            {

                //opDate = DateTime.Parse("2016-12-2");
                CalcWorkingTimes(opDate);
            }

        }

        private static void ParseAndLoadData(DateTime opDate)
        {
            var doorsDb = new DOORSEntities();
            DataAccess.DataTable dt;


            string fileName = @"\\10.10.5.6\DoorExportFiles\DoorsNightlyRawData";
            fileName = fileName + opDate.Year.ToString() + get2Digit(opDate.Month.ToString()) + get2Digit(opDate.Day.ToString());

            //Console.WriteLine(fileName);
            //Console.ReadLine();

            try
            {
                dt = DataAccess.DataTable.New.ReadCsv(fileName);
            }
            catch (Exception)
            {
                dt = null;
            }

            int i = 0;
            int j = 0;
            int k = 0;

            if (dt != null)
            {
                foreach (Row row in dt.Rows)
                {

                    if (row["Event date/time"].Trim() != "" && row["User ExtID"].Trim() != "")
                    {
                        try
                        {
                            DoorsRawData drd = new DoorsRawData();

                            drd.Eventdatetime = DateTime.Parse(row["Event date/time"]);
                            drd.EventdatetimeUTC = DateTime.Parse(row["Event date/time UTC"]);
                            drd.OperationID = Int16.Parse(row["Operation ID"]);
                            drd.Isexit = Int16.Parse(row["Is exit"]);
                            drd.Operationdescription = row["Operation description"];
                            drd.Usertype = Int16.Parse(row["User type"]);
                            drd.Username = row["User name"];
                            drd.UserExtID = row["User ExtID"];
                            drd.UserGPF1 = row["User GPF1"];
                            drd.UserGPF2 = row["User GPF2"];
                            drd.UserGPF3 = row["User GPF3"];
                            drd.UserGPF4 = row["User GPF4"];
                            drd.UserGPF5 = row["User GPF5"];
                            drd.Cardserialnumber = row["Card serial number"];
                            drd.CardID = row["Card ID"];
                            drd.Doorname = row["Door name"];
                            drd.DoorExtID = row["Door ExtID"];
                            drd.DoorGPF1 = row["Door GPF1"];
                            drd.DoorGPF2 = row["Door GPF2"];

                            doorsDb.DoorsRawDatas.Add(drd);
                            i += 1;

                        }
                        catch (Exception ex)
                        {
                            j += 1;
                        }
                    }
                    else
                    {
                        k += 1;
                    }

                }

            }

            doorsDb.SaveChanges();

            dt = null;
            doorsDb.Dispose();

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            Console.WriteLine("DONE!");
        }

        private static void CalcWorkingTimes(DateTime opDate)
        {
            var doorsDb = new DOORSEntities();
            var verpsDb = new VERPSEntities();
            string vUser = Properties.Settings.Default.vUser;
            string vPass = Properties.Settings.Default.vPass;
            string vUri = Properties.Settings.Default.vUri;

            System.Uri myUri = new Uri(vUri);
            VERPSServiceReference.ApplicationData vsr = new VERPSServiceReference.ApplicationData(myUri);
            vsr.Credentials = new NetworkCredential(vUser, vPass, "adm");

            int i = 0;
            int j = 0;

            var doorTimes = from d in doorsDb.vwDoorTimes
                            where d.EventDay == opDate
                            select d;

            //////var empTimes = from b in verpsDb.hrWorkingHours
            //////               where b.WorkingDate.Equals(opDate)
            //////               select b;

            foreach (var doorT in doorTimes)
            {
                //////foreach (var empTime in empTimes)
                //////{
                //////    if (doorT.UserExtID == empTime.DoorSysID && doorT.EventDay == empTime.WorkingDate)
                //////    {
                //////        empTime.EntryTime = doorT.EntryTime;
                //////        empTime.ExitTime = doorT.ExitTime;
                //////        empTime.Modified = DateTimeOffset.Now;
                //////    }
                //////}

                string ssss = doorT.UserExtID;
                try
                {
                    var doorTime = vsr.hrWorkingHours.Where(p => p.DoorSysID == doorT.UserExtID && p.WorkingDate == doorT.EventDay).SingleOrDefault();
                    if (doorTime != null)
                    {
                        doorTime.EntryTime = doorT.EntryTime;
                        doorTime.ExitTime = doorT.ExitTime;

                        DateTime startTime = (DateTime)doorT.EntryTime;
                        DateTime endTime = (DateTime)doorT.ExitTime;
                        TimeSpan timeSpan = endTime.Subtract(startTime);

                        int workedMinute = (timeSpan.Hours * 60) + timeSpan.Minutes;
                        int assignedMinute = (int)doorTime.AssignedWorkingHour * 60;
                        int minuteDiff = workedMinute - assignedMinute;

                        doorTime.TotalHours = timeSpan.Hours;
                        doorTime.TotalMinutes = timeSpan.Minutes;
                        doorTime.HourDiff = minuteDiff / 60;
                        doorTime.MinuteDiff = minuteDiff % 60;




                        vsr.UpdateObject(doorTime);
                        j += 1;
                    }
                }
                catch (Exception ex)
                {

                }

                i += 1;
            }

            vsr.SaveChanges();
            //////verpsDb.SaveChanges();

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine("DONE!");
        }

        private static string get2Digit(string s)
        {
            string str4Return = "";
            if (s.Length == 1)
            {
                str4Return = "0" + s;
            }
            else
            {
                str4Return = s;
            }

            return str4Return;
        }

        private static System.Data.DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("Eventdatetime", typeof(DateTime));
            table.Columns.Add("EventdatetimeUTC", typeof(DateTime));
            table.Columns.Add("OperationID", typeof(Int16));
            table.Columns.Add("Isexit", typeof(Int16));
            table.Columns.Add("Operationdescription", typeof(string));
            table.Columns.Add("Usertype", typeof(Int16));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("UserExtID", typeof(string));
            table.Columns.Add("UserGPF1", typeof(string));
            table.Columns.Add("UserGPF2", typeof(string));
            table.Columns.Add("UserGPF3", typeof(string));
            table.Columns.Add("UserGPF4", typeof(string));
            table.Columns.Add("UserGPF5", typeof(string));
            table.Columns.Add("Cardserialnumber", typeof(string));
            table.Columns.Add("CardID", typeof(string));
            table.Columns.Add("Doorname", typeof(string));
            table.Columns.Add("DoorExtID", typeof(string));
            table.Columns.Add("DoorGPF1", typeof(string));
            table.Columns.Add("DoorGPF2", typeof(string));

            return table;
        }

    }
}
