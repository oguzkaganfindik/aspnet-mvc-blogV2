using App.Persistence.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services.Abstract
{
    public interface IPageService
    {
        Task DeleteByIdAsync(int id);
        Task<IEnumerable<Page>> GetAllAsync();
        Task<Page> GetByIdAsync(int id);
        Task InsertAsync(Page page);
        Task UpdateAsync(Page page);
    }
}
