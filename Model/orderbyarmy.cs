using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TezAPPV2.Model
{
    class orderbyarmy
    {
        public int Talep_Nob { get; set; }//261
        public string Birlik_Ismib { get; set; }
        public string Talep_Miktarb { get; set; }
        public string Olcu_Tipib { get; set; }
        public short MilimetreDipb { get; set; }
        public short MilimetreTepeb { get; set; }


        private SqlConnection _baglan2 = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = THESESX; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public void connect2()
        {
            if (_baglan2.State == ConnectionState.Closed)
            {
                _baglan2.Open();
            }
        }
        public List<orderbyarmy> OrderGetArmy()
        {
            connect2();

            SqlCommand command = new SqlCommand("Select * From TalepDataTheses order by TalepNo DESC", _baglan2);
            SqlDataReader reader = command.ExecuteReader();

            List<orderbyarmy> orderbyarmys = new List<orderbyarmy>();
            while (reader.Read())
            {
                orderbyarmy Orderbyarmy = new orderbyarmy();
                Orderbyarmy.Talep_Nob = Convert.ToInt32(reader["TalepNo"]);
                Orderbyarmy.Birlik_Ismib = reader["Birlik_Ismi"].ToString();
                Orderbyarmy.Olcu_Tipib = reader["Olcu_Tipi"].ToString();
                Orderbyarmy.MilimetreDipb = Convert.ToInt16(reader["MilimetreDip"]);
                Orderbyarmy.MilimetreTepeb = Convert.ToInt16(reader["MilimetreTepe"]);



                orderbyarmys.Add(Orderbyarmy);

            }
            reader.Close();
            _baglan2.Close();
            return orderbyarmys;

        }




    }
}
