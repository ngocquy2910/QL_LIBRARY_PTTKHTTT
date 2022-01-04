using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_LIBRARY_PTTKHTTT
{
    public partial class QL_Sach : Form
    {

        public QL_Sach()
        {
            InitializeComponent();
        }
        string TenNguoiDung;
        string MatKhau;
        string VaiTro;
        int NDID;
        public QL_Sach(string TND, string Mk, String VT, int ID) : this()
        {
            TenNguoiDung = TND;
            MatKhau = Mk; VaiTro = VT; NDID = ID;
        }
        public void HienThiSach(string text)
        {
            string query = "SELECT  s.SachID, " +
                "s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.TacGia, s.GiaTien, s.SoLuong, s.NgayCapNhat, s.SoLuongCon  FROM sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
                "WHERE s.LoaiSach = ls.LoaiSachID AND s.NgonNgu = nn.NgonNguID AND s.NXB = nxb.NXBID "+text+" ";
            DBQL_ThuVien.HienThiDB(query, dgvQLSach);
        }

        private void QL_Sach_Shown(object sender, EventArgs e)
        {
            string text = "";
            lbTenADMIN.Text += TenNguoiDung;
            HienThiSach(text);
            LayLoaiSach(); LayNgonNgu(); LayNXB();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemMoiSach TMS = new ThemMoiSach(this);
            TMS.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you want to Update Book ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string text = "";
                int vt = dgvQLSach.CurrentRow.Index;
                DataGridViewRow dongchon = dgvQLSach.Rows[vt];
                string id = dongchon.Cells[0].Value.ToString();
                string tensach = txtTenSach.Text;
                string tacgia = txtTacGia.Text;
                string giaban = txtGiaBan.Text;
               
                string ngaynhap = txtNgayNhap.Text;
                int sl = int.Parse(txtSoLuong.Text);
                int loai = int.Parse(cbbTheLoai.SelectedValue.ToString());
                int nxb = int.Parse(cbbNXB.SelectedValue.ToString());
                int nn = int.Parse(cbbNgonNgu.SelectedValue.ToString());
                
                Sach book = new Sach(tensach,tacgia,loai,nn,nxb,ngaynhap,giaban,sl);
                DBQL_ThuVien.CapNhatSach(book, id);
                HienThiSach(text);
            }
        }

        private void dgvQLSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt == -1 || vt > dgvQLSach.Columns.Count)
            {
                MessageBox.Show("Vui long chon dung dong......", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridViewRow dongchon = this.dgvQLSach.Rows[vt];
                txtMaSach.Text = dongchon.Cells[0].Value.ToString();
                txtTenSach.Text = dongchon.Cells[1].Value.ToString();
                cbbTheLoai.Text = dongchon.Cells[2].Value.ToString();
                cbbNXB.Text = dongchon.Cells[3].Value.ToString();
                cbbNgonNgu.Text = dongchon.Cells[4].Value.ToString();
                txtTacGia.Text = dongchon.Cells[5].Value.ToString();
                txtGiaBan.Text = dongchon.Cells[6].Value.ToString();
                txtSoLuong.Text = dongchon.Cells[7].Value.ToString();
                txtNgayNhap.Text = dongchon.Cells[8].Value.ToString();
                txtSLCon.Text = dongchon.Cells[9].Value.ToString();
            }

        }
        public void LayLoaiSach()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM loaisach", "LoaiSachID", "TenLoaiSach", cbbTheLoai);
        }
        public void LayNXB()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM nhaxuatban", "NXBID", "TenNXB", cbbNXB);
        }
        public void LayNgonNgu()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM ngonngu", "NgonNguID", "TenNgonNgu", cbbNgonNgu);
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            string text = "";
            if (MessageBox.Show("are you want to delete book record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int vt = dgvQLSach
                    .CurrentRow.Index;
                DataGridViewRow dongchon = dgvQLSach.Rows[vt];

                string id = (dongchon.Cells[0].Value.ToString());
                DBQL_ThuVien.XoaSach(id);
                HienThiSach(text);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemSachCT TKSCT = new TimKiemSachCT();
            TKSCT.Show();
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            QLDocGia QLDG = new QLDocGia(TenNguoiDung,MatKhau,VaiTro,NDID);
         
            if (MessageBox.Show("Neu ban chuyen trang, trang hien tai sẽ dong.", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QLDG.Show();
                this.Visible = false;
            }
        }

        private void btnThayDoiThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            string text = "TDTTND";
            ThayDoiThongTinDocGia TDTTND = new ThayDoiThongTinDocGia(text,NDID,TenNguoiDung,MatKhau,VaiTro);
            TDTTND.Show();
        }

        private void btnQuanLyTraMuon_Click(object sender, EventArgs e)
        {
            QuanLyMuonTra QLMT = new QuanLyMuonTra(TenNguoiDung, MatKhau, VaiTro, NDID);
           
            if (MessageBox.Show("Neu ban chuyen trang, trang hien tai sẽ dong.", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QLMT.Show();
                this.Visible = false;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            ThongKe TK = new ThongKe(TenNguoiDung, MatKhau, VaiTro, NDID);

            if (MessageBox.Show("Neu ban chuyen trang, trang hien tai sẽ dong.", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TK.Show();
                this.Visible = false;
            }
        }

        private void btnPhanLoai_Click(object sender, EventArgs e)
        {
            TimKiemSachCT TKSCT = new TimKiemSachCT();
            TKSCT.Show();
        }
    }
}
