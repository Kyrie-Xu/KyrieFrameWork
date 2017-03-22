using MyFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.BLL.Interface;
using MyFrameWork.DAL.Interface;

namespace MyFrameWork.BLL.Implement
{
    public class StudentManager : CrudManager<Student>,IStudentManager
    {
        //注入数据层实例
        public IStudentDao StudentDao { set; get; }

        public StudentManager()
        {
            //StudentDao.
        }
    }
}
