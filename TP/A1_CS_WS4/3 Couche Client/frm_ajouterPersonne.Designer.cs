namespace A1_CS_WS4._3_Couche_Client
{
    partial class frm_ajouterPersonne
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
            this.txt_AP_nom = new System.Windows.Forms.TextBox();
            this.txt_AP_prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_AP_nom
            // 
            this.txt_AP_nom.Location = new System.Drawing.Point(64, 28);
            this.txt_AP_nom.Name = "txt_AP_nom";
            this.txt_AP_nom.Size = new System.Drawing.Size(199, 20);
            this.txt_AP_nom.TabIndex = 0;
            // 
            // txt_AP_prenom
            // 
            this.txt_AP_prenom.Location = new System.Drawing.Point(64, 54);
            this.txt_AP_prenom.Name = "txt_AP_prenom";
            this.txt_AP_prenom.Size = new System.Drawing.Size(199, 20);
            this.txt_AP_prenom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom :";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(64, 83);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(198, 23);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Enregistrer";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // frm_ajouterPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AP_prenom);
            this.Controls.Add(this.txt_AP_nom);
            this.Name = "frm_ajouterPersonne";
            this.Text = "Ajouter une personne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AP_nom;
        private System.Windows.Forms.TextBox txt_AP_prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_register;
    }
}