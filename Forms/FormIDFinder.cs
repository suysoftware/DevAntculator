using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using TezAPPV2.Forms;

namespace TezAPPV2.Forms
{
    public partial class FormIDFinder : Form
    {

        private IconButton currentBtnFinder;
        private Panel leftBorderBtnFinder;
        private Form currentChildForm;
        public FormIDFinder()
        {
            
            
            InitializeComponent();

            leftBorderBtnFinder = new Panel();
            leftBorderBtnFinder.Size = new Size(7, 60);
            PanelDesktopFinder.Controls.Add(leftBorderBtnFinder);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButtonFinder(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtonFinder();
                //Button
                currentBtnFinder = (IconButton)senderBtn;
                currentBtnFinder.BackColor = Color.FromArgb(37, 36, 81);
                currentBtnFinder.ForeColor = color;
                currentBtnFinder.TextAlign = ContentAlignment.MiddleCenter;
                currentBtnFinder.IconColor = color;
                currentBtnFinder.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtnFinder.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtnFinder.BackColor = color;
                leftBorderBtnFinder.Location = new Point(0, currentBtnFinder.Location.Y);
                leftBorderBtnFinder.Visible = true;
                leftBorderBtnFinder.BringToFront();
                //Current Child Form Icon
               
            }
        }


        private void DisableButtonFinder()
        {
            if (currentBtnFinder != null)
            {
                currentBtnFinder.BackColor = Color.FromArgb(31, 30, 68);
                currentBtnFinder.ForeColor = Color.Gainsboro;
                currentBtnFinder.TextAlign = ContentAlignment.MiddleLeft;
                currentBtnFinder.IconColor = Color.Gainsboro;
                currentBtnFinder.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtnFinder.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

      

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktopFinder.Controls.Add(childForm);
            PanelDesktopFinder.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void ResetFinder()
        {
            DisableButtonFinder();
            leftBorderBtnFinder.Visible = false;
           

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormIDFinder_Load(object sender, EventArgs e)
        {
            pnlS.BackColor= Color.FromArgb(31, 30, 68);
        }

        private void btnBasicS_Click(object sender, EventArgs e)
        {

            ActivateButtonFinder(sender, RGBColors.color2);
            OpenChildForm(new FormIDFinderBasicS());

        }

        private void btnDetailS_Click(object sender, EventArgs e)
        {
            ActivateButtonFinder(sender, RGBColors.color2);
            OpenChildForm(new FormIDFinderDetailS());
        }
    }
}
