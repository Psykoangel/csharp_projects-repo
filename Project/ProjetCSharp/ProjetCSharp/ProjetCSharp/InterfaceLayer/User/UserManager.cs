using ProjetCSharp.BusinessLayer.User;
using ProjetCSharp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCSharp.InterfaceLayer.User
{
    public partial class UserManager : Form
    {
        private CL_User user;
        private blUser bl_user;
        private System.Data.DataSet oDS;

        public UserManager(CL_User u)
        {
            this.user = u;
            InitializeComponent();
            this.tbName.Text = user.getUserName();
            this.tbForName.Text = user.getUserForName();
            this.tbLogin.Text = user.getUserLogin();
            this.tbPass.Text = user.getUserPassword();
            this.btSubmit.Enabled = true;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(this.tbName.Text)
                    || String.IsNullOrWhiteSpace(this.tbForName.Text)
                    || String.IsNullOrWhiteSpace(this.tbLogin.Text)
                    || String.IsNullOrWhiteSpace(this.tbPass.Text)))
            {
                //bl_user.bl_ModifyUser(user.getUserId(), tbName.Text, tbForName.Text, tbLogin.Text, tbPass.Text);
            }
        }
    }
}
