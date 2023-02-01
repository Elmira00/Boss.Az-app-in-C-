using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Runner
    {
        public static void Run()
        {
            Checker checker = new Checker();
            Worker w1 = new Worker("Agasalam Nagiyev", "Nagiyehfv", 18, "NagiyehFv2@gmail.com", "DunyaSenin");
            Worker w2 = new Worker("Fatime Eliyeva", "Fatya_11", 15, "FatyaEliyv12@gmail.com", "Helloworld");
            Announcement announcement1 = new Announcement(1, "React developer", "Sumgait", "18-25", new DateTime(2020, 09, 21), new DateTime(2020, 10, 21), 900, "1 to 3 years", "Amiraslan", "emiraslaneliyev45@gmail.com", "994557134655");
            Announcement announcement2 = new Announcement(1, "Php developer", "Baku", "20-40", new DateTime(2021, 02, 10), new DateTime(2020, 03, 10), 1500, "More than 1 year", "Kenan", "Kenan23@gmail.com", "994558557498");
            Announcement announcement3 = new Announcement(2, "UI/UX Designer", "Ganja", "25-40", new DateTime(2019, 03, 5), new DateTime(2019, 04, 10), 2100, "More than 3 year", "Nebi", "nnabili@gmail.com", "994557135755");
            Announcement announcement4 = new Announcement(2, "Graphic Designer", "Qabala", "20-30", new DateTime(2021, 10, 21, 23, 30, 40), new DateTime(2020, 11, 21), 3100, "More than 2 year", "Burak", "burakaktas@gmail.com", "9043239430");
            Announcement announcement5 = new Announcement(5, "Administrative assistant", "Ganja", "20-30", new DateTime(2021, 10, 21, 23, 30, 40), new DateTime(2020, 11, 21), 3500, "More than 2 year", "Burak", "burakaktas@gmail.com", "9043239430");
            Database.FilterAnnoucments.Add(announcement5);
            Database.FilterAnnoucments.Add(announcement4);
            Database.FilterAnnoucments.Add(announcement3);
            Database.FilterAnnoucments.Add(announcement2);
            Database.FilterAnnoucments.Add(announcement1);
            CV cv1 = new CV(1, "C# Senior backend engineer", "Eli", 45, "Yevlax", "148", "490", "English", "Step It", true, new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Java,Node.js", "More than 2 year");
            CV cv2 = new CV(2, "Product designer", "Shukufe", 20, "Ganja", "163", "557", "English/German", "Code Academy", false, new DateTime(2021, 8, 22, 22, 00, 10), new DateTime(2021, 9, 22, 23, 30, 00), "A high degree of technical knowledge balanced with creative ability and a hands-on approach.", "More than 1 year");
            CV cv3 = new CV(3, "Seller", "Seyid", 24, "Baku", "207", "612", "Russian/German", "KontaktHome", false, new DateTime(2021, 12, 19, 19, 00, 00), new DateTime(2022, 01, 21, 23, 30, 00), "Able to deliver quality results under time constraints in a fast-paced environment.", "Minimum 2 year");
            CV cv4 = new CV(4, "Pilot", "Samir", 51, "Lankaran", "Seyid Cefer Piseveri adina gimnaziya", "678", "English/German", "Turkish Airlines", true, new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Able to work with key stakeholders to a high level", "Minimum 1.5 year");
            CV cv5 = new CV(5, "English Copywriter UX/UI", "Turane", 32, "Shaki", "178", "532", "Russian/English", "Hansa", false, new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Creating, writing and reviewing varied content in English for Swissquotes web interfaces, particularly its applications.", "Minimum 1.5 year");
            CV cv6 = new CV(6, "Game Developer", "Kamal", 29, "Quba", "311", "389", "Russian/Japanese ", "--", false, new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "*Support the Employer lifecycle through administrative tasks (contracts, addendums,…)\n*Prepare the onboarding of new joiners", "Minimum 1.5 year");
            Database.FilterCvs.Add(cv1);
            Database.FilterCvs.Add(cv2);
            Database.FilterCvs.Add(cv3);
            Database.FilterCvs.Add(cv4);
            Database.FilterCvs.Add(cv5);
            Database.FilterCvs.Add(cv6);
            w1.AddCv(cv1);
            w2.AddCv(cv6);
            Employer emp1 = new Employer("Sema Idayatova", "Sema00", 18, "SemaIdayatva@gmail.com", "MyPass00");
            Employer emp2 = new Employer("Dilare Seyidova", "Sayid.k", 19, "DilaraSayid@gmail.com", "Duman1999");
            emp1.AddAnnoucment(announcement1);
            emp1.AddAnnoucment(announcement2);
            emp1.AddAnnoucment(announcement3);
            emp1.AddAnnoucment(announcement4);
            emp2.AddAnnoucment(announcement5);
            Database db = new Database();
            db.Workers = new List<Worker>();
            db.Employers = new List<Employer>();
            //db.Categories = new List<Category>();
            if (File.Exists("workers.json"))
            {

                var workersText = File.ReadAllText("workers.json");
                db.Workers = JsonConvert.DeserializeObject<List<Worker>>(workersText);
            }
            else
            {
                db.Workers.Add(w1);
                db.Workers.Add(w2);
                JsonFormat.WriteJsonWorkers(db.Workers);
            }
            if (File.Exists("employers.json"))
            {

                var employersText = File.ReadAllText("employers.json");
                db.Employers = JsonConvert.DeserializeObject<List<Employer>>(employersText);
            }
            else
            {
                db.Employers.Add(emp1);
                db.Employers.Add(emp2);
                JsonFormat.WriteJsonEmployers(db.Employers);

            }



            Employer GetEmployerWithUsername(string username, List<Employer> employers)
            {
                foreach (var item in employers)
                {
                    if (item.UserName == username)
                    {
                        return item;
                    }
                }
                return null;
            }
            Worker GetWorkerWithUsername(string username, List<Worker> workers)
            {
                foreach (var item in workers)
                {
                    if (item.UserName == username)
                    {
                        return item;
                    }
                }
                return null;
            }

            Console.Write("\n\n\t\tEnter Username : ");
            string Username = Console.ReadLine();
            Console.Write("\n\n\t\tEnter Password : ");
            string Password = Console.ReadLine();

            if (GetWorkerWithUsername(Username, db.Workers) != null)
            {
                var worker = GetWorkerWithUsername(Username, db.Workers);
                if (worker.Password == Password)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nS u c c e s s f u l l y   e n t e r e d !");
                    Console.ResetColor();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Show My Profile : [1]");
                        Console.WriteLine("Add Cv : [2] ");
                        Console.WriteLine("Delete Cv : [3] ");
                        Console.WriteLine("Show CV's : [4]");
                        Console.WriteLine("Look through announcement's : [5]");
                        Console.WriteLine("Show Notifications : [6]");
                        Console.WriteLine("Exit : [7]");
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            var info = worker.ToString();
                            Console.WriteLine(info);
                            Console.ReadKey();
                        }
                        else if (choice == "2")
                        {
                            worker.AddCv(Helper.CvObject(2));
                            JsonFormat.WriteJsonWorkers(db.Workers);
                        }
                        else if (choice == "3")
                        {
                            Console.Write("Which cv you want delete(with id): ");
                            string id;
                            int check1 = 0;
                            if (checker.isNumber(id = Console.ReadLine()))
                            {
                                foreach (var cv in worker.Cvs)
                                {
                                    if (cv.ThisId.ToString() == id)
                                    {
                                        ++check1;
                                        break;
                                    }
                                }
                                if (check1 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You haven't cv this id"); Console.ForegroundColor = ConsoleColor.White;
                                }
                                var item = worker.Cvs.SingleOrDefault(x => x.ThisId == int.Parse(id));
                                worker.Cvs.Remove(item);
                                JsonFormat.WriteJsonWorkers(db.Workers);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Your cv deleted succesfully"); Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(1500);
                            }
                        }

                        else if (choice == "4")
                        {
                            worker.PrintCvs();
                            Console.ReadKey();
                        }
                        else if (choice == "5")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Enter which announcment you want subscribe(With id): ");
                            string id = Console.ReadLine();
                            int check3 = 0;
                            if (checker.isNumber(id))
                            {
                                foreach (var announcment in Database.FilterAnnoucments)
                                {
                                    if (announcment.ThisId == int.Parse(id))
                                    {
                                        foreach (var employer in db.Employers)
                                        {
                                            foreach (var annoucment in employer.Announcements)
                                            {
                                                if (annoucment.ThisId == int.Parse(id))
                                                {
                                                    Notification notification = new Notification { NotificationTime = DateTime.Now, Text = $"{worker.FullName} subscribed your {annoucment.Subject} announcment" };
                                                    employer.Notifications.Add(notification);
                                                    JsonFormat.WriteJsonEmployers(db.Employers);
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("----You succesfully subscribed this announcment and your cv send----"); Console.ForegroundColor = ConsoleColor.White;
                                                    foreach (var cv in worker.Cvs)
                                                    {
                                                        employer.SubscribedEmployerCv.Add(cv);

                                                    }
                                                    JsonFormat.WriteJsonEmployers(db.Employers);
                                                    Thread.Sleep(1500);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            Thread.Sleep(1000);
                        }
                        else if (choice == "6")
                        {
                            Console.WriteLine("-----------------------NOTIFICATIONS-----------------------"); Console.ForegroundColor = ConsoleColor.White;
                            worker.PrintNotifications();

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Which notification you want to select?"); Console.ForegroundColor = ConsoleColor.White;
                            string id = Console.ReadLine();
                            int count = 0;
                            int count1 = 0;
                            int check2 = 0;
                            if (checker.isNumber(id))
                            {
                                foreach (var notification in worker.Notifications)
                                {
                                    if (notification.Id == int.Parse(id))
                                    {
                                        ++check2;
                                        break;
                                    }
                                    ++count;
                                }
                                if (check2 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("You havent notification this id"); Console.ForegroundColor = ConsoleColor.White;
                                    Thread.Sleep(1000);
                                }
                                foreach (var joboffer in worker.JobOffers)
                                {
                                    if (count == count1)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine(joboffer); Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Accept job offer [0]");
                                        Console.WriteLine("Reject job offer [1]");
                                        string choice10 = Console.ReadLine();
                                        if (choice10 == "0")
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("-----You accepted this job offer succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                            worker.Notifications.RemoveAt(count);
                                            worker.JobOffers.RemoveAt(count);
                                            JsonFormat.WriteJsonWorkers(db.Workers);
                                            Thread.Sleep(1500);
                                        }
                                        else if (choice10 == "1")
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.SetCursorPosition(36, 9);
                                            Console.WriteLine("-----You rejected this job offer succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                            worker.Notifications.RemoveAt(count);
                                            worker.JobOffers.RemoveAt(count);
                                            JsonFormat.WriteJsonWorkers(db.Workers);
                                            Thread.Sleep(1500);
                                        }
                                    }
                                    ++count1;
                                }
                            }
                        }
                        else if (choice == "7")
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nW r o n g      p a s s w o r d !");
                            Console.ResetColor();
                            Thread.Sleep(1500);
                        }
                    }
                }
            }
            else if (GetEmployerWithUsername(Username, db.Employers) != null)
            {
                var employer = GetEmployerWithUsername(Username, db.Employers);
                if (employer.Password == Password)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nS u c c e s s f u l l y   e n t e r e d !");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Show My Profile : [1]");
                        Console.WriteLine("Add Announcement : [2] ");
                        Console.WriteLine("Delete Announcement : [3] ");
                        Console.WriteLine("Show Announcement : [4]");
                        Console.WriteLine("Look through CV's : [5]");
                        Console.WriteLine("Show Notifications : [6]");
                        Console.WriteLine("Exit : [7]");
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            var profile = employer.ToString();
                            Console.WriteLine(profile);
                            Console.ReadKey();
                        }
                        else if (choice == "2")
                        {
                            //int categoryId, string subject, string city, string age, DateTime annoucmentTime,
                            //DateTime annoucmentEndTime, double salary,
                            //string workExperience, string relevantPerson, string email, string phoneNumber
                            employer.AddAnnoucment(Helper.AnnoucmentObject(6));
                            JsonFormat.WriteJsonEmployers(db.Employers);
                        }
                        else if (choice == "3")
                        {
                            Console.Write("Which announcment you want to delete(by id): ");
                            string id;
                            int check1 = 0;
                            id = Console.ReadLine();
                            if (checker.isNumber(id))
                            {
                                foreach (var announcement in employer.Announcements)
                                {
                                    if (announcement.ThisId.ToString() == id)
                                    {
                                        ++check1;
                                        break;
                                    }
                                }
                                if (check1 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You haven't annoucment with this id"); Console.ForegroundColor = ConsoleColor.White;
                                }
                                var item = employer.Announcements.SingleOrDefault(x => x.ThisId == int.Parse(id));
                                employer.Announcements.Remove(item);
                                JsonFormat.WriteJsonEmployers(db.Employers);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Your announcment deleted succesfully"); Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(1500);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                            }
                        }

                        else if (choice == "4")
                        {
                            Console.Clear();
                            employer.PrintAnnoucments();
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        else if (choice == "5")
                        {
                            Console.Clear();
                            foreach (var worke in db.Workers)
                            {
                                worke.PrintCvs();
                                Console.ResetColor();
                                Console.WriteLine("\n\n");
                            }
                            Console.Write("Enter which cv you want subscribe(by id): ");
                            string id = Console.ReadLine();
                            int check3 = 0;
                            if (checker.isNumber(id))
                            {
                                foreach (var cv in Database.FilterCvs)
                                {
                                    if (cv.ThisId == int.Parse(id))
                                    {
                                        foreach (var worke in db.Workers)
                                        {
                                            foreach (var cvv in worke.Cvs)
                                            {
                                                if (cvv.ThisId == int.Parse(id))
                                                {
                                                    Notification notification = new Notification { NotificationTime = DateTime.Now, Text = $"{employer.FullName} subscribed your cv" };
                                                    worke.Notifications.Add(notification);
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("----You succesfully subscribed this announcment and your announcment sent----"); Console.ForegroundColor = ConsoleColor.White;
                                                    foreach (var annoucment in employer.Announcements)
                                                    {
                                                        worke.JobOffers.Add(annoucment);
                                                    }
                                                    JsonFormat.WriteJsonWorkers(db.Workers);
                                                    Thread.Sleep(1500);
                                                }
                                            }

                                        }
                                    }
                                }
                                if (check3 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("No cv with this id"); Console.ForegroundColor = ConsoleColor.White;
                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(1000);
                            }
                        }
                        else if (choice == "6")
                        {

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("-----------------------NOTIFICATIONS-----------------------"); Console.ForegroundColor = ConsoleColor.White;
                            employer.PrintNotifications();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Which notification you want to select?"); Console.ForegroundColor = ConsoleColor.White;
                            string id = Console.ReadLine();
                            int count = 0;
                            int count1 = 0;
                            int check2 = 0;
                            if (checker.isNumber(id))
                            {

                                foreach (var notification in employer.Notifications)
                                {
                                    if (notification.Id == int.Parse(id))
                                    {
                                        ++check2;
                                        break;
                                    }
                                    ++count;
                                }
                                if (check2 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("You havent notification this id"); Console.ForegroundColor = ConsoleColor.White;
                                    Thread.Sleep(1000);
                                }
                                foreach (var subcv in employer.SubscribedEmployerCv)
                                {
                                    if (count == count1)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine(subcv); Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Accept  : [0]");
                                        Console.WriteLine("Reject  : [1]");
                                        string choice10 = Console.ReadLine();
                                        if (choice10 == "0")
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("-----You accepted this cv succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                            employer.Notifications.RemoveAt(count);
                                            employer.SubscribedEmployerCv.RemoveAt(count);
                                            JsonFormat.WriteJsonEmployers(db.Employers);
                                            Thread.Sleep(1500);
                                        }
                                        else if (choice10 == "1")
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.SetCursorPosition(36, 9);
                                            Console.WriteLine("-----You rejected this cv succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                            employer.Notifications.RemoveAt(count);
                                            employer.SubscribedEmployerCv.RemoveAt(count);
                                            JsonFormat.WriteJsonEmployers(db.Employers);
                                            Thread.Sleep(1500);

                                        }
                                    }
                                    ++count1;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(1000);
                            }
                        }

                        else if (choice == "7")
                        {
                            break;
                        }

                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nW r o n g      p a s s w o r d !");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\t\tT H E R E   I S   N O   U S E R N A M E !\n");
                Console.ResetColor();
                Thread.Sleep(1500);
            }

            }
        }
    
}
