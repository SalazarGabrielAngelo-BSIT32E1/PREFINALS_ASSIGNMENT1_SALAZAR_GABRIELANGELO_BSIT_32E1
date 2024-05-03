using AuthServer.Core.Repositories;
using AuthServer.Core.Service;
using System.Threading.Tasks;

namespace AuthServer.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepositories _userRepository;

        public UserServices(IUserRepositories userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> RegisterAsync(string username, string password)
        {
            return true; 
        }

        public async Task<string> AuthenticateAsync(string username, string password)
        {
            return "token";
        }
    }
}


