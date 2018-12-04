using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEgenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Ole";
            p1.Efternavn = "Olesen";
            Console.WriteLine(p1.FuldtNavn());

            Person p2 = new Person();
            p2.Fornavn = "Kurt";
            p2.Efternavn = "WW";
            Console.WriteLine(p2.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
    class Person
    {
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length > 3)
                { efternavn = value; }
                else
                { efternavn = ""; }

            }
        }

        public string FuldtNavn()
        {
            return ( Fornavn + " " + Efternavn );
        }
    }
}
