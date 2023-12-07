using DesignPatterns.Creational.FactoryMethod.Products.Abstract;

namespace DesignPatterns.Creational.FactoryMethod.Products.Concrete
{
    public class Product2 : IProduct
    {
        public string Operation()
            => "{Result of ConcreteProduct2}";
    }
}
