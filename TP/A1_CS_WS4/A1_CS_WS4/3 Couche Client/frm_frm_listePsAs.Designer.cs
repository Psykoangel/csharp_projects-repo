namespace A1_CS_WS4._3_Couche_Client
{
    partial class frm_frm_listePsAs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDDWS4nDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDD_WS4nDataSet = new A1_CS_WS4.BDD_WS4nDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDWS4nDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_WS4nDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bDDWS4nDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 309);
            this.dataGridView1.TabIndex = 0;
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
            // frm_frm_listePsAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 363);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_frm_listePsAs";
            this.Text = "Liste globale des personnes";
            this.Load += new System.EventHandler(this.frm_frm_listePsAs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDWS4nDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_WS4nDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bDDWS4nDataSetBindingSource;
        private BDD_WS4nDataSet bDD_WS4nDataSet;
    }
}