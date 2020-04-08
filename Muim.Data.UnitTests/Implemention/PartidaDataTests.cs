using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Muim.Data.Contracts;
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Implemention.Unit.Tests
{
    [TestClass()]
    public class PartidaDataTests
    {
        private Mock<IPartidaData> _partidaData;
        private Partida _partida;
        private List<Partida> _partidas;

        [TestInitialize]
        public void TestInitialize()
        {
            _partida = new Partida();
            _partidas = new List<Partida>();
            _partidaData = new Mock<IPartidaData>();

            _partidaData.Setup(p => p.AddPartida(It.IsAny<Partida>())).Returns(true);
            _partidaData.Setup(p => p.GetPartida(It.IsAny<int>())).Returns(_partida);
            _partidaData.Setup(p => p.DeletePartida(It.IsAny<int>())).Returns(true);
            _partidaData.Setup(p => p.GetAllPartida()).Returns(_partidas);
            _partidaData.Setup(p => p.UpdatePartida(It.IsAny<Partida>())).Returns(true);

        }

        [TestMethod()]
        public void GetUserTest()
        {
            var userGet = _partidaData.Object.GetPartida(1);
            Assert.IsTrue(userGet.Equals(_partida));
        }

        [TestMethod()]
        public void DeleteUserTest()
        {
            var result = _partidaData.Object.DeletePartida(1);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void GetAllUsersTest()
        {
            var userGet = _partidaData.Object.GetAllPartida();
            Assert.IsTrue(userGet.Equals(_partidas));
        }

        [TestMethod()]
        public void AddUserTest()
        {
            var result = _partidaData.Object.AddPartida(_partida);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void UpdateUserTest()
        {
            var result = _partidaData.Object.UpdatePartida(_partida);
            Assert.IsTrue(result);
        }
    }
}