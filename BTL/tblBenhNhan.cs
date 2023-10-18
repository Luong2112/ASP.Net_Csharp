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
    public partial class tblBenhNhan : Form
    {
        public tblBenhNhan()
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
            cmd.CommandText = "select sMaBN as [Mã], sHoTenBN as [Họ và Tên],  bGioiTinh as [Giới tính], dNgaySinh as [Ngày sinh], sDiaChi as [Địa chỉ],  sDienThoaiBN as [SĐT] from tblBenhNhan";
            ad.SelectCommand = cmd;
            tb.Clear();
            ad.Fill(tb);
            dtwBN.DataSource = tb;
            dtwBN.AllowUserToAddRows = false;
        }

        private void tblBenhNhan_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cnn.Open();
            hien();
            cnn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_bosung_benhnhan";
            cmd.Parameters.AddWithValue("@MaBN", txtMaBN.Text);
            cmd.Parameters.AddWithValue("@HoTenBN", txtHotenBN.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbGT.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtNgS.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDc.Text);
            cmd.Parameters.AddWithValue("@DienThoaiBN", txtĐt.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void dtwBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBN.Text = dtwBN.CurrentRow.Cells["Mã"].Value.ToString();
            txtHotenBN.Text = dtwBN.CurrentRow.Cells["Họ và Tên"].Value.ToString();
            cbGT.Text = dtwBN.CurrentRow.Cells["Giới tính"].Value.ToString();
            dtNgS.Text = dtwBN.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            txtDc.Text = dtwBN.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtĐt.Text = dtwBN.CurrentRow.Cells["SĐT"].Value.ToString();

            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "maDT";
            //cmd.Parameters.AddWithValue("@sMaBN", txtMaBN.Text);
            //ad.SelectCommand = cmd;
            //DataTable mdt = new DataTable();
            //mdt.Clear();
            //ad.Fill(mdt);
            //cbMaDT.DataSource = mdt;
            //cbMaDT.DisplayMember = "sMaDT";
            //cbMaDT.ValueMember = "sMaBN";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_capnhat_BN";
            cmd.Parameters.AddWithValue("@MaBN", txtMaBN.Text);
            cmd.Parameters.AddWithValue("@TenBN", txtHotenBN.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbGT.Text);
            cmd.Parameters.AddWithValue("@NgS", dtNgS.Text);
            cmd.Parameters.AddWithValue("@DiaChiBn", txtDc.Text);
            cmd.Parameters.AddWithValue("@DienThoaiBN", txtĐt.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoa_benhnhan";
            cmd.Parameters.AddWithValue("@maBN", txtMaBN.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();

            txtMaBN.Text = "";
            txtHotenBN.Text = "";
            cbGT.Text = "";
            dtNgS.Text = "";
            txtDc.Text = "";
            txtĐt.Text = "";
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            txtMaBN.Text = "";
            txtHotenBN.Text = "";
            cbGT.Text = "";
            dtNgS.Text = "";
            txtDc.Text = "";
            txtĐt.Text = "";
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "donthuoctheoma";
            cmd.Parameters.AddWithValue("@sMaBN", txtMaBN.Text);
            cmd.Parameters.AddWithValue("@sMaDT", cbMaDT.Text);
            ad.SelectCommand = cmd;
            DataTable dt = new DataTable("DonThuoc");
            dt.Clear();
            ad.Fill(dt);
            rptBN_DT baocao = new rptBN_DT();
            baocao.SetDataSource(dt);
            BC_benhnhan f = new BC_benhnhan();
            f.crtBN.ReportSource = baocao;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "benhantheoma";
            cmd.Parameters.AddWithValue("@sMaBN", txtMaBN.Text);
            ad.SelectCommand = cmd;
            DataTable dt = new DataTable("BenhAn");
            dt.Clear();
            ad.Fill(dt);
            rptBN_Ba bc = new rptBN_Ba();
            bc.SetDataSource(dt);
            BC_benhan f = new BC_benhan();
            f.crtBN_BA.ReportSource = bc;
            f.Show();
        }
    }
}
