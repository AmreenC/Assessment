using System;
using System.Collections.Generic;
using System.IO;

namespace name_sorter.Services
{
    public class FileService : IFileService
    {
        public IEnumerable<string> ReadFile(string filename)
        {
            string ReadFilePath = Path.GetFullPath(filename);

            //Read file and store it into List of strings
            try
            {
                return File.ReadAllLines(ReadFilePath);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File '{filename}' Not Found");
                throw new FileNotFoundException("File not found.", e);
            }
        }

        public void WriteFile(IEnumerable<string> writeTxtLines)
        {
            File.WriteAllLines("sorted-names-list.txt", writeTxtLines);
        }
    }
}
