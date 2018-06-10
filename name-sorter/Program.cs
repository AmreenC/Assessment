using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace name_sorter
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> WriteTxtLines = new List<string>();
            List<string> ReadTxtLines = new List<string>();

            NameSorting  NameSort = new NameSorting();

            //string ReadFilePath = Path.GetFileName(args[0]);
            string ReadFilePath = Path.GetFullPath(args[0]);
            Console.WriteLine("trying to open file ... " + ReadFilePath + "\n");
            try
            {
                //Read file and store it into List of strings
                ReadTxtLines = File.ReadAllLines(ReadFilePath).ToList();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: File not found - " + e.Message);
            }

            //Sorting List of Names with their Surname/LastNames
            WriteTxtLines = NameSort.SortWithSurname(ReadTxtLines);
            
            //Write Sorted names to file 
            File.WriteAllLines("sorted-names-list.txt", WriteTxtLines);

            Console.Read();
        } //Main

    }//program
    public class NameSorting
    {
        //sorting names with SurName/LastName
        public List<string> SortWithSurname(List<string> RdLines)
        {
            List<string> ReadTxtLines = new List<string>();
            List<string> WriteTxtLines = new List<string>();
            List<string> ReNamedLines = new List<string>();

            //Rename all string in list with Surname first
            ReNamedLines = ReNameSurnameFirst(RdLines);

            //Sort Renamed List
            ReNamedLines.Sort();

            //Rename sorted list to original name and Print it to console
            WriteTxtLines = ReNameSurnameLast(ReNamedLines);

            return WriteTxtLines;
        }//SortWithSurname

        //Rename Strings with Surname first
        public List<string> ReNameSurnameFirst(List<string> RdLines)
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
            return Rename;//Renamed Unsorted List
        }//ReNameSurnameFirst

        //Rename to original string for Sorted List and print string to screen
        public List<string> ReNameSurnameLast(List<string> RdLines)
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
            return Rename; //SortedList
        }//ReNameSurnameLast
    }//NameSorting
}//name-sorter 
