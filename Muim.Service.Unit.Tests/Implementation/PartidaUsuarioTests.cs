using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Service.Implementation.Unit.Tests
{
    [TestClass()]
    public class PartidaUsuarioTests
    {
        private Mock<IPartidaUsuario> _partidaUsuario;
        private Partida _partida;

        [TestInitialize]
        public void TestInitialize()
        {
            _partida = new Partida();
            _partidaUsuario = new Mock<IPartidaUsuario>();

            _partidaUsuario.Setup(p => p.CreatePartida(It.IsAny<Partida>())).Returns(true);
            _partidaUsuario.Setup(p => p.AddAdmin(It.IsAny<int>(), It.IsAny<int>())).Returns(true);
            _partidaUsuario.Setup(p => p.AddTheUser(It.IsAny<int>(),It.IsAny<Partida>())).Returns(true);
          
        }

        [TestMethod()]
        public void AddAdminTest()
        {
            var result = _partidaUsuario.Object.AddTheUser(1, _partida);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void AddTheUserTest()
        {
            var result = _partidaUsuario.Object.AddAdmin(1,1);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CreatePartidaTest()
        {
            var result = _partidaUsuario.Object.CreatePartida(_partida);
            Assert.IsTrue(result);
        }
    }
}