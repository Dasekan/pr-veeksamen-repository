using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prøveeksamen_repository
{
    public interface IWindowRepository
    {
        
        Windows Add(Windows window);

        IEnumerable<Windows> Get(string? modelIncludes = null, string? energyClass = null, string orderBy = null);

        Windows? GetById(int id);

        Windows? Delete(int id);

        Windows? Update(int id, Windows window);
    }
}

