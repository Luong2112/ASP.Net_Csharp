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
    public partial class tblBenhAn : Form
    {
        public tblBenhAn()
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
            cmd.CommandText = "select sMaBA as [Mã bệnh án], sMaBS as [Mã bác sĩ],  sMaBN as [Mã bệnh nhân], dNgayLap as [Ngày lập], dNgayHoanThanhBenhAn as [Ngày hoàn thành] from tblBenhAn";
            ad.SelectCommand = cmd;
            tb.Clear();
            ad.Fill(tb);
            dtwBA.DataSource = tb;
            dtwBA.AllowUserToAddRows = false;
        }

        private void tblBenhAn_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            SqlCommand cmm = new SqlCommand("select * from tblBenhNhan", cnn);
            SqlCommand cmm1 = new SqlCommand("select * from tblBacSi", cnn);
            cnn.Open();
            hien();

            SqlDataAdapter ad1 = new SqlDataAdapter();
            DataTable tb1 = new DataTable();
            ad1.SelectCommand = cmm;
            ad1.Fill(tb1);
            cbMabn.DataSource = tb1;
            cbMabn.DisplayMember = "sMaBN";
            cbMabn.ValueMember = "sMaBN";

            SqlDataAdapter ad2 = new SqlDataAdapter();
            DataTable tb2 = new DataTable();
            ad2.SelectCommand = cmm1;
            ad2.Fill(tb2);
            cbMabs.DataSource = tb2;
            cbMabs.DisplayMember = "sMaBS";
            cbMabs.ValueMember = "sMaBS";
            cnn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_bosung_benhan";
            cmd.Parameters.AddWithValue("@MaBA", txtMaBA.Text);
            cmd.Parameters.AddWithValue("@MaBS", cbMabs.Text);
            cmd.Parameters.AddWithValue("@MaBN", cbMabn.Text);
            cmd.Parameters.AddWithValue("@NgayLap", dtNgLap.Text);
            cmd.Parameters.AddWithValue("@NgayHoanThanhBenhAn", dtNgayHT.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void dtwBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBA.Text = dtwBA.CurrentRow.Cells["Mã bệnh án"].Value.ToString();
            cbMabs.Text = dtwBA.CurrentRow.Cells["Mã bác sĩ"].Value.ToString();
            cbMabn.Text = dtwBA.CurrentRow.Cells["Mã bệnh nhân"].Value.ToString();
            dtNgLap.Text = dtwBA.CurrentRow.Cells["Ngày lập"].Value.ToString();
            dtNgayHT.Text = dtwBA.CurrentRow.Cells["Ngày hoàn thành"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_capnhat_benhan";
            cmd.Parameters.AddWithValue("@MaBA", txtMaBA.Text);
            cmd.Parameters.AddWithValue("@MaBS", cbMabs.Text);
            cmd.Parameters.AddWithValue("@MaBN", cbMabn.Text);
            cmd.Parameters.AddWithValue("@NgayLap", dtNgLap.Text);
            cmd.Parameters.AddWithValue("@NgayHT", dtNgayHT.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoabenhan";
            cmd.Parameters.AddWithValue("@MaBA", txtMaBA.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();

            txtMaBA.Text = "";
            cbMabs.Text = "";
            cbMabn.Text = "";
            dtNgLap.Text = "";
            dtNgayHT.Text = "";
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            txtMaBA.Text = "";
            cbMabs.Text = "";
            cbMabn.Text = "";
            dtNgLap.Text = "";
            dtNgayHT.Text = "";
        }
    }
}
