using OnlineLearningPlatform.Models;
using OnlineLearningPlatform.Repositories;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<Course>> GetAllCourses()
        {
            return await _courseRepository.GetAllCourses();
        }

        public async Task<Course> GetCourseById(int id)
        {
            return await _courseRepository.GetCourseById(id);
        }

        public async Task AddCourse(Course course)
        {
            await _courseRepository.AddCourse(course);
        }

        public async Task UpdateCourse(Course course)
        {
            await _courseRepository.UpdateCourse(course);
        }

        public async Task DeleteCourse(int id)
        {
            await _courseRepository.DeleteCourse(id);
        }
    }

}
