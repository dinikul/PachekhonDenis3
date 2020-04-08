using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace MyLaba3._2
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"cлово", "word"},
                {"человек", "people"}
            };
            string json = JsonConvert.SerializeObject(dictionary);
            File.WriteAllText(@"C:\Users\Home\Desktop\json.txt", json);
            json = File.ReadAllText(@"C:\Users\Home\Desktop\json.txt");
            dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            foreach(var d in dictionary)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
        }
    }
}
