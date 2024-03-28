using API.Entities;

namespace API.Interfaces
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> GetProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
