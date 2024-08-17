using exploringCSharp2.Models;

// (int, string, string, decimal) tuple = (1, "Renan", "Garcia", 1000.00m);

FileRead fileRead = new FileRead();

var (success, fileLines, _) = fileRead.ReadFile("Files/fileToRead.txt");

if (success)
{
  foreach (var line in fileLines)
  {
    Console.WriteLine(line);
  }
  // Console.WriteLine($"There are {lineCount} lines in the file");
}
else
{
  Console.WriteLine("Something went wrong");
}

