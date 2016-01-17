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
    public partial class frm_frm_listePsAs : Form
    {
        private NS_Layer_gPcs.CL_gPcs_Personnes gPcs_Personnes;
        private System.Data.DataSet oDS;

        public frm_frm_listePsAs()
        {
            InitializeComponent();
        }

        private void frm_frm_listePsAs_Load( object sender, EventArgs e )
        {
            this.oDS = this.gPcs_Personnes.pcs_afficherToutesLesPersonnesAdresses("PersonneRows");
            this.dataGridView1.DataSource = this.oDS.Tables["PersonneRows"];
        }
    }
}
