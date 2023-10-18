using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class AdminRegister
    {
        public int AdminRegisterID { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
    }
}