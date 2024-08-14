using exploringCSharp.Models;

Person p1 = new Person(name: "Thais", lastName: "Andrade");
Person p2 = new Person(name: "Renan", lastName: "Garcia");

Course englishCourse = new Course();
englishCourse.Name = "English";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.ObtainNumberOfStudentsEnrolled();
englishCourse.ListStudents();
