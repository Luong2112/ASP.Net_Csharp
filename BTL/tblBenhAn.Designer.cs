
namespace BTL
{
    partial class tblBenhAn
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
            this.cbMabn = new System.Windows.Forms.ComboBox();
            this.cbMabs = new System.Windows.Forms.ComboBox();
            this.dtNgayHT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgLap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaBA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKt = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtwBA = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtwBA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label1.ForeColor = System.Drawing.SystemColors.GrayText;
            label1.Location = new System.Drawing.Point(13, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 38);
            label1.TabIndex = 2;
            label1.Text = "BỆNH ÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMabn);
            this.groupBox1.Controls.Add(this.cbMabs);
            this.groupBox1.Controls.Add(this.dtNgayHT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtNgLap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMaBA);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 239);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cbMabn
            // 
            this.cbMabn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMabn.FormattingEnabled = true;
            this.cbMabn.Location = new System.Drawing.Point(159, 96);
            this.cbMabn.Name = "cbMabn";
            this.cbMabn.Size = new System.Drawing.Size(229, 28);
            this.cbMabn.TabIndex = 18;
            // 
            // cbMabs
            // 
            this.cbMabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMabs.FormattingEnabled = true;
            this.cbMabs.Location = new System.Drawing.Point(159, 61);
            this.cbMabs.Name = "cbMabs";
            this.cbMabs.Size = new System.Drawing.Size(229, 28);
            this.cbMabs.TabIndex = 17;
            // 
            // dtNgayHT
            // 
            this.dtNgayHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayHT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHT.Location = new System.Drawing.Point(159, 173);
            this.dtNgayHT.Name = "dtNgayHT";
            this.dtNgayHT.Size = new System.Drawing.Size(229, 27);
            this.dtNgayHT.TabIndex = 16;
            this.dtNgayHT.Value = new System.DateTime(2022, 4, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày hoàn thành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Bệnh Nhân";
            // 
            // dtNgLap
            // 
            this.dtNgLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgLap.Location = new System.Drawing.Point(159, 136);
            this.dtNgLap.Name = "dtNgLap";
            this.dtNgLap.Size = new System.Drawing.Size(229, 27);
            this.dtNgLap.TabIndex = 8;
            this.dtNgLap.Value = new System.DateTime(2022, 4, 25, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(63, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày lập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(50, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã Bác Sĩ";
            // 
            // txtMaBA
            // 
            this.txtMaBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBA.Location = new System.Drawing.Point(159, 21);
            this.txtMaBA.Name = "txtMaBA";
            this.txtMaBA.Size = new System.Drawing.Size(229, 27);
            this.txtMaBA.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(36, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã Bệnh Án";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(487, 71);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 35);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(487, 139);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 35);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(487, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 35);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKt
            // 
            this.btnKt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKt.Location = new System.Drawing.Point(632, 100);
            this.btnKt.Name = "btnKt";
            this.btnKt.Size = new System.Drawing.Size(107, 35);
            this.btnKt.TabIndex = 11;
            this.btnKt.Text = "Khởi tạo";
            this.btnKt.UseVisualStyleBackColor = true;
            this.btnKt.Click += new System.EventHandler(this.btnKt_Click);
            // 
            // btnBC
            // 
            this.btnBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBC.Location = new System.Drawing.Point(632, 178);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(107, 35);
            this.btnBC.TabIndex = 12;
            this.btnBC.Text = "Báo cáo";
            this.btnBC.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtwBA);
            this.groupBox2.Location = new System.Drawing.Point(27, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 257);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Bệnh Án";
            // 
            // dtwBA
            // 
            this.dtwBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwBA.Location = new System.Drawing.Point(7, 21);
            this.dtwBA.Name = "dtwBA";
            this.dtwBA.RowHeadersWidth = 51;
            this.dtwBA.RowTemplate.Height = 24;
            this.dtwBA.Size = new System.Drawing.Size(699, 230);
            this.dtwBA.TabIndex = 0;
            this.dtwBA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwBN_CellContentClick);
            // 
            // tblBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.btnKt);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label1);
            this.Name = "tblBenhAn";
            this.Text = "tblBenhAn";
            this.Load += new System.EventHandler(this.tblBenhAn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtwBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaBA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMabn;
        private System.Windows.Forms.ComboBox cbMabs;
        private System.Windows.Forms.DateTimePicker dtNgayHT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKt;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtwBA;
    }
}