namespace API.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        // navigation property
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
