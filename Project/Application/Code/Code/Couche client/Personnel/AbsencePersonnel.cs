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
    public partial class AbsencePersonnel : Form
    {
        private Couche_métier_Personnel.CL_gPcs_Personnel personnel;
        private System.Data.DataSet dataset;

        public AbsencePersonnel()
        {
            InitializeComponent();
        }

        private void AbsencePersonnel_Load(object sender, EventArgs e)
        {
            this.personnel = new Couche_métier_Personnel.CL_gPcs_Personnel();
            this.dataset = new System.Data.DataSet();
        }

        private void btn_InactivitePersonnel_Click(object sender, EventArgs e)
        {
            this.personnel.pcs_afficherUneAbsence(this.tb_NomPersonnel2.Text, "rows");
            this.dataGridView1.DataSource = this.dataset.Tables["rows"];
        }

        private void btn_SelectAInactivite_Click(object sender, EventArgs e)
        {
            this.personnel.pcs_afficherToutesLesAbsences("rows");
            this.dataGridView1.DataSource = this.dataset.Tables["rows"];
        }
    }
}
