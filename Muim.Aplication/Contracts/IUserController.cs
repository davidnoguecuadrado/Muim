
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Aplication.Contracts
{
    public interface IUserController
    {
        List<User> Get();
        public User Get(int id);
        public bool Post(User user);
        public bool Put(int id, User user);
        public bool Delete(int id);
    }
}
