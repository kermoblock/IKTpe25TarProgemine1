using System.ComponentModel.DataAnnotations;

namespace Inheritance2
{
    public class Water
    {
        public bool Flow;
        public string Length;
        //teine viis, kuidas töötab

        //siin on DoSomething meetod, mida siis viidatakse River classi all
        //see võib olla virtual ja ei pea panema override kuna teda kirjutatakse üle
        public virtual void DoSomething()
        {
            Console.WriteLine("Do Something method Water");
        }
    }

    //internal class WaterProp
    //{
    //public bool Flow;
    //public string Length;
    //}
}
