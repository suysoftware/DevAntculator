using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Abstract;
using TezAPPV2.Entities;
using TezAPPV2.Model;
using TezAPPV2.Paths;

namespace TezAPPV2.SqlOperations
{
    class GetOrderData
    {

        public int Talep_No { get; set; }//261
        public string Birlik_Ismi { get; set; }
        public string Talep_Miktar { get; set; }
        public string Olcu_Tipi { get; set; }
        public short MilimetreDip { get; set; }
        public short MilimetreTepe { get; set; }



    



        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }
        public List<GetOrderData> GetOrder()
        {
          

            connect();

            SqlCommand command = new SqlCommand("Select * From TalepDataTheses order by TalepNo DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();



            List<GetOrderData> getOrderDatas = new List<GetOrderData>();
            while (reader.Read())
            {
                GetOrderData getOrderData = new GetOrderData();


                getOrderData.Talep_No = Convert.ToInt32(reader["TalepNo"]);
                getOrderData.Birlik_Ismi = reader["Birlik_Ismi"].ToString();
                getOrderData.Olcu_Tipi = reader["Olcu_Tipi"].ToString();
                getOrderData.MilimetreDip = Convert.ToInt16(reader["MilimetreDip"]);
                getOrderData.MilimetreTepe = Convert.ToInt16(reader["MilimetreTepe"]);








                getOrderDatas.Add(getOrderData);

            }
            reader.Close();
            _baglan.Close();
            return getOrderDatas;











        }
    }
}