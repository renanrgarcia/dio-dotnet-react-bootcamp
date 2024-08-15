using exploringCSharp.Models;
using System.Globalization;

// Person p1 = new Person(name: "Thais", lastName: "Andrade");
// Person p2 = new Person(name: "Renan", lastName: "Garcia");

// Course englishCourse = new Course();
// englishCourse.Name = "English";
// englishCourse.Students = new List<Person>();

// englishCourse.AddStudent(p1);
// englishCourse.AddStudent(p2);
// englishCourse.ObtainNumberOfStudentsEnrolled();
// englishCourse.ListStudents();

// // Money test
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal money = 1000.58m;

// Console.WriteLine($"{money:C}");
// Console.WriteLine(money.ToString("C2"));
// Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Student student = new Student();
// student.Name = "Thais";
// student.LastName = "Andrade";
// student.Introduce();
// student.Email = "T@t.com";
// student.Grade = 10.0;

string[] lines = File.ReadAllLines("Files/readFile.txt");

foreach (string line in lines)
{
  Console.WriteLine(line);
}