
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IUserData
    {
        List<User> GetAllUsers();
        bool AddUser(User user);
        User GetUser(int id);
        bool UpdateUser(User user);
        bool DeleteUser(int id);

    }
}
