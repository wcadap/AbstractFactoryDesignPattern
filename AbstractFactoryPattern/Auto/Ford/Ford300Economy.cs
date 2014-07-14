
namespace AbstractFactoryPattern.Auto.Ford
{
    public class Ford300Economy : IAutomobile
    {
        public string Name()
        {
            return "Ford 300";
        }

        public string Features()
        {
            return "Model 1954. For your Vintage.";
        }
    }
}
