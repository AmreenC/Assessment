using name_sorter.Services;
using System.Collections.Generic;

namespace name_sorter
{
    public class Sort : ISort
    {
        private readonly ISortingService _sortingService;
        private readonly IFileService _fileService;

        public Sort(ISortingService sortingService, IFileService fileService)
        {
            _sortingService = sortingService;
            _fileService = fileService;
        }

        public void Run(string filename)
        {
            IEnumerable<string> ReadTxtLines = _fileService.ReadFile(filename);
            var writeTxtLines = _sortingService.SortWithSurname(ReadTxtLines);
            _fileService.WriteFile(writeTxtLines);
        }
    }
}
