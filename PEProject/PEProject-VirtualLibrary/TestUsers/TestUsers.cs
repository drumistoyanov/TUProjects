using System;
using System.Collections.Generic;
using System.Text;
using SearchSystem_ZartAlgorithm.Entities;

namespace SearchSystem_ZartAlgorithm.TestUsers
{
   public class TestUsers
    {
        public void AddTestObjects(List<User> users)
        {
            var user = new User("admin", "admin");
            users.Add(user);
            var user1 = new User("user1", "user1");
            users.Add(user1);
            var user2 = new User("user2", "user2");
            users.Add(user2);
            var user3 = new User("user3", "user3");
            users.Add(user3);
        }
    }
}
