using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHeltSimpel
{
    class Program
    {
        //public delegate void MinDelegate1(string t);

        static void Main(string[] args)
        {
            Action<string> f1 = MinSkrivTilConsole;
            f1.Invoke("Hejsa");

            //MinDelegate1 f2 = MinSkrivTilConsole;
            //f2("Sukkerfar");

            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3 += Console.WriteLine;
            f3 += Console.WriteLine;
            f3 += Console.WriteLine;
            f3 += Console.WriteLine;
            f3 += Console.WriteLine;
            f3("Nu med cw");

          //  Action<string, int> f4 = int i MinReturIntCW;

            //f1 -= MinSkrivTilConsole;
            //f2 -= MinSkrivTilConsole;
            //f3 -= MinSkrivTilConsole;
            //f3 += Console.WriteLine;


            //f1("dyt");
            //f2("båt");
            //f3("fff");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine(">" + txt);
        }
        static int MinReturIntCW(string txt)
        {
            Console.WriteLine(">" + txt);
            return 123; 
        }
    }
}
