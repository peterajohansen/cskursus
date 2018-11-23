using System;

namespace BrugText
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string navnDel = efternavn.Substring(0, 4);
            Console.WriteLine(navnDel);

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);
            //int ix = 0;
            for (int ix = 0; ix < 20; ix++)
            {
                Console.WriteLine(ix);
                System.IO.File.WriteAllText("c:\\temp\\test2.txt", ix + samletNavn);
                System.IO.File.WriteAllText("c:\\temp\\test2.txt", "\r\n");
            }


            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }
    }
}
