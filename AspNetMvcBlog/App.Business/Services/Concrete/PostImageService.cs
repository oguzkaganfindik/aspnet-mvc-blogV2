using App.Business.Services.Abstract;
using App.Persistence.Data;
using App.Persistence.Data.Entity;

namespace App.Business.Services
{
    public class PostImageService : IPostImageService
    {
        private readonly AppDbContext _db;

        public PostImageService(AppDbContext db)
        {
            _db = db;

        }
        public void DeleteById(int id)
        {
            var postImage = _db.PostImage.Find(id);
            if (postImage != null) _db.PostImage.Remove(postImage);
        }

        public IEnumerable<PostImage> GetAll()
        {
            return _db.PostImage.Select(e => e).ToList();
        }

        public PostImage GetById(int id)
        {

            return _db.PostImage.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Insert(PostImage entity)
        {

            _db.PostImage.Add(entity);
        }

        public void Update(PostImage entity)
        {

            if (_db.PostImage.Contains(entity)) _db.PostImage.Update(entity);
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public PostImage GetByPostId(int postId)
        {
            return _db.PostImage.Where(a => a.PostId == postId).FirstOrDefault();
        }
    }
}