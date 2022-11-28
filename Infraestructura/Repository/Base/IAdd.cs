using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Base
{
    public interface IAdd<TEntity> where TEntity: IEntity
    {
        void Add(TEntity entity);
        void AddAll(IList<TEntity> entities);
    }
}
