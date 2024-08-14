using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploringCSharp.Models
{
    public class Course
    {
        public string Name { get; set; }
        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int ObtainNumberOfStudentsEnrolled()
        {
            int studentsCount = Students.Count;
            return studentsCount;
        }
        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public void ListStudents()
        {
            Console.WriteLine($"The students in the {Name} course:");

            for (int counter = 0; counter < Students.Count; counter++)
            {
                string text = $"Nº {counter + 1} - {Students[counter].FullName}";
                // string text = "Nº " + (counter + 1) + " - " + Students[counter].FullName;
                Console.WriteLine(text);
            }
        }
    }
}