
using Muim.Domain.Models;

namespace Muim.Service.Contracts
{
    public interface IPartidaUsuarios
    {
        bool CreatePartida(Partida partida, int idUsuari);
        bool AddTheUser(int idUsuario,Partida partida);
        bool AddAdmin(int idUsuarioAdd, int idAdmin, int IdPartida);

    }
}
