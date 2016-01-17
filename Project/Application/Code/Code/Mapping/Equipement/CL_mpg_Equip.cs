namespace Code.Mapping
{
    class CL_mpg_Equip
    {
        private string rqSQL;

        public CL_mpg_Equip()
        {
            this.rqSQL = null;
        }

        public string SelectAllGear()
        {
            return this.rqSQL = "SELECT [ID_EQUIPEMENT], [NOM_EQUIPEMENT] FROM EQUIPEMENT;";
        }

        public string AddGear( string nom, string descriptif, bool motor, int puissance, bool stock, bool loc, int prixHtLoc01, int prixHtLoc02, int prixHtLoc03 )
        {
            return this.rqSQL = "INSERT INTO EQUIPEMENT([NOM_EQUIPEMENT], [DESCRIPTIF_EQUIPEMENT], [MOTEUR_EQUIPEMENT], [PUISSANCE_EQUIPEMENT], " +
                       " [TARIF_DEMI_EQUIPEMENT], [TARIF_UNE_EQUIPEMENT], [TARIF_DEUX_EQUIPEMENT], [ETAT_STOCK], [LOCATION_STOCK]) VALUES('" + nom + "', '" + descriptif + "', " +
                       motor + ", " + puissance + ", " + prixHtLoc01 + ", " + prixHtLoc02 + ", " + prixHtLoc03 + ", " + stock + ", " + loc + ");";
        }

        public string ModifyNameGear(int id, string nom)
        {
            return this.rqSQL = "UPDATE EQUIPEMENT SET [NOM_EQUIPEMENT] = '" + nom + "' WHERE [ID_EQUIPEMENT] = " + id + ";";
        }

        public string ModifyDescrGear(int id, string descr)
        {
            return this.rqSQL = "UPDATE EQUIPEMENT SET [DESCRIPTIF_EQUIPEMENT] = '" + descr + "' WHERE [ID_EQUIPEMENT] = " + id + ";";
        }

        public string ModifyMotorGear( int id, bool motor )
        {
            return this.rqSQL = "UPDATE EQUIPEMENT SET [MOTEUR_EQUIPEMENT] = " + motor + " WHERE [ID_EQUIPEMENT] = " + id + ";";
        }

        public string ModifyStrGear(int id, int puissance)
        {
            return this.rqSQL = "UPDATE EQUIPEMENT SET [PUISSANCE_EQUIPEMENT] = " + puissance + " WHERE [ID_EQUIPEMENT] = " + id + ";";
        }

        public string ModifyStockGear(int id, bool stock)
        {
            return this.rqSQL = "UPDATE EQUIPEMENT SET [ETAT_STOCK] = " + stock + " WHERE [ID_EQUIPEMENT] = " + id + ";";
        }

        public string ModifyLocGear(int id, bool loc)
        {
            return this.rqSQL = "UPDATE EQUIPEMENT SET [ETAT_STOCK] = " + loc + " WHERE [ID_EQUIPEMENT] = " + id + ";";
        }

        public string ModifyPcrdemiGear(int id, int prixHtLoc01)
        {
            return this.rqSQL = "UPDATE EQUIPEMENT SET [TARIF_DEMI_EQUIPEMENT] = " + prixHtLoc01 + " WHERE [ID_EQUIPEMENT] = " + id + ";";
        }

        public string ModifyPcruneGear(int id, int prixHtLoc02)
        {
            return this.rqSQL = "UPDATE EQUIPEMENT SET [TARIF_UNE_EQUIPEMENT] = " + prixHtLoc02 + " WHERE [ID_EQUIPEMENT] = " + id + ";";
        }

        public string ModifyPcrdeuxGear(int id, int prixHtLoc03)
        {
            return this.rqSQL = "UPDATE EQUIPEMENT SET [TARIF_DEUX_EQUIPEMENT] = " + prixHtLoc03 + " WHERE [ID_EQUIPEMENT] = " + id + ";";
        }

        public string DeleteGear(int id)
        {
            return this.rqSQL = "DELETE FROM EQUIPEMENT WHERE [ID_EQUIPEMENT] = " + id + " ;";
        }
        
    }
}
