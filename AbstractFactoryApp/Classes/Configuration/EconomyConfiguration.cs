namespace AbstractFactoryApp
{
    class EconomyConfiguration : IConfiguration
    {
        public IEngine GetEngine()
        {
            return new I4();
        }
        public IWheels GetWheels()
        {
            return new R15();
        }
        public ISuspension GetSuspension()
        {
            return new Susp1();
        }
    }
}
