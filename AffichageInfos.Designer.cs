namespace UtilisateursGUI
{
    partial class AffichageInfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageInfos));
            this.closeBtn = new System.Windows.Forms.Button();
            this.elvTot = new System.Windows.Forms.Label();
            this.InfosPrescriLbl = new System.Windows.Forms.Label();
            this.vstTot = new System.Windows.Forms.Label();
            this.elvVstMoy = new System.Windows.Forms.Label();
            this.tpsVstMoy = new System.Windows.Forms.Label();
            this.medicTotAnSco = new System.Windows.Forms.Label();
            this.medicMoyAnSco = new System.Windows.Forms.Label();
            this.todayBtn = new System.Windows.Forms.Button();
            this.medicTotAnScoValue = new System.Windows.Forms.Label();
            this.dateTimeDeb = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NbtotVstP = new System.Windows.Forms.Label();
            this.nbVstEP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(317, 399);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "Fermer";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // elvTot
            // 
            this.elvTot.AutoSize = true;
            this.elvTot.Location = new System.Drawing.Point(243, 198);
            this.elvTot.Name = "elvTot";
            this.elvTot.Size = new System.Drawing.Size(115, 13);
            this.elvTot.TabIndex = 1;
            this.elvTot.Text = "Nombre total d\'élèves :";
            // 
            // InfosPrescriLbl
            // 
            this.InfosPrescriLbl.AutoSize = true;
            this.InfosPrescriLbl.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfosPrescriLbl.Location = new System.Drawing.Point(12, 9);
            this.InfosPrescriLbl.Name = "InfosPrescriLbl";
            this.InfosPrescriLbl.Size = new System.Drawing.Size(542, 39);
            this.InfosPrescriLbl.TabIndex = 92;
            this.InfosPrescriLbl.Text = "Informations concernant les prescriptions";
            this.InfosPrescriLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vstTot
            // 
            this.vstTot.AutoSize = true;
            this.vstTot.Location = new System.Drawing.Point(161, 227);
            this.vstTot.Name = "vstTot";
            this.vstTot.Size = new System.Drawing.Size(197, 13);
            this.vstTot.TabIndex = 93;
            this.vstTot.Text = "Nombre total de visites selon la période :";
            // 
            // elvVstMoy
            // 
            this.elvVstMoy.AutoSize = true;
            this.elvVstMoy.Location = new System.Drawing.Point(86, 258);
            this.elvVstMoy.Name = "elvVstMoy";
            this.elvVstMoy.Size = new System.Drawing.Size(272, 13);
            this.elvVstMoy.TabIndex = 94;
            this.elvVstMoy.Text = "Nombre de visites moyennes par élève selon la période :";
            // 
            // tpsVstMoy
            // 
            this.tpsVstMoy.AutoSize = true;
            this.tpsVstMoy.Location = new System.Drawing.Point(145, 288);
            this.tpsVstMoy.Name = "tpsVstMoy";
            this.tpsVstMoy.Size = new System.Drawing.Size(213, 13);
            this.tpsVstMoy.TabIndex = 95;
            this.tpsVstMoy.Text = "Temps moyen d’une visite selon la période :";
            // 
            // medicTotAnSco
            // 
            this.medicTotAnSco.AutoSize = true;
            this.medicTotAnSco.Location = new System.Drawing.Point(73, 320);
            this.medicTotAnSco.Name = "medicTotAnSco";
            this.medicTotAnSco.Size = new System.Drawing.Size(285, 13);
            this.medicTotAnSco.TabIndex = 96;
            this.medicTotAnSco.Text = "Nombre total de médicaments donnés sur l’année scolaire :";
            // 
            // medicMoyAnSco
            // 
            this.medicMoyAnSco.AutoSize = true;
            this.medicMoyAnSco.Location = new System.Drawing.Point(111, 353);
            this.medicMoyAnSco.Name = "medicMoyAnSco";
            this.medicMoyAnSco.Size = new System.Drawing.Size(247, 13);
            this.medicMoyAnSco.TabIndex = 97;
            this.medicMoyAnSco.Text = "Nombre moyen de médicaments donnés par visite :";
            // 
            // todayBtn
            // 
            this.todayBtn.Location = new System.Drawing.Point(236, 399);
            this.todayBtn.Name = "todayBtn";
            this.todayBtn.Size = new System.Drawing.Size(75, 23);
            this.todayBtn.TabIndex = 98;
            this.todayBtn.Text = "Aujourd\'hui";
            this.todayBtn.UseVisualStyleBackColor = true;
            this.todayBtn.Click += new System.EventHandler(this.todayBtn_Click);
            // 
            // medicTotAnScoValue
            // 
            this.medicTotAnScoValue.AutoSize = true;
            this.medicTotAnScoValue.Location = new System.Drawing.Point(364, 320);
            this.medicTotAnScoValue.Name = "medicTotAnScoValue";
            this.medicTotAnScoValue.Size = new System.Drawing.Size(0, 13);
            this.medicTotAnScoValue.TabIndex = 99;
            // 
            // dateTimeDeb
            // 
            this.dateTimeDeb.Location = new System.Drawing.Point(81, 134);
            this.dateTimeDeb.Name = "dateTimeDeb";
            this.dateTimeDeb.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDeb.TabIndex = 100;
            this.dateTimeDeb.Value = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            this.dateTimeDeb.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(342, 134);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFin.TabIndex = 101;
            this.dateTimeFin.Value = new System.DateTime(2016, 6, 17, 0, 0, 0, 0);
            this.dateTimeFin.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Date de début :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Date de fin :";
            // 
            // NbtotVstP
            // 
            this.NbtotVstP.AutoSize = true;
            this.NbtotVstP.Location = new System.Drawing.Point(361, 226);
            this.NbtotVstP.Name = "NbtotVstP";
            this.NbtotVstP.Size = new System.Drawing.Size(0, 13);
            this.NbtotVstP.TabIndex = 104;
            // 
            // nbVstEP
            // 
            this.nbVstEP.AutoSize = true;
            this.nbVstEP.Location = new System.Drawing.Point(362, 257);
            this.nbVstEP.Name = "nbVstEP";
            this.nbVstEP.Size = new System.Drawing.Size(0, 13);
            this.nbVstEP.TabIndex = 105;
            // 
            // AffichageInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.nbVstEP);
            this.Controls.Add(this.NbtotVstP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeDeb);
            this.Controls.Add(this.medicTotAnScoValue);
            this.Controls.Add(this.todayBtn);
            this.Controls.Add(this.medicMoyAnSco);
            this.Controls.Add(this.medicTotAnSco);
            this.Controls.Add(this.tpsVstMoy);
            this.Controls.Add(this.elvVstMoy);
            this.Controls.Add(this.vstTot);
            this.Controls.Add(this.InfosPrescriLbl);
            this.Controls.Add(this.elvTot);
            this.Controls.Add(this.closeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AffichageInfos";
            this.Text = "Affichage des inormations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label elvTot;
        private System.Windows.Forms.Label InfosPrescriLbl;
        private System.Windows.Forms.Label vstTot;
        private System.Windows.Forms.Label elvVstMoy;
        private System.Windows.Forms.Label tpsVstMoy;
        private System.Windows.Forms.Label medicTotAnSco;
        private System.Windows.Forms.Label medicMoyAnSco;
        private System.Windows.Forms.Button todayBtn;
        private System.Windows.Forms.Label medicTotAnScoValue;
        private System.Windows.Forms.DateTimePicker dateTimeDeb;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NbtotVstP;
        private System.Windows.Forms.Label nbVstEP;
    }
}