
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;

namespace Muim.Data.Implemention
{
    public class ClassCharacterCpacidadesData : IClassCharacterCpacidadesData
    {
        private readonly IContextDb _contextDb;
        public ClassCharacterCpacidadesData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public bool AddPersonajeHabilidadActiva(ClassCharacterCpacidades classCharacterCpacidades)
        {
            _contextDb.ClassCharacterCpacidades.Add(classCharacterCpacidades);
            return true;
        }
        public bool DeletePersonajeHabilidadActiva(ClassCharacterCpacidades classCharacterCpacidades)
        {
            _contextDb.ClassCharacterCpacidades.Remove(classCharacterCpacidades);
            return true;
        }
    }
}
