namespace DesignPatterns.Creational.Builder
{
    public static class Director
    {
        public static void BuildMinimalValuableProduct(AbstractBuilder builder)
        {
            builder.BuildPartA();
        }

        public static void BuildFullFeaturedProduct(AbstractBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
