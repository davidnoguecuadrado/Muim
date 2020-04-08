using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        bool AddUser(User user);
        User GetUser(int id);
        bool UpdateUser(User user,int id);
        bool DeleteUser(int id);
    }
}
