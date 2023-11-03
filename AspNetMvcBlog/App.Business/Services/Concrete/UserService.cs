using App.Business.Services.Abstract;
using App.Persistence.Data;
using App.Persistence.Data.Entity;

namespace App.Business.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _db;

        public UserService(AppDbContext db)
        {
            _db = db;

        }
        public void DeleteById(int id)
        {
            var user = _db.User.Find(id);
            if (user != null) _db.User.Remove(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _db.User.Select(e => e);
        }

        public User GetById(int id)
        {
            return _db.User.Find(id);
        }

        public void Insert(User entity)
        {
            _db.User.Add(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Update(User entity)
        {
            if (_db.User.Contains(entity)) _db.User.Update(entity);
        }
    }
}