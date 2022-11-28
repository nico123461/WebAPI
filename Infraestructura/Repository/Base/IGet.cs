using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Base
{
    public interface IGet<TEntity> where TEntity: IEntity
    {
        TEntity Find(Func<TEntity, bool> func);
        IList<TEntity> FindAll(Func<TEntity, bool> func);
    }
}
