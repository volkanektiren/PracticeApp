namespace DesignPatterns.Creational.Prototype
{
    public class Person
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public required string Name { get; set; }
        public required IdInfo IdInfo { get; set; }

        public Person ShallowCopy()
            => (Person) this.MemberwiseClone();

        public Person DeepCopy()
        {
            var clone = ShallowCopy();

            clone.IdInfo = new(IdInfo.IdNumber);
            clone.Name = new(Name);
            return clone;
        }

        public static string DisplayValues(Person p)
            => $"Name: {p.Name}, Age: {p.Age}, BirthDate: {p.BirthDate}\n" +
            $"ID#: {p.IdInfo.IdNumber}";
    }
}
