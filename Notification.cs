using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Notification
    {

        private static int ID { get; set; } = 100;
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime NotificationTime { get; set; }
        [JsonConstructor]
        public Notification()
        {
            Id = ++ID;
        }
        public override string ToString()
        {
            return $"Id: {Id}\nText: {Text}\nNotification Time: {NotificationTime}";
        }
        public void show()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Text: {Text}");
            Console.WriteLine($"NotificationTime: {NotificationTime}");
        }
    }
}
