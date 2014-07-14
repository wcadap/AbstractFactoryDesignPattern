using AbstractFactoryPattern.Dealers;
using AbstractFactoryPattern.Factory;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new XCarDealer(new ToyotaFactory()).GetDescription());
            Console.WriteLine(new XCarDealer(new FordFactory()).GetDescription());
        }
    }
}
