
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

        public bool AddClassCharacterCapacidades(ClassCharacterCapacidades classCharacterCpacidades)
        {
            return _classCharacterCpacidadesData.AddClassCharacterCapacidades(classCharacterCpacidades);
        }
        public bool DeleteClassCharacterCapacidades(ClassCharacterCapacidades classCharacterCpacidades)
        {
            return _classCharacterCpacidadesData.DeleteClassCharacterCapacidades(classCharacterCpacidades);
        }

    }
}
