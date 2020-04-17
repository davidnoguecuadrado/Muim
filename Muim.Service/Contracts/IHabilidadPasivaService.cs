
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IHabilidadPasivaService
    {
        public bool AddHabilidadPasiva(HabilidadPasiva habilidadPasiva, int idUsuario);

        public bool DeleteHabilidadPasiva(int id, int idUsuario);

        public List<HabilidadPasiva> GetAllHabilidadPasiva();

        public Dictionary<HabilidadPasiva, int> GetHabilidadPasiva(int id);

        public bool UpdateHabilidadPasiva(HabilidadPasiva habilidadPasiva, int idUsuario);
    }
}
