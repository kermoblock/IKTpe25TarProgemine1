namespace Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance 2");

            //kui siin on Water class, siis kuvatakse seal olevat DoSomething meetodi sisu
            Water water = new Water();

            //kui panna Water water = new River(); , siis kuvatakse River classis olevat DoSomething
            //meetodi sisu
            Water water1 = new River();
            water1.Flow = true;
            water1.Length = "123";

            Water water2 = new Lake();

            //kutsume soovitud meetodi esile
            water.DoSomething();
            water1.DoSomething();
            water2.DoSomething();
        }
    }
}
