using App.Persistence.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services.Abstract
{
    public interface IPostService
    {
        Task DeleteByIdAsync(int id);
        Task<IEnumerable<Post>> GetAllAsync();
        Task<Post> GetByIdAsync(int id);

        Task<Post> GetByIdAsyncWithImages(int id);


        Task InsertAsync(Post post);
        Task UpdateAsync(Post post);

        Task<PostImage> GetPostImageByIdAsync(int postId);

        Task InsertPostImageAsync(PostImage postImage);

        Task UpdatePostImageAsync(PostImage postImage);

        Task DeletePostImageByIdAsync(int id);

        Task<Post> GetByIdAsyncAllComments(int id);

        Task<PostComment> GetPostCommentByIdAsync(int postId);

        Task InsertPostCommentAsync(PostComment postComment);

        Task UpdatePostCommentAsync(PostComment postComment);

        Task DeletePostCommentByIdAsync(int id);


    }
}
