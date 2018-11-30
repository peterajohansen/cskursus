using System;

namespace MetSimp
{
    class Program
    {

        static void Main(string[] args)

        {
            
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.53

            Udskriv("Dette er en test");

            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }

        }
        
        static int LægSammen(int a, int b)
        {
            return a + b;
        }
        static double BeregnAreal(int radius)
        {
            return radius * radius * Math.PI;
        }
        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
