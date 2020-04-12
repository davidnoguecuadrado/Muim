using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IMagiaPersonajesService
    {
        bool AddMagiaPersonajes(MagiaPersonajes magiaPersonajes);
        List<MagiaPersonajes> GetMagiaPersonajes(int personajeId);
        bool DeleteMagiaPersonajes(MagiaPersonajes magiaPersonajes);
    }
}
