using System;

namespace OnlineLearningPlatform.Client.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
