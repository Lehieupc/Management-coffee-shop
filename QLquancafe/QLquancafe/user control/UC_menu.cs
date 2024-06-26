﻿using System;
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
    public partial class UC_menu : UserControl
    {
        public UC_menu()
        {
            InitializeComponent();
        }
        // lấy tất bảng menu trong csdl 
        string select = "select * from Menu";
        string select_danhmuc = "select [Tên danh mục] from Danhmuc";
        Ketnoi_SQL ketnoi_menu = new Ketnoi_SQL();
        Ketnoi_SQL ketnoi_danhmuc = new Ketnoi_SQL();
        private void UC_menu_VisibleChanged(object sender, EventArgs e)
        {
            cbb_danh_muc.DisplayMember = "Tên danh mục";
            cbb_danh_muc.DataSource = ketnoi_danhmuc.load_cbb(select_danhmuc);
        }
        private void UC_menu_Load(object sender, EventArgs e)
        {
            dtgv_menu.DataSource = ketnoi_menu.datatable(select);
            cbb_danh_muc.DisplayMember = "Tên danh mục";
            cbb_danh_muc.DataSource = ketnoi_danhmuc.load_cbb(select_danhmuc);
        }

        private void bt_them_mon_Click(object sender, EventArgs e)
        {
            string insert_menu = "insert into Menu values ('" + tb_ma_mon.Text + "',N'"
                + tb_ten_mon.Text + "',N'" + tb_dongia_mon.Text + "',N'" + cbb_danh_muc.Text + "')";
            ketnoi_menu.command_sql(insert_menu,select);
        }

        private void dtgv_menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ma_mon.Text = dtgv_menu.Rows[e.RowIndex].Cells[0].Value.ToString() ;
            tb_ten_mon.Text = dtgv_menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_dongia_mon.Text = dtgv_menu.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbb_danh_muc.Text = dtgv_menu.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void bt_sua_mon_Click(object sender, EventArgs e)
        {
            int row_click = dtgv_menu.CurrentRow.Index;
            string update_menu = "update Menu set  [Tên món] = N'"+ tb_ten_mon.Text 
                + "',[Đơn giá] = '" + tb_dongia_mon.Text + "', [Danh mục] = N'"
                + cbb_danh_muc.Text + "' where [Mã món] = '" +
                dtgv_menu.Rows[row_click].Cells[0].Value + "'";
            ketnoi_menu.command_sql(update_menu, select);
        }

        private void bt_xoa_mon_Click(object sender, EventArgs e)
        {
            int row_click = dtgv_menu.CurrentRow.Index;
            string delete_menu = "delete Menu where [Mã món] = '" +
                   dtgv_menu.Rows[row_click].Cells[0].Value + "'";
            ketnoi_menu.command_sql(delete_menu,select);
        }

        private void bt_timkiem_mon_Click(object sender, EventArgs e)
        {

        }
    }
}
