using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Project.DataAccessLayer
{
    class CAD
    {
        private string _rqSql;
        private string cnx;
        private OleDbConnection oCNX;
        private OleDbCommand oCMD;
        private OleDbDataAdapter oDA;
        private DataSet oDS;

        public CAD()
        {
            this._rqSql = "NC";
            this.cnx = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Users\Psyko\Desktop\Sharing\ProjetCSharp\Database\ProjetCSharp.mdb";
            this.oCNX = new OleDbConnection(this.cnx);
            this.oCMD = new OleDbCommand();
            this.oDA = new OleDbDataAdapter();
        }

        public System.Data.DataSet m_GetRows( string rq_sql, string rows_name )
        {
            this.oDS = new DataSet();
            this._rqSql = rq_sql;
            this.oCMD.Connection = this.oCNX;
            this.oCMD.CommandText = this._rqSql;
            this.oDA.SelectCommand = this.oCMD;
            this.oDA.Fill(this.oDS, rows_name);

            return this.oDS;
        }

        public void m_ActionsRows( string rq_sql )
        {
            this._rqSql = rq_sql;
            this.oCMD.Connection = this.oCNX;
            this.oCMD.CommandText = this._rqSql;
            this.oCNX.Open();
            this.oCMD.ExecuteNonQuery();
            this.oCNX.Close();
        }
    }
}
