using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Client_v1
{
    public partial class Reservation_client : Form
    {
        private System.Data.DataSet dataset;
        private Code.Mapping.Client.CL_gPcs_Client client;

        public Reservation_client()
        {
            InitializeComponent();
        }

        private void Reservation_client_Load(object sender, EventArgs e)
        {
            this.client = new Code.Mapping.Client.CL_gPcs_Client();
            this.dataset = new System.Data.DataSet();
        }

        private void btn_reservation_Click( object sender, EventArgs e )
        {
            this.dataset = client.pcs_afficherReservationClient(this.tb_nom_client1.Text, "rows");
            this.dgv_reservation_client.DataSource = this.dataset.Tables["rows"];
        }
    }
}
