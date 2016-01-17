using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionPersonel
{
    public partial class FicheDetailPersonnel : Form
    {
        private System.Data.DataSet dataset;
        private Couche_métier_Personnel.CL_gPcs_Personnel personnel;

        public FicheDetailPersonnel()
        {
            InitializeComponent();
        }

        private void FicheDetailPersonnel_Load(object sender, EventArgs e)
        {
            this.personnel = new Couche_métier_Personnel.CL_gPcs_Personnel();
            this.dataset = new System.Data.DataSet();
        }

        private void btn_FicheDetailPersonnel_Click(object sender, EventArgs e)
        {
            this.personnel.pcs_afficherUnEmploye(this.tb_NomPersonnel.Text, "rows");
            this.dataGridView1.DataSource = this.dataset.Tables["rows"];
        }
    }
}
