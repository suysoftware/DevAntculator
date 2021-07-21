using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Model;
using TezAPPV2.Paths;
using TezAPPV2.Entities;
using TezAPPV2.Abstract;
using System.Data;

namespace TezAPPV2.SqlOperations
{
    class GetStandart
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
        public short A2Trium { get; set; } //17-7
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
        public string UstGiyimEbat { get; set; }//160-7:153
        public string PantolonEbat { get; set; }//255
        public string BotEbat { get; set; }//256
        public string EldivenEbat { get; set; }//257
        public string BMIndex { get; set; }//249
        public string BKoran { get; set; }//250
        public string Birlik { get; set; }//251
        public string Choosecmb { get; set; }//259
        public string chooseid { get; set; }//260


    

        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }

        public List<GetStandart> Get(string arama)
        {
            

            connect();

            SqlCommand command = new SqlCommand("Select * From ThesesxData where " + Choosecmb + " like '%" + @arama + "%'order by Id DESC",_baglan);
            SqlDataReader reader = command.ExecuteReader();
            command.Parameters.AddWithValue("@arama", arama);



            List<GetStandart> getStandarts = new List<GetStandart>();
            while (reader.Read())
            {
                GetStandart getStandart = new GetStandart();
                getStandart.Id = Convert.ToInt32(reader["Id"]);

                getStandart.Tc = reader["Tc"].ToString();
                getStandart.Ad = reader["Ad"].ToString();
                getStandart.Soyad = reader["Soyad"].ToString();
                getStandart.A77 = Convert.ToInt16(reader["A77"]);
                getStandart.A87 = Convert.ToInt16(reader["A87"]);
                getStandart.A8 = Convert.ToInt16(reader["A8"]);
                getStandart.E101 = Convert.ToInt16(reader["E101"]);
                getStandart.E102 = Convert.ToInt16(reader["E102"]);
                getStandart.E103 = Convert.ToInt16(reader["E103"]);
                getStandart.A2Trium = Convert.ToInt16(reader["A2Trium"]);
                getStandart.A3Trium = Convert.ToInt16(reader["A3Trium"]);
                getStandart.A4Trium = Convert.ToInt16(reader["A4Trium"]);
                getStandart.A5Trium = Convert.ToInt16(reader["A5Trium"]);
                getStandart.A6Trium = Convert.ToInt16(reader["A6Trium"]);
                getStandart.A7Trium = Convert.ToInt16(reader["A7Trium"]);
                getStandart.A9Trium = Convert.ToInt16(reader["A9Trium"]);
                getStandart.A12Trium = Convert.ToInt16(reader["A12Trium"]);
                getStandart.A13Trium = Convert.ToInt16(reader["A13Trium"]);
                getStandart.A17Trium = Convert.ToInt16(reader["A17Trium"]);
                getStandart.A18Trium = Convert.ToInt16(reader["A18Trium"]);
                getStandart.A19Trium = Convert.ToInt16(reader["A19Trium"]);
                getStandart.A20Trium = Convert.ToInt16(reader["A20Trium"]);
                getStandart.A21Trium = Convert.ToInt16(reader["A21Trium"]);
                getStandart.A22Trium = Convert.ToInt16(reader["A22Trium"]);
                getStandart.A23Trium = Convert.ToInt16(reader["A23Trium"]);
                getStandart.A25Trium = Convert.ToInt16(reader["A25Trium"]);
                getStandart.A26Trium = Convert.ToInt16(reader["A26Trium"]);
                getStandart.A27Trium = Convert.ToInt16(reader["A27Trium"]);
                getStandart.A28Trium = Convert.ToInt16(reader["A28Trium"]);
                getStandart.A29Trium = Convert.ToInt16(reader["A29Trium"]);
                getStandart.A30Trium = Convert.ToInt16(reader["A30Trium"]);
                getStandart.A35Trium = Convert.ToInt16(reader["A35Trium"]);
                getStandart.A36Trium = Convert.ToInt16(reader["A36Trium"]);
                getStandart.A37Trium = Convert.ToInt16(reader["A37Trium"]);
                getStandart.A38Trium = Convert.ToInt16(reader["A38Trium"]);
                getStandart.A41Trium = Convert.ToInt16(reader["A41Trium"]);
                getStandart.A42Trium = Convert.ToInt16(reader["A42Trium"]);
                getStandart.A43Trium = Convert.ToInt16(reader["A43Trium"]);
                getStandart.A44Trium = Convert.ToInt16(reader["A44Trium"]);
                getStandart.A45Trium = Convert.ToInt16(reader["A45Trium"]);
                getStandart.A49Trium = Convert.ToInt16(reader["A49Trium"]);
                getStandart.A51Trium = Convert.ToInt16(reader["A51Trium"]);
                getStandart.A52Trium = Convert.ToInt16(reader["A52Trium"]);
                getStandart.A53Trium = Convert.ToInt16(reader["A53Trium"]);
                getStandart.A55Trium = Convert.ToInt16(reader["A55Trium"]);
                getStandart.A56Trium = Convert.ToInt16(reader["A56Trium"]);
                getStandart.A57Trium = Convert.ToInt16(reader["A57Trium"]);
                getStandart.A58Trium = Convert.ToInt16(reader["A58Trium"]);
                getStandart.A59Trium = Convert.ToInt16(reader["A59Trium"]);
                getStandart.A61Trium = Convert.ToInt16(reader["A61Trium"]);
                getStandart.A66Trium = Convert.ToInt16(reader["A66Trium"]);
                getStandart.A67Trium = Convert.ToInt16(reader["A67Trium"]);
                getStandart.A68Trium = Convert.ToInt16(reader["A68Trium"]);
                getStandart.A70Trium = Convert.ToInt16(reader["A70Trium"]);
                getStandart.A71Trium = Convert.ToInt16(reader["A71Trium"]);
                getStandart.A72Trium = Convert.ToInt16(reader["A72Trium"]);
                getStandart.A73Trium = Convert.ToInt16(reader["A73Trium"]);
                getStandart.A74Trium = Convert.ToInt16(reader["A74Trium"]);
                getStandart.A75Trium = Convert.ToInt16(reader["A75Trium"]);
                getStandart.A76Trium = Convert.ToInt16(reader["A76Trium"]);
                getStandart.A78Trium = Convert.ToInt16(reader["A78Trium"]);
                getStandart.A79Trium = Convert.ToInt16(reader["A79Trium"]);
                getStandart.A80Trium = Convert.ToInt16(reader["A80Trium"]);
                getStandart.A81Trium = Convert.ToInt16(reader["A81Trium"]);
                getStandart.A82Trium = Convert.ToInt16(reader["A82Trium"]);
                getStandart.A84Trium = Convert.ToInt16(reader["A84Trium"]);
                getStandart.A85Trium = Convert.ToInt16(reader["A85Trium"]);
                getStandart.A88Trium = Convert.ToInt16(reader["A88Trium"]);
                getStandart.A89Trium = Convert.ToInt16(reader["A89Trium"]);
                getStandart.A91Trium = Convert.ToInt16(reader["A91Trium"]);
                getStandart.A93Trium = Convert.ToInt16(reader["A93Trium"]);
                getStandart.A2Network = Convert.ToInt16(reader["A2Network"]);
                getStandart.A3Network = Convert.ToInt16(reader["A3Network"]);
                getStandart.A4Network = Convert.ToInt16(reader["A4Network"]);
                getStandart.A6Network = Convert.ToInt16(reader["A6Network"]);
                getStandart.A9Network = Convert.ToInt16(reader["A9Network"]);
                getStandart.A10Network = Convert.ToInt16(reader["A10Network"]);
                getStandart.A12Network = Convert.ToInt16(reader["A12Network"]);
                getStandart.A17Network = Convert.ToInt16(reader["A17Network"]);
                getStandart.A18Network = Convert.ToInt16(reader["A18Network"]);
                getStandart.A19Network = Convert.ToInt16(reader["A19Network"]);
                getStandart.A20Network = Convert.ToInt16(reader["A20Network"]);
                getStandart.A21Network = Convert.ToInt16(reader["A21Network"]);
                getStandart.A23Network = Convert.ToInt16(reader["A23Network"]);
                getStandart.A25Network = Convert.ToInt16(reader["A25Network"]);
                getStandart.A26Network = Convert.ToInt16(reader["A26Network"]);
                getStandart.A27Network = Convert.ToInt16(reader["A27Network"]);
                getStandart.A28Network = Convert.ToInt16(reader["A28Network"]);
                getStandart.A35Network = Convert.ToInt16(reader["A35Network"]);
                getStandart.A37Network = Convert.ToInt16(reader["A37Network"]);
                getStandart.A38Network = Convert.ToInt16(reader["A38Network"]);
                getStandart.A39Network = Convert.ToInt16(reader["A39Network"]);
                getStandart.A41Network = Convert.ToInt16(reader["A41Network"]);
                getStandart.A42Network = Convert.ToInt16(reader["A42Network"]);
                getStandart.A45Network = Convert.ToInt16(reader["A45Network"]);
                getStandart.A49Network = Convert.ToInt16(reader["A49Network"]);
                getStandart.A51Network = Convert.ToInt16(reader["A51Network"]);
                getStandart.A52Network = Convert.ToInt16(reader["A52Network"]);
                getStandart.A53Network = Convert.ToInt16(reader["A53Network"]);
                getStandart.A57Network = Convert.ToInt16(reader["A57Network"]);
                getStandart.A58Network = Convert.ToInt16(reader["A58Network"]);
                getStandart.A59Network = Convert.ToInt16(reader["A59Network"]);
                getStandart.A61Network = Convert.ToInt16(reader["A61Network"]);
                getStandart.A67Network = Convert.ToInt16(reader["A67Network"]);
                getStandart.A68Network = Convert.ToInt16(reader["A68Network"]);
                getStandart.A69Network = Convert.ToInt16(reader["A69Network"]);
                getStandart.A70Network = Convert.ToInt16(reader["A70Network"]);
                getStandart.A72Network = Convert.ToInt16(reader["A72Network"]);
                getStandart.A73Network = Convert.ToInt16(reader["A73Network"]);
                getStandart.A74Network = Convert.ToInt16(reader["A74Network"]);
                getStandart.A75Network = Convert.ToInt16(reader["A75Network"]);
                getStandart.A76Network = Convert.ToInt16(reader["A76Network"]);
                getStandart.A78Network = Convert.ToInt16(reader["A78Network"]);
                getStandart.A79Network = Convert.ToInt16(reader["A79Network"]);
                getStandart.A80Network = Convert.ToInt16(reader["A80Network"]);
                getStandart.A82Network = Convert.ToInt16(reader["A82Network"]);
                getStandart.A84Network = Convert.ToInt16(reader["A84Network"]);
                getStandart.A85Network = Convert.ToInt16(reader["A85Network"]);
                getStandart.A88Network = Convert.ToInt16(reader["A88Network"]);
                getStandart.A89Network = Convert.ToInt16(reader["A89Network"]);
                getStandart.A91Network = Convert.ToInt16(reader["A91Network"]);
                getStandart.A92Network = Convert.ToInt16(reader["A92Network"]);
                getStandart.A3Classic = Convert.ToInt16(reader["A3Classic"]);
                getStandart.A4Classic = Convert.ToInt16(reader["A4Classic"]);
                getStandart.A6Classic = Convert.ToInt16(reader["A6Classic"]);
                getStandart.A19Classic = Convert.ToInt16(reader["A19Classic"]);
                getStandart.A20Classic = Convert.ToInt16(reader["A20Classic"]);
                getStandart.A21Classic = Convert.ToInt16(reader["A21Classic"]);
                getStandart.A23Classic = Convert.ToInt16(reader["A23Classic"]);
                getStandart.A27Classic = Convert.ToInt16(reader["A27Classic"]);
                getStandart.A28Classic = Convert.ToInt16(reader["A28Classic"]);
                getStandart.A35Classic = Convert.ToInt16(reader["A35Classic"]);
                getStandart.A41Classic = Convert.ToInt16(reader["A41Classic"]);
                getStandart.A42Classic = Convert.ToInt16(reader["A42Classic"]);
                getStandart.A53Classic = Convert.ToInt16(reader["A53Classic"]);
                getStandart.A57Classic = Convert.ToInt16(reader["A57Classic"]);
                getStandart.A58Classic = Convert.ToInt16(reader["A58Classic"]);
                getStandart.A59Classic = Convert.ToInt16(reader["A59Classic"]);
                getStandart.A65Classic = Convert.ToInt16(reader["A65Classic"]);
                getStandart.A68Classic = Convert.ToInt16(reader["A68Classic"]);
                getStandart.A70Classic = Convert.ToInt16(reader["A70Classic"]);
                getStandart.A72Classic = Convert.ToInt16(reader["A72Classic"]);
                getStandart.A73Classic = Convert.ToInt16(reader["A73Classic"]);
                getStandart.A74Classic = Convert.ToInt16(reader["A74Classic"]);
                getStandart.A75Classic = Convert.ToInt16(reader["A75Classic"]);
                getStandart.A77Classic = Convert.ToInt16(reader["A77Classic"]);
                getStandart.A78Classic = Convert.ToInt16(reader["A78Classic"]);
                getStandart.A82Classic = Convert.ToInt16(reader["A82Classic"]);
                getStandart.A84Classic = Convert.ToInt16(reader["A84Classic"]);
                getStandart.A91Classic = Convert.ToInt16(reader["A91Classic"]);
                getStandart.A94Classic = Convert.ToInt16(reader["A94Classic"]);
                getStandart.UstGiyimEbat = reader["UstGiyimEbat"].ToString();
                getStandart.BMIndex = (reader["BMIndex"].ToString());
                getStandart.BKoran = (reader["BKoran"].ToString());
                getStandart.Birlik = reader["Birlik"].ToString();
                getStandart.PantolonEbat = reader["PantolonEbat"].ToString();
                getStandart.BotEbat = reader["BotEbat"].ToString();
                getStandart.EldivenEbat = reader["EldivenEbat"].ToString();



                getStandarts.Add(getStandart);

            }
            reader.Close();
            _baglan.Close();
            return getStandarts;




        }



    }
}
