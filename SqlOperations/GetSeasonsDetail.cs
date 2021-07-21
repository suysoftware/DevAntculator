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
    class GetSeasonsDetail
    {

        public int donem { get; set; }//0
        public int totalsoldier { get; set; }//1
        public int karakuvvet { get; set; }//2
        public int denizkuvvet { get; set; }//3
        public int havakuvvet { get; set; }//4
        public int karatotalchest { get; set; }//5
        public int havatotalchest { get; set; }//6
        public int deniztotalchest { get; set; }//7
        public int kara_xs_chest { get; set; }//8
        public int kara_s_chest { get; set; }//9
        public int kara_m_chest { get; set; }//10
        public int kara_l_chest { get; set; }//11
        public int kara_xl_chest { get; set; }
        public int kara_2xl_chest { get; set; }//280
        public int hava_xs_chest { get; set; }
        public int hava_s_chest { get; set; }
        public int hava_m_chest { get; set; }
        public int hava_l_chest { get; set; }
        public int hava_2l_chest { get; set; }
        public int hava_xxl_chest { get; set; }
        public int deniz_xs_chest { get; set; }//20
        public int deniz_s_chest { get; set; }//21
        public int deniz_m_chest { get; set; }//22
        public int deniz_l_chest { get; set; }//23
        public int deniz_xl_chest { get; set; }//24
        public int deniz_2xl_chest { get; set; }//25
        public int karatotalbot { get; set; }//26
        public int havatotalbot { get; set; }
        public int deniztotalbot { get; set; }
        public int kara_34_bot { get; set; }
        public int kara_35_bot { get; set; }//30
        public int kara_36_bot { get; set; }//31
        public int kara_37_bot { get; set; }
        public int kara_38_bot { get; set; }//300
        public int kara_39_bot { get; set; }
        public int kara_40_bot { get; set; }
        public int kara_41_bot { get; set; }
        public int kara_42_bot { get; set; }
        public int kara_43_bot { get; set; }
        public int kara_44_bot { get; set; }
        public int kara_45_bot { get; set; }//40
        public int kara_46_bot { get; set; }//41
        public int kara_47_bot { get; set; }
        public int kara_48_bot { get; set; }
        public int hava_34_bot { get; set; }
        public int hava_35_bot { get; set; }
        public int hava_36_bot { get; set; }
        public int hava_37_bot { get; set; }
        public int hava_38_bot { get; set; }
        public int hava_39_bot { get; set; }
        public int hava_40_bot { get; set; }
        public int hava_41_bot { get; set; }//51
        public int hava_42_bot { get; set; }
        public int hava_43_bot { get; set; }
        public int hava_44_bot { get; set; }
        public int hava_45_bot { get; set; }
        public int hava_46_bot { get; set; }
        public int hava_47_bot { get; set; }
        public int hava_48_bot { get; set; }
        public int deniz_34_bot { get; set; }
        public int deniz_35_bot { get; set; }
        public int deniz_36_bot { get; set; }//61
        public int deniz_37_bot { get; set; }
        public int deniz_38_bot { get; set; }
        public int deniz_39_bot { get; set; }
        public int deniz_40_bot { get; set; }
        public int deniz_41_bot { get; set; }
        public int deniz_42_bot { get; set; }
        public int deniz_43_bot { get; set; }
        public int deniz_44_bot { get; set; }
        public int deniz_45_bot { get; set; }
        public int deniz_46_bot { get; set; }//71
        public int deniz_47_bot { get; set; }
        public int deniz_48_bot { get; set; }
        public int karatotalpant { get; set; }
        public int havatotalpant { get; set; }
        public int deniztotalpant { get; set; }
        public int kara_xs_pant { get; set; }//77
        public int kara_s_pant { get; set; }
        public int kara_m_pant { get; set; }
        public int kara_l_pant { get; set; }
        public int kara_xl_pant { get; set; }//81
        public int kara_2xl_pant { get; set; }
        public int kara_3xl_pant { get; set; }
        public int kara_bxl_pant { get; set; }
        public int hava_xs_pant { get; set; }
        public int hava_s_pant { get; set; }
        public int hava_m_pant { get; set; }
        public int hava_l_pant { get; set; }
        public int hava_xl_pant { get; set; }
        public int hava_2xl_pant { get; set; }
        public int hava_3xl_pant { get; set; }//91
        public int hava_bxl_pant { get; set; }
        public int deniz_xs_pant { get; set; }
        public int deniz_s_pant { get; set; }
        public int deniz_m_pant { get; set; }
        public int deniz_l_pant { get; set; }
        public int deniz_xl_pant { get; set; }
        public int deniz_2xl_pant { get; set; }
        public int deniz_3xl_pant { get; set; }
        public int deniz_bxl_pant { get; set; }
        public int karatotalhands { get; set; }//101
        public int havatotalhands { get; set; }
        public int deniztotalhands { get; set; }
        public int kara_xs_hands { get; set; }
        public int kara_s_hands { get; set; }
        public int kara_m_hands { get; set; }
        public int kara_l_hands { get; set; }
        public int kara_xl_hands { get; set; }
        public int kara_2xl_hands { get; set; }
        public int hava_xs_hands { get; set; }
        public int hava_s_hands { get; set; }//111
        public int hava_m_hands { get; set; }
        public int hava_l_hands { get; set; }
        public int hava_xl_hands { get; set; }
        public int hava_2xl_hands { get; set; }
        public int deniz_xs_hands { get; set; }
        public int deniz_s_hands { get; set; }
        public int deniz_m_hands { get; set; }
        public int deniz_l_hands { get; set; }
        public int deniz_xl_hands { get; set; }
        public int deniz_2xl_hands { get; set; }//121
        public int kara_140_150_boy { get; set; }//122
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


        


        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }

        public List<GetSeasonsDetail> GetSeasons()
        {
          

            connect();

            SqlCommand command = new SqlCommand("Select * From Dashboarddata order by donem DESC", _baglan);
            SqlDataReader reader = command.ExecuteReader();



            List<GetSeasonsDetail> getSeasonsDetails = new List<GetSeasonsDetail>();
            while (reader.Read())
            {
                GetSeasonsDetail getSeasonsDetail = new GetSeasonsDetail();

                getSeasonsDetail.donem = Convert.ToInt32(reader["donem"]);
                getSeasonsDetail.totalsoldier = Convert.ToInt32(reader["totalsoldier"]);
                getSeasonsDetail.karakuvvet = Convert.ToInt32(reader["karakuvvet"]);
                getSeasonsDetail.denizkuvvet = Convert.ToInt32(reader["denizkuvvet"]);
                getSeasonsDetail.havakuvvet = Convert.ToInt32(reader["havakuvvet"]);
                getSeasonsDetail.karatotalchest = Convert.ToInt32(reader["karatotalchest"]);
                getSeasonsDetail.havatotalchest = Convert.ToInt32(reader["havatotalchest"]);
                getSeasonsDetail.deniztotalchest = Convert.ToInt32(reader["deniztotalchest"]);
                getSeasonsDetail.kara_xs_chest = Convert.ToInt32(reader["kara_xs_chest"]);
                getSeasonsDetail.kara_s_chest = Convert.ToInt32(reader["kara_s_chest"]);
                getSeasonsDetail.kara_m_chest = Convert.ToInt32(reader["kara_m_chest"]);
                getSeasonsDetail.kara_l_chest = Convert.ToInt32(reader["kara_l_chest"]);
                getSeasonsDetail.kara_xl_chest = Convert.ToInt32(reader["kara_xl_chest"]);
                getSeasonsDetail.kara_2xl_chest = Convert.ToInt32(reader["kara_2xl_chest"]);
                getSeasonsDetail.hava_xs_chest = Convert.ToInt32(reader["hava_xs_chest"]);
                getSeasonsDetail.hava_s_chest = Convert.ToInt32(reader["hava_s_chest"]);
                getSeasonsDetail.hava_m_chest = Convert.ToInt32(reader["hava_m_chest"]);
                getSeasonsDetail.hava_l_chest = Convert.ToInt32(reader["hava_l_chest"]);
                getSeasonsDetail.hava_2l_chest = Convert.ToInt32(reader["hava_2l_chest"]);
                getSeasonsDetail.hava_xxl_chest = Convert.ToInt32(reader["hava_xxl_chest"]);
                getSeasonsDetail.deniz_xs_chest = Convert.ToInt32(reader["deniz_xs_chest"]);
                getSeasonsDetail.deniz_s_chest = Convert.ToInt32(reader["deniz_s_chest"]);
                getSeasonsDetail.deniz_m_chest = Convert.ToInt32(reader["deniz_m_chest"]);
                getSeasonsDetail.deniz_l_chest = Convert.ToInt32(reader["deniz_l_chest"]);
                getSeasonsDetail.deniz_xl_chest = Convert.ToInt32(reader["deniz_xl_chest"]);
                getSeasonsDetail.deniz_2xl_chest = Convert.ToInt32(reader["deniz_2xl_chest"]);
                getSeasonsDetail.karatotalbot = Convert.ToInt32(reader["karatotalbot"]);
                getSeasonsDetail.havatotalbot = Convert.ToInt32(reader["havatotalbot"]);
                getSeasonsDetail.deniztotalbot = Convert.ToInt32(reader["deniztotalbot"]);
                getSeasonsDetail.kara_34_bot = Convert.ToInt32(reader["kara_34_bot"]);
                getSeasonsDetail.kara_35_bot = Convert.ToInt32(reader["kara_35_bot"]);
                getSeasonsDetail.kara_36_bot = Convert.ToInt32(reader["kara_36_bot"]);
                getSeasonsDetail.kara_37_bot = Convert.ToInt32(reader["kara_37_bot"]);
                getSeasonsDetail.kara_38_bot = Convert.ToInt32(reader["kara_38_bot"]);
                getSeasonsDetail.kara_39_bot = Convert.ToInt32(reader["kara_39_bot"]);
                getSeasonsDetail.kara_40_bot = Convert.ToInt32(reader["kara_40_bot"]);
                getSeasonsDetail.kara_41_bot = Convert.ToInt32(reader["kara_41_bot"]);
                getSeasonsDetail.kara_42_bot = Convert.ToInt32(reader["kara_42_bot"]);
                getSeasonsDetail.kara_43_bot = Convert.ToInt32(reader["kara_43_bot"]);
                getSeasonsDetail.kara_44_bot = Convert.ToInt32(reader["kara_44_bot"]);
                getSeasonsDetail.kara_45_bot = Convert.ToInt32(reader["kara_45_bot"]);
                getSeasonsDetail.kara_46_bot = Convert.ToInt32(reader["kara_46_bot"]);
                getSeasonsDetail.kara_47_bot = Convert.ToInt32(reader["kara_47_bot"]);
                getSeasonsDetail.kara_48_bot = Convert.ToInt32(reader["kara_48_bot"]);
                getSeasonsDetail.hava_34_bot = Convert.ToInt32(reader["hava_34_bot"]);
                getSeasonsDetail.hava_35_bot = Convert.ToInt32(reader["hava_35_bot"]);
                getSeasonsDetail.hava_36_bot = Convert.ToInt32(reader["hava_36_bot"]);
                getSeasonsDetail.hava_37_bot = Convert.ToInt32(reader["hava_37_bot"]);
                getSeasonsDetail.hava_38_bot = Convert.ToInt32(reader["hava_38_bot"]);
                getSeasonsDetail.hava_39_bot = Convert.ToInt32(reader["hava_39_bot"]);
                getSeasonsDetail.hava_40_bot = Convert.ToInt32(reader["hava_40_bot"]);
                getSeasonsDetail.hava_41_bot = Convert.ToInt32(reader["hava_41_bot"]);
                getSeasonsDetail.hava_42_bot = Convert.ToInt32(reader["hava_42_bot"]);
                getSeasonsDetail.hava_43_bot = Convert.ToInt32(reader["hava_43_bot"]);
                getSeasonsDetail.hava_44_bot = Convert.ToInt32(reader["hava_44_bot"]);
                getSeasonsDetail.hava_45_bot = Convert.ToInt32(reader["hava_45_bot"]);
                getSeasonsDetail.hava_46_bot = Convert.ToInt32(reader["hava_46_bot"]);
                getSeasonsDetail.hava_47_bot = Convert.ToInt32(reader["hava_47_bot"]);
                getSeasonsDetail.hava_48_bot = Convert.ToInt32(reader["hava_48_bot"]);
                getSeasonsDetail.deniz_34_bot = Convert.ToInt32(reader["deniz_34_bot"]);
                getSeasonsDetail.deniz_35_bot = Convert.ToInt32(reader["deniz_35_bot"]);
                getSeasonsDetail.deniz_36_bot = Convert.ToInt32(reader["deniz_36_bot"]);
                getSeasonsDetail.deniz_37_bot = Convert.ToInt32(reader["deniz_37_bot"]);
                getSeasonsDetail.deniz_38_bot = Convert.ToInt32(reader["deniz_38_bot"]);
                getSeasonsDetail.deniz_39_bot = Convert.ToInt32(reader["deniz_39_bot"]);
                getSeasonsDetail.deniz_40_bot = Convert.ToInt32(reader["deniz_40_bot"]);
                getSeasonsDetail.deniz_41_bot = Convert.ToInt32(reader["deniz_41_bot"]);
                getSeasonsDetail.deniz_42_bot = Convert.ToInt32(reader["deniz_42_bot"]);
                getSeasonsDetail.deniz_43_bot = Convert.ToInt32(reader["deniz_43_bot"]);
                getSeasonsDetail.deniz_44_bot = Convert.ToInt32(reader["deniz_44_bot"]);
                getSeasonsDetail.deniz_45_bot = Convert.ToInt32(reader["deniz_45_bot"]);
                getSeasonsDetail.deniz_46_bot = Convert.ToInt32(reader["deniz_46_bot"]);
                getSeasonsDetail.deniz_47_bot = Convert.ToInt32(reader["deniz_47_bot"]);
                getSeasonsDetail.deniz_48_bot = Convert.ToInt32(reader["deniz_48_bot"]);
                getSeasonsDetail.karatotalpant = Convert.ToInt32(reader["karatotalpant"]);
                getSeasonsDetail.havatotalpant = Convert.ToInt32(reader["havatotalpant"]);
                getSeasonsDetail.deniztotalpant = Convert.ToInt32(reader["deniztotalpant"]);
                getSeasonsDetail.kara_xs_pant = Convert.ToInt32(reader["kara_xs_pant"]);
                getSeasonsDetail.kara_s_pant = Convert.ToInt32(reader["kara_s_pant"]);
                getSeasonsDetail.kara_m_pant = Convert.ToInt32(reader["kara_m_pant"]);
                getSeasonsDetail.kara_l_pant = Convert.ToInt32(reader["kara_l_pant"]);
                getSeasonsDetail.kara_xl_pant = Convert.ToInt32(reader["kara_xl_pant"]);
                getSeasonsDetail.kara_2xl_pant = Convert.ToInt32(reader["kara_2xl_pant"]);
                getSeasonsDetail.kara_3xl_pant = Convert.ToInt32(reader["kara_3xl_pant"]);
                getSeasonsDetail.kara_bxl_pant = Convert.ToInt32(reader["kara_bxl_pant"]);
                getSeasonsDetail.hava_xs_pant = Convert.ToInt32(reader["hava_xs_pant"]);
                getSeasonsDetail.hava_s_pant = Convert.ToInt32(reader["hava_s_pant"]);
                getSeasonsDetail.hava_m_pant = Convert.ToInt32(reader["hava_m_pant"]);
                getSeasonsDetail.hava_l_pant = Convert.ToInt32(reader["hava_l_pant"]);
                getSeasonsDetail.hava_xl_pant = Convert.ToInt32(reader["hava_xl_pant"]);
                getSeasonsDetail.hava_2xl_pant = Convert.ToInt32(reader["hava_2xl_pant"]);
                getSeasonsDetail.hava_3xl_pant = Convert.ToInt32(reader["hava_3xl_pant"]);
                getSeasonsDetail.hava_bxl_pant = Convert.ToInt32(reader["hava_bxl_pant"]);
                getSeasonsDetail.deniz_xs_pant = Convert.ToInt32(reader["deniz_xs_pant"]);
                getSeasonsDetail.deniz_s_pant = Convert.ToInt32(reader["deniz_s_pant"]);
                getSeasonsDetail.deniz_m_pant = Convert.ToInt32(reader["deniz_m_pant"]);
                getSeasonsDetail.deniz_l_pant = Convert.ToInt32(reader["deniz_l_pant"]);
                getSeasonsDetail.deniz_xl_pant = Convert.ToInt32(reader["deniz_xl_pant"]);
                getSeasonsDetail.deniz_2xl_pant = Convert.ToInt32(reader["deniz_2xl_pant"]);
                getSeasonsDetail.deniz_3xl_pant = Convert.ToInt32(reader["deniz_3xl_pant"]);
                getSeasonsDetail.deniz_bxl_pant = Convert.ToInt32(reader["deniz_bxl_pant"]);
                getSeasonsDetail.karatotalhands = Convert.ToInt32(reader["karatotalhands"]);
                getSeasonsDetail.havatotalhands = Convert.ToInt32(reader["havatotalhands"]);
                getSeasonsDetail.deniztotalhands = Convert.ToInt32(reader["deniztotalhands"]);
                getSeasonsDetail.kara_xs_hands = Convert.ToInt32(reader["kara_xs_hands"]);
                getSeasonsDetail.kara_s_hands = Convert.ToInt32(reader["kara_s_hands"]);
                getSeasonsDetail.kara_m_hands = Convert.ToInt32(reader["kara_m_hands"]);
                getSeasonsDetail.kara_l_hands = Convert.ToInt32(reader["kara_l_hands"]);
                getSeasonsDetail.kara_xl_hands = Convert.ToInt32(reader["kara_xl_hands"]);
                getSeasonsDetail.kara_2xl_hands = Convert.ToInt32(reader["kara_2xl_hands"]);
                getSeasonsDetail.hava_xs_hands = Convert.ToInt32(reader["hava_xs_hands"]);
                getSeasonsDetail.hava_s_hands = Convert.ToInt32(reader["hava_s_hands"]);
                getSeasonsDetail.hava_m_hands = Convert.ToInt32(reader["hava_m_hands"]);
                getSeasonsDetail.hava_l_hands = Convert.ToInt32(reader["hava_l_hands"]);
                getSeasonsDetail.hava_xl_hands = Convert.ToInt32(reader["hava_xl_hands"]);
                getSeasonsDetail.hava_2xl_hands = Convert.ToInt32(reader["hava_2xl_hands"]);
                getSeasonsDetail.deniz_xs_hands = Convert.ToInt32(reader["deniz_xs_hands"]);
                getSeasonsDetail.deniz_s_hands = Convert.ToInt32(reader["deniz_s_hands"]);
                getSeasonsDetail.deniz_m_hands = Convert.ToInt32(reader["deniz_m_hands"]);
                getSeasonsDetail.deniz_l_hands = Convert.ToInt32(reader["deniz_l_hands"]);
                getSeasonsDetail.deniz_xl_hands = Convert.ToInt32(reader["deniz_xl_hands"]);
                getSeasonsDetail.deniz_2xl_hands = Convert.ToInt32(reader["deniz_2xl_hands"]);
                getSeasonsDetail.kara_140_150_boy = Convert.ToInt32(reader["kara_140_150_boy"]);
                getSeasonsDetail.kara_150_160_boy = Convert.ToInt32(reader["kara_150_160_boy"]);
                getSeasonsDetail.kara_160_170_boy = Convert.ToInt32(reader["kara_160_170_boy"]);
                getSeasonsDetail.kara_170_180_boy = Convert.ToInt32(reader["kara_170_180_boy"]);
                getSeasonsDetail.kara_180_190_boy = Convert.ToInt32(reader["kara_180_190_boy"]);
                getSeasonsDetail.kara_190_200_boy = Convert.ToInt32(reader["kara_190_200_boy"]);
                getSeasonsDetail.kara_200_210_boy = Convert.ToInt32(reader["kara_200_210_boy"]);
                getSeasonsDetail.kara_210_220_boy = Convert.ToInt32(reader["kara_210_220_boy"]);
                getSeasonsDetail.kara_220_230_boy = Convert.ToInt32(reader["kara_220_230_boy"]);
                getSeasonsDetail.hava_140_150_boy = Convert.ToInt32(reader["hava_140_150_boy"]);
                getSeasonsDetail.hava_150_160_boy = Convert.ToInt32(reader["hava_150_160_boy"]);
                getSeasonsDetail.hava_160_170_boy = Convert.ToInt32(reader["hava_160_170_boy"]);
                getSeasonsDetail.hava_170_180_boy = Convert.ToInt32(reader["hava_170_180_boy"]);
                getSeasonsDetail.hava_180_190_boy = Convert.ToInt32(reader["hava_180_190_boy"]);
                getSeasonsDetail.hava_190_200_boy = Convert.ToInt32(reader["hava_190_200_boy"]);
                getSeasonsDetail.hava_200_210_boy = Convert.ToInt32(reader["hava_200_210_boy"]);
                getSeasonsDetail.hava_210_220_boy = Convert.ToInt32(reader["hava_210_220_boy"]);
                getSeasonsDetail.hava_220_230_boy = Convert.ToInt32(reader["hava_220_230_boy"]);
                getSeasonsDetail.deniz_140_150_boy = Convert.ToInt32(reader["deniz_140_150_boy"]);
                getSeasonsDetail.deniz_150_160_boy = Convert.ToInt32(reader["deniz_150_160_boy"]);
                getSeasonsDetail.deniz_160_170_boy = Convert.ToInt32(reader["deniz_160_170_boy"]);
                getSeasonsDetail.deniz_170_180_boy = Convert.ToInt32(reader["deniz_170_180_boy"]);
                getSeasonsDetail.deniz_180_190_boy = Convert.ToInt32(reader["deniz_180_190_boy"]);
                getSeasonsDetail.deniz_190_200_boy = Convert.ToInt32(reader["deniz_190_200_boy"]);
                getSeasonsDetail.deniz_200_210_boy = Convert.ToInt32(reader["deniz_200_210_boy"]);
                getSeasonsDetail.deniz_210_220_boy = Convert.ToInt32(reader["deniz_210_220_boy"]);
                getSeasonsDetail.deniz_220_230_boy = Convert.ToInt32(reader["deniz_220_230_boy"]);
                getSeasonsDetail.kara_140alti_uyluk = Convert.ToInt32(reader["kara_140alti_uyluk"]);
                getSeasonsDetail.kara_140_180_uyluk = Convert.ToInt32(reader["kara_140_180_uyluk"]);
                getSeasonsDetail.kara_180_220_uyluk = Convert.ToInt32(reader["kara_180_220_uyluk"]);
                getSeasonsDetail.kara_220_260_uyluk = Convert.ToInt32(reader["kara_220_260_uyluk"]);
                getSeasonsDetail.kara_260ustu_uyluk = Convert.ToInt32(reader["kara_260ustu_uyluk"]);
                getSeasonsDetail.hava_140alti_uyluk = Convert.ToInt32(reader["hava_140alti_uyluk"]);
                getSeasonsDetail.hava_140_180_uyluk = Convert.ToInt32(reader["hava_140_180_uyluk"]);
                getSeasonsDetail.hava_180_220_uyluk = Convert.ToInt32(reader["hava_180_220_uyluk"]);
                getSeasonsDetail.hava_220_260_uyluk = Convert.ToInt32(reader["hava_220_260_uyluk"]);
                getSeasonsDetail.hava_260ustu_uyluk = Convert.ToInt32(reader["hava_260ustu_uyluk"]);
                getSeasonsDetail.deniz_140alti_uyluk = Convert.ToInt32(reader["deniz_140alti_uyluk"]);
                getSeasonsDetail.deniz_140_180_uyluk = Convert.ToInt32(reader["deniz_140_180_uyluk"]);
                getSeasonsDetail.deniz_180_220_uyluk = Convert.ToInt32(reader["deniz_180_220_uyluk"]);
                getSeasonsDetail.deniz_220_260_uyluk = Convert.ToInt32(reader["deniz_220_260_uyluk"]);
                getSeasonsDetail.deniz_260ustu_uyluk = Convert.ToInt32(reader["deniz_260ustu_uyluk"]);




                getSeasonsDetails.Add(getSeasonsDetail);

            }
            reader.Close();
            _baglan.Close();
            return getSeasonsDetails;




        }







    }
}
