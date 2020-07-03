using System.IO;
using Newtonsoft.Json.Linq;

namespace ClassLibrary1
{
    public class Class1
    {
        public string GetFile()
        {
            string content = File.ReadAllText(@".\Lookup\TextFile1.txt");
            var json = JObject.Parse(content);
            return json.ToString();
        }
    }
}
