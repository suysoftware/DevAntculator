using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TezAPPV2;
using TezAPPV2.Model;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Mail;
using TezAPPV2.SqlOperations;



namespace TezAPPV2.Forms
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            FormMainMenu.ActiveForm.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
        //Measur _measur = new Measur();
        Postman _postman = new Postman();
        
        GetSeasonsDetail _getSeasonsDetail = new GetSeasonsDetail();
        AddNewSeason _addNewSeason = new AddNewSeason();

        
        private void button1_Click(object sender, EventArgs e)
        {
        
            






        }

        private void yenidonem_Click(object sender, EventArgs e)
        {
            

            _postman.Getmessagestodikimevi();


            dtgMail.DataSource = _getSeasonsDetail.GetSeasons();

            _addNewSeason.totalsoldier = 0;
            _addNewSeason.karakuvvet = 0;
            _addNewSeason.denizkuvvet = 0;
            _addNewSeason.havakuvvet = 0;
            _addNewSeason.karatotalchest = 0;
            _addNewSeason.havatotalchest = 0;
            _addNewSeason.deniztotalchest = 0;
            _addNewSeason.kara_xs_chest = 0;
            _addNewSeason.kara_s_chest = 0;
            _addNewSeason.kara_m_chest = 0;
            _addNewSeason.kara_l_chest = 0;
            _addNewSeason.kara_xl_chest = 0;
            _addNewSeason.kara_2xl_chest = 0;
            _addNewSeason.hava_xs_chest = 0;
            _addNewSeason.hava_s_chest = 0;
            _addNewSeason.hava_m_chest = 0;
            _addNewSeason.hava_l_chest = 0;
            _addNewSeason.hava_2l_chest = 0;
            _addNewSeason.hava_xxl_chest = 0;
            _addNewSeason.deniz_xs_chest = 0;
            _addNewSeason.deniz_s_chest = 0;
            _addNewSeason.deniz_m_chest = 0;
            _addNewSeason.deniz_l_chest = 0;
            _addNewSeason.deniz_xl_chest = 0;
            _addNewSeason.deniz_2xl_chest = 0;
            _addNewSeason.karatotalbot = 0;
            _addNewSeason.havatotalbot = 0;
            _addNewSeason.deniztotalbot = 0;
            _addNewSeason.kara_34_bot = 0;
            _addNewSeason.kara_35_bot = 0;
            _addNewSeason.kara_36_bot = 0;
            _addNewSeason.kara_37_bot = 0;
            _addNewSeason.kara_38_bot = 0;
            _addNewSeason.kara_39_bot = 0;
            _addNewSeason.kara_40_bot = 0;
            _addNewSeason.kara_41_bot = 0;
            _addNewSeason.kara_42_bot = 0;
            _addNewSeason.kara_43_bot = 0;
            _addNewSeason.kara_44_bot = 0;
            _addNewSeason.kara_45_bot = 0;
            _addNewSeason.kara_46_bot = 0;
            _addNewSeason.kara_47_bot = 0;
            _addNewSeason.kara_48_bot = 0;
            _addNewSeason.hava_34_bot = 0;
            _addNewSeason.hava_35_bot = 0;
            _addNewSeason.hava_36_bot = 0;
            _addNewSeason.hava_37_bot = 0;
            _addNewSeason.hava_38_bot = 0;
            _addNewSeason.hava_39_bot = 0;
            _addNewSeason.hava_40_bot = 0;
            _addNewSeason.hava_41_bot = 0;
            _addNewSeason.hava_42_bot = 0;
            _addNewSeason.hava_43_bot = 0;
            _addNewSeason.hava_44_bot = 0;
            _addNewSeason.hava_45_bot = 0;
            _addNewSeason.hava_46_bot = 0;
            _addNewSeason.hava_47_bot = 0;
            _addNewSeason.hava_48_bot = 0;
            _addNewSeason.deniz_34_bot = 0;
            _addNewSeason.deniz_35_bot = 0;
            _addNewSeason.deniz_36_bot = 0;
            _addNewSeason.deniz_37_bot = 0;
            _addNewSeason.deniz_38_bot = 0;
            _addNewSeason.deniz_39_bot = 0;
            _addNewSeason.deniz_40_bot = 0;
            _addNewSeason.deniz_41_bot = 0;
            _addNewSeason.deniz_42_bot = 0;
            _addNewSeason.deniz_43_bot = 0;
            _addNewSeason.deniz_44_bot = 0;
            _addNewSeason.deniz_45_bot = 0;
            _addNewSeason.deniz_46_bot = 0;
            _addNewSeason.deniz_47_bot = 0;
            _addNewSeason.deniz_48_bot = 0;
            _addNewSeason.karatotalpant = 0;
            _addNewSeason.havatotalpant = 0;
            _addNewSeason.deniztotalpant = 0;
            _addNewSeason.kara_xs_pant = 0;
            _addNewSeason.kara_s_pant = 0;
            _addNewSeason.kara_m_pant = 0;
            _addNewSeason.kara_l_pant = 0;
            _addNewSeason.kara_xl_pant = 0;
            _addNewSeason.kara_2xl_pant = 0;
            _addNewSeason.kara_3xl_pant = 0;
            _addNewSeason.kara_bxl_pant = 0;
            _addNewSeason.hava_xs_pant = 0;
            _addNewSeason.hava_s_pant = 0;
            _addNewSeason.hava_m_pant = 0;
            _addNewSeason.hava_l_pant = 0;
            _addNewSeason.hava_xl_pant = 0;
            _addNewSeason.hava_2xl_pant = 0;
            _addNewSeason.hava_3xl_pant = 0;
            _addNewSeason.hava_bxl_pant = 0;
            _addNewSeason.deniz_xs_pant = 0;
            _addNewSeason.deniz_s_pant = 0;
            _addNewSeason.deniz_m_pant = 0;
            _addNewSeason.deniz_l_pant = 0;
            _addNewSeason.deniz_xl_pant = 0;
            _addNewSeason.deniz_2xl_pant = 0;
            _addNewSeason.deniz_3xl_pant = 0;
            _addNewSeason.deniz_bxl_pant = 0;
            _addNewSeason.karatotalhands = 0;
            _addNewSeason.havatotalhands = 0;
            _addNewSeason.deniztotalhands = 0;
            _addNewSeason.kara_xs_hands = 0;
            _addNewSeason.kara_s_hands = 0;
            _addNewSeason.kara_m_hands = 0;
            _addNewSeason.kara_l_hands = 0;
            _addNewSeason.kara_xl_hands = 0;
            _addNewSeason.kara_2xl_hands = 0;
            _addNewSeason.hava_xs_hands = 0;
            _addNewSeason.hava_s_hands = 0;
            _addNewSeason.hava_m_hands = 0;
            _addNewSeason.hava_l_hands = 0;
            _addNewSeason.hava_xl_hands = 0;
            _addNewSeason.hava_2xl_hands = 0;
            _addNewSeason.deniz_xs_hands = 0;
            _addNewSeason.deniz_s_hands = 0;
            _addNewSeason.deniz_m_hands = 0;
            _addNewSeason.deniz_l_hands = 0;
            _addNewSeason.deniz_xl_hands = 0;
            _addNewSeason.deniz_2xl_hands = 0;
            _addNewSeason.kara_140_150_boy = 0;
            _addNewSeason.kara_150_160_boy = 0;
            _addNewSeason.kara_160_170_boy = 0;
            _addNewSeason.kara_170_180_boy = 0;
            _addNewSeason.kara_180_190_boy = 0;
            _addNewSeason.kara_190_200_boy = 0;
            _addNewSeason.kara_200_210_boy = 0;
            _addNewSeason.kara_210_220_boy = 0;
            _addNewSeason.kara_220_230_boy = 0;
            _addNewSeason.hava_140_150_boy = 0;
            _addNewSeason.hava_150_160_boy = 0;
            _addNewSeason.hava_160_170_boy = 0;
            _addNewSeason.hava_170_180_boy = 0;
            _addNewSeason.hava_180_190_boy = 0;
            _addNewSeason.hava_190_200_boy = 0;
            _addNewSeason.hava_200_210_boy = 0;
            _addNewSeason.hava_210_220_boy = 0;
            _addNewSeason.hava_220_230_boy = 0;
            _addNewSeason.deniz_140_150_boy = 0;
            _addNewSeason.deniz_150_160_boy = 0;
            _addNewSeason.deniz_160_170_boy = 0;
            _addNewSeason.deniz_170_180_boy = 0;
            _addNewSeason.deniz_180_190_boy = 0;
            _addNewSeason.deniz_190_200_boy = 0;
            _addNewSeason.deniz_200_210_boy = 0;
            _addNewSeason.deniz_210_220_boy = 0;
            _addNewSeason.deniz_220_230_boy = 0;
            _addNewSeason.kara_140alti_uyluk = 0;
            _addNewSeason.kara_140_180_uyluk = 0;
            _addNewSeason.kara_180_220_uyluk = 0;
            _addNewSeason.kara_220_260_uyluk = 0;
            _addNewSeason.kara_260ustu_uyluk = 0;
            _addNewSeason.hava_140alti_uyluk = 0;
            _addNewSeason.hava_140_180_uyluk = 0;
            _addNewSeason.hava_180_220_uyluk = 0;
            _addNewSeason.hava_220_260_uyluk = 0;
            _addNewSeason.hava_260ustu_uyluk = 0;
            _addNewSeason.deniz_140alti_uyluk = 0;
            _addNewSeason.deniz_140_180_uyluk = 0;
            _addNewSeason.deniz_180_220_uyluk = 0;
            _addNewSeason.deniz_220_260_uyluk = 0;
            _addNewSeason.deniz_260ustu_uyluk = 0;

            _addNewSeason.YeniDonem(_addNewSeason);
        }

        private void btnDonemlerdetay_Click(object sender, EventArgs e)
        {
            cmbDonemlerdetay.Enabled = true;
            
            
                if (cmbDonemlerdetay.Text == "")
                {
                dtgMail.DataSource = _getSeasonsDetail.GetSeasons();
                    
                  
                    ColumnVisibleSearcher();
                    dtgMail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                }
                else
                {
                dtgMail.DataSource = _getSeasonsDetail.GetSeasons();
                    ColumnVisibleSearcher();
                    dtgMail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            btnDonemlerdetay.Enabled = false;
        }





        private void ColumnVisibleSearcher()
        {
            if (cmbDonemlerdetay.Text != "")
            {
                foreach (DataGridViewColumn i in
      dtgMail.Columns)
                {

                    string searcherfilter = dtgMail.Columns[i.DisplayIndex].HeaderText.ToString();
                    switch (searcherfilter)
                    {

                        case "donem":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "totalsoldier":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "karakuvvet":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "havakuvvet":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "denizkuvvet":
                            {
                                i.Visible = true;
                                break;
                            }
                        default:
                            {
                                i.Visible = false;
                                break;
                            }
                    }
                }
                this.dtgMail.Columns[cmbDonemlerdetay.Text].Visible = true;
                dtgMail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            else
            {

                foreach (DataGridViewColumn i in
      dtgMail.Columns)
                {

                    string searcherfilter = dtgMail.Columns[i.DisplayIndex].HeaderText.ToString();
                    switch (searcherfilter)
                    {
                        case "donem":
                            {
                                i.Visible = true;
                                break;
                            }

                        case "kara_l_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_m_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_s_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_xs_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniztotalpant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "havatotalpant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "karatotalpant":
                            {
                                i.Visible = true;
                                break;
                            }


                        case "deniz_48_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_47_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_46_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_45_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_44_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_43_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_42_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_41_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_40_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_39_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_38_bot":
                            {
                                i.Visible = true;
                                break;
                            }

                        case "deniz_37_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_36_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_35_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_34_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_48_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_47_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_46_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_45_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_44_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_43_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_42_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_41_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_40_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_39_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_38_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_37_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_36_bot":
                            {
                                i.Visible = true;
                                break;
                            }

                        case "hava_35_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_34_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_48_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_47_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_46_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_45_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_44_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_43_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_42_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_41_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_40_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_39_bot":
                            {
                                i.Visible = true;
                                break;
                            }


                        case "kara_38_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_37_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_36_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_35_bot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_34_bot":
                            {
                                i.Visible = true;
                                break;
                            }

                        case "deniztotalbot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "havatotalbot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "karatotalbot":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_2xl_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_xl_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_l_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_m_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_s_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_xs_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_xxl_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_2l_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_l_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_m_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_s_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_xs_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_2xl_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_xl_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_l_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_m_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_s_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_xs_chest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniztotalchest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "havatotalchest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "karatotalchest":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "havakuvvet":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "denizkuvvet":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "karakuvvet":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "totalsoldier":
                            {
                                i.Visible = true;
                                break;
                            }

                        case "karatotalhands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_bxl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_3xl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_2xl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_xl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_l_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_m_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_s_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_xs_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_bxl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_3xl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_2xl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_xl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_l_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_m_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_s_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_xs_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_bxl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_3xl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_2xl_pant":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_xl_pant":
                            {
                                i.Visible = true;
                                break;
                            }

                        case "hava_m_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_s_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_xs_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_2xl_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_xl_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_l_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_m_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_s_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "kara_xs_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniztotalhands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "havatotalhands":
                            {
                                i.Visible = true;
                                break;
                            }

                        case "deniz_2xl_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_xl_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_l_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_m_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_s_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "deniz_xs_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_2xl_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_xl_hands":
                            {
                                i.Visible = true;
                                break;
                            }
                        case "hava_l_hands":
                            {
                                i.Visible = true;
                                break;
                            }


                        default:
                            {
                                i.Visible = false;
                                break;
                            }

                    }
                    dtgMail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                }

            }


        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            rbtngraphic.Checked = false;
            rbtngraphicon.Checked = false;
            dtgMail.DataSource = _getSeasonsDetail.GetSeasons();
            ColumnVisibleSearcher();
     
           
            


        }

        

       

        private void dtgMail_SelectionChanged(object sender, EventArgs e)
        {


            if (dtgMail.SelectedRows != null && rbtngraphic.Checked==true)
                {
                    foreach (var series in karachestpie.Series)
                    {
                        
                 


                    series.Points.Clear();
                    karachestpie.Titles.Clear();
                }

                foreach (var series in havachestpie.Series)
                {




                    series.Points.Clear();
                    havachestpie.Titles.Clear();
                }


                foreach (var series in denizchestpie.Series)
                {



                    series.Points.Clear();
                    denizchestpie.Titles.Clear();
                }


                foreach (var series in karapantpie.Series)
                {






                    series.Points.Clear();
                    karapantpie.Titles.Clear();
                }


                foreach (var series in havapantpie.Series)
                {



                    series.Points.Clear();
                    havapantpie.Titles.Clear();
                }

                foreach (var series in denizpantpie.Series)
                {



                    series.Points.Clear();
                    denizpantpie.Titles.Clear();
                }


                foreach (var series in karahandspie.Series)
                {


                    series.Points.Clear();
                    karahandspie.Titles.Clear();
                }

                foreach (var series in havahandspie.Series)
                {




                    series.Points.Clear();
                    havahandspie.Titles.Clear();
                }


                foreach (var series in denizhandspie.Series)
                {



                    series.Points.Clear();
                    denizhandspie.Titles.Clear();
                }


                foreach (var series in karabotpie.Series)
                {



                    series.Points.Clear();
                    karabotpie.Titles.Clear();
                }


                foreach (var series in havabotpie.Series)
                {




                    series.Points.Clear();
                    havabotpie.Titles.Clear();
                }


                foreach (var series in denizbotpie.Series)
                {




                    series.Points.Clear();
                    denizbotpie.Titles.Clear();
                }

                foreach (var series in karaboypie.Series)
                {



                    series.Points.Clear();
                    karaboypie.Titles.Clear();
                }

                foreach (var series in havaboypie.Series)
                {


                    series.Points.Clear();
                    havaboypie.Titles.Clear();
                }


                foreach (var series in denizboypie.Series)
                {



                    series.Points.Clear();
                    denizboypie.Titles.Clear();
                }



                foreach (var series in karauylukpie.Series)
                {


                    series.Points.Clear();
                    karauylukpie.Titles.Clear();
                }


                foreach (var series in havauylukpie.Series)
                {



                    series.Points.Clear();
                    havauylukpie.Titles.Clear();
                }


                foreach (var series in denizuylukpie.Series)
                {




                    series.Points.Clear();
                    denizuylukpie.Titles.Clear();
                }


                karachestpie.Titles.Add("KK UstGiyim");

                karachestpie.Series["birlikkuvvet"].Points.AddXY("XS", dtgMail.CurrentRow.Cells[8].Value);
                karachestpie.Series["birlikkuvvet"].Points.AddXY("S", dtgMail.CurrentRow.Cells[9].Value);
                karachestpie.Series["birlikkuvvet"].Points.AddXY("M", dtgMail.CurrentRow.Cells[10].Value);
                karachestpie.Series["birlikkuvvet"].Points.AddXY("L", dtgMail.CurrentRow.Cells[11].Value);
                karachestpie.Series["birlikkuvvet"].Points.AddXY("XL", dtgMail.CurrentRow.Cells[12].Value);
                karachestpie.Series["birlikkuvvet"].Points.AddXY("2XL", dtgMail.CurrentRow.Cells[13].Value);


                havachestpie.Titles.Add("HK UstGiyim");

                havachestpie.Series["birlikkuvvet"].Points.AddXY("XS", dtgMail.CurrentRow.Cells[14].Value);
                havachestpie.Series["birlikkuvvet"].Points.AddXY("S", dtgMail.CurrentRow.Cells[15].Value);
                havachestpie.Series["birlikkuvvet"].Points.AddXY("M", dtgMail.CurrentRow.Cells[16].Value);
                havachestpie.Series["birlikkuvvet"].Points.AddXY("L", dtgMail.CurrentRow.Cells[17].Value);
                havachestpie.Series["birlikkuvvet"].Points.AddXY("XL", dtgMail.CurrentRow.Cells[18].Value);
                havachestpie.Series["birlikkuvvet"].Points.AddXY("2XL", dtgMail.CurrentRow.Cells[19].Value);


                denizchestpie.Titles.Add("DK UstGiyim");

                denizchestpie.Series["birlikkuvvet"].Points.AddXY("XS", dtgMail.CurrentRow.Cells[20].Value);
                denizchestpie.Series["birlikkuvvet"].Points.AddXY("S", dtgMail.CurrentRow.Cells[21].Value);
                denizchestpie.Series["birlikkuvvet"].Points.AddXY("M", dtgMail.CurrentRow.Cells[22].Value);
                denizchestpie.Series["birlikkuvvet"].Points.AddXY("L", dtgMail.CurrentRow.Cells[23].Value);
                denizchestpie.Series["birlikkuvvet"].Points.AddXY("XL", dtgMail.CurrentRow.Cells[24].Value);
                denizchestpie.Series["birlikkuvvet"].Points.AddXY("2XL", dtgMail.CurrentRow.Cells[25].Value);



                karapantpie.Titles.Add("KK Pantolon");

                karapantpie.Series["birlikkuvvet"].Points.AddXY("XS", dtgMail.CurrentRow.Cells[77].Value);
                karapantpie.Series["birlikkuvvet"].Points.AddXY("S", dtgMail.CurrentRow.Cells[78].Value);
                karapantpie.Series["birlikkuvvet"].Points.AddXY("M", dtgMail.CurrentRow.Cells[79].Value);
                karapantpie.Series["birlikkuvvet"].Points.AddXY("L", dtgMail.CurrentRow.Cells[80].Value);
                karapantpie.Series["birlikkuvvet"].Points.AddXY("XL", dtgMail.CurrentRow.Cells[81].Value);
                karapantpie.Series["birlikkuvvet"].Points.AddXY("2XL", dtgMail.CurrentRow.Cells[82].Value);
                karapantpie.Series["birlikkuvvet"].Points.AddXY("3XL", dtgMail.CurrentRow.Cells[83].Value);
                karapantpie.Series["birlikkuvvet"].Points.AddXY("BXL", dtgMail.CurrentRow.Cells[84].Value);


                havapantpie.Titles.Add("HK Pantolon");

                havapantpie.Series["birlikkuvvet"].Points.AddXY("XS", dtgMail.CurrentRow.Cells[85].Value);
                havapantpie.Series["birlikkuvvet"].Points.AddXY("S", dtgMail.CurrentRow.Cells[86].Value);
                havapantpie.Series["birlikkuvvet"].Points.AddXY("M", dtgMail.CurrentRow.Cells[87].Value);
                havapantpie.Series["birlikkuvvet"].Points.AddXY("L", dtgMail.CurrentRow.Cells[88].Value);
                havapantpie.Series["birlikkuvvet"].Points.AddXY("XL", dtgMail.CurrentRow.Cells[89].Value);
                havapantpie.Series["birlikkuvvet"].Points.AddXY("2XL", dtgMail.CurrentRow.Cells[90].Value);
                havapantpie.Series["birlikkuvvet"].Points.AddXY("3XL", dtgMail.CurrentRow.Cells[91].Value);
                havapantpie.Series["birlikkuvvet"].Points.AddXY("BXL", dtgMail.CurrentRow.Cells[92].Value);


                denizpantpie.Titles.Add("DK Pantolon");


                denizpantpie.Series["birlikkuvvet"].Points.AddXY("XS", dtgMail.CurrentRow.Cells[93].Value);
                denizpantpie.Series["birlikkuvvet"].Points.AddXY("S", dtgMail.CurrentRow.Cells[94].Value);
                denizpantpie.Series["birlikkuvvet"].Points.AddXY("M", dtgMail.CurrentRow.Cells[95].Value);
                denizpantpie.Series["birlikkuvvet"].Points.AddXY("L", dtgMail.CurrentRow.Cells[96].Value);
                denizpantpie.Series["birlikkuvvet"].Points.AddXY("XL", dtgMail.CurrentRow.Cells[97].Value);
                denizpantpie.Series["birlikkuvvet"].Points.AddXY("2XL", dtgMail.CurrentRow.Cells[98].Value);
                denizpantpie.Series["birlikkuvvet"].Points.AddXY("3XL", dtgMail.CurrentRow.Cells[99].Value);
                denizpantpie.Series["birlikkuvvet"].Points.AddXY("BXL", dtgMail.CurrentRow.Cells[100].Value);



                karahandspie.Titles.Add("KK Eldiven");


                karahandspie.Series["birlikkuvvet"].Points.AddXY("XS", dtgMail.CurrentRow.Cells[104].Value);
                karahandspie.Series["birlikkuvvet"].Points.AddXY("S", dtgMail.CurrentRow.Cells[105].Value);
                karahandspie.Series["birlikkuvvet"].Points.AddXY("M", dtgMail.CurrentRow.Cells[106].Value);
                karahandspie.Series["birlikkuvvet"].Points.AddXY("L", dtgMail.CurrentRow.Cells[107].Value);
                karahandspie.Series["birlikkuvvet"].Points.AddXY("XL", dtgMail.CurrentRow.Cells[108].Value);
                karahandspie.Series["birlikkuvvet"].Points.AddXY("2XL", dtgMail.CurrentRow.Cells[109].Value);

                havahandspie.Titles.Add("HK Eldiven");

                havahandspie.Series["birlikkuvvet"].Points.AddXY("XS", dtgMail.CurrentRow.Cells[110].Value);
                havahandspie.Series["birlikkuvvet"].Points.AddXY("S", dtgMail.CurrentRow.Cells[111].Value);
                havahandspie.Series["birlikkuvvet"].Points.AddXY("M", dtgMail.CurrentRow.Cells[112].Value);
                havahandspie.Series["birlikkuvvet"].Points.AddXY("L", dtgMail.CurrentRow.Cells[113].Value);
                havahandspie.Series["birlikkuvvet"].Points.AddXY("XL", dtgMail.CurrentRow.Cells[114].Value);
                havahandspie.Series["birlikkuvvet"].Points.AddXY("2XL", dtgMail.CurrentRow.Cells[115].Value);


                denizhandspie.Titles.Add("DK Eldiven");

                denizhandspie.Series["birlikkuvvet"].Points.AddXY("XS", dtgMail.CurrentRow.Cells[116].Value);
                denizhandspie.Series["birlikkuvvet"].Points.AddXY("S", dtgMail.CurrentRow.Cells[117].Value);
                denizhandspie.Series["birlikkuvvet"].Points.AddXY("M", dtgMail.CurrentRow.Cells[118].Value);
                denizhandspie.Series["birlikkuvvet"].Points.AddXY("L", dtgMail.CurrentRow.Cells[119].Value);
                denizhandspie.Series["birlikkuvvet"].Points.AddXY("XL", dtgMail.CurrentRow.Cells[120].Value);
                denizhandspie.Series["birlikkuvvet"].Points.AddXY("2XL", dtgMail.CurrentRow.Cells[121].Value);


                karabotpie.Titles.Add("KK Bot");

                karabotpie.Series["birlikkuvvet"].Points.AddXY("34", dtgMail.CurrentRow.Cells[29].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("35", dtgMail.CurrentRow.Cells[30].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("36", dtgMail.CurrentRow.Cells[31].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("37", dtgMail.CurrentRow.Cells[32].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("38", dtgMail.CurrentRow.Cells[33].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("39", dtgMail.CurrentRow.Cells[34].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("40", dtgMail.CurrentRow.Cells[35].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("41", dtgMail.CurrentRow.Cells[36].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("42", dtgMail.CurrentRow.Cells[37].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("43", dtgMail.CurrentRow.Cells[38].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("44", dtgMail.CurrentRow.Cells[39].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("45", dtgMail.CurrentRow.Cells[40].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("46", dtgMail.CurrentRow.Cells[41].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("47", dtgMail.CurrentRow.Cells[42].Value);
                karabotpie.Series["birlikkuvvet"].Points.AddXY("48", dtgMail.CurrentRow.Cells[43].Value);


                havabotpie.Titles.Add("HK Bot");

                havabotpie.Series["birlikkuvvet"].Points.AddXY("34", dtgMail.CurrentRow.Cells[44].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("35", dtgMail.CurrentRow.Cells[45].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("36", dtgMail.CurrentRow.Cells[46].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("37", dtgMail.CurrentRow.Cells[47].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("38", dtgMail.CurrentRow.Cells[48].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("39", dtgMail.CurrentRow.Cells[49].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("40", dtgMail.CurrentRow.Cells[50].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("41", dtgMail.CurrentRow.Cells[51].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("42", dtgMail.CurrentRow.Cells[52].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("43", dtgMail.CurrentRow.Cells[53].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("44", dtgMail.CurrentRow.Cells[54].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("45", dtgMail.CurrentRow.Cells[55].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("46", dtgMail.CurrentRow.Cells[56].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("47", dtgMail.CurrentRow.Cells[57].Value);
                havabotpie.Series["birlikkuvvet"].Points.AddXY("48", dtgMail.CurrentRow.Cells[58].Value);



                denizbotpie.Titles.Add("DK Bot");

                denizbotpie.Series["birlikkuvvet"].Points.AddXY("34", dtgMail.CurrentRow.Cells[59].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("35", dtgMail.CurrentRow.Cells[60].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("36", dtgMail.CurrentRow.Cells[61].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("37", dtgMail.CurrentRow.Cells[62].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("38", dtgMail.CurrentRow.Cells[63].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("39", dtgMail.CurrentRow.Cells[64].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("40", dtgMail.CurrentRow.Cells[65].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("41", dtgMail.CurrentRow.Cells[66].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("42", dtgMail.CurrentRow.Cells[67].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("43", dtgMail.CurrentRow.Cells[68].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("44", dtgMail.CurrentRow.Cells[69].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("45", dtgMail.CurrentRow.Cells[70].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("46", dtgMail.CurrentRow.Cells[71].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("47", dtgMail.CurrentRow.Cells[72].Value);
                denizbotpie.Series["birlikkuvvet"].Points.AddXY("48", dtgMail.CurrentRow.Cells[73].Value);


                karaboypie.Titles.Add("KK Boy");

                karaboypie.Series["birlikkuvvet"].Points.AddXY("1.40-1.50", dtgMail.CurrentRow.Cells[122].Value);
                karaboypie.Series["birlikkuvvet"].Points.AddXY("1.50-1.60", dtgMail.CurrentRow.Cells[123].Value);
                karaboypie.Series["birlikkuvvet"].Points.AddXY("1.60-1.70", dtgMail.CurrentRow.Cells[124].Value);
                karaboypie.Series["birlikkuvvet"].Points.AddXY("1.70-1.80", dtgMail.CurrentRow.Cells[125].Value);
                karaboypie.Series["birlikkuvvet"].Points.AddXY("1.80-1.90", dtgMail.CurrentRow.Cells[126].Value);
                karaboypie.Series["birlikkuvvet"].Points.AddXY("1.90-2.00", dtgMail.CurrentRow.Cells[127].Value);
                karaboypie.Series["birlikkuvvet"].Points.AddXY("2.00-2.10", dtgMail.CurrentRow.Cells[128].Value);
                karaboypie.Series["birlikkuvvet"].Points.AddXY("2.10-2.20", dtgMail.CurrentRow.Cells[129].Value);
                karaboypie.Series["birlikkuvvet"].Points.AddXY("2.20-2.30", dtgMail.CurrentRow.Cells[130].Value);



                havaboypie.Titles.Add("HK Boy");

                havaboypie.Series["birlikkuvvet"].Points.AddXY("1.40-1.50", dtgMail.CurrentRow.Cells[131].Value);
                havaboypie.Series["birlikkuvvet"].Points.AddXY("1.50-1.60", dtgMail.CurrentRow.Cells[132].Value);
                havaboypie.Series["birlikkuvvet"].Points.AddXY("1.60-1.70", dtgMail.CurrentRow.Cells[133].Value);
                havaboypie.Series["birlikkuvvet"].Points.AddXY("1.70-1.80", dtgMail.CurrentRow.Cells[134].Value);
                havaboypie.Series["birlikkuvvet"].Points.AddXY("1.80-1.90", dtgMail.CurrentRow.Cells[135].Value);
                havaboypie.Series["birlikkuvvet"].Points.AddXY("1.90-2.00", dtgMail.CurrentRow.Cells[136].Value);
                havaboypie.Series["birlikkuvvet"].Points.AddXY("2.00-2.10", dtgMail.CurrentRow.Cells[137].Value);
                havaboypie.Series["birlikkuvvet"].Points.AddXY("2.10-2.20", dtgMail.CurrentRow.Cells[138].Value);
                havaboypie.Series["birlikkuvvet"].Points.AddXY("2.20-2.30", dtgMail.CurrentRow.Cells[139].Value);


                denizboypie.Titles.Add("DK Boy");

                denizboypie.Series["birlikkuvvet"].Points.AddXY("1.40-1.50", dtgMail.CurrentRow.Cells[140].Value);
                denizboypie.Series["birlikkuvvet"].Points.AddXY("1.50-1.60", dtgMail.CurrentRow.Cells[141].Value);
                denizboypie.Series["birlikkuvvet"].Points.AddXY("1.60-1.70", dtgMail.CurrentRow.Cells[142].Value);
                denizboypie.Series["birlikkuvvet"].Points.AddXY("1.70-1.80", dtgMail.CurrentRow.Cells[143].Value);
                denizboypie.Series["birlikkuvvet"].Points.AddXY("1.80-1.90", dtgMail.CurrentRow.Cells[144].Value);
                denizboypie.Series["birlikkuvvet"].Points.AddXY("1.90-2.00", dtgMail.CurrentRow.Cells[145].Value);
                denizboypie.Series["birlikkuvvet"].Points.AddXY("2.00-2.10", dtgMail.CurrentRow.Cells[146].Value);
                denizboypie.Series["birlikkuvvet"].Points.AddXY("2.10-2.20", dtgMail.CurrentRow.Cells[147].Value);
                denizboypie.Series["birlikkuvvet"].Points.AddXY("2.20-2.30", dtgMail.CurrentRow.Cells[148].Value);


                karauylukpie.Titles.Add("KK Uyluk");

                karauylukpie.Series["birlikkuvvet"].Points.AddXY("<140", dtgMail.CurrentRow.Cells[149].Value);
                karauylukpie.Series["birlikkuvvet"].Points.AddXY("140-180", dtgMail.CurrentRow.Cells[150].Value);
                karauylukpie.Series["birlikkuvvet"].Points.AddXY("180-220", dtgMail.CurrentRow.Cells[151].Value);
                karauylukpie.Series["birlikkuvvet"].Points.AddXY("220-260", dtgMail.CurrentRow.Cells[152].Value);
                karauylukpie.Series["birlikkuvvet"].Points.AddXY(">260", dtgMail.CurrentRow.Cells[153].Value);

                havauylukpie.Titles.Add("HK Uyluk");

                havauylukpie.Series["birlikkuvvet"].Points.AddXY("<140", dtgMail.CurrentRow.Cells[154].Value);
                havauylukpie.Series["birlikkuvvet"].Points.AddXY("140-180", dtgMail.CurrentRow.Cells[155].Value);
                havauylukpie.Series["birlikkuvvet"].Points.AddXY("180-220", dtgMail.CurrentRow.Cells[156].Value);
                havauylukpie.Series["birlikkuvvet"].Points.AddXY("220-260", dtgMail.CurrentRow.Cells[157].Value);
                havauylukpie.Series["birlikkuvvet"].Points.AddXY(">260", dtgMail.CurrentRow.Cells[158].Value);


                denizuylukpie.Titles.Add("DK Uyluk");

                denizuylukpie.Series["birlikkuvvet"].Points.AddXY("<140", dtgMail.CurrentRow.Cells[159].Value);
                denizuylukpie.Series["birlikkuvvet"].Points.AddXY("140-180", dtgMail.CurrentRow.Cells[160].Value);
                denizuylukpie.Series["birlikkuvvet"].Points.AddXY("180-220", dtgMail.CurrentRow.Cells[161].Value);
                denizuylukpie.Series["birlikkuvvet"].Points.AddXY("220-260", dtgMail.CurrentRow.Cells[162].Value);
                denizuylukpie.Series["birlikkuvvet"].Points.AddXY(">260", dtgMail.CurrentRow.Cells[163].Value);

             
            }


            btnDonemlerdetay.Enabled = true;
           
          
        }

        private void rbtny1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtny1.Checked==true)
            {

                rbtny2.Checked = false;
                rbtny3.Checked = false;
                pboxkaraci.Visible = true;
                pboxhavaci.Visible = false;
                pboxdenizci.Visible = false;
                karaboypie.Visible = true;
                karachestpie.Visible = true;
                karahandspie.Visible = true;
                karapantpie.Visible = true;
                karauylukpie.Visible = true;
                karabotpie.Visible = true;
                havaboypie.Visible = false;
                havachestpie.Visible = false;
                havahandspie.Visible = false;
                havapantpie.Visible = false;
                havauylukpie.Visible = false;
                havabotpie.Visible = false;
                denizboypie.Visible = false;
                denizchestpie.Visible = false;
                denizhandspie.Visible = false;
                denizpantpie.Visible = false;
                denizuylukpie.Visible = false;
                denizbotpie.Visible = false;


            }
            else
            {

                pboxkaraci.Visible = false;
                karaboypie.Visible = false;
                karachestpie.Visible = false;
                karahandspie.Visible = false;
                karapantpie.Visible = false;
                karauylukpie.Visible = false;
                karabotpie.Visible = false;

            }
        }

        private void rbtngraphicon_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void rbtnx1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void rbtnx2_CheckedChanged(object sender, EventArgs e)
        {
        
           
        }

        private void rbtnx3_CheckedChanged(object sender, EventArgs e)
        {
         
           
        }

        private void rbtnx4_CheckedChanged(object sender, EventArgs e)
        {
         
          
        }

        private void rbtnx5_CheckedChanged(object sender, EventArgs e)
        {
          
           
        }

        private void rbtnx6_CheckedChanged(object sender, EventArgs e)
        {

            
            
        }

        private void rbtny2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtny2.Checked == true)
            {
                rbtny1.Checked = false;
                rbtny3.Checked = false;
                pboxhavaci.Visible = true;
                pboxdenizci.Visible = false;
                pboxkaraci.Visible = false;
                havaboypie.Visible = true;
                havachestpie.Visible = true;
                havahandspie.Visible = true;
                havapantpie.Visible = true;
                havauylukpie.Visible = true;
                havabotpie.Visible = true;

             
                karaboypie.Visible = false;
                karachestpie.Visible = false;
                karahandspie.Visible = false;
                karapantpie.Visible = false;
                karauylukpie.Visible = false;
                karabotpie.Visible = false;


               
                denizboypie.Visible = false;
                denizchestpie.Visible = false;
                denizhandspie.Visible = false;
                denizpantpie.Visible = false;
                denizuylukpie.Visible = false;
                denizbotpie.Visible = false;


            }
            else
            {
                pboxhavaci.Visible = false;
                havaboypie.Visible = false;
                havachestpie.Visible = false;
                havahandspie.Visible = false;
                havapantpie.Visible = false;
                havauylukpie.Visible = false;
                havabotpie.Visible = false;

            }
        }

        private void rbtny3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtny3.Checked == true)
            {
                rbtny1.Checked = false;
                rbtny2.Checked = false;
                pboxdenizci.Visible = true;
                denizboypie.Visible = true;
                denizchestpie.Visible = true;
                denizhandspie.Visible = true;
                denizpantpie.Visible = true;
                denizuylukpie.Visible = true;
                denizbotpie.Visible = true;


                pboxhavaci.Visible = false;
                havaboypie.Visible = false;
                havachestpie.Visible = false;
                havahandspie.Visible = false;
                havapantpie.Visible = false;
                havauylukpie.Visible = false;
                havabotpie.Visible = false;



                pboxkaraci.Visible = false;
                karaboypie.Visible = false;
                karachestpie.Visible = false;
                karahandspie.Visible = false;
                karapantpie.Visible = false;
                karauylukpie.Visible = false;
                karabotpie.Visible = false;


            }
            else
            {
                pboxdenizci.Visible = false;
                denizboypie.Visible = false;
                denizchestpie.Visible = false;
                denizhandspie.Visible = false;
                denizpantpie.Visible = false;
                denizuylukpie.Visible = false;
                denizbotpie.Visible = false;

            }
        }

        private void pnldenizdash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmailci_Click(object sender, EventArgs e)
        {
            _postman.totalsoldier= Convert.ToInt32(dtgMail.CurrentRow.Cells[1].Value);

            _postman.denizkuvvet =Convert.ToInt32(dtgMail.CurrentRow.Cells[3].Value);
            _postman.karakuvvet = Convert.ToInt32(dtgMail.CurrentRow.Cells[2].Value);
            _postman.havakuvvet = Convert.ToInt32(dtgMail.CurrentRow.Cells[4].Value);

            _postman.karatotalchest = Convert.ToInt32(dtgMail.CurrentRow.Cells[5].Value);
            _postman.havatotalchest = Convert.ToInt32(dtgMail.CurrentRow.Cells[6].Value);
            _postman.deniztotalchest = Convert.ToInt32(dtgMail.CurrentRow.Cells[7].Value);

            _postman.karatotalpant = Convert.ToInt32(dtgMail.CurrentRow.Cells[74].Value);  
            _postman.havatotalpant = Convert.ToInt32(dtgMail.CurrentRow.Cells[75].Value);
            _postman.deniztotalpant = Convert.ToInt32(dtgMail.CurrentRow.Cells[76].Value);

            _postman.karatotalhands = Convert.ToInt32(dtgMail.CurrentRow.Cells[101].Value);        
            _postman.havatotalhands = Convert.ToInt32(dtgMail.CurrentRow.Cells[102].Value);
            _postman.deniztotalhands = Convert.ToInt32(dtgMail.CurrentRow.Cells[103].Value);

            _postman.karatotalbot = Convert.ToInt32(dtgMail.CurrentRow.Cells[26].Value);
            _postman.havatotalbot = Convert.ToInt32(dtgMail.CurrentRow.Cells[27].Value);
            _postman.deniztotalbot = Convert.ToInt32(dtgMail.CurrentRow.Cells[28].Value);

            _postman.kara_xs_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[8].Value);
            _postman.kara_s_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[9].Value);
            _postman.kara_m_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[10].Value);
            _postman.kara_l_chest= Convert.ToInt32(dtgMail.CurrentRow.Cells[11].Value);
            _postman.kara_xl_chest= Convert.ToInt32(dtgMail.CurrentRow.Cells[12].Value);
            _postman.kara_2xl_chest= Convert.ToInt32(dtgMail.CurrentRow.Cells[13].Value);

            _postman.hava_xs_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[14].Value);
            _postman.hava_s_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[15].Value);
            _postman.hava_m_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[16].Value);
            _postman.hava_l_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[17].Value);
            _postman.hava_2l_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[18].Value);
            _postman.hava_xxl_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[19].Value);

            _postman.deniz_xs_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[20].Value);
            _postman.deniz_s_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[21].Value);
            _postman.deniz_m_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[22].Value);
            _postman.deniz_l_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[23].Value);
            _postman.deniz_xl_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[24].Value);
            _postman.deniz_2xl_chest = Convert.ToInt32(dtgMail.CurrentRow.Cells[25].Value);


            _postman.kara_xs_pant=Convert.ToInt32(dtgMail.CurrentRow.Cells[77].Value);
            _postman.kara_s_pant= Convert.ToInt32(dtgMail.CurrentRow.Cells[78].Value);
            _postman.kara_m_pant= Convert.ToInt32(dtgMail.CurrentRow.Cells[79].Value);
            _postman.kara_l_pant= Convert.ToInt32(dtgMail.CurrentRow.Cells[80].Value);
            _postman.kara_xl_pant=Convert.ToInt32(dtgMail.CurrentRow.Cells[81].Value);
            _postman.kara_2xl_pant= Convert.ToInt32(dtgMail.CurrentRow.Cells[82].Value);
            _postman.kara_3xl_pant=Convert.ToInt32(dtgMail.CurrentRow.Cells[83].Value);
            _postman.kara_bxl_pant= Convert.ToInt32(dtgMail.CurrentRow.Cells[84].Value);

            _postman.hava_xs_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[85].Value);
            _postman.hava_s_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[86].Value);
            _postman.hava_m_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[87].Value);
            _postman.hava_l_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[88].Value);
            _postman.hava_xl_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[89].Value);
            _postman.hava_2xl_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[90].Value);
            _postman.hava_3xl_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[91].Value);
            _postman.hava_bxl_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[92].Value);


            _postman.deniz_xs_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[93].Value);
            _postman.deniz_s_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[94].Value);
            _postman.deniz_m_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[95].Value);
            _postman.deniz_l_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[96].Value);
            _postman.deniz_xl_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[97].Value);
            _postman.deniz_2xl_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[98].Value);
            _postman.deniz_3xl_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[99].Value);
            _postman.deniz_bxl_pant = Convert.ToInt32(dtgMail.CurrentRow.Cells[100].Value);

            _postman.kara_xs_hands= Convert.ToInt32(dtgMail.CurrentRow.Cells[101].Value);
            _postman.kara_s_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[102].Value);
            _postman.kara_m_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[103].Value);
            _postman.kara_l_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[104].Value);
            _postman.kara_xl_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[105].Value);
            _postman.kara_2xl_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[106].Value);

            _postman.hava_xs_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[107].Value);
            _postman.hava_s_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[108].Value);
            _postman.hava_m_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[109].Value);
            _postman.hava_l_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[110].Value);
            _postman.hava_xl_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[111].Value);
            _postman.hava_2xl_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[112].Value);

            _postman.deniz_xs_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[113].Value);
            _postman.deniz_s_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[114].Value);
            _postman.deniz_m_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[115].Value);
            _postman.deniz_l_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[116].Value);
            _postman.deniz_xl_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[117].Value);
            _postman.deniz_2xl_hands = Convert.ToInt32(dtgMail.CurrentRow.Cells[118].Value);

            _postman.kara_34_bot= Convert.ToInt32(dtgMail.CurrentRow.Cells[29].Value);
            _postman.kara_35_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[30].Value);
            _postman.kara_36_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[31].Value);
            _postman.kara_37_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[32].Value);
            _postman.kara_38_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[33].Value);
            _postman.kara_39_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[34].Value);
            _postman.kara_40_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[35].Value);
            _postman.kara_41_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[36].Value);
            _postman.kara_42_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[37].Value);
            _postman.kara_43_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[38].Value);
            _postman.kara_44_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[39].Value);
            _postman.kara_45_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[40].Value);
            _postman.kara_46_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[41].Value);
            _postman.kara_47_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[42].Value);
            _postman.kara_48_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[43].Value);

            _postman.hava_34_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[44].Value);
            _postman.hava_35_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[45].Value);
            _postman.hava_36_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[46].Value);
            _postman.hava_37_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[47].Value);
            _postman.hava_38_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[48].Value);
            _postman.hava_39_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[49].Value);
            _postman.hava_40_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[50].Value);
            _postman.hava_41_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[51].Value);
            _postman.hava_42_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[52].Value);
            _postman.hava_43_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[53].Value);
            _postman.hava_44_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[54].Value);
            _postman.hava_45_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[55].Value);
            _postman.hava_46_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[56].Value);
            _postman.hava_47_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[57].Value);
            _postman.hava_48_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[58].Value);


            _postman.deniz_34_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[59].Value);
            _postman.deniz_35_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[60].Value);
            _postman.deniz_36_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[61].Value);
            _postman.deniz_37_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[62].Value);
            _postman.deniz_38_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[63].Value);
            _postman.deniz_39_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[64].Value);
            _postman.deniz_40_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[65].Value);
            _postman.deniz_41_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[66].Value);
            _postman.deniz_42_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[67].Value);
            _postman.deniz_43_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[68].Value);
            _postman.deniz_44_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[69].Value);
            _postman.deniz_45_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[70].Value);
            _postman.deniz_46_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[71].Value);
            _postman.deniz_47_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[72].Value);
            _postman.deniz_48_bot = Convert.ToInt32(dtgMail.CurrentRow.Cells[73].Value);


            _postman.Getmessagestodikimevi();
            _postman.Getmessagestobirlikler();
            

        }

      
    }


}
