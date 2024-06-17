using System;

namespace OnlineLearningPlatform.Client.Models
{
    public class EnrollmentModel
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public StudentModel Student { get; set; } // Reference to Student
        public int CourseId { get; set; }
        public CourseModel Course { get; set; } // Reference to Course
        public DateTime EnrollmentDate { get; set; }
    }
}
