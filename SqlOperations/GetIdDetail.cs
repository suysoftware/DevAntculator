using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Model;
using TezAPPV2.Paths;
using TezAPPV2.Entities;
using System.Data.SqlClient;
using System.Data;

namespace TezAPPV2.SqlOperations
{
    class GetIdDetail
    {
        public int Id { get; set; }  //0
        public string Tc { get; set; }  //1
        public string Ad { get; set; } //2
        public string Soyad { get; set; }  //3
        public short A77 { get; set; }  //4
        public short A87 { get; set; }  //5
        public short A8 { get; set; }  //6
        public short E101 { get; set; }  //7
        public short E102 { get; set; }   //8
        public short E103 { get; set; }   //9
        public short A2Trium { get; set; } //17
        public short A3Trium { get; set; }//18
        public short A4Trium { get; set; }//19
        public short A5Trium { get; set; }//20
        public short A6Trium { get; set; }//21
        public short A7Trium { get; set; }//22
        public short A9Trium { get; set; }//23
        public short A12Trium { get; set; }//24
        public short A13Trium { get; set; }//25
        public short A17Trium { get; set; }//26
        public short A18Trium { get; set; }//27
        public short A19Trium { get; set; }//28
        public short A20Trium { get; set; }//29
        public short A21Trium { get; set; }//30
        public short A22Trium { get; set; }//31
        public short A23Trium { get; set; }//32
        public short A25Trium { get; set; }//33
        public short A26Trium { get; set; }//34
        public short A27Trium { get; set; }//35
        public short A28Trium { get; set; }//36
        public short A29Trium { get; set; }//37
        public short A30Trium { get; set; }//38
        public short A35Trium { get; set; }//39
        public short A36Trium { get; set; }//40
        public short A37Trium { get; set; }//41
        public short A38Trium { get; set; }//42
        public short A41Trium { get; set; }//43
        public short A42Trium { get; set; }//44
        public short A43Trium { get; set; }//45
        public short A44Trium { get; set; }//46
        public short A45Trium { get; set; }//47
        public short A49Trium { get; set; }//48
        public short A51Trium { get; set; }//49
        public short A52Trium { get; set; }//50
        public short A53Trium { get; set; }//51
        public short A55Trium { get; set; }//52
        public short A56Trium { get; set; }//53
        public short A57Trium { get; set; }//54
        public short A58Trium { get; set; }//55
        public short A59Trium { get; set; }//56
        public short A61Trium { get; set; }//57
        public short A66Trium { get; set; }//58
        public short A67Trium { get; set; }//59
        public short A68Trium { get; set; }//60
        public short A70Trium { get; set; }//61
        public short A71Trium { get; set; }//62
        public short A72Trium { get; set; }//63
        public short A73Trium { get; set; }//64
        public short A74Trium { get; set; }//65
        public short A75Trium { get; set; }//66
        public short A76Trium { get; set; }//67
        public short A78Trium { get; set; }//68
        public short A79Trium { get; set; }//69
        public short A80Trium { get; set; }//70
        public short A81Trium { get; set; }//71
        public short A82Trium { get; set; }//72
        public short A84Trium { get; set; }//73
        public short A85Trium { get; set; }//74
        public short A88Trium { get; set; }//75
        public short A89Trium { get; set; }//76
        public short A91Trium { get; set; }//77
        public short A93Trium { get; set; }//78
        public short A2Network { get; set; }//79
        public short A3Network { get; set; }//80
        public short A4Network { get; set; }//81
        public short A6Network { get; set; }//82
        public short A9Network { get; set; }//83
        public short A10Network { get; set; }//84
        public short A12Network { get; set; }//85
        public short A17Network { get; set; }//86
        public short A18Network { get; set; }//87
        public short A19Network { get; set; }//88
        public short A20Network { get; set; }//89
        public short A21Network { get; set; }//90
        public short A23Network { get; set; }//91
        public short A25Network { get; set; }//92
        public short A26Network { get; set; }//93
        public short A27Network { get; set; }//94
        public short A28Network { get; set; }//95
        public short A35Network { get; set; }//96
        public short A37Network { get; set; }//97
        public short A38Network { get; set; }//98
        public short A39Network { get; set; }//99
        public short A41Network { get; set; }//100
        public short A42Network { get; set; }//101
        public short A45Network { get; set; }//102
        public short A49Network { get; set; }//103
        public short A51Network { get; set; }//104
        public short A52Network { get; set; }//105
        public short A53Network { get; set; }//106
        public short A57Network { get; set; }//107
        public short A58Network { get; set; }//108
        public short A59Network { get; set; }//109
        public short A61Network { get; set; }//110
        public short A67Network { get; set; }//111
        public short A68Network { get; set; }//112
        public short A69Network { get; set; }//113
        public short A70Network { get; set; }//114
        public short A72Network { get; set; }//115
        public short A73Network { get; set; }//116
        public short A74Network { get; set; }//117
        public short A75Network { get; set; }//118
        public short A76Network { get; set; }//119
        public short A78Network { get; set; }//120
        public short A79Network { get; set; }//121
        public short A80Network { get; set; }//122
        public short A82Network { get; set; }//123
        public short A84Network { get; set; }//124
        public short A85Network { get; set; }//125
        public short A88Network { get; set; }//126
        public short A89Network { get; set; }//127
        public short A91Network { get; set; }//128
        public short A92Network { get; set; }//129
        public short A3Classic { get; set; }//130
        public short A4Classic { get; set; }//131
        public short A6Classic { get; set; }//132
        public short A19Classic { get; set; }//133
        public short A20Classic { get; set; }
        public short A21Classic { get; set; }
        public short A23Classic { get; set; }
        public short A27Classic { get; set; }
        public short A28Classic { get; set; }
        public short A35Classic { get; set; }
        public short A41Classic { get; set; }//140
        public short A42Classic { get; set; }
        public short A53Classic { get; set; }
        public short A57Classic { get; set; }
        public short A58Classic { get; set; }
        public short A59Classic { get; set; }
        public short A65Classic { get; set; }
        public short A68Classic { get; set; }
        public short A70Classic { get; set; }
        public short A72Classic { get; set; }
        public short A73Classic { get; set; }//150
        public short A74Classic { get; set; }
        public short A75Classic { get; set; }
        public short A77Classic { get; set; }
        public short A78Classic { get; set; }
        public short A82Classic { get; set; }
        public short A84Classic { get; set; }
        public short A91Classic { get; set; }
        public short A94Classic { get; set; }
        public string UstGiyimEbat { get; set; }//159
        public string PantolonEbat { get; set; }//160
        public string BotEbat { get; set; }//161
        public string EldivenEbat { get; set; }//162
        public string BMIndex { get; set; }//163
        public string BKoran { get; set; }//164
        public string Birlik { get; set; }//165
        public string Choosecmb { get; set; }//166
        public string chooseid { get; set; }//167

        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }

        public List<GetIdDetail> Get(string idarama)
        {
           

           connect();

            SqlCommand command = new SqlCommand("Select * From ThesesxData where Id like '%" + @idarama + "%'order by Id DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();
            command.Parameters.AddWithValue("@arama", idarama);



            List<GetIdDetail> getIdDetails = new List<GetIdDetail>();
            while (reader.Read())
            {
                GetIdDetail getIdDetail = new GetIdDetail();
                getIdDetail.Id = Convert.ToInt32(reader["Id"]);



                getIdDetail.Tc = reader["Tc"].ToString();
                getIdDetail.Ad = reader["Ad"].ToString();
                getIdDetail.Soyad = reader["Soyad"].ToString();
                getIdDetail.A77 = Convert.ToInt16(reader["A77"]);
                getIdDetail.A87 = Convert.ToInt16(reader["A87"]);
                getIdDetail.A8 = Convert.ToInt16(reader["A8"]);
                getIdDetail.E101 = Convert.ToInt16(reader["E101"]);
                getIdDetail.E102 = Convert.ToInt16(reader["E102"]);
                getIdDetail.E103 = Convert.ToInt16(reader["E103"]);
                getIdDetail.A2Trium = Convert.ToInt16(reader["A2Trium"]);
                getIdDetail.A3Trium = Convert.ToInt16(reader["A3Trium"]);
                getIdDetail.A4Trium = Convert.ToInt16(reader["A4Trium"]);
                getIdDetail.A5Trium = Convert.ToInt16(reader["A5Trium"]);
                getIdDetail.A6Trium = Convert.ToInt16(reader["A6Trium"]);
                getIdDetail.A7Trium = Convert.ToInt16(reader["A7Trium"]);
                getIdDetail.A9Trium = Convert.ToInt16(reader["A9Trium"]);
                getIdDetail.A12Trium = Convert.ToInt16(reader["A12Trium"]);
                getIdDetail.A13Trium = Convert.ToInt16(reader["A13Trium"]);
                getIdDetail.A17Trium = Convert.ToInt16(reader["A17Trium"]);
                getIdDetail.A18Trium = Convert.ToInt16(reader["A18Trium"]);
                getIdDetail.A19Trium = Convert.ToInt16(reader["A19Trium"]);
                getIdDetail.A20Trium = Convert.ToInt16(reader["A20Trium"]);
                getIdDetail.A21Trium = Convert.ToInt16(reader["A21Trium"]);
                getIdDetail.A22Trium = Convert.ToInt16(reader["A22Trium"]);
                getIdDetail.A23Trium = Convert.ToInt16(reader["A23Trium"]);
                getIdDetail.A25Trium = Convert.ToInt16(reader["A25Trium"]);
                getIdDetail.A26Trium = Convert.ToInt16(reader["A26Trium"]);
                getIdDetail.A27Trium = Convert.ToInt16(reader["A27Trium"]);
                getIdDetail.A28Trium = Convert.ToInt16(reader["A28Trium"]);
                getIdDetail.A29Trium = Convert.ToInt16(reader["A29Trium"]);
                getIdDetail.A30Trium = Convert.ToInt16(reader["A30Trium"]);
                getIdDetail.A35Trium = Convert.ToInt16(reader["A35Trium"]);
                getIdDetail.A36Trium = Convert.ToInt16(reader["A36Trium"]);
                getIdDetail.A37Trium = Convert.ToInt16(reader["A37Trium"]);
                getIdDetail.A38Trium = Convert.ToInt16(reader["A38Trium"]);
                getIdDetail.A41Trium = Convert.ToInt16(reader["A41Trium"]);
                getIdDetail.A42Trium = Convert.ToInt16(reader["A42Trium"]);
                getIdDetail.A43Trium = Convert.ToInt16(reader["A43Trium"]);
                getIdDetail.A44Trium = Convert.ToInt16(reader["A44Trium"]);
                getIdDetail.A45Trium = Convert.ToInt16(reader["A45Trium"]);
                getIdDetail.A49Trium = Convert.ToInt16(reader["A49Trium"]);
                getIdDetail.A51Trium = Convert.ToInt16(reader["A51Trium"]);
                getIdDetail.A52Trium = Convert.ToInt16(reader["A52Trium"]);
                getIdDetail.A53Trium = Convert.ToInt16(reader["A53Trium"]);
                getIdDetail.A55Trium = Convert.ToInt16(reader["A55Trium"]);
                getIdDetail.A56Trium = Convert.ToInt16(reader["A56Trium"]);
                getIdDetail.A57Trium = Convert.ToInt16(reader["A57Trium"]);
                getIdDetail.A58Trium = Convert.ToInt16(reader["A58Trium"]);
                getIdDetail.A59Trium = Convert.ToInt16(reader["A59Trium"]);
                getIdDetail.A61Trium = Convert.ToInt16(reader["A61Trium"]);
                getIdDetail.A66Trium = Convert.ToInt16(reader["A66Trium"]);
                getIdDetail.A67Trium = Convert.ToInt16(reader["A67Trium"]);
                getIdDetail.A68Trium = Convert.ToInt16(reader["A68Trium"]);
                getIdDetail.A70Trium = Convert.ToInt16(reader["A70Trium"]);
                getIdDetail.A71Trium = Convert.ToInt16(reader["A71Trium"]);
                getIdDetail.A72Trium = Convert.ToInt16(reader["A72Trium"]);
                getIdDetail.A73Trium = Convert.ToInt16(reader["A73Trium"]);
                getIdDetail.A74Trium = Convert.ToInt16(reader["A74Trium"]);
                getIdDetail.A75Trium = Convert.ToInt16(reader["A75Trium"]);
                getIdDetail.A76Trium = Convert.ToInt16(reader["A76Trium"]);
                getIdDetail.A78Trium = Convert.ToInt16(reader["A78Trium"]);
                getIdDetail.A79Trium = Convert.ToInt16(reader["A79Trium"]);
                getIdDetail.A80Trium = Convert.ToInt16(reader["A80Trium"]);
                getIdDetail.A81Trium = Convert.ToInt16(reader["A81Trium"]);
                getIdDetail.A82Trium = Convert.ToInt16(reader["A82Trium"]);
                getIdDetail.A84Trium = Convert.ToInt16(reader["A84Trium"]);
                getIdDetail.A85Trium = Convert.ToInt16(reader["A85Trium"]);
                getIdDetail.A88Trium = Convert.ToInt16(reader["A88Trium"]);
                getIdDetail.A89Trium = Convert.ToInt16(reader["A89Trium"]);
                getIdDetail.A91Trium = Convert.ToInt16(reader["A91Trium"]);
                getIdDetail.A93Trium = Convert.ToInt16(reader["A93Trium"]);
                getIdDetail.A2Network = Convert.ToInt16(reader["A2Network"]);
                getIdDetail.A3Network = Convert.ToInt16(reader["A3Network"]);
                getIdDetail.A4Network = Convert.ToInt16(reader["A4Network"]);
                getIdDetail.A6Network = Convert.ToInt16(reader["A6Network"]);
                getIdDetail.A9Network = Convert.ToInt16(reader["A9Network"]);
                getIdDetail.A10Network = Convert.ToInt16(reader["A10Network"]);
                getIdDetail.A12Network = Convert.ToInt16(reader["A12Network"]);
                getIdDetail.A17Network = Convert.ToInt16(reader["A17Network"]);
                getIdDetail.A18Network = Convert.ToInt16(reader["A18Network"]);
                getIdDetail.A19Network = Convert.ToInt16(reader["A19Network"]);
                getIdDetail.A20Network = Convert.ToInt16(reader["A20Network"]);
                getIdDetail.A21Network = Convert.ToInt16(reader["A21Network"]);
                getIdDetail.A23Network = Convert.ToInt16(reader["A23Network"]);
                getIdDetail.A25Network = Convert.ToInt16(reader["A25Network"]);
                getIdDetail.A26Network = Convert.ToInt16(reader["A26Network"]);
                getIdDetail.A27Network = Convert.ToInt16(reader["A27Network"]);
                getIdDetail.A28Network = Convert.ToInt16(reader["A28Network"]);
                getIdDetail.A35Network = Convert.ToInt16(reader["A35Network"]);
                getIdDetail.A37Network = Convert.ToInt16(reader["A37Network"]);
                getIdDetail.A38Network = Convert.ToInt16(reader["A38Network"]);
                getIdDetail.A39Network = Convert.ToInt16(reader["A39Network"]);
                getIdDetail.A41Network = Convert.ToInt16(reader["A41Network"]);
                getIdDetail.A42Network = Convert.ToInt16(reader["A42Network"]);
                getIdDetail.A45Network = Convert.ToInt16(reader["A45Network"]);
                getIdDetail.A49Network = Convert.ToInt16(reader["A49Network"]);
                getIdDetail.A51Network = Convert.ToInt16(reader["A51Network"]);
                getIdDetail.A52Network = Convert.ToInt16(reader["A52Network"]);
                getIdDetail.A53Network = Convert.ToInt16(reader["A53Network"]);
                getIdDetail.A57Network = Convert.ToInt16(reader["A57Network"]);
                getIdDetail.A58Network = Convert.ToInt16(reader["A58Network"]);
                getIdDetail.A59Network = Convert.ToInt16(reader["A59Network"]);
                getIdDetail.A61Network = Convert.ToInt16(reader["A61Network"]);
                getIdDetail.A67Network = Convert.ToInt16(reader["A67Network"]);
                getIdDetail.A68Network = Convert.ToInt16(reader["A68Network"]);
                getIdDetail.A69Network = Convert.ToInt16(reader["A69Network"]);
                getIdDetail.A70Network = Convert.ToInt16(reader["A70Network"]);
                getIdDetail.A72Network = Convert.ToInt16(reader["A72Network"]);
                getIdDetail.A73Network = Convert.ToInt16(reader["A73Network"]);
                getIdDetail.A74Network = Convert.ToInt16(reader["A74Network"]);
                getIdDetail.A75Network = Convert.ToInt16(reader["A75Network"]);
                getIdDetail.A76Network = Convert.ToInt16(reader["A76Network"]);
                getIdDetail.A78Network = Convert.ToInt16(reader["A78Network"]);
                getIdDetail.A79Network = Convert.ToInt16(reader["A79Network"]);
                getIdDetail.A80Network = Convert.ToInt16(reader["A80Network"]);
                getIdDetail.A82Network = Convert.ToInt16(reader["A82Network"]);
                getIdDetail.A84Network = Convert.ToInt16(reader["A84Network"]);
                getIdDetail.A85Network = Convert.ToInt16(reader["A85Network"]);
                getIdDetail.A88Network = Convert.ToInt16(reader["A88Network"]);
                getIdDetail.A89Network = Convert.ToInt16(reader["A89Network"]);
                getIdDetail.A91Network = Convert.ToInt16(reader["A91Network"]);
                getIdDetail.A92Network = Convert.ToInt16(reader["A92Network"]);
                getIdDetail.A3Classic = Convert.ToInt16(reader["A3Classic"]);
                getIdDetail.A4Classic = Convert.ToInt16(reader["A4Classic"]);
                getIdDetail.A6Classic = Convert.ToInt16(reader["A6Classic"]);
                getIdDetail.A19Classic = Convert.ToInt16(reader["A19Classic"]);
                getIdDetail.A20Classic = Convert.ToInt16(reader["A20Classic"]);
                getIdDetail.A21Classic = Convert.ToInt16(reader["A21Classic"]);
                getIdDetail.A23Classic = Convert.ToInt16(reader["A23Classic"]);
                getIdDetail.A27Classic = Convert.ToInt16(reader["A27Classic"]);
                getIdDetail.A28Classic = Convert.ToInt16(reader["A28Classic"]);
                getIdDetail.A35Classic = Convert.ToInt16(reader["A35Classic"]);
                getIdDetail.A41Classic = Convert.ToInt16(reader["A41Classic"]);
                getIdDetail.A42Classic = Convert.ToInt16(reader["A42Classic"]);
                getIdDetail.A53Classic = Convert.ToInt16(reader["A53Classic"]);
                getIdDetail.A57Classic = Convert.ToInt16(reader["A57Classic"]);
                getIdDetail.A58Classic = Convert.ToInt16(reader["A58Classic"]);
                getIdDetail.A59Classic = Convert.ToInt16(reader["A59Classic"]);
                getIdDetail.A65Classic = Convert.ToInt16(reader["A65Classic"]);
                getIdDetail.A68Classic = Convert.ToInt16(reader["A68Classic"]);
                getIdDetail.A70Classic = Convert.ToInt16(reader["A70Classic"]);
                getIdDetail.A72Classic = Convert.ToInt16(reader["A72Classic"]);
                getIdDetail.A73Classic = Convert.ToInt16(reader["A73Classic"]);
                getIdDetail.A74Classic = Convert.ToInt16(reader["A74Classic"]);
                getIdDetail.A75Classic = Convert.ToInt16(reader["A75Classic"]);
                getIdDetail.A77Classic = Convert.ToInt16(reader["A77Classic"]);
                getIdDetail.A78Classic = Convert.ToInt16(reader["A78Classic"]);
                getIdDetail.A82Classic = Convert.ToInt16(reader["A82Classic"]);
                getIdDetail.A84Classic = Convert.ToInt16(reader["A84Classic"]);
                getIdDetail.A91Classic = Convert.ToInt16(reader["A91Classic"]);
                getIdDetail.A94Classic = Convert.ToInt16(reader["A94Classic"]);
                getIdDetail.UstGiyimEbat = reader["UstGiyimEbat"].ToString();
                getIdDetail.BMIndex = (reader["BMIndex"].ToString());
                getIdDetail.BKoran = (reader["BKoran"].ToString());
                getIdDetail.Birlik = reader["Birlik"].ToString();
                getIdDetail.PantolonEbat = reader["PantolonEbat"].ToString();
                getIdDetail.BotEbat = reader["BotEbat"].ToString();
                getIdDetail.EldivenEbat = reader["EldivenEbat"].ToString();


                getIdDetails.Add(getIdDetail);

            }
            reader.Close();
            _baglan.Close();
            return getIdDetails;



        }
    }
}
