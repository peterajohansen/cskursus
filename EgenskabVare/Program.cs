using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskabVare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "Sukker";
            v.Pris = 12.50;
            Console.WriteLine(v.Navn + " " + v.Pris + " " + v.PrisMedMoms());

            Vare v2 = new Vare("Salt", 5.75);
            Console.WriteLine(v2.Navn + " " + v2.Pris + " " + v2.PrisMedMoms());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Vare
    {
        private string navn;
        private double pris;

        
        public string Navn
        {
            get
            {

                Console.WriteLine("Nu aflæses navn");
                return navn;
            }
            set
            {
                Console.WriteLine("Nu tildeles navn");
                navn = value;
            }
        }


        public double Pris
        {
            get
            {
                Console.WriteLine("Nu aflæses pris");
                return pris;
            }
            set
            {
                Console.WriteLine("Nu tildeles pris");
                pris = value;
            }
        }

        private double moms = 0.25;
        public double PrisMedMoms()
        {
            return (this.pris + (this.pris * moms)); 
        }

        public Vare()
        {

        }
        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }
    }
}

