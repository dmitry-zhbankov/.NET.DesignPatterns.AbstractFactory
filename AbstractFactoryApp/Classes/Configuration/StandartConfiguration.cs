namespace AbstractFactoryApp
{
    class StandartConfiguration : IConfiguration
    {
        public IEngine GetEngine()
        {
            return new X18XEV();
        }
        public IWheels GetWheels()
        {
            return new R17();
        }
        public ISuspension GetSuspension()
        {
            return new Susp2();
        }
    }
}
