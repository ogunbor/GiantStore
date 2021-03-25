using GiantStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiantStore.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
