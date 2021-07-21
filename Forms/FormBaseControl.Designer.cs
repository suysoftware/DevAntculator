
namespace TezAPPV2.Forms
{
    partial class FormBaseControl
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
            this.dtgBaseControl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaseControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBaseControl
            // 
            this.dtgBaseControl.AllowUserToOrderColumns = true;
            this.dtgBaseControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBaseControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBaseControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgBaseControl.Location = new System.Drawing.Point(0, 299);
            this.dtgBaseControl.Name = "dtgBaseControl";
            this.dtgBaseControl.Size = new System.Drawing.Size(848, 148);
            this.dtgBaseControl.TabIndex = 0;
            this.dtgBaseControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 447);
            this.Controls.Add(this.dtgBaseControl);
            this.Name = "FormBaseControl";
            this.Text = "FormBaseControl";
            this.Load += new System.EventHandler(this.FormBaseControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaseControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBaseControl;
    }
}