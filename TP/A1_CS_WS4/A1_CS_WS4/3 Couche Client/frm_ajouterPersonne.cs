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
    public partial class frm_ajouterPersonne : Form
    {
        private NS_Layer_gPcs.CL_gPcs_Personnes gPcs_Personnes;
        private System.Data.DataSet oDS;

        public frm_ajouterPersonne()
        {
            InitializeComponent();
        }

        private void btn_register_Click( object sender, EventArgs e )
        {
            this.gPcs_Personnes.pcs_ajouterUnePersonne(this.txt_AP_nom.Text, this.txt_AP_prenom.Text);
        }

    }
}
