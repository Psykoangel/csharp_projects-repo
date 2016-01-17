using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Code.Couche_Data;
using Code.Mapping;

namespace Code.Couche_Processus
{
    class CL_Pcs_gst_Equip
    {
        private Mapping.CL_mpg_Equip oMpgEquipement;
        private Couche_Data.CL_CAD oCad;

        public CL_Pcs_gst_Equip()
        {
            oMpgEquipement = new CL_mpg_Equip();
            oCad = new CL_CAD();
        }

        public System.Data.DataSet pcs_selectAllGear(string rowsName)
        {
            return oCad.m_GetRows(oMpgEquipement.SelectAllGear(), rowsName);
        }

        public void pcs_addGear( string nom, string descriptif, bool motor, int puissance, bool stock, bool loc, int prixHtLoc01, int prixHtLoc02, int prixHtLoc03 )
        {
           oCad.m_ActionsRows(oMpgEquipement.AddGear(nom, descriptif, motor, puissance, stock, loc, prixHtLoc01, prixHtLoc02, prixHtLoc03));
        }

        public void pcs_mdfNameGear()
        {

        }

        public void pcs_mdfDescrGear()
        {

        }

        public void pcs_mdfStrGear()
        {

        }

        public void pcs_mdfStatGear()
        {

        }

        public void pcs_mdfPcrhtGear()
        {

        }

        public void pcs_delGear(int id)
        {
            oCad.m_ActionsRows(oMpgEquipement.DeleteGear(id));
        }
    }
}
