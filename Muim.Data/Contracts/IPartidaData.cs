using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IPartidaData
    {
        List<Partida> GetAllPartida();
        Partida AddPartida(Partida partida);
        Partida GetPartida(int id);
        Partida AddPartidaPassword(string password, int idPartida);
        bool UpdatePartida(Partida partida);
        bool DeletePartida(int id);
    }
}
