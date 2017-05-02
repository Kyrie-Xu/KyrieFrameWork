using MyFrameWork.DAL.Interface;
using MyFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFrameWork.DAL.Implement
{
    public class StudentDao : CrudDao<Student> ,IStudentDao
    {
        public StudentDao() { }
    }
}
