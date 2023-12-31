﻿using MyElearningProject.DAL.Entities;
using System.Data.Entity;

namespace MyElearningProject.DAL.Context
{
    public class ELearningContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseRegister> CourseRegisters { get; set; }
        public DbSet<Feature>  Features { get; set; }
        public DbSet<About> AboutUs { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<AdminRegister> AdminRegisters { get; set; }

    }
}