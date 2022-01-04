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
    public partial class QuanLyMuonTra : Form
    {
        public QuanLyMuonTra()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
       
                this.Visible = false;
        }

      
        public void HienThiPMXN(string text)
        {
            string query = " SELECT pmxn.PhieuMuonXNID, s.TenSach, dg.TenDocGia, pmxn.NgayMuon, pmxn.NgayHenTra, pmxn.SoLuongMuon, pmxn.TinhTrang , s.SachID, s.SoLuongCon, pmxn.DocGia" +
                           " FROM phieumuonxn as pmxn, docgia as dg, sach as s " +
                           " Where pmxn.Sach = s.SachID AND pmxn.DocGia = dg.DocGiaID "+text+" ";

            DBQL_ThuVien.HienThiDB(query, dgvQLMuonTra);
        }
        int PMID = 0;
        string TenDocGia = "";
        string TenSach = "";
        int SLCM = 0;
        int SLC = 0; int SID = 0;
        string NM; string NHT;
        string TinhTrang = "";
        int DocGiaID = 0;
        private void dgvQLMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int vt = e.RowIndex;
            if(vt !=-1|| vt <= dgvQLMuonTra.Rows.Count)
            {
                DataGridViewRow dongchon = this.dgvQLMuonTra.Rows[vt];
                txtPhieuMuonID.Text = dongchon.Cells[0].Value.ToString();
                txtTenSach.Text = dongchon.Cells[1].Value.ToString();
                txtTenDocGia.Text = dongchon.Cells[2].Value.ToString();
                txtNgayMuon.Text = dongchon.Cells[3].Value.ToString();
                txtNgayHenTra.Text = dongchon.Cells[4].Value.ToString();
                txtSoLuong.Text = dongchon.Cells[5].Value.ToString();
                txtTinhTrang.Text = dongchon.Cells[6].Value.ToString();
                SLCM = int.Parse(dongchon.Cells[5].Value.ToString());
                SID = int.Parse(dongchon.Cells[7].Value.ToString());
                SLC = int.Parse(dongchon.Cells[8].Value.ToString());
                PMID = int.Parse(dongchon.Cells[0].Value.ToString());
                TinhTrang = dongchon.Cells[6].Value.ToString();
                NM = dongchon.Cells[3].Value.ToString();
                NHT = dongchon.Cells[4].Value.ToString();
                DocGiaID = int.Parse(dongchon.Cells[9].Value.ToString());
            }
          
        }
        string T = "";
        private void QuanLyMuonTra_Shown(object sender, EventArgs e)
        {
            HienThiPMXN(T);
            lbTenADMIN.Text += TenNguoiDung;
      
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if(rdoDongYChoMuon.Checked)
            {
                if(SLC <= 0|| SLCM > SLC)
                {
                    MessageBox.Show("So lương sach khong du!","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                }
                else
                {
                    int SLHT = SLC - SLCM;
                    if (TinhTrang == "Đang đợi xác nhận cho mượn sách")
                    {
                        TinhTrang = "Đã xác nhận mượn sách";
                        PhieuMuonTamThoi PMTTTT = new PhieuMuonTamThoi(TinhTrang);
                        DBQL_ThuVien.CapNhatPhieu(PMTTTT, PMID);
                        DBQL_ThuVien.CapNhatSoLuongSach(SID, SLHT);
                        PhieuMuonTamThoi PM = new PhieuMuonTamThoi(SID, DocGiaID, NM, NHT, SLCM);
                        DBQL_ThuVien.TaoPhieuMuon(PM);
                        HienThiPMXN(T);

                        MessageBox.Show("Ban dao cho " + TenDocGia + " Muon sach: " + TenSach);
                    }
                    else
                    {
                        MessageBox.Show("Ban chi co the cho doc gia muon sach khi Tinh trang la: " + TinhTrang + " ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
              
               
            }

            if (rdoKhongDongYChoMuon.Checked)
            {
             
                if (TinhTrang == "Đang đợi xác nhận cho mượn sách")
                {
                    TinhTrang = "Phiếu mươn không được chấp nhận";
                    PhieuMuonTamThoi PMTTTT = new PhieuMuonTamThoi(TinhTrang);
                    DBQL_ThuVien.CapNhatPhieu(PMTTTT, PMID);
                    HienThiPMXN(T);
                    MessageBox.Show("Đã từ chối phiếu mượn sách của: "+TenDocGia+"");
                }
                else
                {
                    MessageBox.Show("Ban chi co the tu choi muon sach khi Tinh trang la: " + TinhTrang + " ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rdoXacNhanTraSach.Checked)
            {
                int SLHT = SLC + SLCM;
                if (TinhTrang == "Đã xác nhận trả sách")
                {
                    TinhTrang = "Sách đã được trả thành công";
                    PhieuMuonTamThoi PMTTTT = new PhieuMuonTamThoi(TinhTrang);
                    DBQL_ThuVien.CapNhatPhieu(PMTTTT, PMID);
                    DBQL_ThuVien.CapNhatSoLuongSach(SID, SLHT);
                    HienThiPMXN(T);
                    MessageBox.Show("Ban da dong y yeu cau tra sach cua: " + TenDocGia + " ten sach la: " + TenSach);
                }
                else
                {
                    MessageBox.Show("Ban chi co the dong y tra  sach khi Tinh trang la: " + TinhTrang + " ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(rdoXoaPM.Checked)
            {

                if (TinhTrang != "Đã xác nhận mượn sách" || TinhTrang != "Đã xác nhận trả sách")
                {
                    MessageBox.Show("Ban da xoa phieu muon sach thanh cong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    DBQL_ThuVien.XoaPhieuTamThoi(PMID);
                    HienThiPMXN(T);
                }
                else
                {
                    MessageBox.Show("Ban chi co the xoa phieu muon khi da tra sach hoac phieu muon khong duoc chap thuan!", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }

        }

        string TenNguoiDung;
        string MatKhau;
        string VaiTro;
        int NDID;
        public QuanLyMuonTra(string TND, string Mk, String VT, int ID) : this()
        {
            TenNguoiDung = TND;
            MatKhau = Mk; VaiTro = VT; NDID = ID;
        }

        private void btnThayDoiThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            string text = "TDTTND";
            ThayDoiThongTinDocGia TDTTND = new ThayDoiThongTinDocGia(text, NDID, TenNguoiDung, MatKhau, VaiTro);         
                TDTTND.Show();
            
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

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            QLDocGia QLDG = new QLDocGia(TenNguoiDung, MatKhau, VaiTro, NDID);

            if (MessageBox.Show("Neu ban chuyen trang, trang hien tai sẽ dong.", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QLDG.Show();
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

        private void btTaoPhieuMuon_Click(object sender, EventArgs e)
        {
       
                ReportPMDG RPPM = new ReportPMDG(PMID);
                RPPM.Show();
        
           
        }

        private void cbbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoc.Text =="Hiển thị tất cả")
            {
                HienThiPMXN(T);
            }
            if (cbbLoc.Text == "Hiển thị phiếu mượn đã xác nhận mượn sách")
            {
                T = "AND pmxn.TinhTrang = N'Đã xác nhận mượn sách'";
                HienThiPMXN(T);

            }
            if (cbbLoc.Text == "Hiển thị phiếu mướn đợi xác nhận trả sách")
            {
                T = "AND pmxn.TinhTrang = N'Đã xác nhận trả sách'";
                HienThiPMXN(T);
            }
            if (cbbLoc.Text == "Hiển thị phiếu mượn bị từ chối")
            {
                T = "AND pmxn.TinhTrang = N'Phiếu mươn không được chấp nhận'";
                HienThiPMXN(T);
            }

            if(cbbLoc.Text == "Hiển thị phiếu mượn đợi xác nhận mượn sách")
            {
                T = "AND pmxn.TinhTrang = N'Đang đợi xác nhận cho mượn sách'";
                HienThiPMXN(T);
            }
        }
        public void khoaTaoPhieuMuon()
        {
            btTaoPhieuMuon.Enabled = false;
        }
        public void MoTaoPhieuMuon()
        {
            btTaoPhieuMuon.Enabled = true;
        }

        private void QuanLyMuonTra_Load(object sender, EventArgs e)
        {
            
        }
    }
}
