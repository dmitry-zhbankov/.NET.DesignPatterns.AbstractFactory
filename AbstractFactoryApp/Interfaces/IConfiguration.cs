namespace AbstractFactoryApp
{
    interface IConfiguration
    {
        IEngine GetEngine();
        IWheels GetWheels();
        ISuspension GetSuspension();
    }
}
