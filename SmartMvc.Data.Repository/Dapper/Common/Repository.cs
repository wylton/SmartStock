using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SmartMvc.Data.Repository.Dapper.Common
{
    public class Repository : IDisposable
    {
        public IDbConnection SmartConnection
        {
            get { return new SqlConnection(ConfigurationManager.ConnectionStrings["SmartEntities"].ConnectionString); }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
