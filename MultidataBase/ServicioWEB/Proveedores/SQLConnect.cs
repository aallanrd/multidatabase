using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioWEB
{
    class SQLConnect 
    {

        public SqlConnection connection;

        public SQLConnect()
        {

        }

        public string OpenConnection()
        {
            return "Connected";
        }

        public string CloseConnection()
        {
            throw new NotImplementedException();
        }
    }
}
