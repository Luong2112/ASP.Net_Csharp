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
    public partial class tblBacSi : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string str = ConfigurationManager.ConnectionStrings["QLBA"].ConnectionString;
        SqlDataAdapter ad = new SqlDataAdapter();
        DataTable tb = new DataTable();

        void hien()
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = " select * from thongtinBS";
            ad.SelectCommand = cmd;
            tb.Clear();
            ad.Fill(tb);
            dtwBS.DataSource = tb;
            dtwBS.AllowUserToAddRows = false;
        }

        public tblBacSi()
        {
            InitializeComponent();
        }

        private void tblBacSi_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cnn.Open();
            hien();
            cnn.Close();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_bosung_bacsi";
            cmd.Parameters.AddWithValue("@MaBS", txtMaBS.Text);
            cmd.Parameters.AddWithValue("@TenBS", txtTenBS.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbGioitinh.Text);
            cmd.Parameters.AddWithValue("@DiaChiBS", txtDc.Text);
            cmd.Parameters.AddWithValue("@ChuyenKhoa", cbChuyenKhoa.Text);
            cmd.Parameters.AddWithValue("@DienThoaiBS", txtDT.Text);
            cmd.Parameters.AddWithValue("@NgaySinhBS", dtNgS.Text);
            cmd.Parameters.AddWithValue("@Ngayvaolam", dtNVL.Text);
            cmd.Parameters.AddWithValue("@Luongcoban", txtLuong.Text);
            cmd.Parameters.AddWithValue("@Phucap", txtPC.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void dtwBS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBS.Text = dtwBS.CurrentRow.Cells["Mã"].Value.ToString();
            txtTenBS.Text = dtwBS.CurrentRow.Cells["Họ và Tên"].Value.ToString();
            cbGioitinh.Text = dtwBS.CurrentRow.Cells["Giới tính"].Value.ToString();
            dtNgS.Text = dtwBS.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            txtDc.Text = dtwBS.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtDT.Text = dtwBS.CurrentRow.Cells["SĐT"].Value.ToString();
            cbChuyenKhoa.Text = dtwBS.CurrentRow.Cells["Khoa"].Value.ToString();
            dtNVL.Text = dtwBS.CurrentRow.Cells["Ngày vào làm"].Value.ToString();
            txtLuong.Text = dtwBS.CurrentRow.Cells["Lương cb"].Value.ToString();
            txtPC.Text = dtwBS.CurrentRow.Cells["Phụ cấp"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_capnhat_bacsi";
            cmd.Parameters.AddWithValue("@MaBS", txtMaBS.Text);
            cmd.Parameters.AddWithValue("@TenBS", txtTenBS.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbGioitinh.Text);
            cmd.Parameters.AddWithValue("@DiaChiBS", txtDc.Text);
            cmd.Parameters.AddWithValue("@ChuyenKhoa", cbChuyenKhoa.Text);
            cmd.Parameters.AddWithValue("@DienThoaiBS", txtDT.Text);
            cmd.Parameters.AddWithValue("@dob", dtNgS.Text);
            cmd.Parameters.AddWithValue("@ngayvaolam", dtNVL.Text);
            cmd.Parameters.AddWithValue("@Luongcoban", txtLuong.Text);
            cmd.Parameters.AddWithValue("@Phucap", txtPC.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoaBS_theoma";
            cmd.Parameters.AddWithValue("@ma", txtMaBS.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();

            txtMaBS.Text = "";
            txtTenBS.Text = "";
            cbGioitinh.Text = "";
            dtNgS.Text = "";
            txtDc.Text = "";
            txtDT.Text = "";
            cbChuyenKhoa.Text = "";
            dtNVL.Text = "";
            txtLuong.Text = "";
            txtPC.Text = "";
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            txtMaBS.Text = "";
            txtTenBS.Text = "";
            cbGioitinh.Text = "";
            dtNgS.Text = "";
            txtDc.Text = "";
            txtDT.Text = "";
            cbChuyenKhoa.Text = "";
            dtNVL.Text = "";
            txtLuong.Text = "";
            txtPC.Text = "";
        }
    }
}
