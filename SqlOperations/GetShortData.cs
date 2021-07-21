using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Entities;
using TezAPPV2.Model;
using TezAPPV2.Paths;
using TezAPPV2.Abstract;
using System.Data;

namespace TezAPPV2.SqlOperations
{

     class GetShortData
    {
        public int Id { get; set; }  //0
        public string Tc { get; set; }  //1
        public string Ad { get; set; } //2
        public string Soyad { get; set; }  //3
        public short A77 { get; set; }  //4
        public short A87 { get; set; }  //5
        public short A8 { get; set; }  //6


       
        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }

        public List<GetShortData> ShortGet()
        {



            connect();

            SqlCommand command = new SqlCommand("Select Id,Tc,Ad,Soyad,A77,A87,A8 From ThesesxData order by Id DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();



            List<GetShortData> getShortDatas = new List<GetShortData>();
            while (reader.Read())
            {
                GetShortData getShortData = new GetShortData();

                getShortData.Id = Convert.ToInt32(reader["Id"]);
                getShortData.Tc = reader["Tc"].ToString();
                getShortData.Ad = reader["Ad"].ToString();
                getShortData.Soyad = reader["Soyad"].ToString();
                getShortData.A77 = Convert.ToInt16(reader["A77"]);
                getShortData.A87 = Convert.ToInt16(reader["A87"]);
                getShortData.A8 = Convert.ToInt16(reader["A8"]);



                getShortDatas.Add(getShortData);

            }
            reader.Close();
            _baglan.Close();
            return getShortDatas;




        }



    }
}
