using System;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using NUnit.Framework;

using HolocronProject.Data;
using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Posts;
using HolocronProject.Services.Implementations;

using Microsoft.EntityFrameworkCore;

namespace HolocronProject.Tests.Services
{
    public class PostServiceTests
    {
        private ApplicationDbContext context;
        private IPostsService postsService;
        private IMapper mapper;

        [SetUp]
        public async Task SetUp()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this.context = new ApplicationDbContext(optionsBuilder);
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

            this.postsService = new PostsService(context);

            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Post, PostViewModel>();
            });

            this.mapper = config.CreateMapper();

        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreatePostCreatesPost()
        {
            var account = new Account
            {
                Id = "1"
            };

            var thread = new Thread
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.Threads.AddAsync(thread);
            await this.context.SaveChangesAsync();

            await this.postsService.CreatePostAsync("Test", "1", "1");

            var postCount = this.postsService.TotalPosts();

            Assert.AreEqual(1, postCount);
        }

        [Test]
        public async Task DeletePostAsyncDeletesPost()
        {
            var post = new Post
            {
                Id = "1",
                IsDeleted = false
            };

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();

            await this.postsService.DeletePostAsync("1");

            Assert.True(post.IsDeleted);
        }

        [Test]
        public async Task EditPostByIdEditsPosts()
        {
            var post = new Post
            {
                Id = "1",
                Description = "OldDesc",
                IsDeleted = false
            };

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();

            await this.postsService.EditPostByIdAsync("1", "NewDesc");

            Assert.AreEqual("NewDesc", post.Description);
        }

        [Test]
        public async Task GetAllPostsReturnsAllPosts()
        {
            var post = new Post
            {
                Id = "1",
                Description = "OldDesc",
                IsDeleted = false,
                Account = new Account { Id = "1" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "1"}
            };

            var secondPost = new Post
            {
                Id = "2",
                Description = "OldDesc",
                IsDeleted = true,
                Account = new Account { Id = "2" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "2" }
            };

            await this.context.Posts.AddAsync(post);
            await this.context.Posts.AddAsync(secondPost);
            await this.context.SaveChangesAsync();

            var mappedEntity =  this.postsService.GetAllPosts<PostViewModel>(this.mapper);

            Assert.AreEqual(2, mappedEntity.Count());
        }

        [Test]
        public async Task GetLastNotDeletedByAccountIdShouldReturnLastByAccountIdNotDeleted()
        {
            var post = new Post
            {
                Id = "1",
                Description = "OldDesc",
                IsDeleted = false,
                Account = new Account { Id = "1" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "1" }
            };

            var secondPost = new Post
            {
                Id = "2",
                Description = "OldDesc",
                IsDeleted = true,
                Account = new Account { Id = "2" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "2" }
            };

            await this.context.Posts.AddAsync(post);
            await this.context.Posts.AddAsync(secondPost);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postsService.GetLastNotDeletedPostsByAccountId<PostViewModel>("1", this.mapper);

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetLastNotDeletedByAccountIdShouldReturnNothingBecauseAllAreDeleted()
        {
            var post = new Post
            {
                Id = "1",
                Description = "OldDesc",
                IsDeleted = true,
                Account = new Account { Id = "1" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "1" }
            };

            var secondPost = new Post
            {
                Id = "2",
                Description = "OldDesc",
                IsDeleted = true,
                Account = new Account { Id = "2" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "2" }
            };

            await this.context.Posts.AddAsync(post);
            await this.context.Posts.AddAsync(secondPost);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postsService.GetLastNotDeletedPostsByAccountId<PostViewModel>("1", this.mapper);

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetNotDeletedPostByIdShouldReturnCorrectMappedEntity()
        {
            var post = new Post
            {
                Id = "1",
                Description = "OldDesc",
                IsDeleted = false,
                Account = new Account { Id = "1" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "1" }
            };

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postsService.GetNotDeletedPostById<PostViewModel>("1", this.mapper);

            Assert.AreEqual(post.Id, mappedEntity.Id);
        }

        [Test]
        public async Task TotalPostsShouldReturnAllPostsCount()
        {
            var post = new Post
            {
                Id = "1",
                Description = "OldDesc",
                IsDeleted = false,
                Account = new Account { Id = "1" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "1" }
            };

            var secondPost = new Post
            {
                Id = "2",
                Description = "OldDesc",
                IsDeleted = true,
                Account = new Account { Id = "2" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "2" }
            };

            await this.context.Posts.AddAsync(post);
            await this.context.Posts.AddAsync(secondPost);
            await this.context.SaveChangesAsync();

            var totalNotDeletedPosts = this.postsService.TotalPosts();

            Assert.AreEqual(2, totalNotDeletedPosts);
        }

        [Test]
        public async Task TotalNotDeletedPostsInThreadShouldReturnCorrectCount()
        {
            var post = new Post
            {
                Id = "1",
                Description = "OldDesc",
                IsDeleted = false,
                Account = new Account { Id = "1" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "1" }
            };

            await this.context.Posts.AddAsync(post);

            var secondPost = new Post
            {
                Id = "2",
                Description = "OldDesc",
                IsDeleted = true,
                Account = new Account { Id = "2" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = this.context.Threads.FirstOrDefault(x => x.Id == "1")
            };

            await this.context.Posts.AddAsync(secondPost);
            await this.context.SaveChangesAsync();

            var totalNotDeletedPosts = this.postsService.TotalNotDeletedPostInThread("1");

            Assert.AreEqual(1, totalNotDeletedPosts);
        }

        [Test]
        public async Task DeleteAllPostsByAccountIdDeletesAllPostsByAccountId()
        {
            var post = new Post
            {
                Id = "1",
                Description = "OldDesc",
                IsDeleted = false,
                Account = new Account { Id = "1" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = new Thread { Id = "1" }
            };

            await this.context.Posts.AddAsync(post);

            var secondPost = new Post
            {
                Id = "2",
                Description = "OldDesc",
                IsDeleted = false,
                Account = new Account { Id = "2" },
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Thread = this.context.Threads.FirstOrDefault(x => x.Id == "1")
            };

            await this.context.Posts.AddAsync(secondPost);
            await this.context.SaveChangesAsync();

            await this.postsService.DeleteAllPostsByAccountIdAsync("1");

            Assert.True(post.IsDeleted);
            Assert.False(secondPost.IsDeleted);
        }
    }
}
