using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbVerHoy.BlogAPI.Models;
using AlbVerHoy.BlogAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlbVerHoy.BlogAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PostsController : Controller
    {
        readonly PostsService _postsService;

        public PostsController(PostsService usersService)
        {
            _postsService = usersService;
        }

        [HttpGet]
        public async ValueTask<IEnumerable<Post>> GetPostsAsync() =>
            await _postsService.GetPostsAsync();

        [HttpGet("{id}")]
        public async ValueTask<Post> GetUserByIdAsync(string id) =>
            await _postsService.GetPostByIdAsync(id);

        [HttpPost]
        public async ValueTask<Post> CreateUserAsync([FromBody]Post post) =>
            await _postsService.CreatePostAsync(post);

        [HttpPut]
        public async ValueTask<Post> UpdateUserAsync([FromBody]Post post) =>
            await _postsService.UpdatePostsAsync(post);

        [HttpDelete("{id}")]
        public void DeleteUserAsync(string id) =>
            _postsService.DeletePostAsync(id);
    }
}
