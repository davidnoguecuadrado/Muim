
using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Domain.Utils;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserData _dataUser;

        public UserService(IUserData dataUser)
        {
            _dataUser = dataUser;
        }
        public bool AddUser(User user)
        {
            user.Password=Codification.EncodePasswordToBase64(user.Password);
            user.Tipo = 1;
            return _dataUser.AddUser(user);
        }

        public bool DeleteUser(int id)
        {
            return _dataUser.DeleteUser(id);
        }

        public List<User> GetAllUsers()
        {
            return _dataUser.GetAllUsers();
        }

        public User GetUser(int id)
        {
            return _dataUser.GetUser(id);
        }

        public List<User> GwtUserWithPassword(User user)
        {
            user.Password =Codification.EncodePasswordToBase64(user.Password);
            return _dataUser.GwtUserWithPassword(user);
        }

        public bool UpdateUser(User user,int id)
        {
            user.UserId = id;
            user.Password = Codification.EncodePasswordToBase64(user.Password);
            return _dataUser.UpdateUser(user);
        }
    }
}
