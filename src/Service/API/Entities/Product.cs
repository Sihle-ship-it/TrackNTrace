using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // navigation properties
        public Inventory Inventory { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
