
namespace TezAPPV2.Forms
{
    partial class FormIDFinder
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
            this.pnlS = new System.Windows.Forms.Panel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.btnDetailS = new FontAwesome.Sharp.IconButton();
            this.pnlBasic = new System.Windows.Forms.Panel();
            this.btnBasicS = new FontAwesome.Sharp.IconButton();
            this.PanelDesktopFinder = new System.Windows.Forms.Panel();
            this.pnlS.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.pnlBasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlS
            // 
            this.pnlS.BackColor = System.Drawing.Color.White;
            this.pnlS.Controls.Add(this.pnlDetail);
            this.pnlS.Controls.Add(this.pnlBasic);
            this.pnlS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlS.ForeColor = System.Drawing.Color.Black;
            this.pnlS.Location = new System.Drawing.Point(0, 0);
            this.pnlS.Name = "pnlS";
            this.pnlS.Size = new System.Drawing.Size(848, 49);
            this.pnlS.TabIndex = 0;
            this.pnlS.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.btnDetailS);
            this.pnlDetail.Location = new System.Drawing.Point(191, 8);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(160, 35);
            this.pnlDetail.TabIndex = 3;
            // 
            // btnDetailS
            // 
            this.btnDetailS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetailS.FlatAppearance.BorderSize = 0;
            this.btnDetailS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetailS.IconChar = FontAwesome.Sharp.IconChar.Ruler;
            this.btnDetailS.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDetailS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetailS.IconSize = 32;
            this.btnDetailS.Location = new System.Drawing.Point(0, 0);
            this.btnDetailS.Name = "btnDetailS";
            this.btnDetailS.Size = new System.Drawing.Size(160, 35);
            this.btnDetailS.TabIndex = 1;
            this.btnDetailS.Text = "Detaylı Arama";
            this.btnDetailS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetailS.UseVisualStyleBackColor = true;
            this.btnDetailS.Click += new System.EventHandler(this.btnDetailS_Click);
            // 
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.btnBasicS);
            this.pnlBasic.Location = new System.Drawing.Point(12, 8);
            this.pnlBasic.Name = "pnlBasic";
            this.pnlBasic.Size = new System.Drawing.Size(160, 35);
            this.pnlBasic.TabIndex = 2;
            // 
            // btnBasicS
            // 
            this.btnBasicS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBasicS.FlatAppearance.BorderSize = 0;
            this.btnBasicS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasicS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBasicS.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnBasicS.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBasicS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBasicS.IconSize = 32;
            this.btnBasicS.Location = new System.Drawing.Point(0, 0);
            this.btnBasicS.Name = "btnBasicS";
            this.btnBasicS.Size = new System.Drawing.Size(160, 35);
            this.btnBasicS.TabIndex = 0;
            this.btnBasicS.Text = "Basit Arama";
            this.btnBasicS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBasicS.UseVisualStyleBackColor = true;
            this.btnBasicS.Click += new System.EventHandler(this.btnBasicS_Click);
            // 
            // PanelDesktopFinder
            // 
            this.PanelDesktopFinder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktopFinder.Location = new System.Drawing.Point(0, 49);
            this.PanelDesktopFinder.Name = "PanelDesktopFinder";
            this.PanelDesktopFinder.Size = new System.Drawing.Size(848, 398);
            this.PanelDesktopFinder.TabIndex = 1;
            // 
            // FormIDFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 447);
            this.Controls.Add(this.PanelDesktopFinder);
            this.Controls.Add(this.pnlS);
            this.Name = "FormIDFinder";
            this.Text = "FormIDFinder";
            this.Load += new System.EventHandler(this.FormIDFinder_Load);
            this.pnlS.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlBasic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlS;
        private FontAwesome.Sharp.IconButton btnDetailS;
        private FontAwesome.Sharp.IconButton btnBasicS;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Panel pnlBasic;
        private System.Windows.Forms.Panel PanelDesktopFinder;
    }
}