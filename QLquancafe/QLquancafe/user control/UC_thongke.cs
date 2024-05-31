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
    public partial class UC_thongke : UserControl
    {
        public UC_thongke()
        {
            InitializeComponent();
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            Ketnoi_SQL ketnoi_SQL = new Ketnoi_SQL();
            string select = "select * from Hoadon where CreatedAt >= '" +
                dateTimePicker1.Text + "' and CreatedAt < '" + dateTimePicker2.Text + "'";
            dtgv_doanhthu.DataSource = ketnoi_SQL.datatable(select);
        }
    }
}
