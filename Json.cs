using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp15
{
    class JsonFormat
    {
        public static void WriteJsonWorkers( List<Worker> workers)
        {

            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("workers.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, workers);
                }
            }

        }

        public static void ReadJsonWorkers()
        {
            Worker[] workers = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("workers.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    workers = serializer.Deserialize<Worker[]>(jr);
                }
                foreach (var w in workers)
                {
                    Console.WriteLine(w);
                }
            }
        }
        public static void WriteJsonEmployers(List<Employer> employers)
        {

            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("employers.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, employers);
                }
            }

        }

        public  static void ReadJsonEmployers()
        {
            Employer[] employers = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("employers.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    employers = serializer.Deserialize<Employer[]>(jr);
                }
                foreach (var e in employers)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static void WriteJsonCategories(List<Category> categories)
        {

            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("categories.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, categories);
                }
            }

        }

        public  static void ReadJsonCategories()
        {
            Category[] categories = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("categories.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    categories = serializer.Deserialize<Category[]>(jr);
                }
                foreach (var c in categories)
                {
                    Console.WriteLine(c);
                }
            }
        }


    }
}
