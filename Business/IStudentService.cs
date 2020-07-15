using EntityModel;
using System.Collections.Generic;

namespace Business
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetAllStudentsById(int id);
        IEnumerable<Enrollment> GetAllStudentEnrollments();
        IEnumerable<Enrollment> GetAllStudentEnrollments(int id, string schoolYear);
        IEnumerable<Service> GetAllStudentServices();
        IEnumerable<Service> GetAllStudentServices(int id, string schoolYear);
    }
}
