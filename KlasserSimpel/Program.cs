using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserSimpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Ib";
            p1.Efternavn = "Dam";
            p1.Fødselsår = 1955;

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());

            Person p2 = new Person();
            p2.Efternavn = "Henningsen";
            p2.Fødselsår = 1946;

            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());

            Person p3 = new Person("mikkel", "cronberg", 2006);
            Console.WriteLine(p3.FuldtNavn());
            Console.WriteLine(p3.Alder());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        internal class Person
        {
            public string Fornavn;
            public string Efternavn;
            public int Fødselsår;

            public Person()
            {
                this.Fornavn = "";
                this.Efternavn = "";
            }
            public Person (string Fornavn, String Efternavn, int Fødselsår)
            {

                this.Fødselsår = Fødselsår;
                this.Fornavn = Fornavn;
                this.Efternavn = Efternavn;
            }
            public string FuldtNavn()
            {
                return $"{Fornavn} {Efternavn}";
            }
            public int Alder()
            {
                int AktueltÅr = DateTime.Now.Year;
                return AktueltÅr - Fødselsår;
            }
        }


}
}
