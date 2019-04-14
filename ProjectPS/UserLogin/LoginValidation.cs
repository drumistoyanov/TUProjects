namespace UserLogin
{
    using System.Linq;

    public class LoginValidation
    {
        public LoginValidation(string username, string password, ActionOnError actionOnError)
        {
            this.Username = username;
            this.Password = password;
            this.ErrorAction = actionOnError;
        }

        public delegate void ActionOnError(string errorMsg);

        public static UserRoles CurrentUserRole { get; private set; }
        public static string CurrentUserUsername { get; private set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string Exeption { get; set; }
        private ActionOnError ErrorAction { get; set; }

        public bool ValidateUserInput(User user)
        {
            User checkedPasswordUser = UserData.IsUserPassCorrect(this.Username, this.Password);

            if (user.Username.Length == 0)
            {
                CurrentUserRole = UserRoles.ANONYMOUS;
                Logger.LogActivity("Username is empty.");
                this.Exeption = "Username is empty.";
                this.ErrorAction(this.Exeption);
            }
            if (user.Password.Length == 0)
            {
                CurrentUserRole = UserRoles.ANONYMOUS;
                Logger.LogActivity("Password is empty.");
                this.Exeption = "Password is empty.";
                this.ErrorAction(this.Exeption);
            }
            if (user.Username.Length < 5)
            {
                CurrentUserRole = UserRoles.ANONYMOUS;
                Logger.LogActivity("Username should be longer than 5 symbols.");
                this.Exeption = "Username should be longer than 5 symbols.";
                this.ErrorAction(this.Exeption);
            }
            if (user.Password.Length < 5)
            {
                CurrentUserRole = UserRoles.ANONYMOUS;
                Logger.LogActivity("Password should be longer than 5 symbols.");
                this.Exeption = "Password should be longer than 5 symbols.";
                this.ErrorAction(this.Exeption);
            }
            if (!UserData.TestUsers.Any(x => x.Username == user.Username && x.Password == user.Password))
            {
                CurrentUserRole = UserRoles.ANONYMOUS;
                Logger.LogActivity($"No user with this login details: {user.Username} - {user.Password}");
                this.Exeption = $"No user with this login details: {user.Username} - {user.Password}";
                this.ErrorAction(this.Exeption);
            }
            try
            {
                checkedPasswordUser.Username = this.Username;
                checkedPasswordUser.Password = this.Password;
                CurrentUserRole = checkedPasswordUser.Role;
                CurrentUserUsername = this.Username;
                Logger.LogActivity("Successful login");
            }
            catch
            {
            }
            return true;
        }
    }
}