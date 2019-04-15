using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using SearchSystem_ZartAlgorithm.Entities;

namespace SearchSystem_ZartAlgorithm.LoginAndRegister
{
   public class Register
    {
        public static readonly string WorkingDirectory = Environment.CurrentDirectory;
        public static readonly string TextFilePath = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName + @"\LoginAndRegister\users.json";

        public static void Serialize(List<User> users)
        {
            if (!File.Exists(TextFilePath))
            {
                File.Create(TextFilePath).Dispose();

                using (StreamWriter file = new StreamWriter(TextFilePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, users);
                }
            }
            else if (File.Exists(TextFilePath))
            {
                using (StreamWriter file = new StreamWriter(TextFilePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, users);
                }
            }
        }
    }
}
