using System.Collections.Generic;
using System.Threading.Tasks;
using AlbVerHoy.BlogAPI.Models;
using Microsoft.Azure.CosmosRepository;

namespace AlbVerHoy.BlogAPI.Services
{
    public class UsersService
    {
        readonly IRepository<User> _userRepository;

        public UsersService(IRepository<User> userRepository) =>
            _userRepository = userRepository;

        public async ValueTask<IEnumerable<User>> GetUsersAsync() =>
            await _userRepository.GetByQueryAsync("SELECT * FROM u " +
                "WHERE u.type = 'User'");

        public async ValueTask<User> GetUserByIdAsync(string id) =>
            await _userRepository.GetAsync(id);

        public async ValueTask<User> CreateUserAsync(User user) =>
            await _userRepository.CreateAsync(user);

        public async ValueTask<User> UpdateUserAsync(User user) =>
            await _userRepository.UpdateAsync(user);

        public async void DeleteUserAsync(string id) =>
            await _userRepository.DeleteAsync(id);
    }
}
