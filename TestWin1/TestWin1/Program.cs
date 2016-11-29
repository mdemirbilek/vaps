using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess; // namespace that Csv reader lives in
using System.Data;

namespace TestWin1
{
    class Program
    {
        static void Main(string[] args)
        {

            var whContext1 = new HR1Entities();
            var verpsContext1 = new VERPSEntities();



            DataAccess.DataTable dt = DataAccess.DataTable.New.ReadCsv(@"C:\Users\mehme\Documents\doors.csv");

            DataSet ds = new DataSet();
            System.Data.DataTable dt2 = new System.Data.DataTable();


            foreach (Row row in dt.Rows)
            {

                if (row["Card ID"].ToString().Trim() != "DA45A9BF000000" && 1 == 2)
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

                    //whContext.DoorsRawDatas.Add(drd);

                }
            }

            //whContext.SaveChanges();

            for (int i = 1; i < 32; i++)
            {
                InsertWorkingTimes(i);
            }



            var reader = new StreamReader(File.OpenRead(@"C:\Users\mehme\Documents\doors.csv"));
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split('"');

                listA.Add(values[0]);
                listB.Add(values[1]);
            }


        }

        private static void InsertWorkingTimes(int i)
        {
            var whContext = new HR1Entities();
            var verpsContext = new VERPSEntities();

            var doorTimes = from b in whContext.vwWorkingTimes
                            where b.RecYear == 2016 && b.RecMonth == 11 && b.RecDay == i
                            select b;


            var empTimes = from b in verpsContext.hrWorkingHours
                           where b.RecYear.Equals(2016) && b.RecMonth.Equals(11) && b.RecDay.Equals(i)
                           select b;


            foreach (var doorTime in doorTimes)
            {
                foreach (var empTime in empTimes)
                {


                    if (doorTime.CardID == empTime.AccessCardID && doorTime.RecYear == empTime.RecYear && doorTime.RecMonth == empTime.RecMonth && doorTime.RecDay == empTime.RecDay)
                    {
                        empTime.EntryTime = doorTime.EntryTime;
                        empTime.ExitTime = doorTime.ExitTime;
                        empTime.TotalHours = doorTime.WorkingHours;
                        empTime.TotalMinutes = doorTime.WorkingMinutes;
                        empTime.Modified = DateTimeOffset.Now;
                        //empTime.DayOfWeek = "Sunday";
                    }
                }
            }




            verpsContext.SaveChanges();
        }

        static System.Data.DataTable GetTable()
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

            //// Here we add five DataRows.
            //table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            //table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            //table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            //table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            //table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            return table;
        }

    }
}
