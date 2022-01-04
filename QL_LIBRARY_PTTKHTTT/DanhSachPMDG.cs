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
    public partial class DanhSachPMDG : Form
    {
        public DanhSachPMDG()
        {
            InitializeComponent();
        }
      
        int PMID = 0; string TDG; string Tensach;
        int PMXNID = 0;
        string IDDGFRQLDG;
        string txt;
        int SID = 0; int SLC = 0; int SLCM = 0;
        public void HienThiPMXN()
        {
            if(txt == "PMDGFROMQLDG")
            {
                HienThiFromQLDG();
                string query = " SELECT pmxn.PhieuMuonXNID, s.TenSach, dg.TenDocGia, pmxn.NgayMuon, pmxn.NgayHenTra, pmxn.SoLuongMuon, pmxn.TinhTrang, s.SachID, s.SoLuongCon " +
                         " FROM phieumuonxn as pmxn, docgia as dg, sach as s " +
                         " Where pmxn.Sach = s.SachID AND pmxn.DocGia = dg.DocGiaID AND pmxn.DocGia = " + IDDGFRQLDG + "";
                DBQL_ThuVien.HienThiDB(query, dgvDSPMXN);
            }
            else
            {
                HienThiFromDG();
                string query = " SELECT pmxn.PhieuMuonXNID, s.TenSach, dg.TenDocGia, pmxn.NgayMuon, pmxn.NgayHenTra, pmxn.SoLuongMuon, pmxn.TinhTrang, s.SachID, s.SoLuongCon " +
                           " FROM phieumuonxn as pmxn, docgia as dg, sach as s " +
                           " Where pmxn.Sach = s.SachID AND pmxn.DocGia = dg.DocGiaID AND pmxn.DocGia = " + DocGiaID + "";
                DBQL_ThuVien.HienThiDB(query, dgvDSPMXN);
            }
                 
           
        }

        private void DanhSachPMDG_Shown(object sender, EventArgs e)
        {
            if(txt == "PMDGFROMQLDG")
            {
                lbTenADMIN.Text += TenNguoiDung;
            }else
            {
                lbTenADMIN.Text += TenDocGia;
            }
            HienThiPMXN();
        }
    
     
        string TinhTrang = "";

        private void dgvDSPMXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt == -1 || vt > dgvDSPMXN.Columns.Count )
            {
                MessageBox.Show("Vui long chon dung dong!!!", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }else
            {
                DataGridViewRow dongchon = this.dgvDSPMXN.Rows[vt];
                txtPhieuMuonID.Text = dongchon.Cells[0].Value.ToString();
                txtTenSach.Text = dongchon.Cells[1].Value.ToString();
                txtTenDocGia.Text = dongchon.Cells[2].Value.ToString();
                txtNgayMuon.Text = dongchon.Cells[3].Value.ToString();
                txtNgayHenTra.Text = dongchon.Cells[4].Value.ToString();
                txtSoLuong.Text = dongchon.Cells[5].Value.ToString();
                txtTinhTrang.Text = dongchon.Cells[6].Value.ToString();
                PMID = int.Parse(dongchon.Cells[0].Value.ToString());
                PMXNID = int.Parse(dongchon.Cells[0].Value.ToString());
                TinhTrang = dongchon.Cells[6].Value.ToString();
                SID = int.Parse(dongchon.Cells[7].Value.ToString());
                SLC = int.Parse(dongchon.Cells[8].Value.ToString());
                TDG = dongchon.Cells[2].Value.ToString();
                Tensach = dongchon.Cells[1].Value.ToString();
            }
                     
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
         
                if (TinhTrang != "Đã xác nhận mượn sách" || TinhTrang != "Đã xác nhận trả sách")
                {
                    MessageBox.Show("Ban da xoa phieu muon sach thanh cong","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    DBQL_ThuVien.XoaPhieuTamThoi(PMID);
                    HienThiPMXN();
                }
                else
                {
                    MessageBox.Show("Ban chi co the xoa phieu muon khi da tra sach hoac phieu muon khong duoc chap thuan!", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
           
            
        }

        private void btnXacNhanTraSach_Click(object sender, EventArgs e)
        {
            if (txt == "PMDGFROMQLDG")
            {
                if (rdoXacNhan.Checked)
                {
                    int SLHT = SLC - SLCM;
                    if (TinhTrang == "Đang đợi xác nhận cho mượn sách")
                    {
                        TinhTrang = "Đã xác nhận mượn sách";
                        PhieuMuonTamThoi PMTTTT = new PhieuMuonTamThoi(TinhTrang);
                        DBQL_ThuVien.CapNhatPhieu(PMTTTT, PMID);
                        DBQL_ThuVien.CapNhatSoLuongSach(SID, SLHT);
                        HienThiPMXN();
                        MessageBox.Show("Ban dao cho " + TDG + " Muon sach: " + Tensach);
                    }
                    else
                    {
                        MessageBox.Show("Ban chi co the cho doc gia muon sach khi Tinh trang la: " + TinhTrang + " ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                if (rdoTuChoi.Checked)
                {

                    if (TinhTrang == "Đang đợi xác nhận cho mượn sách")
                    {
                        TinhTrang = "Phiếu mươn không được chấp nhận";
                        PhieuMuonTamThoi PMTTTT = new PhieuMuonTamThoi(TinhTrang);
                        DBQL_ThuVien.CapNhatPhieu(PMTTTT, PMID);
                        HienThiPMXN();
                        MessageBox.Show("Đã từ chối phiếu mượn sách của: " + TDG + "");
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
                        HienThiPMXN();
                        MessageBox.Show("Ban da dong y yeu cau tra sach cua: " + TDG + " ten sach la: " + Tensach);
                    }
                    else
                    {
                        MessageBox.Show("Ban chi co the dong y tra  sach khi Tinh trang la: " + TinhTrang + " ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (rdoXacNhanTraSach.Checked)
                {
                    if(TinhTrang == "Đã xác nhận mượn sách")
                    {
                        TinhTrang = "Đã xác nhận trả sách";
                        PhieuMuonTamThoi PMTTTT = new PhieuMuonTamThoi(TinhTrang);
                        DBQL_ThuVien.CapNhatPhieu(PMTTTT, PMID);
                        HienThiPMXN();
                        MessageBox.Show("Ban da xac nhan tra sach");
                    }
                   
                }
            }
               
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon tro lai!", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }
        public void HienThiFromQLDG ()
        {
            rdoXacNhanTraSach.Visible = true;
            rdoXacNhan.Visible = true;
            rdoTuChoi.Visible = true;
            btnQuanLyDocGia.Visible = true;
            btnQuanLySach.Visible = true;
            btnQuanLyTraMuon.Visible = true;
            btnThongKe.Visible = true;
            btnXacNhanTraSach.Text = "Xác Nhận.";
            
        }

        public void HienThiFromDG()
        {
            rdoXacNhanTraSach.Visible = true;
            rdoXacNhan.Visible = false;
            rdoTuChoi.Visible = false;
            btnQuanLyDocGia.Visible = false;
            btnQuanLySach.Visible = false;
            btnQuanLyTraMuon.Visible = false;
            btnThongKe.Visible = false;
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            QL_Sach QLS = new QL_Sach();
            QLS.Show();
            this.Visible = false;
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            QLDocGia QLDG = new QLDocGia();
            QLDG.Show();
            this.Visible = false;
        }

        private void btnQuanLyTraMuon_Click(object sender, EventArgs e)
        {
            QuanLyMuonTra QLMT = new QuanLyMuonTra();
            QLMT.Show();
            this.Visible = false;
        }
        int DocGiaID = 0;
        string TenDocGia; string CMND; string DiaChi; string SDT;
        public int SachID;
        public int vt;
        public DanhSachPMDG(string str, int id, string cmnd, string std, string dc) : this()
        {
            TenDocGia = str;
            DocGiaID = int.Parse(id.ToString());
            lbTenADMIN.Text += TenDocGia;
            CMND = cmnd; DiaChi = dc; SDT = std;
        }

        private void btnThayDoiThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            if(txt == "PMDGFROMQLDG")
            {
                ThayDoiThongTinDocGia TDTTND = new ThayDoiThongTinDocGia(txt,NDID,TenNguoiDung,MatKhau,VaiTro);
                TDTTND.Show();
            }
            else
            {
                ThayDoiThongTinDocGia TDTTDG = new ThayDoiThongTinDocGia(DocGiaID, TenDocGia, CMND, SDT, DiaChi);
                TDTTDG.Show();
            }
          
        }
        string TenNguoiDung;
        string MatKhau;
        string VaiTro;
        int NDID;
        public DanhSachPMDG(string text,string IDDG, string TND, string MK, string VT, int ID) : this()
        {
            txt = text;
            IDDGFRQLDG = IDDG;
            TenNguoiDung = TND;
            MatKhau = MK; VaiTro = VT; NDID = ID;
        }

    }
}
