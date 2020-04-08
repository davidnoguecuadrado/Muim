using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Muim.Data.Contracts;
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Implemention.Unit.Tests
{
    [TestClass()]
    public class UserPartidaTests
    {
        private Mock<IUserPartida> _usePartidaUsuarioData;
        private PartidaUsuario _userPartida;
        private List<PartidaUsuario> _usersPartidas;

        [TestInitialize]
        public void TestInitialize()
        {
            _userPartida = new PartidaUsuario();
            _usersPartidas = new List<PartidaUsuario>();
            _usePartidaUsuarioData = new Mock<IUserPartida>();

            _usePartidaUsuarioData.Setup(p => p.AddUserPartida(It.IsAny<PartidaUsuario>())).Returns(true);
            _usePartidaUsuarioData.Setup(p => p.GetPartidaUsuario(1)).Returns(_usersPartidas);
            _usePartidaUsuarioData.Setup(p => p.DeleteUser(It.IsAny<int>())).Returns(true);

        }
        [TestMethod()]
        public void AddUserPartidaTest()
        {
            var result = _usePartidaUsuarioData.Object.AddUserPartida(_userPartida);
            Assert.IsTrue(result);        
        }

        [TestMethod()]
        public void DeleteUserTest()
        {
            var result = _usePartidaUsuarioData.Object.DeleteUser(1);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void GetPartidaUsuarioTest()
        {
            var userGet = _usePartidaUsuarioData.Object.GetPartidaUsuario(1);
            Assert.IsTrue(userGet.Equals(_usersPartidas));
        }
    }
}