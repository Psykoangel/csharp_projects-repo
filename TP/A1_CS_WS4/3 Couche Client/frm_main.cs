using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A1_CS_WS4._3_Couche_Client;

namespace A1_CS_WS4
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            DialogResult result;
            this.toolStripStatusLabel.Text = "Welcome !!";

            result = MessageBox.Show("Welcome on C# Program, you will be connect to the dataBase.", "Welcome",
                                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.toolStripStatusLabel.Text = " dataBase connected";
            else
            {
                MessageBox.Show("Please quit the application and try later", "Attention", MessageBoxButtons.OK);
                this.toolStripStatusLabel.Text = "dataBase no connected";
            }

        }

        private void quitterToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form.ActiveForm.Close();
        }

        private void gestionDesPersonnesToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frm_ajouterPersonne ajouterPersonne = new frm_ajouterPersonne();
            ajouterPersonne.MdiParent = this;
            ajouterPersonne.Show();

            frm_frm_listePsAs afficherTout = new frm_frm_listePsAs();
            afficherTout.MdiParent = this;
            afficherTout.Show();

            frm_rechercherPersonne rechercherPersonne = new frm_rechercherPersonne();
            rechercherPersonne.MdiParent = this;
            rechercherPersonne.Show();
        }

        private void gestionDesAdressesToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frm_listeVilles listeVilles = new frm_listeVilles();
            listeVilles.MdiParent = this;
            listeVilles.Show();
        }
    }
}
