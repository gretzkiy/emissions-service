using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Configuration;

namespace EmissionsService
{
    class DataService
    {
        public static string DbConnectionString = ConfigurationManager.ConnectionStrings["emissionsDb"].ConnectionString;
        
        //public static void WriteNum(int num)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnectionString))
        //    {
        //        var sqlQuery = "INSERT INTO MySources (SourceUuid, pniv) VALUES (@SourceUuid, @pniv);";

        //        connection.Execute(sqlQuery, new { pniv = num, SourceUuid = Guid.NewGuid().ToString() });
        //    }
        //}


    }
}
