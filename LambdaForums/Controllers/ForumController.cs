using System;
using System.Linq;
using LambdaForums.Data.Models;
using LambdaForums.Service;
using LambdaForums.ViewModels.ForumViewModels;
using LambdaForums.ViewModels.PostViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LambdaForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForumService _forumService;
        private readonly IPostService _postService;

        public ForumController(IForumService forumService)
        {
            _forumService = forumService;
        }

        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(f => new ForumListViewModel { Id = f.Id, Description = f.Description, Title = f.Title });

            var vm = new ForumIndexViewModel
            {
                ForumList = forums
            };

            return View(vm);
        }

        public IActionResult Topic(int id)
        {
            var helper = new Helpers.ForumHelper();

            var forum = _forumService.GetById(id);
            var posts = forum.Posts;

            var postListings = posts.Select(p => new PostListingViewModel
            {
                Id = p.Id,
                AuthorId = Convert.ToInt32(p.User.Id),
                AuthorName = p.User.UserName,
                AuthorRating = p.User.Rating,
                Title = p.Title,
                DatePosted = p.Created.ToString("MMM dd yyyy"),
                RepliesCount = p.Replies.Count(),
                Forums = helper.BuildForumListing(forum)

            });

            var vm = new ForumTopicViewModel
            {
                Posts = postListings,
                Forum = helper.BuildForumListing(forum)
            };

            return View();
        }
    }
}