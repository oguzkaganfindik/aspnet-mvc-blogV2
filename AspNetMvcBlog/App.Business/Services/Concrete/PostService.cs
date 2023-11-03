using App.Business.DTOs.PostDTOs;
using App.Business.Services.Abstract;
using App.Persistence.Data;
using App.Persistence.Data.Entity;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Business.Services
{
    public class PostService : IPostService
    {
        private readonly AppDbContext _db;
        IMapper _mapper;
        public PostService(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public void DeleteById(int id)
        {
            var post = _db.Post.Find(id);
            if (post != null) _db.Post.Remove(post);
        }

        public IEnumerable<Post> GetAll()
        {
            return _db.Post.Select(e => e).Include(e => e.CategoryPosts).ThenInclude(e => e.Category).ToList();
        }

        public Post GetById(int id)
        {

            return _db.Post.Where(a => a.Id == id).Include(a => a.CategoryPosts).FirstOrDefault();
        }

        public string GetCategoryName(int id)
        {
            int categoryId = _db.CategoryPost.FirstOrDefault(p => p.PostId == id).CategoryId;
            return _db.Category.Find(categoryId).CategoryName;
        }

        public void Insert(Post entity)
        {
            entity.UserId = 1;
            _db.Post.Add(entity);
        }

        public void Update(Post entity)
        {
            entity.UserId = 1;
            if (_db.Post.Contains(entity)) _db.Post.Update(entity);
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public IEnumerable<ViewPostDto> GetAllViewPostDtos()
        {
            var posts = GetAll();

            var postsViewDto = new List<ViewPostDto>();

            foreach (var item in posts)
            {
                postsViewDto.Add(_mapper.Map<ViewPostDto>(item));
            }

            return postsViewDto;
        }

        public CreateOrEditPostDto PopulatePostCategories(CreateOrEditPostDto createOrEditPostDto = null)
        {
            var categories = _db.Category.Select(e => e).ToList();
            var newPostDto = new CreateOrEditPostDto();

            if (createOrEditPostDto == null)
            {
                newPostDto.Categories = categories;
                return newPostDto;
            }
            else
            {
                createOrEditPostDto.Categories = categories;
                return createOrEditPostDto;
            }
            //postDto.selectedCategoryIds.Append(0);

        }

        public void InsertCategoryPost(List<int> selectedCategories, Post post)
        {
            foreach (var categoryId in selectedCategories)
            {
                var categoryPost = new CategoryPost() { PostId = post.Id, CategoryId = categoryId };
                _db.CategoryPost.Add(categoryPost);
            }
        }
        public void UpdateCategoryPost(List<int> selectedCategories, Post post)
        {
            var oldCategoryPost = _db.CategoryPost.Where(p => p.PostId == post.Id).ToList();

            foreach (var item in oldCategoryPost)
            {
                _db.CategoryPost.Remove(item);
                _db.SaveChanges();
            }
            foreach (var item in selectedCategories)
            {
                var newCategoryPost = new CategoryPost { CategoryId = item, PostId = post.Id };
                _db.CategoryPost.Add(newCategoryPost);
                _db.SaveChanges();
            }
        }
        public List<int> GetSelectedCategoryIds(int postId)
        {
            return _db.CategoryPost.Where(a => a.PostId == postId).Select(a => a.CategoryId).ToList();
        }
    }
}