using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaForums.Data.Models;
using LambdaForums.Service;
using LambdaForums.ViewModels.PostViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LambdaForums.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index(int id)
        {
            var helper = new Helpers.PostHelper();

            var post = _postService.GetById(id);
            var replies = helper.BuildPostReplies(post.Replies);

            var vm = new PostIndexViewModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorImageUrl = post.User.ProfileImageUrl,
                AuthorRating = post.User.Rating,
                Created = post.Created,
                PostContent = post.Content,
                PostReplies = replies
            };

            return View(vm);
        }
    }
}