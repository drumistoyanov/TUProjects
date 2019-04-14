namespace UserLogin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class UserData
    {
        private static readonly List<User> TestUsersPrivate = new List<User>();

        public static List<User> TestUsers
        {
            get
            {
                return TestUsersPrivate;
            }
        }

        public static Dictionary<string, int> AllUsersUsernames()
        {
            var result = new Dictionary<string, int>();
            for (int i = 0; i < TestUsers.Count; i++)
            {
                result.Add(TestUsers[i].Username, i);
            }

            return result;
        }

        public static User IsUserPassCorrect(string username, string password)
        {
            return TestUsers.FirstOrDefault(x => x.Username == username && x.Password == password);
        }

        public static void SetUserActiveTo(int userId, DateTime newActivedate)
        {
            var username = AllUsersUsernames().FirstOrDefault(x => x.Value == userId);
            TestUsers.FirstOrDefault(x => x.Username == username.Key).ActiveUntil = newActivedate;
            Logger.LogActivity("Change activity for " + username);
        }

        public static void AssignUserRole(int userId, UserRoles newRole)
        {
            var username = AllUsersUsernames().FirstOrDefault(x => x.Value == userId);
            TestUsers.FirstOrDefault(x => x.Username == username.Key).Role = newRole;
            Logger.LogActivity("Change role for " + username);
        }

        public static void ResetTestUserData()
        {
            TestUsersPrivate.Add(new User
            {
                Username = "Drumi",
                Role = UserRoles.ADMIN,
                Password = "123456",
                FacultyNumber = 1234,
                Created = DateTime.Now,
                ActiveUntil = DateTime.MaxValue
            });
            TestUsersPrivate.Add(new User
            {
                Username = "Pavlin",
                Role = UserRoles.STUDENT,
                Password = "123456",
                FacultyNumber = 1235,
                Created = DateTime.Now,
                ActiveUntil = DateTime.MaxValue
            });
            TestUsersPrivate.Add(new User
            {
                Username = "Petur",
                Role = UserRoles.STUDENT,
                Password = "123456",
                FacultyNumber = 1236,
                Created = DateTime.Now,
                ActiveUntil = DateTime.MaxValue
            });
        }
    }
}