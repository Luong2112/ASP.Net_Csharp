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
    public partial class tblDonThuoc : Form
    {
        public tblDonThuoc()
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
            cmd.CommandText = "select sMaDT as [Mã đơn thuốc], sMaBN as [Mã bệnh nhân],  dNgayCap as [Ngày cấp] from tblDonThuoc";
            ad.SelectCommand = cmd;
            tb.Clear();
            ad.Fill(tb);
            dtwDT.DataSource = tb;
            dtwDT.AllowUserToAddRows = false;
        }
        private void tblDonThuoc_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            SqlCommand cmm = new SqlCommand("select * from tblBenhNhan", cnn);
            cnn.Open();
            hien();

            SqlDataAdapter ad1 = new SqlDataAdapter();
            DataTable tb1 = new DataTable();
            ad1.SelectCommand = cmm;
            ad1.Fill(tb1);
            cbMaBN.DataSource = tb1;
            cbMaBN.DisplayMember = "sMaBN";
            cbMaBN.ValueMember = "sMaBN";
            cnn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "bosungDonThuoc";
            cmd.Parameters.AddWithValue("@MaDT", txtMaDT.Text);
            cmd.Parameters.AddWithValue("@MaBN", cbMaBN.Text);
            cmd.Parameters.AddWithValue("@Ngaycap", dtNgayCap.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_capnhat_DonThuoc";
            cmd.Parameters.AddWithValue("@MaDT", txtMaDT.Text);
            cmd.Parameters.AddWithValue("@MaBN", cbMaBN.Text);
            cmd.Parameters.AddWithValue("@Ngaycap", dtNgayCap.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoaDonThuoc";
            cmd.Parameters.AddWithValue("@MaDT", txtMaDT.Text);;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();

            txtMaDT.Text = "";
            cbMaBN.Text = "";
            dtNgayCap.Text = "";
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            txtMaDT.Text = "";
            cbMaBN.Text = "";
            dtNgayCap.Text = "";
        }

        private void dtwDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDT.Text = dtwDT.CurrentRow.Cells["Mã đơn thuốc"].Value.ToString();
            cbMaBN.Text = dtwDT.CurrentRow.Cells["Mã bệnh nhân"].Value.ToString();
            dtNgayCap.Text = dtwDT.CurrentRow.Cells["Ngày cấp"].Value.ToString();
        }
    }
}
