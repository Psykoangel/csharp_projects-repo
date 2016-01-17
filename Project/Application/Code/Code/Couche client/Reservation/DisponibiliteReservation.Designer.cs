namespace GestionReservation.CoucheClientReservation
{
    partial class DisponibiliteReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisponibiliteReservation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_HeureDebut = new System.Windows.Forms.TextBox();
            this.tb_HeureFin = new System.Windows.Forms.TextBox();
            this.cb_brevet = new System.Windows.Forms.CheckBox();
            this.dgv_ListeMonoDispo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeMonoDispo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heure début";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heure fin";
            // 
            // tb_HeureDebut
            // 
            this.tb_HeureDebut.Location = new System.Drawing.Point(100, 16);
            this.tb_HeureDebut.Name = "tb_HeureDebut";
            this.tb_HeureDebut.Size = new System.Drawing.Size(100, 20);
            this.tb_HeureDebut.TabIndex = 2;
            // 
            // tb_HeureFin
            // 
            this.tb_HeureFin.Location = new System.Drawing.Point(100, 42);
            this.tb_HeureFin.Name = "tb_HeureFin";
            this.tb_HeureFin.Size = new System.Drawing.Size(100, 20);
            this.tb_HeureFin.TabIndex = 3;
            // 
            // cb_brevet
            // 
            this.cb_brevet.AutoSize = true;
            this.cb_brevet.Location = new System.Drawing.Point(268, 18);
            this.cb_brevet.Name = "cb_brevet";
            this.cb_brevet.Size = new System.Drawing.Size(108, 17);
            this.cb_brevet.TabIndex = 5;
            this.cb_brevet.Text = "Scooter des mers";
            this.cb_brevet.UseVisualStyleBackColor = true;
            // 
            // dgv_ListeMonoDispo
            // 
            this.dgv_ListeMonoDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeMonoDispo.Location = new System.Drawing.Point(12, 68);
            this.dgv_ListeMonoDispo.Name = "dgv_ListeMonoDispo";
            this.dgv_ListeMonoDispo.Size = new System.Drawing.Size(517, 273);
            this.dgv_ListeMonoDispo.TabIndex = 6;
            // 
            // DisponibiliteReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 353);
            this.Controls.Add(this.dgv_ListeMonoDispo);
            this.Controls.Add(this.cb_brevet);
            this.Controls.Add(this.tb_HeureFin);
            this.Controls.Add(this.tb_HeureDebut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisponibiliteReservation";
            this.Text = "Liste des moniteurs disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeMonoDispo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_HeureDebut;
        private System.Windows.Forms.TextBox tb_HeureFin;
        private System.Windows.Forms.CheckBox cb_brevet;
        private System.Windows.Forms.DataGridView dgv_ListeMonoDispo;
    }
}