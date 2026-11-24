using Entity.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ProductsService : IProductsService
    {
        IProductsReposetory productsReposetory;

        public ProductsService(IProductsReposetory ProductsReposetory)
        {
            this.productsReposetory = ProductsReposetory;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await productsReposetory.GetProductsAsync();
        }

    }
}
