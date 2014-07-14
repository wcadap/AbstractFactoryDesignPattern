using AbstractFactoryPattern.Factory;
using System;

namespace AbstractFactoryPattern.Dealers
{
    class XCarDealer
    {
        private IFactory AutoManufacturer;
        public XCarDealer(IFactory _autoManufacturer)
        {
            AutoManufacturer = _autoManufacturer;
        }

        public string GetDescription()
        {
            string Description = "";
            Description = String.Concat(Description, "Manufacturer:", AutoManufacturer.Manufacturer, "\n");
            Description = String.Concat(Description, "============================================", "\n");
            Description = String.Concat(Description, "  Economy", "\n");
            Description = String.Concat(Description, "     ", "Name        : ",
                          AutoManufacturer.CreateEconomyCar().Name(), "\n");
            Description = String.Concat(Description, "     ", "Description : ",
                          AutoManufacturer.CreateEconomyCar().Features(), "\n");

            Description = String.Concat(Description, "  Luxury", "\n");
            Description = String.Concat(Description, "     ", "Name        : ",
                          AutoManufacturer.CreateLuxuryCar().Name(), "\n");
            Description = String.Concat(Description, "     ", "Description : ",
                          AutoManufacturer.CreateLuxuryCar().Features(), "\n");
            return Description;
        }
    }
}
