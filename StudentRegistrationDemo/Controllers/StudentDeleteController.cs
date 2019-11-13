using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using StudentRegistrationDemo.Models;
namespace StudentRegistrationDemo2.Controllers
{
    [ApiController]
    public class StudentDeleteController : Controller
    {
        [Route("student/remove/{regdNum}")]
        public String DeleteStudentRecord(String regdNum)
        {
            Console.WriteLine("In deleteStudentRecord");
            return StudentRegistration.getInstance().Remove(regdNum);
        }
    }
}