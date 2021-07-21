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
    class DeleteThePerson
    {
        public int Id { get; set; }

        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }

        public void DeletePerson(DeleteThePerson deletePerson)
        {
          connect();

            SqlCommand command = new SqlCommand("Delete from ThesesxData where Id=@Id", _baglan);

            command.Parameters.AddWithValue("@Id", deletePerson.Id);




            command.ExecuteNonQuery();
            _baglan.Close();


        }




    }
}
