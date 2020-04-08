
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class UserPartida : IUserPartida
    {
        private readonly IContextDb _contextDb;
        public UserPartida(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddUserPartida(PartidaUsuario partidauser)
        {
            _contextDb.PartidaUsuario.Add(partidauser);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeleteUser(int id)
        {
            var partida = _contextDb.PartidaUsuario.Find(id);
            _contextDb.PartidaUsuario.Remove(partida);
            _contextDb.SaveChanges();
            return true;
        }

        public List<PartidaUsuario> GetPartidaUsuario(int id)
        {
            var partida = _contextDb.PartidaUsuario.Where(x => x.UserId == id).ToList();
            return partida;    
        }


    }
}
