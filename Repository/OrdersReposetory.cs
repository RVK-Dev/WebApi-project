using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class OrdersReposetory : IOrdersReposetory
    {
        StoreExContext db;
        public OrdersReposetory(StoreExContext StoreExContext)
        {
            db = StoreExContext;
        }
        public async Task<Order> PostOrder(Order order)
        {
            await db.Orders.AddAsync(order);
            await db.SaveChangesAsync();
            return order;
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await db.Orders.FindAsync(id);
        }

    }
}
