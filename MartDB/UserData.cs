using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MartDB
{
    static class UserData
    {
        // Debugging
        public static string UserName = "user";
        public static string UserRole = "customer";

        static void SetCurrentOrgId()
        {
            // Establish connection
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            //sqlConnection.Open();

            //SqlCommand sqlCmdGetCurrentOrgId = new SqlCommand();
            //sqlCmdGetCurrentOrgId.Connection = sqlConnection;
            //sqlCmdGetCurrentOrgId.CommandType = System.Data.CommandType.Text;
            //SqlParameter orgName = new SqlParameter("@org_name", SqlDbType.Int);
        }
    }
}
