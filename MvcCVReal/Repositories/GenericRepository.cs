using MvcCVReal.Models.Entity;
using System.Linq.Expressions;

namespace MvcCVReal.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbMyCvContext context = new DbMyCvContext();

        public List<T> AllList()
        {
            return context.Set<T>().ToList();
        }

        public void ListAdd(T tab)
        {
            context.Set<T>().Add(tab);
            context.SaveChanges();
        }

        public void ListRemove(T tab)
        {
            context.Set<T>().Remove(tab);
            context.SaveChanges();
        }

        public void ListUpdate(T tab)
        {
            context.Set<T>().Update(tab); 
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public T Find(Expression<Func<T,bool>> where)
        {
            return context.Set<T>().FirstOrDefault(where);
        }
    }
}
