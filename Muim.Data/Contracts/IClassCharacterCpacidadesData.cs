
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IClassCharacterCpacidadesData
    {

        public bool AddClassCharacterCapacidades(ClassCharacterCapacidades classCharacterCpacidades);
        public bool DeleteClassCharacterCapacidades(ClassCharacterCapacidades classCharacterCpacidades);
        List<ClassCharacterCapacidades> GetClassCharacterCapacidades(int classcharacterId);
    }
}
