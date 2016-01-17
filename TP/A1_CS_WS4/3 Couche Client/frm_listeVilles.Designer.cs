namespace A1_CS_WS4._3_Couche_Client
{
    partial class frm_listeVilles
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
            this.components = new System.ComponentModel.Container();
            this.dgv_tv = new System.Windows.Forms.DataGridView();
            this.bDDWS4nDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDD_WS4nDataSet = new A1_CS_WS4.BDD_WS4nDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDWS4nDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_WS4nDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tv
            // 
            this.dgv_tv.AutoGenerateColumns = false;
            this.dgv_tv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tv.DataSource = this.bDDWS4nDataSetBindingSource;
            this.dgv_tv.Location = new System.Drawing.Point(17, 45);
            this.dgv_tv.Name = "dgv_tv";
            this.dgv_tv.Size = new System.Drawing.Size(463, 234);
            this.dgv_tv.TabIndex = 0;
            // 
            // bDDWS4nDataSetBindingSource
            // 
            this.bDDWS4nDataSetBindingSource.DataSource = this.bDD_WS4nDataSet;
            this.bDDWS4nDataSetBindingSource.Position = 0;
            // 
            // bDD_WS4nDataSet
            // 
            this.bDD_WS4nDataSet.DataSetName = "BDD_WS4nDataSet";
            this.bDD_WS4nDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_listeVilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 331);
            this.Controls.Add(this.dgv_tv);
            this.Name = "frm_listeVilles";
            this.Text = "Liste des villes";
            this.Load += new System.EventHandler(this.frm_listeVilles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDWS4nDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_WS4nDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tv;
        private System.Windows.Forms.BindingSource bDDWS4nDataSetBindingSource;
        private BDD_WS4nDataSet bDD_WS4nDataSet;
    }
}