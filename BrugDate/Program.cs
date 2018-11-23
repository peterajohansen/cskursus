using System;

namespace BrugDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);


            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2018, 11, 20 );
            DateTime d3 = new DateTime(2018, 11, 23);
            TimeSpan t1 = d3.Subtract(d2);
            Console.WriteLine($"tidsinterval mellem {d2} og {d3} er {t1}");

            TimeSpan t2 = new TimeSpan(16, 00, 00);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(00, 30, 00);
            Console.WriteLine(t3);

            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine(t4);

            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);

            DateTime nu = DateTime.Now;
            string input = Console.ReadLine();
            DateTime fdt;
            fdt = System.Convert.ToDateTime(input);

            TimeSpan t6 = nu.Subtract(fdt);
            Console.WriteLine(t6);


            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }
    }
}
