using Business;
using EntityModel;
using System.Collections.Generic;
using System.Web.Http;

namespace StudentManagementSystem.Controllers
{
    public class ServiceController : ApiController
    {
        private readonly IStudentService studentService;

        public ServiceController(IStudentService _studentService)
        {
            studentService = _studentService;
        }

        [Route("api/service")]
        public IEnumerable<Service> GetService()
        {
            return studentService.GetAllStudentServices();
        }

        [Route("api/service")]
        public IEnumerable<Service> GetServiceBySearch(int studentId, string schoolYear)
        {
            return studentService.GetAllStudentServices(studentId, schoolYear);
        }

        // POST api/service
        public void Post([FromBody]string value)
        {
        }

        // PUT api/service/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/service/5
        public void Delete(int id)
        {
        }
    }
}
