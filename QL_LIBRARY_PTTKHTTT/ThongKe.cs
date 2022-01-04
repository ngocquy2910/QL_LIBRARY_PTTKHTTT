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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Shown(object sender, EventArgs e)
        {
            HienThiThongKeLuotMuon();
            lbTenADMIN.Text += TenNguoiDung;
        }
        public void HienThiThongKeLuotMuon()
        {
            string query = "select s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat,  Sum(SoLuongMuon) AS N'Tổng lượt sách đã cho mượn' " +
                            " From phieumuon as pm, sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
                            " where pm.Sach = s.SachID AND s.LoaiSach = ls.LoaiSachID AND s.NXB = nxb.NXBID AND s.NgonNgu = nn.NgonNguID " +
                            " Group by s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB,  nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat";
            DBQL_ThuVien.HienThiDB(query,dgvThongKeLuotMuon);
        }

        private void dgvThongKeLuotMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int s = e.RowIndex;
            if (vt == -1|| vt < dgvThongKeLuotMuon.Columns.Count)
            {
                MessageBox.Show("Vui long chon dung dong......", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                DataGridViewRow dongchon = dgvThongKeLuotMuon.Rows[vt];
                txtMaSach.Text = dongchon.Cells[0].Value.ToString();
                txtTenSach.Text = dongchon.Cells[1].Value.ToString();
                txtTheLoai.Text = dongchon.Cells[2].Value.ToString();
                txtNhaXuatban.Text = dongchon.Cells[3].Value.ToString();
                txtNgonNgu.Text = dongchon.Cells[4].Value.ToString();
                txtGiaBan.Text = dongchon.Cells[5].Value.ToString();
                txtSoLuong.Text = dongchon.Cells[6].Value.ToString();
                txtSLCon.Text = dongchon.Cells[7].Value.ToString();
                txtNgayNhap.Text = dongchon.Cells[8].Value.ToString();
                txtSoLuongMuonSach.Text = dongchon.Cells[9].Value.ToString();
            }

           
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "";
            if (cbbLocPM.Text == "Tìm sách không được mượn")
            {
                 query = "select SachID, TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat " +
               " From phieumuon as pm, sach as s,  loaisach as ls, ngonngu as nn, nhaxuatban as nxb" +
               " where s.LoaiSach = ls.LoaiSachID AND s.NXB = nxb.NXBID AND s.NgonNgu = nn.NgonNguID" +
               " except" +
               " select Sach, s.TenSach,  ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat" +
               " From phieumuon, sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb" +
               " where  s.LoaiSach = ls.LoaiSachID AND s.NXB = nxb.NXBID AND s.NgonNgu = nn.NgonNguID ";
                
            }
            if(cbbLocPM.Text == "Xắp số lượng xếp tăng dần")
            {
                query = " select s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat,  Sum(SoLuongMuon) AS N'Tổng lượt sách đã cho mượn' " +
                    " From phieumuon as pm, sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
                    " where pm.Sach = s.SachID AND s.LoaiSach = ls.LoaiSachID AND s.NXB = nxb.NXBID AND s.NgonNgu = nn.NgonNguID " +
                    " Group by s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB,  nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat" +
                    " ORDER BY SoLuong ASC;";
            }

            if (cbbLocPM.Text == "Xắp số lượng xếp giảm dần")
            {
                query = " select s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat,  Sum(SoLuongMuon) AS N'Tổng lượt sách đã cho mượn' " +
                    " From phieumuon as pm, sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
                    " where pm.Sach = s.SachID AND s.LoaiSach = ls.LoaiSachID AND s.NXB = nxb.NXBID AND s.NgonNgu = nn.NgonNguID " +
                    " Group by s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB,  nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat" +
                    " ORDER BY SoLuong DESC;";
            }
            if(cbbLocPM.Text == "Thống kê")
            {
                query = "select s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon,s.NgayCapNhat,  Sum(SoLuongMuon) AS N'Tổng lượt sách đã cho mượn' " +
                            " From phieumuon as pm, sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
                            " where pm.Sach = s.SachID AND s.LoaiSach = ls.LoaiSachID AND s.NXB = nxb.NXBID AND s.NgonNgu = nn.NgonNguID " +
                            " Group by s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB,  nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat";
            }
            DBQL_ThuVien.HienThiDB(query, dgvThongKeLuotMuon);
        }
        string TenNguoiDung;
        string MatKhau;
        string VaiTro;
        int NDID;
        public ThongKe(string TND, string Mk, String VT, int ID) : this()
        {
            TenNguoiDung = TND;
            MatKhau = Mk; VaiTro = VT; NDID = ID;
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            QL_Sach SLS = new QL_Sach(TenNguoiDung, MatKhau, VaiTro, NDID);

            if (MessageBox.Show("Neu ban chuyen trang, trang hien tai sẽ dong.", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SLS.Show();
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

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            QLDocGia QLDG = new QLDocGia(TenNguoiDung, MatKhau, VaiTro, NDID);

            if (MessageBox.Show("Neu ban chuyen trang, trang hien tai sẽ dong.", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QLDG.Show();
                this.Visible = false;
            }
        }

        private void btnBieuDoLuotXem_Click(object sender, EventArgs e)
        {
            BieuDoPhieuMuon BDPM = new BieuDoPhieuMuon();
            BDPM.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string X=""; string Y="";
            string query = "";
    
            if(cbbBieudo.Text == "1. Biểu đồ số lượng mượn sách")
            {
               
                 X = "TenSach";
                 Y = "Tổng lượt sách đã cho mượn";
                   query = " select s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat,  Sum(SoLuongMuon) AS N'Tổng lượt sách đã cho mượn' " +
                   " From phieumuon as pm, sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
                   " where pm.Sach = s.SachID AND s.LoaiSach = ls.LoaiSachID AND s.NXB = nxb.NXBID AND s.NgonNgu = nn.NgonNguID " +
                   " Group by s.SachID, s.TenSach, ls.TenLoaiSach, nxb.TenNXB,  nn.TenNgonNgu, s.GiaTien, s.SoLuong, s.SoLuongCon, s.NgayCapNhat";        
            }
          
            if (cbbBieudo.Text == "2. Biểu đồ số lượng sách trong kho")
            {
               
                X = "TenSach";
                Y = "SoLuongCon";
                query = "SELECT * FROM sach";
            }
            BieuDoPhieuMuon BDPM = new BieuDoPhieuMuon(query,X,Y);
            BDPM.Show();
        }

        private void btnTKNXLLSNN_Click(object sender, EventArgs e)
        {
            QL_NXB_LS_NN NXBLSNN = new QL_NXB_LS_NN();
            NXBLSNN.Show();
        }

        private void btnPMQuaHan_Click(object sender, EventArgs e)
        {
            InDanhSachDocGiaTreHen IDSDGTh = new InDanhSachDocGiaTreHen();
            IDSDGTh.Show();
        }
    }
}
 