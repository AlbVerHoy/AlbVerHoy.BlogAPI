using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AlbVerHoy.BlogAPI.Models;
using Microsoft.Azure.CosmosRepository;

namespace AlbVerHoy.BlogAPI.Services
{
    public class PostsService
    {
        readonly IRepository<Post> _postsService;

        public PostsService(IRepository<Post> postsService) =>
            _postsService = postsService;

        public async ValueTask<IEnumerable<Post>> GetPostsAsync() =>
            await _postsService.GetByQueryAsync("SELECT * FROM u " +
                "WHERE u.type = 'Post'");

        public async ValueTask<Post> GetPostByIdAsync(string id) =>
            await _postsService.GetAsync(id);

        public async ValueTask<Post> CreatePostAsync(Post post) =>
            await _postsService.CreateAsync(post);

        public async ValueTask<Post> UpdatePostsAsync(Post post) =>
            await _postsService.UpdateAsync(post);

        public async void DeletePostAsync(string id) =>
            await _postsService.DeleteAsync(id);
    }
}
