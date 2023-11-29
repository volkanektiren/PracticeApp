using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete
{
    class ProductA1 : IProductA
    {
        public string UsefulFunctionA() 
            => "The result of the product A1.";
    }
}
