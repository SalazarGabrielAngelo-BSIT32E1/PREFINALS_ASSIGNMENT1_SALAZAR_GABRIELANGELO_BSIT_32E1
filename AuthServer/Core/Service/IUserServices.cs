//namespace AuthServer.Core.Service;

//using System;
//using System.Threading.Tasks;

//    public class IUserServices
//    {
//    internal async Task<bool> RegisterAsync(string username, string password)
//    {
//        throw new NotImplementedException();
//    }

//    public interface IUserServices
//    {
//        Task<bool> RegisterAsync(string username, string password);
//        Task<string> AuthenticateAsync(string username, string password);
//    }
//}
using System.Threading.Tasks;

namespace AuthServer.Core.Service
{
    public interface IUserServices
    {
        Task<bool> RegisterAsync(string username, string password);
        Task<string> AuthenticateAsync(string username, string password);
    }
}

