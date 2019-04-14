namespace StudentRepository
{
    using System.Linq;
    using UserLogin;

    public class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            return StudentData.TestStudents.Where(x => x.Name == user.Username).First();
        }
    }
}