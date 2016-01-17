namespace GestionPersonel
{
    partial class ListeCompletePersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeCompletePersonnel));
            this.dgv_liste_complete_personnel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_complete_personnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_liste_complete_personnel
            // 
            this.dgv_liste_complete_personnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_complete_personnel.Location = new System.Drawing.Point(12, 12);
            this.dgv_liste_complete_personnel.Name = "dgv_liste_complete_personnel";
            this.dgv_liste_complete_personnel.Size = new System.Drawing.Size(466, 330);
            this.dgv_liste_complete_personnel.TabIndex = 0;
            // 
            // ListeCompletePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 354);
            this.Controls.Add(this.dgv_liste_complete_personnel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeCompletePersonnel";
            this.Text = "Liste complète du personnel";
            this.Load += new System.EventHandler(this.ListeCompletePersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_complete_personnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_liste_complete_personnel;
    }
}