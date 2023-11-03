using App.Business.Services.Abstract;
using App.Persistence.Data;
using App.Persistence.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Business.Services
{
    public class PostCommentService : IPostCommentService
    {
        private readonly AppDbContext _db;

        public PostCommentService(AppDbContext db)
        {
            _db = db;

        }

        public void DeleteById(int id)
        {
            var postComment = _db.PostComment.Find(id);
            if (postComment != null) _db.PostComment.Remove(postComment);
        }

        public IEnumerable<PostComment> GetAll()
        {
            return _db.PostComment.Select(e => e).ToList();
        }

        public PostComment GetById(int id)
        {

            return _db.PostComment.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Insert(PostComment entity)
        {

            _db.PostComment.Add(entity);
        }

        public void Update(PostComment entity)
        {

            if (_db.PostComment.Contains(entity)) _db.PostComment.Update(entity);
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public IEnumerable<PostComment> GetAllByPostId(int postId)
        {
            return _db.PostComment.Where(e => e.PostId == postId).ToList();
        }
    }
}