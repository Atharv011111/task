using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Task1.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        [JsonIgnore]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
