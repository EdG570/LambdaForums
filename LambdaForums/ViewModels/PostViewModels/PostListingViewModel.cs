using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaForums.ViewModels.ForumViewModels;

namespace LambdaForums.ViewModels.PostViewModels
{
    public class PostListingViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AuthorRating { get; set; }
        public int AuthorId { get; set; }
        public DateTime DatePosted { get; set; }

        public ForumListViewModel Forums { get; set; }

        public int RepliesCount { get; set; }   
    }
}
