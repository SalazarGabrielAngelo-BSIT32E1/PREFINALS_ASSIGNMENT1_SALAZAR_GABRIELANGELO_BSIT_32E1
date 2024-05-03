using AuthServer.Core.Model;
using System.Threading.Tasks;

namespace AuthServer.Domain.Repositories
{
    public interface IUserRepositories
    {
        Task<User> GetUserAsync(string username);
        Task<bool> AddUserAsync(User user);
    }
}

