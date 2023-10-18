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
    public partial class tblPhong : Form
    {
        public tblPhong()
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
            cmd.CommandText = "select iMaPhong as [Mã phòng], sTenPhong as [Tên phòng],  sLoaiPhong as [Loại phòng], iSlGiuong as [Số lượng giường] from tblPhong";
            ad.SelectCommand = cmd;
            tb.Clear();
            ad.Fill(tb);
            dtwPhong.DataSource = tb;
            dtwPhong.AllowUserToAddRows = false;
        }
        private void tblPhong_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cnn.Open();
            hien();
            cnn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "bosungPhong";
            cmd.Parameters.AddWithValue("@MaPhong", txtMaP.Text);
            cmd.Parameters.AddWithValue("@tenPhong", txtTenP.Text);
            cmd.Parameters.AddWithValue("@Loai", txtLoaiP.Text);
            cmd.Parameters.AddWithValue("@SLgiuong", txtSLgiuong.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void dtwPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaP.Text = dtwPhong.CurrentRow.Cells["Mã phòng"].Value.ToString();
            txtTenP.Text = dtwPhong.CurrentRow.Cells["Tên phòng"].Value.ToString();
            txtLoaiP.Text = dtwPhong.CurrentRow.Cells["Loại phòng"].Value.ToString();
            txtSLgiuong.Text = dtwPhong.CurrentRow.Cells["Số lượng giường"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_capnhat_Phong";
            cmd.Parameters.AddWithValue("@MaPhong", txtMaP.Text);
            cmd.Parameters.AddWithValue("@tenPhong", txtTenP.Text);
            cmd.Parameters.AddWithValue("@Loai", txtLoaiP.Text);
            cmd.Parameters.AddWithValue("@SLgiuong", txtSLgiuong.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoaPhong";
            cmd.Parameters.AddWithValue("@MaPhong", txtMaP.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();

            txtMaP.Text = "";
            txtTenP.Text = "";
            txtLoaiP.Text = "";
            txtSLgiuong.Text = "";
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            txtMaP.Text = "";
            txtTenP.Text = "";
            txtLoaiP.Text = "";
            txtSLgiuong.Text = "";
        }
    }
}
