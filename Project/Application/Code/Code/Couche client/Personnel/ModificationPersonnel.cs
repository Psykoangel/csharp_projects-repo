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
    public partial class ModificationPersonnel : Form
    {
        private System.Data.DataSet dataset;
        private Couche_métier_Personnel.CL_gPcs_Personnel personnel;

        public ModificationPersonnel()
        {
            InitializeComponent();
        }

        private void ModificationPersonnel_Load(object sender, EventArgs e)
        {
            this.personnel = new Couche_métier_Personnel.CL_gPcs_Personnel();
            this.dataset = new System.Data.DataSet();
        }


        //SOUCIS: COMMENT TRANSFORMER UNE TEXTBOX EN INT?
        private void btn_AddPersonnel_Click(object sender, EventArgs e)
        {
            this.personnel.pcs_ajouterUnEmploye(txtb_person_nom.Text, txtb_person_prenom.Text, txtb_person_adresse.Text, int.Parse(txtb_person_cp.Text), txtb_person_ville.Text, txtb_person_tel.Text, txtb_person_ncq.Text, dtp_person_datembauch.Value, dtp_person_datevisitmed.Value, txtb_person_typctr.Text, chkb_person_pcote.Checked, txtb_person_npcot.Text, chkb_person_bees.Checked, txtb_person_nbees.Text);
        }

        private void btn_ChangePersonnel_Click(object sender, EventArgs e)
        {
            this.personnel.pcs_modifierUnEmploye(txtb_person_nom.Text, txtb_person_prenom.Text, txtb_person_adresse.Text, int.Parse(txtb_person_cp.Text), txtb_person_ville.Text, txtb_person_tel.Text, txtb_person_ncq.Text, dtp_person_datembauch.Value, dtp_person_datevisitmed.Value, txtb_person_typctr.Text, chkb_person_pcote.Checked, txtb_person_npcot.Text, chkb_person_bees.Checked, txtb_person_nbees.Text);
        }

        private void btn_DeletePersonnel_Click(object sender, EventArgs e)
        {
            this.personnel.pcs_supprimerUnEmploye(txtb_person_nom.Text);
        }

        private void btn_ShowPersonnel_Click(object sender, EventArgs e)
        {
            this.personnel.pcs_afficherTousLePersonnel("rows");
            this.dgv_PersonnelModifier.DataSource = this.dataset.Tables["rows"];
        }

        //ICI IL FAUDRA ENCORE BLOQUER LES BOUTONS!
    }
}
