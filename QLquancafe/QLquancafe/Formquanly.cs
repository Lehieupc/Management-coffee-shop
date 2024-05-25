using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void bt_them_Click(object sender, EventArgs e)
        {
            string gioitinh = rdb_nam.Checked ? rdb_nam.Text : rdb_nu.Text ;
            dataGridView1.Rows.Add(tb_hoten.Text,dtp_ngaysinh.Text,gioitinh,tb_sdt.Text,
                tb_diachi.Text,tb_email.Text,tb_tk_nv.Text,tb_mk_nv.Text);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            int row_click = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(row_click);
        }
    }
}
