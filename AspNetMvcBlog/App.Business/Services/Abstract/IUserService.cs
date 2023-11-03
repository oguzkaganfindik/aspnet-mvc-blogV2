using App.Persistence.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services.Abstract
{
    public interface IUserService
    {
        Task DeleteByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task InsertAsync(User user);
        Task UpdateAsync(User user);
    }
}
