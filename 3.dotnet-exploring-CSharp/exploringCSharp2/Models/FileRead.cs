using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploringCSharp2.Models
{
    public class FileRead
    {
        public (bool success, string[] lines, int linesCount) ReadFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }


        }
    }
}