using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionPersonel.Couche_métier_Personnel
{
    class CL_mpg_Personnel
    {
        private string rq_sql;

        public CL_mpg_Personnel()
        {
            this.rq_sql = null;
        }

        //AFFICHER LA LISTE COMPLETE DU PERSONNEL
        public string SelectAllPersonnel()
        {
            return this.rq_sql = " SELECT * FROM EMPLOYE;";
        }

        //AFFICHER LA FICHE DETAILLE D'UN EMPLOYE
        public string SelectPersonnel(string nompersonnel)
        {
            return this.rq_sql = "SELECT * FROM EMPLOYE where NOM_EMPLOYE = '" + nompersonnel + "';";
        }

        //AFFICHER LA LISTE COMPLETE DES ABSENCES
        public string SelectAllAbsence()
        {
            return this.rq_sql = "SELECT * FROM ABSENCE;";
        }

        //AFFICHER LES ABSENCES D'UN EMPLOYE
        public string SelectAbsence(string name)
        {
            return this.rq_sql = "SELECT * FROM ABSENCE JOIN EMPLOYE ON ABSENCE.ID_EMPLOYE = EMPLOYE.ID_EMPLOYE WHERE NOM_EMPLOYE = '" + name + "';";
        }
        
        //AJOUTER UN EMPLOYE
        public string InsertEmploye(string nom, string prenom, string adresse, int CP, string ville, string telephone, string numerosecu, DateTime embauche, DateTime visitemedicale, string contrat, bool permis, string numeropermis, bool bees, string numerobees)
        {
            return this.rq_sql = "INSERT INTO EMPLOYE([NOM_EMPLOYE], [PRENOM_EMPLOYE], [ADRESSE_EMPLOYE], [CP_EMPLOYE]" +
                "[VILLE_EMPLOYE], [NUM_TEL_EMPLOYE], [NUM_SECU_EMPLOYE], [DATE_EMBAUCHE_EMPLOYE], [DATE_VISITE_MED_EMPLOYE]"+
                "[TYPE_CONTRAT_EMPLOYE], [PERMIS_COT_EMPLOYE], [NUM_PERMIS_COT_EMPLOYE], [BEES_EMPLOYE], [NUM_BEES_EMPLOYE])"+
                "VALUES ('" + nom + "','" + prenom + "','" + adresse + "','" + CP + "','" + ville + "','" + telephone + "','" + numerosecu + "','" + 
                embauche + "','" + visitemedicale + "','" + contrat + "','" + permis + "','" + numeropermis + "','" + bees + "','" + numerobees + "');";
        }

        //SUPPRIMER UN EMPLOYE
        public string DeleteEmploye(string nomemploye)
        {
            return this.rq_sql = "DELETE * FROM EMPLOYE where NOM_EMPLOYE = '" + nomemploye + "';";
        }

        // MODIFIER LES CHAMPS D'UN EMPLOYE
        public string ChangeEmploye(string nom, string prenom, string adresse, int CP, string ville, string telephone, string numerosecu, DateTime embauche, DateTime visitemedicale, string contrat, bool permis, string numeropermis, bool bees, string numerobees)
        {
            return this.rq_sql = "UPDATE EMPLOYE SET ([NOM_EMPLOYE], [PRENOM_EMPLOYE], [ADRESSE_EMPLOYE], [CP_EMPLOYE]" +
                "[VILLE_EMPLOYE], [NUM_TEL_EMPLOYE], [NUM_SECU_EMPLOYE], [DATE_EMBAUCHE_EMPLOYE], [DATE_VISITE_MED_EMPLOYE]" +
                "[TYPE_CONTRAT_EMPLOYE], [PERMIS_COT_EMPLOYE], [NUM_PERMIS_COT_EMPLOYE], [BEES_EMPLOYE], [NUM_BEES_EMPLOYE])" +
                "VALUES ('" + nom + "','" + prenom + "','" + adresse + "','" + CP + "','" + ville + "','" + telephone + "','" + numerosecu + "','" + 
                embauche + "','" + visitemedicale + "','" + contrat + "','" + permis + "','" + numeropermis + "','" + bees + "','" + numerobees + "');";
        }
    }
}
