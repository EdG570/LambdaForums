using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaForums.ViewModels.PostViewModels;

namespace LambdaForums.ViewModels.ForumViewModels
{
    public class ForumTopicViewModel
    {
        public ForumListViewModel Forums { get; set; }
        public IEnumerable<PostListingViewModel> Posts { get; set; }
    }
}
