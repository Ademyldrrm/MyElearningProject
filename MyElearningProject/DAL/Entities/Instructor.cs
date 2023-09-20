using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyElearningProject.DAL.Entities
{
    public class Instructor
    {
        public int InstructorID { get; set; }

        public string Name { get; set; }
        public string Title { get; set; }      
        public string CoverImage { get; set; }
        [StringLength(30)]
        public string Surname { get; set; }

        public string ImageUrl { get; set; }
        public List<Course> Courses { get; set; }

    }
}