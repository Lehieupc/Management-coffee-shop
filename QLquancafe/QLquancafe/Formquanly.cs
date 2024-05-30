using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquancafe
{
    public partial class Formquanly : Form
    {
        public Formquanly()
        {
            InitializeComponent();
        }
        private void Uc_control_hide()
        {
            foreach(Control control in this.Controls) {
                if(control is UserControl)
                {
                    control.Hide();
                }
            }
        }
        private void Formquanly_Load(object sender, EventArgs e)
        {
            Uc_control_hide();
        }

        private void bt_ql_menu_Click(object sender, EventArgs e)
        {
            Uc_control_hide();
            uC_menu1.Visible = true;

        }

        private void bt_ql_nv_Click(object sender, EventArgs e)
        {
            Uc_control_hide();
            uC_nv1.Visible = true;
        }

        private void bt_ql_nl_Click(object sender, EventArgs e)
        {
            Uc_control_hide();
            uC_nl1.Visible = true;
        }

        private void bt_tk_dt_Click(object sender, EventArgs e)
        {
            Uc_control_hide();
            uC_thongke1.Visible = true;
        }

    }
}
