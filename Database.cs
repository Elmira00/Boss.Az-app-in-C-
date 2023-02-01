using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Category(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
    class Database
    {
        public List<Worker> Workers { get; set; }
        public List<Employer> Employers { get; set; }
      //  public List<Category> Categories { get; set; }
        public static List<Announcement> FilterAnnoucments { get; set; } = new List<Announcement>();
        public static List<CV> FilterCvs { get; set; } = new List<CV>();
    }
}
