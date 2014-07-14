using AbstractFactoryPattern.Factory.Toyota;
using AbstractFactoryPattern.Auto.Toyota;

namespace AbstractFactoryPattern.Factory
{
    public class ToyotaFactory : IFactory
    {
        public string Manufacturer
        {
            get
            {
                return "Toyota";
            }
        }
        public Auto.IAutomobile CreateEconomyCar()
        {
            return new CorollaAxioEconomy();
        }

        public Auto.IAutomobile CreateLuxuryCar()
        {
            return new ToyotaAvalonLuxury();
        }
    }
}
