using DesignPatterns.Creational.FactoryMethod.Products.Abstract;

namespace DesignPatterns.Creational.FactoryMethod.Products.Concrete
{
    public class Product1 : IProduct
    {
        public string Operation()
            => "{Result of ConcreteProduct1}";
    }
}
