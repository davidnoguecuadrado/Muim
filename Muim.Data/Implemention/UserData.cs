using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data
{
    public class UserData : IUserData
    {
        private readonly IContextDb _contextDb;
        public UserData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public User GetUser(int id)
        {
            var user = _contextDb.Users.Find(id);
            return user;
        }

        public List<User> GwtUserWithPassword(User user)
        {
            var users = _contextDb.Users.Where(x => x.Password == user.Password).Where(x=> x.Name == user.Name).ToList(); 
            return users;
        }


        public bool DeleteUser(int id) 
        {
            var user = _contextDb.Users.Find(id);
            _contextDb.Users.Remove(user);
            _contextDb.SaveChanges();
            return true;
        }
        public List<User>GetAllUsers()
        {
            var users = _contextDb.Users.ToList(); 
            return users;
        }

        public bool AddUser(User user) {
            _contextDb.Users.Add(user);
            _contextDb.SaveChanges();
            return true;
        }

        public bool UpdateUser(User user) {
            _contextDb.Users.Update(user);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
