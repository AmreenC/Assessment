using System.Collections.Generic;
using System.Linq;

namespace name_sorter.Services
{
    public class SortingService : ISortingService
    {
       private readonly IRenameService _renameService;

        public SortingService(IRenameService renameService)
        {
            _renameService = renameService;
        }
        public IEnumerable<string> SortWithSurname(IEnumerable<string> RdLines)
        {
            //Rename all string in list with Surname first
            var ReNamedLines = _renameService.SurnameFirst(RdLines);

            //Sort Renamed List
            ReNamedLines.OrderBy(x => x).ToList();

            //Rename sorted list to original name and Print it to console
            var writeTxtLines = _renameService.SurnameLast(ReNamedLines);
            return writeTxtLines;
        }
    }
}
