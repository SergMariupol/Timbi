using System.Collections.Generic;
using Timbi.Data.Models;

namespace Timbi.Data.Interfaces
{
   public interface IAllUserArea
    {
        IEnumerable<Main> Main { get; }
    }
}
