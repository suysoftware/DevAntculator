using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TezAPPV2.Model
{
    class Graphcontrol
    {

        ////public int donem { get; set; }
        ////public int totalsoldier { get; set; }
        ////public int karakuvvet { get; set; }
        ////public int denizkuvvet { get; set; }//270
        ////public int havakuvvet { get; set; }
        ////public int karatotalchest { get; set; }
        ////public int havatotalchest { get; set; }
        ////public int deniztotalchest { get; set; }
        ////public int kara_xs_chest { get; set; }
        ////public int kara_s_chest { get; set; }
        ////public int kara_m_chest { get; set; }
        ////public int kara_l_chest { get; set; }
        ////public int kara_xl_chest { get; set; }
        ////public int kara_2xl_chest { get; set; }//280
        ////public int hava_xs_chest { get; set; }
        ////public int hava_s_chest { get; set; }
        ////public int hava_m_chest { get; set; }
        ////public int hava_l_chest { get; set; }
        ////public int hava_2l_chest { get; set; }
        ////public int hava_xxl_chest { get; set; }
        ////public int deniz_xs_chest { get; set; }
        ////public int deniz_s_chest { get; set; }
        ////public int deniz_m_chest { get; set; }
        ////public int deniz_l_chest { get; set; }
        ////public int deniz_xl_chest { get; set; }
        ////public int deniz_2xl_chest { get; set; }
        ////public int karatotalbot { get; set; }
        ////public int havatotalbot { get; set; }
        ////public int deniztotalbot { get; set; }
        ////public int kara_34_bot { get; set; }
        ////public int kara_35_bot { get; set; }
        ////public int kara_36_bot { get; set; }
        ////public int kara_37_bot { get; set; }
        ////public int kara_38_bot { get; set; }//300
        ////public int kara_39_bot { get; set; }
        ////public int kara_40_bot { get; set; }
        ////public int kara_41_bot { get; set; }
        ////public int kara_42_bot { get; set; }
        ////public int kara_43_bot { get; set; }
        ////public int kara_44_bot { get; set; }
        ////public int kara_45_bot { get; set; }
        ////public int kara_46_bot { get; set; }
        ////public int kara_47_bot { get; set; }
        ////public int kara_48_bot { get; set; }
        ////public int hava_34_bot { get; set; }
        ////public int hava_35_bot { get; set; }
        ////public int hava_36_bot { get; set; }
        ////public int hava_37_bot { get; set; }
        ////public int hava_38_bot { get; set; }
        ////public int hava_39_bot { get; set; }
        ////public int hava_40_bot { get; set; }
        ////public int hava_41_bot { get; set; }
        ////public int hava_42_bot { get; set; }
        ////public int hava_43_bot { get; set; }
        ////public int hava_44_bot { get; set; }
        ////public int hava_45_bot { get; set; }
        ////public int hava_46_bot { get; set; }
        ////public int hava_47_bot { get; set; }
        ////public int hava_48_bot { get; set; }
        ////public int deniz_34_bot { get; set; }
        ////public int deniz_35_bot { get; set; }
        ////public int deniz_36_bot { get; set; }
        ////public int deniz_37_bot { get; set; }
        ////public int deniz_38_bot { get; set; }
        ////public int deniz_39_bot { get; set; }
        ////public int deniz_40_bot { get; set; }
        ////public int deniz_41_bot { get; set; }
        ////public int deniz_42_bot { get; set; }
        ////public int deniz_43_bot { get; set; }
        ////public int deniz_44_bot { get; set; }
        ////public int deniz_45_bot { get; set; }
        ////public int deniz_46_bot { get; set; }
        ////public int deniz_47_bot { get; set; }
        ////public int deniz_48_bot { get; set; }
        ////public int karatotalpant { get; set; }
        ////public int havatotalpant { get; set; }
        ////public int deniztotalpant { get; set; }
        ////public int kara_xs_pant { get; set; }
        ////public int kara_s_pant { get; set; }
        ////public int kara_m_pant { get; set; }
        ////public int kara_l_pant { get; set; }
        ////public int kara_xl_pant { get; set; }
        ////public int kara_2xl_pant { get; set; }
        ////public int kara_3xl_pant { get; set; }
        ////public int kara_bxl_pant { get; set; }
        ////public int hava_xs_pant { get; set; }
        ////public int hava_s_pant { get; set; }
        ////public int hava_m_pant { get; set; }
        ////public int hava_l_pant { get; set; }
        ////public int hava_xl_pant { get; set; }
        ////public int hava_2xl_pant { get; set; }
        ////public int hava_3xl_pant { get; set; }
        ////public int hava_bxl_pant { get; set; }
        ////public int deniz_xs_pant { get; set; }
        ////public int deniz_s_pant { get; set; }
        ////public int deniz_m_pant { get; set; }
        ////public int deniz_l_pant { get; set; }
        ////public int deniz_xl_pant { get; set; }
        ////public int deniz_2xl_pant { get; set; }
        ////public int deniz_3xl_pant { get; set; }
        ////public int deniz_bxl_pant { get; set; }
        ////public int karatotalhands { get; set; }
        ////public int havatotalhands { get; set; }
        ////public int deniztotalhands { get; set; }
        ////public int kara_xs_hands { get; set; }
        ////public int kara_s_hands { get; set; }
        ////public int kara_m_hands { get; set; }
        ////public int kara_l_hands { get; set; }
        ////public int kara_xl_hands { get; set; }
        ////public int kara_2xl_hands { get; set; }
        ////public int hava_xs_hands { get; set; }
        ////public int hava_s_hands { get; set; }
        ////public int hava_m_hands { get; set; }
        ////public int hava_l_hands { get; set; }
        ////public int hava_xl_hands { get; set; }
        ////public int hava_2xl_hands { get; set; }
        ////public int deniz_xs_hands { get; set; }
        ////public int deniz_s_hands { get; set; }
        ////public int deniz_m_hands { get; set; }
        ////public int deniz_l_hands { get; set; }
        ////public int deniz_xl_hands { get; set; }
        ////public int deniz_2xl_hands { get; set; }
        ////public int kara_140_150_boy { get; set; }
        ////public int kara_150_160_boy { get; set; }
        ////public int kara_160_170_boy { get; set; }
        ////public int kara_170_180_boy { get; set; }
        ////public int kara_180_190_boy { get; set; }
        ////public int kara_190_200_boy { get; set; }
        ////public int kara_200_210_boy { get; set; }
        ////public int kara_210_220_boy { get; set; }
        ////public int kara_220_230_boy { get; set; }
        ////public int hava_140_150_boy { get; set; }
        ////public int hava_150_160_boy { get; set; }
        ////public int hava_160_170_boy { get; set; }
        ////public int hava_170_180_boy { get; set; }
        ////public int hava_180_190_boy { get; set; }
        ////public int hava_190_200_boy { get; set; }
        ////public int hava_200_210_boy { get; set; }
        ////public int hava_210_220_boy { get; set; }
        ////public int hava_220_230_boy { get; set; }
        ////public int deniz_140_150_boy { get; set; }
        ////public int deniz_150_160_boy { get; set; }
        ////public int deniz_160_170_boy { get; set; }
        ////public int deniz_170_180_boy { get; set; }
        ////public int deniz_180_190_boy { get; set; }
        ////public int deniz_190_200_boy { get; set; }
        ////public int deniz_200_210_boy { get; set; }
        ////public int deniz_210_220_boy { get; set; }
        ////public int deniz_220_230_boy { get; set; }
        ////public int kara_140alti_uyluk { get; set; }
        ////public int kara_140_180_uyluk { get; set; }
        ////public int kara_180_220_uyluk { get; set; }
        ////public int kara_220_260_uyluk { get; set; }
        ////public int kara_260ustu_uyluk { get; set; }
        ////public int hava_140alti_uyluk { get; set; }
        ////public int hava_140_180_uyluk { get; set; }
        ////public int hava_180_220_uyluk { get; set; }
        ////public int hava_220_260_uyluk { get; set; }
        ////public int hava_260ustu_uyluk { get; set; }
        ////public int deniz_140alti_uyluk { get; set; }
        ////public int deniz_140_180_uyluk { get; set; }//427
        ////public int deniz_180_220_uyluk { get; set; }
        ////public int deniz_220_260_uyluk { get; set; }
        ////public int deniz_260ustu_uyluk { get; set; }

        ////private SqlConnection _baglan = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = THESESX; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        ////public void connect()
        ////{
        ////    if (_baglan.State == ConnectionState.Closed)
        ////    {
        ////        _baglan.Open();
        ////    }
        ////}


        ////public List<Graphcontrol> GetDonemlerdetay()
        ////{
        ////    connect();
        ////    SqlCommand command = new SqlCommand("Select * From Dashboarddata order by donem DESC", _baglan);
        ////    SqlDataReader reader = command.ExecuteReader();

        ////    List<Graphcontrol> graphcontrols = new List<Graphcontrol>();
        ////    while (reader.Read())
        ////    {
        ////        Graphcontrol graphcontrol = new Graphcontrol();


        ////        graphcontrol.donem = Convert.ToInt32(reader["donem"]);
        ////        graphcontrol.totalsoldier = Convert.ToInt32(reader["totalsoldier"]);
        ////        graphcontrol.karakuvvet = Convert.ToInt32(reader["karakuvvet"]);
        ////        graphcontrol.denizkuvvet = Convert.ToInt32(reader["denizkuvvet"]);
        ////        graphcontrol.havakuvvet = Convert.ToInt32(reader["havakuvvet"]);
        ////        graphcontrol.karatotalchest = Convert.ToInt32(reader["karatotalchest"]);
        ////        graphcontrol.havatotalchest = Convert.ToInt32(reader["havatotalchest"]);
        ////        graphcontrol.deniztotalchest = Convert.ToInt32(reader["deniztotalchest"]);
        ////        graphcontrol.kara_xs_chest = Convert.ToInt32(reader["kara_xs_chest"]);
        ////        graphcontrol.kara_s_chest = Convert.ToInt32(reader["kara_s_chest"]);
        ////        graphcontrol.kara_m_chest = Convert.ToInt32(reader["kara_m_chest"]);
        ////        graphcontrol.kara_l_chest = Convert.ToInt32(reader["kara_l_chest"]);
        ////        graphcontrol.kara_xl_chest = Convert.ToInt32(reader["kara_xl_chest"]);
        ////        graphcontrol.kara_2xl_chest = Convert.ToInt32(reader["kara_2xl_chest"]);
        ////        graphcontrol.hava_xs_chest = Convert.ToInt32(reader["hava_xs_chest"]);
        ////        graphcontrol.hava_s_chest = Convert.ToInt32(reader["hava_s_chest"]);
        ////        graphcontrol.hava_m_chest = Convert.ToInt32(reader["hava_m_chest"]);
        ////        graphcontrol.hava_l_chest = Convert.ToInt32(reader["hava_l_chest"]);
        ////        graphcontrol.hava_2l_chest = Convert.ToInt32(reader["hava_2l_chest"]);
        ////        graphcontrol.hava_xxl_chest = Convert.ToInt32(reader["hava_xxl_chest"]);
        ////        graphcontrol.deniz_xs_chest = Convert.ToInt32(reader["deniz_xs_chest"]);
        ////        graphcontrol.deniz_s_chest = Convert.ToInt32(reader["deniz_s_chest"]);
        ////        graphcontrol.deniz_m_chest = Convert.ToInt32(reader["deniz_m_chest"]);
        ////        graphcontrol.deniz_l_chest = Convert.ToInt32(reader["deniz_l_chest"]);
        ////        graphcontrol.deniz_xl_chest = Convert.ToInt32(reader["deniz_xl_chest"]);
        ////        graphcontrol.deniz_2xl_chest = Convert.ToInt32(reader["deniz_2xl_chest"]);
        ////        graphcontrol.karatotalbot = Convert.ToInt32(reader["karatotalbot"]);
        ////        graphcontrol.havatotalbot = Convert.ToInt32(reader["havatotalbot"]);
        ////        graphcontrol.deniztotalbot = Convert.ToInt32(reader["deniztotalbot"]);
        ////        graphcontrol.kara_34_bot = Convert.ToInt32(reader["kara_34_bot"]);
        ////        graphcontrol.kara_35_bot = Convert.ToInt32(reader["kara_35_bot"]);
        ////        graphcontrol.kara_36_bot = Convert.ToInt32(reader["kara_36_bot"]);
        ////        graphcontrol.kara_37_bot = Convert.ToInt32(reader["kara_37_bot"]);
        ////        graphcontrol.kara_38_bot = Convert.ToInt32(reader["kara_38_bot"]);
        ////        graphcontrol.kara_39_bot = Convert.ToInt32(reader["kara_39_bot"]);
        ////        graphcontrol.kara_40_bot = Convert.ToInt32(reader["kara_40_bot"]);
        ////        graphcontrol.kara_41_bot = Convert.ToInt32(reader["kara_41_bot"]);
        ////        graphcontrol.kara_42_bot = Convert.ToInt32(reader["kara_42_bot"]);
        ////        graphcontrol.kara_43_bot = Convert.ToInt32(reader["kara_43_bot"]);
        ////        graphcontrol.kara_44_bot = Convert.ToInt32(reader["kara_44_bot"]);
        ////        graphcontrol.kara_45_bot = Convert.ToInt32(reader["kara_45_bot"]);
        ////        graphcontrol.kara_46_bot = Convert.ToInt32(reader["kara_46_bot"]);
        ////        graphcontrol.kara_47_bot = Convert.ToInt32(reader["kara_47_bot"]);
        ////        graphcontrol.kara_48_bot = Convert.ToInt32(reader["kara_48_bot"]);
        ////        graphcontrol.hava_34_bot = Convert.ToInt32(reader["hava_34_bot"]);
        ////        graphcontrol.hava_35_bot = Convert.ToInt32(reader["hava_35_bot"]);
        ////        graphcontrol.hava_36_bot = Convert.ToInt32(reader["hava_36_bot"]);
        ////        graphcontrol.hava_37_bot = Convert.ToInt32(reader["hava_37_bot"]);
        ////        graphcontrol.hava_38_bot = Convert.ToInt32(reader["hava_38_bot"]);
        ////        graphcontrol.hava_39_bot = Convert.ToInt32(reader["hava_39_bot"]);
        ////        graphcontrol.hava_40_bot = Convert.ToInt32(reader["hava_40_bot"]);
        ////        graphcontrol.hava_41_bot = Convert.ToInt32(reader["hava_41_bot"]);
        ////        graphcontrol.hava_42_bot = Convert.ToInt32(reader["hava_42_bot"]);
        ////        graphcontrol.hava_43_bot = Convert.ToInt32(reader["hava_43_bot"]);
        ////        graphcontrol.hava_44_bot = Convert.ToInt32(reader["hava_44_bot"]);
        ////        graphcontrol.hava_45_bot = Convert.ToInt32(reader["hava_45_bot"]);
        ////        graphcontrol.hava_46_bot = Convert.ToInt32(reader["hava_46_bot"]);
        ////        graphcontrol.hava_47_bot = Convert.ToInt32(reader["hava_47_bot"]);
        ////        graphcontrol.hava_48_bot = Convert.ToInt32(reader["hava_48_bot"]);
        ////        graphcontrol.deniz_34_bot = Convert.ToInt32(reader["deniz_34_bot"]);
        ////        graphcontrol.deniz_35_bot = Convert.ToInt32(reader["deniz_35_bot"]);
        ////        graphcontrol.deniz_36_bot = Convert.ToInt32(reader["deniz_36_bot"]);
        ////        graphcontrol.deniz_37_bot = Convert.ToInt32(reader["deniz_37_bot"]);
        ////        graphcontrol.deniz_38_bot = Convert.ToInt32(reader["deniz_38_bot"]);
        ////        graphcontrol.deniz_39_bot = Convert.ToInt32(reader["deniz_39_bot"]);
        ////        graphcontrol.deniz_40_bot = Convert.ToInt32(reader["deniz_40_bot"]);
        ////        graphcontrol.deniz_41_bot = Convert.ToInt32(reader["deniz_41_bot"]);
        ////        graphcontrol.deniz_42_bot = Convert.ToInt32(reader["deniz_42_bot"]);
        ////        graphcontrol.deniz_43_bot = Convert.ToInt32(reader["deniz_43_bot"]);
        ////        graphcontrol.deniz_44_bot = Convert.ToInt32(reader["deniz_44_bot"]);
        ////        graphcontrol.deniz_45_bot = Convert.ToInt32(reader["deniz_45_bot"]);
        ////        graphcontrol.deniz_46_bot = Convert.ToInt32(reader["deniz_46_bot"]);
        ////        graphcontrol.deniz_47_bot = Convert.ToInt32(reader["deniz_47_bot"]);
        ////        graphcontrol.deniz_48_bot = Convert.ToInt32(reader["deniz_48_bot"]);
        ////        graphcontrol.karatotalpant = Convert.ToInt32(reader["karatotalpant"]);
        ////        graphcontrol.havatotalpant = Convert.ToInt32(reader["havatotalpant"]);
        ////        graphcontrol.deniztotalpant = Convert.ToInt32(reader["deniztotalpant"]);
        ////        graphcontrol.kara_xs_pant = Convert.ToInt32(reader["kara_xs_pant"]);
        ////        graphcontrol.kara_s_pant = Convert.ToInt32(reader["kara_s_pant"]);
        ////        graphcontrol.kara_m_pant = Convert.ToInt32(reader["kara_m_pant"]);
        ////        graphcontrol.kara_l_pant = Convert.ToInt32(reader["kara_l_pant"]);
        ////        graphcontrol.kara_xl_pant = Convert.ToInt32(reader["kara_xl_pant"]);
        ////        graphcontrol.kara_2xl_pant = Convert.ToInt32(reader["kara_2xl_pant"]);
        ////        graphcontrol.kara_3xl_pant = Convert.ToInt32(reader["kara_3xl_pant"]);
        ////        graphcontrol.kara_bxl_pant = Convert.ToInt32(reader["kara_bxl_pant"]);
        ////        graphcontrol.hava_xs_pant = Convert.ToInt32(reader["hava_xs_pant"]);
        ////        graphcontrol.hava_s_pant = Convert.ToInt32(reader["hava_s_pant"]);
        ////        graphcontrol.hava_m_pant = Convert.ToInt32(reader["hava_m_pant"]);
        ////        graphcontrol.hava_l_pant = Convert.ToInt32(reader["hava_l_pant"]);
        ////        graphcontrol.hava_xl_pant = Convert.ToInt32(reader["hava_xl_pant"]);
        ////        graphcontrol.hava_2xl_pant = Convert.ToInt32(reader["hava_2xl_pant"]);
        ////        graphcontrol.hava_3xl_pant = Convert.ToInt32(reader["hava_3xl_pant"]);
        ////        graphcontrol.hava_bxl_pant = Convert.ToInt32(reader["hava_bxl_pant"]);
        ////        graphcontrol.deniz_xs_pant = Convert.ToInt32(reader["deniz_xs_pant"]);
        ////        graphcontrol.deniz_s_pant = Convert.ToInt32(reader["deniz_s_pant"]);
        ////        graphcontrol.deniz_m_pant = Convert.ToInt32(reader["deniz_m_pant"]);
        ////        graphcontrol.deniz_l_pant = Convert.ToInt32(reader["deniz_l_pant"]);
        ////        graphcontrol.deniz_xl_pant = Convert.ToInt32(reader["deniz_xl_pant"]);
        ////        graphcontrol.deniz_2xl_pant = Convert.ToInt32(reader["deniz_2xl_pant"]);
        ////        graphcontrol.deniz_3xl_pant = Convert.ToInt32(reader["deniz_3xl_pant"]);
        ////        graphcontrol.deniz_bxl_pant = Convert.ToInt32(reader["deniz_bxl_pant"]);
        ////        graphcontrol.karatotalhands = Convert.ToInt32(reader["karatotalhands"]);
        ////        graphcontrol.havatotalhands = Convert.ToInt32(reader["havatotalhands"]);
        ////        graphcontrol.deniztotalhands = Convert.ToInt32(reader["deniztotalhands"]);
        ////        graphcontrol.kara_xs_hands = Convert.ToInt32(reader["kara_xs_hands"]);
        ////        graphcontrol.kara_s_hands = Convert.ToInt32(reader["kara_s_hands"]);
        ////        graphcontrol.kara_m_hands = Convert.ToInt32(reader["kara_m_hands"]);
        ////        graphcontrol.kara_l_hands = Convert.ToInt32(reader["kara_l_hands"]);
        ////        graphcontrol.kara_xl_hands = Convert.ToInt32(reader["kara_xl_hands"]);
        ////        graphcontrol.kara_2xl_hands = Convert.ToInt32(reader["kara_2xl_hands"]);
        ////        graphcontrol.hava_xs_hands = Convert.ToInt32(reader["hava_xs_hands"]);
        ////        graphcontrol.hava_s_hands = Convert.ToInt32(reader["hava_s_hands"]);
        ////        graphcontrol.hava_m_hands = Convert.ToInt32(reader["hava_m_hands"]);
        ////        graphcontrol.hava_l_hands = Convert.ToInt32(reader["hava_l_hands"]);
        ////        graphcontrol.hava_xl_hands = Convert.ToInt32(reader["hava_xl_hands"]);
        ////        graphcontrol.hava_2xl_hands = Convert.ToInt32(reader["hava_2xl_hands"]);
        ////        graphcontrol.deniz_xs_hands = Convert.ToInt32(reader["deniz_xs_hands"]);
        ////        graphcontrol.deniz_s_hands = Convert.ToInt32(reader["deniz_s_hands"]);
        ////        graphcontrol.deniz_m_hands = Convert.ToInt32(reader["deniz_m_hands"]);
        ////        graphcontrol.deniz_l_hands = Convert.ToInt32(reader["deniz_l_hands"]);
        ////        graphcontrol.deniz_xl_hands = Convert.ToInt32(reader["deniz_xl_hands"]);
        ////        graphcontrol.deniz_2xl_hands = Convert.ToInt32(reader["deniz_2xl_hands"]);
        ////        graphcontrol.kara_140_150_boy = Convert.ToInt32(reader["kara_140_150_boy"]);
        ////        graphcontrol.kara_150_160_boy = Convert.ToInt32(reader["kara_150_160_boy"]);
        ////        graphcontrol.kara_160_170_boy = Convert.ToInt32(reader["kara_160_170_boy"]);
        ////        graphcontrol.kara_170_180_boy = Convert.ToInt32(reader["kara_170_180_boy"]);
        ////        graphcontrol.kara_180_190_boy = Convert.ToInt32(reader["kara_180_190_boy"]);
        ////        graphcontrol.kara_190_200_boy = Convert.ToInt32(reader["kara_190_200_boy"]);
        ////        graphcontrol.kara_200_210_boy = Convert.ToInt32(reader["kara_200_210_boy"]);
        ////        graphcontrol.kara_210_220_boy = Convert.ToInt32(reader["kara_210_220_boy"]);
        ////        graphcontrol.kara_220_230_boy = Convert.ToInt32(reader["kara_220_230_boy"]);
        ////        graphcontrol.hava_140_150_boy = Convert.ToInt32(reader["hava_140_150_boy"]);
        ////        graphcontrol.hava_150_160_boy = Convert.ToInt32(reader["hava_150_160_boy"]);
        ////        graphcontrol.hava_160_170_boy = Convert.ToInt32(reader["hava_160_170_boy"]);
        ////        graphcontrol.hava_170_180_boy = Convert.ToInt32(reader["hava_170_180_boy"]);
        ////        graphcontrol.hava_180_190_boy = Convert.ToInt32(reader["hava_180_190_boy"]);
        ////        graphcontrol.hava_190_200_boy = Convert.ToInt32(reader["hava_190_200_boy"]);
        ////        graphcontrol.hava_200_210_boy = Convert.ToInt32(reader["hava_200_210_boy"]);
        ////        graphcontrol.hava_210_220_boy = Convert.ToInt32(reader["hava_210_220_boy"]);
        ////        graphcontrol.hava_220_230_boy = Convert.ToInt32(reader["hava_220_230_boy"]);
        ////        graphcontrol.deniz_140_150_boy = Convert.ToInt32(reader["deniz_140_150_boy"]);
        ////        graphcontrol.deniz_150_160_boy = Convert.ToInt32(reader["deniz_150_160_boy"]);
        ////        graphcontrol.deniz_160_170_boy = Convert.ToInt32(reader["deniz_160_170_boy"]);
        ////        graphcontrol.deniz_170_180_boy = Convert.ToInt32(reader["deniz_170_180_boy"]);
        ////        graphcontrol.deniz_180_190_boy = Convert.ToInt32(reader["deniz_180_190_boy"]);
        ////        graphcontrol.deniz_190_200_boy = Convert.ToInt32(reader["deniz_190_200_boy"]);
        ////        graphcontrol.deniz_200_210_boy = Convert.ToInt32(reader["deniz_200_210_boy"]);
        ////        graphcontrol.deniz_210_220_boy = Convert.ToInt32(reader["deniz_210_220_boy"]);
        ////        graphcontrol.deniz_220_230_boy = Convert.ToInt32(reader["deniz_220_230_boy"]);
        ////        graphcontrol.kara_140alti_uyluk = Convert.ToInt32(reader["kara_140alti_uyluk"]);
        ////        graphcontrol.kara_140_180_uyluk = Convert.ToInt32(reader["kara_140_180_uyluk"]);
        ////        graphcontrol.kara_180_220_uyluk = Convert.ToInt32(reader["kara_180_220_uyluk"]);
        ////        graphcontrol.kara_220_260_uyluk = Convert.ToInt32(reader["kara_220_260_uyluk"]);
        ////        graphcontrol.kara_260ustu_uyluk = Convert.ToInt32(reader["kara_260ustu_uyluk"]);
        ////        graphcontrol.hava_140alti_uyluk = Convert.ToInt32(reader["hava_140alti_uyluk"]);
        ////        graphcontrol.hava_140_180_uyluk = Convert.ToInt32(reader["hava_140_180_uyluk"]);
        ////        graphcontrol.hava_180_220_uyluk = Convert.ToInt32(reader["hava_180_220_uyluk"]);
        ////        graphcontrol.hava_220_260_uyluk = Convert.ToInt32(reader["hava_220_260_uyluk"]);
        ////        graphcontrol.hava_260ustu_uyluk = Convert.ToInt32(reader["hava_260ustu_uyluk"]);
        ////        graphcontrol.deniz_140alti_uyluk = Convert.ToInt32(reader["deniz_140alti_uyluk"]);
        ////        graphcontrol.deniz_140_180_uyluk = Convert.ToInt32(reader["deniz_140_180_uyluk"]);
        ////        graphcontrol.deniz_180_220_uyluk = Convert.ToInt32(reader["deniz_180_220_uyluk"]);
        ////        graphcontrol.deniz_220_260_uyluk = Convert.ToInt32(reader["deniz_220_260_uyluk"]);
        ////        graphcontrol.deniz_260ustu_uyluk = Convert.ToInt32(reader["deniz_260ustu_uyluk"]);















        ////        graphcontrols.Add(graphcontrol);

        ////    }
        ////    reader.Close();
        ////    _baglan.Close();
        ////    return graphcontrols;



        ////}

        //public List<Graphcontrol> GetMail()
        //{
        //    connect();
        //    SqlCommand command = new SqlCommand("Select * From Dashboarddata where donem=IDENT_CURRENT('Dashboarddata')", _baglan);
        //    SqlDataReader reader = command.ExecuteReader();

        //    List<Graphcontrol> graphconrols = new List<Graphcontrol>();
        //    while (reader.Read())
        //    {
        //        Graphcontrol graphcontrol = new Graphcontrol();



        //        graphcontrol.totalsoldier = Convert.ToInt32(reader["totalsoldier"]);
        //        graphcontrol.karakuvvet = Convert.ToInt32(reader["karakuvvet"]);
        //        graphcontrol.denizkuvvet = Convert.ToInt32(reader["denizkuvvet"]);
        //        graphcontrol.havakuvvet = Convert.ToInt32(reader["havakuvvet"]);
        //        graphcontrol.karatotalchest = Convert.ToInt32(reader["karatotalchest"]);
        //        graphcontrol.havatotalchest = Convert.ToInt32(reader["havatotalchest"]);
        //        graphcontrol.deniztotalchest = Convert.ToInt32(reader["deniztotalchest"]);
        //        graphcontrol.kara_xs_chest = Convert.ToInt32(reader["kara_xs_chest"]);
        //        graphcontrol.kara_s_chest = Convert.ToInt32(reader["kara_s_chest"]);
        //        graphcontrol.kara_m_chest = Convert.ToInt32(reader["kara_m_chest"]);
        //        graphcontrol.kara_l_chest = Convert.ToInt32(reader["kara_l_chest"]);
        //        graphcontrol.kara_xl_chest = Convert.ToInt32(reader["kara_xl_chest"]);
        //        graphcontrol.kara_2xl_chest = Convert.ToInt32(reader["kara_2xl_chest"]);
        //        graphcontrol.hava_xs_chest = Convert.ToInt32(reader["hava_xs_chest"]);
        //        graphcontrol.hava_s_chest = Convert.ToInt32(reader["hava_s_chest"]);
        //        graphcontrol.hava_m_chest = Convert.ToInt32(reader["hava_m_chest"]);
        //        graphcontrol.hava_l_chest = Convert.ToInt32(reader["hava_l_chest"]);
        //        graphcontrol.hava_2l_chest = Convert.ToInt32(reader["hava_2l_chest"]);
        //        graphcontrol.hava_xxl_chest = Convert.ToInt32(reader["hava_xxl_chest"]);
        //        graphcontrol.deniz_xs_chest = Convert.ToInt32(reader["deniz_xs_chest"]);
        //        graphcontrol.deniz_s_chest = Convert.ToInt32(reader["deniz_s_chest"]);
        //        graphcontrol.deniz_m_chest = Convert.ToInt32(reader["deniz_m_chest"]);
        //        graphcontrol.deniz_l_chest = Convert.ToInt32(reader["deniz_l_chest"]);
        //        graphcontrol.deniz_xl_chest = Convert.ToInt32(reader["deniz_xl_chest"]);
        //        graphcontrol.deniz_2xl_chest = Convert.ToInt32(reader["deniz_2xl_chest"]);
        //        graphcontrol.karatotalbot = Convert.ToInt32(reader["karatotalbot"]);
        //        graphcontrol.havatotalbot = Convert.ToInt32(reader["havatotalbot"]);
        //        graphcontrol.deniztotalbot = Convert.ToInt32(reader["deniztotalbot"]);
        //        graphcontrol.kara_34_bot = Convert.ToInt32(reader["kara_34_bot"]);
        //        graphcontrol.kara_35_bot = Convert.ToInt32(reader["kara_35_bot"]);
        //        graphcontrol.kara_36_bot = Convert.ToInt32(reader["kara_36_bot"]);
        //        graphcontrol.kara_37_bot = Convert.ToInt32(reader["kara_37_bot"]);
        //        graphcontrol.kara_38_bot = Convert.ToInt32(reader["kara_38_bot"]);
        //        graphcontrol.kara_39_bot = Convert.ToInt32(reader["kara_39_bot"]);
        //        graphcontrol.kara_40_bot = Convert.ToInt32(reader["kara_40_bot"]);
        //        graphcontrol.kara_41_bot = Convert.ToInt32(reader["kara_41_bot"]);
        //        graphcontrol.kara_42_bot = Convert.ToInt32(reader["kara_42_bot"]);
        //        graphcontrol.kara_43_bot = Convert.ToInt32(reader["kara_43_bot"]);
        //        graphcontrol.kara_44_bot = Convert.ToInt32(reader["kara_44_bot"]);
        //        graphcontrol.kara_45_bot = Convert.ToInt32(reader["kara_45_bot"]);
        //        graphcontrol.kara_46_bot = Convert.ToInt32(reader["kara_46_bot"]);
        //        graphcontrol.kara_47_bot = Convert.ToInt32(reader["kara_47_bot"]);
        //        graphcontrol.kara_48_bot = Convert.ToInt32(reader["kara_48_bot"]);
        //        graphcontrol.hava_34_bot = Convert.ToInt32(reader["hava_34_bot"]);
        //        graphcontrol.hava_35_bot = Convert.ToInt32(reader["hava_35_bot"]);
        //        graphcontrol.hava_36_bot = Convert.ToInt32(reader["hava_36_bot"]);
        //        graphcontrol.hava_37_bot = Convert.ToInt32(reader["hava_37_bot"]);
        //        graphcontrol.hava_38_bot = Convert.ToInt32(reader["hava_38_bot"]);
        //        graphcontrol.hava_39_bot = Convert.ToInt32(reader["hava_39_bot"]);
        //        graphcontrol.hava_40_bot = Convert.ToInt32(reader["hava_40_bot"]);
        //        graphcontrol.hava_41_bot = Convert.ToInt32(reader["hava_41_bot"]);
        //        graphcontrol.hava_42_bot = Convert.ToInt32(reader["hava_42_bot"]);
        //        graphcontrol.hava_43_bot = Convert.ToInt32(reader["hava_43_bot"]);
        //        graphcontrol.hava_44_bot = Convert.ToInt32(reader["hava_44_bot"]);
        //        graphcontrol.hava_45_bot = Convert.ToInt32(reader["hava_45_bot"]);
        //        graphcontrol.hava_46_bot = Convert.ToInt32(reader["hava_46_bot"]);
        //        graphcontrol.hava_47_bot = Convert.ToInt32(reader["hava_47_bot"]);
        //        graphcontrol.hava_48_bot = Convert.ToInt32(reader["hava_48_bot"]);
        //        graphcontrol.deniz_34_bot = Convert.ToInt32(reader["deniz_34_bot"]);
        //        graphcontrol.deniz_35_bot = Convert.ToInt32(reader["deniz_35_bot"]);
        //        graphcontrol.deniz_36_bot = Convert.ToInt32(reader["deniz_36_bot"]);
        //        graphcontrol.deniz_37_bot = Convert.ToInt32(reader["deniz_37_bot"]);
        //        graphcontrol.deniz_38_bot = Convert.ToInt32(reader["deniz_38_bot"]);
        //        graphcontrol.deniz_39_bot = Convert.ToInt32(reader["deniz_39_bot"]);
        //        graphcontrol.deniz_40_bot = Convert.ToInt32(reader["deniz_40_bot"]);
        //        graphcontrol.deniz_41_bot = Convert.ToInt32(reader["deniz_41_bot"]);
        //        graphcontrol.deniz_42_bot = Convert.ToInt32(reader["deniz_42_bot"]);
        //        graphcontrol.deniz_43_bot = Convert.ToInt32(reader["deniz_43_bot"]);
        //        graphcontrol.deniz_44_bot = Convert.ToInt32(reader["deniz_44_bot"]);
        //        graphcontrol.deniz_45_bot = Convert.ToInt32(reader["deniz_45_bot"]);
        //        graphcontrol.deniz_46_bot = Convert.ToInt32(reader["deniz_46_bot"]);
        //        graphcontrol.deniz_47_bot = Convert.ToInt32(reader["deniz_47_bot"]);
        //        graphcontrol.deniz_48_bot = Convert.ToInt32(reader["deniz_48_bot"]);
        //        graphcontrol.karatotalpant = Convert.ToInt32(reader["karatotalpant"]);
        //        graphcontrol.havatotalpant = Convert.ToInt32(reader["havatotalpant"]);
        //        graphcontrol.deniztotalpant = Convert.ToInt32(reader["deniztotalpant"]);
        //        graphcontrol.kara_xs_pant = Convert.ToInt32(reader["kara_xs_pant"]);
        //        graphcontrol.kara_s_pant = Convert.ToInt32(reader["kara_s_pant"]);
        //        graphcontrol.kara_m_pant = Convert.ToInt32(reader["kara_m_pant"]);
        //        graphcontrol.kara_l_pant = Convert.ToInt32(reader["kara_l_pant"]);
        //        graphcontrol.kara_xl_pant = Convert.ToInt32(reader["kara_xl_pant"]);
        //        graphcontrol.kara_2xl_pant = Convert.ToInt32(reader["kara_2xl_pant"]);
        //        graphcontrol.kara_3xl_pant = Convert.ToInt32(reader["kara_3xl_pant"]);
        //        graphcontrol.kara_bxl_pant = Convert.ToInt32(reader["kara_bxl_pant"]);
        //        graphcontrol.hava_xs_pant = Convert.ToInt32(reader["hava_xs_pant"]);
        //        graphcontrol.hava_s_pant = Convert.ToInt32(reader["hava_s_pant"]);
        //        graphcontrol.hava_m_pant = Convert.ToInt32(reader["hava_m_pant"]);
        //        graphcontrol.hava_l_pant = Convert.ToInt32(reader["hava_l_pant"]);
        //        graphcontrol.hava_xl_pant = Convert.ToInt32(reader["hava_xl_pant"]);
        //        graphcontrol.hava_2xl_pant = Convert.ToInt32(reader["hava_2xl_pant"]);
        //        graphcontrol.hava_3xl_pant = Convert.ToInt32(reader["hava_3xl_pant"]);
        //        graphcontrol.hava_bxl_pant = Convert.ToInt32(reader["hava_bxl_pant"]);
        //        graphcontrol.deniz_xs_pant = Convert.ToInt32(reader["deniz_xs_pant"]);
        //        graphcontrol.deniz_s_pant = Convert.ToInt32(reader["deniz_s_pant"]);
        //        graphcontrol.deniz_m_pant = Convert.ToInt32(reader["deniz_m_pant"]);
        //        graphcontrol.deniz_l_pant = Convert.ToInt32(reader["deniz_l_pant"]);
        //        graphcontrol.deniz_xl_pant = Convert.ToInt32(reader["deniz_xl_pant"]);
        //        graphcontrol.deniz_2xl_pant = Convert.ToInt32(reader["deniz_2xl_pant"]);
        //        graphcontrol.deniz_3xl_pant = Convert.ToInt32(reader["deniz_3xl_pant"]);
        //        graphcontrol.deniz_bxl_pant = Convert.ToInt32(reader["deniz_bxl_pant"]);
        //        graphcontrol.karatotalhands = Convert.ToInt32(reader["karatotalhands"]);
        //        graphcontrol.havatotalhands = Convert.ToInt32(reader["havatotalhands"]);
        //        graphcontrol.deniztotalhands = Convert.ToInt32(reader["deniztotalhands"]);
        //        graphcontrol.kara_xs_hands = Convert.ToInt32(reader["kara_xs_hands"]);
        //        graphcontrol.kara_s_hands = Convert.ToInt32(reader["kara_s_hands"]);
        //        graphcontrol.kara_m_hands = Convert.ToInt32(reader["kara_m_hands"]);
        //        graphcontrol.kara_l_hands = Convert.ToInt32(reader["kara_l_hands"]);
        //        graphcontrol.kara_xl_hands = Convert.ToInt32(reader["kara_xl_hands"]);
        //        graphcontrol.kara_2xl_hands = Convert.ToInt32(reader["kara_2xl_hands"]);
        //        graphcontrol.hava_xs_hands = Convert.ToInt32(reader["hava_xs_hands"]);
        //        graphcontrol.hava_s_hands = Convert.ToInt32(reader["hava_s_hands"]);
        //        graphcontrol.hava_m_hands = Convert.ToInt32(reader["hava_m_hands"]);
        //        graphcontrol.hava_l_hands = Convert.ToInt32(reader["hava_l_hands"]);
        //        graphcontrol.hava_xl_hands = Convert.ToInt32(reader["hava_xl_hands"]);
        //        graphcontrol.hava_2xl_hands = Convert.ToInt32(reader["hava_2xl_hands"]);
        //        graphcontrol.deniz_xs_hands = Convert.ToInt32(reader["deniz_xs_hands"]);
        //        graphcontrol.deniz_s_hands = Convert.ToInt32(reader["deniz_s_hands"]);
        //        graphcontrol.deniz_m_hands = Convert.ToInt32(reader["deniz_m_hands"]);
        //        graphcontrol.deniz_l_hands = Convert.ToInt32(reader["deniz_l_hands"]);
        //        graphcontrol.deniz_xl_hands = Convert.ToInt32(reader["deniz_xl_hands"]);
        //        graphcontrol.deniz_2xl_hands = Convert.ToInt32(reader["deniz_2xl_hands"]);
        //        graphcontrol.kara_140_150_boy = Convert.ToInt32(reader["kara_140_150_boy"]);
        //        graphcontrol.kara_150_160_boy = Convert.ToInt32(reader["kara_150_160_boy"]);
        //        graphcontrol.kara_160_170_boy = Convert.ToInt32(reader["kara_160_170_boy"]);
        //        graphcontrol.kara_170_180_boy = Convert.ToInt32(reader["kara_170_180_boy"]);
        //        graphcontrol.kara_180_190_boy = Convert.ToInt32(reader["kara_180_190_boy"]);
        //        graphcontrol.kara_190_200_boy = Convert.ToInt32(reader["kara_190_200_boy"]);
        //        graphcontrol.kara_200_210_boy = Convert.ToInt32(reader["kara_200_210_boy"]);
        //        graphcontrol.kara_210_220_boy = Convert.ToInt32(reader["kara_210_220_boy"]);
        //        graphcontrol.kara_220_230_boy = Convert.ToInt32(reader["kara_220_230_boy"]);
        //        graphcontrol.hava_140_150_boy = Convert.ToInt32(reader["hava_140_150_boy"]);
        //        graphcontrol.hava_150_160_boy = Convert.ToInt32(reader["hava_150_160_boy"]);
        //        graphcontrol.hava_160_170_boy = Convert.ToInt32(reader["hava_160_170_boy"]);
        //        graphcontrol.hava_170_180_boy = Convert.ToInt32(reader["hava_170_180_boy"]);
        //        graphcontrol.hava_180_190_boy = Convert.ToInt32(reader["hava_180_190_boy"]);
        //        graphcontrol.hava_190_200_boy = Convert.ToInt32(reader["hava_190_200_boy"]);
        //        graphcontrol.hava_200_210_boy = Convert.ToInt32(reader["hava_200_210_boy"]);
        //        graphcontrol.hava_210_220_boy = Convert.ToInt32(reader["hava_210_220_boy"]);
        //        graphcontrol.hava_220_230_boy = Convert.ToInt32(reader["hava_220_230_boy"]);
        //        graphcontrol.deniz_140_150_boy = Convert.ToInt32(reader["deniz_140_150_boy"]);
        //        graphcontrol.deniz_150_160_boy = Convert.ToInt32(reader["deniz_150_160_boy"]);
        //        graphcontrol.deniz_160_170_boy = Convert.ToInt32(reader["deniz_160_170_boy"]);
        //        graphcontrol.deniz_170_180_boy = Convert.ToInt32(reader["deniz_170_180_boy"]);
        //        graphcontrol.deniz_180_190_boy = Convert.ToInt32(reader["deniz_180_190_boy"]);
        //        graphcontrol.deniz_190_200_boy = Convert.ToInt32(reader["deniz_190_200_boy"]);
        //        graphcontrol.deniz_200_210_boy = Convert.ToInt32(reader["deniz_200_210_boy"]);
        //        graphcontrol.deniz_210_220_boy = Convert.ToInt32(reader["deniz_210_220_boy"]);
        //        graphcontrol.deniz_220_230_boy = Convert.ToInt32(reader["deniz_220_230_boy"]);
        //        graphcontrol.kara_140alti_uyluk = Convert.ToInt32(reader["kara_140alti_uyluk"]);
        //        graphcontrol.kara_140_180_uyluk = Convert.ToInt32(reader["kara_140_180_uyluk"]);
        //        graphcontrol.kara_180_220_uyluk = Convert.ToInt32(reader["kara_180_220_uyluk"]);
        //        graphcontrol.kara_220_260_uyluk = Convert.ToInt32(reader["kara_220_260_uyluk"]);
        //        graphcontrol.kara_260ustu_uyluk = Convert.ToInt32(reader["kara_260ustu_uyluk"]);
        //        graphcontrol.hava_140alti_uyluk = Convert.ToInt32(reader["hava_140alti_uyluk"]);
        //        graphcontrol.hava_140_180_uyluk = Convert.ToInt32(reader["hava_140_180_uyluk"]);
        //        graphcontrol.hava_180_220_uyluk = Convert.ToInt32(reader["hava_180_220_uyluk"]);
        //        graphcontrol.hava_220_260_uyluk = Convert.ToInt32(reader["hava_220_260_uyluk"]);
        //        graphcontrol.hava_260ustu_uyluk = Convert.ToInt32(reader["hava_260ustu_uyluk"]);
        //        graphcontrol.deniz_140alti_uyluk = Convert.ToInt32(reader["deniz_140alti_uyluk"]);
        //        graphcontrol.deniz_140_180_uyluk = Convert.ToInt32(reader["deniz_140_180_uyluk"]);
        //        graphcontrol.deniz_180_220_uyluk = Convert.ToInt32(reader["deniz_180_220_uyluk"]);
        //        graphcontrol.deniz_220_260_uyluk = Convert.ToInt32(reader["deniz_220_260_uyluk"]);
        //        graphcontrol.deniz_260ustu_uyluk = Convert.ToInt32(reader["deniz_260ustu_uyluk"]);















        //        graphcontrols.Add(graphcontrol);

        //    }
        //    reader.Close();
        //    _baglan.Close();
        //    return graphcontrols;



        //}

    }
}
