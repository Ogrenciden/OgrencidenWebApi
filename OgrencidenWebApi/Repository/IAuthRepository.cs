using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OgrencidenWebApi.Models;

namespace OgrencidenWebApi.Repository
{
    public interface IAuthRepository
    {
        Task<User> RegisterUser(User user, string password);
        Task<User> Login(string eMail, string password);
        Task<bool> UserExists(string eMail);
    }
}
