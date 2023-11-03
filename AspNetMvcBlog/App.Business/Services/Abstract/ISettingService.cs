using App.Persistence.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services.Abstract
{
    public interface ISettingService
    {
        Task DeleteByIdAsync(int id);
        Task<IEnumerable<Setting>> GetAllAsync();
        Task<Setting> GetByIdAsync(int id);
        Task InsertAsync(Setting setting);
        Task UpdateAsync(Setting setting);
    }
}
