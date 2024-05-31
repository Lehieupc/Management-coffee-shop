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
    public partial class UC_dm : UserControl
    {
        public UC_dm()
        {
            InitializeComponent();
        }
        Ketnoi_SQL ketnoi = new Ketnoi_SQL();
        string select = "select * from Danhmuc";
        private void UC_dm_Load(object sender, EventArgs e)
        {
            dtgv_dm.DataSource = ketnoi.datatable(select);
        }
        private void bt_them_nl_Click(object sender, EventArgs e)
        {
            string insert = "insert into Danhmuc values('" + tb_ma_dm.Text  +"',N'" + tb_ten_dm.Text + "')";
            ketnoi.command_sql(insert, select);
        }
        private void dtgv_nl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ma_dm.Text = dtgv_dm.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_ten_dm.Text = dtgv_dm.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void bt_sua_nl_Click(object sender, EventArgs e)
        {
            string update = "update Danhmuc set [Tên danh mục] = N'" + tb_ten_dm.Text 
                            + "' where [Mã danh mục] = '" + tb_ma_dm.Text + "'";
            ketnoi.command_sql(update,select);
        }

        private void bt_xoa_nl_Click(object sender, EventArgs e)
        {
            string delete = "delete Danhmuc where [Mã danh mục] = '" + dtgv_dm.CurrentRow.Cells[0].Value + "'";
            ketnoi.command_sql(delete,select);
        }


    }
}
