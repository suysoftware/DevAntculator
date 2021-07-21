using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Entities;
using TezAPPV2.Model;
using TezAPPV2.Paths;
using TezAPPV2.Abstract;
using System.Data.SqlClient;
using System.Data;

namespace TezAPPV2.SqlOperations
{
    class AddNewSeason
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



        private SqlConnection _baglan = new SqlConnection(@"Data Source=SUY-PC\SQLEXPRESS;Initial Catalog=THESESX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void connect()
        {

            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open();
            }
        }

        public void YeniDonem(AddNewSeason DashboardDataInfo)
        {
            

            connect();

            SqlCommand command = new SqlCommand("Insert Into Dashboarddata values (@totalsoldier,@karakuvvet,@denizkuvvet,@havakuvvet,@karatotalchest,@havatotalchest,@deniztotalchest,@kara_xs_chest,@kara_s_chest,@kara_m_chest,@kara_l_chest,@kara_xl_chest,@kara_2xl_chest,@hava_xs_chest,@hava_s_chest,@hava_m_chest,@hava_l_chest,@hava_2l_chest,@hava_xxl_chest,@deniz_xs_chest,@deniz_s_chest,@deniz_m_chest,@deniz_l_chest,@deniz_xl_chest,@deniz_2xl_chest,@karatotalbot,@havatotalbot,@deniztotalbot,@kara_34_bot,@kara_35_bot,@kara_36_bot,@kara_37_bot,@kara_38_bot,@kara_39_bot,@kara_40_bot,@kara_41_bot,@kara_42_bot,@kara_43_bot,@kara_44_bot,@kara_45_bot,@kara_46_bot,@kara_47_bot,@kara_48_bot,@hava_34_bot,@hava_35_bot,@hava_36_bot,@hava_37_bot,@hava_38_bot,@hava_39_bot,@hava_40_bot,@hava_41_bot,@hava_42_bot,@hava_43_bot,@hava_44_bot,@hava_45_bot,@hava_46_bot,@hava_47_bot,@hava_48_bot,@deniz_34_bot,@deniz_35_bot,@deniz_36_bot,@deniz_37_bot,@deniz_38_bot,@deniz_39_bot,@deniz_40_bot,@deniz_41_bot,@deniz_42_bot,@deniz_43_bot,@deniz_44_bot,@deniz_45_bot,@deniz_46_bot,@deniz_47_bot,@deniz_48_bot,@karatotalpant,@havatotalpant,@deniztotalpant,@kara_xs_pant,@kara_s_pant,@kara_m_pant,@kara_l_pant,@kara_xl_pant,@kara_2xl_pant,@kara_3xl_pant,@kara_bxl_pant,@hava_xs_pant,@hava_s_pant,@hava_m_pant,@hava_l_pant,@hava_xl_pant,@hava_2xl_pant,@hava_3xl_pant,@hava_bxl_pant,@deniz_xs_pant,@deniz_s_pant,@deniz_m_pant,@deniz_l_pant,@deniz_xl_pant,@deniz_2xl_pant,@deniz_3xl_pant,@deniz_bxl_pant,@karatotalhands,@havatotalhands,@deniztotalhands,@kara_xs_hands,@kara_s_hands,@kara_m_hands,@kara_l_hands,@kara_xl_hands,@kara_2xl_hands,@hava_xs_hands,@hava_s_hands,@hava_m_hands,@hava_l_hands,@hava_xl_hands,@hava_2xl_hands,@deniz_xs_hands,@deniz_s_hands,@deniz_m_hands,@deniz_l_hands,@deniz_xl_hands,@deniz_2xl_hands,@kara_140_150_boy,@kara_150_160_boy,@kara_160_170_boy,@kara_170_180_boy,@kara_180_190_boy,@kara_190_200_boy,@kara_200_210_boy,@kara_210_220_boy,@kara_220_230_boy,@hava_140_150_boy,@hava_150_160_boy,@hava_160_170_boy,@hava_170_180_boy,@hava_180_190_boy,@hava_190_200_boy,@hava_200_210_boy,@hava_210_220_boy,@hava_220_230_boy,@deniz_140_150_boy,@deniz_150_160_boy,@deniz_160_170_boy,@deniz_170_180_boy,@deniz_180_190_boy,@deniz_190_200_boy,@deniz_200_210_boy,@deniz_210_220_boy,@deniz_220_230_boy,@kara_140alti_uyluk,@kara_140_180_uyluk,@kara_180_220_uyluk,@kara_220_260_uyluk,@kara_260ustu_uyluk,@hava_140alti_uyluk,@hava_140_180_uyluk,@hava_180_220_uyluk,@hava_220_260_uyluk,@hava_260ustu_uyluk,@deniz_140alti_uyluk,@deniz_140_180_uyluk,@deniz_180_220_uyluk,@deniz_220_260_uyluk,@deniz_260ustu_uyluk)", _baglan) ;

            command.Parameters.AddWithValue("@totalsoldier", DashboardDataInfo.totalsoldier);
            command.Parameters.AddWithValue("@karakuvvet", DashboardDataInfo.karakuvvet);
            command.Parameters.AddWithValue("@denizkuvvet", DashboardDataInfo.denizkuvvet);
            command.Parameters.AddWithValue("@havakuvvet", DashboardDataInfo.havakuvvet);
            command.Parameters.AddWithValue("@karatotalchest", DashboardDataInfo.karatotalchest);
            command.Parameters.AddWithValue("@havatotalchest", DashboardDataInfo.havatotalchest);
            command.Parameters.AddWithValue("@deniztotalchest", DashboardDataInfo.deniztotalchest);
            command.Parameters.AddWithValue("@kara_xs_chest", DashboardDataInfo.kara_xs_chest);
            command.Parameters.AddWithValue("@kara_s_chest", DashboardDataInfo.kara_s_chest);
            command.Parameters.AddWithValue("@kara_m_chest", DashboardDataInfo.kara_m_chest);
            command.Parameters.AddWithValue("@kara_l_chest", DashboardDataInfo.kara_l_chest);
            command.Parameters.AddWithValue("@kara_xl_chest", DashboardDataInfo.kara_xl_chest);
            command.Parameters.AddWithValue("@kara_2xl_chest", DashboardDataInfo.kara_2xl_chest);
            command.Parameters.AddWithValue("@hava_xs_chest", DashboardDataInfo.hava_xs_chest);
            command.Parameters.AddWithValue("@hava_s_chest", DashboardDataInfo.hava_s_chest);
            command.Parameters.AddWithValue("@hava_m_chest", DashboardDataInfo.hava_m_chest);
            command.Parameters.AddWithValue("@hava_l_chest", DashboardDataInfo.hava_l_chest);
            command.Parameters.AddWithValue("@hava_2l_chest", DashboardDataInfo.hava_2l_chest);
            command.Parameters.AddWithValue("@hava_xxl_chest", DashboardDataInfo.hava_xxl_chest);
            command.Parameters.AddWithValue("@deniz_xs_chest", DashboardDataInfo.deniz_xs_chest);
            command.Parameters.AddWithValue("@deniz_s_chest", DashboardDataInfo.deniz_s_chest);
            command.Parameters.AddWithValue("@deniz_m_chest", DashboardDataInfo.deniz_m_chest);
            command.Parameters.AddWithValue("@deniz_l_chest", DashboardDataInfo.deniz_l_chest);
            command.Parameters.AddWithValue("@deniz_xl_chest", DashboardDataInfo.deniz_xl_chest);
            command.Parameters.AddWithValue("@deniz_2xl_chest", DashboardDataInfo.deniz_2xl_chest);
            command.Parameters.AddWithValue("@karatotalbot", DashboardDataInfo.karatotalbot);
            command.Parameters.AddWithValue("@havatotalbot", DashboardDataInfo.havatotalbot);
            command.Parameters.AddWithValue("@deniztotalbot", DashboardDataInfo.deniztotalbot);
            command.Parameters.AddWithValue("@kara_34_bot", DashboardDataInfo.kara_34_bot);
            command.Parameters.AddWithValue("@kara_35_bot", DashboardDataInfo.kara_35_bot);
            command.Parameters.AddWithValue("@kara_36_bot", DashboardDataInfo.kara_36_bot);
            command.Parameters.AddWithValue("@kara_37_bot", DashboardDataInfo.kara_37_bot);
            command.Parameters.AddWithValue("@kara_38_bot", DashboardDataInfo.kara_38_bot);
            command.Parameters.AddWithValue("@kara_39_bot", DashboardDataInfo.kara_39_bot);
            command.Parameters.AddWithValue("@kara_40_bot", DashboardDataInfo.kara_40_bot);
            command.Parameters.AddWithValue("@kara_41_bot", DashboardDataInfo.kara_41_bot);
            command.Parameters.AddWithValue("@kara_42_bot", DashboardDataInfo.kara_42_bot);
            command.Parameters.AddWithValue("@kara_43_bot", DashboardDataInfo.kara_43_bot);
            command.Parameters.AddWithValue("@kara_44_bot", DashboardDataInfo.kara_44_bot);
            command.Parameters.AddWithValue("@kara_45_bot", DashboardDataInfo.kara_45_bot);
            command.Parameters.AddWithValue("@kara_46_bot", DashboardDataInfo.kara_46_bot);
            command.Parameters.AddWithValue("@kara_47_bot", DashboardDataInfo.kara_47_bot);
            command.Parameters.AddWithValue("@kara_48_bot", DashboardDataInfo.kara_48_bot);
            command.Parameters.AddWithValue("@hava_34_bot", DashboardDataInfo.hava_34_bot);
            command.Parameters.AddWithValue("@hava_35_bot", DashboardDataInfo.hava_35_bot);
            command.Parameters.AddWithValue("@hava_36_bot", DashboardDataInfo.hava_36_bot);
            command.Parameters.AddWithValue("@hava_37_bot", DashboardDataInfo.hava_37_bot);
            command.Parameters.AddWithValue("@hava_38_bot", DashboardDataInfo.hava_38_bot);
            command.Parameters.AddWithValue("@hava_39_bot", DashboardDataInfo.hava_39_bot);
            command.Parameters.AddWithValue("@hava_40_bot", DashboardDataInfo.hava_40_bot);
            command.Parameters.AddWithValue("@hava_41_bot", DashboardDataInfo.hava_41_bot);
            command.Parameters.AddWithValue("@hava_42_bot", DashboardDataInfo.hava_42_bot);
            command.Parameters.AddWithValue("@hava_43_bot", DashboardDataInfo.hava_43_bot);
            command.Parameters.AddWithValue("@hava_44_bot", DashboardDataInfo.hava_44_bot);
            command.Parameters.AddWithValue("@hava_45_bot", DashboardDataInfo.hava_45_bot);
            command.Parameters.AddWithValue("@hava_46_bot", DashboardDataInfo.hava_46_bot);
            command.Parameters.AddWithValue("@hava_47_bot", DashboardDataInfo.hava_47_bot);
            command.Parameters.AddWithValue("@hava_48_bot", DashboardDataInfo.hava_48_bot);
            command.Parameters.AddWithValue("@deniz_34_bot", DashboardDataInfo.deniz_34_bot);
            command.Parameters.AddWithValue("@deniz_35_bot", DashboardDataInfo.deniz_35_bot);
            command.Parameters.AddWithValue("@deniz_36_bot", DashboardDataInfo.deniz_36_bot);
            command.Parameters.AddWithValue("@deniz_37_bot", DashboardDataInfo.deniz_37_bot);
            command.Parameters.AddWithValue("@deniz_38_bot", DashboardDataInfo.deniz_38_bot);
            command.Parameters.AddWithValue("@deniz_39_bot", DashboardDataInfo.deniz_39_bot);
            command.Parameters.AddWithValue("@deniz_40_bot", DashboardDataInfo.deniz_40_bot);
            command.Parameters.AddWithValue("@deniz_41_bot", DashboardDataInfo.deniz_41_bot);
            command.Parameters.AddWithValue("@deniz_42_bot", DashboardDataInfo.deniz_42_bot);
            command.Parameters.AddWithValue("@deniz_43_bot", DashboardDataInfo.deniz_43_bot);
            command.Parameters.AddWithValue("@deniz_44_bot", DashboardDataInfo.deniz_44_bot);
            command.Parameters.AddWithValue("@deniz_45_bot", DashboardDataInfo.deniz_45_bot);
            command.Parameters.AddWithValue("@deniz_46_bot", DashboardDataInfo.deniz_46_bot);
            command.Parameters.AddWithValue("@deniz_47_bot", DashboardDataInfo.deniz_47_bot);
            command.Parameters.AddWithValue("@deniz_48_bot", DashboardDataInfo.deniz_48_bot);
            command.Parameters.AddWithValue("@karatotalpant", DashboardDataInfo.karatotalpant);
            command.Parameters.AddWithValue("@havatotalpant", DashboardDataInfo.havatotalpant);
            command.Parameters.AddWithValue("@deniztotalpant", DashboardDataInfo.deniztotalpant);
            command.Parameters.AddWithValue("@kara_xs_pant", DashboardDataInfo.kara_xs_pant);
            command.Parameters.AddWithValue("@kara_s_pant", DashboardDataInfo.kara_s_pant);
            command.Parameters.AddWithValue("@kara_m_pant", DashboardDataInfo.kara_m_pant);
            command.Parameters.AddWithValue("@kara_l_pant", DashboardDataInfo.kara_l_pant);
            command.Parameters.AddWithValue("@kara_xl_pant", DashboardDataInfo.kara_xl_pant);
            command.Parameters.AddWithValue("@kara_2xl_pant", DashboardDataInfo.kara_2xl_pant);
            command.Parameters.AddWithValue("@kara_3xl_pant", DashboardDataInfo.kara_3xl_pant);
            command.Parameters.AddWithValue("@kara_bxl_pant", DashboardDataInfo.kara_bxl_pant);
            command.Parameters.AddWithValue("@hava_xs_pant", DashboardDataInfo.hava_xs_pant);
            command.Parameters.AddWithValue("@hava_s_pant", DashboardDataInfo.hava_s_pant);
            command.Parameters.AddWithValue("@hava_m_pant", DashboardDataInfo.hava_m_pant);
            command.Parameters.AddWithValue("@hava_l_pant", DashboardDataInfo.hava_l_pant);
            command.Parameters.AddWithValue("@hava_xl_pant", DashboardDataInfo.hava_xl_pant);
            command.Parameters.AddWithValue("@hava_2xl_pant", DashboardDataInfo.hava_2xl_pant);
            command.Parameters.AddWithValue("@hava_3xl_pant", DashboardDataInfo.hava_3xl_pant);
            command.Parameters.AddWithValue("@hava_bxl_pant", DashboardDataInfo.hava_bxl_pant);
            command.Parameters.AddWithValue("@deniz_xs_pant", DashboardDataInfo.deniz_xs_pant);
            command.Parameters.AddWithValue("@deniz_s_pant", DashboardDataInfo.deniz_s_pant);
            command.Parameters.AddWithValue("@deniz_m_pant", DashboardDataInfo.deniz_m_pant);
            command.Parameters.AddWithValue("@deniz_l_pant", DashboardDataInfo.deniz_l_pant);
            command.Parameters.AddWithValue("@deniz_xl_pant", DashboardDataInfo.deniz_xl_pant);
            command.Parameters.AddWithValue("@deniz_2xl_pant", DashboardDataInfo.deniz_2xl_pant);
            command.Parameters.AddWithValue("@deniz_3xl_pant", DashboardDataInfo.deniz_3xl_pant);
            command.Parameters.AddWithValue("@deniz_bxl_pant", DashboardDataInfo.deniz_bxl_pant);
            command.Parameters.AddWithValue("@karatotalhands", DashboardDataInfo.karatotalhands);
            command.Parameters.AddWithValue("@havatotalhands", DashboardDataInfo.havatotalhands);
            command.Parameters.AddWithValue("@deniztotalhands", DashboardDataInfo.deniztotalhands);
            command.Parameters.AddWithValue("@kara_xs_hands", DashboardDataInfo.kara_xs_hands);
            command.Parameters.AddWithValue("@kara_s_hands", DashboardDataInfo.kara_s_hands);
            command.Parameters.AddWithValue("@kara_m_hands", DashboardDataInfo.kara_m_hands);
            command.Parameters.AddWithValue("@kara_l_hands", DashboardDataInfo.kara_l_hands);
            command.Parameters.AddWithValue("@kara_xl_hands", DashboardDataInfo.kara_xl_hands);
            command.Parameters.AddWithValue("@kara_2xl_hands", DashboardDataInfo.kara_2xl_hands);
            command.Parameters.AddWithValue("@hava_xs_hands", DashboardDataInfo.hava_xs_hands);
            command.Parameters.AddWithValue("@hava_s_hands", DashboardDataInfo.hava_s_hands);
            command.Parameters.AddWithValue("@hava_m_hands", DashboardDataInfo.hava_m_hands);
            command.Parameters.AddWithValue("@hava_l_hands", DashboardDataInfo.hava_l_hands);
            command.Parameters.AddWithValue("@hava_xl_hands", DashboardDataInfo.hava_xl_hands);
            command.Parameters.AddWithValue("@hava_2xl_hands", DashboardDataInfo.hava_2xl_hands);
            command.Parameters.AddWithValue("@deniz_xs_hands", DashboardDataInfo.deniz_xs_hands);
            command.Parameters.AddWithValue("@deniz_s_hands", DashboardDataInfo.deniz_s_hands);
            command.Parameters.AddWithValue("@deniz_m_hands", DashboardDataInfo.deniz_m_hands);
            command.Parameters.AddWithValue("@deniz_l_hands", DashboardDataInfo.deniz_l_hands);
            command.Parameters.AddWithValue("@deniz_xl_hands", DashboardDataInfo.deniz_xl_hands);
            command.Parameters.AddWithValue("@deniz_2xl_hands", DashboardDataInfo.deniz_2xl_hands);
            command.Parameters.AddWithValue("@kara_140_150_boy", DashboardDataInfo.kara_140_150_boy);
            command.Parameters.AddWithValue("@kara_150_160_boy", DashboardDataInfo.kara_150_160_boy);
            command.Parameters.AddWithValue("@kara_160_170_boy", DashboardDataInfo.kara_160_170_boy);
            command.Parameters.AddWithValue("@kara_170_180_boy", DashboardDataInfo.kara_170_180_boy);
            command.Parameters.AddWithValue("@kara_180_190_boy", DashboardDataInfo.kara_180_190_boy);
            command.Parameters.AddWithValue("@kara_190_200_boy", DashboardDataInfo.kara_190_200_boy);
            command.Parameters.AddWithValue("@kara_200_210_boy", DashboardDataInfo.kara_200_210_boy);
            command.Parameters.AddWithValue("@kara_210_220_boy", DashboardDataInfo.kara_210_220_boy);
            command.Parameters.AddWithValue("@kara_220_230_boy", DashboardDataInfo.kara_220_230_boy);
            command.Parameters.AddWithValue("@hava_140_150_boy", DashboardDataInfo.hava_140_150_boy);
            command.Parameters.AddWithValue("@hava_150_160_boy", DashboardDataInfo.hava_150_160_boy);
            command.Parameters.AddWithValue("@hava_160_170_boy", DashboardDataInfo.hava_160_170_boy);
            command.Parameters.AddWithValue("@hava_170_180_boy", DashboardDataInfo.hava_170_180_boy);
            command.Parameters.AddWithValue("@hava_180_190_boy", DashboardDataInfo.hava_180_190_boy);
            command.Parameters.AddWithValue("@hava_190_200_boy", DashboardDataInfo.hava_190_200_boy);
            command.Parameters.AddWithValue("@hava_200_210_boy", DashboardDataInfo.hava_200_210_boy);
            command.Parameters.AddWithValue("@hava_210_220_boy", DashboardDataInfo.hava_210_220_boy);
            command.Parameters.AddWithValue("@hava_220_230_boy", DashboardDataInfo.hava_220_230_boy);
            command.Parameters.AddWithValue("@deniz_140_150_boy", DashboardDataInfo.deniz_140_150_boy);
            command.Parameters.AddWithValue("@deniz_150_160_boy", DashboardDataInfo.deniz_150_160_boy);
            command.Parameters.AddWithValue("@deniz_160_170_boy", DashboardDataInfo.deniz_160_170_boy);
            command.Parameters.AddWithValue("@deniz_170_180_boy", DashboardDataInfo.deniz_170_180_boy);
            command.Parameters.AddWithValue("@deniz_180_190_boy", DashboardDataInfo.deniz_180_190_boy);
            command.Parameters.AddWithValue("@deniz_190_200_boy", DashboardDataInfo.deniz_190_200_boy);
            command.Parameters.AddWithValue("@deniz_200_210_boy", DashboardDataInfo.deniz_200_210_boy);
            command.Parameters.AddWithValue("@deniz_210_220_boy", DashboardDataInfo.deniz_210_220_boy);
            command.Parameters.AddWithValue("@deniz_220_230_boy", DashboardDataInfo.deniz_220_230_boy);
            command.Parameters.AddWithValue("@kara_140alti_uyluk", DashboardDataInfo.kara_140alti_uyluk);
            command.Parameters.AddWithValue("@kara_140_180_uyluk", DashboardDataInfo.kara_140_180_uyluk);
            command.Parameters.AddWithValue("@kara_180_220_uyluk", DashboardDataInfo.kara_180_220_uyluk);
            command.Parameters.AddWithValue("@kara_220_260_uyluk", DashboardDataInfo.kara_220_260_uyluk);
            command.Parameters.AddWithValue("@kara_260ustu_uyluk", DashboardDataInfo.kara_260ustu_uyluk);
            command.Parameters.AddWithValue("@hava_140alti_uyluk", DashboardDataInfo.hava_140alti_uyluk);
            command.Parameters.AddWithValue("@hava_140_180_uyluk", DashboardDataInfo.hava_140_180_uyluk);
            command.Parameters.AddWithValue("@hava_180_220_uyluk", DashboardDataInfo.hava_180_220_uyluk);
            command.Parameters.AddWithValue("@hava_220_260_uyluk", DashboardDataInfo.hava_220_260_uyluk);
            command.Parameters.AddWithValue("@hava_260ustu_uyluk", DashboardDataInfo.hava_260ustu_uyluk);
            command.Parameters.AddWithValue("@deniz_140alti_uyluk", DashboardDataInfo.deniz_140alti_uyluk);
            command.Parameters.AddWithValue("@deniz_140_180_uyluk", DashboardDataInfo.deniz_140_180_uyluk);
            command.Parameters.AddWithValue("@deniz_180_220_uyluk", DashboardDataInfo.deniz_180_220_uyluk);
            command.Parameters.AddWithValue("@deniz_220_260_uyluk", DashboardDataInfo.deniz_220_260_uyluk);
            command.Parameters.AddWithValue("@deniz_260ustu_uyluk", DashboardDataInfo.deniz_260ustu_uyluk);



            command.ExecuteNonQuery();
            _baglan.Close();


        }


    }
}
