namespace DesignPatterns.Creational.Builder
{
    public class ABuilder : AbstractBuilder
    {
        public override void BuildPartA()
        {
            Product.Add("PartAA");
        }

        public override void BuildPartB()
        {
            Product.Add("PartAB");
        }

        public override void BuildPartC()
        {
            Product.Add("PartAC");
        }
    }
}
