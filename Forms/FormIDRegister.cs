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
using FuzzyLogicController;
using FuzzyLogicController.FLC;
using FuzzyLogicController.RuleEngine;
using StringTok;
using TezAPPV2.SqlOperations;



namespace TezAPPV2.Forms
{
    public partial class FormIDRegister : Form
    {
        double solution;
        double solutionBMI;
        public FormIDRegister()
        {

            InitializeComponent();
        }

        

        AddNewPerson _addNewPerson = new AddNewPerson();



        string RegisterUstGiyimEbat;
        string RegisterBMIndex;

        private void LabelEffect_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl.Location.X == 12)
            {
                lbl.Font = new Font("Century Gothic", 8);
                lbl.Cursor = Cursors.Arrow;
                lbl.Location = new Point(lbl.Location.X - 3, lbl.Location.Y - 20);
                foreach (Control txt in pnlRLeft.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txt" + lbl.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }


        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pnlRLeft.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.DodgerBlue;

                }

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.DodgerBlue;
                    if (ctrl.Location.X != 9)
                    {
                        ctrl.Font = new Font("Century Gothic", 11);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 20);
                    }
                }
            }

        }


        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pnlRLeft.Controls)
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
                        ctrl.Font = new Font("Century Gothic", 15);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X + 3, ctrl.Location.Y + 20);
                    }
                }
            }
        }

        private void LabelEffectPls_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl.Location.X == 12)
            {
                lbl.Font = new Font("Century Gothic", 13);
                lbl.Cursor = Cursors.Arrow;
                lbl.Location = new Point(lbl.Location.X - 3, lbl.Location.Y - 20);
                foreach (Control txt in pnlRLeft.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txt" + lbl.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }

        private void TextBoxPls_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pnlRLeft.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.YellowGreen;

                }

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.YellowGreen;
                    if (ctrl.Location.X != 9)
                    {
                        ctrl.Font = new Font("Century Gothic", 11);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 20);
                    }
                }
            }

        }


        private void TextBoxPls_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pnlRLeft.Controls)
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
                        ctrl.Font = new Font("Century Gothic", 15);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X + 3, ctrl.Location.Y + 20);
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRA77_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }





        private void pls3M_CheckedChanged(object sender, EventArgs e)
        {
            if (pcboxpic.Visible==false)
            {
                pcboxpic.Visible = true;
            }

            else if(pcboxpic.Visible==true)
            {
                pcboxpic.Visible = false;

            }
            if (pls3M.Checked)
            {
                lblRE101.Visible = true;
                lblRE102.Visible = true;
                lblRE103.Visible = true;
                txtRE101.Visible = true;
                txtRE102.Visible = true;
                txtRE103.Visible = true;
                pnlRE101.Visible = true;
                pnlRE102.Visible = true;
                pnlRE103.Visible = true;
            }
            else
            {
                lblRE101.Visible = false;
                lblRE102.Visible = false;
                lblRE103.Visible = false;
                txtRE101.Visible = false;
                txtRE102.Visible = false;
                txtRE103.Visible = false;
                pnlRE101.Visible = false;
                pnlRE102.Visible = false;
                pnlRE103.Visible = false;
                txtRE101.Clear();
                txtRE102.Clear();
                txtRE103.Clear();
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
        public void loadVariables()
        {
            if (FuzzyLogic.InputVariables.Count > 0)
            {
                VarLabel.Text = FuzzyLogic.InputVariables[0].Name;



                for (int i = 1; i < FuzzyLogic.InputVariables.Count; i++)
                {
                    VarLabel.Text = VarLabel.Text + "," + FuzzyLogic.InputVariables[i].Name;
                }
            }
        }

        public void loadRulesChest()
        {
            List<FuzzyLogicController.RuleEngine.Rule> rules = FuzzyLogic.Rules;

        }

        public void FuzzyCalculator()
        {

            clearAll();
            List<double> inputs = FuzzyLogic.tokString(txtFuzzyOption.Text);
            CrispPan.RowCount = FuzzyLogic.InputVariables.Count;

            for (int i = 0; i < FuzzyLogic.InputVariables.Count; i++)
            {
                CrispPan.Controls.Add(TextLabel(FuzzyLogic.InputVariables[i].Name + " : " + inputs[i], TextType.Normal));
            }

            //Fuzzification
            List<FuzzySet> InSets = new List<FuzzySet>();
            for (int i = 0; i < FuzzyLogic.InputVariables.Count; i++)
            {
                InSets.Add(new FuzzySet(FuzzyLogic.FuzzyControl.Fuzzification(inputs[i], FuzzyLogic.InputVariables[i]), FuzzyLogic.InputVariables[i].Name));
            }

            for (int i = 0; i < InSets.Count; i++)
            {

                FuzzPan.Controls.Add(TextLabel(InSets[i].Variable, TextType.Normal));

                for (int j = 0; j < InSets[i].Set.Count; j++)
                {
                    FuzzPan.Controls.Add(TextLabel(InSets[i].Set[j].MemberShipName + ":" + InSets[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                }
            }

            //Inference Engine
            InferEngine engine = new InferEngine(FuzzyLogic.Configuration, FuzzyLogic.Rules, InSets);
            List<FuzzySet> RuleResults = engine.evaluateRules();

            EnginePan.Controls.Add(TextLabel("Triggered Rules", TextType.Header));

            for (int i = 0; i < engine.FiredRules.Count; i++)
            {
                EnginePan.Controls.Add(TextLabel("Rule :" + engine.FiredRules[i].ToString(), TextType.Normal, FuzzyLogic.Rules[engine.FiredRules[i] - 1].ToString()));
            }

            for (int i = 0; i < RuleResults.Count; i++)
            {
                DeFuzzPan.Controls.Add(TextLabel(RuleResults[i].Variable, TextType.Header));
                for (int j = 0; j < RuleResults[i].Set.Count; j++)
                {
                    DeFuzzPan.Controls.Add(TextLabel(RuleResults[i].Set[j].MemberShipName + " : " + RuleResults[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                }
            }


            //deFuzzification
            List<double> CrispValues = new List<double>();
            for (int i = 0; i < FuzzyLogic.OutputVariables.Count; i++)
            {
                CrispValues.Add(FuzzyLogic.FuzzyControl.DeFuzzification(RuleResults, FuzzyLogic.OutputVariables[i]));
            }

            for (int i = 0; i < CrispValues.Count; i++)
            {
                solution = CrispValues[i];

                //String text = FuzzyLogic.OutputVariables[i].Name + " : " + CrispValues[i].ToString();
                String text = RuleResults[i].Set[i].MemberShipName;
                RegisterUstGiyimEbat = RuleResults[i].Set[i].MemberShipName;
                CrispView.Items.Add(text);

            }

        }


        private Label TextLabel(String Text, TextType type)
        {
            Label Temp = new Label();
            Temp.Dock = DockStyle.Fill;
            Temp.Text = Text;
            if (type == TextType.Header)
            {
                Temp.Font = new Font("san Serif", 12, FontStyle.Italic);
            }
            else if (type == TextType.Normal)
            {
                Temp.Font = new Font("san Serif", 10, FontStyle.Regular);
            }
            return Temp;
        }


        private Label TextLabel(String Text, TextType type, String ToolTip)
        {
            Label Temp = new Label();
            Temp.Dock = DockStyle.Fill;
            Temp.Text = Text;

            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.Active = true;
            tip.ToolTipIcon = ToolTipIcon.Info;
            tip.UseAnimation = true;
            tip.UseFading = true;
            tip.SetToolTip(Temp, ToolTip);

            if (type == TextType.Header)
            {
                Temp.Font = new Font("san Serif", 13, FontStyle.Italic);
            }
            else if (type == TextType.Normal)
            {
                Temp.Font = new Font("san Serif", 10, FontStyle.Regular);
            }
            return Temp;
        }


        private enum TextType
        {
            Header = 0, Normal = 1
        }

        private void clearAll()
        {
            CrispPan.Controls.Clear();
            FuzzPan.Controls.Clear();
            DeFuzzPan.Controls.Clear();
            EnginePan.Controls.Clear();
            CrispView.Clear();
        }
        public void ChestConfig()
        {

            loadRulesChest();
            FuzzyLogic.Initalize();
            FuzzyLogic.FuzzyChestOption();
            loadVariables();
            // buraya loadrules eklersek forma if li şekilde kuralları yazdırabilriiz:)
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRA8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(pnlRLeft);
        }

        private void btnRSave_Click(object sender, EventArgs e)
        {
            //clear text koymayı unutma sonuna


            if (txtRAd.Text != "" && txtRSoyad.Text != "" && txtRTc.Text != "" && txtRA77.Text != "" && txtRA8.Text != "" && txtRA87.Text != "")

            {

                _addNewPerson.Tc = txtRTc.Text;
                _addNewPerson.Ad = txtRAd.Text;
                _addNewPerson.Soyad = txtRSoyad.Text;
                _addNewPerson.A77 = Convert.ToInt16(txtRA77.Text);
                _addNewPerson.A87 = Convert.ToInt16(txtRA87.Text);
                _addNewPerson.A8 = Convert.ToInt16(txtRA8.Text);



                if (txtRE101.Visible == true && txtRE102.Visible == true && txtRE103.Visible == true)
                {

                    if (txtRE101.Text == "" && txtRE102.Text == "" && txtRE103.Text == "")
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("-E- DEĞERLERİNİZ EKSİK +3 CLASSİC KAPANSIN MI?", "EKSİK DEĞER", MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                            pls3M.Checked = false;
                            MessageBox.Show("+3CLASSİC KAPANDI !");

                            ClearTextBoxes(pnlRLeft);

                        }
                        else
                        {
                            MessageBox.Show("-E- DEGERLERİNİ DOLDUR");
                            return;
                        }
                    }
                    else
                    {




                        _addNewPerson.E101 = Convert.ToInt16(txtRE101.Text);
                        _addNewPerson.E102 = Convert.ToInt16(txtRE102.Text);
                        _addNewPerson.E103 = Convert.ToInt16(txtRE103.Text);

                        _addNewPerson.A3Classic = Convert.ToInt16(-106.738537 + 0.835045 * Convert.ToDouble(txtRE101.Text) + 0.188357 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A4Classic = Convert.ToInt16(-20.945256 + 0.202817 * Convert.ToDouble(txtRE101.Text));
                        _addNewPerson.A6Classic = Convert.ToInt16(-105.326523 + 0.718177 * Convert.ToDouble(txtRE101.Text) + 0.402824 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A19Classic = Convert.ToInt16(-47.697705 + 0.256377 * Convert.ToDouble(txtRE101.Text) + 1.129147 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A20Classic = Convert.ToInt16(90.761735 + 0.340686 * Convert.ToDouble(txtRE102.Text) + 0.350313 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A21Classic = Convert.ToInt16(59.294483 + 0.188209 * Convert.ToDouble(txtRE102.Text) + 0.548081 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A23Classic = Convert.ToInt16(-57.294902 + 0.848933 * Convert.ToDouble(txtRE101.Text) + 0.194706 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A27Classic = Convert.ToInt16(-41.963861 + 0.644490 * Convert.ToDouble(txtRE101.Text) + 0.468165 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A28Classic = Convert.ToInt16(-47.381527 + 0.213635 * Convert.ToDouble(txtRE101.Text) + 1.205485 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A35Classic = Convert.ToInt16(44.117699 + 0.693511 * Convert.ToDouble(txtRE101.Text) + -1.064576 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A41Classic = Convert.ToInt16(63.810323 + 0.115326 * Convert.ToDouble(txtRE101.Text) + 0.497590 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A42Classic = Convert.ToInt16(152.424057 + 0.595924 * Convert.ToDouble(txtRE102.Text) + 0.742059 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A53Classic = Convert.ToInt16(-55.610308 + 0.419386 * Convert.ToDouble(txtRE101.Text) + 0.885773 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A57Classic = Convert.ToInt16(-28.035053 + 0.101631 * Convert.ToDouble(txtRE101.Text) + 0.786261 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A58Classic = Convert.ToInt16(-15.204029 + 0.167189 * Convert.ToDouble(txtRE101.Text) + 0.641549 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A59Classic = Convert.ToInt16(-12.079942 + 0.101352 * Convert.ToDouble(txtRE101.Text) + 0.757886 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A65Classic = Convert.ToInt16(52.447531 + 0.782496 * Convert.ToDouble(txtRE101.Text));


                        _addNewPerson.A68Classic = Convert.ToInt16(26.169505 + 0.044728 * Convert.ToDouble(txtRE101.Text) + 0.379618 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A70Classic = Convert.ToInt16(82.093259 + 0.080794 * Convert.ToDouble(txtRE102.Text) + 0.447412 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A72Classic = Convert.ToInt16(85.312841 + 0.749979 * Convert.ToDouble(txtRE101.Text) + -1.126437 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A73Classic = Convert.ToInt16(141.415083 + 0.339238 * Convert.ToDouble(txtRE101.Text) + 0.369140 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A74Classic = Convert.ToInt16(26.354689 + 0.168318 * Convert.ToDouble(txtRE101.Text) + 0.630909 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A75Classic = Convert.ToInt16(163.697267 + 0.632588 * Convert.ToDouble(txtRE101.Text) + 1.255216 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A77Classic = Convert.ToInt16(-88.756973 + 0.840642 * Convert.ToDouble(txtRE101.Text) + 0.118663 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A78Classic = Convert.ToInt16(-65.865792 + 0.482697 * Convert.ToDouble(txtRE101.Text) + 0.788300 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A82Classic = Convert.ToInt16(-48.088630 + 0.131415 * Convert.ToDouble(txtRE101.Text) + 0.6642650 * (103));
                        _addNewPerson.A84Classic = Convert.ToInt16(-59.083669 + 0.293004 * Convert.ToDouble(txtRE101.Text) + 1.036371 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A91Classic = Convert.ToInt16(-49.140921 + 0.381921 * Convert.ToDouble(txtRE101.Text) + 1.011836 * Convert.ToDouble(txtRE103.Text));
                        _addNewPerson.A94Classic = Convert.ToInt16(-15.679586 + 0.938747 * Convert.ToDouble(txtRE102.Text) + -0.406201 * Convert.ToDouble(txtRE103.Text));
                    }
                }

                _addNewPerson.A2Trium = Convert.ToInt16(-45.101775 + 0.918255 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A3Trium = Convert.ToInt16(-16.792604 + 0.987023 * Convert.ToDouble(txtRA77.Text) + 0.043370 * Convert.ToDouble(txtRA87.Text) + 0.116696 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A6Trium = Convert.ToInt16(-25.596371 + 0.961065 * Convert.ToDouble(txtRA77.Text) + -0.143448 * Convert.ToDouble(txtRA87.Text) + 0.094185 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A23Trium = Convert.ToInt16(49.888267 + 0.994674 * Convert.ToDouble(txtRA77.Text) + -0.022369 * Convert.ToDouble(txtRA87.Text) + 0.217901 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A27Trium = Convert.ToInt16(12.608033 + 0.881134 * Convert.ToDouble(txtRA77.Text) + -0.147747 * Convert.ToDouble(txtRA87.Text) + 0.294365 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A53Trium = Convert.ToInt16(-64.100029 + 0.761457 * Convert.ToDouble(txtRA77.Text) + -0.197303 * Convert.ToDouble(txtRA87.Text) + 0.471347 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A78Trium = Convert.ToInt16(-77.463677 + 0.754171 * Convert.ToDouble(txtRA77.Text) + -0.072149 * Convert.ToDouble(txtRA87.Text) + 0.680516 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A76Trium = Convert.ToInt16(178.973024 + 1.100870 * Convert.ToDouble(txtRA77.Text) + -0.110327 * Convert.ToDouble(txtRA87.Text) + 0.147082 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A58Trium = Convert.ToInt16(-61.520425 + 0.365502 * Convert.ToDouble(txtRA77.Text) + 0.447251 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A4Trium = Convert.ToInt16(-0.226398 + 0.211667 * Convert.ToDouble(txtRA77.Text) + 0.154119 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A19Trium = Convert.ToInt16(-104.563971 + 0.630994 * Convert.ToDouble(txtRA77.Text) + -0.211202 * Convert.ToDouble(txtRA87.Text) + 0.764583 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A59Trium = Convert.ToInt16(-59.822252 + 0.340544 * Convert.ToDouble(txtRA77.Text) + -0.082402 * Convert.ToDouble(txtRA87.Text) + 0.440318 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A70Trium = Convert.ToInt16(11.255298 + 0.233635 * Convert.ToDouble(txtRA77.Text) + -0.036070 * Convert.ToDouble(txtRA87.Text) + 0.139968 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A74Trium = Convert.ToInt16(-12.349681 + 0.343589 * Convert.ToDouble(txtRA77.Text) + 0.553360 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A91Trium = Convert.ToInt16(-46.524266 + 0.776548 * Convert.ToDouble(txtRA77.Text) + -0.352021 * Convert.ToDouble(txtRA87.Text) + 0.501591 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A35Trium = Convert.ToInt16(263.277758 + 0.436220 * Convert.ToDouble(txtRA77.Text) + 0.064016 * Convert.ToDouble(txtRA87.Text) + -0.533529 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A28Trium = Convert.ToInt16(-102.280483 + 0.622898 * Convert.ToDouble(txtRA77.Text) + -0.282288 * Convert.ToDouble(txtRA87.Text) + 0.717959 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A57Trium = Convert.ToInt16(-83.258033 + 0.346940 * Convert.ToDouble(txtRA77.Text) + -0.072620 * Convert.ToDouble(txtRA87.Text) + 0.478991 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A67Trium = Convert.ToInt16(-59.441407 + 0.334051 * Convert.ToDouble(txtRA77.Text) + -0.193591 * Convert.ToDouble(txtRA87.Text) + 0.357713 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A82Trium = Convert.ToInt16(-83.460238 + 0.370562 * Convert.ToDouble(txtRA77.Text) + -0.065726 * Convert.ToDouble(txtRA87.Text) + 0.199244 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A84Trium = Convert.ToInt16(-95.121944 + 0.672353 * Convert.ToDouble(txtRA77.Text) + -0.225910 * Convert.ToDouble(txtRA87.Text) + 0.510395 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A68Trium = Convert.ToInt16(-12.350114 + 0.137748 * Convert.ToDouble(txtRA77.Text) + 0.408437 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A72Trium = Convert.ToInt16(326.721718 + 0.460583 * Convert.ToDouble(txtRA77.Text) + 0.065512 * Convert.ToDouble(txtRA87.Text) + -0.459889 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A51Trium = Convert.ToInt16(54.850425 + 0.047806 * Convert.ToDouble(txtRA77.Text) + 0.550016 * Convert.ToDouble(txtRA87.Text) + 0.211832 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A44Trium = Convert.ToInt16(78.017335 + 0.031662 * Convert.ToDouble(txtRA77.Text) + 0.079454 * Convert.ToDouble(txtRA87.Text) + 0.312442 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A52Trium = Convert.ToInt16(22.165516 + 0.051973 * Convert.ToDouble(txtRA77.Text) + 0.700181 * Convert.ToDouble(txtRA87.Text) + 0.267744 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A9Trium = Convert.ToInt16(147.667082 + 0.096545 * Convert.ToDouble(txtRA77.Text) + 0.142044 * Convert.ToDouble(txtRA87.Text) + 0.411829 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A79Trium = Convert.ToInt16(54.375209 + -0.031790 * Convert.ToDouble(txtRA77.Text) + 1.335470 * Convert.ToDouble(txtRA87.Text) + 0.898565 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A71Trium = Convert.ToInt16(48.866557 + 0.061390 * Convert.ToDouble(txtRA77.Text) + -0.023408 * Convert.ToDouble(txtRA87.Text) + 0.100708 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A85Trium = Convert.ToInt16(250.729955 + 0.598313 * Convert.ToDouble(txtRA77.Text) + 1.695107 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A30Trium = Convert.ToInt16(88.740184 + 0.224249 * Convert.ToDouble(txtRA77.Text) + 0.139455 * Convert.ToDouble(txtRA87.Text) + -0.502395 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A88Trium = Convert.ToInt16(-64.607488 + 3.079259 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A43Trium = Convert.ToInt16(31.700846 + 0.0136011 * Convert.ToDouble(txtRA77.Text) + 0.0282693739 * Convert.ToDouble(txtRA87.Text) + 0.1381835 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A89Trium = Convert.ToInt16(-45.331941 + 0.867252 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A12Trium = Convert.ToInt16(162.445118 + 0.023838 * Convert.ToDouble(txtRA77.Text) + 0.687638 * Convert.ToDouble(txtRA87.Text) + 0.444005 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A17Trium = Convert.ToInt16(131.020548 + 0.064154 * Convert.ToDouble(txtRA77.Text) + 1.830446 * Convert.ToDouble(txtRA87.Text) + 0.988782 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A29Trium = Convert.ToInt16(80.639868 + 0.213828 * Convert.ToDouble(txtRA77.Text) + 0.717112 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A61Trium = Convert.ToInt16(67.735245 + 0.655908 * Convert.ToDouble(txtRA87.Text) + 0.634233 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A22Trium = Convert.ToInt16(107.431549 + -0.029235 * Convert.ToDouble(txtRA77.Text) + 0.569322 * Convert.ToDouble(txtRA87.Text) + 0.701913 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A5Trium = Convert.ToInt16(62.795146 + 0.212295 * Convert.ToDouble(txtRA87.Text) + 0.483976 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A80Trium = Convert.ToInt16(40.126905 + 0.303287 * Convert.ToDouble(txtRA87.Text) + 0.205684 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A93Trium = Convert.ToInt16(51.217317 + 0.032278 * Convert.ToDouble(txtRA77.Text) + 0.108286 * Convert.ToDouble(txtRA87.Text) + 0.213584 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A56Trium = Convert.ToInt16(181.550507 + 0.045307 * Convert.ToDouble(txtRA77.Text) + 0.423027 * Convert.ToDouble(txtRA87.Text) + 0.325191 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A18Trium = Convert.ToInt16(37.078778 + 0.639543 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A55Trium = Convert.ToInt16(190.115800 + 0.576113 * Convert.ToDouble(txtRA87.Text) + 0.262139 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A26Trium = Convert.ToInt16(16.310536 + -0.014720 * Convert.ToDouble(txtRA77.Text) + 0.604974 * Convert.ToDouble(txtRA87.Text) + 0.304707 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A25Trium = Convert.ToInt16(207.707653 + 2.118783 * Convert.ToDouble(txtRA87.Text) + 0.793033 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A66Trium = Convert.ToInt16(18.771480 + 0.033155 * Convert.ToDouble(txtRA77.Text) + 0.248777 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A49Trium = Convert.ToInt16(39.565337 + 0.061876 * Convert.ToDouble(txtRA77.Text) + 0.139101 * Convert.ToDouble(txtRA87.Text) + 0.843483 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A45Trium = Convert.ToInt16(17.501254 + 0.064538 * Convert.ToDouble(txtRA77.Text) + 0.412735 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A42Trium = Convert.ToInt16(-9.620756 + 0.695622 * Convert.ToDouble(txtRA77.Text) + 0.150238 * Convert.ToDouble(txtRA87.Text) + 0.447978 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A41Trium = Convert.ToInt16(14.972599 + 0.220410 * Convert.ToDouble(txtRA77.Text) + -0.056588 * Convert.ToDouble(txtRA87.Text) + 0.829288 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A38Trium = Convert.ToInt16(4.391388 + 0.176800 * Convert.ToDouble(txtRA77.Text) + 0.449280 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A37Trium = Convert.ToInt16(11.473740 + 0.041407 * Convert.ToDouble(txtRA77.Text) + 0.996029 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A7Trium = Convert.ToInt16(77.747303 + 0.031166 * Convert.ToDouble(txtRA77.Text) + 0.112017 * Convert.ToDouble(txtRA87.Text) + 0.462176 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A81Trium = Convert.ToInt16(35.565254 + 0.387964 * Convert.ToDouble(txtRA77.Text) + 0.099732 * Convert.ToDouble(txtRA87.Text) + 0.924087 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A13Trium = Convert.ToInt16(18.997111 + 0.0102960491 * Convert.ToDouble(txtRA77.Text) + 0.017322 * Convert.ToDouble(txtRA87.Text) + 0.175786 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A20Trium = Convert.ToInt16(-14.886230 + 0.322632 * Convert.ToDouble(txtRA77.Text) + 0.157779 * Convert.ToDouble(txtRA87.Text) + 0.583264 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A21Trium = Convert.ToInt16(-23.080582 + 0.287796 * Convert.ToDouble(txtRA77.Text) + 0.557314 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A36Trium = Convert.ToInt16(34.169395 + 0.010948 * Convert.ToDouble(txtRA77.Text) + 0.037431 * Convert.ToDouble(txtRA87.Text) + 0.197679 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A73Trium = Convert.ToInt16(103.564967 + 0.380240 * Convert.ToDouble(txtRA77.Text) + 0.170729 * Convert.ToDouble(txtRA87.Text) + 0.943287 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A75Trium = Convert.ToInt16(93.518160 + 0.987451 * Convert.ToDouble(txtRA77.Text) + -0.139712 * Convert.ToDouble(txtRA87.Text) + 1.720476 * Convert.ToDouble(txtRA8.Text));


                _addNewPerson.A76Network = Convert.ToInt16(175.831436 + 1.098562 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A53Network = Convert.ToInt16(-62.035009 + 0.781086 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A3Network = Convert.ToInt16(-16.792604 + 0.043370 * Convert.ToDouble(txtRA87.Text) + 0.987023 * Convert.ToDouble(txtRA77.Text) + 0.116696 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A6Network = Convert.ToInt16(-33.260574 + 0.946997 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A27Network = Convert.ToInt16(-99.563702 + 0.753316 * (_addNewPerson.A76Network) + 0.336914 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A78Network = Convert.ToInt16(-77.463677 + 0.680516 * Convert.ToDouble(txtRA8.Text) + -0.072149 * Convert.ToDouble(txtRA87.Text) + 0.754171 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A58Network = Convert.ToInt16(-45.024640 + 0.416505 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A84Network = Convert.ToInt16(-22.336053 + 0.262666 * Convert.ToDouble(txtRA8.Text) + 0.819955 * (_addNewPerson.A53Network));
                _addNewPerson.A19Network = Convert.ToInt16(-13.132120 + 0.931878 * (_addNewPerson.A84Network) + 0.305777 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A72Network = Convert.ToInt16(130.121514 + -0.323757 * Convert.ToDouble(txtRA8.Text) + 0.716447 * (_addNewPerson.A76Network) + -0.469520 * (_addNewPerson.A19Network) + 0.036331 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A91Network = Convert.ToInt16(-37.419551 + 0.438261 * Convert.ToDouble(txtRA8.Text) + 0.756795 * (_addNewPerson.A6Network));
                _addNewPerson.A28Network = Convert.ToInt16(-56.254522 + 0.554312 * (_addNewPerson.A19Network) + 0.247319 * Convert.ToDouble(txtRA77.Text) + 0.269928 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A35Network = Convert.ToInt16(-21.708011 + 0.899739 * (_addNewPerson.A72Network));
                _addNewPerson.A57Network = Convert.ToInt16(-31.107584 + 0.937455 * (_addNewPerson.A58Network));
                _addNewPerson.A59Network = Convert.ToInt16(56.994708 + 0.889996 * (_addNewPerson.A57Network));
                _addNewPerson.A67Network = Convert.ToInt16(-18.582834 + 0.759377 * (_addNewPerson.A59Network) + 0.052079 * (_addNewPerson.A3Network));
                _addNewPerson.A74Network = Convert.ToInt16(30.332024 + 0.317954 * Convert.ToDouble(txtRA8.Text) + 0.347931 * (_addNewPerson.A28Network) + 0.142208 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A70Network = Convert.ToInt16(14.094766 + -0.109304 * Convert.ToDouble(txtRA8.Text) + 0.440916 * (_addNewPerson.A74Network) + 0.076505 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A4Network = Convert.ToInt16(-7.917209 + 0.034367 * Convert.ToDouble(txtRA8.Text) + 0.889153 * (_addNewPerson.A70Network) + 0.008941 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A68Network = Convert.ToInt16(-8.768365 + 0.195002 * Convert.ToDouble(txtRA8.Text) + 0.014528 * (_addNewPerson.A6Network) + 0.367814 * (_addNewPerson.A74Network));
                _addNewPerson.A82Network = Convert.ToInt16(30.142910 + 0.896959 * (_addNewPerson.A57Network));
                _addNewPerson.A23Network = Convert.ToInt16(56.188164 + 1.015654 * Convert.ToDouble(txtRA77.Text));


                _addNewPerson.A88Network = Convert.ToInt16(-64.607488 + 3.079259 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A89Network = Convert.ToInt16(-30.382353 + 0.298617 * (_addNewPerson.A88Network) + -0.063299 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A2Network = Convert.ToInt16(-41.362187 + 0.314714 * (_addNewPerson.A88Network));
                _addNewPerson.A92Network = Convert.ToInt16(-1200.213054 + 1.018030 * (_addNewPerson.A88Network) + 2.123612 * Convert.ToDouble(txtRA8.Text) + 0.466573 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A17Network = Convert.ToInt16(805.425541 + -0.204985 * Convert.ToDouble(txtRA8.Text) + 0.542749 * (_addNewPerson.A92Network) + -0.145211 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A18Network = Convert.ToInt16(-14.190307 + 0.210480 * (_addNewPerson.A17Network) + 0.085129 * (_addNewPerson.A88Network) + -0.024064 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A85Network = Convert.ToInt16(879.090985 + 0.436219 * Convert.ToDouble(txtRA77.Text) + -1.330864 * Convert.ToDouble(txtRA8.Text) + 0.497626 * (_addNewPerson.A92Network));
                _addNewPerson.A51Network = Convert.ToInt16(41.922760 + 0.246423 * (_addNewPerson.A17Network) + 0.108049 * Convert.ToDouble(txtRA87.Text) + 0.086128 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A52Network = Convert.ToInt16(9.475592 + 0.324613 * (_addNewPerson.A17Network) + 0.119083 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A79Network = Convert.ToInt16(-90.180704 + 0.724535 * (_addNewPerson.A17Network) + -0.116226 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A61Network = Convert.ToInt16(32.252850 + 0.361394 * (_addNewPerson.A79Network) + 0.073355 * (_addNewPerson.A2Network) + 0.116480 * (_addNewPerson.A51Network) + 0.023505 * (_addNewPerson.A85Network) + 0.263918 * Convert.ToDouble(txtRA8.Text));
                _addNewPerson.A80Network = Convert.ToInt16(22.863437 + 0.243427 * (_addNewPerson.A79Network) + -0.023422 * Convert.ToDouble(txtRA87.Text) + 0.009082 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A25Network = Convert.ToInt16(1142.709110 + -0.365562 * Convert.ToDouble(txtRA77.Text) + -1.030207 * (_addNewPerson.A80Network) + 0.734066 * (_addNewPerson.A92Network));
                _addNewPerson.A26Network = Convert.ToInt16(-40.612259 + 0.235021 * (_addNewPerson.A25Network) + 0.061500 * Convert.ToDouble(txtRA8.Text) + 0.035386 * (_addNewPerson.A88Network));
                _addNewPerson.A12Network = Convert.ToInt16(448.292036 + -0.073358 * Convert.ToDouble(txtRA77.Text) - 0.084685 * (_addNewPerson.A51Network) + 0.230279 * (_addNewPerson.A92Network));
                _addNewPerson.A69Network = Convert.ToInt16(111.118526 + 0.417027 * Convert.ToDouble(txtRA8.Text) + 1.740003 * (_addNewPerson.A12Network) + 0.074913 * Convert.ToDouble(txtRA77.Text) + -0.051462 * (_addNewPerson.A89Network));
                _addNewPerson.A9Network = Convert.ToInt16(-59.820927 + 0.187514 * Convert.ToDouble(txtRA8.Text) + -0.067350 * (_addNewPerson.A92Network) + 0.314832 * (_addNewPerson.A69Network) + 0.086447 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A10Network = Convert.ToInt16(286.460314 + 0.191893 * (_addNewPerson.A92Network) + 0.124425 * (_addNewPerson.A9Network) + 0.297139 * (_addNewPerson.A80Network) + -0.137483 * Convert.ToDouble(txtRA77.Text));
                _addNewPerson.A39Network = Convert.ToInt16(28.617843 + 0.016631 * Convert.ToDouble(txtRA77.Text) + 0.479472 * (_addNewPerson.A10Network) + 0.109615 * (_addNewPerson.A80Network) + 0.071278 * (_addNewPerson.A9Network) + 0.181101 * Convert.ToDouble(txtRA8.Text));



                _addNewPerson.A37Network = Convert.ToInt16(13.482970 + 0.990611 * Convert.ToDouble(txtRA8.Text) + 0.039571 * Convert.ToDouble(txtRA77.Text) + 0.002011 * (_addNewPerson.A92Network));
                _addNewPerson.A49Network = Convert.ToInt16(90.595603 + 0.048060 * (_addNewPerson.A92Network) + 0.013820 * Convert.ToDouble(txtRA77.Text) + 0.707626 * (_addNewPerson.A37Network));
                _addNewPerson.A75Network = Convert.ToInt16(70.655228 + 0.577853 * (_addNewPerson.A49Network) + 1.233067 * Convert.ToDouble(txtRA8.Text) + 0.951696 * Convert.ToDouble(txtRA77.Text) + -0.220091 * Convert.ToDouble(txtRA87.Text));
                _addNewPerson.A41Network = Convert.ToInt16(11.890962 + 0.508491 * Convert.ToDouble(txtRA8.Text) + 0.018879 * Convert.ToDouble(txtRA77.Text) + 0.214251 * (_addNewPerson.A75Network) + -0.119549 * (_addNewPerson.A9Network));
                _addNewPerson.A45Network = Convert.ToInt16(11.202810 + 0.130049 * Convert.ToDouble(txtRA8.Text) + -0.008431 * Convert.ToDouble(txtRA77.Text) + 0.335489 * (_addNewPerson.A41Network) + 0.016759 * (_addNewPerson.A9Network));
                _addNewPerson.A38Network = Convert.ToInt16(-7.192767 + 0.019299 * Convert.ToDouble(txtRA77.Text) + 0.683946 * (_addNewPerson.A41Network));
                _addNewPerson.A42Network = Convert.ToInt16(43.309529 + 0.564194 * Convert.ToDouble(txtRA77.Text) + 0.049679 * (_addNewPerson.A92Network) + 0.484597 * (_addNewPerson.A41Network));
                _addNewPerson.A20Network = Convert.ToInt16(88.881541 + 0.232427 * (_addNewPerson.A41Network) + 0.324270 * (_addNewPerson.A78Network) + 0.063209 * (_addNewPerson.A92Network));
                _addNewPerson.A21Network = Convert.ToInt16(-34.049338 + -0.037546 * (_addNewPerson.A41Network) + 0.737022 * (_addNewPerson.A20Network) + 0.088839 * (_addNewPerson.A78Network));

                _addNewPerson.A73Network = Convert.ToInt16(157.939760 + 0.068549 * (_addNewPerson.A92Network) + 0.281376 * (_addNewPerson.A75Network) + 0.142154 * Convert.ToDouble(txtRA8.Text) + 0.125155 * (_addNewPerson.A78Network));

                _addNewPerson.karakuvvet = 0;
                _addNewPerson.denizkuvvet = 0;
                _addNewPerson.havakuvvet = 0;
                _addNewPerson.karatotalchest = 0;
                _addNewPerson.havatotalchest = 0;
                _addNewPerson.deniztotalchest = 0;
                _addNewPerson.kara_xs_chest = 0;
                _addNewPerson.kara_s_chest = 0;
                _addNewPerson.kara_m_chest = 0;
                _addNewPerson.kara_l_chest = 0;
                _addNewPerson.kara_xl_chest = 0;
                _addNewPerson.kara_2xl_chest = 0;
                _addNewPerson.hava_xs_chest = 0;
                _addNewPerson.hava_s_chest = 0;
                _addNewPerson.hava_m_chest = 0;
                _addNewPerson.hava_l_chest = 0;
                _addNewPerson.hava_2l_chest = 0;
                _addNewPerson.hava_xxl_chest = 0;
                _addNewPerson.deniz_xs_chest = 0;
                _addNewPerson.deniz_s_chest = 0;
                _addNewPerson.deniz_m_chest = 0;
                _addNewPerson.deniz_l_chest = 0;
                _addNewPerson.deniz_xl_chest = 0;
                _addNewPerson.deniz_2xl_chest = 0;
                _addNewPerson.karatotalbot = 0;
                _addNewPerson.havatotalbot = 0;
                _addNewPerson.deniztotalbot = 0;
                _addNewPerson.kara_34_bot = 0;
                _addNewPerson.kara_35_bot = 0;
                _addNewPerson.kara_36_bot = 0;
                _addNewPerson.kara_37_bot = 0;
                _addNewPerson.kara_38_bot = 0;
                _addNewPerson.kara_39_bot = 0;
                _addNewPerson.kara_40_bot = 0;
                _addNewPerson.kara_41_bot = 0;
                _addNewPerson.kara_42_bot = 0;
                _addNewPerson.kara_43_bot = 0;
                _addNewPerson.kara_44_bot = 0;
                _addNewPerson.kara_45_bot = 0;
                _addNewPerson.kara_46_bot = 0;
                _addNewPerson.kara_47_bot = 0;
                _addNewPerson.kara_48_bot = 0;
                _addNewPerson.hava_34_bot = 0;
                _addNewPerson.hava_35_bot = 0;
                _addNewPerson.hava_36_bot = 0;
                _addNewPerson.hava_37_bot = 0;
                _addNewPerson.hava_38_bot = 0;
                _addNewPerson.hava_39_bot = 0;
                _addNewPerson.hava_40_bot = 0;
                _addNewPerson.hava_41_bot = 0;
                _addNewPerson.hava_42_bot = 0;
                _addNewPerson.hava_43_bot = 0;
                _addNewPerson.hava_44_bot = 0;
                _addNewPerson.hava_45_bot = 0;
                _addNewPerson.hava_46_bot = 0;
                _addNewPerson.hava_47_bot = 0;
                _addNewPerson.hava_48_bot = 0;
                _addNewPerson.deniz_34_bot = 0;
                _addNewPerson.deniz_35_bot = 0;
                _addNewPerson.deniz_36_bot = 0;
                _addNewPerson.deniz_37_bot = 0;
                _addNewPerson.deniz_38_bot = 0;
                _addNewPerson.deniz_39_bot = 0;
                _addNewPerson.deniz_40_bot = 0;
                _addNewPerson.deniz_41_bot = 0;
                _addNewPerson.deniz_42_bot = 0;
                _addNewPerson.deniz_43_bot = 0;
                _addNewPerson.deniz_44_bot = 0;
                _addNewPerson.deniz_45_bot = 0;
                _addNewPerson.deniz_46_bot = 0;
                _addNewPerson.deniz_47_bot = 0;
                _addNewPerson.deniz_48_bot = 0;
                _addNewPerson.karatotalpant = 0;
                _addNewPerson.havatotalpant = 0;
                _addNewPerson.deniztotalpant = 0;
                _addNewPerson.kara_xs_pant = 0;
                _addNewPerson.kara_s_pant = 0;
                _addNewPerson.kara_m_pant = 0;
                _addNewPerson.kara_l_pant = 0;
                _addNewPerson.kara_xl_pant = 0;
                _addNewPerson.kara_2xl_pant = 0;
                _addNewPerson.kara_3xl_pant = 0;
                _addNewPerson.kara_bxl_pant = 0;
                _addNewPerson.hava_xs_pant = 0;
                _addNewPerson.hava_s_pant = 0;
                _addNewPerson.hava_m_pant = 0;
                _addNewPerson.hava_l_pant = 0;
                _addNewPerson.hava_xl_pant = 0;
                _addNewPerson.hava_2xl_pant = 0;
                _addNewPerson.hava_3xl_pant = 0;
                _addNewPerson.hava_bxl_pant = 0;
                _addNewPerson.deniz_xs_pant = 0;
                _addNewPerson.deniz_s_pant = 0;
                _addNewPerson.deniz_m_pant = 0;
                _addNewPerson.deniz_l_pant = 0;
                _addNewPerson.deniz_xl_pant = 0;
                _addNewPerson.deniz_2xl_pant = 0;
                _addNewPerson.deniz_3xl_pant = 0;
                _addNewPerson.deniz_bxl_pant = 0;
                _addNewPerson.karatotalhands = 0;
                _addNewPerson.havatotalhands = 0;
                _addNewPerson.deniztotalhands = 0;
                _addNewPerson.kara_xs_hands = 0;
                _addNewPerson.kara_s_hands = 0;
                _addNewPerson.kara_m_hands = 0;
                _addNewPerson.kara_l_hands = 0;
                _addNewPerson.kara_xl_hands = 0;
                _addNewPerson.kara_2xl_hands = 0;
                _addNewPerson.hava_xs_hands = 0;
                _addNewPerson.hava_s_hands = 0;
                _addNewPerson.hava_m_hands = 0;
                _addNewPerson.hava_l_hands = 0;
                _addNewPerson.hava_xl_hands = 0;
                _addNewPerson.hava_2xl_hands = 0;
                _addNewPerson.deniz_xs_hands = 0;
                _addNewPerson.deniz_s_hands = 0;
                _addNewPerson.deniz_m_hands = 0;
                _addNewPerson.deniz_l_hands = 0;
                _addNewPerson.deniz_xl_hands = 0;
                _addNewPerson.deniz_2xl_hands = 0;
                _addNewPerson.kara_140_150_boy = 0;
                _addNewPerson.kara_150_160_boy = 0;
                _addNewPerson.kara_160_170_boy = 0;
                _addNewPerson.kara_170_180_boy = 0;
                _addNewPerson.kara_180_190_boy = 0;
                _addNewPerson.kara_190_200_boy = 0;
                _addNewPerson.kara_200_210_boy = 0;
                _addNewPerson.kara_210_220_boy = 0;
                _addNewPerson.kara_220_230_boy = 0;
                _addNewPerson.hava_140_150_boy = 0;
                _addNewPerson.hava_150_160_boy = 0;
                _addNewPerson.hava_160_170_boy = 0;
                _addNewPerson.hava_170_180_boy = 0;
                _addNewPerson.hava_180_190_boy = 0;
                _addNewPerson.hava_190_200_boy = 0;
                _addNewPerson.hava_200_210_boy = 0;
                _addNewPerson.hava_210_220_boy = 0;
                _addNewPerson.hava_220_230_boy = 0;
                _addNewPerson.deniz_140_150_boy = 0;
                _addNewPerson.deniz_150_160_boy = 0;
                _addNewPerson.deniz_160_170_boy = 0;
                _addNewPerson.deniz_170_180_boy = 0;
                _addNewPerson.deniz_180_190_boy = 0;
                _addNewPerson.deniz_190_200_boy = 0;
                _addNewPerson.deniz_200_210_boy = 0;
                _addNewPerson.deniz_210_220_boy = 0;
                _addNewPerson.deniz_220_230_boy = 0;
                _addNewPerson.kara_140alti_uyluk = 0;
                _addNewPerson.kara_140_180_uyluk = 0;
                _addNewPerson.kara_180_220_uyluk = 0;
                _addNewPerson.kara_220_260_uyluk = 0;
                _addNewPerson.kara_260ustu_uyluk = 0;
                _addNewPerson.hava_140alti_uyluk = 0;
                _addNewPerson.hava_140_180_uyluk = 0;
                _addNewPerson.hava_180_220_uyluk = 0;
                _addNewPerson.hava_220_260_uyluk = 0;
                _addNewPerson.hava_260ustu_uyluk = 0;
                _addNewPerson.deniz_140alti_uyluk = 0;
                _addNewPerson.deniz_140_180_uyluk = 0;
                _addNewPerson.deniz_180_220_uyluk = 0;
                _addNewPerson.deniz_220_260_uyluk = 0;
                _addNewPerson.deniz_260ustu_uyluk = 0;




                Random birlikkura = new Random();
                int birlikrollvalue = birlikkura.Next(1, 210);

                txtFuzzyOption.Text = _addNewPerson.A25Trium + "," + _addNewPerson.A88Trium;

                ChestConfig();
                FuzzyCalculator();

                _addNewPerson.UstGiyimEbat = RegisterUstGiyimEbat;

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    if (RegisterUstGiyimEbat == "XSmall")
                    {
                        _addNewPerson.kara_xs_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "Small")
                    {
                        _addNewPerson.kara_s_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "Medium")
                    {
                        _addNewPerson.kara_m_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "Large")
                    {
                        _addNewPerson.kara_l_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "XLarge")
                    {
                        _addNewPerson.kara_xl_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "XXLarge")
                    {
                        _addNewPerson.kara_2xl_chest = 1;
                    }

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    if (RegisterUstGiyimEbat == "XSmall")
                    {
                        _addNewPerson.hava_xs_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "Small")
                    {
                        _addNewPerson.hava_s_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "Medium")
                    {
                        _addNewPerson.hava_m_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "Large")
                    {
                        _addNewPerson.hava_l_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "XLarge")
                    {
                        _addNewPerson.hava_2l_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "XXLarge")
                    {
                        _addNewPerson.hava_xxl_chest = 1;
                    }

                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    if (RegisterUstGiyimEbat == "XSmall")
                    {
                        _addNewPerson.deniz_xs_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "Small")
                    {
                        _addNewPerson.deniz_s_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "Medium")
                    {
                        _addNewPerson.deniz_m_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "Large")
                    {
                        _addNewPerson.deniz_l_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "XLarge")
                    {
                        _addNewPerson.deniz_xl_chest = 1;

                    }
                    else if (RegisterUstGiyimEbat == "XXLarge")
                    {
                        _addNewPerson.deniz_2xl_chest = 1;
                    }

                }


                txtFuzzyOptionBMI.Text = _addNewPerson.A92Network + "," + _addNewPerson.A76Trium;
                BMIConfig();
                FuzzyCalculatorBMI();
                _addNewPerson.BMIndex = RegisterBMIndex;

                if (_addNewPerson.A37Trium > 0)
                {
                    if (_addNewPerson.A37Trium < 220)
                    {
                        _addNewPerson.BotEbat = "34 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_34_bot = 1;
                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_34_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_34_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 220 && _addNewPerson.A37Trium < 227)
                    {
                        _addNewPerson.BotEbat = "35 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_35_bot = 1;
                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_35_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_35_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 227 && _addNewPerson.A37Trium < 233)
                    {
                        _addNewPerson.BotEbat = "36 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_36_bot = 1;
                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_36_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_36_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 233 && _addNewPerson.A37Trium < 240)
                    {
                        _addNewPerson.BotEbat = "37 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_37_bot = 1;
                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_37_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_37_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 240 && _addNewPerson.A37Trium < 247)
                    {
                        _addNewPerson.BotEbat = "38 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_38_bot = 1;
                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_38_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_38_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 247 && _addNewPerson.A37Trium < 253)
                    {
                        _addNewPerson.BotEbat = "39 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_39_bot = 1;

                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_39_bot = 1;


                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_39_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 253 && _addNewPerson.A37Trium < 260)
                    {
                        _addNewPerson.BotEbat = "40 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_40_bot = 1;

                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_40_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_40_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 260 && _addNewPerson.A37Trium < 267)
                    {
                        _addNewPerson.BotEbat = "41 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_41_bot = 1;

                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_41_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_41_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 267 && _addNewPerson.A37Trium < 273)
                    {
                        _addNewPerson.BotEbat = "42 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_42_bot = 1;

                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_42_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_42_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 273 && _addNewPerson.A37Trium < 280)
                    {
                        _addNewPerson.BotEbat = "43 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_43_bot = 1;

                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_43_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_43_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 280 && _addNewPerson.A37Trium < 287)
                    {
                        _addNewPerson.BotEbat = "44 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_44_bot = 1;

                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_44_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_44_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 287 && _addNewPerson.A37Trium < 293)
                    {
                        _addNewPerson.BotEbat = "45 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_45_bot = 1;

                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_45_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_45_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 293 && _addNewPerson.A37Trium < 300)
                    {
                        _addNewPerson.BotEbat = "46 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_46_bot = 1;

                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_46_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_46_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 300 && _addNewPerson.A37Trium < 312)
                    {
                        _addNewPerson.BotEbat = "47 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_47_bot = 1;

                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_47_bot = 1;

                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_47_bot = 1;

                        }
                    }
                    else if (_addNewPerson.A37Trium >= 312)
                    {
                        _addNewPerson.BotEbat = "48 Numara";

                        if (birlikrollvalue > 0 && birlikrollvalue < 71)
                        {
                            _addNewPerson.kara_48_bot = 1;
                        }
                        else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                        {
                            _addNewPerson.hava_48_bot = 1;
                        }
                        else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                        {
                            _addNewPerson.deniz_48_bot = 1;
                        }
                    }

                }
                else
                {
                    _addNewPerson.BotEbat = "BELIRSIZ";
                }


                if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) > 0)
                {
                    if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) < 0.85)
                    {
                        _addNewPerson.BKoran = "X<85";
                    }
                    else if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) < 0.90 && Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) > 0.85)
                    {
                        _addNewPerson.BKoran = "85<X<90";
                    }
                    else if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) >= 0.90 && Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) < 0.95)
                    {
                        _addNewPerson.BKoran = "90<X<95";
                    }
                    else if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) > 0.95 && Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) < 1)
                    {
                        _addNewPerson.BKoran = "95<X<100";
                    }
                    else if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) >= 1)
                    {
                        _addNewPerson.BKoran = "X>100";
                    }
                }
                else
                {
                    _addNewPerson.BKoran = "BELIRSIZZ";
                }

                if (_addNewPerson.A88Trium < 690)
                {
                    _addNewPerson.PantolonEbat = "XSmall";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_xs_pant = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_xs_pant = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_xs_pant = 1;


                    }
                }
                else if (_addNewPerson.A88Trium >= 690 && _addNewPerson.A88Trium < 740)
                {
                    _addNewPerson.PantolonEbat = "Small";
                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_s_pant = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_s_pant = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_s_pant = 1;


                    }
                }
                else if (_addNewPerson.A88Trium >= 740 && _addNewPerson.A88Trium < 790)
                {
                    _addNewPerson.PantolonEbat = "Medium";
                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_m_pant = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_m_pant = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_m_pant = 1;



                    }
                }
                else if (_addNewPerson.A88Trium >= 790 && _addNewPerson.A88Trium < 840)
                {
                    _addNewPerson.PantolonEbat = "Large";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_l_pant = 1;


                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_l_pant = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_l_pant = 1;


                    }
                }
                else if (_addNewPerson.A88Trium >= 840 && _addNewPerson.A88Trium < 890)
                {
                    _addNewPerson.PantolonEbat = "XLarge";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_xl_pant = 1;


                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_xl_pant = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_xl_pant = 1;


                    }
                }
                else if (_addNewPerson.A88Trium >= 890 && _addNewPerson.A88Trium < 945)
                {
                    _addNewPerson.PantolonEbat = "2XLarge";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_2xl_pant = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_2xl_pant = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_2xl_pant = 1;


                    }
                }
                else if (_addNewPerson.A88Trium >= 945 && _addNewPerson.A88Trium < 990)
                {
                    _addNewPerson.PantolonEbat = "3XLarge";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_3xl_pant = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {

                        _addNewPerson.hava_3xl_pant = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_3xl_pant = 1;


                    }
                }
                else if (_addNewPerson.A88Trium >= 990)
                {
                    _addNewPerson.PantolonEbat = "BXLarge";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_bxl_pant = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_bxl_pant = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_bxl_pant = 1;

                    }
                }

                if (_addNewPerson.A45Network <= 180)
                {
                    _addNewPerson.EldivenEbat = "XSmall";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_xs_hands = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_xs_hands = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {

                        _addNewPerson.deniz_xs_hands = 1;

                    }
                }
                else if (_addNewPerson.A45Network >= 180 && _addNewPerson.A45Network < 200)
                {
                    _addNewPerson.EldivenEbat = "Small";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_s_hands = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_s_hands = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_s_hands = 1;


                    }
                }
                else if (_addNewPerson.A45Network >= 200 && _addNewPerson.A45Network < 230)
                {
                    _addNewPerson.EldivenEbat = "Medium";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_m_hands = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_m_hands = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_m_hands = 1;


                    }
                }
                else if (_addNewPerson.A45Network >= 230 && _addNewPerson.A45Network < 250)
                {
                    _addNewPerson.EldivenEbat = "Large";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_l_hands = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_l_hands = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_l_hands = 1;


                    }
                }
                else if (_addNewPerson.A45Network >= 250 && _addNewPerson.A45Network < 280)
                {
                    _addNewPerson.EldivenEbat = "XLarge";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_xl_hands = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_xl_hands = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_xl_hands = 1;


                    }
                }
                else if (_addNewPerson.A45Network >= 280)
                {
                    _addNewPerson.EldivenEbat = "XXLarge";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_2xl_hands = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_2xl_hands = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_2xl_hands = 1;

                    }
                }



                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.Birlik = "KaraKuvvetleri";
                    _addNewPerson.karakuvvet = 1;
                    _addNewPerson.karatotalchest = 1;
                    _addNewPerson.karatotalbot = 1;
                    _addNewPerson.karatotalhands = 1;
                    _addNewPerson.karatotalpant = 1;

                    if (_addNewPerson.A76Network <= 1500)
                    {
                        _addNewPerson.kara_140_150_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1500 && _addNewPerson.A76Network <= 1600)
                    {
                        _addNewPerson.kara_150_160_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1600 && _addNewPerson.A76Network <= 1700)
                    {
                        _addNewPerson.kara_160_170_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1700 && _addNewPerson.A76Network <= 1800)
                    {
                        _addNewPerson.kara_170_180_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1800 && _addNewPerson.A76Network <= 1900)
                    {
                        _addNewPerson.kara_180_190_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1900 && _addNewPerson.A76Network <= 2000)
                    {
                        _addNewPerson.kara_190_200_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 2000 && _addNewPerson.A76Network <= 2100)
                    {
                        _addNewPerson.kara_200_210_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 2100 && _addNewPerson.A76Network <= 2200)
                    {
                        _addNewPerson.kara_210_220_boy = 1;

                    }
                    else if (_addNewPerson.A76Network >= 2200)
                    {
                        _addNewPerson.kara_220_230_boy = 1;
                    }

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.Birlik = "HavaKuvvetleri";
                    _addNewPerson.havakuvvet = 1;
                    _addNewPerson.havatotalchest = 1;
                    _addNewPerson.havatotalbot = 1;
                    _addNewPerson.havatotalhands = 1;
                    _addNewPerson.havatotalpant = 1;

                    if (_addNewPerson.A76Network <= 1500)
                    {
                        _addNewPerson.hava_140_150_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1500 && _addNewPerson.A76Network <= 1600)
                    {
                        _addNewPerson.hava_150_160_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1600 && _addNewPerson.A76Network <= 1700)
                    {
                        _addNewPerson.hava_160_170_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1700 && _addNewPerson.A76Network <= 1800)
                    {
                        _addNewPerson.hava_170_180_boy = 1;


                    }
                    else if (_addNewPerson.A76Network > 1800 && _addNewPerson.A76Network <= 1900)
                    {
                        _addNewPerson.hava_180_190_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1900 && _addNewPerson.A76Network <= 2000)
                    {
                        _addNewPerson.hava_190_200_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 2000 && _addNewPerson.A76Network <= 2100)
                    {
                        _addNewPerson.hava_200_210_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 2100 && _addNewPerson.A76Network <= 2200)
                    {
                        _addNewPerson.hava_210_220_boy = 1;

                    }
                    else if (_addNewPerson.A76Network >= 2200)
                    {
                        _addNewPerson.hava_220_230_boy = 1;
                    }

                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.Birlik = "DenizKuvvetleri";
                    _addNewPerson.denizkuvvet = 1;
                    _addNewPerson.deniztotalchest = 1;
                    _addNewPerson.deniztotalbot = 1;
                    _addNewPerson.deniztotalhands = 1;
                    _addNewPerson.deniztotalpant = 1;

                    if (_addNewPerson.A76Network <= 1500)
                    {
                        _addNewPerson.deniz_140_150_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1500 && _addNewPerson.A76Network <= 1600)
                    {
                        _addNewPerson.deniz_150_160_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1600 && _addNewPerson.A76Network <= 1700)
                    {
                        _addNewPerson.deniz_160_170_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1700 && _addNewPerson.A76Network <= 1800)
                    {
                        _addNewPerson.deniz_170_180_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1800 && _addNewPerson.A76Network <= 1900)
                    {
                        _addNewPerson.deniz_180_190_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 1900 && _addNewPerson.A76Network <= 2000)
                    {
                        _addNewPerson.deniz_190_200_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 2000 && _addNewPerson.A76Network <= 2100)
                    {
                        _addNewPerson.deniz_200_210_boy = 1;

                    }
                    else if (_addNewPerson.A76Network > 2100 && _addNewPerson.A76Network <= 2200)
                    {
                        _addNewPerson.deniz_210_220_boy = 1;

                    }
                    else if (_addNewPerson.A76Network >= 2200)
                    {
                        _addNewPerson.deniz_220_230_boy = 1;
                    }
                }


                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {

                    if (_addNewPerson.A80Trium <= 140)
                    {
                        _addNewPerson.kara_140alti_uyluk = 1;


                    }
                    else if (_addNewPerson.A80Trium > 140 && _addNewPerson.A80Trium <= 180)
                    {
                        _addNewPerson.kara_140_180_uyluk = 1;


                    }
                    else if (_addNewPerson.A80Trium > 180 && _addNewPerson.A80Trium <= 220)
                    {
                        _addNewPerson.kara_180_220_uyluk = 1;


                    }
                    else if (_addNewPerson.A80Trium > 220 && _addNewPerson.A80Trium <= 260)
                    {

                        _addNewPerson.kara_220_260_uyluk = 1;

                    }

                    else if (_addNewPerson.A80Trium > 260)
                    {
                        _addNewPerson.kara_260ustu_uyluk = 1;
                    }
                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    if (_addNewPerson.A80Trium <= 140)
                    {

                        _addNewPerson.hava_140alti_uyluk = 1;

                    }
                    else if (_addNewPerson.A80Trium > 140 && _addNewPerson.A80Trium <= 180)
                    {
                        _addNewPerson.hava_140_180_uyluk = 1;


                    }
                    else if (_addNewPerson.A80Trium > 180 && _addNewPerson.A80Trium <= 220)
                    {
                        _addNewPerson.hava_180_220_uyluk = 1;


                    }
                    else if (_addNewPerson.A80Trium > 220 && _addNewPerson.A80Trium <= 260)
                    {
                        _addNewPerson.hava_220_260_uyluk = 1;


                    }

                    else if (_addNewPerson.A80Trium > 260)
                    {
                        _addNewPerson.hava_260ustu_uyluk = 1;
                    }

                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    if (_addNewPerson.A80Trium <= 140)
                    {
                        _addNewPerson.deniz_140alti_uyluk = 1;


                    }
                    else if (_addNewPerson.A80Trium > 140 && _addNewPerson.A80Trium <= 180)
                    {
                        _addNewPerson.deniz_140_180_uyluk = 1;


                    }
                    else if (_addNewPerson.A80Trium > 180 && _addNewPerson.A80Trium <= 220)
                    {
                        _addNewPerson.deniz_180_220_uyluk = 1;


                    }
                    else if (_addNewPerson.A80Trium > 220 && _addNewPerson.A80Trium <= 260)
                    {
                        _addNewPerson.deniz_220_260_uyluk = 1;

                    }

                    else if (_addNewPerson.A80Trium > 260)
                    {
                        _addNewPerson.deniz_260ustu_uyluk = 1;
                    }

                }







                _addNewPerson.AddPerson(_addNewPerson);

                MessageBox.Show("Yeni kayıt eklendi");
                //btnHesapla.Enabled = true;


            }



            else
            {

                MessageBox.Show("HATALI YADA EKSİK GİRİŞ YAPTIN");

            }












        }

        public void loadVariablesBMI()
        {
            if (FuzzyLogic.InputVariablesBMI.Count > 0)
            {
                VarLabelBMI.Text = FuzzyLogic.InputVariablesBMI[0].Name;



                for (int i = 1; i < FuzzyLogic.InputVariablesBMI.Count; i++)
                {
                    VarLabelBMI.Text = VarLabelBMI.Text + "," + FuzzyLogic.InputVariablesBMI[i].Name;
                }
            }
        }

        public void loadRulesBMI()
        {
            List<FuzzyLogicController.RuleEngine.Rule> rulesBMI = FuzzyLogic.RulesBMI;

        }
        public void FuzzyCalculatorBMI()
        {

            clearBMI();
            List<double> inputs = FuzzyLogic.tokString(txtFuzzyOptionBMI.Text);
            CrispPanBMI.RowCount = FuzzyLogic.InputVariablesBMI.Count;

            for (int i = 0; i < FuzzyLogic.InputVariablesBMI.Count; i++)
            {
                CrispPanBMI.Controls.Add(TextLabel(FuzzyLogic.InputVariablesBMI[i].Name + " : " + inputs[i], TextType.Normal));
            }



            //Fuzzification
            List<FuzzySet> InSets = new List<FuzzySet>();
            for (int i = 0; i < FuzzyLogic.InputVariablesBMI.Count; i++)
            {
                InSets.Add(new FuzzySet(FuzzyLogic.FuzzyControl.Fuzzification(inputs[i], FuzzyLogic.InputVariablesBMI[i]), FuzzyLogic.InputVariablesBMI[i].Name));
            }

            for (int i = 0; i < InSets.Count; i++)
            {

                FuzzPanBMI.Controls.Add(TextLabel(InSets[i].Variable, TextType.Normal));

                for (int j = 0; j < InSets[i].Set.Count; j++)
                {
                    FuzzPanBMI.Controls.Add(TextLabel(InSets[i].Set[j].MemberShipName + ":" + InSets[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                }
            }

            //Inference Engine
            InferEngine engine = new InferEngine(FuzzyLogic.Configuration, FuzzyLogic.RulesBMI, InSets);
            List<FuzzySet> RuleResults = engine.evaluateRules();

            EnginePanBMI.Controls.Add(TextLabel("Tetiklenen Kurallar", TextType.Header));

            for (int i = 0; i < engine.FiredRules.Count; i++)
            {
                EnginePanBMI.Controls.Add(TextLabel("Kural :" + engine.FiredRules[i].ToString(), TextType.Normal, FuzzyLogic.RulesBMI[engine.FiredRules[i] - 1].ToString()));
            }

            for (int i = 0; i < RuleResults.Count; i++)
            {
                DeFuzzPanBMI.Controls.Add(TextLabel(RuleResults[i].Variable, TextType.Header));
                for (int j = 0; j < RuleResults[i].Set.Count; j++)
                {
                    DeFuzzPanBMI.Controls.Add(TextLabel(RuleResults[i].Set[j].MemberShipName + " : " + RuleResults[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                }
            }


            //deFuzzification
            List<double> CrispValues = new List<double>();
            for (int i = 0; i < FuzzyLogic.OutputVariablesBMI.Count; i++)
            {
                CrispValues.Add(FuzzyLogic.FuzzyControl.DeFuzzification(RuleResults, FuzzyLogic.OutputVariablesBMI[i]));
            }

            for (int i = 0; i < CrispValues.Count; i++)
            {
                solutionBMI = CrispValues[i];

                //String text = FuzzyLogic.OutputVariables[i].Name  + " : " + CrispValues[i].ToString();

                String text = RuleResults[i].Set[i].MemberShipName;



                RegisterBMIndex = RuleResults[i].Set[i].MemberShipName;
                CrispViewBMI.Items.Add(text);

            }

        }


        private void clearBMI()
        {
            CrispPanBMI.Controls.Clear();
            FuzzPanBMI.Controls.Clear();
            DeFuzzPanBMI.Controls.Clear();
            EnginePanBMI.Controls.Clear();
            CrispViewBMI.Clear();
        }


        public void BMIConfig()
        {

            loadRulesBMI();
            FuzzyLogic.InitalizeBMI();
            FuzzyLogic.FuzzyBMIndexOption();
            loadVariablesBMI();
            // buraya loadrules eklersek forma if li şekilde kuralları yazdırabilriiz:)
        }

        private void pnlRBack_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
