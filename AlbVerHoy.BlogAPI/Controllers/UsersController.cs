using System.Collections.Generic;
using System.Threading.Tasks;
using AlbVerHoy.BlogAPI.Models;
using AlbVerHoy.BlogAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlbVerHoy.BlogAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController : Controller
    {
        readonly UsersService _usersService;

        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async ValueTask<IEnumerable<User>> GetAllUsersAsync() =>
            await _usersService.GetUsersAsync();

        [HttpGet("{id}")]
        public async ValueTask<User> GetUserByIdAsync(string id) =>
            await _usersService.GetUserByIdAsync(id);

        [HttpPost]
        public async ValueTask<User> CreateUserAsync([FromBody]User user) =>
            await _usersService.CreateUserAsync(user);

        [HttpPut]
        public async ValueTask<User> UpdateUserAsync([FromBody]User user) =>
            await _usersService.UpdateUserAsync(user);

        [HttpDelete("{id}")]
        public void DeleteUserAsync(string id) =>
            _usersService.DeleteUserAsync(id);
    }
}
