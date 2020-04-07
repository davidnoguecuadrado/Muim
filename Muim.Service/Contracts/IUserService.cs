using Muim.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
