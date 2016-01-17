using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.Class
{
    public class CL_User
    {
        private int id;
        private string name;
        private string forname;
        private string login;
        private string password;

        public CL_User()
        {
            this.id = 0;
            this.name = "";
            this.forname = "";
            this.login = "";
            this.password = "";
        }

        public int getUserId()
        {
            return this.id;
        }

        public string getUserName()
        {
            return this.name;
        }

        public string getUserForName()
        {
            return this.forname;
        }

        public string getUserLogin()
        {
            return this.login;
        }

        public string getUserPassword()
        {
            return this.password;
        }

        public void setUserId(int id)
        {
            this.id = id;
        }

        public void setUserName(string name)
        {
             this.name = name;
        }

        public void setUserForName(string forname)
        {
             this.forname = forname;
        }

        public void setUserLogin(string login)
        {
             this.login = login;
        }

        public void setUserPassword(string pass)
        {
             this.password = pass;
        }

    }
}
