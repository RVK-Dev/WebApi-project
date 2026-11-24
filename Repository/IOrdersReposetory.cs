using Entity.Models;

namespace Repository
{
    public interface IOrdersReposetory
    {
        Task<Order> PostOrder(Order order);
        Task<Order> GetOrderById(int id);
    }
}