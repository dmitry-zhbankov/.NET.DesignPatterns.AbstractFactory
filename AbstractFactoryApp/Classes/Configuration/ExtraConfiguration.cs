namespace AbstractFactoryApp
{
    class ExtraConfiguration : IConfiguration
    {
        public IEngine GetEngine()
        {
            return new X20XEV();
        }
        public IWheels GetWheels()
        {
            return new R19();
        }
        public ISuspension GetSuspension()
        {
            return new Susp3();
        }
    }
}
