using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Muim.Data.Contracts;
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.UnitTests
{
    [TestClass()]
    public class UserDataTests
    {
        private Mock<IUserData> _useData;
        private User _user;
        private List<User> _users;

        [TestInitialize]
        public void TestInitialize()
        {
            _user = new User();
            _users = new List<User>();
            _useData = new Mock<IUserData>();
            
            _useData.Setup(p => p.AddUser(It.IsAny<User>())).Returns(true);
            _useData.Setup(p => p.GetUser(It.IsAny<int>())).Returns(_user);
            _useData.Setup(p => p.DeleteUser(It.IsAny<int>())).Returns(true);
            _useData.Setup(p => p.GetAllUsers()).Returns(_users);
            _useData.Setup(p => p.UpdateUser(It.IsAny<User>())).Returns(true);

        }


        [TestMethod()]
        public void GetUserTest()
        {
            var userGet=_useData.Object.GetUser(1);
            Assert.IsTrue(userGet.Equals(_user)); 
        }

        [TestMethod()]
        public void DeleteUserTest()
        {
            var result = _useData.Object.DeleteUser(1);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void GetAllUsersTest()
        {
            var userGet = _useData.Object.GetAllUsers();
            Assert.IsTrue(userGet.Equals(_users));
        }

        [TestMethod()]
        public void AddUserTest()
        {
            var result = _useData.Object.AddUser(_user);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void UpdateUserTest()
        {
            var result = _useData.Object.UpdateUser(_user);
            Assert.IsTrue(result);
        }
    }
}