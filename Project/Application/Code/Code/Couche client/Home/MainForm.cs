using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Code.Couche_IHM;
using GestionReservation.CoucheClientReservation;
using Gestion_Client_v1;
using GestionPersonel;

namespace Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region "Date et heure du form main"

            Timer dateTime_Main = new Timer();

            dateTime_Main.Tick += (sender, eventArgs) =>
                                      {
                                          DateTime dateTimeNow = DateTime.Now;
                                          string dateTimeFormart = String.Format("{0:d/MM/yyyy  |  HH:mm:ss}",
                                                                                 dateTimeNow);
                                          dateTimeMain.Text = dateTimeFormart.ToString();
                                      };
            dateTime_Main.Interval = 1000;
            dateTime_Main.Start();

            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void créditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form credits = new Crédits();
            credits.Show();
        }

        private void consulterLesÉquipementsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            gst_Equip gstEquip = new gst_Equip();
            gstEquip.SetBounds(10, 10, 435, 505);
            gstEquip.Show();
        }

        private void détailDunÉquipementToolStripMenuItem_Click( object sender, EventArgs e )
        {
            gst_Equip gstEquip = new gst_Equip();
            gstEquip.changeVisibility(true);
            gstEquip.Show();
        }

        private void ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem_Click( object sender, EventArgs e )
        {
            gst_Equip gstEquip = new gst_Equip();
            gstEquip.changeVisibility(true);
            gstEquip.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos apropos = new APropos();
            apropos.Show();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAQ faq = new FAQ();
            faq.Show();
        }

        private void consulterLaListeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste_complete clientlisteclient = new Liste_complete();
            clientlisteclient.Show();
        }

        private void consulterLesRéservationsDunClientToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Reservation_client clientReservationClient = new Reservation_client();
            clientReservationClient.Show();
        }

        private void ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Modification clientModification = new Modification();
            clientModification.Show();
        }

        private void consulterLaListeDesEmployésToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ListeCompletePersonnel personnelListPersonnel = new ListeCompletePersonnel();
            personnelListPersonnel.Show();
        }

        private void consulterLesDétailsDunEmployéToolStripMenuItem_Click( object sender, EventArgs e )
        {
            FicheDetailPersonnel personnelFicheDetail = new FicheDetailPersonnel();
            personnelFicheDetail.Show();
        }

        private void ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ModificationPersonnel personnelModification = new ModificationPersonnel();
            personnelModification.Show();
        }

        private void abscencesDesEmployésToolStripMenuItem_Click( object sender, EventArgs e )
        {
            AbsencePersonnel personnelAbs = new AbsencePersonnel();
            personnelAbs.Show();
        }

        private void consulterLaListeDesRéservationsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ListeCompleteReservation reservationListReservation = new ListeCompleteReservation();
            reservationListReservation.Show();
        }

        private void consulterLesDétailsDuneRéservationToolStripMenuItem_Click( object sender, EventArgs e )
        {
            FicheDetailReservation reservationFicheDetail = new FicheDetailReservation();
            reservationFicheDetail.Show();
        }

        private void ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ModificationReservation reservationModification = new ModificationReservation();
            reservationModification.Show();
        }
    }
}
