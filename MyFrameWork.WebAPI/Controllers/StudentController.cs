using MyFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyFrameWork.BLL.Interface;

namespace MyFrameWork.WebAPI.Controllers
{
    public class StudentController : ApiController
    {
        public IStudentManager StudentManager { set; get; }

        //public ICrudManager<Student> CrudManager { set; get; }
        public List<Student> GetList()

        {
            return StudentManager.Getlist(p => p.ClassID == 1);
        }

        [HttpGet]
        [HttpPost]
        public int Add()
        {
            Student student = new Student()
            {

                ClassID = 1,
                StudentName = "Kyrie"
            };

            return StudentManager.Add(student);
        }

    }
}
