
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IHabilidadActivaService
    {
        public bool AddHabilidadActiva(HabilidadActiva habilidadActiva, int idUsuario);

        public bool DeleteHabilidadActiva(int id, int idUsuario);

        public List<HabilidadActiva> GetAllHabilidadActiva();

        public HabilidadActiva GetHabilidadActiva(int id);

        public bool UpdateHabilidadActiva(HabilidadActiva habilidadActiva, int idUsuario);
    }
}
