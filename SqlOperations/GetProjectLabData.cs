using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Entities;
using TezAPPV2.Abstract;
using TezAPPV2.Model;
using TezAPPV2.Paths;
using System.Data.SqlClient;
using System.Data;

namespace TezAPPV2.SqlOperations
{
    class GetProjectLabData
    {
        public int subjectid { get; set; }   //0
        public short A77Lab { get; set; }   //1
        public short A87Lab { get; set; }   //2
        public short A8Lab { get; set; }  //3
        public short E101Lab { get; set; }  //4
        public short E102Lab { get; set; }  //5
        public short E103Lab { get; set; }   //6
        public short A2Lab { get; set; }//7
        public short A3Lab { get; set; }//8
        public short A4Lab { get; set; }//9
        public short A5Lab { get; set; }//10
        public short A6Lab { get; set; }//11
        public short A7Lab { get; set; }//12
        public short A9Lab { get; set; }
        public short A10Lab { get; set; }
        public short A11Lab { get; set; }
        public short A12Lab { get; set; }
        public short A13Lab { get; set; }
        public short A14Lab { get; set; }//170
        public short A15Lab { get; set; }
        public short A16Lab { get; set; }
        public short A17Lab { get; set; }
        public short A18Lab { get; set; }
        public short A19Lab { get; set; }
        public short A20Lab { get; set; }
        public short A21Lab { get; set; }
        public short A22Lab { get; set; }
        public short A23Lab { get; set; }
        public short A24Lab { get; set; }//180
        public short A25Lab { get; set; }
        public short A26Lab { get; set; }
        public short A27Lab { get; set; }
        public short A28Lab { get; set; }
        public short A29Lab { get; set; }
        public short A30Lab { get; set; }
        public short A31Lab { get; set; }
        public short A32Lab { get; set; }
        public short A33Lab { get; set; }
        public short A34Lab { get; set; }//190
        public short A35Lab { get; set; }
        public short A36Lab { get; set; }
        public short A37Lab { get; set; }
        public short A38Lab { get; set; }
        public short A39Lab { get; set; }
        public short A40Lab { get; set; }
        public short A41Lab { get; set; }
        public short A42Lab { get; set; }
        public short A43Lab { get; set; }
        public short A44Lab { get; set; }//200
        public short A45Lab { get; set; }
        public short A46Lab { get; set; }
        public short A47Lab { get; set; }
        public short A48Lab { get; set; }
        public short A49Lab { get; set; }
        public short A50Lab { get; set; }
        public short A51Lab { get; set; }
        public short A52Lab { get; set; }
        public short A53Lab { get; set; }
        public short A54Lab { get; set; }//210
        public short A55Lab { get; set; }
        public short A56Lab { get; set; }
        public short A57Lab { get; set; }
        public short A58Lab { get; set; }
        public short A59Lab { get; set; }
        public short A60Lab { get; set; }
        public short A61Lab { get; set; }
        public short A62Lab { get; set; }
        public short A63Lab { get; set; }
        public short A64Lab { get; set; }//220
        public short A65Lab { get; set; }
        public short A66Lab { get; set; }
        public short A67Lab { get; set; }
        public short A68Lab { get; set; }
        public short A69Lab { get; set; }
        public short A70Lab { get; set; }
        public short A71Lab { get; set; }
        public short A72Lab { get; set; }
        public short A73Lab { get; set; }
        public short A74Lab { get; set; }//230
        public short A75Lab { get; set; }
        public short A76Lab { get; set; }
        public short A78Lab { get; set; }
        public short A79Lab { get; set; }
        public short A80Lab { get; set; }
        public short A81Lab { get; set; }
        public short A82Lab { get; set; }
        public short A83Lab { get; set; }
        public short A84Lab { get; set; }
        public short A85Lab { get; set; }//240
        public short A86Lab { get; set; }
        public short A88Lab { get; set; }
        public short A89Lab { get; set; }
        public short A90Lab { get; set; }
        public short A91Lab { get; set; }
        public short A92Lab { get; set; }
        public short A93Lab { get; set; }
        public short A94Lab { get; set; }

        

        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }


        public List<GetProjectLabData> ProjectLabGet()
        {
           
          connect();

            SqlCommand command = new SqlCommand("Select * From ProjectLabData$ order by subjectid DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();



            List<GetProjectLabData> getProjectLabDatas = new List<GetProjectLabData>();
            while (reader.Read())
            {
                GetProjectLabData getProjectLabData = new GetProjectLabData();

                getProjectLabData.subjectid = Convert.ToInt32(reader["subjectid"]);


                getProjectLabData.A77Lab = Convert.ToInt16(reader["A77Lab"]);
                getProjectLabData.A87Lab = Convert.ToInt16(reader["A87Lab"]);
                getProjectLabData.A8Lab = Convert.ToInt16((reader["A8Lab"]));
                getProjectLabData.E101Lab = Convert.ToInt16(reader["E101Lab"]);
                getProjectLabData.E102Lab = Convert.ToInt16(reader["E102Lab"]);
                getProjectLabData.E103Lab = Convert.ToInt16(reader["E103Lab"]);


                getProjectLabData.A2Lab = Convert.ToInt16(reader["A2Lab"]);
                getProjectLabData.A3Lab = Convert.ToInt16(reader["A3Lab"]);
                getProjectLabData.A4Lab = Convert.ToInt16(reader["A4Lab"]);
                getProjectLabData.A5Lab = Convert.ToInt16(reader["A5Lab"]);
                getProjectLabData.A6Lab = Convert.ToInt16(reader["A6Lab"]);
                getProjectLabData.A7Lab = Convert.ToInt16(reader["A7Lab"]);

                getProjectLabData.A9Lab = Convert.ToInt16(reader["A9Lab"]);
                getProjectLabData.A10Lab = Convert.ToInt16(reader["A10Lab"]);
                getProjectLabData.A11Lab = Convert.ToInt16(reader["A11Lab"]);
                getProjectLabData.A12Lab = Convert.ToInt16(reader["A12Lab"]);
                getProjectLabData.A13Lab = Convert.ToInt16(reader["A13Lab"]);
                getProjectLabData.A14Lab = Convert.ToInt16(reader["A14Lab"]);
                getProjectLabData.A15Lab = Convert.ToInt16(reader["A15Lab"]);
                getProjectLabData.A16Lab = Convert.ToInt16(reader["A16Lab"]);
                getProjectLabData.A17Lab = Convert.ToInt16(reader["A17Lab"]);
                getProjectLabData.A18Lab = Convert.ToInt16(reader["A18Lab"]);
                getProjectLabData.A19Lab = Convert.ToInt16(reader["A19Lab"]);
                getProjectLabData.A20Lab = Convert.ToInt16(reader["A20Lab"]);
                getProjectLabData.A21Lab = Convert.ToInt16(reader["A21Lab"]);
                getProjectLabData.A22Lab = Convert.ToInt16(reader["A22Lab"]);
                getProjectLabData.A23Lab = Convert.ToInt16(reader["A23Lab"]);
                getProjectLabData.A24Lab = Convert.ToInt16(reader["A24Lab"]);
                getProjectLabData.A25Lab = Convert.ToInt16(reader["A25Lab"]);
                getProjectLabData.A26Lab = Convert.ToInt16(reader["A26Lab"]);
                getProjectLabData.A27Lab = Convert.ToInt16(reader["A27Lab"]);
                getProjectLabData.A28Lab = Convert.ToInt16(reader["A28Lab"]);
                getProjectLabData.A29Lab = Convert.ToInt16(reader["A29Lab"]);
                getProjectLabData.A30Lab = Convert.ToInt16(reader["A30Lab"]);
                getProjectLabData.A31Lab = Convert.ToInt16(reader["A31Lab"]);
                getProjectLabData.A32Lab = Convert.ToInt16(reader["A32Lab"]);
                getProjectLabData.A33Lab = Convert.ToInt16(reader["A33Lab"]);
                getProjectLabData.A34Lab = Convert.ToInt16(reader["A34Lab"]);
                getProjectLabData.A35Lab = Convert.ToInt16(reader["A35Lab"]);
                getProjectLabData.A36Lab = Convert.ToInt16(reader["A36Lab"]);
                getProjectLabData.A37Lab = Convert.ToInt16(reader["A37Lab"]);
                getProjectLabData.A38Lab = Convert.ToInt16(reader["A38Lab"]);
                getProjectLabData.A39Lab = Convert.ToInt16(reader["A39Lab"]);
                getProjectLabData.A40Lab = Convert.ToInt16(reader["A40Lab"]);
                getProjectLabData.A41Lab = Convert.ToInt16(reader["A41Lab"]);
                getProjectLabData.A42Lab = Convert.ToInt16(reader["A42Lab"]);
                getProjectLabData.A43Lab = Convert.ToInt16(reader["A43Lab"]);
                getProjectLabData.A44Lab = Convert.ToInt16(reader["A44Lab"]);
                getProjectLabData.A45Lab = Convert.ToInt16(reader["A45Lab"]);
                getProjectLabData.A46Lab = Convert.ToInt16(reader["A46Lab"]);
                getProjectLabData.A47Lab = Convert.ToInt16(reader["A47Lab"]);
                getProjectLabData.A48Lab = Convert.ToInt16(reader["A48Lab"]);
                getProjectLabData.A49Lab = Convert.ToInt16(reader["A49Lab"]);
                getProjectLabData.A50Lab = Convert.ToInt16(reader["A50Lab"]);
                getProjectLabData.A51Lab = Convert.ToInt16(reader["A51Lab"]);
                getProjectLabData.A52Lab = Convert.ToInt16(reader["A52Lab"]);
                getProjectLabData.A53Lab = Convert.ToInt16(reader["A53Lab"]);
                getProjectLabData.A54Lab = Convert.ToInt16(reader["A54Lab"]);
                getProjectLabData.A55Lab = Convert.ToInt16(reader["A55Lab"]);
                getProjectLabData.A56Lab = Convert.ToInt16(reader["A56Lab"]);
                getProjectLabData.A57Lab = Convert.ToInt16(reader["A57Lab"]);
                getProjectLabData.A58Lab = Convert.ToInt16(reader["A58Lab"]);
                getProjectLabData.A59Lab = Convert.ToInt16(reader["A59Lab"]);
                getProjectLabData.A60Lab = Convert.ToInt16(reader["A60Lab"]);
                getProjectLabData.A61Lab = Convert.ToInt16(reader["A61Lab"]);
                getProjectLabData.A62Lab = Convert.ToInt16(reader["A62Lab"]);
                getProjectLabData.A63Lab = Convert.ToInt16(reader["A63Lab"]);
                getProjectLabData.A64Lab = Convert.ToInt16(reader["A64Lab"]);
                getProjectLabData.A65Lab = Convert.ToInt16(reader["A65Lab"]);
                getProjectLabData.A66Lab = Convert.ToInt16(reader["A66Lab"]);
                getProjectLabData.A67Lab = Convert.ToInt16(reader["A67Lab"]);
                getProjectLabData.A68Lab = Convert.ToInt16(reader["A68Lab"]);
                getProjectLabData.A69Lab = Convert.ToInt16(reader["A69Lab"]);
                getProjectLabData.A70Lab = Convert.ToInt16(reader["A70Lab"]);
                getProjectLabData.A71Lab = Convert.ToInt16(reader["A71Lab"]);
                getProjectLabData.A72Lab = Convert.ToInt16(reader["A72Lab"]);
                getProjectLabData.A73Lab = Convert.ToInt16(reader["A73Lab"]);
                getProjectLabData.A74Lab = Convert.ToInt16(reader["A74Lab"]);
                getProjectLabData.A75Lab = Convert.ToInt16(reader["A75Lab"]);
                getProjectLabData.A76Lab = Convert.ToInt16(reader["A76Lab"]);
                getProjectLabData.A78Lab = Convert.ToInt16(reader["A78Lab"]);
                getProjectLabData.A79Lab = Convert.ToInt16(reader["A79Lab"]);
                getProjectLabData.A80Lab = Convert.ToInt16(reader["A80Lab"]);
                getProjectLabData.A81Lab = Convert.ToInt16(reader["A81Lab"]);
                getProjectLabData.A82Lab = Convert.ToInt16(reader["A82Lab"]);
                getProjectLabData.A83Lab = Convert.ToInt16(reader["A83Lab"]);
                getProjectLabData.A84Lab = Convert.ToInt16(reader["A84Lab"]);
                getProjectLabData.A85Lab = Convert.ToInt16(reader["A85Lab"]);
                getProjectLabData.A86Lab = Convert.ToInt16(reader["A86Lab"]);
                getProjectLabData.A88Lab = Convert.ToInt16(reader["A88Lab"]);
                getProjectLabData.A89Lab = Convert.ToInt16(reader["A89Lab"]);
                getProjectLabData.A90Lab = Convert.ToInt16(reader["A90Lab"]);
                getProjectLabData.A91Lab = Convert.ToInt16(reader["A91Lab"]);
                getProjectLabData.A92Lab = Convert.ToInt16(reader["A92Lab"]);
                getProjectLabData.A93Lab = Convert.ToInt16(reader["A93Lab"]);
                getProjectLabData.A94Lab = Convert.ToInt16(reader["A94Lab"]);




                getProjectLabDatas.Add(getProjectLabData);

            }
            reader.Close();
            _baglan.Close();
            return getProjectLabDatas;




        }



    }
}
