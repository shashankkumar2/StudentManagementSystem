using Newtonsoft.Json;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        //To get the BaseUrl
        string Baseurl = ConfigurationManager.AppSettings.Get("BaseUrl");
        public async Task<ActionResult> Index(FormCollection Form)
        {
            ViewBag.Name = Form["txtSearch"];
            List<Student> student = new List<Student>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string uri = "api/student";
                if (Form["txtSearch"] != "" && Form["txtSearch"] !=null)
                    uri = uri+ "/" + Form["txtSearch"];
                HttpResponseMessage Res = await client.GetAsync(uri);
                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;
                    student = JsonConvert.DeserializeObject<List<Student>>(response);
                }
                return View(student);
            }
        }

        public async Task<ActionResult> Enrollment(FormCollection Form)
        {

            int studentId = 0;
            ViewBag.Id = Form["txtStudentId"];
            ViewBag.SchoolYear = Form["txtSchoolYear"];
            List<Enrollment> enrollments = new List<Enrollment>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                string uri = "api/enrollment?studentId={0}&schoolYear={1}";
                if (Form["txtStudentId"] != "" && Form["txtStudentId"] != null)
                    studentId =Convert.ToInt32(Form["txtStudentId"]);
                uri = String.Format(uri, studentId, Form["txtSchoolYear"]);

                HttpResponseMessage Res = await client.GetAsync(uri);
                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;
                    enrollments = JsonConvert.DeserializeObject<List<Enrollment>>(response);
                }
                return View(enrollments);
            }
        }

        public async Task<ActionResult> Service(FormCollection Form)
        {

            int studentId = 0;
            ViewBag.Id = Form["txtStudentId"];
            ViewBag.SchoolYear = Form["txtSchoolYear"];
            List<Service> services = new List<Service>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string uri = "api/service?studentId={0}&schoolYear={1}";
                if (Form["txtStudentId"] != "" && Form["txtStudentId"] != null)
                    studentId = Convert.ToInt32(Form["txtStudentId"]);
                uri = String.Format(uri, studentId, Form["txtSchoolYear"]);

                HttpResponseMessage Res = await client.GetAsync(uri);
                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;
                    services = JsonConvert.DeserializeObject<List<Service>>(response);
                }
                return View(services);
            }
        }
    }
}