using System;
using System.Security.Cryptography;

namespace ListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list and LINQ");

            //teeme "andmebaasi"
            //ja selleks on vaja luua class nimega person
            IList<Person> person = new List<Person>()
            {
                new Person() {Id = 1, Name = "Mark", Age  = 500},
                new Person() {Id = 2, Name = "Armand", Age  = 45},
                new Person() {Id = 3, Name = "Emex", Age  = 67},
                new Person() {Id = 4, Name = "Mark-Leon", Age  = 5000},
            };

            //nüüd kasutame person muutujuat uue muutuja all
            //mille nimeks on persons
            var persons = from p in person
                          select new
                          {
                              Id = p.Id,
                              Name = p.Name,
                              Age = p.Age,
                          };

            foreach (var item in persons)
            {
                Console.WriteLine("Id on " + item.Id + " ja ta nimi on " + item.Name);
            }

            Console.WriteLine("--------------------------------------------------------");


            Console.WriteLine("Kasutame LINQ selecti ehk teine variant");
            //siin koondame kogu info result muutuja sisse
            var result = person
                .Where(p => p.Id == 1|| p.Age == 100) //Where-ga saab teha konkreetse päringu, et vastaks mingile tingimusele

                .OrderBy(p  => p.Name) //järjestab isikud nime järjestikus

                .Select(x => new { Id = x.Id, Name = x.Name, Age = x.Age });

            //kasutame result muutujat ja teeme ta lahti rea kaupa
            foreach (var item in result)
            {
                Console.WriteLine("Id on " + item.Id + " ja ta nimi on " + item.Name);
            }

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Gruppide kaupa sorteerimine");

            var groupBy = person.GroupBy(p => p.Age);
            //kuab gruppide kaupa ja antud juhul paneb vanused gruppidese
            // ehk tulemus on neli rida andmeid kuna kõik on üle 9 a

            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0}", item.Key);
            }
        }
    }
}
