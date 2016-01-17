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
    public partial class Liste_complete : Form
    {

        private Code.Mapping.Client.CL_gPcs_Client client;
        private System.Data.DataSet dataset;

        public Liste_complete()
        {
            InitializeComponent();
        }

        private void Liste_complete_Load(object sender, EventArgs e)
        {
            this.client = new Code.Mapping.Client.CL_gPcs_Client();
            this.dataset = new System.Data.DataSet();
            this.dataset = client.pcs_afficherTousLesClients("rows");
            this.dgv_liste_complete.DataSource = this.dataset.Tables["rows"];
        }
    }
}
