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
    public partial class ListeCompletePersonnel : Form
    {
        private System.Data.DataSet dataset;
        private Couche_métier_Personnel.CL_gPcs_Personnel personnel;

        public ListeCompletePersonnel()
        {
            InitializeComponent();
        }

        private void ListeCompletePersonnel_Load(object sender, EventArgs e)
        {
            this.personnel = new Couche_métier_Personnel.CL_gPcs_Personnel();
            this.dataset = new System.Data.DataSet();
            this.dataset = personnel.pcs_afficherTousLePersonnel("rows");
            this.dgv_liste_complete_personnel.DataSource = this.dataset.Tables["rows"];
        }
    }
}
