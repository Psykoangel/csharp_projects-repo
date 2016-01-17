using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS_Layer_gPcs
{
    class CL_gPcs_Personnes
    {
        private NS_Layer_Business.CL_mpg_TB_PERSONNES oMpgPersonne;
        private NS_Layer_Business.CL_mpg_TB_ADRESSES oMpgAdresse;
        private NS_Layer_Business.CL_mpg_VW_PersonnesAdresses oMpgVWPersonnesAdresses;
        private NS_Layer_Data.CL_CAD oCad;

        public CL_gPcs_Personnes()
        {
            this.oMpgPersonne = new NS_Layer_Business.CL_mpg_TB_PERSONNES();
            this.oMpgAdresse = new NS_Layer_Business.CL_mpg_TB_ADRESSES();
            this.oMpgVWPersonnesAdresses = new NS_Layer_Business.CL_mpg_VW_PersonnesAdresses();
            this.oCad = new NS_Layer_Data.CL_CAD();
        }
        
        public System.Data.DataSet pcs_rechercherUnePersonne(string name, string rowsName)
        {
            return this.oCad.m_GetRows(this.oMpgPersonne.SelectByName(name), rowsName);
        }

        public void pcs_ajouterUnePersonne(string nom, string prenom)
        {
            this.oCad.m_ActionsRows(this.oMpgPersonne.Insert(nom, prenom));
        }

        public System.Data.DataSet pcs_afficherToutesLesPersonnesAdresses(string rowsName)
        {
            return this.oCad.m_GetRows(this.oMpgVWPersonnesAdresses.SelectAll(), rowsName);
        }

    }
}
