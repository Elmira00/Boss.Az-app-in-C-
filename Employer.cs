using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Employer : Person
    {
        public List<Announcement> Announcements { get; set; } = new List<Announcement>();
        public List<Notification> Notifications { get; set; } = new List<Notification>();
        public List<CV> SubscribedEmployerCv { get; set; } = new List<CV>();

        //[JsonConstructor]
        public Employer(string name, string surname, int age, string email, string password) : base(name, surname, age, email, password)
        {

        }
        public void AddAnnoucment(Announcement announcement)
        {
            Announcements.Add(announcement);
        }
        public void PrintAnnoucments()
        {
            int count = 0;
            ConsoleColor[] colors = new ConsoleColor[5] { ConsoleColor.Cyan, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.DarkYellow, ConsoleColor.DarkRed };
            foreach (var annoucment in Announcements)
            {
                ++count;
                Console.ForegroundColor = colors[count%5];
                Console.WriteLine($"------------Annoucment {count}------------");
                Console.WriteLine(annoucment);
            }
        }
        public void PrintNotifications()
        {
            int count = 0;
            ConsoleColor[] colors = new ConsoleColor[2] { ConsoleColor.Cyan, ConsoleColor.Green };
            foreach (var notification in Notifications)
            {
                
                ++count;
                Console.ForegroundColor = colors[count %2];
                Console.WriteLine($"------------Notification {count}------------");
                Console.WriteLine(notification);
            }

        }
        public bool IsListEmpty(List<Announcement> announcements)
        {
            if (announcements.Count == 0) return true;
            else return false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
