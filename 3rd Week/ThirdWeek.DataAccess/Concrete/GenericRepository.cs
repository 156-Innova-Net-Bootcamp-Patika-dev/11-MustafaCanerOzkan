using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeek.DataAccess.Interfaces;

namespace ThirdWeek.DataAccess.Concrete
{
    // Her entity için ayrı ayrı class'lar tanımlamak yerine  burada tanımladığımız genel bir
    // class üzerinden, diğer class'larin implementasyonunu sağlıyoruz.
    public class GenericRepository<T, TContext> : IGenericRepository<T>
        where T : class
        where TContext : ThirdWeekDbContext, new()
    {
        // Veri tabanında yeni bir entity oluşturduğumuz kısım.
        public void Create(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }
        // Veri tabanından belirli bir öğeyi silmek için oluşturduğumuz kısım.
        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }
        // Veri tabanından bütün öğeleri çekmek için oluşturduğumuz kısım.
        public List<T> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }
        // Veri tabanından Id'ye göre veri çekmek için kullandığımız kısım.
        public T GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }
        // Veri tabanından belirli bir öğeyi güncellemek için oluşturduğumuz kısım.
        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
