
namespace TezAPPV2.Forms
{
    partial class FormMeasurments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcboxmeasurment = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxmeasurment)).BeginInit();
            this.SuspendLayout();
            // 
            // pcboxmeasurment
            // 
            this.pcboxmeasurment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcboxmeasurment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcboxmeasurment.Image = global::TezAPPV2.Properties.Resources.measurmentss;
            this.pcboxmeasurment.Location = new System.Drawing.Point(0, 0);
            this.pcboxmeasurment.Name = "pcboxmeasurment";
            this.pcboxmeasurment.Size = new System.Drawing.Size(800, 450);
            this.pcboxmeasurment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxmeasurment.TabIndex = 0;
            this.pcboxmeasurment.TabStop = false;
            this.pcboxmeasurment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcboxmeasurment_MouseDown);
            this.pcboxmeasurment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcboxmeasurment_MouseMove);
            // 
            // FormMeasurments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcboxmeasurment);
            this.Name = "FormMeasurments";
            this.Text = "FormMeasurments";
            this.MouseCaptureChanged += new System.EventHandler(this.FormMeasurments_MouseCaptureChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxmeasurment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcboxmeasurment;
    }
}