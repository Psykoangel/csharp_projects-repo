using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private NS_Bonjour.CL_Bonjour _oBonjour;

        private void btn_Submit03_Click( object sender, EventArgs e )
        {
            this.TxtBox03.Text = "I am Santa Claus How How How";
        }

        private StreamReader SR;
    }
}
