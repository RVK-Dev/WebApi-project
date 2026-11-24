using Entity.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class OrdersService : IOrdersService
    {

        IOrdersReposetory ordersReposetory;
        public OrdersService(IOrdersReposetory ordersReposetory)
        {
            this.ordersReposetory = ordersReposetory;
        }

        public async Task<Order> PostOrder(Order order)
        {
            return await ordersReposetory.PostOrder(order);
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await ordersReposetory.GetOrderById(id);
        }
    }
}
