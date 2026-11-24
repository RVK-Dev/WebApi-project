using Entity.Models;

namespace Service
{
    public interface IOrdersService
    {
        Task<Order> PostOrder(Order order);
        Task<Order> GetOrderById(int id);
    }
}