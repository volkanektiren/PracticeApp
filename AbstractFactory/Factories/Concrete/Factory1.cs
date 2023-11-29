using AbstractFactory.Factories.Abstract;
using AbstractFactory.Products.Abstract;
using AbstractFactory.Products.Concrete;

namespace AbstractFactory.Factories.Concrete
{
    public class Factory1 : IFactory
    {
        public IProductA CreateProductA()
            => new ProductA1();

        public IProductB CreateProductB()
            => new ProductB1();
    }
}
