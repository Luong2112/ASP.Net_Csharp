
namespace BTL
{
    partial class BC_benhnhan
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
            this.rptBN_DT1 = new BTL.rptBN_DT();
            this.crtBN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtBN
            // 
            this.crtBN.ActiveViewIndex = -1;
            this.crtBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtBN.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtBN.Location = new System.Drawing.Point(0, 0);
            this.crtBN.Name = "crtBN";
            this.crtBN.Size = new System.Drawing.Size(929, 586);
            this.crtBN.TabIndex = 0;
            this.crtBN.Load += new System.EventHandler(this.crtBN_Load);
            // 
            // BC_benhnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 586);
            this.Controls.Add(this.crtBN);
            this.Name = "BC_benhnhan";
            this.Text = "Báo cáo Bệnh Nhân";
            this.Load += new System.EventHandler(this.BC_benhnhan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private rptBN_DT rptBN_DT1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crtBN;
    }
}