using Business;
using EntityModel;
using System.Collections.Generic;
using System.Web.Http;

namespace StudentManagementSystem.Controllers
{
    public class EnrollmentController : ApiController
    {
        private readonly IStudentService studentService;

        public EnrollmentController(IStudentService _studentService)
        {
            studentService = _studentService;
        }

        [Route("api/enrollment")]
        public IEnumerable<Enrollment> GetEnrollment()
        {
            return studentService.GetAllStudentEnrollments();
        }

        [Route("api/enrollment")]
        public IEnumerable<Enrollment> GetEnrollmentBySearch(int studentId, string schoolYear)
        {
            return studentService.GetAllStudentEnrollments(studentId, schoolYear);
        }

        // POST api/enrollment
        public void Post([FromBody]string value)
        {
        }

        // PUT api/enrollment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/enrollment/5
        public void Delete(int id)
        {
        }
    }
}
