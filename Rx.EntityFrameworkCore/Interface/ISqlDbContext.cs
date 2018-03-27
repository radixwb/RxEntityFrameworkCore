using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.Data.Common;

namespace Rx.EntityFrameworkCore
{
    public interface ISqlDbContext
    {
        DatabaseFacade Database { get; }

        DbConnection DbConnection { get;}

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
