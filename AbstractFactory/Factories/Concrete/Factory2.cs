using AbstractFactory.Factories.Abstract;
using AbstractFactory.Products.Abstract;
using AbstractFactory.Products.Concrete;

namespace AbstractFactory.Factories.Concrete
{
    public class Factory2 : IFactory
    {
        public IProductA CreateProductA() 
            => new ProductA2();

        public IProductB CreateProductB() 
            => new ProductB2();
    }
}
