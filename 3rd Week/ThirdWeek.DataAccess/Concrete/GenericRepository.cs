﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeek.DataAccess.Interfaces;

namespace ThirdWeek.DataAccess.Concrete
{
    public class GenericRepository<T, TContext> : IGenericRepository<T>
        where T : class
        where TContext : ThirdWeekDbContext, new()
    {
        public void Create(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }

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