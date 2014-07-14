using AbstractFactoryPattern.Auto;

namespace AbstractFactoryPattern.Factory.Toyota
{
    public class CorollaAxioEconomy : IAutomobile
    {
        public string Name()
        {
            return "Toyota Corolla Axio";
        }

        public string Features()
        {
            return "Small Type: For Personal Use.";
        }
    }
}
