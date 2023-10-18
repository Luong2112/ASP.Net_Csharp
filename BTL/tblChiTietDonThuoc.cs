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
    public partial class tblChiTietDonThuoc : Form
    {
        public tblChiTietDonThuoc()
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
            cmd.CommandText = "select sMaDT as [Mã đơn thuốc], sMaThuoc as [Mã thuốc], iSoluong as [Số lượng],  sChuThich as [Chú thích] from tblChiTietDonThuoc";
            ad.SelectCommand = cmd;
            tb.Clear();
            ad.Fill(tb);
            dtwCTDT.DataSource = tb;
            dtwCTDT.AllowUserToAddRows = false;
        }
        private void tblChiTietDonThuoc_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            SqlCommand cmm = new SqlCommand("select * from tblDonThuoc", cnn);
            SqlCommand cmm1 = new SqlCommand("select * from tblThuoc", cnn);
            cnn.Open();
            hien();

            SqlDataAdapter ad1 = new SqlDataAdapter();
            DataTable tb1 = new DataTable();
            ad1.SelectCommand = cmm;
            ad1.Fill(tb1);
            cbMaDT.DataSource = tb1;
            cbMaDT.DisplayMember = "sMaDT";
            cbMaDT.ValueMember = "sMaDT";

            SqlDataAdapter ad2 = new SqlDataAdapter();
            DataTable tb2 = new DataTable();
            ad2.SelectCommand = cmm1;
            ad2.Fill(tb2);
            cbMaThuoc.DataSource = tb2;
            cbMaThuoc.DisplayMember = "sMaThuoc";
            cbMaThuoc.ValueMember = "sMaThuoc";
            cnn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "bosungCTDT";
            cmd.Parameters.AddWithValue("@MaDT", cbMaDT.Text);
            cmd.Parameters.AddWithValue("@MaThuoc", cbMaThuoc.Text);
            cmd.Parameters.AddWithValue("@sl", txtSoluong.Text);
            cmd.Parameters.AddWithValue("@note", txtNote.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void dtwCTDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaDT.Text = dtwCTDT.CurrentRow.Cells["Mã đơn thuốc"].Value.ToString();
            cbMaThuoc.Text = dtwCTDT.CurrentRow.Cells["Mã thuốc"].Value.ToString();
            txtSoluong.Text = dtwCTDT.CurrentRow.Cells["Số lượng"].Value.ToString();
            txtNote.Text = dtwCTDT.CurrentRow.Cells["Chú thích"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_capnhat_CTDT";
            cmd.Parameters.AddWithValue("@MaDT", cbMaDT.Text);
            cmd.Parameters.AddWithValue("@MaThuoc", cbMaThuoc.Text);
            cmd.Parameters.AddWithValue("@sl", txtSoluong.Text);
            cmd.Parameters.AddWithValue("@note", txtNote.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoaCTDT";
            cmd.Parameters.AddWithValue("@MaDT", cbMaDT.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();

            cbMaDT.Text = "";
            cbMaThuoc.Text = "";
            txtSoluong.Text = "";
            txtNote.Text = "";
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            cbMaDT.Text = "";
            cbMaThuoc.Text = "";
            txtSoluong.Text = "";
            txtNote.Text = "";
        }
    }
}
