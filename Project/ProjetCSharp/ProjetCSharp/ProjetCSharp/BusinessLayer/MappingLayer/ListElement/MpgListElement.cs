using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Mapping.ListElement
{
    class MpgListElement
    {
        private string _rqSQL;

        public MpgListElement()
        {
            this._rqSQL = null;
        }

        public string ShowAll()
        {
            return this._rqSQL = "SELECT * FROM ELEMENT;";
        }
        /*
        public string ReservationClient(string name)
        {
            return this._rqSQL =
                        "SELECT CLIENT.ID_CLIENT, RESERVATION.ID_RESERVATION, CLIENT.NOM_CLIENT, CLIENT.PRENOM_CLIENT, RESERVATION.DATE_RESERVATION" + 
                        " FROM CLIENT INNER JOIN RESERVATION ON CLIENT.ID_CLIENT = RESERVATION.ID_CLIENT WHERE ((CLIENT.NOM_CLIENT)= '" + name.ToUpper() + "');";
        }
        */
        public string AddListElement( string content, int order )
        {
            return this._rqSQL = "INSERT INTO ELEMENT([CONTENT_ELEMENT], [ORDER_ELEMENT] " +
                       " ) VALUES('" + content + "', '" + order + ");";
        }
        /*
        public string AddListElements(string content, int order)
        {
            return this._rqSQL = "INSERT INTO ELEMENT([CONTENT_ELEMENT], [ORDER_ELEMENT] " +
                       " ) VALUES('" + content + "', '" + order + ");";
        }
        */
        public string ModifyListElement( int id, string content, int order )
        {
            return this._rqSQL = "UPDATE ELEMENT SET [CONTENT_ELEMENT] = '" + content + "', [ORDER_ELEMENT] = '" + order + 
                "' WHERE [ID_ELEMENT] = " + id + ";";
        }

        public string DeleteListElement(int id)
        {
            return this._rqSQL = "DELETE FROM ELEMENT WHERE [ID_ELEMENT] = " + id + " ;";
        }

        public string SearchListElement( int id )
        {
            return this._rqSQL = "SELECT * FROM ELEMENT WHERE [ID_ELEMENT] = " + id + " ;";
        }
    }
}
