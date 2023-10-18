using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTendn.Text == "" || txtMk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else
            {
                if (txtTendn.Text != "nam2002")
                {
                    label3.Text = "Sai tên đăng nhập!";
                }
                else
                    label3.Text = "";

                if (txtMk.Text != "12345678")
                {
                    label4.Text = "Sai mật khẩu!";
                }
                else
                    label4.Text = "";

                if (txtTendn.Text == "nam2002" && txtMk.Text == "12345678")
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
