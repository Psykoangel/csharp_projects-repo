namespace GestionPersonel
{
    partial class AbsencePersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsencePersonnel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_NomPersonnel2 = new System.Windows.Forms.Label();
            this.tb_NomPersonnel2 = new System.Windows.Forms.TextBox();
            this.btn_InactivitePersonnel = new System.Windows.Forms.Button();
            this.btn_SelectAInactivite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // l_NomPersonnel2
            // 
            this.l_NomPersonnel2.AutoSize = true;
            this.l_NomPersonnel2.Location = new System.Drawing.Point(12, 296);
            this.l_NomPersonnel2.Name = "l_NomPersonnel2";
            this.l_NomPersonnel2.Size = new System.Drawing.Size(29, 13);
            this.l_NomPersonnel2.TabIndex = 1;
            this.l_NomPersonnel2.Text = "Nom";
            // 
            // tb_NomPersonnel2
            // 
            this.tb_NomPersonnel2.Location = new System.Drawing.Point(65, 293);
            this.tb_NomPersonnel2.Name = "tb_NomPersonnel2";
            this.tb_NomPersonnel2.Size = new System.Drawing.Size(100, 20);
            this.tb_NomPersonnel2.TabIndex = 2;
            // 
            // btn_InactivitePersonnel
            // 
            this.btn_InactivitePersonnel.Location = new System.Drawing.Point(15, 319);
            this.btn_InactivitePersonnel.Name = "btn_InactivitePersonnel";
            this.btn_InactivitePersonnel.Size = new System.Drawing.Size(150, 23);
            this.btn_InactivitePersonnel.TabIndex = 3;
            this.btn_InactivitePersonnel.Text = "Afficher";
            this.btn_InactivitePersonnel.UseVisualStyleBackColor = true;
            this.btn_InactivitePersonnel.Click += new System.EventHandler(this.btn_InactivitePersonnel_Click);
            // 
            // btn_SelectAInactivite
            // 
            this.btn_SelectAInactivite.Location = new System.Drawing.Point(340, 293);
            this.btn_SelectAInactivite.Name = "btn_SelectAInactivite";
            this.btn_SelectAInactivite.Size = new System.Drawing.Size(118, 50);
            this.btn_SelectAInactivite.TabIndex = 4;
            this.btn_SelectAInactivite.Text = "Afficher les absences de tous le personnel";
            this.btn_SelectAInactivite.UseVisualStyleBackColor = true;
            this.btn_SelectAInactivite.Click += new System.EventHandler(this.btn_SelectAInactivite_Click);
            // 
            // AbsencePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 353);
            this.Controls.Add(this.btn_SelectAInactivite);
            this.Controls.Add(this.btn_InactivitePersonnel);
            this.Controls.Add(this.tb_NomPersonnel2);
            this.Controls.Add(this.l_NomPersonnel2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbsencePersonnel";
            this.Text = "Périodes d\'inactivités";
            this.Load += new System.EventHandler(this.AbsencePersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_NomPersonnel2;
        private System.Windows.Forms.TextBox tb_NomPersonnel2;
        private System.Windows.Forms.Button btn_InactivitePersonnel;
        private System.Windows.Forms.Button btn_SelectAInactivite;
    }
}