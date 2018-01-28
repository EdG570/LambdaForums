using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LambdaForums.Data.Models;

namespace LambdaForums.Service
{
    public interface IForumService
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int id);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
    }
}
