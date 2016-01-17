using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Code.Couche_Data;

namespace Code.Mapping.Client
{
    class CL_gPcs_Client
    {
        private CL_mpg_Client oMpgClient;
        private Couche_Data.CL_CAD oCad;

        public CL_gPcs_Client()
        {
            this.oMpgClient = new CL_mpg_Client();
            this.oCad = new CL_CAD();
        }

        public System.Data.DataSet pcs_afficherTousLesClients(string rowsName)
        {
            return this.oCad.m_GetRows(this.oMpgClient.Affichertous(), rowsName);
        }

        public System.Data.DataSet pcs_afficherReservationClient(string name, string rowsName)
        {
            return this.oCad.m_GetRows(this.oMpgClient.ReservationClient(name), rowsName); 
        }

        public void pcs_ajouterClient(string nom, string prenom, string adresse, int copost, string ville, string num_tel, DateTime dateNaiss, bool permis_co, string num_permis_co)
        {
            this.oCad.m_ActionsRows(this.oMpgClient.AddClient( nom, prenom, adresse, copost, ville, num_tel, dateNaiss, permis_co, num_permis_co));
        }

        public void pcs_modifierClient(int id, string nom, string prenom, string adresse, int copost, string ville, string num_tel, DateTime dateNaiss, bool permis_co, string num_permis_co)
        {
            this.oCad.m_ActionsRows(this.oMpgClient.ModifyClient(id, nom, prenom, adresse, copost, ville, num_tel, dateNaiss, permis_co, num_permis_co));
        }

        public void pcs_supprimerClient(int id)
        {
            this.oCad.m_ActionsRows(this.oMpgClient.DeleteClient(id));
        }
    }
}
