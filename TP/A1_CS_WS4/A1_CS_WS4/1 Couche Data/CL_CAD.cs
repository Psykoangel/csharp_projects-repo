using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace NS_Layer_Data
{
    class CL_CAD
    {
        private string rq_sql;
        private string cnx;
        private OleDbConnection oCNX;               //en utilisant le using System.Data.OleDb, on évite la redondance du code.
        private OleDbCommand oCMD;
        private OleDbDataAdapter oDA;
        private DataSet oDS;

        public  CL_CAD()
        {
            this.rq_sql = "NC";
            this.cnx =@"Provider=Microsoft.Jet.OLEDB.4.0;" + "" +
                      @"Data Source=c:\users\exia_michael\documents\visual studio 2010\Projects\A1_CS_WS4\A1_CS_WS4\BDD_WS4n.mdb";
            this.oCNX = new OleDbConnection(this.cnx);
            this.oCMD = new OleDbCommand();
            this.oDA = new OleDbDataAdapter();
        }

        public System.Data.DataSet m_GetRows(string rq_sql, string rows_name)
        {
            this.oDS = new DataSet();
            this.rq_sql = rq_sql;
            this.oCMD.Connection = this.oCNX;
            this.oCMD.CommandText = this.rq_sql;
            this.oDA.SelectCommand = this.oCMD;
            this.oDA.Fill(this.oDS, rows_name);

            return this.oDS;
        }

        public void m_ActionsRows(string rq_sql)
        {
            this.rq_sql = rq_sql;
            this.oCMD.Connection = this.oCNX;
            this.oCMD.CommandText = this.rq_sql;
            this.oCNX.Open();
            this.oCMD.ExecuteNonQuery();
            this.oCNX.Close();
        }
    }
}
