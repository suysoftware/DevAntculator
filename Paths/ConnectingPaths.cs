using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Model;

namespace TezAPPV2.Paths
{
    public class ConnectingPaths

    {
     
        
        public string _baglanTHESESX = @"Data Source = SUY - PC\SQLEXPRESS;Initial Catalog = THESESX; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //private SqlConnection _baglan = new SqlConnection(_baglanTHESESX);

        //public void connect()
        //{

        //    if (_baglan.State == ConnectionState.Closed)
        //    {
        //        _baglan.Open();
        //    }
        //}


    }
}
