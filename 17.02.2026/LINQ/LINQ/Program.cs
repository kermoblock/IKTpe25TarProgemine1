using LINQ.Models;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ läbi switchi");
            Console.WriteLine("Vali vastav link numbriga");
            Console.WriteLine("1. Where");
            Console.WriteLine("2. Inimese nimi");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    WhereLINQ();
                    break;

                    case 2:
                    WhereByNameLINQ();
                     break;

                    default:
                    break;
            }
        }


        //teeme uue meetodi
        public static void WhereLINQ()
        {
            var peopleAge = PeopleData.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var people in peopleAge)
                {
                    Console.WriteLine(people.Name);
                }
            //kasutada muutujat peopleAge ja kuvada andmed esile
            //kasuta foreach
        }

        public static void WhereByNameLINQ()
        {
            Console.WriteLine("Kirjuta inimese nimi");
            string name = Console.ReadLine();
            var peopleName = PeopleData.peoples
                .Where(x=> x.Name == name);

            foreach (var people in peopleName)
            {
                Console.WriteLine(people.Name);
            }



            

            //kasutada where inimese otsimiseks
            //otsimine toimub nime alusel
        }
    }
}
