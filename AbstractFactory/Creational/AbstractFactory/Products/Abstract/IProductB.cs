namespace DesignPatterns.Creational.AbstractFactory.Products.Abstract
{
    public interface IProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IProductA productA);
    }
}
