using API.Entities;

namespace API.Interfaces
{
    public interface IOrderDetailsRepository
    {
        OrderDetail GetOrderDetail(int id);
        Task<IEnumerable<OrderDetail>> GetOrderDetails();
        void AddOrderDetail(OrderDetail orderDetail);
    }
}
