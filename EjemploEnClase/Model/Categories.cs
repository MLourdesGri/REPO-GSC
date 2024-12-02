using System.ComponentModel.DataAnnotations;

namespace EjemploEnClase.Model
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
