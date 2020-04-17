using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IPersonajeService
    {
        bool AddPersonaje(Personaje personaje, int idUser, int idPartida);
        bool DeletePersonaje(int id);
        List<Personaje> GetAllPersonaje();
        Personaje GetPersonaje(int id);
        bool UpdatePersonaje(Personaje personaje);
        
    }
}
