using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter.Services
{
    public interface IFileService
    {
        IEnumerable<string> ReadFile(string filename);
        void WriteFile(IEnumerable<string> writeTxtLines);
    }
}
