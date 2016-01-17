using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.Class
{
    public class CL_List
    {
        private string listName;
        private DateTime listDeadline;
        private List<CL_Element> content;

        public CL_List()
        {
            listName = "";
            listDeadline = DateTime.Now;
        }

        public CL_List(string n, DateTime d)
        {
            this.listName = n;
            this.listDeadline = d;
        }

        public string getName()
        {
            return this.listName;
        }

        public List<CL_Element> getContent()
        {
            return this.content;
        }

        public void setContent(List<CL_Element> c)
        {
            this.content = c;
        }
    }
}
