namespace StudentRepository
{
    using System;
    using System.Collections.Generic;

    public static class StudentData
    {
        public static List<Student> TestStudents { get; private set; }

        public static void AddStudents()
        {
            var ivan = new Student()
            {
                Name = "Ivan",
                Surname = "Ivan",
                LastName = "Ivan",
                Faculty = "Ivan",
                Speciality = "Ivan",
                Degree = "Ivan",
                Status = "Ivan",
                FacultyNumber = 1,
                Course = 1,
                Flow = 1,
                Group = 1,
                DateOfLastZaverenSemester = DateTime.Now,
                DateOfLastSemesterPayment = DateTime.Now,
            };
            var petur = new Student()
            {
                Name = "petur",
                Surname = "petur",
                LastName = "petur",
                Faculty = "petur",
                Speciality = "petur",
                Degree = "petur",
                Status = "petur",
                FacultyNumber = 2,
                Course = 2,
                Flow = 2,
                Group = 2,
                DateOfLastZaverenSemester = DateTime.Now,
                DateOfLastSemesterPayment = DateTime.Now,
            };
            var stoqn = new Student()
            {
                Name = "stoqn",
                Surname = "stoqn",
                LastName = "stoqn",
                Faculty = "stoqn",
                Speciality = "stoqn",
                Degree = "stoqn",
                Status = "stoqn",
                FacultyNumber = 3,
                Course = 3,
                Flow = 3,
                Group = 3,
                DateOfLastZaverenSemester = DateTime.Now,
                DateOfLastSemesterPayment = DateTime.Now,
            };

            TestStudents.Add(ivan);
            TestStudents.Add(stoqn);
            TestStudents.Add(petur);
        }
    }
}