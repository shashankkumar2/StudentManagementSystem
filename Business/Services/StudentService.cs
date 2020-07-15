using DataAccess;
using EntityModel;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class StudentService : IStudentService
    {
        private IStudentDataService studentDataService;
        public StudentService(IStudentDataService _studentDataService)
        {
            studentDataService = _studentDataService;
        }

        /// <summary>
        /// Get all student details
        /// </summary>
        /// <returns>All student</returns>
        public IEnumerable<Student> GetAllStudents()
        {
            return studentDataService.GetAllStudents();
        }

        /// <summary>
        /// Get students by id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Student as per specific Id</returns>
        public IEnumerable<Student> GetAllStudentsById(int id)
        {
            var students = studentDataService.GetAllStudents().Where(stu => stu.id == id);
            return students;
        }

        /// <summary>
        /// Get all enrollment services
        /// </summary>
        /// <returns>Return all enrollments</returns>
        public IEnumerable<Enrollment> GetAllStudentEnrollments()
        {
            return studentDataService.GetAllStudentEnrollments();
        }

        /// <summary>
        /// Get all enrollment
        /// </summary>
        /// <returns>Return all enrollments</returns>
        public IEnumerable<Enrollment> GetAllStudentEnrollments(int studentId, string schoolYear)
        {
            var enrollments = studentDataService.GetAllStudentEnrollments();
            if (studentId != 0)
                enrollments = enrollments.Where(x => x.StudentId == studentId);
            if (schoolYear != "" && schoolYear != null)
                enrollments = enrollments.Where(x => x.SchoolYear == schoolYear);
            return enrollments;
        }
        

        /// <summary>
        /// Get all student services
        /// </summary>
        /// <returns>Return all student services</returns>
        public IEnumerable<Service> GetAllStudentServices()
        {
            return studentDataService.GetAllStudentServices();
        }
               
        /// <summary>
        /// Get all service
        /// </summary>
        /// <returns>Return all service</returns>
        public IEnumerable<Service> GetAllStudentServices(int studentId, string schoolYear)
        {
            var service = studentDataService.GetAllStudentServices();
            if (studentId != 0)
                service = service.Where(x => x.StudentId == studentId);
            if (schoolYear != "" && schoolYear != null)
                service = service.Where(x => x.SchoolYear == schoolYear);
            return service;
        }
    }
}
