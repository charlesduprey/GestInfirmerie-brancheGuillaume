﻿namespace UtilisateursGUI.GestionMdc
{
    partial class FrmModifMdc
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
            this.frmModifLbl = new System.Windows.Forms.Label();
            this.libelleMdcCmbx = new System.Windows.Forms.ComboBox();
            this.libelleMdcLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmModifLbl
            // 
            this.frmModifLbl.AutoSize = true;
            this.frmModifLbl.Location = new System.Drawing.Point(39, 28);
            this.frmModifLbl.Name = "frmModifLbl";
            this.frmModifLbl.Size = new System.Drawing.Size(214, 13);
            this.frmModifLbl.TabIndex = 0;
            this.frmModifLbl.Text = "Formulaire de modification des médicaments";
            // 
            // libelleMdcCmbx
            // 
            this.libelleMdcCmbx.FormattingEnabled = true;
            this.libelleMdcCmbx.Location = new System.Drawing.Point(121, 107);
            this.libelleMdcCmbx.Name = "libelleMdcCmbx";
            this.libelleMdcCmbx.Size = new System.Drawing.Size(121, 21);
            this.libelleMdcCmbx.TabIndex = 1;
            this.libelleMdcCmbx.SelectionChangeCommitted += new System.EventHandler(this.libelleMdcCmbx_SelectionChangeCommitted);
            // 
            // libelleMdcLbl
            // 
            this.libelleMdcLbl.AutoSize = true;
            this.libelleMdcLbl.Location = new System.Drawing.Point(39, 110);
            this.libelleMdcLbl.Name = "libelleMdcLbl";
            this.libelleMdcLbl.Size = new System.Drawing.Size(76, 13);
            this.libelleMdcLbl.TabIndex = 2;
            this.libelleMdcLbl.Text = "Médicaments :";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(63, 188);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(155, 188);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Fermer";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // FrmModifMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.libelleMdcLbl);
            this.Controls.Add(this.libelleMdcCmbx);
            this.Controls.Add(this.frmModifLbl);
            this.Name = "FrmModifMdc";
            this.Text = "FrmModifMdc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmModifLbl;
        private System.Windows.Forms.ComboBox libelleMdcCmbx;
        private System.Windows.Forms.Label libelleMdcLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}