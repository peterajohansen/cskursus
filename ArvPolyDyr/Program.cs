using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPolyDyr
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund h = new Hund() { Navn = "Vovse" };
            Console.WriteLine(h);
            h.SigNoget();

            Kat k = new Kat() { Navn = "Kitty" };
            Console.WriteLine(k);
            k.SigNoget();
            Console.WriteLine();


            List<Dyr> forskelligeDyr = new List<Dyr>() { h, k, new Hund() { Navn = "Bingo" }, new Kat() { Navn = "Fififi" } };
            foreach (Dyr item in forskelligeDyr)
            {
                item.SigNoget();
            }

            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Dyr[] d = new Dyr[1];
                d[0] = Dyr.TilfældigtDyr();
                d[0].SigNoget();
            }
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }
    abstract class Dyr
    {

        static System.Random rnd = new Random();
        public string Navn { get; set; }
        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er dyr og hedder " + this.Navn);
        }
        public static Dyr TilfældigtDyr()
        {

            string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
            string[] navne = data.Split(';');
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }
        }
    }
    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + this.Navn);
        }
    }
    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en missekat og hedder " + this.Navn);
        }
    }
}
