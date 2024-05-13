using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETINTRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADO DOT NET DEMOS");

            Trainerdb db = new Trainerdb();
            //List<Trainer> trainers = db.Alltrainers();
            List<Trainer> trainers;
            List<student> students;
            db.Alltrainers(out trainers, out students) ;

            Console.WriteLine("ALL TRAINERS IN DATABASE");

            foreach (var t in trainers)
            {
                Console.WriteLine($"Id: {t.Id} Name : {t.Name} City : {t.City} Experience : {t.Experience}");
            }

            Console.WriteLine("ALL STUDENTS IN DATABASE");
            foreach (var s in students)
            {
                Console.WriteLine($"Rollnumber: {s.Rollnumber} Name : {s.Name} Gender : {s.Gender} Trainerid : {s.Trainerid}");
            }

            Console.ReadLine();
        }
    }
}
