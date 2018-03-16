using Negocios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Persistencia;
using Negocios.RN;

namespace Negocios.RN
{
    public abstract class RnGenerica<TEntity> : IGenerica<TEntity> where TEntity : class
    {
        private PalpitecoEntities banco;
        public void Delete(TEntity obj)
        {
            using (banco = new PalpitecoEntities())
            {
                banco.Configuration.ProxyCreationEnabled = false;
                banco.Entry(obj).State = EntityState.Deleted;
                banco.SaveChanges();
            }
        }

        public List<TEntity> FindAll()
        {
            using (banco = new PalpitecoEntities())
            {
                banco.Configuration.ProxyCreationEnabled = false;
                var t = banco.Set<TEntity>().ToList();
                return banco.Set<TEntity>().ToList();
            }
            
        }

        public TEntity FindById(int id)
        {
            using (banco = new PalpitecoEntities())
            {
                banco.Configuration.ProxyCreationEnabled = false;
                return banco.Set<TEntity>().Find(id);
            }
        }

        public void Insert(TEntity obj)
        {
            using (banco = new PalpitecoEntities())
            {
                banco.Configuration.ProxyCreationEnabled = false;
                banco.Entry(obj).State = EntityState.Added;
                banco.SaveChanges();
            }
               
        }

        public void Update(TEntity obj)
        {
            using (banco = new PalpitecoEntities())
            {
                banco.Configuration.ProxyCreationEnabled = false;
                banco.Entry(obj).State = EntityState.Modified;
                banco.SaveChanges();
            }
        }
    }
}
