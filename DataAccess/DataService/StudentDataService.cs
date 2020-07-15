using EntityModel;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.DataService
{
    public class StudentDataService : IStudentDataService
    {
        /// <summary>
        /// Get all student details
        /// </summary>
        /// <returns>All student</returns>
        public IEnumerable<Student> GetAllStudents()
        {
            StudentContext studentContext = new StudentContext();
            return studentContext.Students.ToList();
        }

        /// <summary>
        /// Get all student enrollments
        /// </summary>
        /// <returns>All enrollments</returns>
        public IEnumerable<Enrollment> GetAllStudentEnrollments()
        {
            StudentContext studentContext = new StudentContext();
            return studentContext.Enrollment.ToList();
        }

        /// <summary>
        /// Get all student services
        /// </summary>
        /// <returns>All services</returns>
        public IEnumerable<Service> GetAllStudentServices()
        {
            StudentContext studentContext = new StudentContext();
            return studentContext.Service.ToList();
        }
    }
}