using System;

namespace MetOverload
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Beregn(1,2));

            Console.WriteLine(Beregn(1, 2, 3));

            Console.WriteLine(Beregn(1, 2, 4, 5));


            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }

        }

        static int Beregn(int a, int b)
        {
            return a + b;
        }
        static int Beregn(int a, int b, int c)
        {
            return Beregn(a, b) + c;
        }
        static int Beregn(int a, int b, int c, int d)
        {
            return Beregn(a, b, c) + d;
        }

    }
}
