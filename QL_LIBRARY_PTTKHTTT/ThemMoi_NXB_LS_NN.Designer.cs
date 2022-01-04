
namespace QL_LIBRARY_PTTKHTTT
{
    partial class ThemMoi_NXB_LS_NN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuyTm = new System.Windows.Forms.Button();
            this.txtTMTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.btnXNTM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lbTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 113);
            this.panel1.TabIndex = 0;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTieuDe.Location = new System.Drawing.Point(12, 42);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(96, 20);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Thêm mới: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnHuyTm);
            this.panel2.Controls.Add(this.txtTMTen);
            this.panel2.Controls.Add(this.lbTen);
            this.panel2.Controls.Add(this.btnXNTM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 91);
            this.panel2.TabIndex = 1;
            // 
            // btnHuyTm
            // 
            this.btnHuyTm.BackColor = System.Drawing.Color.Red;
            this.btnHuyTm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHuyTm.Location = new System.Drawing.Point(286, 42);
            this.btnHuyTm.Name = "btnHuyTm";
            this.btnHuyTm.Size = new System.Drawing.Size(51, 23);
            this.btnHuyTm.TabIndex = 20;
            this.btnHuyTm.Text = "Hủy";
            this.btnHuyTm.UseVisualStyleBackColor = false;
            this.btnHuyTm.Click += new System.EventHandler(this.btnHuyTm_Click);
            // 
            // txtTMTen
            // 
            this.txtTMTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTMTen.Location = new System.Drawing.Point(12, 42);
            this.txtTMTen.Name = "txtTMTen";
            this.txtTMTen.Size = new System.Drawing.Size(199, 20);
            this.txtTMTen.TabIndex = 19;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTen.Location = new System.Drawing.Point(9, 26);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(54, 13);
            this.lbTen.TabIndex = 18;
            this.lbTen.Text = "Tên NXB:";
            // 
            // btnXNTM
            // 
            this.btnXNTM.BackColor = System.Drawing.Color.SpringGreen;
            this.btnXNTM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXNTM.Location = new System.Drawing.Point(217, 42);
            this.btnXNTM.Name = "btnXNTM";
            this.btnXNTM.Size = new System.Drawing.Size(61, 23);
            this.btnXNTM.TabIndex = 17;
            this.btnXNTM.Text = "Xác nhận";
            this.btnXNTM.UseVisualStyleBackColor = false;
            this.btnXNTM.Click += new System.EventHandler(this.btnXNTM_Click);
            // 
            // ThemMoi_NXB_LS_NN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 204);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThemMoi_NXB_LS_NN";
            this.Text = "ThemMoi_NXB_LS_NN";
            this.Load += new System.EventHandler(this.ThemMoi_NXB_LS_NN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuyTm;
        private System.Windows.Forms.TextBox txtTMTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Button btnXNTM;
    }
}