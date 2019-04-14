namespace PEProject_VirtualLibrary.File
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using PEProject_VirtualLibrary.Entities;

    public class FileClass
    {
        public static readonly string WorkingDirectory = Environment.CurrentDirectory;
        public static readonly string TextFilePath = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName + @"\File\log.json";

        public static void Serialize(List<Item> items)
        {
            if (!File.Exists(TextFilePath))
            {
                File.Create(TextFilePath).Dispose();

                using (StreamWriter file = new StreamWriter(TextFilePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, items);
                }
            }
            else if (File.Exists(TextFilePath))
            {
                using (StreamWriter file = new StreamWriter(TextFilePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, items);
                }
            }
            //using (StreamWriter file = File.CreateText(TextFilePath))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    //serialize object directly into file stream
            //    serializer.Serialize(file, items);
            //}
        }

        public class ItemConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(Item));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);
                if (jo["Type"].Value<string>() == "Book")
                    return jo.ToObject<Book>(serializer);
                if (jo["Type"].Value<string>() == "AudioCD")
                    return jo.ToObject<AudioCD>(serializer);
                if (jo["Type"].Value<string>() == "CDRom")
                    return jo.ToObject<CDRom>(serializer);
                if (jo["Type"].Value<string>() == "Diskette")
                    return jo.ToObject<Diskette>(serializer);
                if (jo["Type"].Value<string>() == "Magazine")
                    return jo.ToObject<Magazine>(serializer);
                if (jo["Type"].Value<string>() == "VideoDiskette")
                    return jo.ToObject<VideoDiskette>(serializer);

                return null;
            }

            public override bool CanWrite
            {
                get { return false; }
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }

        public static List<Item> Deserialize()
        {
            JsonConverter[] converters = { new ItemConverter() };
            var json = File.ReadAllText(TextFilePath);
            var test = JsonConvert.DeserializeObject<List<Item>>(json, new JsonSerializerSettings() { Converters = converters });

            return test;
            // return JsonConvert.DeserializeObject<List<Item>>(aa);
        }
    }
}