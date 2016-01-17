using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A1_CS_WS4._3_Couche_Client
{
    public partial class frm_rechercherPersonne : Form
    {
        private NS_Layer_gPcs.CL_gPcs_Personnes gPcs_Personnes;
        private NS_Layer_gPcs.CL_gPcs_Adresses gPcs_Adresses;
        private System.Data.DataSet oDS;

        public frm_rechercherPersonne()
        {
            InitializeComponent();
        }

        private void btn_RP_search_Click( object sender, EventArgs e )
        {
            this.oDS = this.gPcs_Personnes.pcs_rechercherUnePersonne(this.txt_RP_searchNom.Text, "rowsPersonne");
            this.dgv_dataSearch.DataSource = this.oDS.Tables["rowsPersonne"];
        }

        private void btn_RP_addAdresse_Click( object sender, EventArgs e )
        {
            this.gPcs_Adresses.ajouterUneAdressePersonne(Int32Converter(this.txt_id_perso.Text), this.txt_RP_adresse.Text, this.txt_RP_ville.Text, this.txt_RP_cp.Text);
        }

        private int Int32Converter( string p )
        {
            throw new NotImplementedException();
        }
    }
}
