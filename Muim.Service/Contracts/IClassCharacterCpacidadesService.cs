
using Muim.Domain.Models;

namespace Muim.Service.Contracts
{
    public interface IClassCharacterCpacidadesService
    {
        public bool AddPersonajesCapacidades(ClassCharacterCapacidades classCharacterCpacidades);
        public bool DeletePersonajesCapacidades(ClassCharacterCapacidades classCharacterCpacidades);
    }
}
