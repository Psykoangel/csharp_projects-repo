using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS_Layer_Business
{
    internal class CL_mpg_TB_ADRESSES
    {
        private string rq_sql;

        public CL_mpg_TB_ADRESSES()
        {
            this.rq_sql = null;
        }

        public string SelectCity()
        {
            this.rq_sql = "SELECT VILLE FROM TB_ADRESSES;";
            return this.rq_sql;
        }

        public string Insert(int idPersonne, string adresse, string ville, string cp)
        {
            this.rq_sql = "INSERT INTO TB_ADRESSES([ADRESSE], [VILLE], [CP], [ID_PERSONNE]) VALUES('" + adresse + "', '" +
                          ville + "', '" + cp + "', '" + idPersonne +
                          "');";
            return this.rq_sql;
        }
    }
}
