
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

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
            _contextDb.Partidas.Remove(partida);
            _contextDb.SaveChanges();
            return true;
        }

        public List<Partida> GetAllPartida()
        {
            var users = _contextDb.Partidas.ToList();
            return users;
        }

        public bool UpdatePartida(Partida partida)
        {
            _contextDb.Partidas.Update(partida);
            _contextDb.SaveChanges();
            return true;
        }

        public Partida GetPartida(int id)
        {
            var partida = _contextDb.Partidas.Find(id);
            return partida;
        }
    }
}
