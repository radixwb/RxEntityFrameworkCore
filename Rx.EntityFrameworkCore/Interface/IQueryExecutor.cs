using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rx.EntityFrameworkCore
{
    public interface IQueryExecutor
    {
        IEnumerable<TEntity> Execute<TEntity>(QueryObject<TEntity> queryObject) where TEntity : class;
    }
}
