using OnlineLearningPlatform.Models;
using OnlineLearningPlatform.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentService(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<IEnumerable<Enrollment>> GetAllEnrollments()
        {
            return await _enrollmentRepository.GetAllEnrollments();
        }

        public async Task<Enrollment> GetEnrollmentById(int id)
        {
            return await _enrollmentRepository.GetEnrollmentById(id);
        }

        public async Task AddEnrollment(Enrollment enrollment)
        {
            await _enrollmentRepository.AddEnrollment(enrollment);
        }

        public async Task UpdateEnrollment(Enrollment enrollment)
        {
            await _enrollmentRepository.UpdateEnrollment(enrollment);
        }

        public async Task DeleteEnrollment(int id)
        {
            await _enrollmentRepository.DeleteEnrollment(id);
        }
    }
}
