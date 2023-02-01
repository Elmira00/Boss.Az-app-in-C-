using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class CV
    {
        public int ThisId { get; set; }
        public static int Id { get; set; } = 100;
        public int CategoryId { get; set; }
        public string WorkName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string School { get; set; }
        public string UniverstyScore { get; set; }
        public string  Language { get; set; }
        public DateTime CvTime { get; set; }
        public DateTime CvEndTime { get; set; }
        public string Skills { get; set; }
        public string Companies { get; set; }
        public string Experience { get; set; }
        public bool HasHonorsDiploma { get; set; }
        public CV(int categoryId, string workName, string name, int age, string city,string school,string universtyScore,string language, string companies,bool hasHonorsDiploma,DateTime cvTime, DateTime cvEndTime, string skills, string experience)
        {
            ThisId = ++Id;
            CategoryId = categoryId;
            WorkName = workName;
            Name = name;
            Age = age;
            City = city;
            Language = language;
            School = school;
            UniverstyScore = universtyScore;
            CvTime = cvTime;
            Companies = companies;
            CvEndTime = cvEndTime;
            Skills = skills;
            Experience = experience;
            HasHonorsDiploma = hasHonorsDiploma;
        }
        public override string ToString()
        {
            return $"Id: {ThisId}\nCategory Id:{CategoryId}\nAge: {Age}\nJob: {WorkName}\nName: {Name}\nCity: {City}\nCv Share Time: {CvTime}\nCv End Time: {CvEndTime}\nSkills: {Skills}\nExperience: {Experience}";
        }
    }
}
