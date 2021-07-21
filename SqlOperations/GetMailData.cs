using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Paths;
using TezAPPV2.Entities;
using TezAPPV2.Model;
using TezAPPV2.Abstract;
using System.Data.SqlClient;
using System.Data;

namespace TezAPPV2.SqlOperations
{
    class GetMailData
    {
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





        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }


        public List<GetMailData> GetMail()
        {
            

           connect();

            SqlCommand command = new SqlCommand("Select * From Dashboarddata where donem=IDENT_CURRENT('Dashboarddata')", _baglan);
            SqlDataReader reader = command.ExecuteReader();



            List<GetMailData> getMailDatas = new List<GetMailData>();
            while (reader.Read())
            {
                GetMailData getMailData = new GetMailData();


              
                getMailData.totalsoldier = Convert.ToInt32(reader["totalsoldier"]);
                getMailData.karakuvvet = Convert.ToInt32(reader["karakuvvet"]);
                getMailData.denizkuvvet = Convert.ToInt32(reader["denizkuvvet"]);
                getMailData.havakuvvet = Convert.ToInt32(reader["havakuvvet"]);
                getMailData.karatotalchest = Convert.ToInt32(reader["karatotalchest"]);
                getMailData.havatotalchest = Convert.ToInt32(reader["havatotalchest"]);
                getMailData.deniztotalchest = Convert.ToInt32(reader["deniztotalchest"]);
                getMailData.kara_xs_chest = Convert.ToInt32(reader["kara_xs_chest"]);
                getMailData.kara_s_chest = Convert.ToInt32(reader["kara_s_chest"]);
                getMailData.kara_m_chest = Convert.ToInt32(reader["kara_m_chest"]);
                getMailData.kara_l_chest = Convert.ToInt32(reader["kara_l_chest"]);
                getMailData.kara_xl_chest = Convert.ToInt32(reader["kara_xl_chest"]);
                getMailData.kara_2xl_chest = Convert.ToInt32(reader["kara_2xl_chest"]);
                getMailData.hava_xs_chest = Convert.ToInt32(reader["hava_xs_chest"]);
                getMailData.hava_s_chest = Convert.ToInt32(reader["hava_s_chest"]);
                getMailData.hava_m_chest = Convert.ToInt32(reader["hava_m_chest"]);
                getMailData.hava_l_chest = Convert.ToInt32(reader["hava_l_chest"]);
                getMailData.hava_2l_chest = Convert.ToInt32(reader["hava_2l_chest"]);
                getMailData.hava_xxl_chest = Convert.ToInt32(reader["hava_xxl_chest"]);
                getMailData.deniz_xs_chest = Convert.ToInt32(reader["deniz_xs_chest"]);
                getMailData.deniz_s_chest = Convert.ToInt32(reader["deniz_s_chest"]);
                getMailData.deniz_m_chest = Convert.ToInt32(reader["deniz_m_chest"]);
                getMailData.deniz_l_chest = Convert.ToInt32(reader["deniz_l_chest"]);
                getMailData.deniz_xl_chest = Convert.ToInt32(reader["deniz_xl_chest"]);
                getMailData.deniz_2xl_chest = Convert.ToInt32(reader["deniz_2xl_chest"]);
                getMailData.karatotalbot = Convert.ToInt32(reader["karatotalbot"]);
                getMailData.havatotalbot = Convert.ToInt32(reader["havatotalbot"]);
                getMailData.deniztotalbot = Convert.ToInt32(reader["deniztotalbot"]);
                getMailData.kara_34_bot = Convert.ToInt32(reader["kara_34_bot"]);
                getMailData.kara_35_bot = Convert.ToInt32(reader["kara_35_bot"]);
                getMailData.kara_36_bot = Convert.ToInt32(reader["kara_36_bot"]);
                getMailData.kara_37_bot = Convert.ToInt32(reader["kara_37_bot"]);
                getMailData.kara_38_bot = Convert.ToInt32(reader["kara_38_bot"]);
                getMailData.kara_39_bot = Convert.ToInt32(reader["kara_39_bot"]);
                getMailData.kara_40_bot = Convert.ToInt32(reader["kara_40_bot"]);
                getMailData.kara_41_bot = Convert.ToInt32(reader["kara_41_bot"]);
                getMailData.kara_42_bot = Convert.ToInt32(reader["kara_42_bot"]);
                getMailData.kara_43_bot = Convert.ToInt32(reader["kara_43_bot"]);
                getMailData.kara_44_bot = Convert.ToInt32(reader["kara_44_bot"]);
                getMailData.kara_45_bot = Convert.ToInt32(reader["kara_45_bot"]);
                getMailData.kara_46_bot = Convert.ToInt32(reader["kara_46_bot"]);
                getMailData.kara_47_bot = Convert.ToInt32(reader["kara_47_bot"]);
                getMailData.kara_48_bot = Convert.ToInt32(reader["kara_48_bot"]);
                getMailData.hava_34_bot = Convert.ToInt32(reader["hava_34_bot"]);
                getMailData.hava_35_bot = Convert.ToInt32(reader["hava_35_bot"]);
                getMailData.hava_36_bot = Convert.ToInt32(reader["hava_36_bot"]);
                getMailData.hava_37_bot = Convert.ToInt32(reader["hava_37_bot"]);
                getMailData.hava_38_bot = Convert.ToInt32(reader["hava_38_bot"]);
                getMailData.hava_39_bot = Convert.ToInt32(reader["hava_39_bot"]);
                getMailData.hava_40_bot = Convert.ToInt32(reader["hava_40_bot"]);
                getMailData.hava_41_bot = Convert.ToInt32(reader["hava_41_bot"]);
                getMailData.hava_42_bot = Convert.ToInt32(reader["hava_42_bot"]);
                getMailData.hava_43_bot = Convert.ToInt32(reader["hava_43_bot"]);
                getMailData.hava_44_bot = Convert.ToInt32(reader["hava_44_bot"]);
                getMailData.hava_45_bot = Convert.ToInt32(reader["hava_45_bot"]);
                getMailData.hava_46_bot = Convert.ToInt32(reader["hava_46_bot"]);
                getMailData.hava_47_bot = Convert.ToInt32(reader["hava_47_bot"]);
                getMailData.hava_48_bot = Convert.ToInt32(reader["hava_48_bot"]);
                getMailData.deniz_34_bot = Convert.ToInt32(reader["deniz_34_bot"]);
                getMailData.deniz_35_bot = Convert.ToInt32(reader["deniz_35_bot"]);
                getMailData.deniz_36_bot = Convert.ToInt32(reader["deniz_36_bot"]);
                getMailData.deniz_37_bot = Convert.ToInt32(reader["deniz_37_bot"]);
                getMailData.deniz_38_bot = Convert.ToInt32(reader["deniz_38_bot"]);
                getMailData.deniz_39_bot = Convert.ToInt32(reader["deniz_39_bot"]);
                getMailData.deniz_40_bot = Convert.ToInt32(reader["deniz_40_bot"]);
                getMailData.deniz_41_bot = Convert.ToInt32(reader["deniz_41_bot"]);
                getMailData.deniz_42_bot = Convert.ToInt32(reader["deniz_42_bot"]);
                getMailData.deniz_43_bot = Convert.ToInt32(reader["deniz_43_bot"]);
                getMailData.deniz_44_bot = Convert.ToInt32(reader["deniz_44_bot"]);
                getMailData.deniz_45_bot = Convert.ToInt32(reader["deniz_45_bot"]);
                getMailData.deniz_46_bot = Convert.ToInt32(reader["deniz_46_bot"]);
                getMailData.deniz_47_bot = Convert.ToInt32(reader["deniz_47_bot"]);
                getMailData.deniz_48_bot = Convert.ToInt32(reader["deniz_48_bot"]);
                getMailData.karatotalpant = Convert.ToInt32(reader["karatotalpant"]);
                getMailData.havatotalpant = Convert.ToInt32(reader["havatotalpant"]);
                getMailData.deniztotalpant = Convert.ToInt32(reader["deniztotalpant"]);
                getMailData.kara_xs_pant = Convert.ToInt32(reader["kara_xs_pant"]);
                getMailData.kara_s_pant = Convert.ToInt32(reader["kara_s_pant"]);
                getMailData.kara_m_pant = Convert.ToInt32(reader["kara_m_pant"]);
                getMailData.kara_l_pant = Convert.ToInt32(reader["kara_l_pant"]);
                getMailData.kara_xl_pant = Convert.ToInt32(reader["kara_xl_pant"]);
                getMailData.kara_2xl_pant = Convert.ToInt32(reader["kara_2xl_pant"]);
                getMailData.kara_3xl_pant = Convert.ToInt32(reader["kara_3xl_pant"]);
                getMailData.kara_bxl_pant = Convert.ToInt32(reader["kara_bxl_pant"]);
                getMailData.hava_xs_pant = Convert.ToInt32(reader["hava_xs_pant"]);
                getMailData.hava_s_pant = Convert.ToInt32(reader["hava_s_pant"]);
                getMailData.hava_m_pant = Convert.ToInt32(reader["hava_m_pant"]);
                getMailData.hava_l_pant = Convert.ToInt32(reader["hava_l_pant"]);
                getMailData.hava_xl_pant = Convert.ToInt32(reader["hava_xl_pant"]);
                getMailData.hava_2xl_pant = Convert.ToInt32(reader["hava_2xl_pant"]);
                getMailData.hava_3xl_pant = Convert.ToInt32(reader["hava_3xl_pant"]);
                getMailData.hava_bxl_pant = Convert.ToInt32(reader["hava_bxl_pant"]);
                getMailData.deniz_xs_pant = Convert.ToInt32(reader["deniz_xs_pant"]);
                getMailData.deniz_s_pant = Convert.ToInt32(reader["deniz_s_pant"]);
                getMailData.deniz_m_pant = Convert.ToInt32(reader["deniz_m_pant"]);
                getMailData.deniz_l_pant = Convert.ToInt32(reader["deniz_l_pant"]);
                getMailData.deniz_xl_pant = Convert.ToInt32(reader["deniz_xl_pant"]);
                getMailData.deniz_2xl_pant = Convert.ToInt32(reader["deniz_2xl_pant"]);
                getMailData.deniz_3xl_pant = Convert.ToInt32(reader["deniz_3xl_pant"]);
                getMailData.deniz_bxl_pant = Convert.ToInt32(reader["deniz_bxl_pant"]);
                getMailData.karatotalhands = Convert.ToInt32(reader["karatotalhands"]);
                getMailData.havatotalhands = Convert.ToInt32(reader["havatotalhands"]);
                getMailData.deniztotalhands = Convert.ToInt32(reader["deniztotalhands"]);
                getMailData.kara_xs_hands = Convert.ToInt32(reader["kara_xs_hands"]);
                getMailData.kara_s_hands = Convert.ToInt32(reader["kara_s_hands"]);
                getMailData.kara_m_hands = Convert.ToInt32(reader["kara_m_hands"]);
                getMailData.kara_l_hands = Convert.ToInt32(reader["kara_l_hands"]);
                getMailData.kara_xl_hands = Convert.ToInt32(reader["kara_xl_hands"]);
                getMailData.kara_2xl_hands = Convert.ToInt32(reader["kara_2xl_hands"]);
                getMailData.hava_xs_hands = Convert.ToInt32(reader["hava_xs_hands"]);
                getMailData.hava_s_hands = Convert.ToInt32(reader["hava_s_hands"]);
                getMailData.hava_m_hands = Convert.ToInt32(reader["hava_m_hands"]);
                getMailData.hava_l_hands = Convert.ToInt32(reader["hava_l_hands"]);
                getMailData.hava_xl_hands = Convert.ToInt32(reader["hava_xl_hands"]);
                getMailData.hava_2xl_hands = Convert.ToInt32(reader["hava_2xl_hands"]);
                getMailData.deniz_xs_hands = Convert.ToInt32(reader["deniz_xs_hands"]);
                getMailData.deniz_s_hands = Convert.ToInt32(reader["deniz_s_hands"]);
                getMailData.deniz_m_hands = Convert.ToInt32(reader["deniz_m_hands"]);
                getMailData.deniz_l_hands = Convert.ToInt32(reader["deniz_l_hands"]);
                getMailData.deniz_xl_hands = Convert.ToInt32(reader["deniz_xl_hands"]);
                getMailData.deniz_2xl_hands = Convert.ToInt32(reader["deniz_2xl_hands"]);
                getMailData.kara_140_150_boy = Convert.ToInt32(reader["kara_140_150_boy"]);
                getMailData.kara_150_160_boy = Convert.ToInt32(reader["kara_150_160_boy"]);
                getMailData.kara_160_170_boy = Convert.ToInt32(reader["kara_160_170_boy"]);
                getMailData.kara_170_180_boy = Convert.ToInt32(reader["kara_170_180_boy"]);
                getMailData.kara_180_190_boy = Convert.ToInt32(reader["kara_180_190_boy"]);
                getMailData.kara_190_200_boy = Convert.ToInt32(reader["kara_190_200_boy"]);
                getMailData.kara_200_210_boy = Convert.ToInt32(reader["kara_200_210_boy"]);
                getMailData.kara_210_220_boy = Convert.ToInt32(reader["kara_210_220_boy"]);
                getMailData.kara_220_230_boy = Convert.ToInt32(reader["kara_220_230_boy"]);
                getMailData.hava_140_150_boy = Convert.ToInt32(reader["hava_140_150_boy"]);
                getMailData.hava_150_160_boy = Convert.ToInt32(reader["hava_150_160_boy"]);
                getMailData.hava_160_170_boy = Convert.ToInt32(reader["hava_160_170_boy"]);
                getMailData.hava_170_180_boy = Convert.ToInt32(reader["hava_170_180_boy"]);
                getMailData.hava_180_190_boy = Convert.ToInt32(reader["hava_180_190_boy"]);
                getMailData.hava_190_200_boy = Convert.ToInt32(reader["hava_190_200_boy"]);
                getMailData.hava_200_210_boy = Convert.ToInt32(reader["hava_200_210_boy"]);
                getMailData.hava_210_220_boy = Convert.ToInt32(reader["hava_210_220_boy"]);
                getMailData.hava_220_230_boy = Convert.ToInt32(reader["hava_220_230_boy"]);
                getMailData.deniz_140_150_boy = Convert.ToInt32(reader["deniz_140_150_boy"]);
                getMailData.deniz_150_160_boy = Convert.ToInt32(reader["deniz_150_160_boy"]);
                getMailData.deniz_160_170_boy = Convert.ToInt32(reader["deniz_160_170_boy"]);
                getMailData.deniz_170_180_boy = Convert.ToInt32(reader["deniz_170_180_boy"]);
                getMailData.deniz_180_190_boy = Convert.ToInt32(reader["deniz_180_190_boy"]);
                getMailData.deniz_190_200_boy = Convert.ToInt32(reader["deniz_190_200_boy"]);
                getMailData.deniz_200_210_boy = Convert.ToInt32(reader["deniz_200_210_boy"]);
                getMailData.deniz_210_220_boy = Convert.ToInt32(reader["deniz_210_220_boy"]);
                getMailData.deniz_220_230_boy = Convert.ToInt32(reader["deniz_220_230_boy"]);
                getMailData.kara_140alti_uyluk = Convert.ToInt32(reader["kara_140alti_uyluk"]);
                getMailData.kara_140_180_uyluk = Convert.ToInt32(reader["kara_140_180_uyluk"]);
                getMailData.kara_180_220_uyluk = Convert.ToInt32(reader["kara_180_220_uyluk"]);
                getMailData.kara_220_260_uyluk = Convert.ToInt32(reader["kara_220_260_uyluk"]);
                getMailData.kara_260ustu_uyluk = Convert.ToInt32(reader["kara_260ustu_uyluk"]);
                getMailData.hava_140alti_uyluk = Convert.ToInt32(reader["hava_140alti_uyluk"]);
                getMailData.hava_140_180_uyluk = Convert.ToInt32(reader["hava_140_180_uyluk"]);
                getMailData.hava_180_220_uyluk = Convert.ToInt32(reader["hava_180_220_uyluk"]);
                getMailData.hava_220_260_uyluk = Convert.ToInt32(reader["hava_220_260_uyluk"]);
                getMailData.hava_260ustu_uyluk = Convert.ToInt32(reader["hava_260ustu_uyluk"]);
                getMailData.deniz_140alti_uyluk = Convert.ToInt32(reader["deniz_140alti_uyluk"]);
                getMailData.deniz_140_180_uyluk = Convert.ToInt32(reader["deniz_140_180_uyluk"]);
                getMailData.deniz_180_220_uyluk = Convert.ToInt32(reader["deniz_180_220_uyluk"]);
                getMailData.deniz_220_260_uyluk = Convert.ToInt32(reader["deniz_220_260_uyluk"]);
                getMailData.deniz_260ustu_uyluk = Convert.ToInt32(reader["deniz_260ustu_uyluk"]);






                getMailDatas.Add(getMailData);

            }
            reader.Close();
            _baglan.Close();
            return getMailDatas;




        }





    }
}
