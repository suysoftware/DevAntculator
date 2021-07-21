using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TezAPPV2.Forms
{
    public partial class FormMeasurments : Form
    {
        public FormMeasurments()
        {

            InitializeComponent();
        }
        public int XXX = 0;
       public int  YYY = 0;
        private void pcboxmeasurment_DoubleClick(object sender, EventArgs e)
        {
            //float k = 0.30f;
            //pcboxmeasurment.Image = new Bitmap(pcboxmeasurment.Image, new Size((int)(pcboxmeasurment.Image.Width * k), (int)(pcboxmeasurment.Image.Height * k)));

        }

        private void pcboxmeasurment_Click(object sender, EventArgs e)
        {

            //float z = 1.5f;
            //pcboxmeasurment.Image = new Bitmap(pcboxmeasurment.Image, new Size((int)(pcboxmeasurment.Image.Width * z), (int)(pcboxmeasurment.Image.Height * z)));
        }

        private void pcboxmeasurment_MouseDown(object sender, MouseEventArgs e)
        {
            
           
            
            // pcboxmeasurment.Location = new Point(e.X, e.Y);
        }

        private void pcboxmeasurment_MouseMove(object sender, MouseEventArgs e)
        {
        
        }

        private void FormMeasurments_MouseCaptureChanged(object sender, EventArgs e)
        {
           
                XXX = Cursor.Position.X; YYY = Cursor.Position.Y ;
            //pcboxmeasurment.Location = new Point(XXX, YYY);
           
            


        }
    }
}
