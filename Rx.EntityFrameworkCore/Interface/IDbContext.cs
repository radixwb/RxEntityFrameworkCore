using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rx.EntityFrameworkCore
{
    public interface IDbContext:IDisposable
    {
        DatabaseFacade Database { get; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();

        ChangeTracker ChangeTracker { get; }
    }
}
