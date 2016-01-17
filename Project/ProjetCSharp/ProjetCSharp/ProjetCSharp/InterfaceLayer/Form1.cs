using ProjetCSharp.BusinessLayer.User;
using ProjetCSharp.Class;
using ProjetCSharp.InterfaceLayer.List;
using ProjetCSharp.InterfaceLayer.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ProjetCSharp
{
    public partial class Form1 : Form
    {
        private CL_User user;
        private blUser bl_user;
        private System.Data.DataSet oDS;

        public Form1()
        {
            InitializeComponent();
            bl_user = new blUser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.tbPass.Text))
            {
                this.lbMessage.Text = "Click on submit to log in.";
                this.btSubmit.Enabled = true;
            }
            else if (String.IsNullOrEmpty(this.tbLogin.Text))
            {
                this.lbMessage.Text = "Please enter your login and password to access the lists application.";
            }
            else
            {
                this.lbMessage.Text = "Please enter your password.";
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.tbLogin.Text))
            {
                this.lbMessage.Text = "Click on submit to log in.";
                this.btSubmit.Enabled = true;
            }
            else if (String.IsNullOrEmpty(this.tbPass.Text))
            {
                this.lbMessage.Text = "Please enter your login and password to access the lists application.";
            }
            else
            {
                this.lbMessage.Text = "Please enter your login.";
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            //TODO faire la verification du login et du mot de passe
            string login = tbLogin.Text;
            string pass = tbPass.Text;

            //bool passRight = bl_user.bl_CheckExistingUser(login, pass, "USER");
            bool passRight = true;
            if (passRight)
            {
                //this.user = bl_user.bl_SearchUser(login, pass);
                this.user = new CL_User();
                this.user.setUserId(1);
                this.user.setUserName("POKEMON");
                this.user.setUserForName("Jean");
                this.user.setUserLogin("aze");
                this.user.setUserPassword("123");

                //TODO recuperer les listes de l utilisateur

                this.lbInfo.Text = this.lbInfo.Text.Replace("member", user.getUserName());
                this.gpConnexion.Visible = false;
                this.gpMessage.Visible = false;
                this.lbInfo.Visible = true;
                this.gpLists.Visible = true;
                this.btAddList.Visible = true;
                this.lbInfo.Visible = true;

                List<CL_List> newList = new List<CL_List>();
                newList.Add(new CL_List("courses", DateTime.Now));
                newList.Add(new CL_List("ménage", DateTime.Now));
                newList.Add(new CL_List("recette de crepes", DateTime.Now));
                newList.Add(new CL_List("liste des cadeaux", DateTime.Now));

                foreach(CL_List listElement in newList)
                {
                    this.lvList.Items.Add(listElement.getName());
                }
            }
            else
            {
                this.tbLogin.Clear();
                this.tbPass.Clear();
                this.lbMessage.Text = "Login or Password has not been recognize. Please retry later or contact your Administrator.";
            }

        }

        private void btAddList_Click(object sender, EventArgs e)
        {
            AddList newList = new AddList();
            newList.Show();
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {
            UserManager userM = new UserManager(this.user);
            userM.Show();
        }

        private void lvList_DoubleClick(object sender, EventArgs e)
        {
            var y = (ListView) sender;
            ListManager manag = new ListManager(y.SelectedItems[0].Text);
            manag.Show();
        }
    }
}
