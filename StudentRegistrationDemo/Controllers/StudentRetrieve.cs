﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentRegistrationDemo.Models;

namespace StudentRegistrationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRetrieveController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return StudentRegistration.getInstance().getAllStudent();
        }
        [HttpGet("GetAllStudentRecords")]
        public JsonResult GetAllStudentRecords()
        {
            return Json(StudentRegistration.getInstance().getAllStudent());
        }
    }
}

