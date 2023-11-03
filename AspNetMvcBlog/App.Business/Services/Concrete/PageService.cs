using App.Business.Services.Abstract;
using App.Persistence.Data;
using App.Persistence.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services.Concrete
{
    public class PageService : IPageService
    {
        private readonly AppDbContext _context;

        public PageService(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task DeleteByIdAsync(int id)
        {
            Page entityToDelete = await _context.Set<Page>().FindAsync(id);
            if (entityToDelete != null)
            {
                _context.Set<Page>().Remove(entityToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Page>> GetAllAsync()
        {
            return await _context.Set<Page>().ToListAsync();
        }

        public async Task<Page> GetByIdAsync(int id)
        {
            return await _context.Set<Page>().FindAsync(id);
        }

        public async Task InsertAsync(Page page)
        {
            await _context.Set<Page>().AddAsync(page);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Page page)
        {
            _context.Update(page);
            await _context.SaveChangesAsync();
        }
    }
}
