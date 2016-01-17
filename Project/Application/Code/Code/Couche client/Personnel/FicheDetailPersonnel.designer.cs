namespace GestionPersonel
{
    partial class FicheDetailPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheDetailPersonnel));
            this.l_NomPersonnel = new System.Windows.Forms.Label();
            this.tb_NomPersonnel = new System.Windows.Forms.TextBox();
            this.btn_FicheDetailPersonnel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_NomPersonnel
            // 
            this.l_NomPersonnel.AutoSize = true;
            this.l_NomPersonnel.Location = new System.Drawing.Point(12, 9);
            this.l_NomPersonnel.Name = "l_NomPersonnel";
            this.l_NomPersonnel.Size = new System.Drawing.Size(29, 13);
            this.l_NomPersonnel.TabIndex = 0;
            this.l_NomPersonnel.Text = "Nom";
            // 
            // tb_NomPersonnel
            // 
            this.tb_NomPersonnel.Location = new System.Drawing.Point(62, 6);
            this.tb_NomPersonnel.Name = "tb_NomPersonnel";
            this.tb_NomPersonnel.Size = new System.Drawing.Size(100, 20);
            this.tb_NomPersonnel.TabIndex = 1;
            // 
            // btn_FicheDetailPersonnel
            // 
            this.btn_FicheDetailPersonnel.Location = new System.Drawing.Point(15, 32);
            this.btn_FicheDetailPersonnel.Name = "btn_FicheDetailPersonnel";
            this.btn_FicheDetailPersonnel.Size = new System.Drawing.Size(147, 23);
            this.btn_FicheDetailPersonnel.TabIndex = 2;
            this.btn_FicheDetailPersonnel.Text = "Voir la fiche détaillée";
            this.btn_FicheDetailPersonnel.UseVisualStyleBackColor = true;
            this.btn_FicheDetailPersonnel.Click += new System.EventHandler(this.btn_FicheDetailPersonnel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 220);
            this.dataGridView1.TabIndex = 3;
            // 
            // FicheDetailPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 293);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_FicheDetailPersonnel);
            this.Controls.Add(this.tb_NomPersonnel);
            this.Controls.Add(this.l_NomPersonnel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FicheDetailPersonnel";
            this.Text = "Fiche détaillée d\'un membre du personnel";
            this.Load += new System.EventHandler(this.FicheDetailPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_NomPersonnel;
        private System.Windows.Forms.TextBox tb_NomPersonnel;
        private System.Windows.Forms.Button btn_FicheDetailPersonnel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}