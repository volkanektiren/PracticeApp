using DesignPatterns.Creational.FactoryMethod.Creators.Abstract;
using DesignPatterns.Creational.FactoryMethod.Products.Abstract;
using DesignPatterns.Creational.FactoryMethod.Products.Concrete;

namespace DesignPatterns.Creational.FactoryMethod.Creators.Concrete
{
    public class Creator2 : Creator
    {
        public override IProduct FactoryMethod()
            => new Product2();
    }
}
