using System;
using System.Collections.Generic;
using SearchSystem_ZartAlgorithm.CommandMenu;
using SearchSystem_ZartAlgorithm.Entities;
using SearchSystem_ZartAlgorithm.LoginAndRegister;
using SearchSystem_ZartAlgorithm.TestUsers;

namespace SearchSystem_ZartAlgorithm
{
    public class StartUp
    {
        public static void Main()
        {

            //var users = new List<User>();
            //var test = new Test();
            //test.AddTestObjects(users);
            //Register.Serialize(users);
            var users = Login.Deserialize();
            Command.Menu(users);
        }
    }
}
