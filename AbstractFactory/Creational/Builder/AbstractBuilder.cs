namespace DesignPatterns.Creational.Builder
{
    public abstract class AbstractBuilder
    {
        protected Product Product { get; set; } = new();

        public void Reset()
        {
            Product = new();
        }

        public Product GetProduct()
        {
            Product result = Product;

            Reset();

            return result;
        }

        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract void BuildPartC();
    }
}
