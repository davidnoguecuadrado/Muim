
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IClassCharacterCpacidadesData
    {

        public bool AddPersonajesCapacidades(ClassCharacterCapacidades classCharacterCpacidades);
        public bool DeletePersonajesCapacidades(ClassCharacterCapacidades classCharacterCpacidades);
        List<ClassCharacterCapacidades> GetPersonajesCapacidades(int classcharacterId);
    }
}
