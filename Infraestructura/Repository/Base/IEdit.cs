using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Base
{
    public interface IEdit<TEntity> where TEntity : IEntity
    {
        void Edit(TEntity entity);
        void EditAll(IList<TEntity> entities);
    }
}
