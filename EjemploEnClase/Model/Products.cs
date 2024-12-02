using System.ComponentModel.DataAnnotations;

namespace EjemploEnClase.Model
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
    }
}
