using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdaForums.Data;
using LambdaForums.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LambdaForums.Service
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _db;

        public PostService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task Add(Post post)
        {
            throw new NotImplementedException();
        }

        public Task AddReply(PostReply reply)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByForumId(int id)
        {
            return _db.Posts.Include(p => p.Replies).ThenInclude(r => r.User)
                        .Include(p => p.User)
                        .Where(p => p.Forum.Id == id)
                        .ToList();
        }
    }
}
