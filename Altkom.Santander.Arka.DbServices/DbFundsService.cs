using Altkom.Santander.Arka.IServices;
using Altkom.Santander.Arka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Altkom.Santander.Arka.DbServices
{
    public class DbFundsService : IFundsService, IDisposable
    {
        private readonly ArkaContext context;


        public DbFundsService()
            : this(new ArkaContext())
        {

        }

        public DbFundsService(ArkaContext context)
        {
            this.context = context;
        }

        public void Add(Fund entity)
        {
            context.Funds.Add(entity);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public ICollection<Fund> Get()
        {
             return context.Funds.Include(p=>p.Group).ToList();


            return context.Database.SqlQuery<Fund>("usrGetFunds").ToList();
        }

        public Fund Get(int id)
        {
            return context.Funds.Find(id);
        }

        public void Remove(Fund entity)
        {
            // context.Funds.Remove(entity);

            context.Database.ExecuteSqlCommand("UPDATE IsRemoved = 1 WHERE Id = 100");
            context.SaveChanges();
        }

        public void Update(Fund entity)
        {
            context.SaveChanges();
        }
    }
}
