namespace UserLogin
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class Program
    {
        public static void Main(string[] args)
        {
            UserData.ResetTestUserData();
            string username = null, password = null;
            Console.WriteLine("0-Exit");
            Console.WriteLine("1-Login");
            //Console.WriteLine("2-Register");

            Console.Write("Choose command: ");
            var command = int.Parse(Console.ReadLine());
            if (command == 0)
            {
                Console.WriteLine("Bye");
            }

            var done = false;
            while (command != 0 && !done)
            {
                switch (command)
                {
                    case 0:
                        break;

                    case 1:
                        Console.Write("Username:");
                        username = Console.ReadLine();
                        Console.Write("Password:");
                        password = Console.ReadLine();
                        var loginValidation = new LoginValidation(username, password, ActionOnError);

                        var user = new User(username, password);

                        bool isValid = loginValidation.ValidateUserInput(user);

                        if (isValid && LoginValidation.CurrentUserRole == UserRoles.ADMIN)
                        {
                            AdminMethod(username);
                            done = true;
                        }
                        else
                        {
                            Console.Write("Choose command: ");
                            command = int.Parse(Console.ReadLine());
                        }

                        break;

                    //case 2:
                    //  break;

                    default:
                        Console.Write("Wrong command!!! Try again: ");
                        command = int.Parse(Console.ReadLine());
                        break;
                }
            }
        }

        public static void ActionOnError(string errorMsg)
        {
            Console.WriteLine("!!! " + errorMsg + " !!!");
        }

        private static void AdminMethod(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }

            Console.WriteLine($"You are {LoginValidation.CurrentUserRole}");
            Console.WriteLine("Choose option:");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Change role of user");
            Console.WriteLine("2: Change active date of user");
            Console.WriteLine("3: List of users");
            Console.WriteLine("4: Check whole activity log");
            Console.WriteLine("5: Check current session activity log");

            var command = int.Parse(Console.ReadLine());
            if (command == 0)
            {
                Console.WriteLine("Bye");
            }

            while (command != 0)
            {
                switch (command)
                {
                    case 0:
                        break;

                    case 1:
                        Console.Write("Id of user to change role:");
                        Dictionary<string, int> allUsers = UserData.AllUsersUsernames();
                        var userToEdit = int.Parse(Console.ReadLine());
                        Console.Write($"New role for {allUsers.FirstOrDefault(x => x.Value == userToEdit).Key}" +
                            $"(ANONYMOUS = 0, ADMIN = 1, INSPECTOR = 2, PROFESSOR = 3, STUDENT = 4):");
                        var role = int.Parse(Console.ReadLine());
                        UserData.AssignUserRole(userToEdit, (UserRoles)role);
                        Console.Write("Choose option: ");
                        command = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.Write("Id of user to change active until:");
                        allUsers = UserData.AllUsersUsernames();
                        userToEdit = int.Parse(Console.ReadLine());
                        Console.Write($"New active date in format \"MM/dd/yyyy\" for {allUsers.FirstOrDefault(x => x.Value == userToEdit).Key}:");
                        string line = Console.ReadLine();
                        DateTime dt;
                        while (!DateTime.TryParseExact(line, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                        {
                            Console.WriteLine("Invalid date, please retry");
                            line = Console.ReadLine();
                        }
                        UserData.SetUserActiveTo(userToEdit, dt);
                        Console.Write("Choose option: ");
                        command = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("List of users:");
                        allUsers = UserData.AllUsersUsernames();
                        var users = UserData.TestUsers;
                        foreach (var user in allUsers)
                        {
                            Console.WriteLine(user.Value
                                + " - " + user.Key
                                + " - " + users.FirstOrDefault(x => x.Username == user.Key).Role
                                + " - " + users.FirstOrDefault(x => x.Username == user.Key).ActiveUntil);
                        }
                        Console.Write("Choose option: ");
                        command = int.Parse(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Log history:");
                        StreamReader sr = new StreamReader(Logger.TextFilePath);
                        line = sr.ReadToEnd();
                        Console.WriteLine(line);
                        sr.Close();
                        Console.Write("Choose option: ");
                        command = int.Parse(Console.ReadLine());
                        break;

                    case 5:
                        Console.Write("Choose filter (keyword):");
                        var filter = Console.ReadLine();
                        Console.WriteLine("Current log history:");
                        Console.WriteLine(Logger.GetCurrentSessionActivities(filter));
                        Console.Write("Choose option: ");
                        command = int.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.Write("Wrong command!!! Try again: ");
                        command = int.Parse(Console.ReadLine());
                        break;
                }
            }
        }
    }
}