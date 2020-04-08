
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IUserPartida
    {
        bool AddUserPartida(PartidaUsuario partidauser);
        bool DeleteUser(int id);
        List<PartidaUsuario> GetPartidaUsuario(int id);

    }
}
