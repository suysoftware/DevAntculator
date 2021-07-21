using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TezAPPV2.Paths;

namespace TezAPPV2.Model
{
    class Measur
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
        public int subjectid { get; set; }   //10
        public short A77Lab { get; set; }   //11
        public short A87Lab { get; set; }   //12
        public short A8Lab { get; set; }  //13
        public short E101Lab { get; set; }  //14
        public short E102Lab { get; set; }  //15
        public short E103Lab { get; set; }   //16
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
        public short A2Lab { get; set; }
        public short A3Lab { get; set; }//160
        public short A4Lab { get; set; }
        public short A5Lab { get; set; }
        public short A6Lab { get; set; }
        public short A7Lab { get; set; }//164
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
        public string BMIndex { get; set; }//249
        public string BKoran { get; set; }//250
        public string Birlik { get; set; }//251
        public string ParkaEbat { get; set; }//252
        public string UstGiyimEbat { get; set; }//253
        public string SapkaEbat { get; set; }//254
        public string PantolonEbat { get; set; }//255
        public string BotEbat { get; set; }//256
        public string EldivenEbat { get; set; }//257
        public string TerlikEbat { get; set; }//258
        public string Choosecmb { get; set; }//259
        public string chooseid { get; set; }//260
        public int Talep_No { get; set; }//261
        public string Birlik_Ismi { get; set; }
        public string Talep_Miktar { get; set; }
        public string Olcu_Tipi { get; set; }
        public short MilimetreDip { get; set; }
        public short MilimetreTepe { get; set; }
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

       
        //private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        //public void connect()
        //{

        //    if (_baglan.State == ConnectionState.Closed)
        //    {
        //        _baglan.Open();
        //    }
        //}

        

        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }


        public List<Measur> ShortGet()
        {
            connect();

            SqlCommand command = new SqlCommand("Select Id,Tc,Ad,Soyad,A77,A87,A8 From ThesesxData order by Id DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();

            List<Measur> measurs = new List<Measur>();
            while (reader.Read())
            {
                Measur measur = new Measur();
                measur.Id = Convert.ToInt32(reader["Id"]);
                measur.Tc = reader["Tc"].ToString();
                measur.Ad = reader["Ad"].ToString();
                measur.Soyad = reader["Soyad"].ToString();
                measur.A77 = Convert.ToInt16(reader["A77"]);
                measur.A87 = Convert.ToInt16(reader["A87"]);
                measur.A8 = Convert.ToInt16(reader["A8"]);



                measurs.Add(measur);

            }
            reader.Close();
            _baglan.Close();
            return measurs;



        }


        public List<Measur> TalepGet()
        {
            connect();

            SqlCommand command = new SqlCommand("Select * From TalepDataTheses order by TalepNo DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();

            List<Measur> measurs = new List<Measur>();
            while (reader.Read())
            {
                Measur measur = new Measur();
                measur.Talep_No = Convert.ToInt32(reader["TalepNo"]);
                measur.Birlik_Ismi = reader["Birlik_Ismi"].ToString();
                measur.Olcu_Tipi = reader["Olcu_Tipi"].ToString();
                measur.MilimetreDip = Convert.ToInt16(reader["MilimetreDip"]);
                measur.MilimetreTepe = Convert.ToInt16(reader["MilimetreTepe"]);



                measurs.Add(measur);

            }
            reader.Close();
            _baglan.Close();
            return measurs;



        }

        public List<Measur> GetProjectLabData()
        {
            connect();

            SqlCommand command = new SqlCommand("Select * From ProjectLabData$ order by subjectid DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();


            List<Measur> measurs = new List<Measur>();
            while (reader.Read())
            {
                Measur measur = new Measur();
                measur.subjectid = Convert.ToInt32(reader["subjectid"]);


                measur.A77Lab = Convert.ToInt16(reader["A77Lab"]);
                measur.A87Lab = Convert.ToInt16(reader["A87Lab"]);
                measur.A8Lab = Convert.ToInt16((reader["A8Lab"]));
                measur.E101Lab = Convert.ToInt16(reader["E101Lab"]);
                measur.E102Lab = Convert.ToInt16(reader["E102Lab"]);
                measur.E103Lab = Convert.ToInt16(reader["E103Lab"]);


                measur.A2Lab = Convert.ToInt16(reader["A2Lab"]);
                measur.A3Lab = Convert.ToInt16(reader["A3Lab"]);
                measur.A4Lab = Convert.ToInt16(reader["A4Lab"]);
                measur.A5Lab = Convert.ToInt16(reader["A5Lab"]);
                measur.A6Lab = Convert.ToInt16(reader["A6Lab"]);
                measur.A7Lab = Convert.ToInt16(reader["A7Lab"]);

                measur.A9Lab = Convert.ToInt16(reader["A9Lab"]);
                measur.A10Lab = Convert.ToInt16(reader["A10Lab"]);
                measur.A11Lab = Convert.ToInt16(reader["A11Lab"]);
                measur.A12Lab = Convert.ToInt16(reader["A12Lab"]);
                measur.A13Lab = Convert.ToInt16(reader["A13Lab"]);
                measur.A14Lab = Convert.ToInt16(reader["A14Lab"]);
                measur.A15Lab = Convert.ToInt16(reader["A15Lab"]);
                measur.A16Lab = Convert.ToInt16(reader["A16Lab"]);
                measur.A17Lab = Convert.ToInt16(reader["A17Lab"]);
                measur.A18Lab = Convert.ToInt16(reader["A18Lab"]);
                measur.A19Lab = Convert.ToInt16(reader["A19Lab"]);
                measur.A20Lab = Convert.ToInt16(reader["A20Lab"]);
                measur.A21Lab = Convert.ToInt16(reader["A21Lab"]);
                measur.A22Lab = Convert.ToInt16(reader["A22Lab"]);
                measur.A23Lab = Convert.ToInt16(reader["A23Lab"]);
                measur.A24Lab = Convert.ToInt16(reader["A24Lab"]);
                measur.A25Lab = Convert.ToInt16(reader["A25Lab"]);
                measur.A26Lab = Convert.ToInt16(reader["A26Lab"]);
                measur.A27Lab = Convert.ToInt16(reader["A27Lab"]);
                measur.A28Lab = Convert.ToInt16(reader["A28Lab"]);
                measur.A29Lab = Convert.ToInt16(reader["A29Lab"]);
                measur.A30Lab = Convert.ToInt16(reader["A30Lab"]);
                measur.A31Lab = Convert.ToInt16(reader["A31Lab"]);
                measur.A32Lab = Convert.ToInt16(reader["A32Lab"]);
                measur.A33Lab = Convert.ToInt16(reader["A33Lab"]);
                measur.A34Lab = Convert.ToInt16(reader["A34Lab"]);
                measur.A35Lab = Convert.ToInt16(reader["A35Lab"]);
                measur.A36Lab = Convert.ToInt16(reader["A36Lab"]);
                measur.A37Lab = Convert.ToInt16(reader["A37Lab"]);
                measur.A38Lab = Convert.ToInt16(reader["A38Lab"]);
                measur.A39Lab = Convert.ToInt16(reader["A39Lab"]);
                measur.A40Lab = Convert.ToInt16(reader["A40Lab"]);
                measur.A41Lab = Convert.ToInt16(reader["A41Lab"]);
                measur.A42Lab = Convert.ToInt16(reader["A42Lab"]);
                measur.A43Lab = Convert.ToInt16(reader["A43Lab"]);
                measur.A44Lab = Convert.ToInt16(reader["A44Lab"]);
                measur.A45Lab = Convert.ToInt16(reader["A45Lab"]);
                measur.A46Lab = Convert.ToInt16(reader["A46Lab"]);
                measur.A47Lab = Convert.ToInt16(reader["A47Lab"]);
                measur.A48Lab = Convert.ToInt16(reader["A48Lab"]);
                measur.A49Lab = Convert.ToInt16(reader["A49Lab"]);
                measur.A50Lab = Convert.ToInt16(reader["A50Lab"]);
                measur.A51Lab = Convert.ToInt16(reader["A51Lab"]);
                measur.A52Lab = Convert.ToInt16(reader["A52Lab"]);
                measur.A53Lab = Convert.ToInt16(reader["A53Lab"]);
                measur.A54Lab = Convert.ToInt16(reader["A54Lab"]);
                measur.A55Lab = Convert.ToInt16(reader["A55Lab"]);
                measur.A56Lab = Convert.ToInt16(reader["A56Lab"]);
                measur.A57Lab = Convert.ToInt16(reader["A57Lab"]);
                measur.A58Lab = Convert.ToInt16(reader["A58Lab"]);
                measur.A59Lab = Convert.ToInt16(reader["A59Lab"]);
                measur.A60Lab = Convert.ToInt16(reader["A60Lab"]);
                measur.A61Lab = Convert.ToInt16(reader["A61Lab"]);
                measur.A62Lab = Convert.ToInt16(reader["A62Lab"]);
                measur.A63Lab = Convert.ToInt16(reader["A63Lab"]);
                measur.A64Lab = Convert.ToInt16(reader["A64Lab"]);
                measur.A65Lab = Convert.ToInt16(reader["A65Lab"]);
                measur.A66Lab = Convert.ToInt16(reader["A66Lab"]);
                measur.A67Lab = Convert.ToInt16(reader["A67Lab"]);
                measur.A68Lab = Convert.ToInt16(reader["A68Lab"]);
                measur.A69Lab = Convert.ToInt16(reader["A69Lab"]);
                measur.A70Lab = Convert.ToInt16(reader["A70Lab"]);
                measur.A71Lab = Convert.ToInt16(reader["A71Lab"]);
                measur.A72Lab = Convert.ToInt16(reader["A72Lab"]);
                measur.A73Lab = Convert.ToInt16(reader["A73Lab"]);
                measur.A74Lab = Convert.ToInt16(reader["A74Lab"]);
                measur.A75Lab = Convert.ToInt16(reader["A75Lab"]);
                measur.A76Lab = Convert.ToInt16(reader["A76Lab"]);
                measur.A78Lab = Convert.ToInt16(reader["A78Lab"]);
                measur.A79Lab = Convert.ToInt16(reader["A79Lab"]);
                measur.A80Lab = Convert.ToInt16(reader["A80Lab"]);
                measur.A81Lab = Convert.ToInt16(reader["A81Lab"]);
                measur.A82Lab = Convert.ToInt16(reader["A82Lab"]);
                measur.A83Lab = Convert.ToInt16(reader["A83Lab"]);
                measur.A84Lab = Convert.ToInt16(reader["A84Lab"]);
                measur.A85Lab = Convert.ToInt16(reader["A85Lab"]);
                measur.A86Lab = Convert.ToInt16(reader["A86Lab"]);
                measur.A88Lab = Convert.ToInt16(reader["A88Lab"]);
                measur.A89Lab = Convert.ToInt16(reader["A89Lab"]);
                measur.A90Lab = Convert.ToInt16(reader["A90Lab"]);
                measur.A91Lab = Convert.ToInt16(reader["A91Lab"]);
                measur.A92Lab = Convert.ToInt16(reader["A92Lab"]);
                measur.A93Lab = Convert.ToInt16(reader["A93Lab"]);
                measur.A94Lab = Convert.ToInt16(reader["A94Lab"]);







                measurs.Add(measur);

            }
            reader.Close();
            _baglan.Close();
            return measurs;



        }

        public List<Measur> GetDonemlerdetay()
        {
            connect();
            SqlCommand command = new SqlCommand("Select * From Dashboarddata order by donem DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();

            List<Measur> measurs = new List<Measur>();
            while (reader.Read())
            {
                Measur measur = new Measur();


                measur.donem = Convert.ToInt32(reader["donem"]);
                measur.totalsoldier = Convert.ToInt32(reader["totalsoldier"]);
                measur.karakuvvet = Convert.ToInt32(reader["karakuvvet"]);
                measur.denizkuvvet = Convert.ToInt32(reader["denizkuvvet"]);
                measur.havakuvvet = Convert.ToInt32(reader["havakuvvet"]);
                measur.karatotalchest = Convert.ToInt32(reader["karatotalchest"]);
                measur.havatotalchest = Convert.ToInt32(reader["havatotalchest"]);
                measur.deniztotalchest = Convert.ToInt32(reader["deniztotalchest"]);
                measur.kara_xs_chest = Convert.ToInt32(reader["kara_xs_chest"]);
                measur.kara_s_chest = Convert.ToInt32(reader["kara_s_chest"]);
                measur.kara_m_chest = Convert.ToInt32(reader["kara_m_chest"]);
                measur.kara_l_chest = Convert.ToInt32(reader["kara_l_chest"]);
                measur.kara_xl_chest = Convert.ToInt32(reader["kara_xl_chest"]);
                measur.kara_2xl_chest = Convert.ToInt32(reader["kara_2xl_chest"]);
                measur.hava_xs_chest = Convert.ToInt32(reader["hava_xs_chest"]);
                measur.hava_s_chest = Convert.ToInt32(reader["hava_s_chest"]);
                measur.hava_m_chest = Convert.ToInt32(reader["hava_m_chest"]);
                measur.hava_l_chest = Convert.ToInt32(reader["hava_l_chest"]);
                measur.hava_2l_chest = Convert.ToInt32(reader["hava_2l_chest"]);
                measur.hava_xxl_chest = Convert.ToInt32(reader["hava_xxl_chest"]);
                measur.deniz_xs_chest = Convert.ToInt32(reader["deniz_xs_chest"]);
                measur.deniz_s_chest = Convert.ToInt32(reader["deniz_s_chest"]);
                measur.deniz_m_chest = Convert.ToInt32(reader["deniz_m_chest"]);
                measur.deniz_l_chest = Convert.ToInt32(reader["deniz_l_chest"]);
                measur.deniz_xl_chest = Convert.ToInt32(reader["deniz_xl_chest"]);
                measur.deniz_2xl_chest = Convert.ToInt32(reader["deniz_2xl_chest"]);
                measur.karatotalbot = Convert.ToInt32(reader["karatotalbot"]);
                measur.havatotalbot = Convert.ToInt32(reader["havatotalbot"]);
                measur.deniztotalbot = Convert.ToInt32(reader["deniztotalbot"]);
                measur.kara_34_bot = Convert.ToInt32(reader["kara_34_bot"]);
                measur.kara_35_bot = Convert.ToInt32(reader["kara_35_bot"]);
                measur.kara_36_bot = Convert.ToInt32(reader["kara_36_bot"]);
                measur.kara_37_bot = Convert.ToInt32(reader["kara_37_bot"]);
                measur.kara_38_bot = Convert.ToInt32(reader["kara_38_bot"]);
                measur.kara_39_bot = Convert.ToInt32(reader["kara_39_bot"]);
                measur.kara_40_bot = Convert.ToInt32(reader["kara_40_bot"]);
                measur.kara_41_bot = Convert.ToInt32(reader["kara_41_bot"]);
                measur.kara_42_bot = Convert.ToInt32(reader["kara_42_bot"]);
                measur.kara_43_bot = Convert.ToInt32(reader["kara_43_bot"]);
                measur.kara_44_bot = Convert.ToInt32(reader["kara_44_bot"]);
                measur.kara_45_bot = Convert.ToInt32(reader["kara_45_bot"]);
                measur.kara_46_bot = Convert.ToInt32(reader["kara_46_bot"]);
                measur.kara_47_bot = Convert.ToInt32(reader["kara_47_bot"]);
                measur.kara_48_bot = Convert.ToInt32(reader["kara_48_bot"]);
                measur.hava_34_bot = Convert.ToInt32(reader["hava_34_bot"]);
                measur.hava_35_bot = Convert.ToInt32(reader["hava_35_bot"]);
                measur.hava_36_bot = Convert.ToInt32(reader["hava_36_bot"]);
                measur.hava_37_bot = Convert.ToInt32(reader["hava_37_bot"]);
                measur.hava_38_bot = Convert.ToInt32(reader["hava_38_bot"]);
                measur.hava_39_bot = Convert.ToInt32(reader["hava_39_bot"]);
                measur.hava_40_bot = Convert.ToInt32(reader["hava_40_bot"]);
                measur.hava_41_bot = Convert.ToInt32(reader["hava_41_bot"]);
                measur.hava_42_bot = Convert.ToInt32(reader["hava_42_bot"]);
                measur.hava_43_bot = Convert.ToInt32(reader["hava_43_bot"]);
                measur.hava_44_bot = Convert.ToInt32(reader["hava_44_bot"]);
                measur.hava_45_bot = Convert.ToInt32(reader["hava_45_bot"]);
                measur.hava_46_bot = Convert.ToInt32(reader["hava_46_bot"]);
                measur.hava_47_bot = Convert.ToInt32(reader["hava_47_bot"]);
                measur.hava_48_bot = Convert.ToInt32(reader["hava_48_bot"]);
                measur.deniz_34_bot = Convert.ToInt32(reader["deniz_34_bot"]);
                measur.deniz_35_bot = Convert.ToInt32(reader["deniz_35_bot"]);
                measur.deniz_36_bot = Convert.ToInt32(reader["deniz_36_bot"]);
                measur.deniz_37_bot = Convert.ToInt32(reader["deniz_37_bot"]);
                measur.deniz_38_bot = Convert.ToInt32(reader["deniz_38_bot"]);
                measur.deniz_39_bot = Convert.ToInt32(reader["deniz_39_bot"]);
                measur.deniz_40_bot = Convert.ToInt32(reader["deniz_40_bot"]);
                measur.deniz_41_bot = Convert.ToInt32(reader["deniz_41_bot"]);
                measur.deniz_42_bot = Convert.ToInt32(reader["deniz_42_bot"]);
                measur.deniz_43_bot = Convert.ToInt32(reader["deniz_43_bot"]);
                measur.deniz_44_bot = Convert.ToInt32(reader["deniz_44_bot"]);
                measur.deniz_45_bot = Convert.ToInt32(reader["deniz_45_bot"]);
                measur.deniz_46_bot = Convert.ToInt32(reader["deniz_46_bot"]);
                measur.deniz_47_bot = Convert.ToInt32(reader["deniz_47_bot"]);
                measur.deniz_48_bot = Convert.ToInt32(reader["deniz_48_bot"]);
                measur.karatotalpant = Convert.ToInt32(reader["karatotalpant"]);
                measur.havatotalpant = Convert.ToInt32(reader["havatotalpant"]);
                measur.deniztotalpant = Convert.ToInt32(reader["deniztotalpant"]);
                measur.kara_xs_pant = Convert.ToInt32(reader["kara_xs_pant"]);
                measur.kara_s_pant = Convert.ToInt32(reader["kara_s_pant"]);
                measur.kara_m_pant = Convert.ToInt32(reader["kara_m_pant"]);
                measur.kara_l_pant = Convert.ToInt32(reader["kara_l_pant"]);
                measur.kara_xl_pant = Convert.ToInt32(reader["kara_xl_pant"]);
                measur.kara_2xl_pant = Convert.ToInt32(reader["kara_2xl_pant"]);
                measur.kara_3xl_pant = Convert.ToInt32(reader["kara_3xl_pant"]);
                measur.kara_bxl_pant = Convert.ToInt32(reader["kara_bxl_pant"]);
                measur.hava_xs_pant = Convert.ToInt32(reader["hava_xs_pant"]);
                measur.hava_s_pant = Convert.ToInt32(reader["hava_s_pant"]);
                measur.hava_m_pant = Convert.ToInt32(reader["hava_m_pant"]);
                measur.hava_l_pant = Convert.ToInt32(reader["hava_l_pant"]);
                measur.hava_xl_pant = Convert.ToInt32(reader["hava_xl_pant"]);
                measur.hava_2xl_pant = Convert.ToInt32(reader["hava_2xl_pant"]);
                measur.hava_3xl_pant = Convert.ToInt32(reader["hava_3xl_pant"]);
                measur.hava_bxl_pant = Convert.ToInt32(reader["hava_bxl_pant"]);
                measur.deniz_xs_pant = Convert.ToInt32(reader["deniz_xs_pant"]);
                measur.deniz_s_pant = Convert.ToInt32(reader["deniz_s_pant"]);
                measur.deniz_m_pant = Convert.ToInt32(reader["deniz_m_pant"]);
                measur.deniz_l_pant = Convert.ToInt32(reader["deniz_l_pant"]);
                measur.deniz_xl_pant = Convert.ToInt32(reader["deniz_xl_pant"]);
                measur.deniz_2xl_pant = Convert.ToInt32(reader["deniz_2xl_pant"]);
                measur.deniz_3xl_pant = Convert.ToInt32(reader["deniz_3xl_pant"]);
                measur.deniz_bxl_pant = Convert.ToInt32(reader["deniz_bxl_pant"]);
                measur.karatotalhands = Convert.ToInt32(reader["karatotalhands"]);
                measur.havatotalhands = Convert.ToInt32(reader["havatotalhands"]);
                measur.deniztotalhands = Convert.ToInt32(reader["deniztotalhands"]);
                measur.kara_xs_hands = Convert.ToInt32(reader["kara_xs_hands"]);
                measur.kara_s_hands = Convert.ToInt32(reader["kara_s_hands"]);
                measur.kara_m_hands = Convert.ToInt32(reader["kara_m_hands"]);
                measur.kara_l_hands = Convert.ToInt32(reader["kara_l_hands"]);
                measur.kara_xl_hands = Convert.ToInt32(reader["kara_xl_hands"]);
                measur.kara_2xl_hands = Convert.ToInt32(reader["kara_2xl_hands"]);
                measur.hava_xs_hands = Convert.ToInt32(reader["hava_xs_hands"]);
                measur.hava_s_hands = Convert.ToInt32(reader["hava_s_hands"]);
                measur.hava_m_hands = Convert.ToInt32(reader["hava_m_hands"]);
                measur.hava_l_hands = Convert.ToInt32(reader["hava_l_hands"]);
                measur.hava_xl_hands = Convert.ToInt32(reader["hava_xl_hands"]);
                measur.hava_2xl_hands = Convert.ToInt32(reader["hava_2xl_hands"]);
                measur.deniz_xs_hands = Convert.ToInt32(reader["deniz_xs_hands"]);
                measur.deniz_s_hands = Convert.ToInt32(reader["deniz_s_hands"]);
                measur.deniz_m_hands = Convert.ToInt32(reader["deniz_m_hands"]);
                measur.deniz_l_hands = Convert.ToInt32(reader["deniz_l_hands"]);
                measur.deniz_xl_hands = Convert.ToInt32(reader["deniz_xl_hands"]);
                measur.deniz_2xl_hands = Convert.ToInt32(reader["deniz_2xl_hands"]);
                measur.kara_140_150_boy = Convert.ToInt32(reader["kara_140_150_boy"]);
                measur.kara_150_160_boy = Convert.ToInt32(reader["kara_150_160_boy"]);
                measur.kara_160_170_boy = Convert.ToInt32(reader["kara_160_170_boy"]);
                measur.kara_170_180_boy = Convert.ToInt32(reader["kara_170_180_boy"]);
                measur.kara_180_190_boy = Convert.ToInt32(reader["kara_180_190_boy"]);
                measur.kara_190_200_boy = Convert.ToInt32(reader["kara_190_200_boy"]);
                measur.kara_200_210_boy = Convert.ToInt32(reader["kara_200_210_boy"]);
                measur.kara_210_220_boy = Convert.ToInt32(reader["kara_210_220_boy"]);
                measur.kara_220_230_boy = Convert.ToInt32(reader["kara_220_230_boy"]);
                measur.hava_140_150_boy = Convert.ToInt32(reader["hava_140_150_boy"]);
                measur.hava_150_160_boy = Convert.ToInt32(reader["hava_150_160_boy"]);
                measur.hava_160_170_boy = Convert.ToInt32(reader["hava_160_170_boy"]);
                measur.hava_170_180_boy = Convert.ToInt32(reader["hava_170_180_boy"]);
                measur.hava_180_190_boy = Convert.ToInt32(reader["hava_180_190_boy"]);
                measur.hava_190_200_boy = Convert.ToInt32(reader["hava_190_200_boy"]);
                measur.hava_200_210_boy = Convert.ToInt32(reader["hava_200_210_boy"]);
                measur.hava_210_220_boy = Convert.ToInt32(reader["hava_210_220_boy"]);
                measur.hava_220_230_boy = Convert.ToInt32(reader["hava_220_230_boy"]);
                measur.deniz_140_150_boy = Convert.ToInt32(reader["deniz_140_150_boy"]);
                measur.deniz_150_160_boy = Convert.ToInt32(reader["deniz_150_160_boy"]);
                measur.deniz_160_170_boy = Convert.ToInt32(reader["deniz_160_170_boy"]);
                measur.deniz_170_180_boy = Convert.ToInt32(reader["deniz_170_180_boy"]);
                measur.deniz_180_190_boy = Convert.ToInt32(reader["deniz_180_190_boy"]);
                measur.deniz_190_200_boy = Convert.ToInt32(reader["deniz_190_200_boy"]);
                measur.deniz_200_210_boy = Convert.ToInt32(reader["deniz_200_210_boy"]);
                measur.deniz_210_220_boy = Convert.ToInt32(reader["deniz_210_220_boy"]);
                measur.deniz_220_230_boy = Convert.ToInt32(reader["deniz_220_230_boy"]);
                measur.kara_140alti_uyluk = Convert.ToInt32(reader["kara_140alti_uyluk"]);
                measur.kara_140_180_uyluk = Convert.ToInt32(reader["kara_140_180_uyluk"]);
                measur.kara_180_220_uyluk = Convert.ToInt32(reader["kara_180_220_uyluk"]);
                measur.kara_220_260_uyluk = Convert.ToInt32(reader["kara_220_260_uyluk"]);
                measur.kara_260ustu_uyluk = Convert.ToInt32(reader["kara_260ustu_uyluk"]);
                measur.hava_140alti_uyluk = Convert.ToInt32(reader["hava_140alti_uyluk"]);
                measur.hava_140_180_uyluk = Convert.ToInt32(reader["hava_140_180_uyluk"]);
                measur.hava_180_220_uyluk = Convert.ToInt32(reader["hava_180_220_uyluk"]);
                measur.hava_220_260_uyluk = Convert.ToInt32(reader["hava_220_260_uyluk"]);
                measur.hava_260ustu_uyluk = Convert.ToInt32(reader["hava_260ustu_uyluk"]);
                measur.deniz_140alti_uyluk = Convert.ToInt32(reader["deniz_140alti_uyluk"]);
                measur.deniz_140_180_uyluk = Convert.ToInt32(reader["deniz_140_180_uyluk"]);
                measur.deniz_180_220_uyluk = Convert.ToInt32(reader["deniz_180_220_uyluk"]);
                measur.deniz_220_260_uyluk = Convert.ToInt32(reader["deniz_220_260_uyluk"]);
                measur.deniz_260ustu_uyluk = Convert.ToInt32(reader["deniz_260ustu_uyluk"]);















                measurs.Add(measur);

            }
            reader.Close();
            _baglan.Close();
            return measurs;



        }

        public List<Measur> GetMail()
        {
            connect();
            SqlCommand command = new SqlCommand("Select * From Dashboarddata where donem=IDENT_CURRENT('Dashboarddata')", _baglan);
            SqlDataReader reader = command.ExecuteReader();

            List<Measur> measurs = new List<Measur>();
            while (reader.Read())
            {
                Measur measur = new Measur();



                measur.totalsoldier = Convert.ToInt32(reader["totalsoldier"]);
                measur.karakuvvet = Convert.ToInt32(reader["karakuvvet"]);
                measur.denizkuvvet = Convert.ToInt32(reader["denizkuvvet"]);
                measur.havakuvvet = Convert.ToInt32(reader["havakuvvet"]);
                measur.karatotalchest = Convert.ToInt32(reader["karatotalchest"]);
                measur.havatotalchest = Convert.ToInt32(reader["havatotalchest"]);
                measur.deniztotalchest = Convert.ToInt32(reader["deniztotalchest"]);
                measur.kara_xs_chest = Convert.ToInt32(reader["kara_xs_chest"]);
                measur.kara_s_chest = Convert.ToInt32(reader["kara_s_chest"]);
                measur.kara_m_chest = Convert.ToInt32(reader["kara_m_chest"]);
                measur.kara_l_chest = Convert.ToInt32(reader["kara_l_chest"]);
                measur.kara_xl_chest = Convert.ToInt32(reader["kara_xl_chest"]);
                measur.kara_2xl_chest = Convert.ToInt32(reader["kara_2xl_chest"]);
                measur.hava_xs_chest = Convert.ToInt32(reader["hava_xs_chest"]);
                measur.hava_s_chest = Convert.ToInt32(reader["hava_s_chest"]);
                measur.hava_m_chest = Convert.ToInt32(reader["hava_m_chest"]);
                measur.hava_l_chest = Convert.ToInt32(reader["hava_l_chest"]);
                measur.hava_2l_chest = Convert.ToInt32(reader["hava_2l_chest"]);
                measur.hava_xxl_chest = Convert.ToInt32(reader["hava_xxl_chest"]);
                measur.deniz_xs_chest = Convert.ToInt32(reader["deniz_xs_chest"]);
                measur.deniz_s_chest = Convert.ToInt32(reader["deniz_s_chest"]);
                measur.deniz_m_chest = Convert.ToInt32(reader["deniz_m_chest"]);
                measur.deniz_l_chest = Convert.ToInt32(reader["deniz_l_chest"]);
                measur.deniz_xl_chest = Convert.ToInt32(reader["deniz_xl_chest"]);
                measur.deniz_2xl_chest = Convert.ToInt32(reader["deniz_2xl_chest"]);
                measur.karatotalbot = Convert.ToInt32(reader["karatotalbot"]);
                measur.havatotalbot = Convert.ToInt32(reader["havatotalbot"]);
                measur.deniztotalbot = Convert.ToInt32(reader["deniztotalbot"]);
                measur.kara_34_bot = Convert.ToInt32(reader["kara_34_bot"]);
                measur.kara_35_bot = Convert.ToInt32(reader["kara_35_bot"]);
                measur.kara_36_bot = Convert.ToInt32(reader["kara_36_bot"]);
                measur.kara_37_bot = Convert.ToInt32(reader["kara_37_bot"]);
                measur.kara_38_bot = Convert.ToInt32(reader["kara_38_bot"]);
                measur.kara_39_bot = Convert.ToInt32(reader["kara_39_bot"]);
                measur.kara_40_bot = Convert.ToInt32(reader["kara_40_bot"]);
                measur.kara_41_bot = Convert.ToInt32(reader["kara_41_bot"]);
                measur.kara_42_bot = Convert.ToInt32(reader["kara_42_bot"]);
                measur.kara_43_bot = Convert.ToInt32(reader["kara_43_bot"]);
                measur.kara_44_bot = Convert.ToInt32(reader["kara_44_bot"]);
                measur.kara_45_bot = Convert.ToInt32(reader["kara_45_bot"]);
                measur.kara_46_bot = Convert.ToInt32(reader["kara_46_bot"]);
                measur.kara_47_bot = Convert.ToInt32(reader["kara_47_bot"]);
                measur.kara_48_bot = Convert.ToInt32(reader["kara_48_bot"]);
                measur.hava_34_bot = Convert.ToInt32(reader["hava_34_bot"]);
                measur.hava_35_bot = Convert.ToInt32(reader["hava_35_bot"]);
                measur.hava_36_bot = Convert.ToInt32(reader["hava_36_bot"]);
                measur.hava_37_bot = Convert.ToInt32(reader["hava_37_bot"]);
                measur.hava_38_bot = Convert.ToInt32(reader["hava_38_bot"]);
                measur.hava_39_bot = Convert.ToInt32(reader["hava_39_bot"]);
                measur.hava_40_bot = Convert.ToInt32(reader["hava_40_bot"]);
                measur.hava_41_bot = Convert.ToInt32(reader["hava_41_bot"]);
                measur.hava_42_bot = Convert.ToInt32(reader["hava_42_bot"]);
                measur.hava_43_bot = Convert.ToInt32(reader["hava_43_bot"]);
                measur.hava_44_bot = Convert.ToInt32(reader["hava_44_bot"]);
                measur.hava_45_bot = Convert.ToInt32(reader["hava_45_bot"]);
                measur.hava_46_bot = Convert.ToInt32(reader["hava_46_bot"]);
                measur.hava_47_bot = Convert.ToInt32(reader["hava_47_bot"]);
                measur.hava_48_bot = Convert.ToInt32(reader["hava_48_bot"]);
                measur.deniz_34_bot = Convert.ToInt32(reader["deniz_34_bot"]);
                measur.deniz_35_bot = Convert.ToInt32(reader["deniz_35_bot"]);
                measur.deniz_36_bot = Convert.ToInt32(reader["deniz_36_bot"]);
                measur.deniz_37_bot = Convert.ToInt32(reader["deniz_37_bot"]);
                measur.deniz_38_bot = Convert.ToInt32(reader["deniz_38_bot"]);
                measur.deniz_39_bot = Convert.ToInt32(reader["deniz_39_bot"]);
                measur.deniz_40_bot = Convert.ToInt32(reader["deniz_40_bot"]);
                measur.deniz_41_bot = Convert.ToInt32(reader["deniz_41_bot"]);
                measur.deniz_42_bot = Convert.ToInt32(reader["deniz_42_bot"]);
                measur.deniz_43_bot = Convert.ToInt32(reader["deniz_43_bot"]);
                measur.deniz_44_bot = Convert.ToInt32(reader["deniz_44_bot"]);
                measur.deniz_45_bot = Convert.ToInt32(reader["deniz_45_bot"]);
                measur.deniz_46_bot = Convert.ToInt32(reader["deniz_46_bot"]);
                measur.deniz_47_bot = Convert.ToInt32(reader["deniz_47_bot"]);
                measur.deniz_48_bot = Convert.ToInt32(reader["deniz_48_bot"]);
                measur.karatotalpant = Convert.ToInt32(reader["karatotalpant"]);
                measur.havatotalpant = Convert.ToInt32(reader["havatotalpant"]);
                measur.deniztotalpant = Convert.ToInt32(reader["deniztotalpant"]);
                measur.kara_xs_pant = Convert.ToInt32(reader["kara_xs_pant"]);
                measur.kara_s_pant = Convert.ToInt32(reader["kara_s_pant"]);
                measur.kara_m_pant = Convert.ToInt32(reader["kara_m_pant"]);
                measur.kara_l_pant = Convert.ToInt32(reader["kara_l_pant"]);
                measur.kara_xl_pant = Convert.ToInt32(reader["kara_xl_pant"]);
                measur.kara_2xl_pant = Convert.ToInt32(reader["kara_2xl_pant"]);
                measur.kara_3xl_pant = Convert.ToInt32(reader["kara_3xl_pant"]);
                measur.kara_bxl_pant = Convert.ToInt32(reader["kara_bxl_pant"]);
                measur.hava_xs_pant = Convert.ToInt32(reader["hava_xs_pant"]);
                measur.hava_s_pant = Convert.ToInt32(reader["hava_s_pant"]);
                measur.hava_m_pant = Convert.ToInt32(reader["hava_m_pant"]);
                measur.hava_l_pant = Convert.ToInt32(reader["hava_l_pant"]);
                measur.hava_xl_pant = Convert.ToInt32(reader["hava_xl_pant"]);
                measur.hava_2xl_pant = Convert.ToInt32(reader["hava_2xl_pant"]);
                measur.hava_3xl_pant = Convert.ToInt32(reader["hava_3xl_pant"]);
                measur.hava_bxl_pant = Convert.ToInt32(reader["hava_bxl_pant"]);
                measur.deniz_xs_pant = Convert.ToInt32(reader["deniz_xs_pant"]);
                measur.deniz_s_pant = Convert.ToInt32(reader["deniz_s_pant"]);
                measur.deniz_m_pant = Convert.ToInt32(reader["deniz_m_pant"]);
                measur.deniz_l_pant = Convert.ToInt32(reader["deniz_l_pant"]);
                measur.deniz_xl_pant = Convert.ToInt32(reader["deniz_xl_pant"]);
                measur.deniz_2xl_pant = Convert.ToInt32(reader["deniz_2xl_pant"]);
                measur.deniz_3xl_pant = Convert.ToInt32(reader["deniz_3xl_pant"]);
                measur.deniz_bxl_pant = Convert.ToInt32(reader["deniz_bxl_pant"]);
                measur.karatotalhands = Convert.ToInt32(reader["karatotalhands"]);
                measur.havatotalhands = Convert.ToInt32(reader["havatotalhands"]);
                measur.deniztotalhands = Convert.ToInt32(reader["deniztotalhands"]);
                measur.kara_xs_hands = Convert.ToInt32(reader["kara_xs_hands"]);
                measur.kara_s_hands = Convert.ToInt32(reader["kara_s_hands"]);
                measur.kara_m_hands = Convert.ToInt32(reader["kara_m_hands"]);
                measur.kara_l_hands = Convert.ToInt32(reader["kara_l_hands"]);
                measur.kara_xl_hands = Convert.ToInt32(reader["kara_xl_hands"]);
                measur.kara_2xl_hands = Convert.ToInt32(reader["kara_2xl_hands"]);
                measur.hava_xs_hands = Convert.ToInt32(reader["hava_xs_hands"]);
                measur.hava_s_hands = Convert.ToInt32(reader["hava_s_hands"]);
                measur.hava_m_hands = Convert.ToInt32(reader["hava_m_hands"]);
                measur.hava_l_hands = Convert.ToInt32(reader["hava_l_hands"]);
                measur.hava_xl_hands = Convert.ToInt32(reader["hava_xl_hands"]);
                measur.hava_2xl_hands = Convert.ToInt32(reader["hava_2xl_hands"]);
                measur.deniz_xs_hands = Convert.ToInt32(reader["deniz_xs_hands"]);
                measur.deniz_s_hands = Convert.ToInt32(reader["deniz_s_hands"]);
                measur.deniz_m_hands = Convert.ToInt32(reader["deniz_m_hands"]);
                measur.deniz_l_hands = Convert.ToInt32(reader["deniz_l_hands"]);
                measur.deniz_xl_hands = Convert.ToInt32(reader["deniz_xl_hands"]);
                measur.deniz_2xl_hands = Convert.ToInt32(reader["deniz_2xl_hands"]);
                measur.kara_140_150_boy = Convert.ToInt32(reader["kara_140_150_boy"]);
                measur.kara_150_160_boy = Convert.ToInt32(reader["kara_150_160_boy"]);
                measur.kara_160_170_boy = Convert.ToInt32(reader["kara_160_170_boy"]);
                measur.kara_170_180_boy = Convert.ToInt32(reader["kara_170_180_boy"]);
                measur.kara_180_190_boy = Convert.ToInt32(reader["kara_180_190_boy"]);
                measur.kara_190_200_boy = Convert.ToInt32(reader["kara_190_200_boy"]);
                measur.kara_200_210_boy = Convert.ToInt32(reader["kara_200_210_boy"]);
                measur.kara_210_220_boy = Convert.ToInt32(reader["kara_210_220_boy"]);
                measur.kara_220_230_boy = Convert.ToInt32(reader["kara_220_230_boy"]);
                measur.hava_140_150_boy = Convert.ToInt32(reader["hava_140_150_boy"]);
                measur.hava_150_160_boy = Convert.ToInt32(reader["hava_150_160_boy"]);
                measur.hava_160_170_boy = Convert.ToInt32(reader["hava_160_170_boy"]);
                measur.hava_170_180_boy = Convert.ToInt32(reader["hava_170_180_boy"]);
                measur.hava_180_190_boy = Convert.ToInt32(reader["hava_180_190_boy"]);
                measur.hava_190_200_boy = Convert.ToInt32(reader["hava_190_200_boy"]);
                measur.hava_200_210_boy = Convert.ToInt32(reader["hava_200_210_boy"]);
                measur.hava_210_220_boy = Convert.ToInt32(reader["hava_210_220_boy"]);
                measur.hava_220_230_boy = Convert.ToInt32(reader["hava_220_230_boy"]);
                measur.deniz_140_150_boy = Convert.ToInt32(reader["deniz_140_150_boy"]);
                measur.deniz_150_160_boy = Convert.ToInt32(reader["deniz_150_160_boy"]);
                measur.deniz_160_170_boy = Convert.ToInt32(reader["deniz_160_170_boy"]);
                measur.deniz_170_180_boy = Convert.ToInt32(reader["deniz_170_180_boy"]);
                measur.deniz_180_190_boy = Convert.ToInt32(reader["deniz_180_190_boy"]);
                measur.deniz_190_200_boy = Convert.ToInt32(reader["deniz_190_200_boy"]);
                measur.deniz_200_210_boy = Convert.ToInt32(reader["deniz_200_210_boy"]);
                measur.deniz_210_220_boy = Convert.ToInt32(reader["deniz_210_220_boy"]);
                measur.deniz_220_230_boy = Convert.ToInt32(reader["deniz_220_230_boy"]);
                measur.kara_140alti_uyluk = Convert.ToInt32(reader["kara_140alti_uyluk"]);
                measur.kara_140_180_uyluk = Convert.ToInt32(reader["kara_140_180_uyluk"]);
                measur.kara_180_220_uyluk = Convert.ToInt32(reader["kara_180_220_uyluk"]);
                measur.kara_220_260_uyluk = Convert.ToInt32(reader["kara_220_260_uyluk"]);
                measur.kara_260ustu_uyluk = Convert.ToInt32(reader["kara_260ustu_uyluk"]);
                measur.hava_140alti_uyluk = Convert.ToInt32(reader["hava_140alti_uyluk"]);
                measur.hava_140_180_uyluk = Convert.ToInt32(reader["hava_140_180_uyluk"]);
                measur.hava_180_220_uyluk = Convert.ToInt32(reader["hava_180_220_uyluk"]);
                measur.hava_220_260_uyluk = Convert.ToInt32(reader["hava_220_260_uyluk"]);
                measur.hava_260ustu_uyluk = Convert.ToInt32(reader["hava_260ustu_uyluk"]);
                measur.deniz_140alti_uyluk = Convert.ToInt32(reader["deniz_140alti_uyluk"]);
                measur.deniz_140_180_uyluk = Convert.ToInt32(reader["deniz_140_180_uyluk"]);
                measur.deniz_180_220_uyluk = Convert.ToInt32(reader["deniz_180_220_uyluk"]);
                measur.deniz_220_260_uyluk = Convert.ToInt32(reader["deniz_220_260_uyluk"]);
                measur.deniz_260ustu_uyluk = Convert.ToInt32(reader["deniz_260ustu_uyluk"]);















                measurs.Add(measur);

            }
            reader.Close();
            _baglan.Close();
            return measurs;



        }

        public List<Measur> Get()
        {
            connect();
            SqlCommand command = new SqlCommand("Select * From ThesesxData order by Id DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();

            List<Measur> measurs = new List<Measur>();
            while (reader.Read())
            {
                Measur measur = new Measur();
                measur.Id = Convert.ToInt32(reader["Id"]);
                measur.Tc = reader["Tc"].ToString();
                measur.Ad = reader["Ad"].ToString();
                measur.Soyad = reader["Soyad"].ToString();
                measur.A77 = Convert.ToInt16(reader["A77"]);
                measur.A87 = Convert.ToInt16(reader["A87"]);
                measur.A8 = Convert.ToInt16(reader["A8"]);
                measur.E101 = Convert.ToInt16(reader["E101"]);
                measur.E102 = Convert.ToInt16(reader["E102"]);
                measur.E103 = Convert.ToInt16(reader["E103"]);
                measur.A2Trium = Convert.ToInt16(reader["A2Trium"]);
                measur.A3Trium = Convert.ToInt16(reader["A3Trium"]);
                measur.A4Trium = Convert.ToInt16(reader["A4Trium"]);
                measur.A5Trium = Convert.ToInt16(reader["A5Trium"]);
                measur.A6Trium = Convert.ToInt16(reader["A6Trium"]);
                measur.A7Trium = Convert.ToInt16(reader["A7Trium"]);
                measur.A9Trium = Convert.ToInt16(reader["A9Trium"]);
                measur.A12Trium = Convert.ToInt16(reader["A12Trium"]);
                measur.A13Trium = Convert.ToInt16(reader["A13Trium"]);
                measur.A17Trium = Convert.ToInt16(reader["A17Trium"]);
                measur.A18Trium = Convert.ToInt16(reader["A18Trium"]);
                measur.A19Trium = Convert.ToInt16(reader["A19Trium"]);
                measur.A20Trium = Convert.ToInt16(reader["A20Trium"]);
                measur.A21Trium = Convert.ToInt16(reader["A21Trium"]);
                measur.A22Trium = Convert.ToInt16(reader["A22Trium"]);
                measur.A23Trium = Convert.ToInt16(reader["A23Trium"]);
                measur.A25Trium = Convert.ToInt16(reader["A25Trium"]);
                measur.A26Trium = Convert.ToInt16(reader["A26Trium"]);
                measur.A27Trium = Convert.ToInt16(reader["A27Trium"]);
                measur.A28Trium = Convert.ToInt16(reader["A28Trium"]);
                measur.A29Trium = Convert.ToInt16(reader["A29Trium"]);
                measur.A30Trium = Convert.ToInt16(reader["A30Trium"]);
                measur.A35Trium = Convert.ToInt16(reader["A35Trium"]);
                measur.A36Trium = Convert.ToInt16(reader["A36Trium"]);
                measur.A37Trium = Convert.ToInt16(reader["A37Trium"]);
                measur.A38Trium = Convert.ToInt16(reader["A38Trium"]);
                measur.A41Trium = Convert.ToInt16(reader["A41Trium"]);
                measur.A42Trium = Convert.ToInt16(reader["A42Trium"]);
                measur.A43Trium = Convert.ToInt16(reader["A43Trium"]);
                measur.A44Trium = Convert.ToInt16(reader["A44Trium"]);
                measur.A45Trium = Convert.ToInt16(reader["A45Trium"]);
                measur.A49Trium = Convert.ToInt16(reader["A49Trium"]);
                measur.A51Trium = Convert.ToInt16(reader["A51Trium"]);
                measur.A52Trium = Convert.ToInt16(reader["A52Trium"]);
                measur.A53Trium = Convert.ToInt16(reader["A53Trium"]);
                measur.A55Trium = Convert.ToInt16(reader["A55Trium"]);
                measur.A56Trium = Convert.ToInt16(reader["A56Trium"]);
                measur.A57Trium = Convert.ToInt16(reader["A57Trium"]);
                measur.A58Trium = Convert.ToInt16(reader["A58Trium"]);
                measur.A59Trium = Convert.ToInt16(reader["A59Trium"]);
                measur.A61Trium = Convert.ToInt16(reader["A61Trium"]);
                measur.A66Trium = Convert.ToInt16(reader["A66Trium"]);
                measur.A67Trium = Convert.ToInt16(reader["A67Trium"]);
                measur.A68Trium = Convert.ToInt16(reader["A68Trium"]);
                measur.A70Trium = Convert.ToInt16(reader["A70Trium"]);
                measur.A71Trium = Convert.ToInt16(reader["A71Trium"]);
                measur.A72Trium = Convert.ToInt16(reader["A72Trium"]);
                measur.A73Trium = Convert.ToInt16(reader["A73Trium"]);
                measur.A74Trium = Convert.ToInt16(reader["A74Trium"]);
                measur.A75Trium = Convert.ToInt16(reader["A75Trium"]);
                measur.A76Trium = Convert.ToInt16(reader["A76Trium"]);
                measur.A78Trium = Convert.ToInt16(reader["A78Trium"]);
                measur.A79Trium = Convert.ToInt16(reader["A79Trium"]);
                measur.A80Trium = Convert.ToInt16(reader["A80Trium"]);
                measur.A81Trium = Convert.ToInt16(reader["A81Trium"]);
                measur.A82Trium = Convert.ToInt16(reader["A82Trium"]);
                measur.A84Trium = Convert.ToInt16(reader["A84Trium"]);
                measur.A85Trium = Convert.ToInt16(reader["A85Trium"]);
                measur.A88Trium = Convert.ToInt16(reader["A88Trium"]);
                measur.A89Trium = Convert.ToInt16(reader["A89Trium"]);
                measur.A91Trium = Convert.ToInt16(reader["A91Trium"]);
                measur.A93Trium = Convert.ToInt16(reader["A93Trium"]);
                measur.A2Network = Convert.ToInt16(reader["A2Network"]);
                measur.A3Network = Convert.ToInt16(reader["A3Network"]);
                measur.A4Network = Convert.ToInt16(reader["A4Network"]);
                measur.A6Network = Convert.ToInt16(reader["A6Network"]);
                measur.A9Network = Convert.ToInt16(reader["A9Network"]);
                measur.A10Network = Convert.ToInt16(reader["A10Network"]);
                measur.A12Network = Convert.ToInt16(reader["A12Network"]);
                measur.A17Network = Convert.ToInt16(reader["A17Network"]);
                measur.A18Network = Convert.ToInt16(reader["A18Network"]);
                measur.A19Network = Convert.ToInt16(reader["A19Network"]);
                measur.A20Network = Convert.ToInt16(reader["A20Network"]);
                measur.A21Network = Convert.ToInt16(reader["A21Network"]);
                measur.A23Network = Convert.ToInt16(reader["A23Network"]);
                measur.A25Network = Convert.ToInt16(reader["A25Network"]);
                measur.A26Network = Convert.ToInt16(reader["A26Network"]);
                measur.A27Network = Convert.ToInt16(reader["A27Network"]);
                measur.A28Network = Convert.ToInt16(reader["A28Network"]);
                measur.A35Network = Convert.ToInt16(reader["A35Network"]);
                measur.A37Network = Convert.ToInt16(reader["A37Network"]);
                measur.A38Network = Convert.ToInt16(reader["A38Network"]);
                measur.A39Network = Convert.ToInt16(reader["A39Network"]);
                measur.A41Network = Convert.ToInt16(reader["A41Network"]);
                measur.A42Network = Convert.ToInt16(reader["A42Network"]);
                measur.A45Network = Convert.ToInt16(reader["A45Network"]);
                measur.A49Network = Convert.ToInt16(reader["A49Network"]);
                measur.A51Network = Convert.ToInt16(reader["A51Network"]);
                measur.A52Network = Convert.ToInt16(reader["A52Network"]);
                measur.A53Network = Convert.ToInt16(reader["A53Network"]);
                measur.A57Network = Convert.ToInt16(reader["A57Network"]);
                measur.A58Network = Convert.ToInt16(reader["A58Network"]);
                measur.A59Network = Convert.ToInt16(reader["A59Network"]);
                measur.A61Network = Convert.ToInt16(reader["A61Network"]);
                measur.A67Network = Convert.ToInt16(reader["A67Network"]);
                measur.A68Network = Convert.ToInt16(reader["A68Network"]);
                measur.A69Network = Convert.ToInt16(reader["A69Network"]);
                measur.A70Network = Convert.ToInt16(reader["A70Network"]);
                measur.A72Network = Convert.ToInt16(reader["A72Network"]);
                measur.A73Network = Convert.ToInt16(reader["A73Network"]);
                measur.A74Network = Convert.ToInt16(reader["A74Network"]);
                measur.A75Network = Convert.ToInt16(reader["A75Network"]);
                measur.A76Network = Convert.ToInt16(reader["A76Network"]);
                measur.A78Network = Convert.ToInt16(reader["A78Network"]);
                measur.A79Network = Convert.ToInt16(reader["A79Network"]);
                measur.A80Network = Convert.ToInt16(reader["A80Network"]);
                measur.A82Network = Convert.ToInt16(reader["A82Network"]);
                measur.A84Network = Convert.ToInt16(reader["A84Network"]);
                measur.A85Network = Convert.ToInt16(reader["A85Network"]);
                measur.A88Network = Convert.ToInt16(reader["A88Network"]);
                measur.A89Network = Convert.ToInt16(reader["A89Network"]);
                measur.A91Network = Convert.ToInt16(reader["A91Network"]);
                measur.A92Network = Convert.ToInt16(reader["A92Network"]);
                measur.A3Classic = Convert.ToInt16(reader["A3Classic"]);
                measur.A4Classic = Convert.ToInt16(reader["A4Classic"]);
                measur.A6Classic = Convert.ToInt16(reader["A6Classic"]);
                measur.A19Classic = Convert.ToInt16(reader["A19Classic"]);
                measur.A20Classic = Convert.ToInt16(reader["A20Classic"]);
                measur.A21Classic = Convert.ToInt16(reader["A21Classic"]);
                measur.A23Classic = Convert.ToInt16(reader["A23Classic"]);
                measur.A27Classic = Convert.ToInt16(reader["A27Classic"]);
                measur.A28Classic = Convert.ToInt16(reader["A28Classic"]);
                measur.A35Classic = Convert.ToInt16(reader["A35Classic"]);
                measur.A41Classic = Convert.ToInt16(reader["A41Classic"]);
                measur.A42Classic = Convert.ToInt16(reader["A42Classic"]);
                measur.A53Classic = Convert.ToInt16(reader["A53Classic"]);
                measur.A57Classic = Convert.ToInt16(reader["A57Classic"]);
                measur.A58Classic = Convert.ToInt16(reader["A58Classic"]);
                measur.A59Classic = Convert.ToInt16(reader["A59Classic"]);
                measur.A65Classic = Convert.ToInt16(reader["A65Classic"]);
                measur.A68Classic = Convert.ToInt16(reader["A68Classic"]);
                measur.A70Classic = Convert.ToInt16(reader["A70Classic"]);
                measur.A72Classic = Convert.ToInt16(reader["A72Classic"]);
                measur.A73Classic = Convert.ToInt16(reader["A73Classic"]);
                measur.A74Classic = Convert.ToInt16(reader["A74Classic"]);
                measur.A75Classic = Convert.ToInt16(reader["A75Classic"]);
                measur.A77Classic = Convert.ToInt16(reader["A77Classic"]);
                measur.A78Classic = Convert.ToInt16(reader["A78Classic"]);
                measur.A82Classic = Convert.ToInt16(reader["A82Classic"]);
                measur.A84Classic = Convert.ToInt16(reader["A84Classic"]);
                measur.A91Classic = Convert.ToInt16(reader["A91Classic"]);
                measur.A94Classic = Convert.ToInt16(reader["A94Classic"]);
                measur.UstGiyimEbat = reader["UstGiyimEbat"].ToString();
                measur.BMIndex = (reader["BMIndex"].ToString());
                measur.BKoran = (reader["BKoran"].ToString());
                measur.Birlik = reader["Birlik"].ToString();
                measur.PantolonEbat = reader["PantolonEbat"].ToString();
                measur.BotEbat = reader["BotEbat"].ToString();
                measur.EldivenEbat = reader["EldivenEbat"].ToString();



                measurs.Add(measur);

            }
            reader.Close();
            _baglan.Close();
            return measurs;



        }

        public void ClearAllDataBase()
        {
            connect();

            SqlCommand command = new SqlCommand("TRUNCATE TABLE ThesesxData", _baglan);

            command.ExecuteNonQuery();

            _baglan.Close();
        }

        public List<Measur> IDDetay(string idarama)
        {
            connect();

            SqlCommand command = new SqlCommand("Select * From ThesesxData where Id like '%" + @idarama + "%'order by Id DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();



            command.Parameters.AddWithValue("@idarama", idarama);

            List<Measur> measurs = new List<Measur>();
            while (reader.Read())
            {
                Measur measur = new Measur();
                measur.Id = Convert.ToInt32(reader["Id"]);  //0
                measur.Tc = reader["Tc"].ToString();
                measur.Ad = reader["Ad"].ToString();
                measur.Soyad = reader["Soyad"].ToString();
                measur.A77 = Convert.ToInt16(reader["A77"]);
                measur.A87 = Convert.ToInt16(reader["A87"]);
                measur.A8 = Convert.ToInt16(reader["A8"]);
                measur.E101 = Convert.ToInt16(reader["E101"]);
                measur.E102 = Convert.ToInt16(reader["E102"]);
                measur.E103 = Convert.ToInt16(reader["E103"]);  //9

                measur.A2Trium = Convert.ToInt16(reader["A2Trium"]);
                measur.A3Trium = Convert.ToInt16(reader["A3Trium"]);
                measur.A4Trium = Convert.ToInt16(reader["A4Trium"]);
                measur.A5Trium = Convert.ToInt16(reader["A5Trium"]);
                measur.A6Trium = Convert.ToInt16(reader["A6Trium"]);
                measur.A7Trium = Convert.ToInt16(reader["A7Trium"]);  //15
                measur.A9Trium = Convert.ToInt16(reader["A9Trium"]);
                measur.A12Trium = Convert.ToInt16(reader["A12Trium"]);
                measur.A13Trium = Convert.ToInt16(reader["A13Trium"]);
                measur.A17Trium = Convert.ToInt16(reader["A17Trium"]);
                measur.A18Trium = Convert.ToInt16(reader["A18Trium"]);
                measur.A19Trium = Convert.ToInt16(reader["A19Trium"]);
                measur.A20Trium = Convert.ToInt16(reader["A20Trium"]);
                measur.A21Trium = Convert.ToInt16(reader["A21Trium"]);
                measur.A22Trium = Convert.ToInt16(reader["A22Trium"]);
                measur.A23Trium = Convert.ToInt16(reader["A23Trium"]);  //25
                measur.A25Trium = Convert.ToInt16(reader["A25Trium"]);
                measur.A26Trium = Convert.ToInt16(reader["A26Trium"]);
                measur.A27Trium = Convert.ToInt16(reader["A27Trium"]);
                measur.A28Trium = Convert.ToInt16(reader["A28Trium"]);
                measur.A29Trium = Convert.ToInt16(reader["A29Trium"]);   //30
                measur.A30Trium = Convert.ToInt16(reader["A30Trium"]);
                measur.A35Trium = Convert.ToInt16(reader["A35Trium"]);
                measur.A36Trium = Convert.ToInt16(reader["A36Trium"]);
                measur.A37Trium = Convert.ToInt16(reader["A37Trium"]);
                measur.A38Trium = Convert.ToInt16(reader["A38Trium"]);
                measur.A41Trium = Convert.ToInt16(reader["A41Trium"]);
                measur.A42Trium = Convert.ToInt16(reader["A42Trium"]);
                measur.A43Trium = Convert.ToInt16(reader["A43Trium"]);
                measur.A44Trium = Convert.ToInt16(reader["A44Trium"]);
                measur.A45Trium = Convert.ToInt16(reader["A45Trium"]);  //40
                measur.A49Trium = Convert.ToInt16(reader["A49Trium"]);
                measur.A51Trium = Convert.ToInt16(reader["A51Trium"]);
                measur.A52Trium = Convert.ToInt16(reader["A52Trium"]);
                measur.A53Trium = Convert.ToInt16(reader["A53Trium"]);
                measur.A55Trium = Convert.ToInt16(reader["A55Trium"]);
                measur.A56Trium = Convert.ToInt16(reader["A56Trium"]);
                measur.A57Trium = Convert.ToInt16(reader["A57Trium"]);
                measur.A58Trium = Convert.ToInt16(reader["A58Trium"]);
                measur.A59Trium = Convert.ToInt16(reader["A59Trium"]);
                measur.A61Trium = Convert.ToInt16(reader["A61Trium"]);  //50
                measur.A66Trium = Convert.ToInt16(reader["A66Trium"]);
                measur.A67Trium = Convert.ToInt16(reader["A67Trium"]);
                measur.A68Trium = Convert.ToInt16(reader["A68Trium"]);
                measur.A70Trium = Convert.ToInt16(reader["A70Trium"]);
                measur.A71Trium = Convert.ToInt16(reader["A71Trium"]);
                measur.A72Trium = Convert.ToInt16(reader["A72Trium"]);
                measur.A73Trium = Convert.ToInt16(reader["A73Trium"]);
                measur.A74Trium = Convert.ToInt16(reader["A74Trium"]);
                measur.A75Trium = Convert.ToInt16(reader["A75Trium"]);
                measur.A76Trium = Convert.ToInt16(reader["A76Trium"]); //60
                measur.A78Trium = Convert.ToInt16(reader["A78Trium"]);
                measur.A79Trium = Convert.ToInt16(reader["A79Trium"]);
                measur.A80Trium = Convert.ToInt16(reader["A80Trium"]);
                measur.A81Trium = Convert.ToInt16(reader["A81Trium"]);
                measur.A82Trium = Convert.ToInt16(reader["A82Trium"]);
                measur.A84Trium = Convert.ToInt16(reader["A84Trium"]);
                measur.A85Trium = Convert.ToInt16(reader["A85Trium"]);
                measur.A88Trium = Convert.ToInt16(reader["A88Trium"]);//68
                measur.A89Trium = Convert.ToInt16(reader["A89Trium"]);
                measur.A91Trium = Convert.ToInt16(reader["A91Trium"]);   //70
                measur.A93Trium = Convert.ToInt16(reader["A93Trium"]);
                measur.A2Network = Convert.ToInt16(reader["A2Network"]);
                measur.A3Network = Convert.ToInt16(reader["A3Network"]);
                measur.A4Network = Convert.ToInt16(reader["A4Network"]);
                measur.A6Network = Convert.ToInt16(reader["A6Network"]);
                measur.A9Network = Convert.ToInt16(reader["A9Network"]);
                measur.A10Network = Convert.ToInt16(reader["A10Network"]);
                measur.A12Network = Convert.ToInt16(reader["A12Network"]);
                measur.A17Network = Convert.ToInt16(reader["A17Network"]);
                measur.A18Network = Convert.ToInt16(reader["A18Network"]); //80
                measur.A19Network = Convert.ToInt16(reader["A19Network"]);
                measur.A20Network = Convert.ToInt16(reader["A20Network"]);
                measur.A21Network = Convert.ToInt16(reader["A21Network"]);
                measur.A23Network = Convert.ToInt16(reader["A23Network"]);
                measur.A25Network = Convert.ToInt16(reader["A25Network"]);
                measur.A26Network = Convert.ToInt16(reader["A26Network"]);
                measur.A27Network = Convert.ToInt16(reader["A27Network"]);
                measur.A28Network = Convert.ToInt16(reader["A28Network"]);
                measur.A35Network = Convert.ToInt16(reader["A35Network"]);
                measur.A37Network = Convert.ToInt16(reader["A37Network"]); //90
                measur.A38Network = Convert.ToInt16(reader["A38Network"]);
                measur.A39Network = Convert.ToInt16(reader["A39Network"]);
                measur.A41Network = Convert.ToInt16(reader["A41Network"]);
                measur.A42Network = Convert.ToInt16(reader["A42Network"]);
                measur.A45Network = Convert.ToInt16(reader["A45Network"]);
                measur.A49Network = Convert.ToInt16(reader["A49Network"]);
                measur.A51Network = Convert.ToInt16(reader["A51Network"]);
                measur.A52Network = Convert.ToInt16(reader["A52Network"]);
                measur.A53Network = Convert.ToInt16(reader["A53Network"]);
                measur.A57Network = Convert.ToInt16(reader["A57Network"]);//100
                measur.A58Network = Convert.ToInt16(reader["A58Network"]);
                measur.A59Network = Convert.ToInt16(reader["A59Network"]);
                measur.A61Network = Convert.ToInt16(reader["A61Network"]);
                measur.A67Network = Convert.ToInt16(reader["A67Network"]);
                measur.A68Network = Convert.ToInt16(reader["A68Network"]);
                measur.A69Network = Convert.ToInt16(reader["A69Network"]);
                measur.A70Network = Convert.ToInt16(reader["A70Network"]);
                measur.A72Network = Convert.ToInt16(reader["A72Network"]);
                measur.A73Network = Convert.ToInt16(reader["A73Network"]);
                measur.A74Network = Convert.ToInt16(reader["A74Network"]);//110
                measur.A75Network = Convert.ToInt16(reader["A75Network"]);
                measur.A76Network = Convert.ToInt16(reader["A76Network"]);
                measur.A78Network = Convert.ToInt16(reader["A78Network"]);
                measur.A79Network = Convert.ToInt16(reader["A79Network"]);
                measur.A80Network = Convert.ToInt16(reader["A80Network"]);
                measur.A82Network = Convert.ToInt16(reader["A82Network"]);
                measur.A84Network = Convert.ToInt16(reader["A84Network"]);
                measur.A85Network = Convert.ToInt16(reader["A85Network"]);
                measur.A88Network = Convert.ToInt16(reader["A88Network"]);
                measur.A89Network = Convert.ToInt16(reader["A89Network"]);
                measur.A91Network = Convert.ToInt16(reader["A91Network"]);
                measur.A92Network = Convert.ToInt16(reader["A92Network"]);//122

                measur.A3Classic = Convert.ToInt16(reader["A3Classic"]);
                measur.A4Classic = Convert.ToInt16(reader["A4Classic"]);
                measur.A6Classic = Convert.ToInt16(reader["A6Classic"]);
                measur.A19Classic = Convert.ToInt16(reader["A19Classic"]);
                measur.A20Classic = Convert.ToInt16(reader["A20Classic"]);
                measur.A21Classic = Convert.ToInt16(reader["A21Classic"]);
                measur.A23Classic = Convert.ToInt16(reader["A23Classic"]);
                measur.A27Classic = Convert.ToInt16(reader["A27Classic"]);
                measur.A28Classic = Convert.ToInt16(reader["A28Classic"]);
                measur.A35Classic = Convert.ToInt16(reader["A35Classic"]);
                measur.A41Classic = Convert.ToInt16(reader["A41Classic"]);
                measur.A42Classic = Convert.ToInt16(reader["A42Classic"]);
                measur.A53Classic = Convert.ToInt16(reader["A53Classic"]);
                measur.A57Classic = Convert.ToInt16(reader["A57Classic"]);
                measur.A58Classic = Convert.ToInt16(reader["A58Classic"]);
                measur.A59Classic = Convert.ToInt16(reader["A59Classic"]);
                measur.A65Classic = Convert.ToInt16(reader["A65Classic"]);
                measur.A68Classic = Convert.ToInt16(reader["A68Classic"]);
                measur.A70Classic = Convert.ToInt16(reader["A70Classic"]);
                measur.A72Classic = Convert.ToInt16(reader["A72Classic"]);
                measur.A73Classic = Convert.ToInt16(reader["A73Classic"]);
                measur.A74Classic = Convert.ToInt16(reader["A74Classic"]);
                measur.A75Classic = Convert.ToInt16(reader["A75Classic"]);
                measur.A77Classic = Convert.ToInt16(reader["A77Classic"]);
                measur.A78Classic = Convert.ToInt16(reader["A78Classic"]);
                measur.A82Classic = Convert.ToInt16(reader["A82Classic"]);
                measur.A84Classic = Convert.ToInt16(reader["A84Classic"]);
                measur.A91Classic = Convert.ToInt16(reader["A91Classic"]);
                measur.A94Classic = Convert.ToInt16(reader["A94Classic"]);


                measur.UstGiyimEbat = reader["UstGiyimEbat"].ToString();
                measur.BMIndex = (reader["BMIndex"].ToString());
                measur.BKoran = (reader["BKoran"].ToString());
                measur.Birlik = reader["Birlik"].ToString();
                measur.PantolonEbat = reader["PantolonEbat"].ToString();
                measur.BotEbat = reader["BotEbat"].ToString();
                measur.EldivenEbat = reader["EldivenEbat"].ToString();

                measurs.Add(measur);

            }
            reader.Close();
            _baglan.Close();
            return measurs;



        }
        public List<Measur> Get(string arama)
        {
            connect();


            SqlCommand command = new SqlCommand("Select * From ThesesxData where " + Choosecmb + " like '%" + @arama + "%'order by Id DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();
            command.Parameters.AddWithValue("@arama", arama);

            List<Measur> measurs = new List<Measur>();
            while (reader.Read())
            {
                Measur measur = new Measur();
                measur.Id = Convert.ToInt32(reader["Id"]);
                measur.Tc = reader["Tc"].ToString();
                measur.Ad = reader["Ad"].ToString();
                measur.Soyad = reader["Soyad"].ToString();
                measur.A77 = Convert.ToInt16(reader["A77"]);
                measur.A87 = Convert.ToInt16(reader["A87"]);
                measur.A8 = Convert.ToInt16(reader["A8"]);
                measur.E101 = Convert.ToInt16(reader["E101"]);
                measur.E102 = Convert.ToInt16(reader["E102"]);
                measur.E103 = Convert.ToInt16(reader["E103"]);


                measur.A2Trium = Convert.ToInt16(reader["A2Trium"]);
                measur.A3Trium = Convert.ToInt16(reader["A3Trium"]);
                measur.A4Trium = Convert.ToInt16(reader["A4Trium"]);
                measur.A5Trium = Convert.ToInt16(reader["A5Trium"]);
                measur.A6Trium = Convert.ToInt16(reader["A6Trium"]);
                measur.A7Trium = Convert.ToInt16(reader["A7Trium"]);
                measur.A9Trium = Convert.ToInt16(reader["A9Trium"]);
                measur.A12Trium = Convert.ToInt16(reader["A12Trium"]);
                measur.A13Trium = Convert.ToInt16(reader["A13Trium"]);
                measur.A17Trium = Convert.ToInt16(reader["A17Trium"]);
                measur.A18Trium = Convert.ToInt16(reader["A18Trium"]);
                measur.A19Trium = Convert.ToInt16(reader["A19Trium"]);
                measur.A20Trium = Convert.ToInt16(reader["A20Trium"]);
                measur.A21Trium = Convert.ToInt16(reader["A21Trium"]);
                measur.A22Trium = Convert.ToInt16(reader["A22Trium"]);
                measur.A23Trium = Convert.ToInt16(reader["A23Trium"]);
                measur.A25Trium = Convert.ToInt16(reader["A25Trium"]);
                measur.A26Trium = Convert.ToInt16(reader["A26Trium"]);
                measur.A27Trium = Convert.ToInt16(reader["A27Trium"]);
                measur.A28Trium = Convert.ToInt16(reader["A28Trium"]);
                measur.A29Trium = Convert.ToInt16(reader["A29Trium"]);
                measur.A30Trium = Convert.ToInt16(reader["A30Trium"]);
                measur.A35Trium = Convert.ToInt16(reader["A35Trium"]);
                measur.A36Trium = Convert.ToInt16(reader["A36Trium"]);
                measur.A37Trium = Convert.ToInt16(reader["A37Trium"]);
                measur.A38Trium = Convert.ToInt16(reader["A38Trium"]);
                measur.A41Trium = Convert.ToInt16(reader["A41Trium"]);
                measur.A42Trium = Convert.ToInt16(reader["A42Trium"]);
                measur.A43Trium = Convert.ToInt16(reader["A43Trium"]);
                measur.A44Trium = Convert.ToInt16(reader["A44Trium"]);
                measur.A45Trium = Convert.ToInt16(reader["A45Trium"]);
                measur.A49Trium = Convert.ToInt16(reader["A49Trium"]);
                measur.A51Trium = Convert.ToInt16(reader["A51Trium"]);
                measur.A52Trium = Convert.ToInt16(reader["A52Trium"]);
                measur.A53Trium = Convert.ToInt16(reader["A53Trium"]);
                measur.A55Trium = Convert.ToInt16(reader["A55Trium"]);
                measur.A56Trium = Convert.ToInt16(reader["A56Trium"]);
                measur.A57Trium = Convert.ToInt16(reader["A57Trium"]);
                measur.A58Trium = Convert.ToInt16(reader["A58Trium"]);
                measur.A59Trium = Convert.ToInt16(reader["A59Trium"]);
                measur.A61Trium = Convert.ToInt16(reader["A61Trium"]);
                measur.A66Trium = Convert.ToInt16(reader["A66Trium"]);
                measur.A67Trium = Convert.ToInt16(reader["A67Trium"]);
                measur.A68Trium = Convert.ToInt16(reader["A68Trium"]);
                measur.A70Trium = Convert.ToInt16(reader["A70Trium"]);
                measur.A71Trium = Convert.ToInt16(reader["A71Trium"]);
                measur.A72Trium = Convert.ToInt16(reader["A72Trium"]);
                measur.A73Trium = Convert.ToInt16(reader["A73Trium"]);
                measur.A74Trium = Convert.ToInt16(reader["A74Trium"]);
                measur.A75Trium = Convert.ToInt16(reader["A75Trium"]);
                measur.A76Trium = Convert.ToInt16(reader["A76Trium"]);
                measur.A78Trium = Convert.ToInt16(reader["A78Trium"]);
                measur.A79Trium = Convert.ToInt16(reader["A79Trium"]);
                measur.A80Trium = Convert.ToInt16(reader["A80Trium"]);
                measur.A81Trium = Convert.ToInt16(reader["A81Trium"]);
                measur.A82Trium = Convert.ToInt16(reader["A82Trium"]);
                measur.A84Trium = Convert.ToInt16(reader["A84Trium"]);
                measur.A85Trium = Convert.ToInt16(reader["A85Trium"]);
                measur.A88Trium = Convert.ToInt16(reader["A88Trium"]);
                measur.A89Trium = Convert.ToInt16(reader["A89Trium"]);
                measur.A91Trium = Convert.ToInt16(reader["A91Trium"]);
                measur.A93Trium = Convert.ToInt16(reader["A93Trium"]);
                measur.A2Network = Convert.ToInt16(reader["A2Network"]);
                measur.A3Network = Convert.ToInt16(reader["A3Network"]);
                measur.A4Network = Convert.ToInt16(reader["A4Network"]);
                measur.A6Network = Convert.ToInt16(reader["A6Network"]);
                measur.A9Network = Convert.ToInt16(reader["A9Network"]);
                measur.A10Network = Convert.ToInt16(reader["A10Network"]);
                measur.A12Network = Convert.ToInt16(reader["A12Network"]);
                measur.A17Network = Convert.ToInt16(reader["A17Network"]);
                measur.A18Network = Convert.ToInt16(reader["A18Network"]);
                measur.A19Network = Convert.ToInt16(reader["A19Network"]);
                measur.A20Network = Convert.ToInt16(reader["A20Network"]);
                measur.A21Network = Convert.ToInt16(reader["A21Network"]);
                measur.A23Network = Convert.ToInt16(reader["A23Network"]);
                measur.A25Network = Convert.ToInt16(reader["A25Network"]);
                measur.A26Network = Convert.ToInt16(reader["A26Network"]);
                measur.A27Network = Convert.ToInt16(reader["A27Network"]);
                measur.A28Network = Convert.ToInt16(reader["A28Network"]);
                measur.A35Network = Convert.ToInt16(reader["A35Network"]);
                measur.A37Network = Convert.ToInt16(reader["A37Network"]);
                measur.A38Network = Convert.ToInt16(reader["A38Network"]);
                measur.A39Network = Convert.ToInt16(reader["A39Network"]);
                measur.A41Network = Convert.ToInt16(reader["A41Network"]);
                measur.A42Network = Convert.ToInt16(reader["A42Network"]);
                measur.A45Network = Convert.ToInt16(reader["A45Network"]);
                measur.A49Network = Convert.ToInt16(reader["A49Network"]);
                measur.A51Network = Convert.ToInt16(reader["A51Network"]);
                measur.A52Network = Convert.ToInt16(reader["A52Network"]);
                measur.A53Network = Convert.ToInt16(reader["A53Network"]);
                measur.A57Network = Convert.ToInt16(reader["A57Network"]);
                measur.A58Network = Convert.ToInt16(reader["A58Network"]);
                measur.A59Network = Convert.ToInt16(reader["A59Network"]);
                measur.A61Network = Convert.ToInt16(reader["A61Network"]);
                measur.A67Network = Convert.ToInt16(reader["A67Network"]);
                measur.A68Network = Convert.ToInt16(reader["A68Network"]);
                measur.A69Network = Convert.ToInt16(reader["A69Network"]);
                measur.A70Network = Convert.ToInt16(reader["A70Network"]);
                measur.A72Network = Convert.ToInt16(reader["A72Network"]);
                measur.A73Network = Convert.ToInt16(reader["A73Network"]);
                measur.A74Network = Convert.ToInt16(reader["A74Network"]);
                measur.A75Network = Convert.ToInt16(reader["A75Network"]);
                measur.A76Network = Convert.ToInt16(reader["A76Network"]);
                measur.A78Network = Convert.ToInt16(reader["A78Network"]);
                measur.A79Network = Convert.ToInt16(reader["A79Network"]);
                measur.A80Network = Convert.ToInt16(reader["A80Network"]);
                measur.A82Network = Convert.ToInt16(reader["A82Network"]);
                measur.A84Network = Convert.ToInt16(reader["A84Network"]);
                measur.A85Network = Convert.ToInt16(reader["A85Network"]);
                measur.A88Network = Convert.ToInt16(reader["A88Network"]);
                measur.A89Network = Convert.ToInt16(reader["A89Network"]);
                measur.A91Network = Convert.ToInt16(reader["A91Network"]);
                measur.A92Network = Convert.ToInt16(reader["A92Network"]);


                measur.A3Classic = Convert.ToInt16(reader["A3Classic"]);
                measur.A4Classic = Convert.ToInt16(reader["A4Classic"]);
                measur.A6Classic = Convert.ToInt16(reader["A6Classic"]);
                measur.A19Classic = Convert.ToInt16(reader["A19Classic"]);
                measur.A20Classic = Convert.ToInt16(reader["A20Classic"]);
                measur.A21Classic = Convert.ToInt16(reader["A21Classic"]);
                measur.A23Classic = Convert.ToInt16(reader["A23Classic"]);
                measur.A27Classic = Convert.ToInt16(reader["A27Classic"]);
                measur.A28Classic = Convert.ToInt16(reader["A28Classic"]);
                measur.A35Classic = Convert.ToInt16(reader["A35Classic"]);
                measur.A41Classic = Convert.ToInt16(reader["A41Classic"]);
                measur.A42Classic = Convert.ToInt16(reader["A42Classic"]);
                measur.A53Classic = Convert.ToInt16(reader["A53Classic"]);
                measur.A57Classic = Convert.ToInt16(reader["A57Classic"]);
                measur.A58Classic = Convert.ToInt16(reader["A58Classic"]);
                measur.A59Classic = Convert.ToInt16(reader["A59Classic"]);
                measur.A65Classic = Convert.ToInt16(reader["A65Classic"]);
                measur.A68Classic = Convert.ToInt16(reader["A68Classic"]);
                measur.A70Classic = Convert.ToInt16(reader["A70Classic"]);
                measur.A72Classic = Convert.ToInt16(reader["A72Classic"]);
                measur.A73Classic = Convert.ToInt16(reader["A73Classic"]);
                measur.A74Classic = Convert.ToInt16(reader["A74Classic"]);
                measur.A75Classic = Convert.ToInt16(reader["A75Classic"]);
                measur.A77Classic = Convert.ToInt16(reader["A77Classic"]);
                measur.A78Classic = Convert.ToInt16(reader["A78Classic"]);
                measur.A82Classic = Convert.ToInt16(reader["A82Classic"]);
                measur.A84Classic = Convert.ToInt16(reader["A84Classic"]);
                measur.A91Classic = Convert.ToInt16(reader["A91Classic"]);
                measur.A94Classic = Convert.ToInt16(reader["A94Classic"]);


                measur.UstGiyimEbat = reader["UstGiyimEbat"].ToString();
                measur.BMIndex = (reader["BMIndex"].ToString());
                measur.BKoran = (reader["BKoran"].ToString());
                measur.Birlik = reader["Birlik"].ToString();
                measur.PantolonEbat = reader["PantolonEbat"].ToString();
                measur.BotEbat = reader["BotEbat"].ToString();
                measur.EldivenEbat = reader["EldivenEbat"].ToString();

                measurs.Add(measur);
            }
            reader.Close();
            _baglan.Close();
            return measurs;

        }




        public void YeniDonem(Measur Model)
        {
            connect();
            SqlCommand command = new SqlCommand("Insert Into Dashboarddata values (@totalsoldier,@karakuvvet,@denizkuvvet,@havakuvvet,@karatotalchest,@havatotalchest,@deniztotalchest,@kara_xs_chest,@kara_s_chest,@kara_m_chest,@kara_l_chest,@kara_xl_chest,@kara_2xl_chest,@hava_xs_chest,@hava_s_chest,@hava_m_chest,@hava_l_chest,@hava_2l_chest,@hava_xxl_chest,@deniz_xs_chest,@deniz_s_chest,@deniz_m_chest,@deniz_l_chest,@deniz_xl_chest,@deniz_2xl_chest,@karatotalbot,@havatotalbot,@deniztotalbot,@kara_34_bot,@kara_35_bot,@kara_36_bot,@kara_37_bot,@kara_38_bot,@kara_39_bot,@kara_40_bot,@kara_41_bot,@kara_42_bot,@kara_43_bot,@kara_44_bot,@kara_45_bot,@kara_46_bot,@kara_47_bot,@kara_48_bot,@hava_34_bot,@hava_35_bot,@hava_36_bot,@hava_37_bot,@hava_38_bot,@hava_39_bot,@hava_40_bot,@hava_41_bot,@hava_42_bot,@hava_43_bot,@hava_44_bot,@hava_45_bot,@hava_46_bot,@hava_47_bot,@hava_48_bot,@deniz_34_bot,@deniz_35_bot,@deniz_36_bot,@deniz_37_bot,@deniz_38_bot,@deniz_39_bot,@deniz_40_bot,@deniz_41_bot,@deniz_42_bot,@deniz_43_bot,@deniz_44_bot,@deniz_45_bot,@deniz_46_bot,@deniz_47_bot,@deniz_48_bot,@karatotalpant,@havatotalpant,@deniztotalpant,@kara_xs_pant,@kara_s_pant,@kara_m_pant,@kara_l_pant,@kara_xl_pant,@kara_2xl_pant,@kara_3xl_pant,@kara_bxl_pant,@hava_xs_pant,@hava_s_pant,@hava_m_pant,@hava_l_pant,@hava_xl_pant,@hava_2xl_pant,@hava_3xl_pant,@hava_bxl_pant,@deniz_xs_pant,@deniz_s_pant,@deniz_m_pant,@deniz_l_pant,@deniz_xl_pant,@deniz_2xl_pant,@deniz_3xl_pant,@deniz_bxl_pant,@karatotalhands,@havatotalhands,@deniztotalhands,@kara_xs_hands,@kara_s_hands,@kara_m_hands,@kara_l_hands,@kara_xl_hands,@kara_2xl_hands,@hava_xs_hands,@hava_s_hands,@hava_m_hands,@hava_l_hands,@hava_xl_hands,@hava_2xl_hands,@deniz_xs_hands,@deniz_s_hands,@deniz_m_hands,@deniz_l_hands,@deniz_xl_hands,@deniz_2xl_hands,@kara_140_150_boy,@kara_150_160_boy,@kara_160_170_boy,@kara_170_180_boy,@kara_180_190_boy,@kara_190_200_boy,@kara_200_210_boy,@kara_210_220_boy,@kara_220_230_boy,@hava_140_150_boy,@hava_150_160_boy,@hava_160_170_boy,@hava_170_180_boy,@hava_180_190_boy,@hava_190_200_boy,@hava_200_210_boy,@hava_210_220_boy,@hava_220_230_boy,@deniz_140_150_boy,@deniz_150_160_boy,@deniz_160_170_boy,@deniz_170_180_boy,@deniz_180_190_boy,@deniz_190_200_boy,@deniz_200_210_boy,@deniz_210_220_boy,@deniz_220_230_boy,@kara_140alti_uyluk,@kara_140_180_uyluk,@kara_180_220_uyluk,@kara_220_260_uyluk,@kara_260ustu_uyluk,@hava_140alti_uyluk,@hava_140_180_uyluk,@hava_180_220_uyluk,@hava_220_260_uyluk,@hava_260ustu_uyluk,@deniz_140alti_uyluk,@deniz_140_180_uyluk,@deniz_180_220_uyluk,@deniz_220_260_uyluk,@deniz_260ustu_uyluk)", _baglan);


            command.Parameters.AddWithValue("@totalsoldier", Model.totalsoldier);
            command.Parameters.AddWithValue("@karakuvvet", Model.karakuvvet);
            command.Parameters.AddWithValue("@denizkuvvet", Model.denizkuvvet);
            command.Parameters.AddWithValue("@havakuvvet", Model.havakuvvet);
            command.Parameters.AddWithValue("@karatotalchest", Model.karatotalchest);
            command.Parameters.AddWithValue("@havatotalchest", Model.havatotalchest);
            command.Parameters.AddWithValue("@deniztotalchest", Model.deniztotalchest);
            command.Parameters.AddWithValue("@kara_xs_chest", Model.kara_xs_chest);
            command.Parameters.AddWithValue("@kara_s_chest", Model.kara_s_chest);
            command.Parameters.AddWithValue("@kara_m_chest", Model.kara_m_chest);
            command.Parameters.AddWithValue("@kara_l_chest", Model.kara_l_chest);
            command.Parameters.AddWithValue("@kara_xl_chest", Model.kara_xl_chest);
            command.Parameters.AddWithValue("@kara_2xl_chest", Model.kara_2xl_chest);
            command.Parameters.AddWithValue("@hava_xs_chest", Model.hava_xs_chest);
            command.Parameters.AddWithValue("@hava_s_chest", Model.hava_s_chest);
            command.Parameters.AddWithValue("@hava_m_chest", Model.hava_m_chest);
            command.Parameters.AddWithValue("@hava_l_chest", Model.hava_l_chest);
            command.Parameters.AddWithValue("@hava_2l_chest", Model.hava_2l_chest);
            command.Parameters.AddWithValue("@hava_xxl_chest", Model.hava_xxl_chest);
            command.Parameters.AddWithValue("@deniz_xs_chest", Model.deniz_xs_chest);
            command.Parameters.AddWithValue("@deniz_s_chest", Model.deniz_s_chest);
            command.Parameters.AddWithValue("@deniz_m_chest", Model.deniz_m_chest);
            command.Parameters.AddWithValue("@deniz_l_chest", Model.deniz_l_chest);
            command.Parameters.AddWithValue("@deniz_xl_chest", Model.deniz_xl_chest);
            command.Parameters.AddWithValue("@deniz_2xl_chest", Model.deniz_2xl_chest);
            command.Parameters.AddWithValue("@karatotalbot", Model.karatotalbot);
            command.Parameters.AddWithValue("@havatotalbot", Model.havatotalbot);
            command.Parameters.AddWithValue("@deniztotalbot", Model.deniztotalbot);
            command.Parameters.AddWithValue("@kara_34_bot", Model.kara_34_bot);
            command.Parameters.AddWithValue("@kara_35_bot", Model.kara_35_bot);
            command.Parameters.AddWithValue("@kara_36_bot", Model.kara_36_bot);
            command.Parameters.AddWithValue("@kara_37_bot", Model.kara_37_bot);
            command.Parameters.AddWithValue("@kara_38_bot", Model.kara_38_bot);
            command.Parameters.AddWithValue("@kara_39_bot", Model.kara_39_bot);
            command.Parameters.AddWithValue("@kara_40_bot", Model.kara_40_bot);
            command.Parameters.AddWithValue("@kara_41_bot", Model.kara_41_bot);
            command.Parameters.AddWithValue("@kara_42_bot", Model.kara_42_bot);
            command.Parameters.AddWithValue("@kara_43_bot", Model.kara_43_bot);
            command.Parameters.AddWithValue("@kara_44_bot", Model.kara_44_bot);
            command.Parameters.AddWithValue("@kara_45_bot", Model.kara_45_bot);
            command.Parameters.AddWithValue("@kara_46_bot", Model.kara_46_bot);
            command.Parameters.AddWithValue("@kara_47_bot", Model.kara_47_bot);
            command.Parameters.AddWithValue("@kara_48_bot", Model.kara_48_bot);
            command.Parameters.AddWithValue("@hava_34_bot", Model.hava_34_bot);
            command.Parameters.AddWithValue("@hava_35_bot", Model.hava_35_bot);
            command.Parameters.AddWithValue("@hava_36_bot", Model.hava_36_bot);
            command.Parameters.AddWithValue("@hava_37_bot", Model.hava_37_bot);
            command.Parameters.AddWithValue("@hava_38_bot", Model.hava_38_bot);
            command.Parameters.AddWithValue("@hava_39_bot", Model.hava_39_bot);
            command.Parameters.AddWithValue("@hava_40_bot", Model.hava_40_bot);
            command.Parameters.AddWithValue("@hava_41_bot", Model.hava_41_bot);
            command.Parameters.AddWithValue("@hava_42_bot", Model.hava_42_bot);
            command.Parameters.AddWithValue("@hava_43_bot", Model.hava_43_bot);
            command.Parameters.AddWithValue("@hava_44_bot", Model.hava_44_bot);
            command.Parameters.AddWithValue("@hava_45_bot", Model.hava_45_bot);
            command.Parameters.AddWithValue("@hava_46_bot", Model.hava_46_bot);
            command.Parameters.AddWithValue("@hava_47_bot", Model.hava_47_bot);
            command.Parameters.AddWithValue("@hava_48_bot", Model.hava_48_bot);
            command.Parameters.AddWithValue("@deniz_34_bot", Model.deniz_34_bot);
            command.Parameters.AddWithValue("@deniz_35_bot", Model.deniz_35_bot);
            command.Parameters.AddWithValue("@deniz_36_bot", Model.deniz_36_bot);
            command.Parameters.AddWithValue("@deniz_37_bot", Model.deniz_37_bot);
            command.Parameters.AddWithValue("@deniz_38_bot", Model.deniz_38_bot);
            command.Parameters.AddWithValue("@deniz_39_bot", Model.deniz_39_bot);
            command.Parameters.AddWithValue("@deniz_40_bot", Model.deniz_40_bot);
            command.Parameters.AddWithValue("@deniz_41_bot", Model.deniz_41_bot);
            command.Parameters.AddWithValue("@deniz_42_bot", Model.deniz_42_bot);
            command.Parameters.AddWithValue("@deniz_43_bot", Model.deniz_43_bot);
            command.Parameters.AddWithValue("@deniz_44_bot", Model.deniz_44_bot);
            command.Parameters.AddWithValue("@deniz_45_bot", Model.deniz_45_bot);
            command.Parameters.AddWithValue("@deniz_46_bot", Model.deniz_46_bot);
            command.Parameters.AddWithValue("@deniz_47_bot", Model.deniz_47_bot);
            command.Parameters.AddWithValue("@deniz_48_bot", Model.deniz_48_bot);
            command.Parameters.AddWithValue("@karatotalpant", Model.karatotalpant);
            command.Parameters.AddWithValue("@havatotalpant", Model.havatotalpant);
            command.Parameters.AddWithValue("@deniztotalpant", Model.deniztotalpant);
            command.Parameters.AddWithValue("@kara_xs_pant", Model.kara_xs_pant);
            command.Parameters.AddWithValue("@kara_s_pant", Model.kara_s_pant);
            command.Parameters.AddWithValue("@kara_m_pant", Model.kara_m_pant);
            command.Parameters.AddWithValue("@kara_l_pant", Model.kara_l_pant);
            command.Parameters.AddWithValue("@kara_xl_pant", Model.kara_xl_pant);
            command.Parameters.AddWithValue("@kara_2xl_pant", Model.kara_2xl_pant);
            command.Parameters.AddWithValue("@kara_3xl_pant", Model.kara_3xl_pant);
            command.Parameters.AddWithValue("@kara_bxl_pant", Model.kara_bxl_pant);
            command.Parameters.AddWithValue("@hava_xs_pant", Model.hava_xs_pant);
            command.Parameters.AddWithValue("@hava_s_pant", Model.hava_s_pant);
            command.Parameters.AddWithValue("@hava_m_pant", Model.hava_m_pant);
            command.Parameters.AddWithValue("@hava_l_pant", Model.hava_l_pant);
            command.Parameters.AddWithValue("@hava_xl_pant", Model.hava_xl_pant);
            command.Parameters.AddWithValue("@hava_2xl_pant", Model.hava_2xl_pant);
            command.Parameters.AddWithValue("@hava_3xl_pant", Model.hava_3xl_pant);
            command.Parameters.AddWithValue("@hava_bxl_pant", Model.hava_bxl_pant);
            command.Parameters.AddWithValue("@deniz_xs_pant", Model.deniz_xs_pant);
            command.Parameters.AddWithValue("@deniz_s_pant", Model.deniz_s_pant);
            command.Parameters.AddWithValue("@deniz_m_pant", Model.deniz_m_pant);
            command.Parameters.AddWithValue("@deniz_l_pant", Model.deniz_l_pant);
            command.Parameters.AddWithValue("@deniz_xl_pant", Model.deniz_xl_pant);
            command.Parameters.AddWithValue("@deniz_2xl_pant", Model.deniz_2xl_pant);
            command.Parameters.AddWithValue("@deniz_3xl_pant", Model.deniz_3xl_pant);
            command.Parameters.AddWithValue("@deniz_bxl_pant", Model.deniz_bxl_pant);
            command.Parameters.AddWithValue("@karatotalhands", Model.karatotalhands);
            command.Parameters.AddWithValue("@havatotalhands", Model.havatotalhands);
            command.Parameters.AddWithValue("@deniztotalhands", Model.deniztotalhands);
            command.Parameters.AddWithValue("@kara_xs_hands", Model.kara_xs_hands);
            command.Parameters.AddWithValue("@kara_s_hands", Model.kara_s_hands);
            command.Parameters.AddWithValue("@kara_m_hands", Model.kara_m_hands);
            command.Parameters.AddWithValue("@kara_l_hands", Model.kara_l_hands);
            command.Parameters.AddWithValue("@kara_xl_hands", Model.kara_xl_hands);
            command.Parameters.AddWithValue("@kara_2xl_hands", Model.kara_2xl_hands);
            command.Parameters.AddWithValue("@hava_xs_hands", Model.hava_xs_hands);
            command.Parameters.AddWithValue("@hava_s_hands", Model.hava_s_hands);
            command.Parameters.AddWithValue("@hava_m_hands", Model.hava_m_hands);
            command.Parameters.AddWithValue("@hava_l_hands", Model.hava_l_hands);
            command.Parameters.AddWithValue("@hava_xl_hands", Model.hava_xl_hands);
            command.Parameters.AddWithValue("@hava_2xl_hands", Model.hava_2xl_hands);
            command.Parameters.AddWithValue("@deniz_xs_hands", Model.deniz_xs_hands);
            command.Parameters.AddWithValue("@deniz_s_hands", Model.deniz_s_hands);
            command.Parameters.AddWithValue("@deniz_m_hands", Model.deniz_m_hands);
            command.Parameters.AddWithValue("@deniz_l_hands", Model.deniz_l_hands);
            command.Parameters.AddWithValue("@deniz_xl_hands", Model.deniz_xl_hands);
            command.Parameters.AddWithValue("@deniz_2xl_hands", Model.deniz_2xl_hands);
            command.Parameters.AddWithValue("@kara_140_150_boy", Model.kara_140_150_boy);
            command.Parameters.AddWithValue("@kara_150_160_boy", Model.kara_150_160_boy);
            command.Parameters.AddWithValue("@kara_160_170_boy", Model.kara_160_170_boy);
            command.Parameters.AddWithValue("@kara_170_180_boy", Model.kara_170_180_boy);
            command.Parameters.AddWithValue("@kara_180_190_boy", Model.kara_180_190_boy);
            command.Parameters.AddWithValue("@kara_190_200_boy", Model.kara_190_200_boy);
            command.Parameters.AddWithValue("@kara_200_210_boy", Model.kara_200_210_boy);
            command.Parameters.AddWithValue("@kara_210_220_boy", Model.kara_210_220_boy);
            command.Parameters.AddWithValue("@kara_220_230_boy", Model.kara_220_230_boy);
            command.Parameters.AddWithValue("@hava_140_150_boy", Model.hava_140_150_boy);
            command.Parameters.AddWithValue("@hava_150_160_boy", Model.hava_150_160_boy);
            command.Parameters.AddWithValue("@hava_160_170_boy", Model.hava_160_170_boy);
            command.Parameters.AddWithValue("@hava_170_180_boy", Model.hava_170_180_boy);
            command.Parameters.AddWithValue("@hava_180_190_boy", Model.hava_180_190_boy);
            command.Parameters.AddWithValue("@hava_190_200_boy", Model.hava_190_200_boy);
            command.Parameters.AddWithValue("@hava_200_210_boy", Model.hava_200_210_boy);
            command.Parameters.AddWithValue("@hava_210_220_boy", Model.hava_210_220_boy);
            command.Parameters.AddWithValue("@hava_220_230_boy", Model.hava_220_230_boy);
            command.Parameters.AddWithValue("@deniz_140_150_boy", Model.deniz_140_150_boy);
            command.Parameters.AddWithValue("@deniz_150_160_boy", Model.deniz_150_160_boy);
            command.Parameters.AddWithValue("@deniz_160_170_boy", Model.deniz_160_170_boy);
            command.Parameters.AddWithValue("@deniz_170_180_boy", Model.deniz_170_180_boy);
            command.Parameters.AddWithValue("@deniz_180_190_boy", Model.deniz_180_190_boy);
            command.Parameters.AddWithValue("@deniz_190_200_boy", Model.deniz_190_200_boy);
            command.Parameters.AddWithValue("@deniz_200_210_boy", Model.deniz_200_210_boy);
            command.Parameters.AddWithValue("@deniz_210_220_boy", Model.deniz_210_220_boy);
            command.Parameters.AddWithValue("@deniz_220_230_boy", Model.deniz_220_230_boy);
            command.Parameters.AddWithValue("@kara_140alti_uyluk", Model.kara_140alti_uyluk);
            command.Parameters.AddWithValue("@kara_140_180_uyluk", Model.kara_140_180_uyluk);
            command.Parameters.AddWithValue("@kara_180_220_uyluk", Model.kara_180_220_uyluk);
            command.Parameters.AddWithValue("@kara_220_260_uyluk", Model.kara_220_260_uyluk);
            command.Parameters.AddWithValue("@kara_260ustu_uyluk", Model.kara_260ustu_uyluk);
            command.Parameters.AddWithValue("@hava_140alti_uyluk", Model.hava_140alti_uyluk);
            command.Parameters.AddWithValue("@hava_140_180_uyluk", Model.hava_140_180_uyluk);
            command.Parameters.AddWithValue("@hava_180_220_uyluk", Model.hava_180_220_uyluk);
            command.Parameters.AddWithValue("@hava_220_260_uyluk", Model.hava_220_260_uyluk);
            command.Parameters.AddWithValue("@hava_260ustu_uyluk", Model.hava_260ustu_uyluk);
            command.Parameters.AddWithValue("@deniz_140alti_uyluk", Model.deniz_140alti_uyluk);
            command.Parameters.AddWithValue("@deniz_140_180_uyluk", Model.deniz_140_180_uyluk);
            command.Parameters.AddWithValue("@deniz_180_220_uyluk", Model.deniz_180_220_uyluk);
            command.Parameters.AddWithValue("@deniz_220_260_uyluk", Model.deniz_220_260_uyluk);
            command.Parameters.AddWithValue("@deniz_260ustu_uyluk", Model.deniz_260ustu_uyluk);
            command.ExecuteNonQuery();
            _baglan.Close();


        }

        public void Kaydet(Measur Model)
        {
            connect();

            SqlCommand command = new SqlCommand(
               "Insert Into ThesesxData values              (@Tc,@Ad,@Soyad,@A77,@A87,@A8,@E101,@E102,@E103,@A2Trium,@A3Trium,@A4Trium,@A5Trium,@A6Trium,@A7Trium,@A9Trium,@A12Trium,@A13Trium,@A17Trium,@A18Trium,@A19Trium,@A20Trium,@A21Trium,@A22Trium,@A23Trium,@A25Trium,@A26Trium,@A27Trium,@A28Trium,@A29Trium,@A30Trium,@A35Trium,@A36Trium,@A37Trium,@A38Trium,@A41Trium,@A42Trium,@A43Trium,@A44Trium,@A45Trium,@A49Trium,@A51Trium,@A52Trium,@A53Trium,@A55Trium,@A56Trium,@A57Trium,@A58Trium,@A59Trium,@A61Trium,@A66Trium,@A67Trium,@A68Trium,@A70Trium,@A71Trium,@A72Trium,@A73Trium,@A74Trium,@A75Trium,@A76Trium,@A78Trium,@A79Trium,@A80Trium,@A81Trium,@A82Trium,@A84Trium,@A85Trium,@A88Trium,@A89Trium,@A91Trium,@A93Trium,@A2Network,@A3Network,@A4Network,@A6Network,@A9Network,@A10Network,@A12Network,@A17Network,@A18Network,@A19Network,@A20Network,@A21Network,@A23Network,@A25Network,@A26Network,@A27Network,@A28Network,@A35Network,@A37Network,@A38Network,@A39Network,@A41Network,@A42Network,@A45Network,@A49Network,@A51Network,@A52Network,@A53Network,@A57Network,@A58Network,@A59Network,@A61Network,@A67Network,@A68Network,@A69Network,@A70Network,@A72Network,@A73Network,@A74Network,@A75Network,@A76Network,@A78Network,@A79Network,@A80Network,@A82Network,@A84Network,@A85Network,@A88Network,@A89Network,@A91Network,@A92Network,@A3Classic,@A4Classic,@A6Classic,@A19Classic,@A20Classic,@A21Classic,@A23Classic,@A27Classic,@A28Classic,@A35Classic,@A41Classic,@A42Classic,@A53Classic,@A57Classic,@A58Classic,@A59Classic,@A65Classic,@A68Classic,@A70Classic,@A72Classic,@A73Classic,@A74Classic,@A75Classic,@A77Classic,@A78Classic,@A82Classic,@A84Classic,@A91Classic,@A94Classic,@UstGiyimEbat,@BMIndex,@BKoran,@Birlik,@PantolonEbat,@BotEbat,@EldivenEbat)", _baglan);

            command.Parameters.AddWithValue("@Tc", Model.Tc);
            command.Parameters.AddWithValue("@Ad", Model.Ad);
            command.Parameters.AddWithValue("@Soyad", Model.Soyad);
            command.Parameters.AddWithValue("@A77", Model.A77);
            command.Parameters.AddWithValue("@A87", Model.A87);
            command.Parameters.AddWithValue("@A8", Model.A8);

            command.Parameters.AddWithValue("@E101", Model.E101);
            command.Parameters.AddWithValue("@E102", Model.E102);
            command.Parameters.AddWithValue("@E103", Model.E103);



            command.Parameters.AddWithValue("@A2Trium", Model.A2Trium);
            command.Parameters.AddWithValue("@A3Trium", Model.A3Trium);
            command.Parameters.AddWithValue("@A4Trium", Model.A4Trium);
            command.Parameters.AddWithValue("@A5Trium", Model.A5Trium);
            command.Parameters.AddWithValue("@A6Trium", Model.A6Trium);
            command.Parameters.AddWithValue("@A7Trium", Model.A7Trium);
            command.Parameters.AddWithValue("@A9Trium", Model.A9Trium);
            command.Parameters.AddWithValue("@A12Trium", Model.A12Trium);
            command.Parameters.AddWithValue("@A13Trium", Model.A13Trium);
            command.Parameters.AddWithValue("@A17Trium", Model.A17Trium);
            command.Parameters.AddWithValue("@A18Trium", Model.A18Trium);
            command.Parameters.AddWithValue("@A19Trium", Model.A19Trium);
            command.Parameters.AddWithValue("@A20Trium", Model.A20Trium);
            command.Parameters.AddWithValue("@A21Trium", Model.A21Trium);
            command.Parameters.AddWithValue("@A22Trium", Model.A22Trium);
            command.Parameters.AddWithValue("@A23Trium", Model.A23Trium);
            command.Parameters.AddWithValue("@A25Trium", Model.A25Trium);
            command.Parameters.AddWithValue("@A26Trium", Model.A26Trium);
            command.Parameters.AddWithValue("@A27Trium", Model.A27Trium);
            command.Parameters.AddWithValue("@A28Trium", Model.A28Trium);
            command.Parameters.AddWithValue("@A29Trium", Model.A29Trium);
            command.Parameters.AddWithValue("@A30Trium", Model.A30Trium);
            command.Parameters.AddWithValue("@A35Trium", Model.A35Trium);
            command.Parameters.AddWithValue("@A36Trium", Model.A36Trium);
            command.Parameters.AddWithValue("@A37Trium", Model.A37Trium);
            command.Parameters.AddWithValue("@A38Trium", Model.A38Trium);
            command.Parameters.AddWithValue("@A41Trium", Model.A41Trium);
            command.Parameters.AddWithValue("@A42Trium", Model.A42Trium);
            command.Parameters.AddWithValue("@A43Trium", Model.A43Trium);
            command.Parameters.AddWithValue("@A44Trium", Model.A44Trium);
            command.Parameters.AddWithValue("@A45Trium", Model.A45Trium);
            command.Parameters.AddWithValue("@A49Trium", Model.A49Trium);
            command.Parameters.AddWithValue("@A51Trium", Model.A51Trium);
            command.Parameters.AddWithValue("@A52Trium", Model.A52Trium);
            command.Parameters.AddWithValue("@A53Trium", Model.A53Trium);
            command.Parameters.AddWithValue("@A55Trium", Model.A55Trium);
            command.Parameters.AddWithValue("@A56Trium", Model.A56Trium);
            command.Parameters.AddWithValue("@A57Trium", Model.A57Trium);
            command.Parameters.AddWithValue("@A58Trium", Model.A58Trium);
            command.Parameters.AddWithValue("@A59Trium", Model.A59Trium);
            command.Parameters.AddWithValue("@A61Trium", Model.A61Trium);
            command.Parameters.AddWithValue("@A66Trium", Model.A66Trium);
            command.Parameters.AddWithValue("@A67Trium", Model.A67Trium);
            command.Parameters.AddWithValue("@A68Trium", Model.A68Trium);
            command.Parameters.AddWithValue("@A70Trium", Model.A70Trium);
            command.Parameters.AddWithValue("@A71Trium", Model.A71Trium);
            command.Parameters.AddWithValue("@A72Trium", Model.A72Trium);
            command.Parameters.AddWithValue("@A73Trium", Model.A73Trium);
            command.Parameters.AddWithValue("@A74Trium", Model.A74Trium);
            command.Parameters.AddWithValue("@A75Trium", Model.A75Trium);
            command.Parameters.AddWithValue("@A76Trium", Model.A76Trium);
            command.Parameters.AddWithValue("@A78Trium", Model.A78Trium);
            command.Parameters.AddWithValue("@A79Trium", Model.A79Trium);
            command.Parameters.AddWithValue("@A80Trium", Model.A80Trium);
            command.Parameters.AddWithValue("@A81Trium", Model.A81Trium);
            command.Parameters.AddWithValue("@A82Trium", Model.A82Trium);
            command.Parameters.AddWithValue("@A84Trium", Model.A84Trium);
            command.Parameters.AddWithValue("@A85Trium", Model.A85Trium);
            command.Parameters.AddWithValue("@A88Trium", Model.A88Trium);
            command.Parameters.AddWithValue("@A89Trium", Model.A89Trium);
            command.Parameters.AddWithValue("@A91Trium", Model.A91Trium);
            command.Parameters.AddWithValue("@A93Trium", Model.A93Trium);
            command.Parameters.AddWithValue("@A2Network", Model.A2Network);
            command.Parameters.AddWithValue("@A3Network", Model.A3Network);
            command.Parameters.AddWithValue("@A4Network", Model.A4Network);
            command.Parameters.AddWithValue("@A6Network", Model.A6Network);
            command.Parameters.AddWithValue("@A9Network", Model.A9Network);
            command.Parameters.AddWithValue("@A10Network", Model.A10Network);
            command.Parameters.AddWithValue("@A12Network", Model.A12Network);
            command.Parameters.AddWithValue("@A17Network", Model.A17Network);
            command.Parameters.AddWithValue("@A18Network", Model.A18Network);
            command.Parameters.AddWithValue("@A19Network", Model.A19Network);
            command.Parameters.AddWithValue("@A20Network", Model.A20Network);
            command.Parameters.AddWithValue("@A21Network", Model.A21Network);
            command.Parameters.AddWithValue("@A23Network", Model.A23Network);
            command.Parameters.AddWithValue("@A25Network", Model.A25Network);
            command.Parameters.AddWithValue("@A26Network", Model.A26Network);
            command.Parameters.AddWithValue("@A27Network", Model.A27Network);
            command.Parameters.AddWithValue("@A28Network", Model.A28Network);
            command.Parameters.AddWithValue("@A35Network", Model.A35Network);
            command.Parameters.AddWithValue("@A37Network", Model.A37Network);
            command.Parameters.AddWithValue("@A38Network", Model.A38Network);
            command.Parameters.AddWithValue("@A39Network", Model.A39Network);
            command.Parameters.AddWithValue("@A41Network", Model.A41Network);
            command.Parameters.AddWithValue("@A42Network", Model.A42Network);
            command.Parameters.AddWithValue("@A45Network", Model.A45Network);
            command.Parameters.AddWithValue("@A49Network", Model.A49Network);
            command.Parameters.AddWithValue("@A51Network", Model.A51Network);
            command.Parameters.AddWithValue("@A52Network", Model.A52Network);
            command.Parameters.AddWithValue("@A53Network", Model.A53Network);
            command.Parameters.AddWithValue("@A57Network", Model.A57Network);
            command.Parameters.AddWithValue("@A58Network", Model.A58Network);
            command.Parameters.AddWithValue("@A59Network", Model.A59Network);
            command.Parameters.AddWithValue("@A61Network", Model.A61Network);
            command.Parameters.AddWithValue("@A67Network", Model.A67Network);
            command.Parameters.AddWithValue("@A68Network", Model.A68Network);
            command.Parameters.AddWithValue("@A69Network", Model.A69Network);
            command.Parameters.AddWithValue("@A70Network", Model.A70Network);
            command.Parameters.AddWithValue("@A72Network", Model.A72Network);
            command.Parameters.AddWithValue("@A73Network", Model.A73Network);
            command.Parameters.AddWithValue("@A74Network", Model.A74Network);
            command.Parameters.AddWithValue("@A75Network", Model.A75Network);
            command.Parameters.AddWithValue("@A76Network", Model.A76Network);
            command.Parameters.AddWithValue("@A78Network", Model.A78Network);
            command.Parameters.AddWithValue("@A79Network", Model.A79Network);
            command.Parameters.AddWithValue("@A80Network", Model.A80Network);
            command.Parameters.AddWithValue("@A82Network", Model.A82Network);
            command.Parameters.AddWithValue("@A84Network", Model.A84Network);
            command.Parameters.AddWithValue("@A85Network", Model.A85Network);
            command.Parameters.AddWithValue("@A88Network", Model.A88Network);
            command.Parameters.AddWithValue("@A89Network", Model.A89Network);
            command.Parameters.AddWithValue("@A91Network", Model.A91Network);
            command.Parameters.AddWithValue("@A92Network", Model.A92Network);
            command.Parameters.AddWithValue("@A3Classic", Model.A3Classic);
            command.Parameters.AddWithValue("@A4Classic", Model.A4Classic);
            command.Parameters.AddWithValue("@A6Classic", Model.A6Classic);
            command.Parameters.AddWithValue("@A19Classic", Model.A19Classic);
            command.Parameters.AddWithValue("@A20Classic", Model.A20Classic);
            command.Parameters.AddWithValue("@A21Classic", Model.A21Classic);
            command.Parameters.AddWithValue("@A23Classic", Model.A23Classic);
            command.Parameters.AddWithValue("@A27Classic", Model.A27Classic);
            command.Parameters.AddWithValue("@A28Classic", Model.A28Classic);
            command.Parameters.AddWithValue("@A35Classic", Model.A35Classic);
            command.Parameters.AddWithValue("@A41Classic", Model.A41Classic);
            command.Parameters.AddWithValue("@A42Classic", Model.A42Classic);
            command.Parameters.AddWithValue("@A53Classic", Model.A53Classic);
            command.Parameters.AddWithValue("@A57Classic", Model.A57Classic);
            command.Parameters.AddWithValue("@A58Classic", Model.A58Classic);
            command.Parameters.AddWithValue("@A59Classic", Model.A59Classic);
            command.Parameters.AddWithValue("@A65Classic", Model.A65Classic);
            command.Parameters.AddWithValue("@A68Classic", Model.A68Classic);
            command.Parameters.AddWithValue("@A70Classic", Model.A70Classic);
            command.Parameters.AddWithValue("@A72Classic", Model.A72Classic);
            command.Parameters.AddWithValue("@A73Classic", Model.A73Classic);
            command.Parameters.AddWithValue("@A74Classic", Model.A74Classic);
            command.Parameters.AddWithValue("@A75Classic", Model.A75Classic);
            command.Parameters.AddWithValue("@A77Classic", Model.A77Classic);
            command.Parameters.AddWithValue("@A78Classic", Model.A78Classic);
            command.Parameters.AddWithValue("@A82Classic", Model.A82Classic);
            command.Parameters.AddWithValue("@A84Classic", Model.A84Classic);
            command.Parameters.AddWithValue("@A91Classic", Model.A91Classic);
            command.Parameters.AddWithValue("@A94Classic", Model.A94Classic);
            command.Parameters.AddWithValue("@UstGiyimEbat", Model.UstGiyimEbat);
            command.Parameters.AddWithValue("@BMIndex", Model.BMIndex);
            command.Parameters.AddWithValue("@BKoran", Model.BKoran);
            command.Parameters.AddWithValue("@Birlik", Model.Birlik);
            command.Parameters.AddWithValue("@PantolonEbat", Model.PantolonEbat);
            command.Parameters.AddWithValue("@BotEbat", Model.BotEbat);
            command.Parameters.AddWithValue("@EldivenEbat", Model.EldivenEbat);
            command.ExecuteNonQuery();




            SqlCommand commandsayac = new SqlCommand("Update Dashboarddata Set totalsoldier=totalsoldier+@totalsoldier,karakuvvet=karakuvvet+@karakuvvet,denizkuvvet=denizkuvvet+@denizkuvvet,havakuvvet=havakuvvet+@havakuvvet,karatotalchest = karatotalchest + @karatotalchest,havatotalchest = havatotalchest + @havatotalchest,deniztotalchest = deniztotalchest + @deniztotalchest,kara_xs_chest = kara_xs_chest + @kara_xs_chest,kara_s_chest = kara_s_chest + @kara_s_chest,kara_m_chest = kara_m_chest + @kara_m_chest,kara_l_chest = kara_l_chest + @kara_l_chest,kara_xl_chest = kara_xl_chest + @kara_xl_chest,kara_2xl_chest = kara_2xl_chest + @kara_2xl_chest,hava_xs_chest = hava_xs_chest + @hava_xs_chest,hava_s_chest = hava_s_chest + @hava_s_chest,hava_m_chest = hava_m_chest + @hava_m_chest,hava_l_chest = hava_l_chest + @hava_l_chest,hava_2l_chest = hava_2l_chest + @hava_2l_chest,hava_xxl_chest = hava_xxl_chest + @hava_xxl_chest,deniz_xs_chest = deniz_xs_chest + @deniz_xs_chest,deniz_s_chest = deniz_s_chest + @deniz_s_chest,deniz_m_chest = deniz_m_chest + @deniz_m_chest,deniz_l_chest = deniz_l_chest + @deniz_l_chest,deniz_xl_chest = deniz_xl_chest + @deniz_xl_chest,deniz_2xl_chest = deniz_2xl_chest + @deniz_2xl_chest,karatotalbot = karatotalbot + @karatotalbot,havatotalbot = havatotalbot + @havatotalbot,deniztotalbot = deniztotalbot + @deniztotalbot,kara_34_bot = kara_34_bot + @kara_34_bot,kara_35_bot = kara_35_bot + @kara_35_bot,kara_36_bot = kara_36_bot + @kara_36_bot,kara_37_bot = kara_37_bot + @kara_37_bot,kara_38_bot = kara_38_bot + @kara_38_bot,kara_39_bot = kara_39_bot + @kara_39_bot,kara_40_bot = kara_40_bot + @kara_40_bot,kara_41_bot = kara_41_bot + @kara_41_bot,kara_42_bot = kara_42_bot + @kara_42_bot,kara_43_bot = kara_43_bot + @kara_43_bot,kara_44_bot = kara_44_bot + @kara_44_bot,kara_45_bot = kara_45_bot + @kara_45_bot,kara_46_bot = kara_46_bot + @kara_46_bot,kara_47_bot = kara_47_bot + @kara_47_bot,kara_48_bot = kara_48_bot + @kara_48_bot,hava_34_bot = hava_34_bot + @hava_34_bot,hava_35_bot = hava_35_bot + @hava_35_bot,hava_36_bot = hava_36_bot + @hava_36_bot,hava_37_bot = hava_37_bot + @hava_37_bot,hava_38_bot = hava_38_bot + @hava_38_bot,hava_39_bot = hava_39_bot + @hava_39_bot,hava_40_bot = hava_40_bot + @hava_40_bot,hava_41_bot = hava_41_bot + @hava_41_bot,hava_42_bot = hava_42_bot + @hava_42_bot,hava_43_bot = hava_43_bot + @hava_43_bot,hava_44_bot = hava_44_bot + @hava_44_bot,hava_45_bot = hava_45_bot + @hava_45_bot,hava_46_bot = hava_46_bot + @hava_46_bot,hava_47_bot = hava_47_bot + @hava_47_bot,hava_48_bot = hava_48_bot + @hava_48_bot,deniz_34_bot = deniz_34_bot + @deniz_34_bot,deniz_35_bot = deniz_35_bot + @deniz_35_bot,deniz_36_bot = deniz_36_bot + @deniz_36_bot,deniz_37_bot = deniz_37_bot + @deniz_37_bot,deniz_38_bot = deniz_38_bot + @deniz_38_bot,deniz_39_bot = deniz_39_bot + @deniz_39_bot,deniz_40_bot = deniz_40_bot + @deniz_40_bot,deniz_41_bot = deniz_41_bot + @deniz_41_bot,deniz_42_bot = deniz_42_bot + @deniz_42_bot,deniz_43_bot = deniz_43_bot + @deniz_43_bot,deniz_44_bot = deniz_44_bot + @deniz_44_bot,deniz_45_bot = deniz_45_bot + @deniz_45_bot,deniz_46_bot = deniz_46_bot + @deniz_46_bot,deniz_47_bot = deniz_47_bot + @deniz_47_bot,deniz_48_bot = deniz_48_bot + @deniz_48_bot,karatotalpant = karatotalpant + @karatotalpant,havatotalpant = havatotalpant + @havatotalpant,deniztotalpant = deniztotalpant + @deniztotalpant,kara_xs_pant = kara_xs_pant + @kara_xs_pant,kara_s_pant = kara_s_pant + @kara_s_pant,kara_m_pant = kara_m_pant + @kara_m_pant,kara_l_pant = kara_l_pant + @kara_l_pant,kara_xl_pant = kara_xl_pant + @kara_xl_pant,kara_2xl_pant = kara_2xl_pant + @kara_2xl_pant,kara_3xl_pant = kara_3xl_pant + @kara_3xl_pant,kara_bxl_pant = kara_bxl_pant + @kara_bxl_pant,hava_xs_pant = hava_xs_pant + @hava_xs_pant,hava_s_pant = hava_s_pant + @hava_s_pant,hava_m_pant = hava_m_pant + @hava_m_pant,hava_l_pant = hava_l_pant + @hava_l_pant,hava_xl_pant = hava_xl_pant + @hava_xl_pant,hava_2xl_pant = hava_2xl_pant + @hava_2xl_pant,hava_3xl_pant = hava_3xl_pant + @hava_3xl_pant,hava_bxl_pant = hava_bxl_pant + @hava_bxl_pant,deniz_xs_pant = deniz_xs_pant + @deniz_xs_pant,deniz_s_pant = deniz_s_pant + @deniz_s_pant,deniz_m_pant = deniz_m_pant + @deniz_m_pant,deniz_l_pant = deniz_l_pant + @deniz_l_pant,deniz_xl_pant = deniz_xl_pant + @deniz_xl_pant,deniz_2xl_pant = deniz_2xl_pant + @deniz_2xl_pant,deniz_3xl_pant = deniz_3xl_pant + @deniz_3xl_pant,deniz_bxl_pant = deniz_bxl_pant + @deniz_bxl_pant,karatotalhands = karatotalhands + @karatotalhands,havatotalhands = havatotalhands + @havatotalhands,deniztotalhands = deniztotalhands + @deniztotalhands,kara_xs_hands = kara_xs_hands + @kara_xs_hands,kara_s_hands = kara_s_hands + @kara_s_hands,kara_m_hands = kara_m_hands + @kara_m_hands,kara_l_hands = kara_l_hands + @kara_l_hands,kara_xl_hands = kara_xl_hands + @kara_xl_hands,kara_2xl_hands = kara_2xl_hands + @kara_2xl_hands,hava_xs_hands = hava_xs_hands + @hava_xs_hands,hava_s_hands = hava_s_hands + @hava_s_hands,hava_m_hands = hava_m_hands + @hava_m_hands,hava_l_hands = hava_l_hands + @hava_l_hands,hava_xl_hands = hava_xl_hands + @hava_xl_hands,hava_2xl_hands = hava_2xl_hands + @hava_2xl_hands,deniz_xs_hands = deniz_xs_hands + @deniz_xs_hands,deniz_s_hands = deniz_s_hands + @deniz_s_hands,deniz_m_hands = deniz_m_hands + @deniz_m_hands,deniz_l_hands = deniz_l_hands + @deniz_l_hands,deniz_xl_hands = deniz_xl_hands + @deniz_xl_hands,deniz_2xl_hands = deniz_2xl_hands + @deniz_2xl_hands,kara_140_150_boy = kara_140_150_boy + @kara_140_150_boy,kara_150_160_boy = kara_150_160_boy + @kara_150_160_boy,kara_160_170_boy = kara_160_170_boy + @kara_160_170_boy,kara_170_180_boy = kara_170_180_boy + @kara_170_180_boy,kara_180_190_boy = kara_180_190_boy + @kara_180_190_boy,kara_190_200_boy = kara_190_200_boy + @kara_190_200_boy,kara_200_210_boy = kara_200_210_boy + @kara_200_210_boy,kara_210_220_boy = kara_210_220_boy + @kara_210_220_boy,kara_220_230_boy = kara_220_230_boy + @kara_220_230_boy,hava_140_150_boy = hava_140_150_boy + @hava_140_150_boy,hava_150_160_boy = hava_150_160_boy + @hava_150_160_boy,hava_160_170_boy = hava_160_170_boy + @hava_160_170_boy,hava_170_180_boy = hava_170_180_boy + @hava_170_180_boy,hava_180_190_boy = hava_180_190_boy + @hava_180_190_boy,hava_190_200_boy = hava_190_200_boy + @hava_190_200_boy,hava_200_210_boy = hava_200_210_boy + @hava_200_210_boy,hava_210_220_boy = hava_210_220_boy + @hava_210_220_boy,hava_220_230_boy = hava_220_230_boy + @hava_220_230_boy,deniz_140_150_boy = deniz_140_150_boy + @deniz_140_150_boy,deniz_150_160_boy = deniz_150_160_boy + @deniz_150_160_boy,deniz_160_170_boy = deniz_160_170_boy + @deniz_160_170_boy,deniz_170_180_boy = deniz_170_180_boy + @deniz_170_180_boy,deniz_180_190_boy = deniz_180_190_boy + @deniz_180_190_boy,deniz_190_200_boy = deniz_190_200_boy + @deniz_190_200_boy,deniz_200_210_boy = deniz_200_210_boy + @deniz_200_210_boy,deniz_210_220_boy = deniz_210_220_boy + @deniz_210_220_boy,deniz_220_230_boy = deniz_220_230_boy + @deniz_220_230_boy,kara_140alti_uyluk = kara_140alti_uyluk + @kara_140alti_uyluk,kara_140_180_uyluk = kara_140_180_uyluk + @kara_140_180_uyluk,kara_180_220_uyluk = kara_180_220_uyluk + @kara_180_220_uyluk,kara_220_260_uyluk = kara_220_260_uyluk + @kara_220_260_uyluk,kara_260ustu_uyluk = kara_260ustu_uyluk + @kara_260ustu_uyluk,hava_140alti_uyluk = hava_140alti_uyluk + @hava_140alti_uyluk,hava_140_180_uyluk = hava_140_180_uyluk + @hava_140_180_uyluk,hava_180_220_uyluk = hava_180_220_uyluk + @hava_180_220_uyluk,hava_220_260_uyluk = hava_220_260_uyluk + @hava_220_260_uyluk,hava_260ustu_uyluk = hava_260ustu_uyluk + @hava_260ustu_uyluk,deniz_140alti_uyluk = deniz_140alti_uyluk + @deniz_140alti_uyluk,deniz_140_180_uyluk = deniz_140_180_uyluk + @deniz_140_180_uyluk,deniz_180_220_uyluk = deniz_180_220_uyluk + @deniz_180_220_uyluk,deniz_220_260_uyluk = deniz_220_260_uyluk + @deniz_220_260_uyluk,deniz_260ustu_uyluk = deniz_260ustu_uyluk + @deniz_260ustu_uyluk Where donem=IDENT_CURRENT('Dashboarddata')", _baglan);









            /*

             ,karatotalchest=@karatotalchest,kara_xs_chest=@kara_xs_chest,kara_s_hest=@kara_s_hest,kara_m_chest=@kara_m_chest,kara_l_chest=@kara_l_chest,kara_xl_chest=@kara_xl_chest,kara_2xl_chest=@kara_2xl_chest,hava_xs_chest=@hava_xs_chest,hava_s_chest=@hava_s_chest,hava_m_chest=@hava_m_chest,hava_l_chest=@hava_l_chest,hava_2l_chest=@hava_2l_chest,hava_xxl_chest=@hava_xxl_chest,deniz_xs_chest=@deniz_xs_chest,deniz_s_hest=@deniz_s_chest,deniz_m_chest=@deniz_m_chest,deniz_l_chest=@deniz_l_chest,deniz_xl_chest=@deniz_xl_chest,deniz_2xl_chest=@deniz_2xl_chest,Kara_34_bot=@kara_34_bot,Kara_35_bot=@kara_35_bot,kara_36_bot=@kara_36_bot,kara_37_bot=@kara_37_bot,kara_38_bot=@kara_38_bot,kara_39_bot=@kara_39_bot,kara_40_bot=@kara_40_bot,kara_41_bot=@kara_41_bot,kara_42_bot=@kara_42_bot,kara_43_bot=@kara_43_bot,kara_44_bot=@kara_44_bot,kara_45_bot=@kara_45_bot,kara_46_bot=@kara_46_bot,kara_47_bot=@kara_47_bot,kara_48_bot=@kara_48_bot,hava_34_bot=@hava_34_bot,hava_35_bot=@hava_35_bot,hava_36_bot=@hava_36_bot,hava_37_bot=@hava_37_bot,hava_38_bot=@hava_38_bot,hava_39_bot=@hava_39_bot,hava_40_bot=@hava_40_bot,hava_41_bot=@hava_41_bot,hava_42_bot=@hava_42_bot,hava_43_bot=@hava_43_bot,hava_44_bot=@hava_44_bot,hava_45_bot=@hava_45_bot,hava_46_bot=@hava_46_bot,hava_47_bot=@hava_47_bot,hava_48_bot=@hava_48_bot,deniz_34_bot=@deniz_34_bot,deniz_35_bot=@deniz_35_bot,deniz_36_bot=@deniz_36_bot,deniz_37_bot=@deniz_37_bot,deniz_38_bot=@deniz_38_bot,deniz_39_bot=@deniz_39_bot,deniz_40_bot=@deniz_40_bot,deniz_41_bot=@deniz_41_bot,deniz_42_bot=@deniz_42_bot,deniz_43_bot=@deniz_43_bot,deniz_44_bot=@deniz_44_bot,deniz_45_bot=@deniz_45_bot,deniz_46_bot=@deniz_46_bot,deniz_47_bot=@deniz_47_bot,deniz_48_bot=@deniz_48_bot,kara_s_pant=@kara_s_pant,kara_m_pant=@kara_m_pant,kara_l_pant=@kara_l_pant,kara_xl_pant=@kara_xl_pant,kara_2xl_pant=@kara_2xl_pant,kara_3xl_pant=@kara_3xl_pant,kara_bxl_pant=@kara_bxl_pant,hava_xs_pant=@hava_xs_pant,hava_s_pant=@hava_s_pant,hava_m_pant=@hava_m_pant,hava_l_pant=@hava_l_pant,hava_xl_pant=@hava_xl_pant,hava_2xl_pant=@hava_2xl_pant,hava_3xl_pant=@hava_3xl_pant,hava_bxl_pant=@hava_bxl_pant,deniz_s_pant=@deniz_s_pant,deniz_m_pant=@deniz_m_pant,deniz_l_pant=@deniz_l_pant,deniz_xl_pant=@deniz_xl_pant,deniz_2xl_pant=@deniz_2xl_pant,deniz_3xl_pant=@deniz_3xl_pant,deniz_bxl_pant=@deniz_bxl_pant,kara_xs_hands=@kara_xs_hands,kara_s_hands=@kara_s_hands,kara_m_hands=@kara_m_hands,kara_l_hands=@kara_l_hands,kara_xl_hands=@kara_xl_hands,kara_2xl_hands=@kara_2xl_hands,hava_xs_hands=@hava_xs_hands,hava_s_hands=@hava_s_hands,hava_m_hands=@hava_m_hands,hava_l_hands=@hava_l_hands,hava_xl_hands=@hava_xl_hands,hava_2xl_hands=@hava_2xl_hands,deniz_xs_hands=@deniz_xs_hands,deniz_s_hands=@deniz_s_hands,deniz_m_hands=@deniz_m_hands,deniz_l_hands=@deniz_l_hands,deniz_xl_hands=@deniz_xl_hands,deniz_2xl_hands=@deniz_2xl_hands,kara_140_150_boy=@kara_140_150_boy,kara_150_160_boy=@kara_150_160_boy,kara_160_170_boy=@kara_160_170_boy,kara_170_180_boy=@kara_170_180_boy,kara_180_190_boy=@kara_180_190_boy,kara_190_200_boy=@kara_190_200_boy,kara_200_210_boy=@kara_200_210_boy,kara_210_220_boy=@kara_210_220_boy,kara_220_230_boy=@kara_220_230_boy,hava_140_150_boy=@hava_140_150_boy,hava_150_160_boy=@hava_150_160_boy,hava_160_170_boy=@hava_160_170_boy,hava_170_180_boy=@hava_170_180_boy,hava_180_190_boy=@hava_180_190_boy,hava_190_200_boy=@hava_190_200_boy,hava_200_210_boy=@hava_200_210_boy,hava_210_220_boy=@hava_210_220_boy,hava_220_230_boy=@hava_220_230_boy,deniz_140_150_boy=@deniz_140_150_boy,deniz_150_160_boy=@deniz_150_160_boy,deniz_160_170_boy=@deniz_160_170_boy,deniz_170_180_boy=@deniz_170_180_boy,deniz_180_190_boy=@deniz_180_190_boy,deniz_190_200_boy=@deniz_190_200_boy,deniz_200_210_boy=@deniz_200_210_boy,deniz_210_220_boy=@deniz_210_220_boy,deniz_220_230_boy=@deniz_220_230_boy,kara_140alti_uyluk=@kara_140alti_uyluk,kara_140_180_uyluk=@kara_140_180_uyluk,kara_180_220_uyluk=@kara_180_220_uyluk,kara_220_260_uyluk=@kara_220_260_uyluk,kara_260ustu_uyluk=@kara_260ustu_uyluk,hava_140alti_uyluk=@hava_140alti_uyluk,hava_140_180_uyluk=@hava_140_180_uyluk,hava_180_220_uyluk=@hava_180_220_uyluk,hava_220_260_uyluk=@hava_220_260_uyluk,hava_260ustu_uyluk=@hava_260ustu_uyluk,deniz_140alti_uyluk=@deniz_140alti_uyluk,deniz_140_180_uyluk=@deniz_140_180_uyluk,deniz_180_220_uyluk=@deniz_180_220_uyluk,deniz_220_260_uyluk=@deniz_220_260_uyluk,deniz_260ustu_uyluk=@deniz_260ustu_uyluk 

             */

            commandsayac.Parameters.AddWithValue("@totalsoldier", Model.totalsoldier);
            commandsayac.Parameters.AddWithValue("@karakuvvet", Model.karakuvvet);
            commandsayac.Parameters.AddWithValue("@denizkuvvet", Model.denizkuvvet);
            commandsayac.Parameters.AddWithValue("@havakuvvet", Model.havakuvvet);
            commandsayac.Parameters.AddWithValue("@karatotalchest", Model.karatotalchest);
            commandsayac.Parameters.AddWithValue("@havatotalchest", Model.havatotalchest);
            commandsayac.Parameters.AddWithValue("@deniztotalchest", Model.deniztotalchest);
            commandsayac.Parameters.AddWithValue("@kara_xs_chest", Model.kara_xs_chest);
            commandsayac.Parameters.AddWithValue("@kara_s_chest", Model.kara_s_chest);
            commandsayac.Parameters.AddWithValue("@kara_m_chest", Model.kara_m_chest);
            commandsayac.Parameters.AddWithValue("@kara_l_chest", Model.kara_l_chest);
            commandsayac.Parameters.AddWithValue("@kara_xl_chest", Model.kara_xl_chest);
            commandsayac.Parameters.AddWithValue("@kara_2xl_chest", Model.kara_2xl_chest);
            commandsayac.Parameters.AddWithValue("@hava_xs_chest", Model.hava_xs_chest);
            commandsayac.Parameters.AddWithValue("@hava_s_chest", Model.hava_s_chest);
            commandsayac.Parameters.AddWithValue("@hava_m_chest", Model.hava_m_chest);
            commandsayac.Parameters.AddWithValue("@hava_l_chest", Model.hava_l_chest);
            commandsayac.Parameters.AddWithValue("@hava_2l_chest", Model.hava_2l_chest);
            commandsayac.Parameters.AddWithValue("@hava_xxl_chest", Model.hava_xxl_chest);
            commandsayac.Parameters.AddWithValue("@deniz_xs_chest", Model.deniz_xs_chest);
            commandsayac.Parameters.AddWithValue("@deniz_s_chest", Model.deniz_s_chest);
            commandsayac.Parameters.AddWithValue("@deniz_m_chest", Model.deniz_m_chest);
            commandsayac.Parameters.AddWithValue("@deniz_l_chest", Model.deniz_l_chest);
            commandsayac.Parameters.AddWithValue("@deniz_xl_chest", Model.deniz_xl_chest);
            commandsayac.Parameters.AddWithValue("@deniz_2xl_chest", Model.deniz_2xl_chest);
            commandsayac.Parameters.AddWithValue("@karatotalbot", Model.karatotalbot);
            commandsayac.Parameters.AddWithValue("@havatotalbot", Model.havatotalbot);
            commandsayac.Parameters.AddWithValue("@deniztotalbot", Model.deniztotalbot);
            commandsayac.Parameters.AddWithValue("@kara_34_bot", Model.kara_34_bot);
            commandsayac.Parameters.AddWithValue("@kara_35_bot", Model.kara_35_bot);
            commandsayac.Parameters.AddWithValue("@kara_36_bot", Model.kara_36_bot);
            commandsayac.Parameters.AddWithValue("@kara_37_bot", Model.kara_37_bot);
            commandsayac.Parameters.AddWithValue("@kara_38_bot", Model.kara_38_bot);
            commandsayac.Parameters.AddWithValue("@kara_39_bot", Model.kara_39_bot);
            commandsayac.Parameters.AddWithValue("@kara_40_bot", Model.kara_40_bot);
            commandsayac.Parameters.AddWithValue("@kara_41_bot", Model.kara_41_bot);
            commandsayac.Parameters.AddWithValue("@kara_42_bot", Model.kara_42_bot);
            commandsayac.Parameters.AddWithValue("@kara_43_bot", Model.kara_43_bot);
            commandsayac.Parameters.AddWithValue("@kara_44_bot", Model.kara_44_bot);
            commandsayac.Parameters.AddWithValue("@kara_45_bot", Model.kara_45_bot);
            commandsayac.Parameters.AddWithValue("@kara_46_bot", Model.kara_46_bot);
            commandsayac.Parameters.AddWithValue("@kara_47_bot", Model.kara_47_bot);
            commandsayac.Parameters.AddWithValue("@kara_48_bot", Model.kara_48_bot);
            commandsayac.Parameters.AddWithValue("@hava_34_bot", Model.hava_34_bot);
            commandsayac.Parameters.AddWithValue("@hava_35_bot", Model.hava_35_bot);
            commandsayac.Parameters.AddWithValue("@hava_36_bot", Model.hava_36_bot);
            commandsayac.Parameters.AddWithValue("@hava_37_bot", Model.hava_37_bot);
            commandsayac.Parameters.AddWithValue("@hava_38_bot", Model.hava_38_bot);
            commandsayac.Parameters.AddWithValue("@hava_39_bot", Model.hava_39_bot);
            commandsayac.Parameters.AddWithValue("@hava_40_bot", Model.hava_40_bot);
            commandsayac.Parameters.AddWithValue("@hava_41_bot", Model.hava_41_bot);
            commandsayac.Parameters.AddWithValue("@hava_42_bot", Model.hava_42_bot);
            commandsayac.Parameters.AddWithValue("@hava_43_bot", Model.hava_43_bot);
            commandsayac.Parameters.AddWithValue("@hava_44_bot", Model.hava_44_bot);
            commandsayac.Parameters.AddWithValue("@hava_45_bot", Model.hava_45_bot);
            commandsayac.Parameters.AddWithValue("@hava_46_bot", Model.hava_46_bot);
            commandsayac.Parameters.AddWithValue("@hava_47_bot", Model.hava_47_bot);
            commandsayac.Parameters.AddWithValue("@hava_48_bot", Model.hava_48_bot);
            commandsayac.Parameters.AddWithValue("@deniz_34_bot", Model.deniz_34_bot);
            commandsayac.Parameters.AddWithValue("@deniz_35_bot", Model.deniz_35_bot);
            commandsayac.Parameters.AddWithValue("@deniz_36_bot", Model.deniz_36_bot);
            commandsayac.Parameters.AddWithValue("@deniz_37_bot", Model.deniz_37_bot);
            commandsayac.Parameters.AddWithValue("@deniz_38_bot", Model.deniz_38_bot);
            commandsayac.Parameters.AddWithValue("@deniz_39_bot", Model.deniz_39_bot);
            commandsayac.Parameters.AddWithValue("@deniz_40_bot", Model.deniz_40_bot);
            commandsayac.Parameters.AddWithValue("@deniz_41_bot", Model.deniz_41_bot);
            commandsayac.Parameters.AddWithValue("@deniz_42_bot", Model.deniz_42_bot);
            commandsayac.Parameters.AddWithValue("@deniz_43_bot", Model.deniz_43_bot);
            commandsayac.Parameters.AddWithValue("@deniz_44_bot", Model.deniz_44_bot);
            commandsayac.Parameters.AddWithValue("@deniz_45_bot", Model.deniz_45_bot);
            commandsayac.Parameters.AddWithValue("@deniz_46_bot", Model.deniz_46_bot);
            commandsayac.Parameters.AddWithValue("@deniz_47_bot", Model.deniz_47_bot);
            commandsayac.Parameters.AddWithValue("@deniz_48_bot", Model.deniz_48_bot);
            commandsayac.Parameters.AddWithValue("@karatotalpant", Model.karatotalpant);
            commandsayac.Parameters.AddWithValue("@havatotalpant", Model.havatotalpant);
            commandsayac.Parameters.AddWithValue("@deniztotalpant", Model.deniztotalpant);
            commandsayac.Parameters.AddWithValue("@kara_xs_pant", Model.kara_xs_pant);
            commandsayac.Parameters.AddWithValue("@kara_s_pant", Model.kara_s_pant);
            commandsayac.Parameters.AddWithValue("@kara_m_pant", Model.kara_m_pant);
            commandsayac.Parameters.AddWithValue("@kara_l_pant", Model.kara_l_pant);
            commandsayac.Parameters.AddWithValue("@kara_xl_pant", Model.kara_xl_pant);
            commandsayac.Parameters.AddWithValue("@kara_2xl_pant", Model.kara_2xl_pant);
            commandsayac.Parameters.AddWithValue("@kara_3xl_pant", Model.kara_3xl_pant);
            commandsayac.Parameters.AddWithValue("@kara_bxl_pant", Model.kara_bxl_pant);
            commandsayac.Parameters.AddWithValue("@hava_xs_pant", Model.hava_xs_pant);
            commandsayac.Parameters.AddWithValue("@hava_s_pant", Model.hava_s_pant);
            commandsayac.Parameters.AddWithValue("@hava_m_pant", Model.hava_m_pant);
            commandsayac.Parameters.AddWithValue("@hava_l_pant", Model.hava_l_pant);
            commandsayac.Parameters.AddWithValue("@hava_xl_pant", Model.hava_xl_pant);
            commandsayac.Parameters.AddWithValue("@hava_2xl_pant", Model.hava_2xl_pant);
            commandsayac.Parameters.AddWithValue("@hava_3xl_pant", Model.hava_3xl_pant);
            commandsayac.Parameters.AddWithValue("@hava_bxl_pant", Model.hava_bxl_pant);
            commandsayac.Parameters.AddWithValue("@deniz_xs_pant", Model.deniz_xs_pant);
            commandsayac.Parameters.AddWithValue("@deniz_s_pant", Model.deniz_s_pant);
            commandsayac.Parameters.AddWithValue("@deniz_m_pant", Model.deniz_m_pant);
            commandsayac.Parameters.AddWithValue("@deniz_l_pant", Model.deniz_l_pant);
            commandsayac.Parameters.AddWithValue("@deniz_xl_pant", Model.deniz_xl_pant);
            commandsayac.Parameters.AddWithValue("@deniz_2xl_pant", Model.deniz_2xl_pant);
            commandsayac.Parameters.AddWithValue("@deniz_3xl_pant", Model.deniz_3xl_pant);
            commandsayac.Parameters.AddWithValue("@deniz_bxl_pant", Model.deniz_bxl_pant);
            commandsayac.Parameters.AddWithValue("@karatotalhands", Model.karatotalhands);
            commandsayac.Parameters.AddWithValue("@havatotalhands", Model.havatotalhands);
            commandsayac.Parameters.AddWithValue("@deniztotalhands", Model.deniztotalhands);
            commandsayac.Parameters.AddWithValue("@kara_xs_hands", Model.kara_xs_hands);
            commandsayac.Parameters.AddWithValue("@kara_s_hands", Model.kara_s_hands);
            commandsayac.Parameters.AddWithValue("@kara_m_hands", Model.kara_m_hands);
            commandsayac.Parameters.AddWithValue("@kara_l_hands", Model.kara_l_hands);
            commandsayac.Parameters.AddWithValue("@kara_xl_hands", Model.kara_xl_hands);
            commandsayac.Parameters.AddWithValue("@kara_2xl_hands", Model.kara_2xl_hands);
            commandsayac.Parameters.AddWithValue("@hava_xs_hands", Model.hava_xs_hands);
            commandsayac.Parameters.AddWithValue("@hava_s_hands", Model.hava_s_hands);
            commandsayac.Parameters.AddWithValue("@hava_m_hands", Model.hava_m_hands);
            commandsayac.Parameters.AddWithValue("@hava_l_hands", Model.hava_l_hands);
            commandsayac.Parameters.AddWithValue("@hava_xl_hands", Model.hava_xl_hands);
            commandsayac.Parameters.AddWithValue("@hava_2xl_hands", Model.hava_2xl_hands);
            commandsayac.Parameters.AddWithValue("@deniz_xs_hands", Model.deniz_xs_hands);
            commandsayac.Parameters.AddWithValue("@deniz_s_hands", Model.deniz_s_hands);
            commandsayac.Parameters.AddWithValue("@deniz_m_hands", Model.deniz_m_hands);
            commandsayac.Parameters.AddWithValue("@deniz_l_hands", Model.deniz_l_hands);
            commandsayac.Parameters.AddWithValue("@deniz_xl_hands", Model.deniz_xl_hands);
            commandsayac.Parameters.AddWithValue("@deniz_2xl_hands", Model.deniz_2xl_hands);
            commandsayac.Parameters.AddWithValue("@kara_140_150_boy", Model.kara_140_150_boy);
            commandsayac.Parameters.AddWithValue("@kara_150_160_boy", Model.kara_150_160_boy);
            commandsayac.Parameters.AddWithValue("@kara_160_170_boy", Model.kara_160_170_boy);
            commandsayac.Parameters.AddWithValue("@kara_170_180_boy", Model.kara_170_180_boy);
            commandsayac.Parameters.AddWithValue("@kara_180_190_boy", Model.kara_180_190_boy);
            commandsayac.Parameters.AddWithValue("@kara_190_200_boy", Model.kara_190_200_boy);
            commandsayac.Parameters.AddWithValue("@kara_200_210_boy", Model.kara_200_210_boy);
            commandsayac.Parameters.AddWithValue("@kara_210_220_boy", Model.kara_210_220_boy);
            commandsayac.Parameters.AddWithValue("@kara_220_230_boy", Model.kara_220_230_boy);
            commandsayac.Parameters.AddWithValue("@hava_140_150_boy", Model.hava_140_150_boy);
            commandsayac.Parameters.AddWithValue("@hava_150_160_boy", Model.hava_150_160_boy);
            commandsayac.Parameters.AddWithValue("@hava_160_170_boy", Model.hava_160_170_boy);
            commandsayac.Parameters.AddWithValue("@hava_170_180_boy", Model.hava_170_180_boy);
            commandsayac.Parameters.AddWithValue("@hava_180_190_boy", Model.hava_180_190_boy);
            commandsayac.Parameters.AddWithValue("@hava_190_200_boy", Model.hava_190_200_boy);
            commandsayac.Parameters.AddWithValue("@hava_200_210_boy", Model.hava_200_210_boy);
            commandsayac.Parameters.AddWithValue("@hava_210_220_boy", Model.hava_210_220_boy);
            commandsayac.Parameters.AddWithValue("@hava_220_230_boy", Model.hava_220_230_boy);
            commandsayac.Parameters.AddWithValue("@deniz_140_150_boy", Model.deniz_140_150_boy);
            commandsayac.Parameters.AddWithValue("@deniz_150_160_boy", Model.deniz_150_160_boy);
            commandsayac.Parameters.AddWithValue("@deniz_160_170_boy", Model.deniz_160_170_boy);
            commandsayac.Parameters.AddWithValue("@deniz_170_180_boy", Model.deniz_170_180_boy);
            commandsayac.Parameters.AddWithValue("@deniz_180_190_boy", Model.deniz_180_190_boy);
            commandsayac.Parameters.AddWithValue("@deniz_190_200_boy", Model.deniz_190_200_boy);
            commandsayac.Parameters.AddWithValue("@deniz_200_210_boy", Model.deniz_200_210_boy);
            commandsayac.Parameters.AddWithValue("@deniz_210_220_boy", Model.deniz_210_220_boy);
            commandsayac.Parameters.AddWithValue("@deniz_220_230_boy", Model.deniz_220_230_boy);
            commandsayac.Parameters.AddWithValue("@kara_140alti_uyluk", Model.kara_140alti_uyluk);
            commandsayac.Parameters.AddWithValue("@kara_140_180_uyluk", Model.kara_140_180_uyluk);
            commandsayac.Parameters.AddWithValue("@kara_180_220_uyluk", Model.kara_180_220_uyluk);
            commandsayac.Parameters.AddWithValue("@kara_220_260_uyluk", Model.kara_220_260_uyluk);
            commandsayac.Parameters.AddWithValue("@kara_260ustu_uyluk", Model.kara_260ustu_uyluk);
            commandsayac.Parameters.AddWithValue("@hava_140alti_uyluk", Model.hava_140alti_uyluk);
            commandsayac.Parameters.AddWithValue("@hava_140_180_uyluk", Model.hava_140_180_uyluk);
            commandsayac.Parameters.AddWithValue("@hava_180_220_uyluk", Model.hava_180_220_uyluk);
            commandsayac.Parameters.AddWithValue("@hava_220_260_uyluk", Model.hava_220_260_uyluk);
            commandsayac.Parameters.AddWithValue("@hava_260ustu_uyluk", Model.hava_260ustu_uyluk);
            commandsayac.Parameters.AddWithValue("@deniz_140alti_uyluk", Model.deniz_140alti_uyluk);
            commandsayac.Parameters.AddWithValue("@deniz_140_180_uyluk", Model.deniz_140_180_uyluk);
            commandsayac.Parameters.AddWithValue("@deniz_180_220_uyluk", Model.deniz_180_220_uyluk);
            commandsayac.Parameters.AddWithValue("@deniz_220_260_uyluk", Model.deniz_220_260_uyluk);
            commandsayac.Parameters.AddWithValue("@deniz_260ustu_uyluk", Model.deniz_260ustu_uyluk);





            //commandsayac.Parameters.AddWithValue("@donem");


            commandsayac.ExecuteNonQuery();








            _baglan.Close();
        }
        public void Guncelle(Measur Model)
        {
            connect();
            SqlCommand command = new SqlCommand("Update ThesesxData Set Tc=@Tc,Ad=@Ad,Soyad=@Soyad,A77=@A77,A87=@A87,A8=@A8,A2Trium=@A2Trium,A3Trium=@A3Trium,A4Trium=@A4Trium,A5Trium=@A5Trium,A6Trium=@A6Trium,A7Trium=@A7Trium,A9Trium=@A9Trium,A12Trium=@A12Trium,A13Trium=@A13Trium,A17Trium=@A17Trium,A18Trium=@A18Trium,A19Trium=@A19Trium,A20Trium=@A20Trium,A21Trium=@A21Trium,A22Trium=@A22Trium,A23Trium=@A23Trium,A25Trium=@A25Trium,A26Trium=@A26Trium,A27Trium=@A27Trium,A28Trium=@A28Trium,A29Trium=@A29Trium,A30Trium=@A30Trium,A35Trium=@A35Trium,A36Trium=@A36Trium,A37Trium=@A37Trium,A38Trium=@A38Trium,A41Trium=@A41Trium,A42Trium=@A42Trium,A43Trium=@A43Trium,A44Trium=@A44Trium,A45Trium=@A45Trium,A49Trium=@A49Trium,A51Trium=@A51Trium,A52Trium=@A52Trium,A53Trium=@A53Trium,A55Trium=@A55Trium,A56Trium=@A56Trium,A57Trium=@A57Trium,A58Trium=@A58Trium,A59Trium=@A59Trium,A61Trium=@A61Trium,A66Trium=@A66Trium,A67Trium=@A67Trium,A68Trium=@A68Trium,A70Trium=@A70Trium,A71Trium=@A71Trium,A72Trium=@A72Trium,A73Trium=@A73Trium,A74Trium=@A74Trium,A75Trium=@A75Trium,A76Trium=@A76Trium,A78Trium=@A78Trium,A79Trium=@A79Trium,A80Trium=@A80Trium,A81Trium=@A81Trium,A82Trium=@A82Trium,A84Trium=@A84Trium,A85Trium=@A85Trium,A88Trium=@A88Trium,A89Trium=@A89Trium,A91Trium=@A91Trium,A93Trium=@A93Trium,A2Network=@A2Network,A3Network=@A3Network,A4Network=@A4Network,A6Network=@A6Network,A9Network=@A9Network,A10Network=@A10Network,A12Network=@A12Network,A17Network=@A17Network,A18Network=@A18Network,A19Network=@A19Network,A20Network=@A20Network,A21Network=@A21Network,A23Network=@A23Network,A25Network=@A25Network,A26Network=@A26Network,A27Network=@A27Network,A28Network=@A28Network,A35Network=@A35Network,A37Network=@A37Network,A38Network=@A38Network,A39Network=@A39Network,A41Network=@A41Network,A42Network=@A42Network,A45Network=@A45Network,A49Network=@A49Network,A51Network=@A51Network,A52Network=@A52Network,A53Network=@A53Network,A57Network=@A57Network,A58Network=@A58Network,A59Network=@A59Network,A61Network=@A61Network,A67Network=@A67Network,A68Network=@A68Network,A69Network=@A69Network,A70Network=@A70Network,A72Network=@A72Network,A73Network=@A73Network,A74Network=@A74Network,A75Network=@A75Network,A76Network=@A76Network,A78Network=@A78Network,A79Network=@A79Network,A80Network=@A80Network,A82Network=@A82Network,A84Network=@A84Network,A85Network=@A85Network,A88Network=@A88Network,A89Network=@A89Network,A91Network=@A91Network,A92Network=@A92Network Where Id=@Id", _baglan);




            /*
             
            
                    E101=@E101,E102=@E102,E103=@E103,



             ,A3Classic=@A3Classic,A4Classic=@A4Classic,A6Classic=@A6Classic,A19Classic=@A19Classic,A20Classic=@A20Classic,A21Classic=@A21Classic,A23Classic=@A23Classic,A27Classic=@A27Classic,A28Classic=@A28Classic,A35Classic=@A35Classic,A41Classic=@A41Classic,A42Classic=@A42Classic,A53Classic=@A53Classic,A57Classic=@A57Classic,A58Classic=@A58Classic,A59Classic=@A59Classic,A65Classic=@A65Classic,A68Classic=@A68Classic,A70Classic=@A70Classic,A72Classic=@A72Classic,A73Classic=@A73Classic,A74Classic=@A74Classic,A75Classic=@A75Classic,A77Classic=@A77Classic,A78Classic=@A78Classic,A82Classic=@A82Classic,A84Classic=@A84Classic,A91Classic=@A91Classic,A94Classic=@A94Classic
             */

            //

            /*
            command.Parameters.AddWithValue("@E101",Model.E101);
            command.Parameters.AddWithValue("@E102",Model.E102);
            command.Parameters.AddWithValue("@E103",Model.E103);

            
            */
            command.Parameters.AddWithValue("@Tc", Model.Tc);
            command.Parameters.AddWithValue("@Ad", Model.Ad);
            command.Parameters.AddWithValue("@Soyad", Model.Soyad);
            command.Parameters.AddWithValue("@A77", Model.A77);
            command.Parameters.AddWithValue("@A87", Model.A87);
            command.Parameters.AddWithValue("@A8", Model.A8);
            command.Parameters.AddWithValue("@A2Trium", Model.A2Trium);
            command.Parameters.AddWithValue("@A3Trium", Model.A3Trium);
            command.Parameters.AddWithValue("@A4Trium", Model.A4Trium);
            command.Parameters.AddWithValue("@A5Trium", Model.A5Trium);
            command.Parameters.AddWithValue("@A6Trium", Model.A6Trium);
            command.Parameters.AddWithValue("@A7Trium", Model.A7Trium);
            command.Parameters.AddWithValue("@A9Trium", Model.A9Trium);
            command.Parameters.AddWithValue("@A12Trium", Model.A12Trium);
            command.Parameters.AddWithValue("@A13Trium", Model.A13Trium);
            command.Parameters.AddWithValue("@A17Trium", Model.A17Trium);
            command.Parameters.AddWithValue("@A18Trium", Model.A18Trium);
            command.Parameters.AddWithValue("@A19Trium", Model.A19Trium);
            command.Parameters.AddWithValue("@A20Trium", Model.A20Trium);
            command.Parameters.AddWithValue("@A21Trium", Model.A21Trium);
            command.Parameters.AddWithValue("@A22Trium", Model.A22Trium);
            command.Parameters.AddWithValue("@A23Trium", Model.A23Trium);
            command.Parameters.AddWithValue("@A25Trium", Model.A25Trium);
            command.Parameters.AddWithValue("@A26Trium", Model.A26Trium);
            command.Parameters.AddWithValue("@A27Trium", Model.A27Trium);
            command.Parameters.AddWithValue("@A28Trium", Model.A28Trium);
            command.Parameters.AddWithValue("@A29Trium", Model.A29Trium);
            command.Parameters.AddWithValue("@A30Trium", Model.A30Trium);
            command.Parameters.AddWithValue("@A35Trium", Model.A35Trium);
            command.Parameters.AddWithValue("@A36Trium", Model.A36Trium);
            command.Parameters.AddWithValue("@A37Trium", Model.A37Trium);
            command.Parameters.AddWithValue("@A38Trium", Model.A38Trium);
            command.Parameters.AddWithValue("@A41Trium", Model.A41Trium);
            command.Parameters.AddWithValue("@A42Trium", Model.A42Trium);
            command.Parameters.AddWithValue("@A43Trium", Model.A43Trium);
            command.Parameters.AddWithValue("@A44Trium", Model.A44Trium);
            command.Parameters.AddWithValue("@A45Trium", Model.A45Trium);
            command.Parameters.AddWithValue("@A49Trium", Model.A49Trium);
            command.Parameters.AddWithValue("@A51Trium", Model.A51Trium);
            command.Parameters.AddWithValue("@A52Trium", Model.A52Trium);
            command.Parameters.AddWithValue("@A53Trium", Model.A53Trium);
            command.Parameters.AddWithValue("@A55Trium", Model.A55Trium);
            command.Parameters.AddWithValue("@A56Trium", Model.A56Trium);
            command.Parameters.AddWithValue("@A57Trium", Model.A57Trium);
            command.Parameters.AddWithValue("@A58Trium", Model.A58Trium);
            command.Parameters.AddWithValue("@A59Trium", Model.A59Trium);
            command.Parameters.AddWithValue("@A61Trium", Model.A61Trium);
            command.Parameters.AddWithValue("@A66Trium", Model.A66Trium);
            command.Parameters.AddWithValue("@A67Trium", Model.A67Trium);
            command.Parameters.AddWithValue("@A68Trium", Model.A68Trium);
            command.Parameters.AddWithValue("@A70Trium", Model.A70Trium);
            command.Parameters.AddWithValue("@A71Trium", Model.A71Trium);
            command.Parameters.AddWithValue("@A72Trium", Model.A72Trium);
            command.Parameters.AddWithValue("@A73Trium", Model.A73Trium);
            command.Parameters.AddWithValue("@A74Trium", Model.A74Trium);
            command.Parameters.AddWithValue("@A75Trium", Model.A75Trium);
            command.Parameters.AddWithValue("@A76Trium", Model.A76Trium);
            command.Parameters.AddWithValue("@A78Trium", Model.A78Trium);
            command.Parameters.AddWithValue("@A79Trium", Model.A79Trium);
            command.Parameters.AddWithValue("@A80Trium", Model.A80Trium);
            command.Parameters.AddWithValue("@A81Trium", Model.A81Trium);
            command.Parameters.AddWithValue("@A82Trium", Model.A82Trium);
            command.Parameters.AddWithValue("@A84Trium", Model.A84Trium);
            command.Parameters.AddWithValue("@A85Trium", Model.A85Trium);
            command.Parameters.AddWithValue("@A88Trium", Model.A88Trium);
            command.Parameters.AddWithValue("@A89Trium", Model.A89Trium);
            command.Parameters.AddWithValue("@A91Trium", Model.A91Trium);
            command.Parameters.AddWithValue("@A93Trium", Model.A93Trium);
            command.Parameters.AddWithValue("@A2Network", Model.A2Network);
            command.Parameters.AddWithValue("@A3Network", Model.A3Network);
            command.Parameters.AddWithValue("@A4Network", Model.A4Network);
            command.Parameters.AddWithValue("@A6Network", Model.A6Network);
            command.Parameters.AddWithValue("@A9Network", Model.A9Network);
            command.Parameters.AddWithValue("@A10Network", Model.A10Network);
            command.Parameters.AddWithValue("@A12Network", Model.A12Network);
            command.Parameters.AddWithValue("@A17Network", Model.A17Network);
            command.Parameters.AddWithValue("@A18Network", Model.A18Network);
            command.Parameters.AddWithValue("@A19Network", Model.A19Network);
            command.Parameters.AddWithValue("@A20Network", Model.A20Network);
            command.Parameters.AddWithValue("@A21Network", Model.A21Network);
            command.Parameters.AddWithValue("@A23Network", Model.A23Network);
            command.Parameters.AddWithValue("@A25Network", Model.A25Network);
            command.Parameters.AddWithValue("@A26Network", Model.A26Network);
            command.Parameters.AddWithValue("@A27Network", Model.A27Network);
            command.Parameters.AddWithValue("@A28Network", Model.A28Network);
            command.Parameters.AddWithValue("@A35Network", Model.A35Network);
            command.Parameters.AddWithValue("@A37Network", Model.A37Network);
            command.Parameters.AddWithValue("@A38Network", Model.A38Network);
            command.Parameters.AddWithValue("@A39Network", Model.A39Network);
            command.Parameters.AddWithValue("@A41Network", Model.A41Network);
            command.Parameters.AddWithValue("@A42Network", Model.A42Network);
            command.Parameters.AddWithValue("@A45Network", Model.A45Network);
            command.Parameters.AddWithValue("@A49Network", Model.A49Network);
            command.Parameters.AddWithValue("@A51Network", Model.A51Network);
            command.Parameters.AddWithValue("@A52Network", Model.A52Network);
            command.Parameters.AddWithValue("@A53Network", Model.A53Network);
            command.Parameters.AddWithValue("@A57Network", Model.A57Network);
            command.Parameters.AddWithValue("@A58Network", Model.A58Network);
            command.Parameters.AddWithValue("@A59Network", Model.A59Network);
            command.Parameters.AddWithValue("@A61Network", Model.A61Network);
            command.Parameters.AddWithValue("@A67Network", Model.A67Network);
            command.Parameters.AddWithValue("@A68Network", Model.A68Network);
            command.Parameters.AddWithValue("@A69Network", Model.A69Network);
            command.Parameters.AddWithValue("@A70Network", Model.A70Network);
            command.Parameters.AddWithValue("@A72Network", Model.A72Network);
            command.Parameters.AddWithValue("@A73Network", Model.A73Network);
            command.Parameters.AddWithValue("@A74Network", Model.A74Network);
            command.Parameters.AddWithValue("@A75Network", Model.A75Network);
            command.Parameters.AddWithValue("@A76Network", Model.A76Network);
            command.Parameters.AddWithValue("@A78Network", Model.A78Network);
            command.Parameters.AddWithValue("@A79Network", Model.A79Network);
            command.Parameters.AddWithValue("@A80Network", Model.A80Network);
            command.Parameters.AddWithValue("@A82Network", Model.A82Network);
            command.Parameters.AddWithValue("@A84Network", Model.A84Network);
            command.Parameters.AddWithValue("@A85Network", Model.A85Network);
            command.Parameters.AddWithValue("@A88Network", Model.A88Network);
            command.Parameters.AddWithValue("@A89Network", Model.A89Network);
            command.Parameters.AddWithValue("@A91Network", Model.A91Network);
            command.Parameters.AddWithValue("@A92Network", Model.A92Network);
            //command.Parameters.AddWithValue("@UstGiyimEbat",Model.UstGiyimEbat);


            /*kapattım çünkü bunlar güncellenmiyor eğer basics bölümünde bunlarada değer girme açılırsa eklenebilir.
             * 
             * 
            command.Parameters.AddWithValue("@A3Classic",Model.A3Classic);
            command.Parameters.AddWithValue("@A4Classic",Model.A4Classic);
            command.Parameters.AddWithValue("@A6Classic",Model.A6Classic);
            command.Parameters.AddWithValue("@A19Classic",Model.A19Classic);
            command.Parameters.AddWithValue("@A20Classic",Model.A20Classic);
            command.Parameters.AddWithValue("@A21Classic",Model.A21Classic);
            command.Parameters.AddWithValue("@A23Classic",Model.A23Classic);
            command.Parameters.AddWithValue("@A27Classic",Model.A27Classic);
            command.Parameters.AddWithValue("@A28Classic",Model.A28Classic);
            command.Parameters.AddWithValue("@A35Classic",Model.A35Classic);
            command.Parameters.AddWithValue("@A41Classic",Model.A41Classic);
            command.Parameters.AddWithValue("@A42Classic",Model.A42Classic);
            command.Parameters.AddWithValue("@A53Classic",Model.A53Classic);
            command.Parameters.AddWithValue("@A57Classic",Model.A57Classic);
            command.Parameters.AddWithValue("@A58Classic",Model.A58Classic);
            command.Parameters.AddWithValue("@A59Classic",Model.A59Classic);
            command.Parameters.AddWithValue("@A65Classic",Model.A65Classic);
            command.Parameters.AddWithValue("@A68Classic",Model.A68Classic);
            command.Parameters.AddWithValue("@A70Classic",Model.A70Classic);
            command.Parameters.AddWithValue("@A72Classic",Model.A72Classic);
            command.Parameters.AddWithValue("@A73Classic",Model.A73Classic);
            command.Parameters.AddWithValue("@A74Classic",Model.A74Classic);
            command.Parameters.AddWithValue("@A75Classic",Model.A75Classic);
            command.Parameters.AddWithValue("@A77Classic",Model.A77Classic);
            command.Parameters.AddWithValue("@A78Classic",Model.A78Classic);
            command.Parameters.AddWithValue("@A82Classic",Model.A82Classic);
            command.Parameters.AddWithValue("@A84Classic",Model.A84Classic);
            command.Parameters.AddWithValue("@A91Classic",Model.A91Classic);
            command.Parameters.AddWithValue("@A94Classic",Model.A94Classic);
            */

            command.Parameters.AddWithValue("@Id", Model.Id);


            command.ExecuteNonQuery();
            _baglan.Close();


        }


        public void Sil(Measur Model)
        {
            connect();
            SqlCommand command = new SqlCommand("Delete from ThesesxData where Id=@Id", _baglan);

            command.Parameters.AddWithValue("@Id", Model.Id);




            command.ExecuteNonQuery();
            _baglan.Close();


        }




    }
}
