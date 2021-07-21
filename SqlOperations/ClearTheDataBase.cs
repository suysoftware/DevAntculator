using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Paths;
using TezAPPV2.Model;
using System.Data;

namespace TezAPPV2.SqlOperations
{
    class ClearTheDataBase
    {

        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }

        public void ClearAllDataBase()
        {


            connect();


            SqlCommand command = new SqlCommand("TRUNCATE TABLE ThesesxData", _baglan);

            command.ExecuteNonQuery();

            _baglan.Close();
        }


    }
}
