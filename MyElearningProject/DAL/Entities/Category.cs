using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyElearningProject.DAL.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CategoryImage { get; set; }

        public List<Course> Courses { get; set; }
    }
}