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
    public partial class UC_mhc : UserControl
    {
        public UC_mhc()
        {
            InitializeComponent();
        }
        Ketnoi_SQL ketnoi_mon = new Ketnoi_SQL();
        Ketnoi_SQL ketnoi_danhmuc = new Ketnoi_SQL();
        string select_danhmuc = "select [Tên danh mục] from Danhmuc";

        private void UC_mhc_Load(object sender, EventArgs e)
        {
            cbb_dm.DataSource = ketnoi_danhmuc.load_cbb(select_danhmuc);
            cbb_dm.DisplayMember = "Tên danh mục";
        }

        private void UC_mhc_VisibleChanged(object sender, EventArgs e)
        {

            cbb_dm.DataSource = ketnoi_danhmuc.load_cbb(select_danhmuc);
            cbb_dm.DisplayMember = "Tên danh mục";
        }
        private void cbb_dm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select_mon = "select [Tên món] from Menu where [Danh mục] = '" + cbb_dm.Text + "'";
            cbb_mon.DataSource = ketnoi_mon.load_cbb(select_mon);
            cbb_mon.DisplayMember = "Tên món";
        }
        Button button = new Button();
        private void ban_click(object sender, EventArgs e)
        {
            if (button != null)
            {
                button.BackColor = Color.FromArgb(192, 255, 255);
            }
            if(button == ((Button)sender))
            {
                button.BackColor = Color.FromArgb(192, 255, 255);
                button = null;
            }
            else
            {
                ((Button)sender).BackColor = Color.FromArgb(255, 128, 128);
                button = ((Button)sender);
            }
        }


    }
}
