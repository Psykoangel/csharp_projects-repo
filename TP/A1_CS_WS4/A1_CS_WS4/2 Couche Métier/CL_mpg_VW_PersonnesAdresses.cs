using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS_Layer_Business
{
    class CL_mpg_VW_PersonnesAdresses
    {
        private string rq_sql;

        public CL_mpg_VW_PersonnesAdresses()
        {
            this.rq_sql = null;
        }

        public string SelectAll()
        {
            this.rq_sql = "SELECT TB_PERSONNE.ID_PERSONNE, TB_PERSONNE.NOM_PERSONNE, TB_PERSONNE.PRENOM_PERSONNE, TB_ADRESSES.ADRESSE, TB_ADRESSES.CP, " +
                          "TB_ADRESSES.VILLE FROM TB_PERSONNE INNER JOIN TB_ADRESSES ON TB_PERSONNE.ID_PERSONNE = TB_ADRESSES.ID_PERSONNE ;";
            return this.rq_sql;

        }
        
    }
}
