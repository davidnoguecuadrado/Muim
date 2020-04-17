
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IClassCharacterCpacidadesData
    {

        public bool AddPersonajesCapacidades(ClassCharacterCpacidades classCharacterCpacidades);
        public bool DeletePersonajesCapacidades(ClassCharacterCpacidades classCharacterCpacidades);
        List<ClassCharacterCpacidades> GetPersonajesCapacidades(int classcharacterId);
    }
}
