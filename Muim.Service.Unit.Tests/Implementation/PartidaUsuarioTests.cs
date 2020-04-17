using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Service.Implementation.Unit.Tests
{
    [TestClass()]
    public class PartidaUsuarioTests
    {
        private Mock<IPartidaUsuarios> _partidaUsuario;
        private Partida _partida;

        [TestInitialize]
        public void TestInitialize()
        {
            _partida = new Partida();
            _partidaUsuario = new Mock<IPartidaUsuarios>();

            _partidaUsuario.Setup(p => p.CreatePartida(It.IsAny<Partida>(),1)).Returns(true);
            _partidaUsuario.Setup(p => p.AddAdmin(It.IsAny<int>(),It.IsAny<int>(), It.IsAny<int>())).Returns(true);
            _partidaUsuario.Setup(p => p.AddTheUser(It.IsAny<int>(),It.IsAny<Partida>())).Returns(true);
          
        }

        [TestMethod()]
        public void AddTheUserTest()
        {
            var result = _partidaUsuario.Object.AddTheUser(1, _partida);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void AddAdminTest()
        {
            var result = _partidaUsuario.Object.AddAdmin(1,1,1);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CreatePartidaTest()
        {
            var result = _partidaUsuario.Object.CreatePartida(_partida,1);
            Assert.IsTrue(result);
        }
    }
}