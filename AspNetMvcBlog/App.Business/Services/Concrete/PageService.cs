using App.Business.Services.Abstract;
using App.Persistence.Data;
using App.Persistence.Data.Entity;

namespace App.Business.Services
{
	public class PageService : IPageService
	{
		private readonly AppDbContext _db;

		public PageService(AppDbContext db)
		{
			_db = db;

		}
		public void DeleteById(int id)
		{
			var page = _db.Page.Find(id);
			if (page != null) _db.Page.Remove(page);
		}

		public IEnumerable<Page> GetAll()
		{
			return _db.Page.Select(e => e);
		}

		public Page GetById(int id)
		{
			return _db.Page.Find(id);
		}

		public void Insert(Page entity)
		{
			_db.Page.Add(entity);
		}

		public void SaveChanges()
		{
			_db.SaveChanges();
		}

		public void Update(Page entity)
		{
			if (_db.Page.Contains(entity)) _db.Page.Update(entity);
		}
	}
}