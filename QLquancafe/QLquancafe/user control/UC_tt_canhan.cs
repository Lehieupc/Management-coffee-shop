using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquancafe.user_control
{
    public partial class UC_tt_canhan : UserControl
    {
        public UC_tt_canhan()
        {
            InitializeComponent();
        }
        Ketnoi_SQL ketnoi_SQL = new Ketnoi_SQL();
        private void set_read_only()
        {
            foreach (Control ct in tableLayoutPanel1.Controls)
            {
                if (ct is TextBox tb)
                {
                    tb.ReadOnly = bt_sua.Visible ? false : true;
                }
            }
        }
        private void set_hide_bt()
        {
            if (bt_sua.Visible == true)
            {
                bt_huy.Visible = false;
                bt_xac_nhan.Visible = false;
            }
            else
            {
                bt_huy.Visible = true;
                bt_xac_nhan.Visible = true;
            }
        }
        private void UC_ttcn_Load(object sender, EventArgs e)
        {
            set_read_only();
            set_hide_bt();
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            set_read_only();
            bt_sua.Visible = false;
            set_hide_bt();
        }

        private void bt_xac_nhan_Click(object sender, EventArgs e)
        {

        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            set_read_only();
            bt_sua.Visible = true;
            set_hide_bt();
        }
    }
}