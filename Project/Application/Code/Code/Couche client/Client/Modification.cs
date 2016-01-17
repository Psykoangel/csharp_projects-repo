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
    public partial class Modification : Form
    {

        private System.Data.DataSet dataset;
        private Code.Mapping.Client.CL_gPcs_Client client;

        public Modification()
        {
            InitializeComponent();
        }

        private void Modification_Load(object sender, EventArgs e)
        {
            this.dataset = new System.Data.DataSet();
            this.client = new Code.Mapping.Client.CL_gPcs_Client();
        }

        private void btn_add_client_Click( object sender, EventArgs e )
        {
            this.client.pcs_ajouterClient(txtb_client_nom.Text, txtb_client_prenom.Text, txtb_client_adresse.Text, int.Parse(txtb_client_cp.Text), txtb_client_ville.Text, txtb_client_datenaiss.Text, DateTime.ParseExact(txtb_client_tel.Text, "dd/MM/yyyy", null), chkb_client_pcot.Checked, txtb_client_nbreserv.Text);
        }

        private void btn_change_client_Click( object sender, EventArgs e )
        {
            this.client.pcs_modifierClient(int.Parse(txtb_client_id.Text), txtb_client_nom.Text, txtb_client_prenom.Text, txtb_client_adresse.Text, int.Parse(txtb_client_cp.Text), txtb_client_ville.Text, txtb_client_tel.Text, DateTime.ParseExact(txtb_client_datenaiss.Text, "dd/MM/yyyy", null), chkb_client_pcot.Checked, txtb_client_npcot.Text);
        }

        private void btn_delete_client_Click( object sender, EventArgs e )
        {
            this.client.pcs_supprimerClient(int.Parse(txtb_client_id.Text));
        }

        private void select_AClient2_Click( object sender, EventArgs e )
        {
            this.client = new Code.Mapping.Client.CL_gPcs_Client();
            this.dataset = new System.Data.DataSet();
            this.dataset = client.pcs_afficherTousLesClients("rows");
            this.dataGridView1.DataSource = this.dataset.Tables["rows"];
        }

    }
}
