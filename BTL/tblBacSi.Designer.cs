
namespace BTL
{
    partial class tblBacSi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.dtNgS = new System.Windows.Forms.DateTimePicker();
            this.dtNVL = new System.Windows.Forms.DateTimePicker();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.cbChuyenKhoa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKt = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtwBS = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtwBS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label1.ForeColor = System.Drawing.SystemColors.GrayText;
            label1.Location = new System.Drawing.Point(42, 25);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 46);
            label1.TabIndex = 0;
            label1.Text = "BÁC SĨ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGioitinh);
            this.groupBox1.Controls.Add(this.dtNgS);
            this.groupBox1.Controls.Add(this.dtNVL);
            this.groupBox1.Controls.Add(this.txtPC);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.cbChuyenKhoa);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenBS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaBS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(209, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(983, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(163, 109);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(113, 33);
            this.cbGioitinh.TabIndex = 21;
            this.cbGioitinh.Text = "Nam";
            // 
            // dtNgS
            // 
            this.dtNgS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgS.Location = new System.Drawing.Point(163, 154);
            this.dtNgS.Name = "dtNgS";
            this.dtNgS.Size = new System.Drawing.Size(252, 30);
            this.dtNgS.TabIndex = 8;
            this.dtNgS.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // dtNVL
            // 
            this.dtNVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNVL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNVL.Location = new System.Drawing.Point(657, 113);
            this.dtNVL.Name = "dtNVL";
            this.dtNVL.Size = new System.Drawing.Size(250, 30);
            this.dtNVL.TabIndex = 8;
            this.dtNVL.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // txtPC
            // 
            this.txtPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPC.Location = new System.Drawing.Point(657, 203);
            this.txtPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(250, 30);
            this.txtPC.TabIndex = 20;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.Location = new System.Drawing.Point(657, 157);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(250, 30);
            this.txtLuong.TabIndex = 19;
            // 
            // cbChuyenKhoa
            // 
            this.cbChuyenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChuyenKhoa.FormattingEnabled = true;
            this.cbChuyenKhoa.Items.AddRange(new object[] {
            "Khoa Cấp Cứu",
            "Khoa Phổi",
            "Khoa Mắt",
            "Khoa Ngoại Tiết",
            "Khoa Da Liễu",
            "Khoa Nội Tiết",
            "Khoa Thần Kinh",
            "Khoa Sản",
            "Khoa Tim Mạch"});
            this.cbChuyenKhoa.Location = new System.Drawing.Point(657, 68);
            this.cbChuyenKhoa.Name = "cbChuyenKhoa";
            this.cbChuyenKhoa.Size = new System.Drawing.Size(250, 33);
            this.cbChuyenKhoa.TabIndex = 17;
            this.cbChuyenKhoa.Text = "Khoa Cấp Cứu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(537, 203);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Phụ cấp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(557, 157);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Lương";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(479, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ngày vào làm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(485, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Chuyên khoa";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDT.Location = new System.Drawing.Point(657, 20);
            this.txtDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDT.MaxLength = 10;
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(250, 30);
            this.txtDT.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(516, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Điện thoại";
            // 
            // txtDc
            // 
            this.txtDc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDc.Location = new System.Drawing.Point(163, 202);
            this.txtDc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDc.Name = "txtDc";
            this.txtDc.Size = new System.Drawing.Size(252, 30);
            this.txtDc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(45, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(17, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(35, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // txtTenBS
            // 
            this.txtTenBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenBS.Location = new System.Drawing.Point(163, 62);
            this.txtTenBS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(252, 30);
            this.txtTenBS.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và Tên";
            // 
            // txtMaBS
            // 
            this.txtMaBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBS.Location = new System.Drawing.Point(163, 20);
            this.txtMaBS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(252, 30);
            this.txtMaBS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Bác Sĩ";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(319, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 37);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(562, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 37);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(437, 35);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 37);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKt
            // 
            this.btnKt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKt.Location = new System.Drawing.Point(681, 35);
            this.btnKt.Name = "btnKt";
            this.btnKt.Size = new System.Drawing.Size(123, 37);
            this.btnKt.TabIndex = 5;
            this.btnKt.Text = "Khởi tạo";
            this.btnKt.UseVisualStyleBackColor = true;
            this.btnKt.Click += new System.EventHandler(this.btnKt_Click);
            // 
            // btnBC
            // 
            this.btnBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBC.Location = new System.Drawing.Point(825, 35);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(139, 37);
            this.btnBC.TabIndex = 6;
            this.btnBC.Text = "Báo cáo";
            this.btnBC.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtwBS);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(16, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1385, 367);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Bác Sĩ";
            // 
            // dtwBS
            // 
            this.dtwBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwBS.Location = new System.Drawing.Point(6, 26);
            this.dtwBS.Name = "dtwBS";
            this.dtwBS.RowHeadersWidth = 51;
            this.dtwBS.RowTemplate.Height = 24;
            this.dtwBS.Size = new System.Drawing.Size(1373, 341);
            this.dtwBS.TabIndex = 0;
            this.dtwBS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwBS_CellContentClick);
            // 
            // tblBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 751);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.btnKt);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tblBacSi";
            this.Text = "tblBacSi";
            this.Load += new System.EventHandler(this.tblBacSi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtwBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbChuyenKhoa;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnKt;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtwBS;
        private System.Windows.Forms.DateTimePicker dtNgS;
        private System.Windows.Forms.DateTimePicker dtNVL;
        private System.Windows.Forms.ComboBox cbGioitinh;
    }
}