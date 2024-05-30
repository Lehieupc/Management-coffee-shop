using QLquancafe.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquancafe
{
    public partial class Formchung : Form
    {
        public Formchung(string id)
        {
            InitializeComponent();
            _id = id;
        }
        public Formchung()
        {
            InitializeComponent();
        }
        private void Uc_control_hide()
        {
            foreach (Control control in this.Controls)
            {
                if (control is UserControl)
                {
                    control.Hide();
                }
            }
        }
        Ketnoi_SQL ketnoi_SQL = new Ketnoi_SQL();
        public string _id;
        private void hienthi_tt()
        {
            string hoten = "select [Họ tên] from Nhanvien where id = '" + _id + "'";
            string ngaysinh = "select [Ngày sinh] from Nhanvien where id = '" + _id + "'";
            string gioitinh = "select [Giới tính] from Nhanvien where id = '" + _id + "'";
            string sdt = "select [SDT] from Nhanvien where id = '" + _id + "'";
            string diachi = "select [Địa chỉ] from Nhanvien where id = '" + _id + "'";
            uC_tt_canhan1.tb_hoten.Text = ketnoi_SQL.command_string(hoten);
            uC_tt_canhan1.dtp_ngaysinh.Text = ketnoi_SQL.command_string(ngaysinh);
            uC_tt_canhan1.cbb_gioitinh.Text = ketnoi_SQL.command_string(gioitinh);
            uC_tt_canhan1.tb_sdt.Text = ketnoi_SQL.command_string(sdt);
            uC_tt_canhan1.tb_diachi.Text = ketnoi_SQL.command_string(diachi);
        }
        private void Formchung_Load(object sender, EventArgs e)
        {
            hienthi_tt();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Formquanly formquanly = new Formquanly();
            formquanly.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uc_control_hide();
            uC_qlban1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uc_control_hide();
            uC_tt_canhan1.Visible = true;
        }
    }
}
