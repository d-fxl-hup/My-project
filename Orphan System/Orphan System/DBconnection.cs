using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Orphan_System
{
    internal class DBconnection
    {
        public static string sqlServerConnString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog = OSD; Integrated Security = True";

    }
}
