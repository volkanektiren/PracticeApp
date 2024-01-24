using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeApp.Models
{
    [Table("As", Schema = "Practice")]
    public class A
    {
        public int Id { get; set; }
        public int Value { get; set; }
    }
}
