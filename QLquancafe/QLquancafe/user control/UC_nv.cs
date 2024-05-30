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
    public partial class UC_nv : UserControl
    {
        public UC_nv()
        {
            InitializeComponent();
        }
        // câu lệnh mở bảng sql 
        string select = "select * from Nhanvien where [Vai trò] = 'nv' ";
        Ketnoi_SQL ketnoi = new Ketnoi_SQL();
        private void UC_nv_Load(object sender, EventArgs e)
        {
            dtgv_nv.DataSource = ketnoi.datatable(select);
        }
        // thêm sửa xóa nhân viên 
        private void bt_them_nv_Click(object sender, EventArgs e)
        {
            string gioitinh = rdb_nam.Checked ? rdb_nam.Text : rdb_nu.Text;
            string insert_nv = "insert into Nhanvien values('" + tb_id.Text + "',N'" + tb_hoten.Text + "','"
                + dtp_ngaysinh.Text + "',N'" + gioitinh + "','" + tb_sdt.Text + "',N'"
                + tb_diachi.Text + "','" + tb_tk_nv.Text + "','" + tb_mk_nv.Text + "','nv')";
            try
            {
                ketnoi.command_sql(insert_nv, select);
            }
            catch(SqlException)
            {
                MessageBox.Show("Id nhân viên chỉ cho 1 nhân viên","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void bt_xoa_nv_Click(object sender, EventArgs e)
        {
            int row_click = dtgv_nv.CurrentRow.Index;
            string delete_nv = "delete Nhanvien where id = '"
                + dtgv_nv.Rows[row_click].Cells[0].Value + "'";
            ketnoi.command_sql(delete_nv, select);
        }

        private void dtgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dtgv_nv.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_hoten.Text = dtgv_nv.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtp_ngaysinh.Text = dtgv_nv.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dtgv_nv.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
            {
                rdb_nam.Checked = true;
            }
            else
            {
                rdb_nu.Checked = true;
            }
            tb_sdt.Text = dtgv_nv.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_diachi.Text = dtgv_nv.Rows[e.RowIndex].Cells[5].Value.ToString();
            tb_tk_nv.Text = dtgv_nv.Rows[e.RowIndex].Cells[6].Value.ToString();
            tb_mk_nv.Text = dtgv_nv.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        private void bt_sua_nv_Click(object sender, EventArgs e)
        {
            string gioitinh = rdb_nam.Checked ? rdb_nam.Text : rdb_nu.Text;
            int row_click = dtgv_nv.CurrentRow.Index;
            string update_nv = "update Nhanvien set [Họ tên] = N'" + tb_hoten.Text
                + "', [Ngày sinh] = '" + dtp_ngaysinh.Text + "', [Giới tính] = N'" + gioitinh
                + "', SDT = '" + tb_sdt.Text + "', [Địa chỉ] = N'" + tb_diachi.Text
                + "', [Tài khoản] = '" + tb_tk_nv.Text + "', [Mật khẩu] ='" + tb_mk_nv.Text
                + "', [Vai trò] = 'nv' " +
                " where id = '" + dtgv_nv.Rows[row_click].Cells[0].Value + "'";
            ketnoi.command_sql(update_nv, select);
        }
    }
}
