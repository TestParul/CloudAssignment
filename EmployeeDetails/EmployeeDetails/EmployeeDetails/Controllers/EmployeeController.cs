using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeDetails.Models;
using Newtonsoft.Json;

namespace EmployeeDetails.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            WebClient webClient = new WebClient();
            string json = webClient.DownloadString(@"https://cloud-basics-assignment.s3.ap-south-1.amazonaws.com/employee_details.json");
            //Employee employees = JsonConvert.DeserializeObject<Employee>(json);
            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(json);
            return View(employees);
        }
    }
}