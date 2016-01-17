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
    public partial class frm_listeVilles : Form
    {
        private NS_Layer_gPcs.CL_gPcs_Adresses gPcs_Adresses;
        private System.Data.DataSet oDS;

        public frm_listeVilles()
        {
            InitializeComponent();
        }

        private void frm_listeVilles_Load( object sender, EventArgs e )
        {
            this.oDS = this.gPcs_Adresses.pcs_afficherLesVilles("villeRows");
            this.dgv_tv.DataSource = this.oDS.Tables["villeRows"];
        }

    }
}
