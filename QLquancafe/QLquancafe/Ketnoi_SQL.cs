using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace QLquancafe
{
    public class Ketnoi_SQL
    {
        string chuoiketnoi = "Data Source = DESKTOP-E9L97H8;" +
        "Initial Catalog=SQLcafe;" +
        "Integrated Security=True;";
        SqlConnection conn = null;
        DataTable dt = new DataTable();
        public DataTable datatable(string select)
        {
            // hàm để lấy dữ liệu từ sql đổ vào datatTable
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(select, conn);
            sqlData.Fill(dt);
            conn.Close();
            return dt;
        }
        public void command_sql(string cmd,string select)
        {
            // hàm để thêm sửa xóa vào bảng trong sql 
                conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(select, conn);
                dt.Clear();
                sqlData.Fill(dt);
                conn.Close();
        }
        public string command_string(string select)
        {
            // hàm để lấy thông tin ra cho vào string
            try
            {
                conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                SqlCommand command = new SqlCommand(select, conn);
                return command.ExecuteScalar().ToString();
            }
            catch (NullReferenceException)
            {
                return null;
            }

        }
    }
}
