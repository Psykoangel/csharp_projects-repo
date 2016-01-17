using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class WinForm1 : Form
    {
        public WinForm1()
        {
            InitializeComponent();
        }

        private void FermerToolStripMenuItemClick( object sender, EventArgs e )
        {
            if (Form.ActiveForm != null) ActiveForm.Close();
        }

        private void FichierFormToolStripMenuItemClick( object sender, EventArgs e )
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void FichierForm2ToolStripMenuItemClick( object sender, EventArgs e )
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }
    }
}
