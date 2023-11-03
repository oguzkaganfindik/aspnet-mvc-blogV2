﻿using App.Business.Services.Abstract;
using App.Persistence.Data;
using App.Persistence.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _db;

        public CategoryService(AppDbContext db)
        {
            _db = db;

        }
        public void DeleteById(int id)
        {
            var category = _db.Category.Find(id);
            if (category != null) _db.Category.Remove(category);
        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Category.Select(e => e);
        }

        public Category GetById(int id)
        {
            return _db.Category.Find(id);
        }

        public void Insert(Category entity)
        {
            _db.Category.Add(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Update(Category entity)
        {
            if (_db.Category.Contains(entity)) _db.Category.Update(entity);
        }

        public List<Post> GetPostsBySearch(string searchString)
        {
            return _db.Post.Where(p => p.PostContext.Contains(searchString) || p.PostTitle.Contains(searchString)).Include(p => p.PostImage).Include(p => p.CategoryPosts).ThenInclude(p => p.Category).ToList();
        }

        public List<CategoryPost> GetPostsByCategoryIndex(int Id)
        {
            return _db.CategoryPost.Where(p => p.CategoryId == Id).Include(c => c.Post).ThenInclude(c => c.PostImage).Include(c => c.Category).ToList();
        }
    }
}