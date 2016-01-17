namespace A1_CS_WS4._3_Couche_Client
{
    partial class frm_rechercherPersonne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.txt_RP_searchNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RP_search = new System.Windows.Forms.Button();
            this.dgv_dataSearch = new System.Windows.Forms.DataGridView();
            this.txt_RP_adresse = new System.Windows.Forms.TextBox();
            this.txt_RP_ville = new System.Windows.Forms.TextBox();
            this.txt_RP_cp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_RP_addAdresse = new System.Windows.Forms.Button();
            this.txt_id_perso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_RP_searchNom
            // 
            this.txt_RP_searchNom.Location = new System.Drawing.Point(96, 27);
            this.txt_RP_searchNom.Name = "txt_RP_searchNom";
            this.txt_RP_searchNom.Size = new System.Drawing.Size(232, 20);
            this.txt_RP_searchNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom : ";
            // 
            // btn_RP_search
            // 
            this.btn_RP_search.Location = new System.Drawing.Point(59, 64);
            this.btn_RP_search.Name = "btn_RP_search";
            this.btn_RP_search.Size = new System.Drawing.Size(268, 26);
            this.btn_RP_search.TabIndex = 2;
            this.btn_RP_search.Text = "Rechercher";
            this.btn_RP_search.UseVisualStyleBackColor = true;
            this.btn_RP_search.Click += new System.EventHandler(this.btn_RP_search_Click);
            // 
            // dgv_dataSearch
            // 
            this.dgv_dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataSearch.Location = new System.Drawing.Point(60, 115);
            this.dgv_dataSearch.Name = "dgv_dataSearch";
            this.dgv_dataSearch.Size = new System.Drawing.Size(266, 178);
            this.dgv_dataSearch.TabIndex = 3;
            // 
            // txt_RP_adresse
            // 
            this.txt_RP_adresse.Location = new System.Drawing.Point(96, 325);
            this.txt_RP_adresse.Name = "txt_RP_adresse";
            this.txt_RP_adresse.Size = new System.Drawing.Size(229, 20);
            this.txt_RP_adresse.TabIndex = 4;
            // 
            // txt_RP_ville
            // 
            this.txt_RP_ville.Location = new System.Drawing.Point(96, 360);
            this.txt_RP_ville.Name = "txt_RP_ville";
            this.txt_RP_ville.Size = new System.Drawing.Size(229, 20);
            this.txt_RP_ville.TabIndex = 5;
            // 
            // txt_RP_cp
            // 
            this.txt_RP_cp.Location = new System.Drawing.Point(97, 395);
            this.txt_RP_cp.Name = "txt_RP_cp";
            this.txt_RP_cp.Size = new System.Drawing.Size(229, 20);
            this.txt_RP_cp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adresse : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ville : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CP : ";
            // 
            // btn_RP_addAdresse
            // 
            this.btn_RP_addAdresse.Location = new System.Drawing.Point(38, 430);
            this.btn_RP_addAdresse.Name = "btn_RP_addAdresse";
            this.btn_RP_addAdresse.Size = new System.Drawing.Size(289, 25);
            this.btn_RP_addAdresse.TabIndex = 10;
            this.btn_RP_addAdresse.Text = "Ajouter une adresse à cette personne";
            this.btn_RP_addAdresse.UseVisualStyleBackColor = true;
            this.btn_RP_addAdresse.Click += new System.EventHandler(this.btn_RP_addAdresse_Click);
            // 
            // txt_id_perso
            // 
            this.txt_id_perso.Location = new System.Drawing.Point(92, 298);
            this.txt_id_perso.Name = "txt_id_perso";
            this.txt_id_perso.Size = new System.Drawing.Size(100, 20);
            this.txt_id_perso.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID : ";
            // 
            // frm_rechercherPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 466);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_id_perso);
            this.Controls.Add(this.btn_RP_addAdresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_RP_cp);
            this.Controls.Add(this.txt_RP_ville);
            this.Controls.Add(this.txt_RP_adresse);
            this.Controls.Add(this.dgv_dataSearch);
            this.Controls.Add(this.btn_RP_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RP_searchNom);
            this.Name = "frm_rechercherPersonne";
            this.Text = "Rechercher une Personne";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_RP_searchNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RP_search;
        private System.Windows.Forms.DataGridView dgv_dataSearch;
        private System.Windows.Forms.TextBox txt_RP_adresse;
        private System.Windows.Forms.TextBox txt_RP_ville;
        private System.Windows.Forms.TextBox txt_RP_cp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_RP_addAdresse;
        private System.Windows.Forms.TextBox txt_id_perso;
        private System.Windows.Forms.Label label5;
    }
}