using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Santander.Arka.IServices
{
    public interface IEntitiesService<TEntity>
    {
        ICollection<TEntity> Get();
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}
