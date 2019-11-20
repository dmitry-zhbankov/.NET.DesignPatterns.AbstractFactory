using System;

namespace AbstractFactoryApp
{
    public interface IConfiguration
    {
        IEngine CreateEngine();
        IWheels CreateWheels();
        ISuspension CreateSuspension();
    }
    public interface IEngine
    {
        public double Capacity { get; }
    }
    public interface IWheels
    {
        public double Diameter { get; }
    }
    public interface ISuspension
    {
        public string Type { get; }
    }

    class EconomyConfiguration : IConfiguration
    {
        public IEngine CreateEngine()
        {
            return new I4();
        }
        public IWheels CreateWheels()
        {
            return new R15();
        }
        public ISuspension CreateSuspension()
        {
            return new Susp1();
        }
    }
    class StandartConfiguration : IConfiguration
    {
        public IEngine CreateEngine()
        {
            return new X18XEV();
        }
        public IWheels CreateWheels()
        {
            return new R17();
        }
        public ISuspension CreateSuspension()
        {
            return new Susp2();
        }

    }
    class ExtraConfiguration : IConfiguration
    {
        public IEngine CreateEngine()
        {
            return new X20XEV();
        }
        public IWheels CreateWheels()
        {
            return new R19();
        }
        public ISuspension CreateSuspension()
        {
            return new Susp3();
        }
    }

    class X18XEV : IEngine
    {
        public double Capacity { get; private set; } = 1.8;
    }
    class X20XEV : IEngine
    {
        public double Capacity { get; private set; } = 2.0;
    }
    class I4 : IEngine
    {
        public double Capacity { get; private set; } = 1.7;
    }
    class R15 : IWheels
    {
        public double Diameter { get; private set; } = 15;
    }
    class R17 : IWheels
    {
        public double Diameter { get; private set; } = 17;
    }
    class R19 : IWheels
    {
        public double Diameter { get; private set; } = 19;
    }
    class Susp1 : ISuspension
    {
        public string Type { get; private set; } = "MacPherson";

    }
    class Susp2 : ISuspension
    {
        public string Type { get; private set; } = "Swing axle";

    }
    class Susp3 : ISuspension
    {
        public string Type { get; private set; } = "Sliding pillar";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Main();
        }
    }
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
            IEngine engine = configuration.CreateEngine();
            IWheels wheels = configuration.CreateWheels();
            ISuspension suspension = configuration.CreateSuspension();
            return $"engine capacity={engine.Capacity}, wheels diameter={wheels.Diameter}, suspension type={suspension.Type}";
        }
    }
}
