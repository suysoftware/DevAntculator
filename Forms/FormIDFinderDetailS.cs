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
namespace TezAPPV2.Forms
{
    public partial class FormIDFinderDetailS : Form
    {
        public FormIDFinderDetailS()
        {
            FormMainMenu.ActiveForm.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
   

     
        GetShortData _getShortData = new GetShortData();
        GetStandart _getStandart = new GetStandart();
        DeleteThePerson _deleteThePerson = new DeleteThePerson();
        LoadThePerson _loadThePerson = new LoadThePerson();
        GetIdDetail _getIdDetail = new GetIdDetail();
        private void LabelEffectDetail_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl.Location.X % 20 == 0)
            {
                lbl.Font = new Font("Century Gothic", 7);
                lbl.Cursor = Cursors.Arrow;
                lbl.Location = new Point(lbl.Location.X - 3, lbl.Location.Y - 15);
                foreach (Control txt in pnlDetailTop.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txt" + lbl.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }


        private void Yukle2(string aras = "")
        {
            if (aras != "") 
            {
                _getStandart.Choosecmb = comboDetail.Text;
                dtgSanal.DataSource = _getIdDetail.Get(aras);

            
            }



        }

        private void Yukle(string ara = "")
        {
            
            if (ara == "" && comboDetail.SelectedItem == null)
            {

                dtgDetailS.DataSource = _getShortData.ShortGet(); 

            }
            else if (comboDetail.SelectedItem != null)
            {
                _getStandart.Choosecmb = comboDetail.Text;
                dtgDetailS.DataSource = _getStandart.Get(ara);  

                ColumnVisibleSearcher();

            }
        }
     

        private void ColumnVisibleSearcher()
        {

            foreach (DataGridViewColumn i in
       dtgDetailS.Columns)
            {

                string searcherfilter = dtgDetailS.Columns[i.DisplayIndex].HeaderText.ToString();
                switch (searcherfilter)
                {
                    case "Id":
                        {
                            i.Visible = true;
                            break;
                        }
                    case "Tc":
                        {
                            i.Visible = true;
                            break;
                        }
                    case "Ad":
                        {
                            i.Visible = true;
                            break;
                        }
                    case "Soyad":
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

            this.dtgDetailS.Columns[comboDetail.Text].Visible = true;


        }

      

        private void TextBoxDetail_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pnlDetailTop.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.DodgerBlue;

                }

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.DodgerBlue;
                    if (ctrl.Location.X % 20 == 0)
                    {
                        ctrl.Font = new Font("Century Gothic", 8);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 15);
                    }
                }
            }

        }

        private void TextBoxDetail_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pnlDetailTop.Controls)
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
                        ctrl.Font = new Font("Century Gothic", 8);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X + 3, ctrl.Location.Y + 15);
                    }
                }
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




        }


        private void txtNmbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


        private void FormIDFinderDetailS_Load(object sender, EventArgs e)
        {
            Yukle();
            if (comboDetail.SelectedItem != null)
            {
                btnDetailSearcherClear.Enabled = true;
                txtAramaDetail.Enabled = true;
            }
            else
            {

                txtAramaDetail.Enabled = false;
                btnDetailSearcherClear.Enabled = false;
            }

            Yukle2();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDetailClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(pnlDetailTop);
            txtIDDetail.Text = "";
            btnDetailData.Enabled = false;
            dtgDetailS.Visible = true;
            comboDetail.Enabled = true;
            txtAramaDetail.ReadOnly = false;
            hataverirmi.Visible = false;
            armyequipment.Visible = false;
            armylblchest.Visible = false;
            armylblhands.Visible = false;


            pboxdenizcidetail.Visible = false;
            pboxhavacidetail.Visible = false;
            pboxkaracidetail.Visible = false;


            armylblpants.Visible = false;
            armylblboot.Visible = false;
            pcbox2progress.Visible = false;
            pboxprogress.Visible = false;
            belkalcalblyazi.Visible = false;
            BMIPICBOX1.Visible = false;
            BMIPICBOX2.Visible = false;
            BMIlblarmy.Visible = false;
            BMIlblprogress.Visible = false;
            BMIPROGRESSSBAR.Visible = false;
            BKoranlblarmy.Visible = false;
        }

        private void pnlDetailTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAramaDetail_TextChanged(object sender, EventArgs e)
        {


            Yukle(txtAramaDetail.Text);

        }

        private void btnDetailSearcherClear_Click(object sender, EventArgs e)
        {
          
            dtgDetailS.Columns[comboDetail.Text].DefaultCellStyle.BackColor = Color.White;
            comboDetail.SelectedItem = null;
            txtAramaDetail.Text = "";
            txtAramaDetail.Enabled = false;
            btnDetailSearcherClear.Enabled = false;

            dtgDetailS.DataSource = _getShortData.ShortGet(); 

           
        }

        private void comboDetail_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //

            Yukle(txtAramaDetail.Text);
            txtAramaDetail.Enabled = true;
            btnDetailSearcherClear.Enabled = true;

            dtgDetailS.Columns[comboDetail.Text].DefaultCellStyle.BackColor = Color.Silver;
        }

        private void comboDetail_Click(object sender, EventArgs e)
        {
            if (comboDetail.SelectedItem != null)
            {
                dtgDetailS.Columns[comboDetail.Text].DefaultCellStyle.BackColor = Color.White;



            }

        }



        private void btnDetailData_Click(object sender, EventArgs e)
        {
            FormMainMenu.ActiveForm.WindowState = FormWindowState.Maximized;


            Yukle2(txtIDDetail.Text);


            txtDetailA2.Text = dtgSanal.Rows[0].Cells[10].Value.ToString();
            txtDetailA3.Text = dtgSanal.Rows[0].Cells[11].Value.ToString();
            txtDetailA4.Text = dtgSanal.Rows[0].Cells[12].Value.ToString();
            txtDetailA5.Text = dtgSanal.Rows[0].Cells[13].Value.ToString();
            txtDetailA6.Text = dtgSanal.Rows[0].Cells[14].Value.ToString();
            txtDetailA7.Text = dtgSanal.Rows[0].Cells[15].Value.ToString();
            txtDetailA8.Text = dtgSanal.Rows[0].Cells[6].Value.ToString();
            txtDetailA9.Text = dtgSanal.Rows[0].Cells[16].Value.ToString();
            txtDetailA10.Text = dtgSanal.Rows[0].Cells[77].Value.ToString();
            txtDetailA12.Text = dtgSanal.Rows[0].Cells[17].Value.ToString();
            txtDetailA17.Text = dtgSanal.Rows[0].Cells[19].Value.ToString();
            txtDetailA18.Text = dtgSanal.Rows[0].Cells[80].Value.ToString();
            txtDetailA19.Text = dtgSanal.Rows[0].Cells[21].Value.ToString();
            txtDetailA20.Text = dtgSanal.Rows[0].Cells[22].Value.ToString();
            txtDetailA21.Text = dtgSanal.Rows[0].Cells[23].Value.ToString();
            txtDetailA22.Text = dtgSanal.Rows[0].Cells[24].Value.ToString();
            txtDetailA23.Text = dtgSanal.Rows[0].Cells[25].Value.ToString();
            txtDetailA25.Text = dtgSanal.Rows[0].Cells[26].Value.ToString();
            txtDetailA26.Text = dtgSanal.Rows[0].Cells[27].Value.ToString();
            txtDetailA27.Text = dtgSanal.Rows[0].Cells[28].Value.ToString();
            txtDetailA28.Text = dtgSanal.Rows[0].Cells[29].Value.ToString();
            txtDetailA29.Text = dtgSanal.Rows[0].Cells[30].Value.ToString();
            txtDetailA30.Text = dtgSanal.Rows[0].Cells[31].Value.ToString();
            txtDetailA35.Text = dtgSanal.Rows[0].Cells[32].Value.ToString();
            txtDetailA36.Text = dtgSanal.Rows[0].Cells[33].Value.ToString();
            txtDetailA37.Text = dtgSanal.Rows[0].Cells[34].Value.ToString();
            txtDetailA38.Text = dtgSanal.Rows[0].Cells[35].Value.ToString();
            txtDetailA39.Text = dtgSanal.Rows[0].Cells[92].Value.ToString();
            txtDetailA41.Text = dtgSanal.Rows[0].Cells[36].Value.ToString();
            txtDetailA42.Text = dtgSanal.Rows[0].Cells[37].Value.ToString();
            txtDetailA43.Text = dtgSanal.Rows[0].Cells[38].Value.ToString();
            txtDetailA44.Text = dtgSanal.Rows[0].Cells[39].Value.ToString();
            txtDetailA45.Text = dtgSanal.Rows[0].Cells[40].Value.ToString();
            txtDetailA49.Text = dtgSanal.Rows[0].Cells[41].Value.ToString();
            txtDetailA51.Text = dtgSanal.Rows[0].Cells[42].Value.ToString();
            txtDetailA52.Text = dtgSanal.Rows[0].Cells[43].Value.ToString();
            txtDetailA53.Text = dtgSanal.Rows[0].Cells[44].Value.ToString();
            txtDetailA55.Text = dtgSanal.Rows[0].Cells[45].Value.ToString();
            txtDetailA56.Text = dtgSanal.Rows[0].Cells[46].Value.ToString();
            txtDetailA57.Text = dtgSanal.Rows[0].Cells[47].Value.ToString();
            txtDetailA58.Text = dtgSanal.Rows[0].Cells[48].Value.ToString();
            txtDetailA59.Text = dtgSanal.Rows[0].Cells[49].Value.ToString();
            txtDetailA61.Text = dtgSanal.Rows[0].Cells[50].Value.ToString();
            txtDetailA66.Text = dtgSanal.Rows[0].Cells[51].Value.ToString();
            txtDetailA67.Text = dtgSanal.Rows[0].Cells[52].Value.ToString();
            txtDetailA68.Text = dtgSanal.Rows[0].Cells[53].Value.ToString();
            txtDetailA69.Text = dtgSanal.Rows[0].Cells[106].Value.ToString();
            txtDetailA70.Text = dtgSanal.Rows[0].Cells[54].Value.ToString();
            txtDetailA71.Text = dtgSanal.Rows[0].Cells[55].Value.ToString();
            txtDetailA72.Text = dtgSanal.Rows[0].Cells[56].Value.ToString();
            txtDetailA73.Text = dtgSanal.Rows[0].Cells[57].Value.ToString();
            txtDetailA74.Text = dtgSanal.Rows[0].Cells[58].Value.ToString();
            txtDetailA75.Text = dtgSanal.Rows[0].Cells[59].Value.ToString();
            txtDetailA76.Text = dtgSanal.Rows[0].Cells[60].Value.ToString();
            txtDetailA77.Text = dtgSanal.Rows[0].Cells[4].Value.ToString();
            txtDetailA78.Text = dtgSanal.Rows[0].Cells[61].Value.ToString();
            txtDetailA79.Text = dtgSanal.Rows[0].Cells[62].Value.ToString();
            txtDetailA80.Text = dtgSanal.Rows[0].Cells[63].Value.ToString();
            txtDetailA81.Text = dtgSanal.Rows[0].Cells[64].Value.ToString();
            txtDetailA82.Text = dtgSanal.Rows[0].Cells[65].Value.ToString();
            txtDetailA84.Text = dtgSanal.Rows[0].Cells[66].Value.ToString();
            txtDetailA85.Text = dtgSanal.Rows[0].Cells[67].Value.ToString();
            txtDetailA87.Text = dtgSanal.Rows[0].Cells[5].Value.ToString();
            txtDetailA88.Text = dtgSanal.Rows[0].Cells[68].Value.ToString();
            txtDetailA89.Text = dtgSanal.Rows[0].Cells[69].Value.ToString();
            txtDetailA91.Text = dtgSanal.Rows[0].Cells[70].Value.ToString();
            txtDetailA92.Text = dtgSanal.Rows[0].Cells[122].Value.ToString();
            txtDetailA93.Text = dtgSanal.Rows[0].Cells[71].Value.ToString();
            txtDetailE101.Text = dtgSanal.Rows[0].Cells[7].Value.ToString();
            txtDetailE102.Text = dtgSanal.Rows[0].Cells[8].Value.ToString();
            txtDetailE103.Text = dtgSanal.Rows[0].Cells[9].Value.ToString();
            txtDetailTc.Text = dtgSanal.Rows[0].Cells[1].Value.ToString();
            txtDetailAd.Text = dtgSanal.Rows[0].Cells[2].Value.ToString();
            txtDetailSoyad.Text = dtgSanal.Rows[0].Cells[3].Value.ToString();
            armylblchest.Text = dtgSanal.Rows[0].Cells[152].Value.ToString();
            armylblhands.Text = dtgSanal.Rows[0].Cells[155].Value.ToString();

            armylblpants.Text = dtgSanal.Rows[0].Cells[153].Value.ToString();
            armylblboot.Text = dtgSanal.Rows[0].Cells[154].Value.ToString();
            BMIlblarmy.Text = dtgSanal.Rows[0].Cells[156].Value.ToString();
            BKoranlblarmy.Text = dtgSanal.Rows[0].Cells[157].Value.ToString();


            if (dtgSanal.Rows[0].Cells[158].Value.ToString()=="KaraKuvvetleri")
            {
                pboxkaracidetail.Visible = true;
                pboxhavacidetail.Visible = false;
                pboxdenizcidetail.Visible = false;
            }
            else if (dtgSanal.Rows[0].Cells[158].Value.ToString() == "HavaKuvvetleri")
            {
                pboxkaracidetail.Visible = false;
                pboxhavacidetail.Visible = true;
                pboxdenizcidetail.Visible = false;
            }
            else if (dtgSanal.Rows[0].Cells[158].Value.ToString() == "DenizKuvvetleri")
            {
                pboxkaracidetail.Visible = false;
                pboxhavacidetail.Visible = false;
                pboxdenizcidetail.Visible = true;

            }

            if (dtgSanal.Rows[0].Cells[157].Value.ToString() == "X<85")
            {
                BKoranprogress.Value = 30;

            }
            else if (dtgSanal.Rows[0].Cells[157].Value.ToString() == "85<X<90")
            {
                BKoranprogress.Value = 50;

            }
            else if (dtgSanal.Rows[0].Cells[157].Value.ToString() == "90<X<95")
            {
                BKoranprogress.Value = 70;

            }
            else if (dtgSanal.Rows[0].Cells[157].Value.ToString() == "95<X<100")
            {
                BKoranprogress.Value = 80;

            }
            else if (dtgSanal.Rows[0].Cells[157].Value.ToString() == "X>100")
            {
                BKoranprogress.Value = 100;

            }
            else
            {
                MessageBox.Show("HATA");
            }


           


            if (dtgSanal.Rows[0].Cells[156].Value.ToString() == "VERYTHIN")
            {
                BMIPROGRESSSBAR.Value = 40;
            }
            else if (dtgSanal.Rows[0].Cells[156].Value.ToString() == "THIN")
            {
                BMIPROGRESSSBAR.Value = 60;
            }
            else if (dtgSanal.Rows[0].Cells[156].Value.ToString() == "NORMAL")
            {
                BMIPROGRESSSBAR.Value = 75;
            }
            else if (dtgSanal.Rows[0].Cells[156].Value.ToString() == "FAT")
            {
                BMIPROGRESSSBAR.Value = 85;
            }
            else if (dtgSanal.Rows[0].Cells[156].Value.ToString() == "VERYFAT")
            {
                BMIPROGRESSSBAR.Value = 100;
            }
            else
            {
                BMIPROGRESSSBAR.Value = 65;
            }
            



            dtgDetailS.Visible = false;
            comboDetail.Enabled = false;
            txtAramaDetail.ReadOnly = true;
            hataverirmi.Visible = true;
            armyequipment.Visible = true;
            armylblchest.Visible = true;
            armylblhands.Visible = true;
            BMIPICBOX2.Visible = true;
            armylblpants.Visible = true;
            armylblboot.Visible = true;
            pcbox2progress.Visible = true;
            BMIPICBOX1.Visible = true;
            belkalcalblyazi.Visible = true;
           
            pboxprogress.Visible = true;
            BMIlblarmy.Visible = true;
            BMIlblprogress.Visible = true;
            BKoranlblarmy.Visible = true;

            BMIPICBOX2.Height = 200 - BMIPROGRESSSBAR.Value * 2;
            pcbox2progress.Height = 200 - BKoranprogress.Value * 2;

        }

        private void dtgDetailS_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dtgDetailS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dtgDetailS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                MessageBox.Show("Hata yaptın");
            }
            else
            {
                dtgDetailS.ClearSelection();
                txtIDDetail.Text = dtgDetailS.CurrentRow.Cells[0].Value.ToString();
                txtIDDetail.ReadOnly = false;
                txtIDDetail.ReadOnly = true;
                btnDetailData.Enabled = true;


               


            }
        }

        private void BMIPICBOX2_Click(object sender, EventArgs e)
        {

        }
    }
}
