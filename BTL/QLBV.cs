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
    public partial class QLBV : Form
    {
        public QLBV()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.MdiParent = this;
            dn.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "ask", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void bácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblBacSi bs = new tblBacSi();
            bs.MdiParent = this;
            bs.Show();
        }

        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblBenhNhan bn = new tblBenhNhan();
            bn.MdiParent = this;
            bn.Show();
        }

        private void bệnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tblBenh benh = new tblBenh();
            benh.MdiParent = this;
            benh.Show();
        }

        private void bệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblBenhAn ba = new tblBenhAn();
            ba.MdiParent = this;
            ba.Show();
        }

        private void chiTiếtBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblChiTietBenhAn ctba = new tblChiTietBenhAn();
            ctba.MdiParent = this;
            ctba.Show();
        }

        private void thuốcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tblThuoc thuoc = new tblThuoc();
            thuoc.MdiParent = this;
            thuoc.Show();
        }

        private void đơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblDonThuoc dt = new tblDonThuoc();
            dt.MdiParent = this;
            dt.Show();
        }

        private void chiTiếtĐơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblChiTietDonThuoc ctdt = new tblChiTietDonThuoc();
            ctdt.MdiParent = this;
            ctdt.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblPhong phong = new tblPhong();
            phong.MdiParent = this;
            phong.Show();
        }
    }
}
