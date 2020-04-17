
using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class ClassCharacterCpacidadesService : IClassCharacterCpacidadesService
    {
        private readonly IClassCharacterCpacidadesData _classCharacterCpacidadesData;

        public ClassCharacterCpacidadesService(IClassCharacterCpacidadesData classCharacterCpacidadesData)
        {
            _classCharacterCpacidadesData = classCharacterCpacidadesData;

        }

        public bool AddPersonajesCapacidades(ClassCharacterCpacidades classCharacterCpacidades)
        {
            return _classCharacterCpacidadesData.AddPersonajeHabilidadActiva(classCharacterCpacidades);
        }
        public bool DeletePersonajesCapacidades(ClassCharacterCpacidades classCharacterCpacidades)
        {
            return _classCharacterCpacidadesData.DeletePersonajeHabilidadActiva(classCharacterCpacidades);
        }

    }
}
