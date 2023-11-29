namespace DesignPatterns.Creational.Builder
{
    public class Product
    {
        private List<object> _parts = [];

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            var str = string.Join(", ", _parts);

            return "Product parts: " + str + "\n";
        }
    }
}
