using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TezAPPV2.Model;
using TezAPPV2.SqlOperations;
using TezAPPV2.Entities;

using System.Data.SqlClient;
namespace TezAPPV2.Forms
{
    public partial class FormIDFinderBasicS : Form
    {
        public FormIDFinderBasicS()
        {
            
            InitializeComponent();
        }
        StandartDataInfo _measur = new StandartDataInfo();
        
        GetShortData _getShortData = new GetShortData();
        GetStandart _getStandart = new GetStandart();
        DeleteThePerson _deleteThePerson = new DeleteThePerson();
        LoadThePerson _loadThePerson = new LoadThePerson();
        


        private void LabelEffectBasic_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl.Location.X%5==0)
            {
                lbl.Font = new Font("Century Gothic", 10);
                lbl.Cursor = Cursors.Arrow;
                lbl.Location = new Point(lbl.Location.X - 3, lbl.Location.Y - 20);
                foreach (Control txt in pnlBasicTop.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txt" + lbl.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }
        
        

        private void Yukle(string ara = "")
        {
            //dtgList.DataSource = _getStandart.Get();
            if (ara == "")
            {


                dtgBasic.DataSource = _getShortData.ShortGet();
                
                //ColumnVisible();
               

                //dtgBasic.Dock = DockStyle.Fill;
            }
            else
            {
                
                if (comboBasic.Text=="ID No")
                {
                    _getStandart.Choosecmb = "Id";
                }
                else if (comboBasic.Text == "TC Kimlik No")
                {
                    _getStandart.Choosecmb = "Tc";
                }
                else if (comboBasic.Text=="Ad")
                {
                    _getStandart.Choosecmb = "Ad";

                }
                else if (comboBasic.Text == "Soyad")
                {
                    _getStandart.Choosecmb = "Soyad";
                }
                else if (comboBasic.Text=="A77")
                {
                    _getStandart.Choosecmb = "A77";
                }
                else if (comboBasic.Text=="A87")
                {
                    _getStandart.Choosecmb = "A87";
                }
                else if(comboBasic.Text=="A8")
                {
                    _getStandart.Choosecmb = "A8";
                }

              
                dtgBasic.DataSource = _getStandart.Get(ara);


            }
        }

        private void ColumnVisible()
        {

            foreach (DataGridViewColumn i in
       dtgBasic.Columns)
            {
                i.Visible = false;
            }

            
            this.dtgBasic.Columns["Id"].Visible = true;
            this.dtgBasic.Columns["Tc"].Visible = true;
             this.dtgBasic.Columns["Ad"].Visible = true;
            this.dtgBasic.Columns["Soyad"].Visible = true;
             this.dtgBasic.Columns["A77"].Visible = true;
             this.dtgBasic.Columns["A87"].Visible = true;
            this.dtgBasic.Columns["A8"].Visible = true;
           
           
            
          

        }

        private void TextBoxBasic_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pnlBasicTop.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.DodgerBlue;

                }

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.DodgerBlue;
                    if (ctrl.Location.X%5==0)
                    {
                        ctrl.Font = new Font("Century Gothic", 10);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 20);
                    }
                }
            }

        }


        private void TextBoxBasic_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pnlBasicTop.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.Gainsboro;

                }

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.Gainsboro;
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        ctrl.Font = new Font("Century Gothic", 13);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X + 3, ctrl.Location.Y + 20);
                    }
                }
            }
        }

        private void txtNmbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        public void ClearTextBoxes(Control parent)
        {

            foreach (Control child in parent.Controls)
            {
                if (child is TextBox)
                {
                    (child as TextBox).Text = "";



                } 
                else
                {
                    ClearTextBoxes(child);
                }

                


            }

            this.Refresh();
        }

       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlBasicTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBasicDelete_Click(object sender, EventArgs e)
        {
            _getShortData.Id = Convert.ToInt32(dtgBasic.CurrentRow.Cells[0].Value);
            _deleteThePerson.DeletePerson(_deleteThePerson); 
            Yukle(txtSearcher.Text);
            MessageBox.Show("Kayıt Silindi");
            btnBasicDelete.Enabled = false;
            btnBasicUpdate.Enabled = false;

           



        }

        private void btnBasicClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(pnlBasicTop);

        }

        private void FormIDFinderBasicS_Load(object sender, EventArgs e)
        {

            btnBasicDelete.Enabled = false;
            btnBasicUpdate.Enabled = false;
            Yukle();

        }

        private void txtSearcher_TextChanged(object sender, EventArgs e)
        {
            Yukle(txtSearcher.Text);
            btnBasicDelete.Enabled = false;
            btnBasicUpdate.Enabled = false;
        }

        private void comboBasic_SelectedValueChanged(object sender, EventArgs e)
        {
            Yukle(txtSearcher.Text);
        }

        private void btnBasicUpdate_Click(object sender, EventArgs e)
        {


            if (lblBasicID.Text!="" &&txtBasicAd.Text != "" && txtBasicSoyad.Text != "" && txtBasicTc.Text != "" && txtBasicA77.Text != "" && txtBasicA8.Text != "" && txtBasicA87.Text != "")
            
            {
                btnBasicDelete.Enabled = false;
                _getStandart.Id = Convert.ToInt32(dtgBasic.CurrentRow.Cells[0].Value);
                _getStandart.Tc = txtBasicTc.Text;
                _getStandart.Ad = txtBasicAd.Text;
                _getStandart.Soyad = txtBasicSoyad.Text;
                _getStandart.A77 = Convert.ToInt16(txtBasicA77.Text);
                _getStandart.A87 = Convert.ToInt16(txtBasicA87.Text);
                _getStandart.A8 = Convert.ToInt16(txtBasicA8.Text);

                _getStandart.A2Trium = Convert.ToInt16(-45.101775 + 0.918255 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A3Trium = Convert.ToInt16(-16.792604 + 0.987023 * Convert.ToDouble(txtBasicA77.Text) + 0.043370 * Convert.ToDouble(txtBasicA77.Text) + 0.116696 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A6Trium = Convert.ToInt16(-25.596371 + 0.961065 * Convert.ToDouble(txtBasicA77.Text) + -0.143448 * Convert.ToDouble(txtBasicA87.Text) + 0.094185 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A23Trium = Convert.ToInt16(49.888267 + 0.994674 * Convert.ToDouble(txtBasicA77.Text) + -0.022369 * Convert.ToDouble(txtBasicA87.Text) + 0.217901 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A27Trium = Convert.ToInt16(12.608033 + 0.881134 * Convert.ToDouble(txtBasicA77.Text) + -0.147747 * Convert.ToDouble(txtBasicA87.Text) + 0.294365 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A53Trium = Convert.ToInt16(-64.100029 + 0.761457 * Convert.ToDouble(txtBasicA77.Text) + -0.197303 * Convert.ToDouble(txtBasicA87.Text) + 0.471347 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A78Trium = Convert.ToInt16(-77.463677 + 0.754171 * Convert.ToDouble(txtBasicA77.Text) + -0.072149 * Convert.ToDouble(txtBasicA87.Text) + 0.680516 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A76Trium = Convert.ToInt16(178.973024 + 1.100870 * Convert.ToDouble(txtBasicA77.Text) + -0.110327 * Convert.ToDouble(txtBasicA87.Text) + 0.147082 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A58Trium = Convert.ToInt16(-61.520425 + 0.365502 * Convert.ToDouble(txtBasicA77.Text) + 0.447251 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A4Trium = Convert.ToInt16(-0.226398 + 0.211667 * Convert.ToDouble(txtBasicA77.Text) + 0.154119 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A19Trium = Convert.ToInt16(-104.563971 + 0.630994 * Convert.ToDouble(txtBasicA77.Text) + -0.211202 * Convert.ToDouble(txtBasicA87.Text) + 0.764583 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A59Trium = Convert.ToInt16(-59.822252 + 0.340544 * Convert.ToDouble(txtBasicA77.Text) + -0.082402 * Convert.ToDouble(txtBasicA87.Text) + 0.440318 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A70Trium = Convert.ToInt16(11.255298 + 0.233635 * Convert.ToDouble(txtBasicA77.Text) + -0.036070 * Convert.ToDouble(txtBasicA87.Text) + 0.139968 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A74Trium = Convert.ToInt16(-12.349681 + 0.343589 * Convert.ToDouble(txtBasicA77.Text) + 0.553360 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A91Trium = Convert.ToInt16(-46.524266 + 0.776548 * Convert.ToDouble(txtBasicA77.Text) + -0.352021 * Convert.ToDouble(txtBasicA87.Text) + 0.501591 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A35Trium = Convert.ToInt16(263.277758 + 0.436220 * Convert.ToDouble(txtBasicA77.Text) + 0.064016 * Convert.ToDouble(txtBasicA87.Text) + -0.533529 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A28Trium = Convert.ToInt16(-102.280483 + 0.622898 * Convert.ToDouble(txtBasicA77.Text) + -0.282288 * Convert.ToDouble(txtBasicA87.Text) + 0.717959 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A57Trium = Convert.ToInt16(-83.258033 + 0.346940 * Convert.ToDouble(txtBasicA77.Text) + -0.072620 * Convert.ToDouble(txtBasicA87.Text) + 0.478991 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A67Trium = Convert.ToInt16(-59.441407 + 0.334051 * Convert.ToDouble(txtBasicA77.Text) + -0.193591 * Convert.ToDouble(txtBasicA87.Text) + 0.357713 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A82Trium = Convert.ToInt16(-83.460238 + 0.370562 * Convert.ToDouble(txtBasicA77.Text) + -0.065726 * Convert.ToDouble(txtBasicA87.Text) + 0.199244 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A84Trium = Convert.ToInt16(-95.121944 + 0.672353 * Convert.ToDouble(txtBasicA77.Text) + -0.225910 * Convert.ToDouble(txtBasicA87.Text) + 0.510395 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A68Trium = Convert.ToInt16(-12.350114 + 0.137748 * Convert.ToDouble(txtBasicA77.Text) + 0.408437 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A72Trium = Convert.ToInt16(326.721718 + 0.460583 * Convert.ToDouble(txtBasicA77.Text) + 0.065512 * Convert.ToDouble(txtBasicA87.Text) + -0.459889 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A51Trium = Convert.ToInt16(54.850425 + 0.047806 * Convert.ToDouble(txtBasicA77.Text) + 0.550016 * Convert.ToDouble(txtBasicA87.Text) + 0.211832 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A44Trium = Convert.ToInt16(78.017335 + 0.031662 * Convert.ToDouble(txtBasicA77.Text) + 0.079454 * Convert.ToDouble(txtBasicA87.Text) + 0.312442 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A52Trium = Convert.ToInt16(22.165516 + 0.051973 * Convert.ToDouble(txtBasicA77.Text) + 0.700181 * Convert.ToDouble(txtBasicA87.Text) + 0.267744 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A9Trium = Convert.ToInt16(147.667082 + 0.096545 * Convert.ToDouble(txtBasicA77.Text) + 0.142044 * Convert.ToDouble(txtBasicA87.Text) + 0.411829 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A79Trium = Convert.ToInt16(54.375209 + -0.031790 * Convert.ToDouble(txtBasicA77.Text) + 1.335470 * Convert.ToDouble(txtBasicA87.Text) + 0.898565 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A71Trium = Convert.ToInt16(48.866557 + 0.061390 * Convert.ToDouble(txtBasicA77.Text) + -0.023408 * Convert.ToDouble(txtBasicA87.Text) + 0.100708 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A85Trium = Convert.ToInt16(250.729955 + 0.598313 * Convert.ToDouble(txtBasicA77.Text) + 1.695107 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A30Trium = Convert.ToInt16(88.740184 + 0.224249 * Convert.ToDouble(txtBasicA77.Text) + 0.139455 * Convert.ToDouble(txtBasicA87.Text) + -0.502395 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A88Trium = Convert.ToInt16(-64.607488 + 3.079259 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A43Trium = Convert.ToInt16(31.700846 + 0.0136011 * Convert.ToDouble(txtBasicA77.Text) + 0.0282693739 * Convert.ToDouble(txtBasicA87.Text) + 0.1381835 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A89Trium = Convert.ToInt16(-45.331941 + 0.867252 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A12Trium = Convert.ToInt16(162.445118 + 0.023838 * Convert.ToDouble(txtBasicA77.Text) + 0.687638 * Convert.ToDouble(txtBasicA87.Text) + 0.444005 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A17Trium = Convert.ToInt16(131.020548 + 0.064154 * Convert.ToDouble(txtBasicA77.Text) + 1.830446 * Convert.ToDouble(txtBasicA87.Text) + 0.988782 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A29Trium = Convert.ToInt16(80.639868 + 0.213828 * Convert.ToDouble(txtBasicA77.Text) + 0.717112 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A61Trium = Convert.ToInt16(67.735245 + 0.655908 * Convert.ToDouble(txtBasicA87.Text) + 0.634233 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A22Trium = Convert.ToInt16(107.431549 + -0.029235 * Convert.ToDouble(txtBasicA77.Text) + 0.569322 * Convert.ToDouble(txtBasicA87.Text) + 0.701913 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A5Trium = Convert.ToInt16(62.795146 + 0.212295 * Convert.ToDouble(txtBasicA87.Text) + 0.483976 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A80Trium = Convert.ToInt16(40.126905 + 0.303287 * Convert.ToDouble(txtBasicA87.Text) + 0.205684 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A93Trium = Convert.ToInt16(51.217317 + 0.032278 * Convert.ToDouble(txtBasicA77.Text) + 0.108286 * Convert.ToDouble(txtBasicA87.Text) + 0.213584 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A56Trium = Convert.ToInt16(181.550507 + 0.045307 * Convert.ToDouble(txtBasicA77.Text) + 0.423027 * Convert.ToDouble(txtBasicA87.Text) + 0.325191 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A18Trium = Convert.ToInt16(37.078778 + 0.639543 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A55Trium = Convert.ToInt16(190.115800 + 0.576113 * Convert.ToDouble(txtBasicA87.Text) + 0.262139 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A26Trium = Convert.ToInt16(16.310536 + -0.014720 * Convert.ToDouble(txtBasicA77.Text) + 0.604974 * Convert.ToDouble(txtBasicA87.Text) + 0.304707 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A25Trium = Convert.ToInt16(207.707653 + 2.118783 * Convert.ToDouble(txtBasicA87.Text) + 0.793033 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A66Trium = Convert.ToInt16(18.771480 + 0.033155 * Convert.ToDouble(txtBasicA77.Text) + 0.248777 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A49Trium = Convert.ToInt16(39.565337 + 0.061876 * Convert.ToDouble(txtBasicA77.Text) + 0.139101 * Convert.ToDouble(txtBasicA87.Text) + 0.843483 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A45Trium = Convert.ToInt16(17.501254 + 0.064538 * Convert.ToDouble(txtBasicA77.Text) + 0.412735 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A42Trium = Convert.ToInt16(-9.620756 + 0.695622 * Convert.ToDouble(txtBasicA77.Text) + 0.150238 * Convert.ToDouble(txtBasicA87.Text) + 0.447978 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A41Trium = Convert.ToInt16(14.972599 + 0.220410 * Convert.ToDouble(txtBasicA77.Text) + -0.056588 * Convert.ToDouble(txtBasicA87.Text) + 0.829288 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A38Trium = Convert.ToInt16(4.391388 + 0.176800 * Convert.ToDouble(txtBasicA77.Text) + 0.449280 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A37Trium = Convert.ToInt16(11.473740 + 0.041407 * Convert.ToDouble(txtBasicA77.Text) + 0.996029 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A7Trium = Convert.ToInt16(77.747303 + 0.031166 * Convert.ToDouble(txtBasicA77.Text) + 0.112017 * Convert.ToDouble(txtBasicA87.Text) + 0.462176 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A81Trium = Convert.ToInt16(35.565254 + 0.387964 * Convert.ToDouble(txtBasicA77.Text) + 0.099732 * Convert.ToDouble(txtBasicA87.Text) + 0.924087 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A13Trium = Convert.ToInt16(18.997111 + 0.0102960491 * Convert.ToDouble(txtBasicA77.Text) + 0.017322 * Convert.ToDouble(txtBasicA87.Text) + 0.175786 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A20Trium = Convert.ToInt16(-14.886230 + 0.322632 * Convert.ToDouble(txtBasicA77.Text) + 0.157779 * Convert.ToDouble(txtBasicA87.Text) + 0.583264 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A21Trium = Convert.ToInt16(-23.080582 + 0.287796 * Convert.ToDouble(txtBasicA77.Text) + 0.557314 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A36Trium = Convert.ToInt16(34.169395 + 0.010948 * Convert.ToDouble(txtBasicA77.Text) + 0.037431 * Convert.ToDouble(txtBasicA87.Text) + 0.197679 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A73Trium = Convert.ToInt16(103.564967 + 0.380240 * Convert.ToDouble(txtBasicA77.Text) + 0.170729 * Convert.ToDouble(txtBasicA87.Text) + 0.943287 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A75Trium = Convert.ToInt16(93.518160 + 0.987451 * Convert.ToDouble(txtBasicA77.Text) + -0.139712 * Convert.ToDouble(txtBasicA87.Text) + 1.720476 * Convert.ToDouble(txtBasicA8.Text));


                _getStandart.A76Network = Convert.ToInt16(175.831436 + 1.098562 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A53Network = Convert.ToInt16(-62.035009 + 0.781086 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A3Network = Convert.ToInt16(-16.792604 + 0.043370 * Convert.ToDouble(txtBasicA87.Text) + 0.987023 * Convert.ToDouble(txtBasicA77.Text) + 0.116696 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A6Network = Convert.ToInt16(-33.260574 + 0.946997 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A27Network = Convert.ToInt16(-99.563702 + 0.753316 * (_getStandart.A76Network) + 0.336914 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A78Network = Convert.ToInt16(-77.463677 + 0.680516 * Convert.ToDouble(txtBasicA8.Text) + -0.072149 * Convert.ToDouble(txtBasicA87.Text) + 0.754171 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A58Network = Convert.ToInt16(-45.024640 + 0.416505 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A84Network = Convert.ToInt16(-22.336053 + 0.262666 * Convert.ToDouble(txtBasicA8.Text) + 0.819955 * (_getStandart.A53Network));
                _getStandart.A19Network = Convert.ToInt16(-13.132120 + 0.931878 * (_getStandart.A84Network) + 0.305777 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A72Network = Convert.ToInt16(130.121514 + -0.323757 * Convert.ToDouble(txtBasicA8.Text) + 0.716447 * (_getStandart.A76Network) + -0.469520 * (_getStandart.A19Network) + 0.036331 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A91Network = Convert.ToInt16(-37.419551 + 0.438261 * Convert.ToDouble(txtBasicA8.Text) + 0.756795 * (_getStandart.A6Network));
                _getStandart.A28Network = Convert.ToInt16(-56.254522 + 0.554312 * (_getStandart.A19Network) + 0.247319 * Convert.ToDouble(txtBasicA77.Text) + 0.269928 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A35Network = Convert.ToInt16(-21.708011 + 0.899739 * (_getStandart.A72Network));
                _getStandart.A57Network = Convert.ToInt16(-31.107584 + 0.937455 * (_getStandart.A58Network));
                _getStandart.A59Network = Convert.ToInt16(56.994708 + 0.889996 * (_getStandart.A57Network));
                _getStandart.A67Network = Convert.ToInt16(-18.582834 + 0.759377 * (_getStandart.A59Network) + 0.052079 * (_getStandart.A3Network));
                _getStandart.A74Network = Convert.ToInt16(30.332024 + 0.317954 * Convert.ToDouble(txtBasicA8.Text) + 0.347931 * (_getStandart.A28Network) + 0.142208 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A70Network = Convert.ToInt16(14.094766 + -0.109304 * Convert.ToDouble(txtBasicA8.Text) + 0.440916 * (_getStandart.A74Network) + 0.076505 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A4Network = Convert.ToInt16(-7.917209 + 0.034367 * Convert.ToDouble(txtBasicA8.Text) + 0.889153 * (_getStandart.A70Network) + 0.008941 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A68Network = Convert.ToInt16(-8.768365 + 0.195002 * Convert.ToDouble(txtBasicA8.Text) + 0.014528 * (_getStandart.A6Network) + 0.367814 * (_getStandart.A74Network));
                _getStandart.A82Network = Convert.ToInt16(30.142910 + 0.896959 * (_getStandart.A57Network));
                _getStandart.A23Network = Convert.ToInt16(56.188164 + 1.015654 * Convert.ToDouble(txtBasicA77.Text));


                _getStandart.A88Network = Convert.ToInt16(-64.607488 + 3.079259 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A89Network = Convert.ToInt16(-30.382353 + 0.298617 * (_getStandart.A88Network) + -0.063299 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A2Network = Convert.ToInt16(-41.362187 + 0.314714 * (_getStandart.A88Network));
                _getStandart.A92Network = Convert.ToInt16(-1200.213054 + 1.018030 * (_getStandart.A88Network) + 2.123612 * Convert.ToDouble(txtBasicA8.Text) + 0.466573 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A17Network = Convert.ToInt16(805.425541 + -0.204985 * Convert.ToDouble(txtBasicA8.Text) + 0.542749 * (_getStandart.A92Network) + -0.145211 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A18Network = Convert.ToInt16(-14.190307 + 0.210480 * (_getStandart.A17Network) + 0.085129 * (_getStandart.A88Network) + -0.024064 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A85Network = Convert.ToInt16(879.090985 + 0.436219 * Convert.ToDouble(txtBasicA77.Text) + -1.330864 * Convert.ToDouble(txtBasicA8.Text) + 0.497626 * (_getStandart.A92Network));
                _getStandart.A51Network = Convert.ToInt16(41.922760 + 0.246423 * (_getStandart.A17Network) + 0.108049 * Convert.ToDouble(txtBasicA87.Text) + 0.086128 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A52Network = Convert.ToInt16(9.475592 + 0.324613 * (_getStandart.A17Network) + 0.119083 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A79Network = Convert.ToInt16(-90.180704 + 0.724535 * (_getStandart.A17Network) + -0.116226 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A61Network = Convert.ToInt16(32.252850 + 0.361394 * (_getStandart.A79Network) + 0.073355 * (_getStandart.A2Network) + 0.116480 * (_getStandart.A51Network) + 0.023505 * (_getStandart.A85Network) + 0.263918 * Convert.ToDouble(txtBasicA8.Text));
                _getStandart.A80Network = Convert.ToInt16(22.863437 + 0.243427 * (_getStandart.A79Network) + -0.023422 * Convert.ToDouble(txtBasicA87.Text) + 0.009082 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A25Network = Convert.ToInt16(1142.709110 + -0.365562 * Convert.ToDouble(txtBasicA77.Text) + -1.030207 * (_getStandart.A80Network) + 0.734066 * (_getStandart.A92Network));
                _getStandart.A26Network = Convert.ToInt16(-40.612259 + 0.235021 * (_getStandart.A25Network) + 0.061500 * Convert.ToDouble(txtBasicA8.Text) + 0.035386 * (_getStandart.A88Network));
                _getStandart.A12Network = Convert.ToInt16(448.292036 + -0.073358 * Convert.ToDouble(txtBasicA77.Text) - 0.084685 * (_getStandart.A51Network) + 0.230279 * (_getStandart.A92Network));
                _getStandart.A69Network = Convert.ToInt16(111.118526 + 0.417027 * Convert.ToDouble(txtBasicA8.Text) + 1.740003 * (_getStandart.A12Network) + 0.074913 * Convert.ToDouble(txtBasicA77.Text) + -0.051462 * (_getStandart.A89Network));
                _getStandart.A9Network = Convert.ToInt16(-59.820927 + 0.187514 * Convert.ToDouble(txtBasicA8.Text) + -0.067350 * (_getStandart.A92Network) + 0.314832 * (_getStandart.A69Network) + 0.086447 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A10Network = Convert.ToInt16(286.460314 + 0.191893 * (_getStandart.A92Network) + 0.124425 * (_getStandart.A9Network) + 0.297139 * (_getStandart.A80Network) + -0.137483 * Convert.ToDouble(txtBasicA77.Text));
                _getStandart.A39Network = Convert.ToInt16(28.617843 + 0.016631 * Convert.ToDouble(txtBasicA77.Text) + 0.479472 * (_getStandart.A10Network) + 0.109615 * (_getStandart.A80Network) + 0.071278 * (_getStandart.A9Network) + 0.181101 * Convert.ToDouble(txtBasicA8.Text));



                _getStandart.A37Network = Convert.ToInt16(13.482970 + 0.990611 * Convert.ToDouble(txtBasicA8.Text) + 0.039571 * Convert.ToDouble(txtBasicA77.Text) + 0.002011 * (_getStandart.A92Network));
                _getStandart.A49Network = Convert.ToInt16(90.595603 + 0.048060 * (_getStandart.A92Network) + 0.013820 * Convert.ToDouble(txtBasicA77.Text) + 0.707626 * (_getStandart.A37Network));
                _getStandart.A75Network = Convert.ToInt16(70.655228 + 0.577853 * (_getStandart.A49Network) + 1.233067 * Convert.ToDouble(txtBasicA8.Text) + 0.951696 * Convert.ToDouble(txtBasicA77.Text) + -0.220091 * Convert.ToDouble(txtBasicA87.Text));
                _getStandart.A41Network = Convert.ToInt16(11.890962 + 0.508491 * Convert.ToDouble(txtBasicA8.Text) + 0.018879 * Convert.ToDouble(txtBasicA77.Text) + 0.214251 * (_getStandart.A75Network) + -0.119549 * (_getStandart.A9Network));
                _getStandart.A45Network = Convert.ToInt16(11.202810 + 0.130049 * Convert.ToDouble(txtBasicA8.Text) + -0.008431 * Convert.ToDouble(txtBasicA77.Text) + 0.335489 * (_getStandart.A41Network) + 0.016759 * (_getStandart.A9Network));
                _getStandart.A38Network = Convert.ToInt16(-7.192767 + 0.019299 * Convert.ToDouble(txtBasicA77.Text) + 0.683946 * (_getStandart.A41Network));
                _getStandart.A42Network = Convert.ToInt16(43.309529 + 0.564194 * Convert.ToDouble(txtBasicA77.Text) + 0.049679 * (_getStandart.A92Network) + 0.484597 * (_getStandart.A41Network));
                _getStandart.A20Network = Convert.ToInt16(88.881541 + 0.232427 * (_getStandart.A41Network) + 0.324270 * (_getStandart.A78Network) + 0.063209 * (_getStandart.A92Network));
                _getStandart.A21Network = Convert.ToInt16(-34.049338 + -0.037546 * (_getStandart.A41Network) + 0.737022 * (_getStandart.A20Network) + 0.088839 * (_getStandart.A78Network));

                _getStandart.A73Network = Convert.ToInt16(157.939760 + 0.068549 * (_getStandart.A92Network) + 0.281376 * (_getStandart.A75Network) + 0.142154 * Convert.ToDouble(txtBasicA8.Text) + 0.125155 * (_getStandart.A78Network));


           

                _loadThePerson.LoadPerson(_loadThePerson);
                Yukle(txtSearcher.Text);
                MessageBox.Show("Veri Güncellendi");

                btnBasicUpdate.Enabled = false;

            }

            else
            {
                MessageBox.Show("EKSİK GİRİŞ YAPTIN KONTROL ET !");
            }



            
        }

        private void comboBasic_Click(object sender, EventArgs e)
        {
            txtSearcher.Enabled = true;
            btnBasicUpdate.Enabled = false;
            btnBasicDelete.Enabled = false;
        }

        private void dtgBasic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgBasic.ClearSelection();
            //IdSpy = (int)dtgList.CurrentRow.Cells[0].Value;

            //btnBasicUpdate.Enabled = true; şuan hata veriyor sonradan açılabilir.
            btnBasicDelete.Enabled = true;

            lblBasicID.Text = "ID: " + dtgBasic.CurrentRow.Cells[0].Value.ToString();
            txtBasicTc.Text = dtgBasic.CurrentRow.Cells[1].Value.ToString();
            txtBasicAd.Text = dtgBasic.CurrentRow.Cells[2].Value.ToString();
            txtBasicSoyad.Text = dtgBasic.CurrentRow.Cells[3].Value.ToString();
            txtBasicA77.Text = dtgBasic.CurrentRow.Cells[4].Value.ToString();
            txtBasicA87.Text = dtgBasic.CurrentRow.Cells[5].Value.ToString();
            txtBasicA8.Text = dtgBasic.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
