using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Mapping.User
{
    class MpgUser
    {
        private string _rqSQL;

        public MpgUser()
        {
            this._rqSQL = null;
        }

        public string ShowAll()
        {
            return this._rqSQL = "SELECT * FROM USER;";
        }

        public string CheckExistingUser(string login, string password)
        {
            return _rqSQL = "SELECT COUNT([NAME_USER]) FROM USER WHERE [LOGIN_USER] = '" + login + "' AND [PASSWORD_USER] = '" + password + "' ;";
        }
        /*
        public string ReservationClient(string name)
        {
            return this._rqSQL =
                        "SELECT CLIENT.ID_CLIENT, RESERVATION.ID_RESERVATION, CLIENT.NOM_CLIENT, CLIENT.PRENOM_CLIENT, RESERVATION.DATE_RESERVATION" + 
                        " FROM CLIENT INNER JOIN RESERVATION ON CLIENT.ID_CLIENT = RESERVATION.ID_CLIENT WHERE ((CLIENT.NOM_CLIENT)= '" + name.ToUpper() + "');";
        }
        */
        public string AddUser( string name, string forName, string login, int password )
        {
            return this._rqSQL = "INSERT INTO USER([NAME_USER], [FORNAME_USER], [LOGIN_USER], [PASSWORD_USER] " +
                       " ) VALUES('" + name.ToUpper() + "', '" + forName + "', '" + login + "', " + password + ");";
        }

        public string ModifyUser( int id, string nom, string forName, string login, string password )
        {
            return this._rqSQL = "UPDATE USER SET [NAME_USER] = '" + nom.ToUpper() + "', [FORNAME_USER] = '" + forName +
                "' [LOGIN_USER] = '" + login + "' [PASSWORD_USER] = '" + password + "' WHERE [ID_USER] = " + id + ";";
        }

        public string DeleteUser(int id)
        {
            return this._rqSQL = "DELETE FROM USER WHERE [ID_USER] = " + id + " ;";
        }

        public string SearchUser( int id )
        {
            return this._rqSQL = "SELECT * FROM USER WHERE [ID_USER] = " + id + " ;";
        }

        public string SearchUser(string login, string pass)
        {
            return this._rqSQL = "SELECT * FROM USER WHERE [LOGIN_USER] = '" + login + "' AND [PASSWORD_USER] = '" + pass + "' ;";
        }
    }
}
