using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Code.Couche_Data;

namespace GestionPersonel.Couche_métier_Personnel
{
    class CL_gPcs_Personnel
    {
        private Couche_métier_Personnel.CL_mpg_Personnel oMpgPersonnel; 
        private Code.Couche_Data.CL_CAD oCad;

        public CL_gPcs_Personnel()
        {
            this.oMpgPersonnel = new CL_mpg_Personnel();
            this.oCad = new CL_CAD();
        }

        public System.Data.DataSet pcs_afficherTousLePersonnel(string rowsName)
        {
            return this.oCad.m_GetRows(this.oMpgPersonnel.SelectAllPersonnel(), rowsName);
        }

        public System.Data.DataSet pcs_afficherUnEmploye(string nompersonnel, string rowsName)
        {
            return this.oCad.m_GetRows(this.oMpgPersonnel.SelectPersonnel(nompersonnel), rowsName);
        }

        public System.Data.DataSet pcs_afficherUneAbsence(string name, string rowsName)
        {
            return this.oCad.m_GetRows(this.oMpgPersonnel.SelectAbsence(name), rowsName);
        }

        public System.Data.DataSet pcs_afficherToutesLesAbsences(string rowsName)
        {
            return this.oCad.m_GetRows(this.oMpgPersonnel.SelectAllAbsence(), rowsName);
        }

        public void pcs_ajouterUnEmploye(string nom, string prenom, string adresse, int CP, string ville, string telephone, string numerosecu, DateTime embauche, DateTime visitemedicale, string contrat, bool permis, string numeropermis, bool bees, string numerobees)
        {
            this.oCad.m_ActionsRows(this.oMpgPersonnel.InsertEmploye(nom, prenom, adresse, CP, ville, telephone, numerosecu, embauche, visitemedicale, contrat, permis, numeropermis, bees, numerobees));
        }

        public void pcs_modifierUnEmploye(string nom, string prenom, string adresse, int CP, string ville, string telephone, string numerosecu, DateTime embauche, DateTime visitemedicale, string contrat, bool permis, string numeropermis, bool bees, string numerobees)
        {
            this.oCad.m_ActionsRows(this.oMpgPersonnel.ChangeEmploye(nom, prenom, adresse, CP, ville, telephone, numerosecu, embauche, visitemedicale, contrat, permis, numeropermis, bees, numerobees));
        }

        public void pcs_supprimerUnEmploye(string nomemploye)
        {
            this.oCad.m_ActionsRows(this.oMpgPersonnel.DeleteEmploye(nomemploye));
        }
    }
}
