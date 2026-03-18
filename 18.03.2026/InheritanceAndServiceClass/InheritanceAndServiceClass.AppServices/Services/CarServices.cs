using InheritanceAndServiceClass.Core.ServiceInterface;

namespace InheritanceAndServiceClass.AppServices.Services
{
    //proovie lahendada probleem, et CarServices ei
    //saa kasutada ICarService-s, kuna see on defineeritud
    //teises projektis
    public class CarServices : ICarServices
    {
        public void GetData()
        {
            Console.WriteLine("Car Services");
        }
    }
}
