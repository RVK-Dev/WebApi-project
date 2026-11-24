using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CatagoryReposetory : ICatagoryReposetory
    {
        StoreExContext db;
        public CatagoryReposetory(StoreExContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await db.Categories.ToListAsync();
        }
    }
}
