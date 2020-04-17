
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IHabilidadPasivaData
    {
        public bool AddHabilidadPasiva(HabilidadPasiva habilidadPasiva);

        public bool DeleteHabilidadPasiva(int id);
        public List<HabilidadPasiva> GetAllHabilidadPasiva();

        public HabilidadPasiva GetHabilidadPasiva(int id);

        public bool UpdateHabilidadPasiva(HabilidadPasiva habilidadPasiva);
    }
}
