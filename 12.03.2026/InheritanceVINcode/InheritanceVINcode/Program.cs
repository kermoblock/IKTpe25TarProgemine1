namespace InheritanceVINcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta masina number");
            int vinCode = Convert.ToInt32(Console.ReadLine());

            Machine machine = new Machine();
            machine.SetVinCode(vinCode);

            Console.WriteLine("Edukalt sisestatud");
            Console.WriteLine("VIN Code: " + machine.GetVinCode());



            //teha pärimus
            //on olemas class nimega Machine
            //see pärib Cars classi
            //saab siestada masina numbri
            //konsool annab vastuse: Edukalt sisestatud
            // VIN kood: VIN koodi nr
        }
    }

    class Car
    {
        public void SetVinCode(int vinCode)
        {
            vin = vinCode;
        }
        protected int vin;
    }

    class Machine : Car
    {
        public int GetVinCode()
        {
            return vin;
        }
    }
}
