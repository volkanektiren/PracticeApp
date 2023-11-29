using DesignPatterns.Creational.AbstractFactory.Products.Abstract;

namespace DesignPatterns.Creational.AbstractFactory.Products.Concrete
{
    class ProductB1 : IProductB
    {
        public string AnotherUsefulFunctionB(IProductA productA)
        {
            var result = productA.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
            => "The result of the product B1.";
    }
}
