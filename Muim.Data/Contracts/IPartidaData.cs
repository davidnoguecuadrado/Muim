using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IPartidaData
    {
        List<Partida> GetAllPartida();
        bool AddPartida(Partida partida);
        Partida GetPartida(int id);
        bool UpdatePartida(Partida partida);
        bool DeletePartida(int id);
    }
}
