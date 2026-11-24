using Entity.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        ICatagoryReposetory catagoryReposetory;
        public CategoryService(ICatagoryReposetory catagoryReposetory)
        {
            this.catagoryReposetory = catagoryReposetory;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await catagoryReposetory.GetCategories();
        }

    }
}
