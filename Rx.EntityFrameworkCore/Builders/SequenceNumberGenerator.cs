using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data.SqlClient;
using Rx.EntityFrameworkCore.Attributes;
using Rx.EntityFrameworkCore.Internal;

namespace Rx.EntityFrameworkCore
{
    public class SequenceNumberValueGenerator : ValueGenerator<int>
    {
        public override bool GeneratesTemporaryValues => false;

        public override int Next(EntityEntry entry)
        {
            long newNumber = 0;
            var sequenceName = (SequenceNameAttribute)entry.Entity.GetType().GetCustomAttributes(typeof(SequenceNameAttribute),false).SingleOrDefault();
            if (sequenceName != null) {
                var sqlDbConnection = new SqlConnection(DataUtility.DbConnectionString);
                var sqlCommand = new SqlCommand(string.Format("SELECT NEXT VALUE FOR {0}.{1} AS NewNumber",sequenceName.Schema,sequenceName.Name), sqlDbConnection);
                sqlDbConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    newNumber = reader.GetInt64(0);
                }
                reader.Close();
                sqlCommand.Dispose();
                sqlDbConnection.Close();
                sqlDbConnection.Dispose();
                return Convert.ToInt32(newNumber);
            }
            return Convert.ToInt32(newNumber);
        }
    }
}
