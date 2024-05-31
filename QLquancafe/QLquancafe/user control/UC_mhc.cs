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

            string select_mon = "select [Tên món] from Menu where [Danh mục] = N'" + cbb_dm.Text + "'";
            cbb_mon.DataSource = ketnoi_mon.load_cbb(select_mon);
            cbb_mon.DisplayMember = "Tên món";

        }
        Button button_chon = new Button();
        Button button_nguoi_ngoi = new Button();
        private void ban_click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            tinh_tien();
            if (button_chon != null)
            {
                button_chon.BackColor = Color.FromArgb(192, 255, 255);
            }
            if (((Button)sender).BackColor != Color.FromArgb(192, 255, 192))
            {
                ((Button)sender).BackColor = Color.FromArgb(255, 128, 128);
                button_chon = ((Button)sender);
            }
        }
        private void tinh_tien()
        {
            double n = 0;
            int colum_count = dataGridView1.ColumnCount - 1;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                n += Convert.ToDouble(dataGridView1.Rows[i].Cells[colum_count].Value);
            }
            tb_tien.Text = n.ToString();
        }
        private void set_button()
        {
            if (button_chon == null) ;
            else
            {
                button_nguoi_ngoi = button_chon;
                button_nguoi_ngoi.BackColor = Color.FromArgb(192, 255, 192);
                button_chon = null;
            }
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            set_button();
            string select_gia = "select [Đơn giá] from Menu where [Tên món] = N'" + cbb_mon.Text + "'";
            string gia = ketnoi_mon.command_string(select_gia);
            int thanh_tien = Convert.ToInt32(gia) * Convert.ToInt32(nbr_sl.Value);
            dataGridView1.Rows.Add(cbb_mon.Text, gia, nbr_sl.Value, thanh_tien);
            tinh_tien();

        }
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            int row_click = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(row_click);
            tinh_tien();
        }
        private void nbr_gg_ValueChanged(object sender, EventArgs e)
        {
            tinh_tien();
            double gg = Convert.ToDouble(tb_tien.Text) * (100 - Convert.ToDouble(nbr_gg.Value)) / 100;
            tb_tien.Text = gg.ToString();
        }

        private void bt_thanhtoan_click(object sender, EventArgs e)
        {
            button_nguoi_ngoi.BackColor = Color.FromArgb(192, 255, 255);
        }
    }
}
