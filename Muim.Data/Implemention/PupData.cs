
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;

namespace Muim.Data.Implemention
{
    public class PupData : IPupData
    {
        private readonly IContextDb _contextDb;
        public PupData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public bool Add(PUP pup) {
            _contextDb.Pup.Add(pup);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
