using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Mapping.List
{
    class MpgList
    {
        private string _rqSQL;

        public MpgList()
        {
            this._rqSQL = null;
        }

        public string ShowAll()
        {
            return this._rqSQL = "SELECT * FROM LIST;";
        }
        /*
        public string ReservationClient(string name)
        {
            return this._rqSQL =
                        "SELECT CLIENT.ID_CLIENT, RESERVATION.ID_RESERVATION, CLIENT.NOM_CLIENT, CLIENT.PRENOM_CLIENT, RESERVATION.DATE_RESERVATION" + 
                        " FROM CLIENT INNER JOIN RESERVATION ON CLIENT.ID_CLIENT = RESERVATION.ID_CLIENT WHERE ((CLIENT.NOM_CLIENT)= '" + name.ToUpper() + "');";
        }
        */
        public string AddList( string title, DateTime deadline )
        {
            return this._rqSQL = "INSERT INTO LIST([TITLE_LIST], [DEADLINE_LIST] " +
                       " ) VALUES('" + title + "', '" + DateTime.Parse(deadline.ToShortDateString()) + ");";
        }

        public string ModifyList( int id, string newTitle, DateTime newDeadline )
        {
            return this._rqSQL = "UPDATE LIST SET [TITLE_LIST] = '" + newTitle + "', [DEADLINE_LIST] = '" + DateTime.Parse(newDeadline.ToShortDateString()) + 
                "' WHERE [ID_LIST] = " + id + ";";
        }

        public string DeleteList(int id)
        {
            return this._rqSQL = "DELETE FROM LIST WHERE [ID_LIST] = " + id + " ;";
        }

        public string SearchList( int id )
        {
            return this._rqSQL = "SELECT * FROM LIST WHERE [ID_LIST] = " + id + " ;";
        }
    }
}
