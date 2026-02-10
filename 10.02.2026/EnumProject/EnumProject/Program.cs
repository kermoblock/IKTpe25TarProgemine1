using System.Net.Security;

namespace EnumProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");
            //kasuta enumit Weekdays ja tuleb näha reedet
            Console.WriteLine(Weekdays.Friday);

            Console.WriteLine("----------------------------");
            //tahame näha friday numbrilist väärtust
            Console.WriteLine((int)Weekdays.Friday);

            Console.WriteLine("----------------------------");
            //tehke uus enum Colors
            Console.WriteLine(Colors.Green);
            Console.WriteLine((int)Colors.Green);
        }

        enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Colors
        {
            Red = 3,
            Green = 10,
            Blue = 13,
            Yellow = 5,
            Black = 1,
            White = 8
        }
    }
}
