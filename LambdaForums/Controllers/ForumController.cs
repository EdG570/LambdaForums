using System.Linq;
using LambdaForums.Service;
using LambdaForums.ViewModels.ForumViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LambdaForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForumService _forumService;

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

        public IActionResult Topic()
        {
            throw new System.NotImplementedException();
        }
    }
}