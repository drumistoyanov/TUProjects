using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using SearchSystem_ZartAlgorithm.CommandMenu;
using SearchSystem_ZartAlgorithm.Entities;
using SearchSystem_ZartAlgorithm.LoginAndRegister;
using SearchSystem_ZartAlgorithm.LogReading;
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
            List<LogClass> items = LogReader.Log();
           
            var users = Login.Deserialize();
            Command.Menu(users);
        }
    }
}
