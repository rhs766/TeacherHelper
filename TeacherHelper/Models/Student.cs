using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeacherHelper.Models
{
    public class Student
    {
        public int Id { get; set; }
        public Guid TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Period { get; set; } 
    }
}