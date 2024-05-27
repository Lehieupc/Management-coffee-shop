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
        string chuoiketnoi = "Data Source = DESKTOP-E9L97H8;" +
            "Initial Catalog=SQLcafe;" +
            "Integrated Security=True;";
        SqlConnection conn = null;
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            this.Hide();
            Formchung formchung = new Formchung();
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
