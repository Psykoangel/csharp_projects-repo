using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCSharp.Class;

namespace ProjetCSharp.BusinessLayer.User
{
    class blUser
    {
        private Project.Mapping.User.MpgUser oMpgUser;
        private Project.DataAccessLayer.CAD oCAD;
        private System.Data.DataSet ds;

        public blUser()
        {
            oMpgUser = new Project.Mapping.User.MpgUser();
            oCAD = new Project.DataAccessLayer.CAD();
        }

        public List<string> bl_GetAllUser(string rowsName)
        {
            ds = oCAD.m_GetRows(oMpgUser.ShowAll(), rowsName);
            return new List<string>();
        }

        public void bl_ModifyUser(int id, string n, string fn, string l, string p)
        {
            oCAD.m_ActionsRows(oMpgUser.ModifyUser(id, n, fn, l, p));
        }

        public CL_User bl_SearchUser(string login, string password)
        {
            CL_User user = new CL_User();
            ds = oCAD.m_GetRows(oMpgUser.SearchUser(login, password), "USER");
            user.setUserId(int.Parse(ds.Tables["USER"].Rows[0]["ID_USER"].ToString()));
            user.setUserName(ds.Tables["USER"].Rows[0]["NAME_USER"].ToString());
            user.setUserForName(ds.Tables["USER"].Rows[0]["FORNAME_USER"].ToString());
            user.setUserLogin(ds.Tables["USER"].Rows[0]["LOGIN_USER"].ToString());
            user.setUserPassword(ds.Tables["USER"].Rows[0]["PASSWORD_USER"].ToString());
            return user;
        }

        public bool bl_CheckExistingUser(string l, string p, string rowsName)
        {
            ds = oCAD.m_GetRows(oMpgUser.CheckExistingUser(l, p), rowsName);
            if(int.Parse(ds.Tables["test"].Rows[0].ToString()) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
