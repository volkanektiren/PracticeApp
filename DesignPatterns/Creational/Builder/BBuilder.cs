namespace DesignPatterns.Creational.Builder
{
    public class BBuilder : AbstractBuilder
    {
        public override void BuildPartA()
        {
            Product.Add("PartBA");
        }

        public override void BuildPartB()
        {
            Product.Add("PartBB");
        }

        public override void BuildPartC()
        {
            Product.Add("PartBC");
        }
    }
}
