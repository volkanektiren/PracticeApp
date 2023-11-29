using DesignPatterns.Creational.AbstractFactory.Products.Abstract;

namespace DesignPatterns.Creational.AbstractFactory.Factories.Abstract
{
    public interface IFactory
    {
        IProductA CreateProductA();

        IProductB CreateProductB();
    }
}
