using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using SearchSystem_ZartAlgorithm.Entities;

namespace SearchSystem_ZartAlgorithm.LoginAndRegister
{
  public  class Login
    {
        public static readonly string WorkingDirectory = Environment.CurrentDirectory;
        public static readonly string TextFilePath = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName + @"\LoginAndRegister\users.json";

        public static List<User> Deserialize()
        {
            var json = File.ReadAllText(TextFilePath);
            var deserializedObjects = JsonConvert.DeserializeObject<List<User>>(json);

            return deserializedObjects;
        }
    }
}
