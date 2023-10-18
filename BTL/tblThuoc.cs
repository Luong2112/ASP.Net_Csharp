using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BTL
{
    public partial class tblThuoc : Form
    {
        public tblThuoc()
        {
            InitializeComponent();
        }

        SqlConnection cnn;
        SqlCommand cmd;
        string str = ConfigurationManager.ConnectionStrings["QLBA"].ConnectionString;
        SqlDataAdapter ad = new SqlDataAdapter();
        DataTable tb = new DataTable();

        void hien()
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select sMaThuoc as [Mã thuốc], sTenThuoc as [Tên thuốc],  fGiaThuoc as [Giá] from tblThuoc";
            ad.SelectCommand = cmd;
            tb.Clear();
            ad.Fill(tb);
            dtwThuoc.DataSource = tb;
            dtwThuoc.AllowUserToAddRows = false;
        }

        private void tblThuoc_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cnn.Open();
            hien();
            cnn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "bosungThuoc";
            cmd.Parameters.AddWithValue("@Mathuoc", txtMaThuoc.Text);
            cmd.Parameters.AddWithValue("@Tenthuoc", txtTenThuoc.Text);
            cmd.Parameters.AddWithValue("@gia", txtGia.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void dtwThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThuoc.Text = dtwThuoc.CurrentRow.Cells["Mã thuốc"].Value.ToString();
            txtTenThuoc.Text = dtwThuoc.CurrentRow.Cells["Tên thuốc"].Value.ToString();
            txtGia.Text = dtwThuoc.CurrentRow.Cells["Giá"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_capnhat_Thuoc";
            cmd.Parameters.AddWithValue("@MaThuoc", txtMaThuoc.Text);
            cmd.Parameters.AddWithValue("@TenThuoc", txtTenThuoc.Text);
            cmd.Parameters.AddWithValue("@gia", txtGia.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoaThuoc";
            cmd.Parameters.AddWithValue("@MaThuoc", txtMaThuoc.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();

            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtGia.Text = "";
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtGia.Text = "";
;        }
    }
}
