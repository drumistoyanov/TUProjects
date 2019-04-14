namespace UserLogin
{
    using System;

    public class User
    {
        public User()
        {
        }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.FacultyNumber = 0;
            this.Role = UserRoles.ANONYMOUS;
        }

        public DateTime Created { get; set; }

        public DateTime ActiveUntil { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int FacultyNumber { get; set; }

        public UserRoles Role { get; set; }

        public override string ToString()
        {
            return $"{this.Username} has password {this.Password} with {this.FacultyNumber} and role  {this.Role}";
        }
    }
}