using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Service.Implementation
{
    public class PartidaUsuario : IPartidaUsuario
    {
        private readonly IPartidaData _partidaDatar;
        private readonly IUserPartida _userPartida;
        public PartidaUsuario(IPartidaData partidaData, IUserPartida userPartida)
        {
            _partidaDatar = partidaData;
            _userPartida = userPartida;
        }
        public bool AddAdmin(int idUsuarioAdd, int idAdmin)
        {
            throw new System.NotImplementedException();
        }

        public bool AddTheUser(int idUsuario, Partida partida)
        {
            throw new System.NotImplementedException();
        }

        public bool CreatePartida(Partida partida)
        {
            throw new System.NotImplementedException();
        }
    }
}
