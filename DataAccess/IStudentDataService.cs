using EntityModel;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IStudentDataService
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Enrollment> GetAllStudentEnrollments();
        IEnumerable<Service> GetAllStudentServices();
    }
}
