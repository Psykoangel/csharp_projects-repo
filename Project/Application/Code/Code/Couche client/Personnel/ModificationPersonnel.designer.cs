namespace GestionPersonel
{
    partial class ModificationPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificationPersonnel));
            this.dgv_PersonnelModifier = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtb_person_nom = new System.Windows.Forms.TextBox();
            this.txtb_person_prenom = new System.Windows.Forms.TextBox();
            this.txtb_person_adresse = new System.Windows.Forms.TextBox();
            this.txtb_person_cp = new System.Windows.Forms.TextBox();
            this.txtb_person_ville = new System.Windows.Forms.TextBox();
            this.txtb_person_tel = new System.Windows.Forms.TextBox();
            this.txtb_person_ncq = new System.Windows.Forms.TextBox();
            this.txtb_person_typctr = new System.Windows.Forms.TextBox();
            this.txtb_person_npcot = new System.Windows.Forms.TextBox();
            this.txtb_person_nbees = new System.Windows.Forms.TextBox();
            this.btn_AddPersonnel = new System.Windows.Forms.Button();
            this.btn_ChangePersonnel = new System.Windows.Forms.Button();
            this.btn_DeletePersonnel = new System.Windows.Forms.Button();
            this.btn_ShowPersonnel = new System.Windows.Forms.Button();
            this.chkb_person_pcote = new System.Windows.Forms.CheckBox();
            this.chkb_person_bees = new System.Windows.Forms.CheckBox();
            this.dtp_person_datembauch = new System.Windows.Forms.DateTimePicker();
            this.dtp_person_datevisitmed = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonnelModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PersonnelModifier
            // 
            this.dgv_PersonnelModifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PersonnelModifier.Location = new System.Drawing.Point(12, 12);
            this.dgv_PersonnelModifier.Name = "dgv_PersonnelModifier";
            this.dgv_PersonnelModifier.Size = new System.Drawing.Size(459, 106);
            this.dgv_PersonnelModifier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Numéro Sécu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date d\'embauche";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date visite médicale";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Type de contrat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Numéro permis côtier";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(242, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Numéro BEES";
            // 
            // txtb_person_nom
            // 
            this.txtb_person_nom.Location = new System.Drawing.Point(117, 128);
            this.txtb_person_nom.Name = "txtb_person_nom";
            this.txtb_person_nom.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_nom.TabIndex = 15;
            // 
            // txtb_person_prenom
            // 
            this.txtb_person_prenom.Location = new System.Drawing.Point(117, 154);
            this.txtb_person_prenom.Name = "txtb_person_prenom";
            this.txtb_person_prenom.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_prenom.TabIndex = 16;
            // 
            // txtb_person_adresse
            // 
            this.txtb_person_adresse.Location = new System.Drawing.Point(117, 180);
            this.txtb_person_adresse.Name = "txtb_person_adresse";
            this.txtb_person_adresse.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_adresse.TabIndex = 17;
            // 
            // txtb_person_cp
            // 
            this.txtb_person_cp.Location = new System.Drawing.Point(117, 206);
            this.txtb_person_cp.Name = "txtb_person_cp";
            this.txtb_person_cp.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_cp.TabIndex = 18;
            // 
            // txtb_person_ville
            // 
            this.txtb_person_ville.Location = new System.Drawing.Point(117, 232);
            this.txtb_person_ville.Name = "txtb_person_ville";
            this.txtb_person_ville.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_ville.TabIndex = 19;
            // 
            // txtb_person_tel
            // 
            this.txtb_person_tel.Location = new System.Drawing.Point(117, 258);
            this.txtb_person_tel.Name = "txtb_person_tel";
            this.txtb_person_tel.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_tel.TabIndex = 20;
            // 
            // txtb_person_ncq
            // 
            this.txtb_person_ncq.Location = new System.Drawing.Point(117, 284);
            this.txtb_person_ncq.Name = "txtb_person_ncq";
            this.txtb_person_ncq.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_ncq.TabIndex = 21;
            // 
            // txtb_person_typctr
            // 
            this.txtb_person_typctr.Location = new System.Drawing.Point(371, 180);
            this.txtb_person_typctr.Name = "txtb_person_typctr";
            this.txtb_person_typctr.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_typctr.TabIndex = 24;
            // 
            // txtb_person_npcot
            // 
            this.txtb_person_npcot.Location = new System.Drawing.Point(371, 232);
            this.txtb_person_npcot.Name = "txtb_person_npcot";
            this.txtb_person_npcot.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_npcot.TabIndex = 26;
            // 
            // txtb_person_nbees
            // 
            this.txtb_person_nbees.Location = new System.Drawing.Point(371, 284);
            this.txtb_person_nbees.Name = "txtb_person_nbees";
            this.txtb_person_nbees.Size = new System.Drawing.Size(100, 20);
            this.txtb_person_nbees.TabIndex = 28;
            // 
            // btn_AddPersonnel
            // 
            this.btn_AddPersonnel.Location = new System.Drawing.Point(12, 312);
            this.btn_AddPersonnel.Name = "btn_AddPersonnel";
            this.btn_AddPersonnel.Size = new System.Drawing.Size(100, 23);
            this.btn_AddPersonnel.TabIndex = 29;
            this.btn_AddPersonnel.Text = "Ajouter";
            this.btn_AddPersonnel.UseVisualStyleBackColor = true;
            this.btn_AddPersonnel.Click += new System.EventHandler(this.btn_AddPersonnel_Click);
            // 
            // btn_ChangePersonnel
            // 
            this.btn_ChangePersonnel.Location = new System.Drawing.Point(197, 312);
            this.btn_ChangePersonnel.Name = "btn_ChangePersonnel";
            this.btn_ChangePersonnel.Size = new System.Drawing.Size(100, 23);
            this.btn_ChangePersonnel.TabIndex = 30;
            this.btn_ChangePersonnel.Text = "Modifier";
            this.btn_ChangePersonnel.UseVisualStyleBackColor = true;
            this.btn_ChangePersonnel.Click += new System.EventHandler(this.btn_ChangePersonnel_Click);
            // 
            // btn_DeletePersonnel
            // 
            this.btn_DeletePersonnel.Location = new System.Drawing.Point(371, 312);
            this.btn_DeletePersonnel.Name = "btn_DeletePersonnel";
            this.btn_DeletePersonnel.Size = new System.Drawing.Size(100, 23);
            this.btn_DeletePersonnel.TabIndex = 31;
            this.btn_DeletePersonnel.Text = "Supprimer";
            this.btn_DeletePersonnel.UseVisualStyleBackColor = true;
            this.btn_DeletePersonnel.Click += new System.EventHandler(this.btn_DeletePersonnel_Click);
            // 
            // btn_ShowPersonnel
            // 
            this.btn_ShowPersonnel.Location = new System.Drawing.Point(371, 341);
            this.btn_ShowPersonnel.Name = "btn_ShowPersonnel";
            this.btn_ShowPersonnel.Size = new System.Drawing.Size(100, 23);
            this.btn_ShowPersonnel.TabIndex = 32;
            this.btn_ShowPersonnel.Text = "Afficher";
            this.btn_ShowPersonnel.UseVisualStyleBackColor = true;
            this.btn_ShowPersonnel.Click += new System.EventHandler(this.btn_ShowPersonnel_Click);
            // 
            // chkb_person_pcote
            // 
            this.chkb_person_pcote.AutoSize = true;
            this.chkb_person_pcote.Location = new System.Drawing.Point(245, 208);
            this.chkb_person_pcote.Name = "chkb_person_pcote";
            this.chkb_person_pcote.Size = new System.Drawing.Size(86, 17);
            this.chkb_person_pcote.TabIndex = 33;
            this.chkb_person_pcote.Text = "Permis côtier";
            this.chkb_person_pcote.UseVisualStyleBackColor = true;
            // 
            // chkb_person_bees
            // 
            this.chkb_person_bees.AutoSize = true;
            this.chkb_person_bees.Location = new System.Drawing.Point(245, 260);
            this.chkb_person_bees.Name = "chkb_person_bees";
            this.chkb_person_bees.Size = new System.Drawing.Size(54, 17);
            this.chkb_person_bees.TabIndex = 34;
            this.chkb_person_bees.Text = "BEES";
            this.chkb_person_bees.UseVisualStyleBackColor = true;
            // 
            // dtp_person_datembauch
            // 
            this.dtp_person_datembauch.Location = new System.Drawing.Point(371, 128);
            this.dtp_person_datembauch.Name = "dtp_person_datembauch";
            this.dtp_person_datembauch.Size = new System.Drawing.Size(20, 20);
            this.dtp_person_datembauch.TabIndex = 35;
            // 
            // dtp_person_datevisitmed
            // 
            this.dtp_person_datevisitmed.Location = new System.Drawing.Point(371, 151);
            this.dtp_person_datevisitmed.Name = "dtp_person_datevisitmed";
            this.dtp_person_datevisitmed.Size = new System.Drawing.Size(20, 20);
            this.dtp_person_datevisitmed.TabIndex = 36;
            // 
            // ModificationPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 372);
            this.Controls.Add(this.dtp_person_datevisitmed);
            this.Controls.Add(this.dtp_person_datembauch);
            this.Controls.Add(this.chkb_person_bees);
            this.Controls.Add(this.chkb_person_pcote);
            this.Controls.Add(this.btn_ShowPersonnel);
            this.Controls.Add(this.btn_DeletePersonnel);
            this.Controls.Add(this.btn_ChangePersonnel);
            this.Controls.Add(this.btn_AddPersonnel);
            this.Controls.Add(this.txtb_person_nbees);
            this.Controls.Add(this.txtb_person_npcot);
            this.Controls.Add(this.txtb_person_typctr);
            this.Controls.Add(this.txtb_person_ncq);
            this.Controls.Add(this.txtb_person_tel);
            this.Controls.Add(this.txtb_person_ville);
            this.Controls.Add(this.txtb_person_cp);
            this.Controls.Add(this.txtb_person_adresse);
            this.Controls.Add(this.txtb_person_prenom);
            this.Controls.Add(this.txtb_person_nom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_PersonnelModifier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificationPersonnel";
            this.Text = "ModificationPersonnel";
            this.Load += new System.EventHandler(this.ModificationPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonnelModifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PersonnelModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtb_person_nom;
        private System.Windows.Forms.TextBox txtb_person_prenom;
        private System.Windows.Forms.TextBox txtb_person_adresse;
        private System.Windows.Forms.TextBox txtb_person_cp;
        private System.Windows.Forms.TextBox txtb_person_ville;
        private System.Windows.Forms.TextBox txtb_person_tel;
        private System.Windows.Forms.TextBox txtb_person_ncq;
        private System.Windows.Forms.TextBox txtb_person_typctr;
        private System.Windows.Forms.TextBox txtb_person_npcot;
        private System.Windows.Forms.TextBox txtb_person_nbees;
        private System.Windows.Forms.Button btn_AddPersonnel;
        private System.Windows.Forms.Button btn_ChangePersonnel;
        private System.Windows.Forms.Button btn_DeletePersonnel;
        private System.Windows.Forms.Button btn_ShowPersonnel;
        private System.Windows.Forms.CheckBox chkb_person_pcote;
        private System.Windows.Forms.CheckBox chkb_person_bees;
        private System.Windows.Forms.DateTimePicker dtp_person_datembauch;
        private System.Windows.Forms.DateTimePicker dtp_person_datevisitmed;
    }
}