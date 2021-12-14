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
        public static string UserName = "admin";
        public static string UserRole = "admin";

        //public static string UserName = "org";
        //public static string UserRole = "organisation";
        public static bool IsCurrentUserAuthenticated = false;
    }
}
