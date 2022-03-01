using System.Collections.Generic;
using Timbi.Data.Models;

namespace Timbi.Data.Interfaces
{
   public interface IAllUserArea
    {
        IEnumerable<Main> Main { get; }
        IEnumerable<Region> Region { get; }
        IEnumerable<TypeService> TypeService { get; }
        IEnumerable<Company> Company { get; }

    }
}
