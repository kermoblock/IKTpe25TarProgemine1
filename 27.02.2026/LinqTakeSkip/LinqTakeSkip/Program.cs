using System.Threading.Channels;

namespace LinqTakeSkip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ meetodid");
            Console.WriteLine("1. Skip");
            Console.WriteLine("2. SkipWhile");
            Console.WriteLine("3. TakeWhile");
            Console.WriteLine("4. FirstOrDefault");
            Console.WriteLine("5. Average");
            Console.WriteLine("6. Count");
            Console.WriteLine("7. Sum");
            Console.WriteLine("8. Max");
            Console.WriteLine("9. Min");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Skip();
                    break;

                case 2:
                    SkipWhile();
                    break;

                case 3:
                    TakeWhile();
                    break;

                case 4:
                    FirstOrDefault();
                    break;

                case 5:
                    Average();
                    break;

                case 6:
                    CountLINQ();
                    break;

                case 7:
                    Sum();
                    break;

                case 8:
                    Max();
                    break;

                case 9:
                    Min();
                    break;

                default:
                    Console.WriteLine("Vale Valik");
                    break;
            }
        }



        public static void Skip()
        {
            Console.WriteLine("-------------Skip-------------");
            //kasuta skip ja jäta kolm tükki vahele

            var Skip = PeopleList.peoples.Skip(3);

            foreach (var people in Skip)
            {
                Console.WriteLine(people.Name);
            }
        }

        //teete uue meetodi, aga kasutate SkipWhile ja vanemad, kui 18 peab olema tingimuses
        public static void SkipWhile()
        {
            Console.WriteLine("-------------SkipWhile-------------");

            //Skipwhile jätab loendis nii kaua vahele ridu kuni vastab tingimusele
            //ehk antud juhul jätab read vahele kuni leiab 18a või noorema isiku ja
            //peale seda hakkab infot jälle kuvama olenemata vanuse tingimusest

            //mis tähendab: => . see tähendab lamba märki
            //ja selle abil saab kasutada pikema classi nimetuse asemel lühendit
            //koos sees oleva muutujaga, mis antud juhul on x.
            var SkipWhile = PeopleList.peoples.SkipWhile(x => x.Age > 18);
            
            foreach (var people in SkipWhile)
            {
                Console.WriteLine(people.Id + " " + people.Name + " " + people.Age);
            }
        }

        //kasutada TakeWhile ja kutsuda see esile switchis
        //tingimus on Age > 18
        public static void TakeWhile()
        {
            //Takewhile näitab isikuid kuni vastab tingimusele
            //ehk antud juhul näitab kuni leiab 18a või vanema isiku ja
            //peale seda ei näita enam andmeid
            Console.WriteLine("-------------TakeWhile-------------");
            var TakeWhile = PeopleList.peoples.TakeWhile(x => x.Age > 18);

            foreach (var people in TakeWhile)
            {
                Console.WriteLine(people.Id + " " + people.Name + " " + people.Age);
            }
        }

        public static void FirstOrDefault()
        {
            //peate kasutama Name ja Length-i. Nimi peav olema vähemalt 5
            //tähemärki pikk

            //kuvab esimese elemendi, mis järjestuses
            //vastab tingimusele
            Console.WriteLine("-------------FirstOrDefault-------------");
            string FirstLongName = PeopleList.peoples.FirstOrDefault(x => x.Name.Length > 5).Name;

            Console.WriteLine("The first long name is '{0}'.", FirstLongName);
        }

        //kasutame Avarage Linq

        public static void Average()
        {
            Console.WriteLine("-------------Average-------------");
            var Average = PeopleList.peoples.Average(x => x.Age);
            Console.WriteLine(Average);
        }

        public static void CountLINQ()
        {
            var TotalPersons = PeopleList.peoples.Count();

            Console.WriteLine("-------------Count-------------");
            Console.WriteLine("Inimesi on kokku " + TotalPersons);

            Console.WriteLine("-------------------------------");
            var AdultPerson = PeopleList.peoples.Count(x  => x.Age > 18);
            Console.WriteLine("Täiskasvanuid on kokku " + AdultPerson);
        }

        //kasutame summat ehk sum

        public static void Sum()
        {
            Console.WriteLine("-------------Sum-------------");
            var Sum = PeopleList.peoples.Sum(x => x.Age);
            Console.WriteLine("Kõikide vanus kokku on " + Sum);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Täisealite isikute koondarv");
            var sumAdults = 0;
            var NumAdults = PeopleList.peoples.Sum(y =>
            {
                if (y.Age >= 18)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            Console.WriteLine("Täiskasvanud isikute koondarv on " + NumAdults);
        }

        public static void Max()
        {
            Console.WriteLine("-------------Max-------------");
            var Max = PeopleList.peoples.Max(x => x.Age);

            Console.WriteLine("Kõige vanem inimene on " + Max + " aastat vana");
        }

        public static void Min()
        {
            Console.WriteLine("-------------Min-------------");
            var Min = PeopleList.peoples.Min(x => x.Age);

            Console.WriteLine("Kõige noorem inimene on " + Min + " aastat vana");
        }
    }
}
