namespace Gestion_Client_v1
{
    partial class Liste_complete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste_complete));
            this.dgv_liste_complete = new System.Windows.Forms.DataGridView();
            this.btn_selectAClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_complete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_liste_complete
            // 
            this.dgv_liste_complete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_complete.Location = new System.Drawing.Point(12, 12);
            this.dgv_liste_complete.Name = "dgv_liste_complete";
            this.dgv_liste_complete.Size = new System.Drawing.Size(512, 294);
            this.dgv_liste_complete.TabIndex = 0;
            // 
            // btn_selectAClient
            // 
            this.btn_selectAClient.Location = new System.Drawing.Point(167, 312);
            this.btn_selectAClient.Name = "btn_selectAClient";
            this.btn_selectAClient.Size = new System.Drawing.Size(226, 23);
            this.btn_selectAClient.TabIndex = 1;
            this.btn_selectAClient.Text = "Afficher la liste complète des clients";
            this.btn_selectAClient.UseVisualStyleBackColor = true;
            // 
            // Liste_complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 347);
            this.Controls.Add(this.btn_selectAClient);
            this.Controls.Add(this.dgv_liste_complete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Liste_complete";
            this.Text = "Liste complète des clients";
            this.Load += new System.EventHandler(this.Liste_complete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_complete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_liste_complete;
        private System.Windows.Forms.Button btn_selectAClient;
    }
}