using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFilewatcher
{
    class Program
    {
        static bool StopFesten = false;

        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            // bind en metode til w.Changed
            w.Created += W_Created;
            w.Renamed += W_Renamed;

            Console.WriteLine("Nu kigger vi på filer");
            while (StopFesten == false)
            {

            }
            Console.WriteLine("tak for nu");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void W_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            Console.WriteLine("Nyt filnavn: " + e.Name + " til filen " + e.OldName);
            if (e.Name == "stop.txt")
            {
                StopFesten = true;
            }
        }

        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Ny fil: " + e.Name);
            if (e.Name == "stop.txt")
            {
                StopFesten = true;
            }
        }
    }
}
