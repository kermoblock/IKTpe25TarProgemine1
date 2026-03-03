using System.Net.Cache;

namespace LinqAllAny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LINQ");
            Console.WriteLine("1. All");
            Console.WriteLine("2. Any");
            Console.WriteLine("3. Join");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AllLinq();
                    break;

                case 2:
                    AnyLinq();
                    break;

                case 3:
                    JoinLinq();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }

        public static void AllLinq()
        {
            //kasutate All
            //kontrollite, kas on vanemaid, kui 12 ja ja nooremaid kui 20

            bool result = StudentData.students.All(x => x.Age > 12 && x.Age < 20);

            Console.WriteLine("----------------AllLinq----------------");
            Console.WriteLine(result);
        }

        //uus meetod nimega AnyLinq
        //Kasutada Any-t
        //Vastus on true
        public static void AnyLinq()
        {
            bool result = StudentData.students.Any(x => x.Age > 12 && x.Age < 20);

            Console.WriteLine("----------------AnyLinq----------------");
            Console.WriteLine(result);
        }

        //teha meetod nimega JoinLinq
        //kasutada Join-i
        //

        public static void JoinLinq()
        {
            var innerjoin = StudentData.students.Join
            (
                StandartData.standarts,
                students => students.StandartId,
                standartId => standartId.StandartId,
                (students, standartId) => new
                {
                    Name = students.Name,
                    standartId = standartId.StandartId,
                }
            );

            foreach ( var item in innerjoin )
            {
                Console.WriteLine(" {0} - {1}", item.Name, item.standartId);
            }
        }
    }
}
