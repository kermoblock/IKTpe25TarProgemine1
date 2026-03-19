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

        public void SaveAsync()
        {
            Console.WriteLine("Andmed Edukalt Salvestatud");
        }

        public void UpdateData()
        {
            Console.WriteLine("Andmed Edukalt Uuendatud");
        }

        public void EraseData()
        {
            Console.WriteLine("Andmed Edukalt Kustutatud");
        }
    }
}
