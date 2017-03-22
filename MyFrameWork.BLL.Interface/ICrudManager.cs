using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyFrameWork.BLL.Interface
{ 
    public interface ICrudManager<T> where T : class
    {
        int Add(T entity);

        int Modify(T entity);

        int Romove(T entity);

        List<T> Getlist(Expression<Func<T, bool>> whereLambda);
    }
}
