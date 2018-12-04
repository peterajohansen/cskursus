using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingerStack
{
    class Program
    {
        static void Main(string[] args)
        {

            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.Fjernkort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }

    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void TilføjKort(Kort k)
        {
            bunke.Push(k);
        }
        public Kort Fjernkort()
        {
            if (bunke.Count > 0)
                return bunke.Pop();
            return null;
        }
        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }
        }
    }

}
