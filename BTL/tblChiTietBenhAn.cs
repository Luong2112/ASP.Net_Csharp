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
    public partial class tblChiTietBenhAn : Form
    {
        public tblChiTietBenhAn()
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
            cmd.CommandText = "select sMaBA as [Mã bệnh án], sMaBenh as [Mã bệnh],  sDichVu as [Dịch Vụ], iMaPhong as [Mã phòng] from tblChiTietBenhAn";
            ad.SelectCommand = cmd;
            tb.Clear();
            ad.Fill(tb);
            dtwCTBA.DataSource = tb;
            dtwCTBA.AllowUserToAddRows = false;
        }
        private void tblChiTietBenhAn_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            SqlCommand cmm = new SqlCommand("select * from tblBenhAn", cnn);
            SqlCommand cmm1 = new SqlCommand("select * from tblBenh", cnn);
            SqlCommand cmm2 = new SqlCommand("select * from tblPhong", cnn);
            cnn.Open();
            hien();

            SqlDataAdapter ad1 = new SqlDataAdapter();
            DataTable tb1 = new DataTable();
            ad1.SelectCommand = cmm;
            ad1.Fill(tb1);
            cbMaBA.DataSource = tb1;
            cbMaBA.DisplayMember = "sMaBA";
            cbMaBA.ValueMember = "sMaBA";

            SqlDataAdapter ad2 = new SqlDataAdapter();
            DataTable tb2 = new DataTable();
            ad2.SelectCommand = cmm1;
            ad2.Fill(tb2);
            cbMaB.DataSource = tb2;
            cbMaB.DisplayMember = "sMaBenh";
            cbMaB.ValueMember = "sMaBenh";

            SqlDataAdapter ad3 = new SqlDataAdapter();
            DataTable tb3 = new DataTable();
            ad3.SelectCommand = cmm2;
            ad3.Fill(tb3);
            cbMaP.DataSource = tb3;
            cbMaP.DisplayMember = "iMaPhong";
            cbMaP.ValueMember = "iMaPhong";
            cnn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "bosungCTBA";
            cmd.Parameters.AddWithValue("@maBA", cbMaBA.Text);
            cmd.Parameters.AddWithValue("@maBenh", cbMaB.Text);
            cmd.Parameters.AddWithValue("@maPhong", cbMaP.Text);
            cmd.Parameters.AddWithValue("@dv", txtDV.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void dtwCTBA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaBA.Text = dtwCTBA.CurrentRow.Cells["Mã bệnh án"].Value.ToString();
            cbMaB.Text = dtwCTBA.CurrentRow.Cells["Mã bệnh"].Value.ToString();
            txtDV.Text = dtwCTBA.CurrentRow.Cells["Dịch vụ"].Value.ToString();
            cbMaP.Text = dtwCTBA.CurrentRow.Cells["Mã phòng"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_capnhat_CTBA";
            cmd.Parameters.AddWithValue("@MaBA", cbMaBA.Text);
            cmd.Parameters.AddWithValue("@MaBenh", cbMaB.Text);
            cmd.Parameters.AddWithValue("@dv", txtDV.Text);
            cmd.Parameters.AddWithValue("@MaPhong", cbMaP.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoaCTbenhan";
            cmd.Parameters.AddWithValue("@MaBA", cbMaBA.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();

            cbMaBA.Text = "";
            cbMaB.Text = "";
            txtDV.Text = "";
            cbMaP.Text = "";
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            cbMaBA.Text = "";
            cbMaB.Text = "";
            txtDV.Text = "";
            cbMaP.Text = "";
        }
    }
}
