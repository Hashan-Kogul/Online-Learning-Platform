using System.Collections.Generic;
namespace OnlineLearningPlatform.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; } // Duration in hours
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
