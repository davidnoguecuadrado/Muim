using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Muim.Data.Contracts;
using Muim.Domain.Models;

namespace Muim.Data.UnitTests
{
    [TestClass()]
    public class UserDataTests
    {
        private Mock<IUserData> _useData;
        private User _user;

        [TestInitialize]
        public void TestInitialize()
        {
            _user = new User();
            _useData = new Mock<IUserData>();
            
            _useData.Setup(p => p.AddUser(It.IsAny<User>())).Returns(true);


        }


        [TestMethod()]
        public void GetUserTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteUserTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllUsersTest()
        {
            Assert.Fail();
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
            Assert.Fail();
        }
    }
}