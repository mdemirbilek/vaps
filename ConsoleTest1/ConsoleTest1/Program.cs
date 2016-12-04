using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Uri uri = new Uri(@"http://localhost:1235/ApplicationData.svc");
            NetworkCredential nc = new NetworkCredential(@"adm\mdemirbilek", @"Demirbim!21");

            ServiceReference1.ApplicationData ad = new ServiceReference1.ApplicationData(uri);
            ad.Credentials = nc;

            ServiceReference1.Student s1 = new ServiceReference1.Student();

            //var ss = ad.Students.Where(r => r.Id == 2).ToList();

            var studd = ad.Students.Where(p => p.Id == 2).SingleOrDefault();

            int i = 0;
            studd = null;

            studd = ad.Students.Where(p => p.Id == 2).SingleOrDefault();
            studd.Name = "qqqqqq";
            studd.Surname = "aaaa";
            ad.UpdateObject(studd);

            studd = ad.Students.Where(p => p.Id == 3).SingleOrDefault();
            studd.Name = "aaaaaaa";
            studd.Surname = "bbbb";
            ad.UpdateObject(studd);


            ad.SaveChanges();



            Console.ReadLine();

        }
    }
}
