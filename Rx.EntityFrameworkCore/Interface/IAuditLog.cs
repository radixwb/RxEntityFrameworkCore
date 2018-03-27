using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.EntityFrameworkCore
{
    public interface IAuditLog
    {
        void RequestLog();
        void EntityLog(object entity, EntityState entityState, object dbEntity);
        int SaveChanges();
    }
}
