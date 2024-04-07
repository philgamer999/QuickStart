using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    internal class DataManagement
    {
        public static Data ReturnData(string path)
        {
            Data data = new Data();
            try
            {
                data = JsonConvert.DeserializeObject<Data>(File.ReadAllText(path));
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return data;
        }

        public void JSONWrite(Data data, string path)
        {
            try
            {
                SerializeToJsonFile(data, path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SerializeToJsonFile<T>(T obj, string filePath)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
