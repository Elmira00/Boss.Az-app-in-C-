using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Helper
    {
        public static CV CvObject(int categoryId)
        {
            Console.Clear();
            Checker checker = new Checker();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            if (checker.isString(name)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect name try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;

            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Your job: ");
            string workName = Console.ReadLine();
            if (checker.isString(workName)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect job name try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
      
            }


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--Age must be more than 18--");
            Console.Write("Enter your Age: ");
            string age = Console.ReadLine();
            if (checker.IsValidAge(age)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect age try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Your city: ");
            string city = Console.ReadLine();
            if (checker.isString(city)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect city try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("Your Skills: ");
            string skills = Console.ReadLine();
            Console.Write("Your Experience: ");
            string experience = Console.ReadLine();
            Console.Write("Your Languages: ");
            string languages = Console.ReadLine();
            Console.Write("Your School: ");
            string school = Console.ReadLine();
            Console.Write("Your UniverstyScore: ");
            string universtyScore = Console.ReadLine();
            Console.Write("Your Companies: ");
            string companies = Console.ReadLine();
            Console.WriteLine("Has honors diploma ? :\nYES--->[1]\nNO--->[0]\n");
            bool hasHonorsDiploma = false;
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                hasHonorsDiploma = true;
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("You succefully added Cv");
            CV cv = new CV(categoryId, workName, name, int.Parse(age), city, school, universtyScore, languages, companies, hasHonorsDiploma, DateTime.Now, DateTime.Now.AddDays(30), skills, experience);
            Thread.Sleep(1500); Console.ForegroundColor = ConsoleColor.White;
            return cv;

        }
        public static Announcement AnnoucmentObject(int categoryId)
        {
            Console.Clear();
            Checker checker = new Checker();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Subject: ");
            string subject = Console.ReadLine();
            if (checker.isString(subject)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect subject try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("City: ");
            string city = Console.ReadLine();
            if (checker.isString(city)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect city try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--Age must be more than 18--");
            Console.Write("Enter  Age: ");
            string age = Console.ReadLine();
            if (checker.IsValidAge(age)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect age try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Salary: ");
            string salary = Console.ReadLine();
            if (checker.isNumber(salary)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect salary try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("Work experience: ");
            string workexperience = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Relevant person: ");
            string relevantPerson = Console.ReadLine();
            if (checker.isString(relevantPerson)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect relevant person name try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Email: ");
            string email = Console.ReadLine();
            if (checker.IsValidEmail(email)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect email try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            if (checker.isNumber(phoneNumber)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect phone number try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("You succefully added Annoucment");
            Announcement announcement = new Announcement(categoryId, subject, city, age, DateTime.Now, DateTime.Now.AddDays(30), int.Parse(salary), workexperience, relevantPerson, email, phoneNumber);
            Thread.Sleep(1500); Console.ForegroundColor = ConsoleColor.White;
            return announcement;
        }
    }
}
