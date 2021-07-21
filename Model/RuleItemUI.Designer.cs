
namespace TezAPPV2.Model
{
    partial class RuleItemUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MFCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VarText = new System.Windows.Forms.Label();
            this.VarTextBMI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MFComboBMI = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MFCombo
            // 
            this.MFCombo.FormattingEnabled = true;
            this.MFCombo.Location = new System.Drawing.Point(81, 20);
            this.MFCombo.Name = "MFCombo";
            this.MFCombo.Size = new System.Drawing.Size(105, 21);
            this.MFCombo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Is";
            // 
            // VarText
            // 
            this.VarText.AutoSize = true;
            this.VarText.Location = new System.Drawing.Point(3, 23);
            this.VarText.Name = "VarText";
            this.VarText.Size = new System.Drawing.Size(35, 13);
            this.VarText.TabIndex = 6;
            this.VarText.Text = "label1";
            // 
            // VarTextBMI
            // 
            this.VarTextBMI.AutoSize = true;
            this.VarTextBMI.Location = new System.Drawing.Point(3, 57);
            this.VarTextBMI.Name = "VarTextBMI";
            this.VarTextBMI.Size = new System.Drawing.Size(35, 13);
            this.VarTextBMI.TabIndex = 6;
            this.VarTextBMI.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Is";
            // 
            // MFComboBMI
            // 
            this.MFComboBMI.FormattingEnabled = true;
            this.MFComboBMI.Location = new System.Drawing.Point(81, 54);
            this.MFComboBMI.Name = "MFComboBMI";
            this.MFComboBMI.Size = new System.Drawing.Size(105, 21);
            this.MFComboBMI.TabIndex = 8;
            // 
            // RuleItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MFComboBMI);
            this.Controls.Add(this.MFCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VarTextBMI);
            this.Controls.Add(this.VarText);
            this.Name = "RuleItemUI";
            this.Size = new System.Drawing.Size(226, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MFCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VarText;
        private System.Windows.Forms.Label VarTextBMI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MFComboBMI;
    }
}
