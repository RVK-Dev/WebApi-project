using Entity.Models;

namespace Service
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}