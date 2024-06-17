using System;
using System.Collections.Generic;

namespace OnlineLearningPlatform.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}