
namespace AbstractFactoryPattern.Auto.Ford
{
    public class FordCougarLuxury : IAutomobile
    {
        public string Name()
        {
            return "Ford Cougar";
        }

        public string Features()
        {
            return "Third generation Probe. Comfort is our business.";
        }
    }
}
