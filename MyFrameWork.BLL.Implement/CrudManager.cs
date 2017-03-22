using MyFrameWork.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.DAL.Interface;

namespace MyFrameWork.BLL.Implement
{
    public class CrudManager<T> : ICrudManager<T> where T : class
    {
        public ICrudDao<T> CrudDao { set; get; }

        public int Add(T entity)
        {

            return CrudDao.Add(entity);
        }

        public List<T> Getlist(Expression<Func<T, bool>> whereLambda)
        {
            return CrudDao.Getlist(whereLambda);
        }

        public int Modify(T entity)
        {
            return CrudDao.Modify(entity);
        }

        public int Romove(T entity)
        {

            return CrudDao.Romove(entity);
        }
    }
}
