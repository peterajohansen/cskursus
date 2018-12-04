using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                int j = Run (i);
                i = j;
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static int Run(int i)
        {
            try
            {
                Console.WriteLine("Indtast 1. tal");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast 2. tal");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int res = tal1 + tal2;
                Console.WriteLine("resultatet er " + res);
                i = 55;
                return ( i );
            }

            catch (Exception ex)
            {


                Console.WriteLine("Antal forsøg tilbage: " + (3-i) + " " + ex.Message);
                //throw;
            }
        }



    }
}
