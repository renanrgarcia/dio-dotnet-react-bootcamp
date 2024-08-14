using exploringCSharp.Models;

Person p1 = new Person();
p1.Name = "Renan";
p1.LastName = "Garcia";

Person p2 = new Person();
p2.Name = "Thaís";
p2.LastName = "Andrade";

Course englishCourse = new Course();
englishCourse.Name = "English";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.ObtainNumberOfStudentsEnrolled();
englishCourse.ListStudents();
