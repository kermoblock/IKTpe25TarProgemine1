namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb teha class nimega PeopleList
            //Seal on kuus rida andmeid
            //Kindlasti peab olema kaks Mari nimega isikut, aga erinevate vanustega

            Console.WriteLine("Tee valik numbriga");
            Console.WriteLine("1. ThenByLinq");
            Console.WriteLine("2. ThenByDescending");
            Console.WriteLine("3. SelectLINQ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThenByLINQ();
                    break;

                case 2:
                    ThenByDescendingLINQ();
                    break;

                case 3:
                    SelectLINQ();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }

        //kutsuda meetod switchis esile
        public static void ThenByLINQ()
        {
            //thenby sorteerib numbrilises järjestuses
            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            Console.WriteLine("ThenBy järgi sorteerimine");
            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        public static void ThenByDescendingLINQ()
        {
            var ThenByDescending = PeopleList.peoples
                .OrderByDescending(y => y.Name)
                .ThenByDescending(y => y.Age);

            Console.WriteLine("ThenByDescending järgi sorteerimine");
            foreach (var people in ThenByDescending)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        public static void SelectLINQ()
        {
            //select lihtsalt annab andmed,
            //ei mingit järjestust lihtsalt
            //nii nagu need on andmebaasis
            var SelectLINQ = PeopleList.peoples
                .Select(x => new
                {
                    x.Name,
                    x.Age   
                });

            Console.WriteLine("Select järgi sorteerimine");
            foreach (var people in SelectLINQ)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }


        }
    }
}
