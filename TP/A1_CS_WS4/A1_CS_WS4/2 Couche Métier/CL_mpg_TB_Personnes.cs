using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS_Layer_Business
{
    class CL_mpg_TB_PERSONNES
    {
        private string rq_sql;

        public CL_mpg_TB_PERSONNES()
        {
            this.rq_sql = null;
        }

        public string SelectAll()
        {
            this.rq_sql = "SELECT * FROM TB_PERSONNE;";
            return this.rq_sql;
        }

        public string SelectByName(string name)
        {
            this.rq_sql = "SELECT * FROM TB_PERSONNE WHERE [NOM_PERSONNE] = '" + name + "';";
            return this.rq_sql;
        }

        public  string Insert(string nom, string prenom)
        {
            this.rq_sql = "INSERT INTO TB_PERSONNE([NOM_PERSONNE], [PRENOM_PERSONNE]) VALUES('" + nom + "', '" + prenom +
                          "');";
            return this.rq_sql;
        }
    }
}
