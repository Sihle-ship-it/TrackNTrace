using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Inventory
    {
        [Key]
        public int ProductId { get; set; }
        public int StockAvailable { get; set; }
        public Product Product { get; set; }
    }
}
