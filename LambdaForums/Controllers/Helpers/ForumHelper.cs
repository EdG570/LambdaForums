using LambdaForums.ViewModels.ForumViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaForums.Data.Models;

namespace LambdaForums.Controllers.Helpers
{
    public class ForumHelper
    {
        public ForumListViewModel BuildForumListing(Post post)
        {
            var forum = post.Forum;
            return BuildForumListing(forum);
        }

        public ForumListViewModel BuildForumListing(Forum forum)
        {
            return new ForumListViewModel
            {
                Id = forum.Id,
                Title = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.Imageurl
            };
        }
    }
}
