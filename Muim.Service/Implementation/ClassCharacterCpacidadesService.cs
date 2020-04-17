
using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;

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
            return _classCharacterCpacidadesData.AddPersonajesCapacidades(classCharacterCpacidades);
        }
        public bool DeletePersonajesCapacidades(ClassCharacterCpacidades classCharacterCpacidades)
        {
            return _classCharacterCpacidadesData.DeletePersonajesCapacidades(classCharacterCpacidades);
        }

    }
}
