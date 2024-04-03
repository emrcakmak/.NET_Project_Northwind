using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext :DbContext,new()
    {
        
        public void Add(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity=context.Entry(Entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
               

            }
        }



        public void Delete(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var DeleteEntity = context.Entry(Entity);
                DeleteEntity.State = EntityState.Deleted;
                context.SaveChanges();


            }
        }

        public TEntity Get(int id)
        {
            using (TContext context = new TContext())
            {

                return context.Set<TEntity>().SingleOrDefault(p =>p.Equals(id));

            }
        }

        public List<TEntity> GetAll()
        {
            using (TContext context = new TContext())
            {

                return context.Set<TEntity>().ToList();

            }
        }

        public void Update(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var UpdateEntity = context.Entry(Entity);
                UpdateEntity.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
    }
}
