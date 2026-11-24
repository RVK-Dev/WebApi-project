using Entity.Models;

namespace Repository
{
    public interface IProductsReposetory
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}