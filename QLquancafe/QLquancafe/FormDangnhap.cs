using QLquancafe.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquancafe
{
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }
        Ketnoi_SQL ketnoi = new Ketnoi_SQL();
        private string id_nv()
        {
            string id = "select id from Nhanvien where [Tài khoản] = '"
            + tb_tk.Text + "'";
            return ketnoi.command_string(id);
        }
        private bool role_member()
        {
            string role = "select [Vai trò] from Nhanvien where [Tài khoản] = '"
            + tb_tk.Text + "'";
            if (ketnoi.command_string(role) == "admin")
            {
                return true;
            }
            else return false;
        }
        private bool kt_dn()
        {
            string select = "select [Mật khẩu] from Nhanvien where [Tài khoản] = '"
            + tb_tk.Text + "' and [Mật khẩu] = '" + tb_mk.Text + "'";
            if (ketnoi.command_string(select) == "") return false;
            else if (ketnoi.command_string(select) == tb_mk.Text) return true;
            else return false;
        }
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            
             if (kt_dn())
            {
                this.Hide();
                Formchung formchung = new Formchung(id_nv());
                formchung.bt_quanly.Visible = role_member() ? true : false;
                formchung.ShowDialog();
                tb_tk.Clear();
                tb_mk.Clear();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tb_tk.Clear();
                tb_mk.Clear();
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_hien_mk_CheckedChanged(object sender, EventArgs e)
        {
            tb_mk.UseSystemPasswordChar = cb_hien_mk.Checked ? false : true;
        }


    }
}
