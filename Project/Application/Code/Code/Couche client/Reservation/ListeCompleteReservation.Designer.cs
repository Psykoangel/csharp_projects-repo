namespace GestionReservation.CoucheClientReservation
{
    partial class ListeCompleteReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeCompleteReservation));
            this.dgv_ListeCompleteReservation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_IdReservation = new System.Windows.Forms.TextBox();
            this.btn_DetailReservation = new System.Windows.Forms.Button();
            this.btn_ModifierFicheDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeCompleteReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListeCompleteReservation
            // 
            this.dgv_ListeCompleteReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeCompleteReservation.Location = new System.Drawing.Point(12, 12);
            this.dgv_ListeCompleteReservation.Name = "dgv_ListeCompleteReservation";
            this.dgv_ListeCompleteReservation.Size = new System.Drawing.Size(441, 326);
            this.dgv_ListeCompleteReservation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Détail d\'une réservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Réservation";
            // 
            // tb_IdReservation
            // 
            this.tb_IdReservation.Location = new System.Drawing.Point(551, 41);
            this.tb_IdReservation.Name = "tb_IdReservation";
            this.tb_IdReservation.Size = new System.Drawing.Size(100, 20);
            this.tb_IdReservation.TabIndex = 3;
            // 
            // btn_DetailReservation
            // 
            this.btn_DetailReservation.Location = new System.Drawing.Point(477, 67);
            this.btn_DetailReservation.Name = "btn_DetailReservation";
            this.btn_DetailReservation.Size = new System.Drawing.Size(174, 40);
            this.btn_DetailReservation.TabIndex = 4;
            this.btn_DetailReservation.Text = "Afficher";
            this.btn_DetailReservation.UseVisualStyleBackColor = true;
            // 
            // btn_ModifierFicheDetail
            // 
            this.btn_ModifierFicheDetail.Location = new System.Drawing.Point(477, 113);
            this.btn_ModifierFicheDetail.Name = "btn_ModifierFicheDetail";
            this.btn_ModifierFicheDetail.Size = new System.Drawing.Size(174, 40);
            this.btn_ModifierFicheDetail.TabIndex = 6;
            this.btn_ModifierFicheDetail.Text = "Ajouter, supprimer ou modifier";
            this.btn_ModifierFicheDetail.UseVisualStyleBackColor = true;
            // 
            // ListeCompleteReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 350);
            this.Controls.Add(this.btn_ModifierFicheDetail);
            this.Controls.Add(this.btn_DetailReservation);
            this.Controls.Add(this.tb_IdReservation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ListeCompleteReservation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeCompleteReservation";
            this.Text = "Fiche complète des réservations";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeCompleteReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListeCompleteReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_IdReservation;
        private System.Windows.Forms.Button btn_DetailReservation;
        private System.Windows.Forms.Button btn_ModifierFicheDetail;
    }
}