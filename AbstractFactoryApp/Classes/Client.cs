using System;

namespace AbstractFactoryApp
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Getting extra configuration:");
            Console.WriteLine(GetPartsSet(new ExtraConfiguration()));
            Console.WriteLine();
            Console.WriteLine("Getting standart configuration:");
            Console.WriteLine(GetPartsSet(new StandartConfiguration()));
            Console.WriteLine();
            Console.WriteLine("Getting economy configuration:");
            Console.WriteLine(GetPartsSet(new EconomyConfiguration()));
        }
        string GetPartsSet(IConfiguration configuration)
        {
            IEngine engine = configuration.GetEngine();
            IWheels wheels = configuration.GetWheels();
            ISuspension suspension = configuration.GetSuspension();
            return $"engine capacity={engine.Capacity}, wheels diameter={wheels.Diameter}, suspension type={suspension.Type}";
        }
    }
}
