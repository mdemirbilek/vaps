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

            //var ents = ad.Entities;


            studd.Name = "Friday211";
            studd.Surname = "Saturday211";

            //ad.AddToStudents(s1);


            ad.UpdateObject(studd);


           


            ad.SaveChanges();



            Console.ReadLine();

        }
    }
}
