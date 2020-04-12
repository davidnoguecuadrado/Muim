

using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IMagiaData
    {
        List<Magia> GetAllMagias();
        bool AddMagia(Magia magia);
        Magia GetMagia(int id);
        bool UpdateMagia(Magia magia);
        bool DeleteMagia(int id);
    }
}
