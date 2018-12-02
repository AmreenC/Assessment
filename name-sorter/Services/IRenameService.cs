using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter.Services
{
    public interface IRenameService
    {
        IEnumerable<string> SurnameFirst(IEnumerable<string> RdLines);
        IEnumerable<string> SurnameLast(IEnumerable<string> RdLines);
    }
}
