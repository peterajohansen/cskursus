using System;

namespace Brugvar
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal += 20;
            heltal ++;
            heltal--;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }

        }
    }
}
