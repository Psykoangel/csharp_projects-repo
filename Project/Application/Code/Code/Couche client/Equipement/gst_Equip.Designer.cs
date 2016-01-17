namespace Code.Couche_IHM
{
    partial class gst_Equip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gst_Equip));
            this.gpb_equip = new System.Windows.Forms.GroupBox();
            this.dgv_equip = new System.Windows.Forms.DataGridView();
            this.btn_add_equip = new System.Windows.Forms.Button();
            this.btn_mdf_equip = new System.Windows.Forms.Button();
            this.btn_del_equip = new System.Windows.Forms.Button();
            this.gpb_dtl_equip = new System.Windows.Forms.GroupBox();
            this.chkb_equip_loc = new System.Windows.Forms.CheckBox();
            this.chkb_equip_stock = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_equip_pcrht03 = new System.Windows.Forms.TextBox();
            this.txtb_equip_pcrht02 = new System.Windows.Forms.TextBox();
            this.txtb_equip_pcrht01 = new System.Windows.Forms.TextBox();
            this.chkb_equip_motor = new System.Windows.Forms.CheckBox();
            this.txtb_equip_id = new System.Windows.Forms.TextBox();
            this.txt_equip_descr = new System.Windows.Forms.TextBox();
            this.txtb_equip_puissance = new System.Windows.Forms.TextBox();
            this.txtb_equip_name = new System.Windows.Forms.TextBox();
            this.lb_prcht_equip = new System.Windows.Forms.Label();
            this.lb_equip_puissance = new System.Windows.Forms.Label();
            this.lb_descr_equip = new System.Windows.Forms.Label();
            this.lb_nom_equip = new System.Windows.Forms.Label();
            this.gpb_equip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equip)).BeginInit();
            this.gpb_dtl_equip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_equip
            // 
            this.gpb_equip.Controls.Add(this.dgv_equip);
            this.gpb_equip.Location = new System.Drawing.Point(10, 10);
            this.gpb_equip.Name = "gpb_equip";
            this.gpb_equip.Size = new System.Drawing.Size(400, 450);
            this.gpb_equip.TabIndex = 0;
            this.gpb_equip.TabStop = false;
            this.gpb_equip.Text = "Equipement";
            // 
            // dgv_equip
            // 
            this.dgv_equip.AllowUserToResizeColumns = false;
            this.dgv_equip.AllowUserToResizeRows = false;
            this.dgv_equip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_equip.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_equip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_equip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equip.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_equip.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_equip.Location = new System.Drawing.Point(2, 21);
            this.dgv_equip.MultiSelect = false;
            this.dgv_equip.Name = "dgv_equip";
            this.dgv_equip.ReadOnly = true;
            this.dgv_equip.RowHeadersVisible = false;
            this.dgv_equip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_equip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_equip.Size = new System.Drawing.Size(394, 413);
            this.dgv_equip.TabIndex = 0;
            // 
            // btn_add_equip
            // 
            this.btn_add_equip.Location = new System.Drawing.Point(8, 394);
            this.btn_add_equip.Name = "btn_add_equip";
            this.btn_add_equip.Size = new System.Drawing.Size(112, 38);
            this.btn_add_equip.TabIndex = 1;
            this.btn_add_equip.Text = "Ajouter";
            this.btn_add_equip.UseVisualStyleBackColor = true;
            this.btn_add_equip.Click += new System.EventHandler(this.btn_add_equip_Click);
            // 
            // btn_mdf_equip
            // 
            this.btn_mdf_equip.Location = new System.Drawing.Point(126, 394);
            this.btn_mdf_equip.Name = "btn_mdf_equip";
            this.btn_mdf_equip.Size = new System.Drawing.Size(112, 38);
            this.btn_mdf_equip.TabIndex = 2;
            this.btn_mdf_equip.Text = "Modifier";
            this.btn_mdf_equip.UseVisualStyleBackColor = true;
            this.btn_mdf_equip.Click += new System.EventHandler(this.btn_mdf_equip_Click);
            // 
            // btn_del_equip
            // 
            this.btn_del_equip.Location = new System.Drawing.Point(244, 394);
            this.btn_del_equip.Name = "btn_del_equip";
            this.btn_del_equip.Size = new System.Drawing.Size(112, 38);
            this.btn_del_equip.TabIndex = 3;
            this.btn_del_equip.Text = "Supprimer";
            this.btn_del_equip.UseVisualStyleBackColor = true;
            this.btn_del_equip.Click += new System.EventHandler(this.btn_del_equip_Click);
            // 
            // gpb_dtl_equip
            // 
            this.gpb_dtl_equip.Controls.Add(this.chkb_equip_loc);
            this.gpb_dtl_equip.Controls.Add(this.chkb_equip_stock);
            this.gpb_dtl_equip.Controls.Add(this.label3);
            this.gpb_dtl_equip.Controls.Add(this.label2);
            this.gpb_dtl_equip.Controls.Add(this.label1);
            this.gpb_dtl_equip.Controls.Add(this.txtb_equip_pcrht03);
            this.gpb_dtl_equip.Controls.Add(this.txtb_equip_pcrht02);
            this.gpb_dtl_equip.Controls.Add(this.txtb_equip_pcrht01);
            this.gpb_dtl_equip.Controls.Add(this.chkb_equip_motor);
            this.gpb_dtl_equip.Controls.Add(this.txtb_equip_id);
            this.gpb_dtl_equip.Controls.Add(this.btn_del_equip);
            this.gpb_dtl_equip.Controls.Add(this.txt_equip_descr);
            this.gpb_dtl_equip.Controls.Add(this.btn_mdf_equip);
            this.gpb_dtl_equip.Controls.Add(this.btn_add_equip);
            this.gpb_dtl_equip.Controls.Add(this.txtb_equip_puissance);
            this.gpb_dtl_equip.Controls.Add(this.txtb_equip_name);
            this.gpb_dtl_equip.Controls.Add(this.lb_prcht_equip);
            this.gpb_dtl_equip.Controls.Add(this.lb_equip_puissance);
            this.gpb_dtl_equip.Controls.Add(this.lb_descr_equip);
            this.gpb_dtl_equip.Controls.Add(this.lb_nom_equip);
            this.gpb_dtl_equip.Location = new System.Drawing.Point(422, 12);
            this.gpb_dtl_equip.Name = "gpb_dtl_equip";
            this.gpb_dtl_equip.Size = new System.Drawing.Size(361, 448);
            this.gpb_dtl_equip.TabIndex = 1;
            this.gpb_dtl_equip.TabStop = false;
            this.gpb_dtl_equip.Text = "Fiche détaillée de l\'équipement";
            this.gpb_dtl_equip.Visible = false;
            // 
            // chkb_equip_loc
            // 
            this.chkb_equip_loc.AutoSize = true;
            this.chkb_equip_loc.Location = new System.Drawing.Point(171, 243);
            this.chkb_equip_loc.Name = "chkb_equip_loc";
            this.chkb_equip_loc.Size = new System.Drawing.Size(78, 17);
            this.chkb_equip_loc.TabIndex = 28;
            this.chkb_equip_loc.Text = "en location";
            this.chkb_equip_loc.UseVisualStyleBackColor = true;
            // 
            // chkb_equip_stock
            // 
            this.chkb_equip_stock.AutoSize = true;
            this.chkb_equip_stock.Location = new System.Drawing.Point(53, 243);
            this.chkb_equip_stock.Name = "chkb_equip_stock";
            this.chkb_equip_stock.Size = new System.Drawing.Size(67, 17);
            this.chkb_equip_stock.TabIndex = 27;
            this.chkb_equip_stock.Text = "en stock";
            this.chkb_equip_stock.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "pour deux heures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "pour une heure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "pour une demi heure";
            // 
            // txtb_equip_pcrht03
            // 
            this.txtb_equip_pcrht03.Location = new System.Drawing.Point(126, 339);
            this.txtb_equip_pcrht03.Name = "txtb_equip_pcrht03";
            this.txtb_equip_pcrht03.Size = new System.Drawing.Size(57, 20);
            this.txtb_equip_pcrht03.TabIndex = 23;
            // 
            // txtb_equip_pcrht02
            // 
            this.txtb_equip_pcrht02.Location = new System.Drawing.Point(126, 313);
            this.txtb_equip_pcrht02.Name = "txtb_equip_pcrht02";
            this.txtb_equip_pcrht02.Size = new System.Drawing.Size(57, 20);
            this.txtb_equip_pcrht02.TabIndex = 22;
            // 
            // txtb_equip_pcrht01
            // 
            this.txtb_equip_pcrht01.Location = new System.Drawing.Point(126, 287);
            this.txtb_equip_pcrht01.Name = "txtb_equip_pcrht01";
            this.txtb_equip_pcrht01.Size = new System.Drawing.Size(57, 20);
            this.txtb_equip_pcrht01.TabIndex = 21;
            // 
            // chkb_equip_motor
            // 
            this.chkb_equip_motor.AutoSize = true;
            this.chkb_equip_motor.Location = new System.Drawing.Point(13, 164);
            this.chkb_equip_motor.Name = "chkb_equip_motor";
            this.chkb_equip_motor.Size = new System.Drawing.Size(65, 17);
            this.chkb_equip_motor.TabIndex = 20;
            this.chkb_equip_motor.Text = "motorisé";
            this.chkb_equip_motor.UseVisualStyleBackColor = true;
            this.chkb_equip_motor.CheckedChanged += new System.EventHandler(this.chkb_equip_motor_CheckedChanged);
            // 
            // txtb_equip_id
            // 
            this.txtb_equip_id.Location = new System.Drawing.Point(126, 25);
            this.txtb_equip_id.Name = "txtb_equip_id";
            this.txtb_equip_id.Size = new System.Drawing.Size(38, 20);
            this.txtb_equip_id.TabIndex = 11;
            this.txtb_equip_id.Visible = false;
            // 
            // txt_equip_descr
            // 
            this.txt_equip_descr.Location = new System.Drawing.Point(126, 100);
            this.txt_equip_descr.Multiline = true;
            this.txt_equip_descr.Name = "txt_equip_descr";
            this.txt_equip_descr.Size = new System.Drawing.Size(209, 55);
            this.txt_equip_descr.TabIndex = 9;
            // 
            // txtb_equip_puissance
            // 
            this.txtb_equip_puissance.Location = new System.Drawing.Point(126, 187);
            this.txtb_equip_puissance.Name = "txtb_equip_puissance";
            this.txtb_equip_puissance.Size = new System.Drawing.Size(209, 20);
            this.txtb_equip_puissance.TabIndex = 6;
            // 
            // txtb_equip_name
            // 
            this.txtb_equip_name.Location = new System.Drawing.Point(126, 66);
            this.txtb_equip_name.Name = "txtb_equip_name";
            this.txtb_equip_name.Size = new System.Drawing.Size(209, 20);
            this.txtb_equip_name.TabIndex = 5;
            // 
            // lb_prcht_equip
            // 
            this.lb_prcht_equip.AutoSize = true;
            this.lb_prcht_equip.Location = new System.Drawing.Point(10, 287);
            this.lb_prcht_equip.Name = "lb_prcht_equip";
            this.lb_prcht_equip.Size = new System.Drawing.Size(97, 13);
            this.lb_prcht_equip.TabIndex = 4;
            this.lb_prcht_equip.Text = "Prix HT de location";
            // 
            // lb_equip_puissance
            // 
            this.lb_equip_puissance.AutoSize = true;
            this.lb_equip_puissance.Location = new System.Drawing.Point(10, 194);
            this.lb_equip_puissance.Name = "lb_equip_puissance";
            this.lb_equip_puissance.Size = new System.Drawing.Size(56, 13);
            this.lb_equip_puissance.TabIndex = 2;
            this.lb_equip_puissance.Text = "Puissance";
            // 
            // lb_descr_equip
            // 
            this.lb_descr_equip.AutoSize = true;
            this.lb_descr_equip.Location = new System.Drawing.Point(10, 101);
            this.lb_descr_equip.Name = "lb_descr_equip";
            this.lb_descr_equip.Size = new System.Drawing.Size(51, 13);
            this.lb_descr_equip.TabIndex = 1;
            this.lb_descr_equip.Text = "Descriptif";
            // 
            // lb_nom_equip
            // 
            this.lb_nom_equip.AutoSize = true;
            this.lb_nom_equip.Location = new System.Drawing.Point(10, 72);
            this.lb_nom_equip.Name = "lb_nom_equip";
            this.lb_nom_equip.Size = new System.Drawing.Size(29, 13);
            this.lb_nom_equip.TabIndex = 0;
            this.lb_nom_equip.Text = "Nom";
            // 
            // gst_Equip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 467);
            this.Controls.Add(this.gpb_dtl_equip);
            this.Controls.Add(this.gpb_equip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gst_Equip";
            this.Text = "Gestion de l\'équipement";
            this.Load += new System.EventHandler(this.gst_Equip_Load);
            this.gpb_equip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equip)).EndInit();
            this.gpb_dtl_equip.ResumeLayout(false);
            this.gpb_dtl_equip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_equip;
        private System.Windows.Forms.Button btn_del_equip;
        private System.Windows.Forms.Button btn_mdf_equip;
        private System.Windows.Forms.Button btn_add_equip;
        private System.Windows.Forms.GroupBox gpb_dtl_equip;
        private System.Windows.Forms.TextBox txt_equip_descr;
        private System.Windows.Forms.TextBox txtb_equip_puissance;
        private System.Windows.Forms.TextBox txtb_equip_name;
        private System.Windows.Forms.Label lb_prcht_equip;
        private System.Windows.Forms.Label lb_equip_puissance;
        private System.Windows.Forms.Label lb_descr_equip;
        private System.Windows.Forms.Label lb_nom_equip;
        private System.Windows.Forms.TextBox txtb_equip_id;
        private System.Windows.Forms.CheckBox chkb_equip_loc;
        private System.Windows.Forms.CheckBox chkb_equip_stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_equip_pcrht03;
        private System.Windows.Forms.TextBox txtb_equip_pcrht02;
        private System.Windows.Forms.TextBox txtb_equip_pcrht01;
        private System.Windows.Forms.CheckBox chkb_equip_motor;
        public System.Windows.Forms.DataGridView dgv_equip;

    }
}