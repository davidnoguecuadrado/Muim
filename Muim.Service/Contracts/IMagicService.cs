

using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IMagicService
    {
        List<Magia> GetAllMagia();
        bool AddMagia(Magia user, int idUsuario);
        Magia GetMagia(int id);
        bool UpdateMagia(Magia user, int idUsuario);
        bool DeleteMagia(int id, int idUsuario);
    }
}
