using System;

namespace BrugStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = new FilTyper();

            ft = FilTyper.csv;
            Console.WriteLine(ft);

            Person p = new Person
            {
                Id = 1,
                Navn = "Mikkel",
                Køn = 0
            };

            Console.WriteLine(p.Navn);
           
            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }


    }
    enum FilTyper
    { csv, pdf, txt }

    public struct Person
    {
        public int Id;
        public string Navn;
        public int Køn;
    }

    public enum Køn : int
    {
        Mand,
        Kvinde
    }
}
