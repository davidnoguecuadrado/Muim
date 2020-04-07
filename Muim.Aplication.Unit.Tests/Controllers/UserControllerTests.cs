using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Muim.Aplication.Contracts;
using Muim.Domain.Models;
using System;
using System.Collections.Generic;

namespace Muim.Aplication.Controllers.Unit.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        private Mock<IUserController> _useData;
        private User _user;
        private List<User> _users;

        [TestInitialize]
        public void TestInitialize()
        {
            _user = new User();
            _users = new List<User>();
            _useData = new Mock<IUserController>();

            _useData.Setup(p => p.Post(It.IsAny<User>())).Returns(true);
            _useData.Setup(p => p.Get(It.IsAny<int>())).Returns(_user);
            _useData.Setup(p => p.Delete(It.IsAny<int>())).Returns(true);
            _useData.Setup(p => p.Get()).Returns(_users);
            _useData.Setup(p => p.Put(It.IsAny<int>(), It.IsAny<User>())).Returns(true);

        }
        [TestMethod()]
        public void GetUserTest()
        {
            var userGet = _useData.Object.Get(1);
            Assert.IsTrue(userGet.Equals(_user));
        }

        [TestMethod()]
        public void DeleteUserTest()
        {
            var result = _useData.Object.Delete(1);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void GetAllUsersTest()
        {
            var userGet = _useData.Object.Get();
            Assert.IsTrue(userGet.Equals(_users));
        }

        [TestMethod()]
        public void AddUserTest()
        {
            var result = _useData.Object.Post(_user);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void UpdateUserTest()
        {
            var result = _useData.Object.Put(1, _user);
            Assert.IsTrue(result);
        }
    }
}