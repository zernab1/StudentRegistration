using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using StudentRegistrationDemo.Models;
namespace StudentRegistrationDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentUpdateController : Controller
    {
        public String PutStudentRecord(Student stdn)
        {
            Console.WriteLine("In updateStudentRecord");
            return StudentRegistration.getInstance().UpdateStudent(stdn);
        }
    }
}
