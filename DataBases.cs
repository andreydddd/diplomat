using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace diplomat
{
    internal class DataBases
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-I9IF6HI;Initial Catalog=diploma;Integrated Security=True");

        public void OpenConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
    }
