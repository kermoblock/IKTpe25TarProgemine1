using System.ComponentModel.DataAnnotations;


namespace Inheritance2
{
    //River on antud juhul alamklass ja viitab Waterile ehk peamisele classile
     public class River : Water
    {
        //kui kirjutan override, siis kirjutab Water meetodis oleva DoSomething meetodi üle
        //kui panen siia public virtual void, siis ei kirjuta Water meetodi DoSomething-t üle
        public override void DoSomething()
        {
            //WaterProp waterProp = new WaterProp();
            //Water classis on olemas muutuja Flow ja Length ja sellepärast ei pea neid siin uuesti defineerima

            Console.WriteLine("This river method and it has " + Flow + " and " + Length + " is in meters River");
        }
    }
}
