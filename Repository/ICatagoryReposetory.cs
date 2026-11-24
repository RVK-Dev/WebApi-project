using Entity.Models;

namespace Repository
{
    public interface ICatagoryReposetory
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}