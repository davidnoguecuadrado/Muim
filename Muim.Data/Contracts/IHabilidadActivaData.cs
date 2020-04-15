using Muim.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muim.Data.Contracts
{
    public interface IHabilidadActivaData
    {
        public bool AddHabilidadActiva(HabilidadActiva habilidadActiva);
        public bool DeleteHabilidadActiva(int id);
        public List<HabilidadActiva> GetAllHabilidadActiva();
        public HabilidadActiva GetHabilidadActiva(int id);
        public bool UpdateHabilidadActiva(HabilidadActiva habilidadActiva);
    }
}
