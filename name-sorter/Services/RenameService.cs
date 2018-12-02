using System;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter.Services
{
    public class RenameService : IRenameService
    {
        //Rename Strings with Surname first
        public IEnumerable<string> SurnameFirst(IEnumerable<string> RdLines)
        {
            List<string> Rename = new List<string>();
            foreach (string Line in RdLines)
            {
                string Last = Line.Split(' ').LastOrDefault();

                if (Line.Length != 0)
                {
                    Rename.Add(Last + ' ' + Line.Remove(Line.LastIndexOf(' ') + 1));
                }
            }
            return Rename;
        }

        //Rename to original string for Sorted List and print string to screen
        public IEnumerable<string> SurnameLast(IEnumerable<string> RdLines)
        {
            List<string> Rename = new List<string>();
            foreach (string Line in RdLines)
            {
                string SurName = Line.Split(' ').FirstOrDefault(); // first word in string

                if (Line.Length != 0)
                {
                    Rename.Add(Line.Substring(Line.IndexOf(' ') + 1) + SurName);
                    Console.WriteLine(Rename[Rename.Count - 1]);    //Print to screen last added string to list
                }
            }
            return Rename;
        }
    }
}
