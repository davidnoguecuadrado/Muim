
using Muim.Domain.Models;

namespace Muim.Service.Contracts
{
    public interface IPartidaUsuario
    {
        bool CreatePartida(Partida partida);
        bool AddTheUser(int idUsuario,Partida partida);
        bool AddAdmin(int idUsuarioAdd, int idAdmin);

    }
}
