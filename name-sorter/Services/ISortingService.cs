using System.Collections.Generic;

namespace name_sorter.Services
{
    public interface ISortingService
    {
        IEnumerable<string> SortWithSurname(IEnumerable<string> RdLines);
    }
}
