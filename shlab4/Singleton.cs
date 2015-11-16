using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shlab4
{
    class Singleton
    {
        private static OracleConnection oracleConnection1 = null;
        public static OracleConnection getConnection()
        {
            if (oracleConnection1 == null)
            {
                OracleConnectionStringBuilder myCStringB = new OracleConnectionStringBuilder();
                myCStringB.UserID = "CinemaCity2";
                myCStringB.Password = "cinemacity2";
                myCStringB.DataSource = "XE";
                oracleConnection1 = new OracleConnection(myCStringB.ConnectionString);
            }
            return oracleConnection1;
        }
    }
}
