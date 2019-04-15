using System;
using System.Collections.Generic;
using System.Text;

namespace SearchSystem_ZartAlgorithm.Entities
{
   public class User
    {
        public User(string username,string password)
        {
            this.Username = username;
            this.Password = password;
            this.CreatedOn = DateTime.Now.Date;
        }
        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
