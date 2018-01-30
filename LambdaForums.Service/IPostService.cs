using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LambdaForums.Data.Models;

namespace LambdaForums.Service
{
    public interface IPostService
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetPostsByForumId(int id);

        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        Task AddReply(PostReply reply);
    }
}
