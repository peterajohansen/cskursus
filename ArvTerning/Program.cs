using System;

namespace ArvTerning
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t1 = new Terning();
            
            t1.Skriv();

            // set til 3
            LudoTerning t2 = new LudoTerning(3);
            
            t2.Skriv();
            
            Console.WriteLine(t2.ErGlobus());
            Console.WriteLine(t2.ErStjerne());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public class Terning
    {
        private int værdi;
        private static Random r1;

        public int Værdi
        {
            get { return this.værdi; }
            set
            {
                if (value < 1 || value > 6)
                {
                    value = 1;
                }
                this.værdi = value;
            }
        }
        public Terning()
        {
            Ryst();
        }
        public Terning(int customVærdi)
        {
            this.værdi = customVærdi;
        }

        static Terning()
        {
            r1 = new Random();
        }

        public void Ryst()
        {
            this.Værdi = r1.Next( 1, 7);
 
        }
        public void Skriv()
        {
 
            Console.WriteLine(this.Værdi);

        }
    }

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            if (this.Værdi == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ErStjerne()
        {
            if (this.Værdi == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public LudoTerning() : base()
        {

        }
        public LudoTerning(int værdi) : base(værdi)
        {

        }

    }
}
