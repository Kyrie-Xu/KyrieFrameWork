using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.Models;
using System.Data.Entity;
using MyFrameWork.DAL.Interface;

namespace MyFrameWork.DAL.Implement
{
    public class CrudDao<T> : ICrudDao<T> where T : class
    {
        public CrudDao() { }

        MyFrameWorkContext context = new MyFrameWorkContext();   
        public int Add(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Added;
            return context.SaveChanges();
        }

        public List<T> Getlist(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda)
        {
            return context.Set<T>().Where(whereLambda).ToList();
        }

        public int Modify(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public int Romove(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Deleted;
            return context.SaveChanges();
        }
    }
}
