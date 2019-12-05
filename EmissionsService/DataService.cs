using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace EmissionsService
{
    class DataService
    {
        const string DbConnectionString = @"Server=.\SQLEXPRESS;Database=emissionsDBtest;Trusted_Connection=True;";
        
        public static void WriteNum(int num)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnectionString))
            {
                var sqlQuery = "INSERT INTO MySources (SourceUuid, pniv) VALUES (@SourceUuid, @pniv);";

                connection.Execute(sqlQuery, new { pniv = num, SourceUuid = Guid.NewGuid().ToString() });
            }
        }
    }
}
