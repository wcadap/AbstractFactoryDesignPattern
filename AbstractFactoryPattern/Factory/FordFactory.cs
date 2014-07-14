using AbstractFactoryPattern.Auto.Ford;

namespace AbstractFactoryPattern.Factory
{
    class FordFactory : IFactory
    {
        public string Manufacturer
        {
            get 
            { 
               return "Ford"; 
            }
        }
        public Auto.IAutomobile CreateEconomyCar()
        {
            return new Ford300Economy();
        }

        public Auto.IAutomobile CreateLuxuryCar()
        {
            return new FordCougarLuxury();
        }
    }
}
