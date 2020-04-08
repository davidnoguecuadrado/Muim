using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IPartidaData
    {
        List<Partida> GetAllPartida();
        bool AddPartida(Partida partida);
        List<Partida> GetPartida(int id);
        bool UpdatePartida(Partida user);
        bool DeletePartida(int id);
    }
}
