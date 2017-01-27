using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNLayer.Data
{
    public class Connection
    {
        public static SqlConnection Cn { get; set; }
        public static string CadenaConnection = ConfigurationManager.ConnectionStrings["Connection.ADO.NET"].ToString();
        public static SqlConnection GetConnection()
        {
            return Cn ?? (Cn = new SqlConnection(CadenaConnection));
        }
    }
}
