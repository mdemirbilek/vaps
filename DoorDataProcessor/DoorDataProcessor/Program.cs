using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess; // namespace that Csv reader lives in
using System.Data;


namespace DoorDataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {

            string op = "";

            try
            {
                op = args[0].Trim().ToString();
            }
            catch (Exception ex)
            {
                op = "";
            }

            if (op != "pald")
            {
                ParseAndLoadData();
            }



        }

        private static void ParseAndLoadData()
        {
            DateTime dtNow = DateTime.Now;
            //\\10.10.5.6\DoorExportFiles

            string fileName = @"\\10.10.5.6\DoorExportFiles\DoorsNightlyRawData";
            fileName = fileName + dtNow.Year.ToString() + get2Digit(dtNow.Month.ToString()) + get2Digit(dtNow.Day.ToString());

            DataAccess.DataTable dt = DataAccess.DataTable.New.ReadCsv(fileName);

            Console.WriteLine(fileName);

            Console.ReadLine();


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
