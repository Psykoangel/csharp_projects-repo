using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS_Layer_gPcs
{
    class CL_gPcs_Adresses
    {
        private NS_Layer_Business.CL_mpg_TB_ADRESSES oMpgAdresse;
        private NS_Layer_Data.CL_CAD oCad;

        public CL_gPcs_Adresses()
        {
            this.oMpgAdresse = new NS_Layer_Business.CL_mpg_TB_ADRESSES();
            this.oCad = new NS_Layer_Data.CL_CAD();
        }

        public System.Data.DataSet pcs_afficherLesVilles(string rowsName)
        {
            return this.oCad.m_GetRows(this.oMpgAdresse.SelectCity(), rowsName);
        }

        public  void ajouterUneAdressePersonne(int id_personne, string adresse, string ville, string cp)
        {
            this.oCad.m_ActionsRows(this.oMpgAdresse.Insert(id_personne, adresse, ville, cp));
        }

    }
}
