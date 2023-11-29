using DesignPatterns.Creational.AbstractFactory.Factories.Abstract;
using DesignPatterns.Creational.AbstractFactory.Products.Abstract;
using DesignPatterns.Creational.AbstractFactory.Products.Concrete;

namespace DesignPatterns.Creational.AbstractFactory.Factories.Concrete
{
    public class Factory2 : IFactory
    {
        public IProductA CreateProductA()
            => new ProductA2();

        public IProductB CreateProductB()
            => new ProductB2();
    }
}
