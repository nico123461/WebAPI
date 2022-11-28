using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Base
{
    public interface IDelete<TEntity> where TEntity : IEntity
    {
        void Delete(TEntity entity);
        void DeleteAll(IList<TEntity> entities);
    }
}
