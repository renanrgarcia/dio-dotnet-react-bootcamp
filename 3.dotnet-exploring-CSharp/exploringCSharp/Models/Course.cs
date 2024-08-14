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
            int counter = 1;
            foreach (Person student in Students)
            {
                Console.WriteLine($"{counter}. {student.FullName}");
                counter++;
            }
        }
    }
}