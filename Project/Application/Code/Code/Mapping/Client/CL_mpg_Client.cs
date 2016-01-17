using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code.Mapping.Client
{
    class CL_mpg_Client
    {
        private string _rqSQL;

        public CL_mpg_Client()
        {
            this._rqSQL = null;
        }

        public string Affichertous()
        {
            return this._rqSQL = "SELECT * FROM CLIENT;";
        }

        public string ReservationClient(string name)
        {
            return this._rqSQL =
                "SELECT CLIENT.ID_CLIENT, CLIENT.NOM_CLIENT, CLIENT.PRENOM_CLIENT, RESERVATION.DATE_RESERVATION, RESERVATION.HEURE_DEBUT_RESERVATION," + 
                " RESERVATION.HEURE_FIN_RESERVATION, RESERVATION.COUT_GLOBAL_RESERVATION" +
                "FROM CLIENT JOIN RESERVATION ON CLIENT.ID_CLIENT = RESERVATION.ID_CLIENT WHERE CLIENT.NOM_CLIENT = '"+ name +"';";
        }

        public string AddClient( string nom, string prenom, string adresse, int copost, string ville, string num_tel,
                                                                                        DateTime dateNaiss, bool permis_co, string num_permis_co)
        {
            return this._rqSQL =
                "INSERT INTO CLIENT([NOM_CLIENT] = '" + nom + "', [PRENOM_CLIENT] = '" + prenom + "', [ADRESSE_CLIENT] = '" + adresse +
                "', [CP_CLIENT] = '" + copost + "', [VILLE_CLIENT] = '" + ville + "', [NUM_TEL_CLIENT] = '" + num_tel + "', [DATE_NAISSANCE_CLIENT] = '" + dateNaiss +
                "', [PERMIS_COTIER_CLIENT] = '" + permis_co + "', [NUM_PERMIS_CO_CLIENT] = '" + num_permis_co + "';)";
        }

        public string ModifyClient(int id, string nom, string prenom, string adresse, int copost, string ville, string num_tel, 
                                                                                        DateTime dateNaiss, bool permis_co, string num_permis_co)
        {
            return this._rqSQL =
                "UPDATE CLIENT SET [NOM_CLIENT] = '" + nom + "', [PRENOM_CLIENT] = '" + prenom + "', [ADRESSE_CLIENT] = '" + adresse +
                "', [CP_CLIENT] = '" + copost + "', [VILLE_CLIENT] = '" + ville + "', [NUM_TEL_CLIENT] = '" + num_tel + "', [DATE_NAISSANCE_CLIENT] = '" + dateNaiss +
                "', [PERMIS_COTIER_CLIENT] = '" + permis_co + "', [NUM_PERMIS_CO_CLIENT] = '" + num_permis_co +
                "', WHERE [ID_CLIENT] = '" + id + "' ;";
        }

        public string DeleteClient(int id)
        {
            return this._rqSQL = "DELETE FROM CLIENT WHERE [ID_CLIENT] = " + id + " ;";
        }
    }
}
