using Business;
using EntityModel;
using System.Collections.Generic;
using System.Web.Http;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService _studentService)
        {
            studentService = _studentService;
        }

        // GET api/student
        public IEnumerable<Student> Get()
        {
            return studentService.GetAllStudents();
        }

        // GET api/Student/5
        public IEnumerable<Student> Get(int id)
        {
            return studentService.GetAllStudentsById(id);
        }

        // POST api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Student/5
        public void Delete(int id)
        {
        }
    }
}
