﻿namespace AbstractFactory.Products.Abstract
{
    public interface IProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IProductA productA);
    }
}
