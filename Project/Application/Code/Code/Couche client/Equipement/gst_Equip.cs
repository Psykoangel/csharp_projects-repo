using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Code.Couche_Processus;

namespace Code.Couche_IHM
{
    public partial class gst_Equip : Form
    {

        private Couche_Processus.CL_Pcs_gst_Equip gPcs_Equipement;
        private DataSet oDataSet;

        public gst_Equip()
        {
            InitializeComponent();
        }

        public void changeVisibility( bool boolean ) { this.gpb_dtl_equip.Visible = boolean; }

        private void gst_Equip_Load( object sender, EventArgs e )
        {
            gPcs_Equipement = new CL_Pcs_gst_Equip();
            oDataSet = gPcs_Equipement.pcs_selectAllGear("rowEquip");
            dgv_equip.DataSource = oDataSet.Tables["rowEquip"];
        }

        private void btn_add_equip_Click( object sender, EventArgs e )
        {
            gPcs_Equipement.pcs_addGear(txtb_equip_name.Text, txt_equip_descr.Text, chkb_equip_motor.Checked, int.Parse(txtb_equip_puissance.Text), chkb_equip_stock.Checked, chkb_equip_loc.Checked, int.Parse(txtb_equip_pcrht01.Text), int.Parse(txtb_equip_pcrht02.Text), int.Parse(txtb_equip_pcrht03.Text));
        }

        private void btn_mdf_equip_Click( object sender, EventArgs e )
        {

        }

        private void btn_del_equip_Click( object sender, EventArgs e )
        {
            gPcs_Equipement.pcs_delGear(int.Parse(txtb_equip_id.Text));
        }

        private void chkb_equip_motor_CheckedChanged( object sender, EventArgs e )
        {
            if (chkb_equip_motor.Checked)
            {
                lb_equip_puissance.Visible = true;
                txtb_equip_puissance.Visible = true;
            }
            else
            {
                lb_equip_puissance.Visible = false;
                txtb_equip_puissance.Visible = false;
            }
        }


    }
}
