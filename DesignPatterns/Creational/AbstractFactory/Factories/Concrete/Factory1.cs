using DesignPatterns.Creational.AbstractFactory.Factories.Abstract;
using DesignPatterns.Creational.AbstractFactory.Products.Abstract;
using DesignPatterns.Creational.AbstractFactory.Products.Concrete;

namespace DesignPatterns.Creational.AbstractFactory.Factories.Concrete
{
    public class Factory1 : IFactory
    {
        public IProductA CreateProductA()
            => new ProductA1();

        public IProductB CreateProductB()
            => new ProductB1();
    }
}
