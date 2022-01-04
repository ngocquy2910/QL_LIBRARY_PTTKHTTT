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
    public partial class TaoPhieuMuonTamThoi : Form
    {
        private readonly Yersin_University_Library _parent;
        public TaoPhieuMuonTamThoi()
        {
            InitializeComponent();
        }
      
        private void btn_TMS_Hủy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public TaoPhieuMuonTamThoi(Yersin_University_Library perent) : this()
        {
            _parent = perent;
        }

        private void TaoPhieuMuonTamThoi_Shown(object sender, EventArgs e)
        {
            
        }
         int SachID = 0;
         int DocGiaID = 0;
        public TaoPhieuMuonTamThoi (int Sach, int DocGia, string TenSach, string TenDocGIa) : this()
        {
             SachID = Sach; DocGiaID = DocGia;
            txtSachID.Text = TenSach;
            txtDocGiaID.Text = TenDocGIa;
  
        }

        private void btn_TMS_ThemMoi_Click(object sender, EventArgs e)
        {
            string NgayMuon = datetimeNgayMuon.Value.ToShortDateString();
            string NgayHenTra = datetimeNgayHenTra.Value.ToShortDateString();
            int SoLuongMuon = int.Parse(nudSoLuong.Text);
            string Tinhtrang = txtTinhTrang.Text;
            PhieuMuonTamThoi PMTT = new PhieuMuonTamThoi(SachID, DocGiaID, NgayMuon, NgayHenTra, SoLuongMuon, Tinhtrang);
            DBQL_ThuVien.TaoPhieuTamThoi(PMTT);
        }
    }
}
