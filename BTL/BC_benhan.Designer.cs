
namespace BTL
{
    partial class BC_benhan
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
            this.crtBN_BA = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtBN_BA
            // 
            this.crtBN_BA.ActiveViewIndex = -1;
            this.crtBN_BA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtBN_BA.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtBN_BA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtBN_BA.Location = new System.Drawing.Point(0, 0);
            this.crtBN_BA.Name = "crtBN_BA";
            this.crtBN_BA.Size = new System.Drawing.Size(800, 450);
            this.crtBN_BA.TabIndex = 0;
            // 
            // BC_benhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crtBN_BA);
            this.Name = "BC_benhan";
            this.Text = "Báo cáo Bệnh Án";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crtBN_BA;
    }
}