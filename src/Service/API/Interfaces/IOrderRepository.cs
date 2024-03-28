using API.Entities;

namespace API.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetOrders();
        void PlaceOrder(Order order);
        void CancelOrder(int orderId);
    }
}
