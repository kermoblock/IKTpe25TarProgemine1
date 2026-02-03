namespace MinMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double[] number = new double[10] { 6, 10, 67, 56, 12, 6, 8, 34, 21, 7};

            Console.WriteLine(number.Max());
            Console.WriteLine(number.Min());
            Console.WriteLine(number.Sum());
            Console.WriteLine(number.Average());

            Console.WriteLine("---------------");
            Console.WriteLine("Sorteerib numbrid alates väiksemast suuremani");

            //peate kasutama array ja sort ning foreach

            Array.Sort(number);
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }

            //soreteerib numbrid alates suuremast väiksemani
            Console.WriteLine("---------------------");
            Console.WriteLine("soreteerib numbrid alates suuremast väiksemani");

            Array.Reverse(number);
            foreach (int item in number)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------");
            //kasutate binarysearch
            //kirjuta lühidalt mis see tähendab
            Console.WriteLine("BinarySearch on kiire algorithm, mis otib asju tabelist");
            Console.WriteLine(Array.BinarySearch(number, 5));
        }
    }
}
