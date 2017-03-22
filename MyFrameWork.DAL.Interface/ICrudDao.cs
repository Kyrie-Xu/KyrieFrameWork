using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MyFrameWork.DAL.Interface
{
    public interface ICrudDao<T> where T : class
    {
        int Add(T entity);

        int Modify(T entity);

        int Romove(T entity);

        List<T> Getlist(Expression<Func<T,bool>> whereLambda);
    }
}
