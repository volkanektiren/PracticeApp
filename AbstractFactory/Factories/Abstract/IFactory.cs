using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Factories.Abstract
{
    public interface IFactory
    {
        IProductA CreateProductA();

        IProductB CreateProductB();
    }
}
