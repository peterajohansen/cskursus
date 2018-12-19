using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[5];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 1, Navn = "Bimmer" };
            hunde[3] = new Hund() { Alder = 1, Navn = "Kvik" };
            hunde[4] = new Hund() { Alder = 13, Navn = "Lars Løkke" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn + " " + item.Alder);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Hund : IComparable<Hund>
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(Hund h)
        {
            if (h.Alder > this.Alder)
                return -1;
            if (h.Alder < this.Alder)
                return 1;

            if (h.Alder == this.Alder)
                return string.Compare(this.Navn, h.Navn);
   
            return 0;
        }
    }
}