
namespace QL_LIBRARY_PTTKHTTT
{
    partial class DanhSachPMDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachPMDG));
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDSPMXN = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXacNhanTraSach = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuanLyTraMuon = new System.Windows.Forms.Button();
            this.btnQuanLyDocGia = new System.Windows.Forms.Button();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnTrolai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThayDoiThongTinTaiKhoan = new System.Windows.Forms.Button();
            this.lbTenADMIN = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaPMSach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoXacNhanTraSach = new System.Windows.Forms.RadioButton();
            this.rdoTuChoi = new System.Windows.Forms.RadioButton();
            this.rdoXacNhan = new System.Windows.Forms.RadioButton();
            this.txtNgayMuon = new System.Windows.Forms.TextBox();
            this.txtNgayHenTra = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhieuMuonID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPMXN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dgvDSPMXN);
            this.panel4.Location = new System.Drawing.Point(20, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 165);
            this.panel4.TabIndex = 7;
            // 
            // dgvDSPMXN
            // 
            this.dgvDSPMXN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSPMXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPMXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPMXN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDSPMXN.Location = new System.Drawing.Point(3, 3);
            this.dgvDSPMXN.Name = "dgvDSPMXN";
            this.dgvDSPMXN.RowHeadersWidth = 51;
            this.dgvDSPMXN.Size = new System.Drawing.Size(527, 162);
            this.dgvDSPMXN.TabIndex = 0;
            this.dgvDSPMXN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPMXN_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PhieuMuonXNID";
            this.Column1.HeaderText = "ID phiếu mượn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenDocGia";
            this.Column3.HeaderText = "Tên độc giả";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayMuon";
            this.Column4.HeaderText = "Ngày mượn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayHenTra";
            this.Column5.HeaderText = "Ngày hẹn trả";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuongMuon";
            this.Column6.HeaderText = "Số lượng mượn";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TinhTrang";
            this.Column7.HeaderText = "Tình trạng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SachID";
            this.Column8.HeaderText = "SachID";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SoLuongCon";
            this.Column9.HeaderText = "SoLuongCon";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // btnXacNhanTraSach
            // 
            this.btnXacNhanTraSach.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhanTraSach.Image")));
            this.btnXacNhanTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhanTraSach.Location = new System.Drawing.Point(94, 299);
            this.btnXacNhanTraSach.Name = "btnXacNhanTraSach";
            this.btnXacNhanTraSach.Size = new System.Drawing.Size(91, 38);
            this.btnXacNhanTraSach.TabIndex = 3;
            this.btnXacNhanTraSach.Text = "Xác nhận ";
            this.btnXacNhanTraSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhanTraSach.UseVisualStyleBackColor = true;
            this.btnXacNhanTraSach.Click += new System.EventHandler(this.btnXacNhanTraSach_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnQuanLyTraMuon);
            this.panel1.Controls.Add(this.btnQuanLyDocGia);
            this.panel1.Controls.Add(this.btnQuanLySach);
            this.panel1.Controls.Add(this.btnTrolai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThayDoiThongTinTaiKhoan);
            this.panel1.Controls.Add(this.lbTenADMIN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 500);
            this.panel1.TabIndex = 3;
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSize = true;
            this.btnThongKe.Location = new System.Drawing.Point(28, 336);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(168, 27);
            this.btnThongKe.TabIndex = 13;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyTraMuon
            // 
            this.btnQuanLyTraMuon.AutoSize = true;
            this.btnQuanLyTraMuon.Location = new System.Drawing.Point(28, 280);
            this.btnQuanLyTraMuon.Name = "btnQuanLyTraMuon";
            this.btnQuanLyTraMuon.Size = new System.Drawing.Size(168, 27);
            this.btnQuanLyTraMuon.TabIndex = 12;
            this.btnQuanLyTraMuon.Text = "Quản lý mượn trả";
            this.btnQuanLyTraMuon.UseVisualStyleBackColor = true;
            this.btnQuanLyTraMuon.Click += new System.EventHandler(this.btnQuanLyTraMuon_Click);
            // 
            // btnQuanLyDocGia
            // 
            this.btnQuanLyDocGia.AutoSize = true;
            this.btnQuanLyDocGia.Location = new System.Drawing.Point(30, 224);
            this.btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            this.btnQuanLyDocGia.Size = new System.Drawing.Size(168, 27);
            this.btnQuanLyDocGia.TabIndex = 11;
            this.btnQuanLyDocGia.Text = "Quản lý độc giả";
            this.btnQuanLyDocGia.UseVisualStyleBackColor = true;
            this.btnQuanLyDocGia.Click += new System.EventHandler(this.btnQuanLyDocGia_Click);
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.AutoSize = true;
            this.btnQuanLySach.Location = new System.Drawing.Point(28, 168);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Size = new System.Drawing.Size(168, 27);
            this.btnQuanLySach.TabIndex = 10;
            this.btnQuanLySach.Text = "Qản lý sách";
            this.btnQuanLySach.UseVisualStyleBackColor = true;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);
            // 
            // btnTrolai
            // 
            this.btnTrolai.AutoSize = true;
            this.btnTrolai.BackColor = System.Drawing.Color.Red;
            this.btnTrolai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrolai.Location = new System.Drawing.Point(25, 438);
            this.btnTrolai.Name = "btnTrolai";
            this.btnTrolai.Size = new System.Drawing.Size(168, 27);
            this.btnTrolai.TabIndex = 9;
            this.btnTrolai.Text = "Trở lại";
            this.btnTrolai.UseVisualStyleBackColor = false;
            this.btnTrolai.Click += new System.EventHandler(this.btnTrolai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(39, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "____________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "____________________";
            // 
            // btnThayDoiThongTinTaiKhoan
            // 
            this.btnThayDoiThongTinTaiKhoan.AutoSize = true;
            this.btnThayDoiThongTinTaiKhoan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThayDoiThongTinTaiKhoan.Location = new System.Drawing.Point(28, 73);
            this.btnThayDoiThongTinTaiKhoan.Name = "btnThayDoiThongTinTaiKhoan";
            this.btnThayDoiThongTinTaiKhoan.Size = new System.Drawing.Size(187, 27);
            this.btnThayDoiThongTinTaiKhoan.TabIndex = 1;
            this.btnThayDoiThongTinTaiKhoan.Text = "Thay đổi thông tin cá nhân";
            this.btnThayDoiThongTinTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThayDoiThongTinTaiKhoan.Click += new System.EventHandler(this.btnThayDoiThongTinTaiKhoan_Click);
            // 
            // lbTenADMIN
            // 
            this.lbTenADMIN.AutoSize = true;
            this.lbTenADMIN.BackColor = System.Drawing.Color.Transparent;
            this.lbTenADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenADMIN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTenADMIN.Location = new System.Drawing.Point(12, 22);
            this.lbTenADMIN.Name = "lbTenADMIN";
            this.lbTenADMIN.Size = new System.Drawing.Size(87, 18);
            this.lbTenADMIN.TabIndex = 0;
            this.lbTenADMIN.Text = "Xin Chào: ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnXoaPMSach);
            this.panel2.Controls.Add(this.btnXacNhanTraSach);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(235, -24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 524);
            this.panel2.TabIndex = 4;
            // 
            // btnXoaPMSach
            // 
            this.btnXoaPMSach.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPMSach.Image")));
            this.btnXoaPMSach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPMSach.Location = new System.Drawing.Point(334, 301);
            this.btnXoaPMSach.Name = "btnXoaPMSach";
            this.btnXoaPMSach.Size = new System.Drawing.Size(138, 38);
            this.btnXoaPMSach.TabIndex = 6;
            this.btnXoaPMSach.Text = "Hủy phiếu mượn sách";
            this.btnXoaPMSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPMSach.UseVisualStyleBackColor = true;
            this.btnXoaPMSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(150, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh sách thông tin phiếu mượn";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.rdoXacNhanTraSach);
            this.panel3.Controls.Add(this.rdoTuChoi);
            this.panel3.Controls.Add(this.rdoXacNhan);
            this.panel3.Controls.Add(this.txtNgayMuon);
            this.panel3.Controls.Add(this.txtNgayHenTra);
            this.panel3.Controls.Add(this.txtTenDocGia);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.txtTinhTrang);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTenSach);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtPhieuMuonID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(20, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 232);
            this.panel3.TabIndex = 0;
            // 
            // rdoXacNhanTraSach
            // 
            this.rdoXacNhanTraSach.AutoSize = true;
            this.rdoXacNhanTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoXacNhanTraSach.Location = new System.Drawing.Point(327, 202);
            this.rdoXacNhanTraSach.Name = "rdoXacNhanTraSach";
            this.rdoXacNhanTraSach.Size = new System.Drawing.Size(129, 17);
            this.rdoXacNhanTraSach.TabIndex = 22;
            this.rdoXacNhanTraSach.TabStop = true;
            this.rdoXacNhanTraSach.Text = "Xác nhận trả sách";
            this.rdoXacNhanTraSach.UseVisualStyleBackColor = true;
            // 
            // rdoTuChoi
            // 
            this.rdoTuChoi.AutoSize = true;
            this.rdoTuChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTuChoi.Location = new System.Drawing.Point(327, 172);
            this.rdoTuChoi.Name = "rdoTuChoi";
            this.rdoTuChoi.Size = new System.Drawing.Size(127, 17);
            this.rdoTuChoi.TabIndex = 21;
            this.rdoTuChoi.TabStop = true;
            this.rdoTuChoi.Text = "Từ chối cho mượn";
            this.rdoTuChoi.UseVisualStyleBackColor = true;
            // 
            // rdoXacNhan
            // 
            this.rdoXacNhan.AutoSize = true;
            this.rdoXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoXacNhan.Location = new System.Drawing.Point(327, 140);
            this.rdoXacNhan.Name = "rdoXacNhan";
            this.rdoXacNhan.Size = new System.Drawing.Size(138, 17);
            this.rdoXacNhan.TabIndex = 20;
            this.rdoXacNhan.TabStop = true;
            this.rdoXacNhan.Text = "Xác nhận cho mượn";
            this.rdoXacNhan.UseVisualStyleBackColor = true;
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.Location = new System.Drawing.Point(326, 25);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Size = new System.Drawing.Size(169, 20);
            this.txtNgayMuon.TabIndex = 19;
            // 
            // txtNgayHenTra
            // 
            this.txtNgayHenTra.Location = new System.Drawing.Point(327, 64);
            this.txtNgayHenTra.Name = "txtNgayHenTra";
            this.txtNgayHenTra.Size = new System.Drawing.Size(169, 20);
            this.txtNgayHenTra.TabIndex = 18;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(80, 63);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(169, 20);
            this.txtTenDocGia.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên độc giả";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(327, 107);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(169, 20);
            this.txtSoLuong.TabIndex = 15;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(80, 156);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(169, 20);
            this.txtTinhTrang.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tinh trạng";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày hẹn trả";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Mượn:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(80, 111);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(169, 20);
            this.txtTenSach.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên Sách";
            // 
            // txtPhieuMuonID
            // 
            this.txtPhieuMuonID.Location = new System.Drawing.Point(80, 21);
            this.txtPhieuMuonID.Name = "txtPhieuMuonID";
            this.txtPhieuMuonID.Size = new System.Drawing.Size(169, 20);
            this.txtPhieuMuonID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Phiếu mượn";
            // 
            // DanhSachPMDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DanhSachPMDG";
            this.Text = "DanhSachPMDG";
            this.Shown += new System.EventHandler(this.DanhSachPMDG_Shown);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPMXN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDSPMXN;
        private System.Windows.Forms.Button btnXacNhanTraSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThayDoiThongTinTaiKhoan;
        private System.Windows.Forms.Label lbTenADMIN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaPMSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTrolai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNgayMuon;
        private System.Windows.Forms.TextBox txtNgayHenTra;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhieuMuonID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQuanLyTraMuon;
        private System.Windows.Forms.Button btnQuanLyDocGia;
        private System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.RadioButton rdoXacNhanTraSach;
        private System.Windows.Forms.RadioButton rdoTuChoi;
        private System.Windows.Forms.RadioButton rdoXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}