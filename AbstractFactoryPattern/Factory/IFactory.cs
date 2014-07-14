using AbstractFactoryPattern.Auto;

namespace AbstractFactoryPattern.Factory
{
    public interface IFactory
    {
        string Manufacturer { get; }
        IAutomobile CreateEconomyCar();
        IAutomobile CreateLuxuryCar();
        
    }
}
