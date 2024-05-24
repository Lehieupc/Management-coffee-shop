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
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formchung formchung = new Formchung();
            if(tb_tk.Text == "admin" && tb_mk.Text == "admin")
            {
                formchung.teep = true;
            }
            formchung.ShowDialog();
            tb_tk.Clear();
            tb_mk.Clear();
            this.Visible = true;
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
