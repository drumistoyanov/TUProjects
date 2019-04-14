namespace StudentRepository
{
    using System;

    public class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string Faculty { get; set; }

        public string Speciality { get; set; }

        public string Degree { get; set; }

        public string Status { get; set; }

        public int FacultyNumber { get; set; }

        public int Course { get; set; }

        public int Flow { get; set; }

        public int Group { get; set; }

        public DateTime DateOfLastZaverenSemester { get; set; }

        public DateTime DateOfLastSemesterPayment { get; set; }
    }
}