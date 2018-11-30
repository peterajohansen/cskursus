using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Metoder_statisk

{

    class Program

    {

        static void Main(string[] args)

        {

            bool t = System.IO.File.Exists(@"C:\Users\b19416\Desktop\test.txt");

            Console.WriteLine($"Findes fil: {t}");

            string indhold = System.IO.File.ReadAllText(@"C:\Users\b19416\Desktop\test.txt");

            Console.WriteLine(indhold);



            var fil = new System.IO.FileInfo(@"C:\Users\b19416\Desktop\test.txt");

            DateTime d = fil.LastAccessTime;

            Console.WriteLine($"Tid: {d}");

            string ex = fil.Extension;

            Console.WriteLine($"Extension: {ex}");



            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }

            
        }

    }

}