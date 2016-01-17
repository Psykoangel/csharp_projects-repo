using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2ADO
{
    public partial class Form1 : Form
    {
        private string rq_sql;
        private string cnx;
        private System.Data.OleDb.OleDbConnection oCNX;
        private System.Data.OleDb.OleDbCommand oCMD;
        private System.Data.OleDb.OleDbDataAdapter oDA;
        private System.Data.DataSet oDS;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            this.rq_sql = "NC";
            this.cnx = "NC";
            this.oCNX = null;
            this.oCMD = null;
            this.oDA = null;
            this.oDS = null;
            this.toolStripStatusLabel1.Text = "BDD Non Connectée";
        }

        private void bnt_cnx_bdd_Click( object sender, EventArgs e )
        {
            this.cnx = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\eXia_Michael\Documents\Visual Studio 2010\Projects\WindowsFormsApplication2ADO\BDD3.mdb";
            this.oCNX = new System.Data.OleDb.OleDbConnection(this.cnx);
            this.oCNX.Open();
            this.toolStripStatusLabel1.Text = "BDD Connectée";
            this.oCNX.Close();
            
        }

        private void m_select()
        {
            this.rq_sql = "SELECT * FROM PERSONNE;";
            this.oCNX = new System.Data.OleDb.OleDbConnection(this.cnx);
            this.oCMD = new System.Data.OleDb.OleDbCommand(this.rq_sql, this.oCNX);
            this.oDA = new System.Data.OleDb.OleDbDataAdapter(this.oCMD);
            this.oDS = new DataSet();
            this.oCNX.Open();
            this.oDA.Fill(this.oDS, "PERSONNERows");
            this.dgv_data.DataSource = this.oDS;
            this.dgv_data.DataMember = "PERSONNERows";
            this.oCNX.Close();            
        }

        private void btn_select_Click( object sender, EventArgs e )
        {
            this.m_select();
        }

        private void btn_insert_Click( object sender, EventArgs e )
        {
            this.rq_sql = "INSERT INTO PERSONNE ([NOM_PERSONNE], [PRENOM_PERSONNE]) " +
                          "VALUES ('" + this.txt_nom.Text + "','" + this.txt_prenom.Text + "');";
            this.oCMD.CommandText = this.rq_sql;
            this.oCNX.Open();
            this.oCMD.ExecuteNonQuery();
            this.oCNX.Close();
            this.m_select();
        }

        private void btn_suppr_Click( object sender, EventArgs e )
        {
            this.rq_sql = "DELETE FROM PERSONNE WHERE ID_PERSONNE=" + txt_id_suppr.Text + ";";
            this.oCMD.CommandText = this.rq_sql;
            this.oCNX.Open();
            this.oCMD.ExecuteNonQuery();
            this.oCNX.Close();
            this.m_select();
        }

        private void quitterToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form1.ActiveForm.Close();
        }

    }
}
