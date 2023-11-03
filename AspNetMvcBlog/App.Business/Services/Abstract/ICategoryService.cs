using App.Persistence.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services.Abstract
{
    public interface ICategoryService
    {
        Task DeleteByIdAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task InsertAsync(Category category);
        Task UpdateAsync(Category category);
    }
}
