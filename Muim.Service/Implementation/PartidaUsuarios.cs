using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Domain.Utils;
using Muim.Service.Contracts;
using System.Linq;

namespace Muim.Service.Implementation
{
    public class PartidaUsuarios : IPartidaUsuarios
    {
        private readonly IPartidaData _partidaData;
        private readonly IUserPartida _userPartida;
        public PartidaUsuarios(IPartidaData partidaData, IUserPartida userPartida)
        {
            _partidaData= partidaData;
            _userPartida = userPartida;
        }
        public bool AddAdmin(int idUsuarioAdd, int idAdmin, int IdPartida)
        {
            var userPartida=_userPartida.GetPartidaUsuario(idAdmin).Where(x=> x.PartidaId == IdPartida).First();
            if (userPartida.Rol == 0)
            {
                PartidaUsuario pu = new PartidaUsuario();
                pu.Rol = 1;
                pu.PartidaId = IdPartida;
                pu.UserId = idUsuarioAdd;
                _userPartida.AddUserPartida(pu);
                return true;
            }
            else {
                return false;
            }
        }

        public bool AddTheUser(int idUsuario, Partida partida)
        {
            var part = _partidaData.AddPartidaPassword(Codification.EncodePasswordToBase64(partida.Password),partida.Name);
            if (part != null)
            {
                PartidaUsuario pu = new PartidaUsuario();
                pu.Rol = 1;
                pu.PartidaId = part.PartidaId;
                pu.UserId = idUsuario;
                _userPartida.AddUserPartida(pu);
                return true;
            }
            else {
                return false;
            }
        }

        public bool CreatePartida(Partida partida,int idUsuari)
        {
            partida.Password = Codification.EncodePasswordToBase64(partida.Password);
           var part = _partidaData.AddPartida(partida);
           PartidaUsuario pu = new PartidaUsuario();
           pu.Rol = 0;
           pu.PartidaId = part.PartidaId;
           pu.UserId = idUsuari;
           _userPartida.AddUserPartida(pu);
           return true;
        }
    }
}
