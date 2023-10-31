using System;
using System.Collections.Generic;
using System.Text;
using AdityaBooks.Models;

namespace AdityaBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
