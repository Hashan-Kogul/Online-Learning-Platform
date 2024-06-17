using OnlineLearningPlatform.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);
        Task AddStudent(Student student);
        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
    }
}
