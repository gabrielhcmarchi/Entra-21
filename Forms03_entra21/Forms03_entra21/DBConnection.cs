using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms03_entra21
{
    public static class DBConnection
    {
        public static SqlConnection Connection { get; } = new SqlConnection("Data Source=LAPTOP-R77MK71E;Initial Catalog=tempdb;Integrated Security=True");


    }
}
