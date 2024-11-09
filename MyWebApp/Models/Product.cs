using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }

    }
}
