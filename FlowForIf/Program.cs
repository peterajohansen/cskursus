using System;

namespace FlowForIf
{
    class Program
    {

        static void Main(string[] args)
        {

            int i = 0;
            int j = 0;

            while (i < 10)
            {
                i++;
                while (j < 10)
                {
                    j++;
                    string Tal = (i * j).ToString();
                    if (( i * j ) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(Tal.PadLeft(4));

                }
                j = 0;
                Console.WriteLine(" ");
            }


            for (int xx = 1; xx < 11; xx++)

            {

                for (int yy = 1; yy < 11; yy++)

                {

                    string tal = ( xx * yy ).ToString();

                    if (( xx * yy ) > 50)

                        Console.ForegroundColor = ConsoleColor.Yellow;

                    else

                        Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(tal.PadLeft(4));

                }

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Gray;

            }



            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }


            if (System.Diagnostics.Debugger.IsAttached)
            {

                Console.WriteLine("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }
    }
}
