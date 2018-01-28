﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LambdaForums.Data;
using LambdaForums.Data.Models;

namespace LambdaForums.Service
{
    public class ForumService : IForumService
    {
        private readonly ApplicationDbContext _db;

        public ForumService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}