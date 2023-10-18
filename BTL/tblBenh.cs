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
    public partial class tblBenh : Form
    {
        public tblBenh()
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
            cmd.CommandText = "select sMaBenh as [Mã], sTenBenh as [Tên] from tblBenh";
            ad.SelectCommand = cmd;
            tb.Clear();
            ad.Fill(tb);
            dtwBenh.DataSource = tb;
            dtwBenh.AllowUserToAddRows = false;
        }

        private void tblBenh_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cnn.Open();
            hien();
            cnn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_bosung_benh";
            cmd.Parameters.AddWithValue("@MaBenh", txtMaB.Text);
            cmd.Parameters.AddWithValue("@TenBenh", txtTenB.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void dtwBenh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaB.Text = dtwBenh.CurrentRow.Cells["Mã"].Value.ToString();
            txtTenB.Text = dtwBenh.CurrentRow.Cells["Tên"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_capnhat_benh";
            cmd.Parameters.AddWithValue("@MaB", txtMaB.Text);
            cmd.Parameters.AddWithValue("@TenB", txtTenB.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoabenh";
            cmd.Parameters.AddWithValue("@MaB", txtMaB.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            hien();
            txtMaB.Text = "";
            txtTenB.Text = "";
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            txtMaB.Text = "";
            txtTenB.Text = "";
        }
    }
}
