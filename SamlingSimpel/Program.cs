using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingSimpel
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> lst1 = new List<Person>();

            lst1.Add(new Person() { Id = 1, Navn = "Alf" });
            lst1.Add(new Person() { Id = 2, Navn = "Flemming" });
            lst1.Add(new Person() { Id = 3, Navn = "Bent-Ole" });
            foreach (var item in lst1)
            {
                Console.WriteLine(item.Navn);
            }

            Dictionary<int, Person> lst2 = new Dictionary<int, Person>();
            lst2.Add(1, new Person() { Id = 1, Navn = "Tulle"});
            lst2.Add(2, new Person() { Id = 2, Navn = "Fede Finn"});
            lst2.Add(3, new Person() { Id = 3, Navn = "Berit"});
            foreach (var item in lst2)
            {
                Console.WriteLine(item.Key + "" + item.Value);
            }
            var p = lst2[3];
            Console.WriteLine(p.Navn);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}

