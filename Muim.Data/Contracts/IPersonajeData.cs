using Muim.Domain.Models;
using System.Collections.Generic;


namespace Muim.Data.Contracts
{
    public interface IPersonajeData
    {
        List<Personaje> GetAllPersonaje();
        Personaje AddPersonaje(Personaje personaje);
        Personaje GetPersonaje(int id);
        bool UpdatePersonaje(Personaje personaje);
        bool DeletePersonaje(int id);
    }
}
