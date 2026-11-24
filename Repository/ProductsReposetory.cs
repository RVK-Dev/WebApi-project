using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ProductsReposetory : IProductsReposetory
    {
        StoreExContext _dbContent;
        public ProductsReposetory(StoreExContext StoreExContext)
        {
            _dbContent = StoreExContext;
        }
     

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _dbContent.Products.ToListAsync();
        }



    }
}
