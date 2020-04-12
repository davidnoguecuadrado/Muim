using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IMagiaPersonajesData
    {
        bool AddMagiaPersonajes(MagiaPersonajes magiaPersonajes);
        List<MagiaPersonajes> GetMagiaPersonajes(int personajeId);
        bool DeleteMagiaPersonajes(MagiaPersonajes magiaPersonajes);
    }
}
