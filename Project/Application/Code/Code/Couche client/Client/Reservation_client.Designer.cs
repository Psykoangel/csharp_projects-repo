namespace Gestion_Client_v1
{
    partial class Reservation_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation_client));
            this.l_nom_client1 = new System.Windows.Forms.Label();
            this.tb_nom_client1 = new System.Windows.Forms.TextBox();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.dgv_reservation_client = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation_client)).BeginInit();
            this.SuspendLayout();
            // 
            // l_nom_client1
            // 
            this.l_nom_client1.AutoSize = true;
            this.l_nom_client1.Location = new System.Drawing.Point(12, 9);
            this.l_nom_client1.Name = "l_nom_client1";
            this.l_nom_client1.Size = new System.Drawing.Size(57, 13);
            this.l_nom_client1.TabIndex = 0;
            this.l_nom_client1.Text = "Nom client";
            // 
            // tb_nom_client1
            // 
            this.tb_nom_client1.Location = new System.Drawing.Point(75, 6);
            this.tb_nom_client1.Name = "tb_nom_client1";
            this.tb_nom_client1.Size = new System.Drawing.Size(100, 20);
            this.tb_nom_client1.TabIndex = 1;
            // 
            // btn_reservation
            // 
            this.btn_reservation.Location = new System.Drawing.Point(15, 32);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(160, 23);
            this.btn_reservation.TabIndex = 2;
            this.btn_reservation.Text = "Voir les réservations";
            this.btn_reservation.UseVisualStyleBackColor = true;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // dgv_reservation_client
            // 
            this.dgv_reservation_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservation_client.Location = new System.Drawing.Point(15, 61);
            this.dgv_reservation_client.Name = "dgv_reservation_client";
            this.dgv_reservation_client.Size = new System.Drawing.Size(483, 269);
            this.dgv_reservation_client.TabIndex = 3;
            // 
            // Reservation_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 342);
            this.Controls.Add(this.dgv_reservation_client);
            this.Controls.Add(this.btn_reservation);
            this.Controls.Add(this.tb_nom_client1);
            this.Controls.Add(this.l_nom_client1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reservation_client";
            this.Text = "Réservation d\'un client";
            this.Load += new System.EventHandler(this.Reservation_client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nom_client1;
        private System.Windows.Forms.TextBox tb_nom_client1;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.DataGridView dgv_reservation_client;
    }
}