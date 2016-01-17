using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCSharp.InterfaceLayer.List
{
    public partial class ListManager : Form
    {
        public ListManager(string listName)
        {
            InitializeComponent();

            //TODO Charger les éléments de la liste et les afficher dans la listview.
        }

        private void btDeleteElement_Click(object sender, EventArgs e)
        {
            var l = (ListView) sender;
            if (l.SelectedItems.Count > 0)
            {
                //TODO supprimer l'element selectionner.
            }
        }
    }
}
