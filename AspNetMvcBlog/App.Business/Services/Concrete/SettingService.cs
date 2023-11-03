using App.Business.DTOs.Setting;
using App.Business.Services.Abstract;
using App.Persistence.Data;
using App.Persistence.Data.Entity;

namespace App.Business.Services
{
    public class SettingService : ISettingService
    {
        private readonly AppDbContext _db;

        public SettingService(AppDbContext db)
        {
            _db = db;
        }
        public void DeleteById(int id)
        {
            var setting = _db.Setting.Find(id);
            if (setting != null) _db.Setting.Remove(setting);
        }

        public IEnumerable<Setting> GetAll()
        {
            return _db.Setting.Select(e => e);
        }

        public IEnumerable<ViewSettingDto> GetAllByUserNames()
        {
            var viewSettingDtos = new List<ViewSettingDto>();

            var settings = _db.Setting.Select(e => e).ToList();

            foreach (var item in settings)
            {
                viewSettingDtos.Add(new ViewSettingDto { Id = item.Id, DarkMode = item.DarkMode, UserName = _db.User.FirstOrDefault(a => a.Id == item.Id).UserName });
            }
            return viewSettingDtos;
        }

        public Setting GetById(int id)
        {
            return _db.Setting.FirstOrDefault(a => a.Id == id);
        }

        public void Insert(Setting entity)
        {
            _db.Setting.Add(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Update(Setting entity)
        {
            if (_db.Setting.Contains(entity)) _db.Setting.Update(entity);
        }
    }
}