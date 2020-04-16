
using Muim.Domain.Models;

namespace Muim.Service.Contracts
{
    public interface IClassCharacterCpacidadesService
    {
        public bool AddPersonajesCapacidades(ClassCharacterCpacidades classCharacterCpacidades);
        public bool DeletePersonajesCapacidades(ClassCharacterCpacidades classCharacterCpacidades);
    }
}
