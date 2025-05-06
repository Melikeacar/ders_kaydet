using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglantı
    {
        public static SqlConnection BGL = new SqlConnection(@"Data Source=LAPTOP-558BI1BU\MSSQLSERVER02;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
