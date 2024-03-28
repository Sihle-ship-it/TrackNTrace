using API.Entities;

namespace API.Interfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventories();
        void UpdateStock(int productId, int quantity);
        bool CheckStock(int productId);
    }
}
