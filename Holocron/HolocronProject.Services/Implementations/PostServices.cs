﻿using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class PostServices : IPostService
    {
        private HolocronDbContext context;

        public PostServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreatePostAsync(string description, string accountId, string threadId)
        {
            var post = new Post
            {
                Description = description,
                AccountId = accountId,
                ThreadId = threadId
            };

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();
        } 
    }
}
