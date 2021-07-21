using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TezAPPV2.SqlOperations
{
    class LoadThePerson
    {
        public int donem { get; set; }
        public int totalsoldier { get; set; }
        public int karakuvvet { get; set; }
        public int denizkuvvet { get; set; }//270
        public int havakuvvet { get; set; }
        public int karatotalchest { get; set; }
        public int havatotalchest { get; set; }
        public int deniztotalchest { get; set; }
        public int kara_xs_chest { get; set; }
        public int kara_s_chest { get; set; }
        public int kara_m_chest { get; set; }
        public int kara_l_chest { get; set; }
        public int kara_xl_chest { get; set; }
        public int kara_2xl_chest { get; set; }//280
        public int hava_xs_chest { get; set; }
        public int hava_s_chest { get; set; }
        public int hava_m_chest { get; set; }
        public int hava_l_chest { get; set; }
        public int hava_2l_chest { get; set; }
        public int hava_xxl_chest { get; set; }
        public int deniz_xs_chest { get; set; }
        public int deniz_s_chest { get; set; }
        public int deniz_m_chest { get; set; }
        public int deniz_l_chest { get; set; }
        public int deniz_xl_chest { get; set; }
        public int deniz_2xl_chest { get; set; }
        public int karatotalbot { get; set; }
        public int havatotalbot { get; set; }
        public int deniztotalbot { get; set; }
        public int kara_34_bot { get; set; }
        public int kara_35_bot { get; set; }
        public int kara_36_bot { get; set; }
        public int kara_37_bot { get; set; }
        public int kara_38_bot { get; set; }//300
        public int kara_39_bot { get; set; }
        public int kara_40_bot { get; set; }
        public int kara_41_bot { get; set; }
        public int kara_42_bot { get; set; }
        public int kara_43_bot { get; set; }
        public int kara_44_bot { get; set; }
        public int kara_45_bot { get; set; }
        public int kara_46_bot { get; set; }
        public int kara_47_bot { get; set; }
        public int kara_48_bot { get; set; }
        public int hava_34_bot { get; set; }
        public int hava_35_bot { get; set; }
        public int hava_36_bot { get; set; }
        public int hava_37_bot { get; set; }
        public int hava_38_bot { get; set; }
        public int hava_39_bot { get; set; }
        public int hava_40_bot { get; set; }
        public int hava_41_bot { get; set; }
        public int hava_42_bot { get; set; }
        public int hava_43_bot { get; set; }
        public int hava_44_bot { get; set; }
        public int hava_45_bot { get; set; }
        public int hava_46_bot { get; set; }
        public int hava_47_bot { get; set; }
        public int hava_48_bot { get; set; }
        public int deniz_34_bot { get; set; }
        public int deniz_35_bot { get; set; }
        public int deniz_36_bot { get; set; }
        public int deniz_37_bot { get; set; }
        public int deniz_38_bot { get; set; }
        public int deniz_39_bot { get; set; }
        public int deniz_40_bot { get; set; }
        public int deniz_41_bot { get; set; }
        public int deniz_42_bot { get; set; }
        public int deniz_43_bot { get; set; }
        public int deniz_44_bot { get; set; }
        public int deniz_45_bot { get; set; }
        public int deniz_46_bot { get; set; }
        public int deniz_47_bot { get; set; }
        public int deniz_48_bot { get; set; }
        public int karatotalpant { get; set; }
        public int havatotalpant { get; set; }
        public int deniztotalpant { get; set; }
        public int kara_xs_pant { get; set; }
        public int kara_s_pant { get; set; }
        public int kara_m_pant { get; set; }
        public int kara_l_pant { get; set; }
        public int kara_xl_pant { get; set; }
        public int kara_2xl_pant { get; set; }
        public int kara_3xl_pant { get; set; }
        public int kara_bxl_pant { get; set; }
        public int hava_xs_pant { get; set; }
        public int hava_s_pant { get; set; }
        public int hava_m_pant { get; set; }
        public int hava_l_pant { get; set; }
        public int hava_xl_pant { get; set; }
        public int hava_2xl_pant { get; set; }
        public int hava_3xl_pant { get; set; }
        public int hava_bxl_pant { get; set; }
        public int deniz_xs_pant { get; set; }
        public int deniz_s_pant { get; set; }
        public int deniz_m_pant { get; set; }
        public int deniz_l_pant { get; set; }
        public int deniz_xl_pant { get; set; }
        public int deniz_2xl_pant { get; set; }
        public int deniz_3xl_pant { get; set; }
        public int deniz_bxl_pant { get; set; }
        public int karatotalhands { get; set; }
        public int havatotalhands { get; set; }
        public int deniztotalhands { get; set; }
        public int kara_xs_hands { get; set; }
        public int kara_s_hands { get; set; }
        public int kara_m_hands { get; set; }
        public int kara_l_hands { get; set; }
        public int kara_xl_hands { get; set; }
        public int kara_2xl_hands { get; set; }
        public int hava_xs_hands { get; set; }
        public int hava_s_hands { get; set; }
        public int hava_m_hands { get; set; }
        public int hava_l_hands { get; set; }
        public int hava_xl_hands { get; set; }
        public int hava_2xl_hands { get; set; }
        public int deniz_xs_hands { get; set; }
        public int deniz_s_hands { get; set; }
        public int deniz_m_hands { get; set; }
        public int deniz_l_hands { get; set; }
        public int deniz_xl_hands { get; set; }
        public int deniz_2xl_hands { get; set; }
        public int kara_140_150_boy { get; set; }
        public int kara_150_160_boy { get; set; }
        public int kara_160_170_boy { get; set; }
        public int kara_170_180_boy { get; set; }
        public int kara_180_190_boy { get; set; }
        public int kara_190_200_boy { get; set; }
        public int kara_200_210_boy { get; set; }
        public int kara_210_220_boy { get; set; }
        public int kara_220_230_boy { get; set; }
        public int hava_140_150_boy { get; set; }
        public int hava_150_160_boy { get; set; }
        public int hava_160_170_boy { get; set; }
        public int hava_170_180_boy { get; set; }
        public int hava_180_190_boy { get; set; }
        public int hava_190_200_boy { get; set; }
        public int hava_200_210_boy { get; set; }
        public int hava_210_220_boy { get; set; }
        public int hava_220_230_boy { get; set; }
        public int deniz_140_150_boy { get; set; }
        public int deniz_150_160_boy { get; set; }
        public int deniz_160_170_boy { get; set; }
        public int deniz_170_180_boy { get; set; }
        public int deniz_180_190_boy { get; set; }
        public int deniz_190_200_boy { get; set; }
        public int deniz_200_210_boy { get; set; }
        public int deniz_210_220_boy { get; set; }
        public int deniz_220_230_boy { get; set; }
        public int kara_140alti_uyluk { get; set; }
        public int kara_140_180_uyluk { get; set; }
        public int kara_180_220_uyluk { get; set; }
        public int kara_220_260_uyluk { get; set; }
        public int kara_260ustu_uyluk { get; set; }
        public int hava_140alti_uyluk { get; set; }
        public int hava_140_180_uyluk { get; set; }
        public int hava_180_220_uyluk { get; set; }
        public int hava_220_260_uyluk { get; set; }
        public int hava_260ustu_uyluk { get; set; }
        public int deniz_140alti_uyluk { get; set; }
        public int deniz_140_180_uyluk { get; set; }//427
        public int deniz_180_220_uyluk { get; set; }
        public int deniz_220_260_uyluk { get; set; }
        public int deniz_260ustu_uyluk { get; set; }

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
        public string UstGiyimEbat { get; set; }//253
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


        public void LoadPerson(LoadThePerson loadPerson)
        {
          

         

            connect();

            SqlCommand command = new SqlCommand("Update ThesesxData Set Tc=@Tc,Ad=@Ad,Soyad=@Soyad,A77=@A77,A87=@A87,A8=@A8,A2Trium=@A2Trium,A3Trium=@A3Trium,A4Trium=@A4Trium,A5Trium=@A5Trium,A6Trium=@A6Trium,A7Trium=@A7Trium,A9Trium=@A9Trium,A12Trium=@A12Trium,A13Trium=@A13Trium,A17Trium=@A17Trium,A18Trium=@A18Trium,A19Trium=@A19Trium,A20Trium=@A20Trium,A21Trium=@A21Trium,A22Trium=@A22Trium,A23Trium=@A23Trium,A25Trium=@A25Trium,A26Trium=@A26Trium,A27Trium=@A27Trium,A28Trium=@A28Trium,A29Trium=@A29Trium,A30Trium=@A30Trium,A35Trium=@A35Trium,A36Trium=@A36Trium,A37Trium=@A37Trium,A38Trium=@A38Trium,A41Trium=@A41Trium,A42Trium=@A42Trium,A43Trium=@A43Trium,A44Trium=@A44Trium,A45Trium=@A45Trium,A49Trium=@A49Trium,A51Trium=@A51Trium,A52Trium=@A52Trium,A53Trium=@A53Trium,A55Trium=@A55Trium,A56Trium=@A56Trium,A57Trium=@A57Trium,A58Trium=@A58Trium,A59Trium=@A59Trium,A61Trium=@A61Trium,A66Trium=@A66Trium,A67Trium=@A67Trium,A68Trium=@A68Trium,A70Trium=@A70Trium,A71Trium=@A71Trium,A72Trium=@A72Trium,A73Trium=@A73Trium,A74Trium=@A74Trium,A75Trium=@A75Trium,A76Trium=@A76Trium,A78Trium=@A78Trium,A79Trium=@A79Trium,A80Trium=@A80Trium,A81Trium=@A81Trium,A82Trium=@A82Trium,A84Trium=@A84Trium,A85Trium=@A85Trium,A88Trium=@A88Trium,A89Trium=@A89Trium,A91Trium=@A91Trium,A93Trium=@A93Trium,A2Network=@A2Network,A3Network=@A3Network,A4Network=@A4Network,A6Network=@A6Network,A9Network=@A9Network,A10Network=@A10Network,A12Network=@A12Network,A17Network=@A17Network,A18Network=@A18Network,A19Network=@A19Network,A20Network=@A20Network,A21Network=@A21Network,A23Network=@A23Network,A25Network=@A25Network,A26Network=@A26Network,A27Network=@A27Network,A28Network=@A28Network,A35Network=@A35Network,A37Network=@A37Network,A38Network=@A38Network,A39Network=@A39Network,A41Network=@A41Network,A42Network=@A42Network,A45Network=@A45Network,A49Network=@A49Network,A51Network=@A51Network,A52Network=@A52Network,A53Network=@A53Network,A57Network=@A57Network,A58Network=@A58Network,A59Network=@A59Network,A61Network=@A61Network,A67Network=@A67Network,A68Network=@A68Network,A69Network=@A69Network,A70Network=@A70Network,A72Network=@A72Network,A73Network=@A73Network,A74Network=@A74Network,A75Network=@A75Network,A76Network=@A76Network,A78Network=@A78Network,A79Network=@A79Network,A80Network=@A80Network,A82Network=@A82Network,A84Network=@A84Network,A85Network=@A85Network,A88Network=@A88Network,A89Network=@A89Network,A91Network=@A91Network,A92Network=@A92Network Where Id=@Id", _baglan);

            command.Parameters.AddWithValue("@Tc", loadPerson.Tc);
            command.Parameters.AddWithValue("@Ad", loadPerson.Ad);
            command.Parameters.AddWithValue("@Soyad", loadPerson.Soyad);
            command.Parameters.AddWithValue("@A77", loadPerson.A77);
            command.Parameters.AddWithValue("@A87", loadPerson.A87);
            command.Parameters.AddWithValue("@A8", loadPerson.A8);

         


            command.Parameters.AddWithValue("@A2Trium", loadPerson.A2Trium);
            command.Parameters.AddWithValue("@A3Trium", loadPerson.A3Trium);
            command.Parameters.AddWithValue("@A4Trium", loadPerson.A4Trium);
            command.Parameters.AddWithValue("@A5Trium", loadPerson.A5Trium);
            command.Parameters.AddWithValue("@A6Trium", loadPerson.A6Trium);
            command.Parameters.AddWithValue("@A7Trium", loadPerson.A7Trium);
            command.Parameters.AddWithValue("@A9Trium", loadPerson.A9Trium);
            command.Parameters.AddWithValue("@A12Trium", loadPerson.A12Trium);
            command.Parameters.AddWithValue("@A13Trium", loadPerson.A13Trium);
            command.Parameters.AddWithValue("@A17Trium", loadPerson.A17Trium);
            command.Parameters.AddWithValue("@A18Trium", loadPerson.A18Trium);
            command.Parameters.AddWithValue("@A19Trium", loadPerson.A19Trium);
            command.Parameters.AddWithValue("@A20Trium", loadPerson.A20Trium);
            command.Parameters.AddWithValue("@A21Trium", loadPerson.A21Trium);
            command.Parameters.AddWithValue("@A22Trium", loadPerson.A22Trium);
            command.Parameters.AddWithValue("@A23Trium", loadPerson.A23Trium);
            command.Parameters.AddWithValue("@A25Trium", loadPerson.A25Trium);
            command.Parameters.AddWithValue("@A26Trium", loadPerson.A26Trium);
            command.Parameters.AddWithValue("@A27Trium", loadPerson.A27Trium);
            command.Parameters.AddWithValue("@A28Trium", loadPerson.A28Trium);
            command.Parameters.AddWithValue("@A29Trium", loadPerson.A29Trium);
            command.Parameters.AddWithValue("@A30Trium", loadPerson.A30Trium);
            command.Parameters.AddWithValue("@A35Trium", loadPerson.A35Trium);
            command.Parameters.AddWithValue("@A36Trium", loadPerson.A36Trium);
            command.Parameters.AddWithValue("@A37Trium", loadPerson.A37Trium);
            command.Parameters.AddWithValue("@A38Trium", loadPerson.A38Trium);
            command.Parameters.AddWithValue("@A41Trium", loadPerson.A41Trium);
            command.Parameters.AddWithValue("@A42Trium", loadPerson.A42Trium);
            command.Parameters.AddWithValue("@A43Trium", loadPerson.A43Trium);
            command.Parameters.AddWithValue("@A44Trium", loadPerson.A44Trium);
            command.Parameters.AddWithValue("@A45Trium", loadPerson.A45Trium);
            command.Parameters.AddWithValue("@A49Trium", loadPerson.A49Trium);
            command.Parameters.AddWithValue("@A51Trium", loadPerson.A51Trium);
            command.Parameters.AddWithValue("@A52Trium", loadPerson.A52Trium);
            command.Parameters.AddWithValue("@A53Trium", loadPerson.A53Trium);
            command.Parameters.AddWithValue("@A55Trium", loadPerson.A55Trium);
            command.Parameters.AddWithValue("@A56Trium", loadPerson.A56Trium);
            command.Parameters.AddWithValue("@A57Trium", loadPerson.A57Trium);
            command.Parameters.AddWithValue("@A58Trium", loadPerson.A58Trium);
            command.Parameters.AddWithValue("@A59Trium", loadPerson.A59Trium);
            command.Parameters.AddWithValue("@A61Trium", loadPerson.A61Trium);
            command.Parameters.AddWithValue("@A66Trium", loadPerson.A66Trium);
            command.Parameters.AddWithValue("@A67Trium", loadPerson.A67Trium);
            command.Parameters.AddWithValue("@A68Trium", loadPerson.A68Trium);
            command.Parameters.AddWithValue("@A70Trium", loadPerson.A70Trium);
            command.Parameters.AddWithValue("@A71Trium", loadPerson.A71Trium);
            command.Parameters.AddWithValue("@A72Trium", loadPerson.A72Trium);
            command.Parameters.AddWithValue("@A73Trium", loadPerson.A73Trium);
            command.Parameters.AddWithValue("@A74Trium", loadPerson.A74Trium);
            command.Parameters.AddWithValue("@A75Trium", loadPerson.A75Trium);
            command.Parameters.AddWithValue("@A76Trium", loadPerson.A76Trium);
            command.Parameters.AddWithValue("@A78Trium", loadPerson.A78Trium);
            command.Parameters.AddWithValue("@A79Trium", loadPerson.A79Trium);
            command.Parameters.AddWithValue("@A80Trium", loadPerson.A80Trium);
            command.Parameters.AddWithValue("@A81Trium", loadPerson.A81Trium);
            command.Parameters.AddWithValue("@A82Trium", loadPerson.A82Trium);
            command.Parameters.AddWithValue("@A84Trium", loadPerson.A84Trium);
            command.Parameters.AddWithValue("@A85Trium", loadPerson.A85Trium);
            command.Parameters.AddWithValue("@A88Trium", loadPerson.A88Trium);
            command.Parameters.AddWithValue("@A89Trium", loadPerson.A89Trium);
            command.Parameters.AddWithValue("@A91Trium", loadPerson.A91Trium);
            command.Parameters.AddWithValue("@A93Trium", loadPerson.A93Trium);
            command.Parameters.AddWithValue("@A2Network", loadPerson.A2Network);
            command.Parameters.AddWithValue("@A3Network", loadPerson.A3Network);
            command.Parameters.AddWithValue("@A4Network", loadPerson.A4Network);
            command.Parameters.AddWithValue("@A6Network", loadPerson.A6Network);
            command.Parameters.AddWithValue("@A9Network", loadPerson.A9Network);
            command.Parameters.AddWithValue("@A10Network", loadPerson.A10Network);
            command.Parameters.AddWithValue("@A12Network", loadPerson.A12Network);
            command.Parameters.AddWithValue("@A17Network", loadPerson.A17Network);
            command.Parameters.AddWithValue("@A18Network", loadPerson.A18Network);
            command.Parameters.AddWithValue("@A19Network", loadPerson.A19Network);
            command.Parameters.AddWithValue("@A20Network", loadPerson.A20Network);
            command.Parameters.AddWithValue("@A21Network", loadPerson.A21Network);
            command.Parameters.AddWithValue("@A23Network", loadPerson.A23Network);
            command.Parameters.AddWithValue("@A25Network", loadPerson.A25Network);
            command.Parameters.AddWithValue("@A26Network", loadPerson.A26Network);
            command.Parameters.AddWithValue("@A27Network", loadPerson.A27Network);
            command.Parameters.AddWithValue("@A28Network", loadPerson.A28Network);
            command.Parameters.AddWithValue("@A35Network", loadPerson.A35Network);
            command.Parameters.AddWithValue("@A37Network", loadPerson.A37Network);
            command.Parameters.AddWithValue("@A38Network", loadPerson.A38Network);
            command.Parameters.AddWithValue("@A39Network", loadPerson.A39Network);
            command.Parameters.AddWithValue("@A41Network", loadPerson.A41Network);
            command.Parameters.AddWithValue("@A42Network", loadPerson.A42Network);
            command.Parameters.AddWithValue("@A45Network", loadPerson.A45Network);
            command.Parameters.AddWithValue("@A49Network", loadPerson.A49Network);
            command.Parameters.AddWithValue("@A51Network", loadPerson.A51Network);
            command.Parameters.AddWithValue("@A52Network", loadPerson.A52Network);
            command.Parameters.AddWithValue("@A53Network", loadPerson.A53Network);
            command.Parameters.AddWithValue("@A57Network", loadPerson.A57Network);
            command.Parameters.AddWithValue("@A58Network", loadPerson.A58Network);
            command.Parameters.AddWithValue("@A59Network", loadPerson.A59Network);
            command.Parameters.AddWithValue("@A61Network", loadPerson.A61Network);
            command.Parameters.AddWithValue("@A67Network", loadPerson.A67Network);
            command.Parameters.AddWithValue("@A68Network", loadPerson.A68Network);
            command.Parameters.AddWithValue("@A69Network", loadPerson.A69Network);
            command.Parameters.AddWithValue("@A70Network", loadPerson.A70Network);
            command.Parameters.AddWithValue("@A72Network", loadPerson.A72Network);
            command.Parameters.AddWithValue("@A73Network", loadPerson.A73Network);
            command.Parameters.AddWithValue("@A74Network", loadPerson.A74Network);
            command.Parameters.AddWithValue("@A75Network", loadPerson.A75Network);
            command.Parameters.AddWithValue("@A76Network", loadPerson.A76Network);
            command.Parameters.AddWithValue("@A78Network", loadPerson.A78Network);
            command.Parameters.AddWithValue("@A79Network", loadPerson.A79Network);
            command.Parameters.AddWithValue("@A80Network", loadPerson.A80Network);
            command.Parameters.AddWithValue("@A82Network", loadPerson.A82Network);
            command.Parameters.AddWithValue("@A84Network", loadPerson.A84Network);
            command.Parameters.AddWithValue("@A85Network", loadPerson.A85Network);
            command.Parameters.AddWithValue("@A88Network", loadPerson.A88Network);
            command.Parameters.AddWithValue("@A89Network", loadPerson.A89Network);
            command.Parameters.AddWithValue("@A91Network", loadPerson.A91Network);
            command.Parameters.AddWithValue("@A92Network", loadPerson.A92Network);
     
            //command.Parameters.AddWithValue("@UstGiyimEbat", loadPerson.UstGiyimEbat);
            //command.Parameters.AddWithValue("@BMIndex", loadPerson.BMIndex);
            //command.Parameters.AddWithValue("@BKoran", loadPerson.BKoran);
            //command.Parameters.AddWithValue("@Birlik", loadPerson.Birlik);
            //command.Parameters.AddWithValue("@PantolonEbat", loadPerson.PantolonEbat);
            //command.Parameters.AddWithValue("@BotEbat", loadPerson.BotEbat);
            //command.Parameters.AddWithValue("@EldivenEbat", loadPerson.EldivenEbat);

            command.Parameters.AddWithValue("@Id", loadPerson.Id);

            command.ExecuteNonQuery();




            //SqlCommand commandsayac = new SqlCommand("Update Dashboarddata Set totalsoldier=totalsoldier+@totalsoldier,karakuvvet=karakuvvet+@karakuvvet,denizkuvvet=denizkuvvet+@denizkuvvet,havakuvvet=havakuvvet+@havakuvvet,karatotalchest = karatotalchest + @karatotalchest,havatotalchest = havatotalchest + @havatotalchest,deniztotalchest = deniztotalchest + @deniztotalchest,kara_xs_chest = kara_xs_chest + @kara_xs_chest,kara_s_chest = kara_s_chest + @kara_s_chest,kara_m_chest = kara_m_chest + @kara_m_chest,kara_l_chest = kara_l_chest + @kara_l_chest,kara_xl_chest = kara_xl_chest + @kara_xl_chest,kara_2xl_chest = kara_2xl_chest + @kara_2xl_chest,hava_xs_chest = hava_xs_chest + @hava_xs_chest,hava_s_chest = hava_s_chest + @hava_s_chest,hava_m_chest = hava_m_chest + @hava_m_chest,hava_l_chest = hava_l_chest + @hava_l_chest,hava_2l_chest = hava_2l_chest + @hava_2l_chest,hava_xxl_chest = hava_xxl_chest + @hava_xxl_chest,deniz_xs_chest = deniz_xs_chest + @deniz_xs_chest,deniz_s_chest = deniz_s_chest + @deniz_s_chest,deniz_m_chest = deniz_m_chest + @deniz_m_chest,deniz_l_chest = deniz_l_chest + @deniz_l_chest,deniz_xl_chest = deniz_xl_chest + @deniz_xl_chest,deniz_2xl_chest = deniz_2xl_chest + @deniz_2xl_chest,karatotalbot = karatotalbot + @karatotalbot,havatotalbot = havatotalbot + @havatotalbot,deniztotalbot = deniztotalbot + @deniztotalbot,kara_34_bot = kara_34_bot + @kara_34_bot,kara_35_bot = kara_35_bot + @kara_35_bot,kara_36_bot = kara_36_bot + @kara_36_bot,kara_37_bot = kara_37_bot + @kara_37_bot,kara_38_bot = kara_38_bot + @kara_38_bot,kara_39_bot = kara_39_bot + @kara_39_bot,kara_40_bot = kara_40_bot + @kara_40_bot,kara_41_bot = kara_41_bot + @kara_41_bot,kara_42_bot = kara_42_bot + @kara_42_bot,kara_43_bot = kara_43_bot + @kara_43_bot,kara_44_bot = kara_44_bot + @kara_44_bot,kara_45_bot = kara_45_bot + @kara_45_bot,kara_46_bot = kara_46_bot + @kara_46_bot,kara_47_bot = kara_47_bot + @kara_47_bot,kara_48_bot = kara_48_bot + @kara_48_bot,hava_34_bot = hava_34_bot + @hava_34_bot,hava_35_bot = hava_35_bot + @hava_35_bot,hava_36_bot = hava_36_bot + @hava_36_bot,hava_37_bot = hava_37_bot + @hava_37_bot,hava_38_bot = hava_38_bot + @hava_38_bot,hava_39_bot = hava_39_bot + @hava_39_bot,hava_40_bot = hava_40_bot + @hava_40_bot,hava_41_bot = hava_41_bot + @hava_41_bot,hava_42_bot = hava_42_bot + @hava_42_bot,hava_43_bot = hava_43_bot + @hava_43_bot,hava_44_bot = hava_44_bot + @hava_44_bot,hava_45_bot = hava_45_bot + @hava_45_bot,hava_46_bot = hava_46_bot + @hava_46_bot,hava_47_bot = hava_47_bot + @hava_47_bot,hava_48_bot = hava_48_bot + @hava_48_bot,deniz_34_bot = deniz_34_bot + @deniz_34_bot,deniz_35_bot = deniz_35_bot + @deniz_35_bot,deniz_36_bot = deniz_36_bot + @deniz_36_bot,deniz_37_bot = deniz_37_bot + @deniz_37_bot,deniz_38_bot = deniz_38_bot + @deniz_38_bot,deniz_39_bot = deniz_39_bot + @deniz_39_bot,deniz_40_bot = deniz_40_bot + @deniz_40_bot,deniz_41_bot = deniz_41_bot + @deniz_41_bot,deniz_42_bot = deniz_42_bot + @deniz_42_bot,deniz_43_bot = deniz_43_bot + @deniz_43_bot,deniz_44_bot = deniz_44_bot + @deniz_44_bot,deniz_45_bot = deniz_45_bot + @deniz_45_bot,deniz_46_bot = deniz_46_bot + @deniz_46_bot,deniz_47_bot = deniz_47_bot + @deniz_47_bot,deniz_48_bot = deniz_48_bot + @deniz_48_bot,karatotalpant = karatotalpant + @karatotalpant,havatotalpant = havatotalpant + @havatotalpant,deniztotalpant = deniztotalpant + @deniztotalpant,kara_xs_pant = kara_xs_pant + @kara_xs_pant,kara_s_pant = kara_s_pant + @kara_s_pant,kara_m_pant = kara_m_pant + @kara_m_pant,kara_l_pant = kara_l_pant + @kara_l_pant,kara_xl_pant = kara_xl_pant + @kara_xl_pant,kara_2xl_pant = kara_2xl_pant + @kara_2xl_pant,kara_3xl_pant = kara_3xl_pant + @kara_3xl_pant,kara_bxl_pant = kara_bxl_pant + @kara_bxl_pant,hava_xs_pant = hava_xs_pant + @hava_xs_pant,hava_s_pant = hava_s_pant + @hava_s_pant,hava_m_pant = hava_m_pant + @hava_m_pant,hava_l_pant = hava_l_pant + @hava_l_pant,hava_xl_pant = hava_xl_pant + @hava_xl_pant,hava_2xl_pant = hava_2xl_pant + @hava_2xl_pant,hava_3xl_pant = hava_3xl_pant + @hava_3xl_pant,hava_bxl_pant = hava_bxl_pant + @hava_bxl_pant,deniz_xs_pant = deniz_xs_pant + @deniz_xs_pant,deniz_s_pant = deniz_s_pant + @deniz_s_pant,deniz_m_pant = deniz_m_pant + @deniz_m_pant,deniz_l_pant = deniz_l_pant + @deniz_l_pant,deniz_xl_pant = deniz_xl_pant + @deniz_xl_pant,deniz_2xl_pant = deniz_2xl_pant + @deniz_2xl_pant,deniz_3xl_pant = deniz_3xl_pant + @deniz_3xl_pant,deniz_bxl_pant = deniz_bxl_pant + @deniz_bxl_pant,karatotalhands = karatotalhands + @karatotalhands,havatotalhands = havatotalhands + @havatotalhands,deniztotalhands = deniztotalhands + @deniztotalhands,kara_xs_hands = kara_xs_hands + @kara_xs_hands,kara_s_hands = kara_s_hands + @kara_s_hands,kara_m_hands = kara_m_hands + @kara_m_hands,kara_l_hands = kara_l_hands + @kara_l_hands,kara_xl_hands = kara_xl_hands + @kara_xl_hands,kara_2xl_hands = kara_2xl_hands + @kara_2xl_hands,hava_xs_hands = hava_xs_hands + @hava_xs_hands,hava_s_hands = hava_s_hands + @hava_s_hands,hava_m_hands = hava_m_hands + @hava_m_hands,hava_l_hands = hava_l_hands + @hava_l_hands,hava_xl_hands = hava_xl_hands + @hava_xl_hands,hava_2xl_hands = hava_2xl_hands + @hava_2xl_hands,deniz_xs_hands = deniz_xs_hands + @deniz_xs_hands,deniz_s_hands = deniz_s_hands + @deniz_s_hands,deniz_m_hands = deniz_m_hands + @deniz_m_hands,deniz_l_hands = deniz_l_hands + @deniz_l_hands,deniz_xl_hands = deniz_xl_hands + @deniz_xl_hands,deniz_2xl_hands = deniz_2xl_hands + @deniz_2xl_hands,kara_140_150_boy = kara_140_150_boy + @kara_140_150_boy,kara_150_160_boy = kara_150_160_boy + @kara_150_160_boy,kara_160_170_boy = kara_160_170_boy + @kara_160_170_boy,kara_170_180_boy = kara_170_180_boy + @kara_170_180_boy,kara_180_190_boy = kara_180_190_boy + @kara_180_190_boy,kara_190_200_boy = kara_190_200_boy + @kara_190_200_boy,kara_200_210_boy = kara_200_210_boy + @kara_200_210_boy,kara_210_220_boy = kara_210_220_boy + @kara_210_220_boy,kara_220_230_boy = kara_220_230_boy + @kara_220_230_boy,hava_140_150_boy = hava_140_150_boy + @hava_140_150_boy,hava_150_160_boy = hava_150_160_boy + @hava_150_160_boy,hava_160_170_boy = hava_160_170_boy + @hava_160_170_boy,hava_170_180_boy = hava_170_180_boy + @hava_170_180_boy,hava_180_190_boy = hava_180_190_boy + @hava_180_190_boy,hava_190_200_boy = hava_190_200_boy + @hava_190_200_boy,hava_200_210_boy = hava_200_210_boy + @hava_200_210_boy,hava_210_220_boy = hava_210_220_boy + @hava_210_220_boy,hava_220_230_boy = hava_220_230_boy + @hava_220_230_boy,deniz_140_150_boy = deniz_140_150_boy + @deniz_140_150_boy,deniz_150_160_boy = deniz_150_160_boy + @deniz_150_160_boy,deniz_160_170_boy = deniz_160_170_boy + @deniz_160_170_boy,deniz_170_180_boy = deniz_170_180_boy + @deniz_170_180_boy,deniz_180_190_boy = deniz_180_190_boy + @deniz_180_190_boy,deniz_190_200_boy = deniz_190_200_boy + @deniz_190_200_boy,deniz_200_210_boy = deniz_200_210_boy + @deniz_200_210_boy,deniz_210_220_boy = deniz_210_220_boy + @deniz_210_220_boy,deniz_220_230_boy = deniz_220_230_boy + @deniz_220_230_boy,kara_140alti_uyluk = kara_140alti_uyluk + @kara_140alti_uyluk,kara_140_180_uyluk = kara_140_180_uyluk + @kara_140_180_uyluk,kara_180_220_uyluk = kara_180_220_uyluk + @kara_180_220_uyluk,kara_220_260_uyluk = kara_220_260_uyluk + @kara_220_260_uyluk,kara_260ustu_uyluk = kara_260ustu_uyluk + @kara_260ustu_uyluk,hava_140alti_uyluk = hava_140alti_uyluk + @hava_140alti_uyluk,hava_140_180_uyluk = hava_140_180_uyluk + @hava_140_180_uyluk,hava_180_220_uyluk = hava_180_220_uyluk + @hava_180_220_uyluk,hava_220_260_uyluk = hava_220_260_uyluk + @hava_220_260_uyluk,hava_260ustu_uyluk = hava_260ustu_uyluk + @hava_260ustu_uyluk,deniz_140alti_uyluk = deniz_140alti_uyluk + @deniz_140alti_uyluk,deniz_140_180_uyluk = deniz_140_180_uyluk + @deniz_140_180_uyluk,deniz_180_220_uyluk = deniz_180_220_uyluk + @deniz_180_220_uyluk,deniz_220_260_uyluk = deniz_220_260_uyluk + @deniz_220_260_uyluk,deniz_260ustu_uyluk = deniz_260ustu_uyluk + @deniz_260ustu_uyluk Where donem=IDENT_CURRENT('Dashboarddata')", _baglan);



            //commandsayac.Parameters.AddWithValue("@totalsoldier", loadPerson.totalsoldier);
            //commandsayac.Parameters.AddWithValue("@karakuvvet", loadPerson.karakuvvet);
            //commandsayac.Parameters.AddWithValue("@denizkuvvet", loadPerson.denizkuvvet);
            //commandsayac.Parameters.AddWithValue("@havakuvvet", loadPerson.havakuvvet);
            //commandsayac.Parameters.AddWithValue("@karatotalchest", loadPerson.karatotalchest);
            //commandsayac.Parameters.AddWithValue("@havatotalchest", loadPerson.havatotalchest);
            //commandsayac.Parameters.AddWithValue("@deniztotalchest", loadPerson.deniztotalchest);
            //commandsayac.Parameters.AddWithValue("@kara_xs_chest", loadPerson.kara_xs_chest);
            //commandsayac.Parameters.AddWithValue("@kara_s_chest", loadPerson.kara_s_chest);
            //commandsayac.Parameters.AddWithValue("@kara_m_chest", loadPerson.kara_m_chest);
            //commandsayac.Parameters.AddWithValue("@kara_l_chest", loadPerson.kara_l_chest);
            //commandsayac.Parameters.AddWithValue("@kara_xl_chest", loadPerson.kara_xl_chest);
            //commandsayac.Parameters.AddWithValue("@kara_2xl_chest", loadPerson.kara_2xl_chest);
            //commandsayac.Parameters.AddWithValue("@hava_xs_chest", loadPerson.hava_xs_chest);
            //commandsayac.Parameters.AddWithValue("@hava_s_chest", loadPerson.hava_s_chest);
            //commandsayac.Parameters.AddWithValue("@hava_m_chest", loadPerson.hava_m_chest);
            //commandsayac.Parameters.AddWithValue("@hava_l_chest", loadPerson.hava_l_chest);
            //commandsayac.Parameters.AddWithValue("@hava_2l_chest", loadPerson.hava_2l_chest);
            //commandsayac.Parameters.AddWithValue("@hava_xxl_chest", loadPerson.hava_xxl_chest);
            //commandsayac.Parameters.AddWithValue("@deniz_xs_chest", loadPerson.deniz_xs_chest);
            //commandsayac.Parameters.AddWithValue("@deniz_s_chest", loadPerson.deniz_s_chest);
            //commandsayac.Parameters.AddWithValue("@deniz_m_chest", loadPerson.deniz_m_chest);
            //commandsayac.Parameters.AddWithValue("@deniz_l_chest", loadPerson.deniz_l_chest);
            //commandsayac.Parameters.AddWithValue("@deniz_xl_chest", loadPerson.deniz_xl_chest);
            //commandsayac.Parameters.AddWithValue("@deniz_2xl_chest", loadPerson.deniz_2xl_chest);
            //commandsayac.Parameters.AddWithValue("@karatotalbot", loadPerson.karatotalbot);
            //commandsayac.Parameters.AddWithValue("@havatotalbot", loadPerson.havatotalbot);
            //commandsayac.Parameters.AddWithValue("@deniztotalbot", loadPerson.deniztotalbot);
            //commandsayac.Parameters.AddWithValue("@kara_34_bot", loadPerson.kara_34_bot);
            //commandsayac.Parameters.AddWithValue("@kara_35_bot", loadPerson.kara_35_bot);
            //commandsayac.Parameters.AddWithValue("@kara_36_bot", loadPerson.kara_36_bot);
            //commandsayac.Parameters.AddWithValue("@kara_37_bot", loadPerson.kara_37_bot);
            //commandsayac.Parameters.AddWithValue("@kara_38_bot", loadPerson.kara_38_bot);
            //commandsayac.Parameters.AddWithValue("@kara_39_bot", loadPerson.kara_39_bot);
            //commandsayac.Parameters.AddWithValue("@kara_40_bot", loadPerson.kara_40_bot);
            //commandsayac.Parameters.AddWithValue("@kara_41_bot", loadPerson.kara_41_bot);
            //commandsayac.Parameters.AddWithValue("@kara_42_bot", loadPerson.kara_42_bot);
            //commandsayac.Parameters.AddWithValue("@kara_43_bot", loadPerson.kara_43_bot);
            //commandsayac.Parameters.AddWithValue("@kara_44_bot", loadPerson.kara_44_bot);
            //commandsayac.Parameters.AddWithValue("@kara_45_bot", loadPerson.kara_45_bot);
            //commandsayac.Parameters.AddWithValue("@kara_46_bot", loadPerson.kara_46_bot);
            //commandsayac.Parameters.AddWithValue("@kara_47_bot", loadPerson.kara_47_bot);
            //commandsayac.Parameters.AddWithValue("@kara_48_bot", loadPerson.kara_48_bot);
            //commandsayac.Parameters.AddWithValue("@hava_34_bot", loadPerson.hava_34_bot);
            //commandsayac.Parameters.AddWithValue("@hava_35_bot", loadPerson.hava_35_bot);
            //commandsayac.Parameters.AddWithValue("@hava_36_bot", loadPerson.hava_36_bot);
            //commandsayac.Parameters.AddWithValue("@hava_37_bot", loadPerson.hava_37_bot);
            //commandsayac.Parameters.AddWithValue("@hava_38_bot", loadPerson.hava_38_bot);
            //commandsayac.Parameters.AddWithValue("@hava_39_bot", loadPerson.hava_39_bot);
            //commandsayac.Parameters.AddWithValue("@hava_40_bot", loadPerson.hava_40_bot);
            //commandsayac.Parameters.AddWithValue("@hava_41_bot", loadPerson.hava_41_bot);
            //commandsayac.Parameters.AddWithValue("@hava_42_bot", loadPerson.hava_42_bot);
            //commandsayac.Parameters.AddWithValue("@hava_43_bot", loadPerson.hava_43_bot);
            //commandsayac.Parameters.AddWithValue("@hava_44_bot", loadPerson.hava_44_bot);
            //commandsayac.Parameters.AddWithValue("@hava_45_bot", loadPerson.hava_45_bot);
            //commandsayac.Parameters.AddWithValue("@hava_46_bot", loadPerson.hava_46_bot);
            //commandsayac.Parameters.AddWithValue("@hava_47_bot", loadPerson.hava_47_bot);
            //commandsayac.Parameters.AddWithValue("@hava_48_bot", loadPerson.hava_48_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_34_bot", loadPerson.deniz_34_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_35_bot", loadPerson.deniz_35_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_36_bot", loadPerson.deniz_36_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_37_bot", loadPerson.deniz_37_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_38_bot", loadPerson.deniz_38_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_39_bot", loadPerson.deniz_39_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_40_bot", loadPerson.deniz_40_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_41_bot", loadPerson.deniz_41_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_42_bot", loadPerson.deniz_42_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_43_bot", loadPerson.deniz_43_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_44_bot", loadPerson.deniz_44_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_45_bot", loadPerson.deniz_45_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_46_bot", loadPerson.deniz_46_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_47_bot", loadPerson.deniz_47_bot);
            //commandsayac.Parameters.AddWithValue("@deniz_48_bot", loadPerson.deniz_48_bot);
            //commandsayac.Parameters.AddWithValue("@karatotalpant", loadPerson.karatotalpant);
            //commandsayac.Parameters.AddWithValue("@havatotalpant", loadPerson.havatotalpant);
            //commandsayac.Parameters.AddWithValue("@deniztotalpant", loadPerson.deniztotalpant);
            //commandsayac.Parameters.AddWithValue("@kara_xs_pant", loadPerson.kara_xs_pant);
            //commandsayac.Parameters.AddWithValue("@kara_s_pant", loadPerson.kara_s_pant);
            //commandsayac.Parameters.AddWithValue("@kara_m_pant", loadPerson.kara_m_pant);
            //commandsayac.Parameters.AddWithValue("@kara_l_pant", loadPerson.kara_l_pant);
            //commandsayac.Parameters.AddWithValue("@kara_xl_pant", loadPerson.kara_xl_pant);
            //commandsayac.Parameters.AddWithValue("@kara_2xl_pant", loadPerson.kara_2xl_pant);
            //commandsayac.Parameters.AddWithValue("@kara_3xl_pant", loadPerson.kara_3xl_pant);
            //commandsayac.Parameters.AddWithValue("@kara_bxl_pant", loadPerson.kara_bxl_pant);
            //commandsayac.Parameters.AddWithValue("@hava_xs_pant", loadPerson.hava_xs_pant);
            //commandsayac.Parameters.AddWithValue("@hava_s_pant", loadPerson.hava_s_pant);
            //commandsayac.Parameters.AddWithValue("@hava_m_pant", loadPerson.hava_m_pant);
            //commandsayac.Parameters.AddWithValue("@hava_l_pant", loadPerson.hava_l_pant);
            //commandsayac.Parameters.AddWithValue("@hava_xl_pant", loadPerson.hava_xl_pant);
            //commandsayac.Parameters.AddWithValue("@hava_2xl_pant", loadPerson.hava_2xl_pant);
            //commandsayac.Parameters.AddWithValue("@hava_3xl_pant", loadPerson.hava_3xl_pant);
            //commandsayac.Parameters.AddWithValue("@hava_bxl_pant", loadPerson.hava_bxl_pant);
            //commandsayac.Parameters.AddWithValue("@deniz_xs_pant", loadPerson.deniz_xs_pant);
            //commandsayac.Parameters.AddWithValue("@deniz_s_pant", loadPerson.deniz_s_pant);
            //commandsayac.Parameters.AddWithValue("@deniz_m_pant", loadPerson.deniz_m_pant);
            //commandsayac.Parameters.AddWithValue("@deniz_l_pant", loadPerson.deniz_l_pant);
            //commandsayac.Parameters.AddWithValue("@deniz_xl_pant", loadPerson.deniz_xl_pant);
            //commandsayac.Parameters.AddWithValue("@deniz_2xl_pant", loadPerson.deniz_2xl_pant);
            //commandsayac.Parameters.AddWithValue("@deniz_3xl_pant", loadPerson.deniz_3xl_pant);
            //commandsayac.Parameters.AddWithValue("@deniz_bxl_pant", loadPerson.deniz_bxl_pant);
            //commandsayac.Parameters.AddWithValue("@karatotalhands", loadPerson.karatotalhands);
            //commandsayac.Parameters.AddWithValue("@havatotalhands", loadPerson.havatotalhands);
            //commandsayac.Parameters.AddWithValue("@deniztotalhands", loadPerson.deniztotalhands);
            //commandsayac.Parameters.AddWithValue("@kara_xs_hands", loadPerson.kara_xs_hands);
            //commandsayac.Parameters.AddWithValue("@kara_s_hands", loadPerson.kara_s_hands);
            //commandsayac.Parameters.AddWithValue("@kara_m_hands", loadPerson.kara_m_hands);
            //commandsayac.Parameters.AddWithValue("@kara_l_hands", loadPerson.kara_l_hands);
            //commandsayac.Parameters.AddWithValue("@kara_xl_hands", loadPerson.kara_xl_hands);
            //commandsayac.Parameters.AddWithValue("@kara_2xl_hands", loadPerson.kara_2xl_hands);
            //commandsayac.Parameters.AddWithValue("@hava_xs_hands", loadPerson.hava_xs_hands);
            //commandsayac.Parameters.AddWithValue("@hava_s_hands", loadPerson.hava_s_hands);
            //commandsayac.Parameters.AddWithValue("@hava_m_hands", loadPerson.hava_m_hands);
            //commandsayac.Parameters.AddWithValue("@hava_l_hands", loadPerson.hava_l_hands);
            //commandsayac.Parameters.AddWithValue("@hava_xl_hands", loadPerson.hava_xl_hands);
            //commandsayac.Parameters.AddWithValue("@hava_2xl_hands", loadPerson.hava_2xl_hands);
            //commandsayac.Parameters.AddWithValue("@deniz_xs_hands", loadPerson.deniz_xs_hands);
            //commandsayac.Parameters.AddWithValue("@deniz_s_hands", loadPerson.deniz_s_hands);
            //commandsayac.Parameters.AddWithValue("@deniz_m_hands", loadPerson.deniz_m_hands);
            //commandsayac.Parameters.AddWithValue("@deniz_l_hands", loadPerson.deniz_l_hands);
            //commandsayac.Parameters.AddWithValue("@deniz_xl_hands", loadPerson.deniz_xl_hands);
            //commandsayac.Parameters.AddWithValue("@deniz_2xl_hands", loadPerson.deniz_2xl_hands);
            //commandsayac.Parameters.AddWithValue("@kara_140_150_boy", loadPerson.kara_140_150_boy);
            //commandsayac.Parameters.AddWithValue("@kara_150_160_boy", loadPerson.kara_150_160_boy);
            //commandsayac.Parameters.AddWithValue("@kara_160_170_boy", loadPerson.kara_160_170_boy);
            //commandsayac.Parameters.AddWithValue("@kara_170_180_boy", loadPerson.kara_170_180_boy);
            //commandsayac.Parameters.AddWithValue("@kara_180_190_boy", loadPerson.kara_180_190_boy);
            //commandsayac.Parameters.AddWithValue("@kara_190_200_boy", loadPerson.kara_190_200_boy);
            //commandsayac.Parameters.AddWithValue("@kara_200_210_boy", loadPerson.kara_200_210_boy);
            //commandsayac.Parameters.AddWithValue("@kara_210_220_boy", loadPerson.kara_210_220_boy);
            //commandsayac.Parameters.AddWithValue("@kara_220_230_boy", loadPerson.kara_220_230_boy);
            //commandsayac.Parameters.AddWithValue("@hava_140_150_boy", loadPerson.hava_140_150_boy);
            //commandsayac.Parameters.AddWithValue("@hava_150_160_boy", loadPerson.hava_150_160_boy);
            //commandsayac.Parameters.AddWithValue("@hava_160_170_boy", loadPerson.hava_160_170_boy);
            //commandsayac.Parameters.AddWithValue("@hava_170_180_boy", loadPerson.hava_170_180_boy);
            //commandsayac.Parameters.AddWithValue("@hava_180_190_boy", loadPerson.hava_180_190_boy);
            //commandsayac.Parameters.AddWithValue("@hava_190_200_boy", loadPerson.hava_190_200_boy);
            //commandsayac.Parameters.AddWithValue("@hava_200_210_boy", loadPerson.hava_200_210_boy);
            //commandsayac.Parameters.AddWithValue("@hava_210_220_boy", loadPerson.hava_210_220_boy);
            //commandsayac.Parameters.AddWithValue("@hava_220_230_boy", loadPerson.hava_220_230_boy);
            //commandsayac.Parameters.AddWithValue("@deniz_140_150_boy", loadPerson.deniz_140_150_boy);
            //commandsayac.Parameters.AddWithValue("@deniz_150_160_boy", loadPerson.deniz_150_160_boy);
            //commandsayac.Parameters.AddWithValue("@deniz_160_170_boy", loadPerson.deniz_160_170_boy);
            //commandsayac.Parameters.AddWithValue("@deniz_170_180_boy", loadPerson.deniz_170_180_boy);
            //commandsayac.Parameters.AddWithValue("@deniz_180_190_boy", loadPerson.deniz_180_190_boy);
            //commandsayac.Parameters.AddWithValue("@deniz_190_200_boy", loadPerson.deniz_190_200_boy);
            //commandsayac.Parameters.AddWithValue("@deniz_200_210_boy", loadPerson.deniz_200_210_boy);
            //commandsayac.Parameters.AddWithValue("@deniz_210_220_boy", loadPerson.deniz_210_220_boy);
            //commandsayac.Parameters.AddWithValue("@deniz_220_230_boy", loadPerson.deniz_220_230_boy);
            //commandsayac.Parameters.AddWithValue("@kara_140alti_uyluk", loadPerson.kara_140alti_uyluk);
            //commandsayac.Parameters.AddWithValue("@kara_140_180_uyluk", loadPerson.kara_140_180_uyluk);
            //commandsayac.Parameters.AddWithValue("@kara_180_220_uyluk", loadPerson.kara_180_220_uyluk);
            //commandsayac.Parameters.AddWithValue("@kara_220_260_uyluk", loadPerson.kara_220_260_uyluk);
            //commandsayac.Parameters.AddWithValue("@kara_260ustu_uyluk", loadPerson.kara_260ustu_uyluk);
            //commandsayac.Parameters.AddWithValue("@hava_140alti_uyluk", loadPerson.hava_140alti_uyluk);
            //commandsayac.Parameters.AddWithValue("@hava_140_180_uyluk", loadPerson.hava_140_180_uyluk);
            //commandsayac.Parameters.AddWithValue("@hava_180_220_uyluk", loadPerson.hava_180_220_uyluk);
            //commandsayac.Parameters.AddWithValue("@hava_220_260_uyluk", loadPerson.hava_220_260_uyluk);
            //commandsayac.Parameters.AddWithValue("@hava_260ustu_uyluk", loadPerson.hava_260ustu_uyluk);
            //commandsayac.Parameters.AddWithValue("@deniz_140alti_uyluk", loadPerson.deniz_140alti_uyluk);
            //commandsayac.Parameters.AddWithValue("@deniz_140_180_uyluk", loadPerson.deniz_140_180_uyluk);
            //commandsayac.Parameters.AddWithValue("@deniz_180_220_uyluk", loadPerson.deniz_180_220_uyluk);
            //commandsayac.Parameters.AddWithValue("@deniz_220_260_uyluk", loadPerson.deniz_220_260_uyluk);
            //commandsayac.Parameters.AddWithValue("@deniz_260ustu_uyluk", loadPerson.deniz_260ustu_uyluk);







            //commandsayac.ExecuteNonQuery();








            _baglan.Close();
        }










    }
}
