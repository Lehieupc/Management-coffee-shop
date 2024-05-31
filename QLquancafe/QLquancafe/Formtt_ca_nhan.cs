using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquancafe
{
    public partial class Formtt_ca_nhan : Form
    {
        public Formtt_ca_nhan(string id)
        {
            InitializeComponent();
            _id = id;
        }
        string _id;
        Ketnoi_SQL ketnoi_SQL = new Ketnoi_SQL();
        private void hienthi_tt()
        {
            string hoten = "select [Họ tên] from Nhanvien where id = '" + _id + "'";
            string ngaysinh = "select [Ngày sinh] from Nhanvien where id = '" + _id + "'";
            string gioitinh = "select [Giới tính] from Nhanvien where id = '" + _id + "'";
            string sdt = "select [SDT] from Nhanvien where id = '" + _id + "'";
            string diachi = "select [Địa chỉ] from Nhanvien where id = '" + _id + "'";
            tb_hoten.Text = ketnoi_SQL.command_string(hoten);
            dtp_ngaysinh.Text = ketnoi_SQL.command_string(ngaysinh);
            cbb_gioitinh.Text = ketnoi_SQL.command_string(gioitinh);
            tb_sdt.Text = ketnoi_SQL.command_string(sdt);
            tb_diachi.Text = ketnoi_SQL.command_string(diachi);
        }

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
        private void Formtt_ca_nhan_Load(object sender, EventArgs e)
        {
            hienthi_tt();
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
            string select = "select * from Nhanvien";
            string update_nv = "update Nhanvien set [Họ tên] = N'" + tb_hoten.Text
            + "', [Ngày sinh] = '" + dtp_ngaysinh.Text + "', [Giới tính] = N'" + cbb_gioitinh.Text
            + "', SDT = '" + tb_sdt.Text + "', [Địa chỉ] = N'" + tb_diachi.Text +
            "' where id = '" + _id + "'";
            ketnoi_SQL.command_sql(update_nv, select);
            set_read_only();
            bt_sua.Visible = true;
            set_hide_bt();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            hienthi_tt();
            set_read_only();
            bt_sua.Visible = true;
            set_hide_bt();
        }
    }
}
