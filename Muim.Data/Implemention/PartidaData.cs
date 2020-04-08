
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Implemention
{
    public class PartidaData : IPartidaData
    {
        private readonly IContextDb _contextDb;
        public PartidaData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddPartida(Partida partida)
        {
            _contextDb.Partidas.Add(partida);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeletePartida(int id)
        {
            var partida = _contextDb.Partidas.Find(id);
            _contextDb.Users.Remove(partida);
            _contextDb.SaveChanges();
            return true;
        }

        public List<Partida> GetAllPartida()
        {
            throw new System.NotImplementedException();
        }

        public bool UpdatePartida(Partida user)
        {
            throw new System.NotImplementedException();
        }

        public List<Partida> GetPartida(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
