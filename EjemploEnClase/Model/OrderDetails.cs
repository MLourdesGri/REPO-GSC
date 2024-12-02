using System.ComponentModel.DataAnnotations;

namespace EjemploEnClase.Model
{
    public class OrderDetails
    {

        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
