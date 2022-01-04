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
    public partial class TimKiemSachDNDG : Form
    {
        public TimKiemSachDNDG()
        {
            InitializeComponent();
        }

        public void HienThiSach()
        {
            string query = "SELECT  s.SachID, " +
                "s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.TacGia, s.GiaTien, s.SoLuong, s.NgayCapNhat  FROM sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
                "WHERE s.LoaiSach = ls.LoaiSachID AND s.NgonNgu = nn.NgonNguID AND s.NXB = nxb.NXBID ";
            DBQL_ThuVien.HienThiDB(query, dgvKQTK);
        }

        private void TimKiemSachDNDG_Shown(object sender, EventArgs e)
        {
            LayLoaiSach();
            HienThiSach();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimKiemSachCT tksct = new TimKiemSachCT();
            tksct.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimKiem.Text;
            string query = "SELECT  s.SachID, " +
               "s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.TacGia, s.GiaTien, s.SoLuong, s.NgayCapNhat  FROM sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
               "WHERE s.LoaiSach = ls.LoaiSachID AND s.NgonNgu = nn.NgonNguID AND s.NXB = nxb.NXBID AND s.TenSach LIKE N'%"+tk+"%' ";
            DBQL_ThuVien.TimKiemSach(query, dgvKQTK);
        }
        public void LayLoaiSach()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM loaisach", "LoaiSachID", "TenLoaiSach", cbbDanhMuc);
        }
        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dm = int.Parse(cbbDanhMuc.SelectedValue.ToString());
            string query = "SELECT  s.SachID, " +
               "s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.TacGia, s.GiaTien, s.SoLuong, s.NgayCapNhat  FROM sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
               "WHERE s.LoaiSach = ls.LoaiSachID AND s.NgonNgu = nn.NgonNguID AND s.NXB = nxb.NXBID AND ls.LoaiSachID = "+dm+" ";
                 DBQL_ThuVien.TimKiemSach(query, dgvKQTK);
        }

        public void clear()
        {
            txtSoCMND.Text = "";
            txtTenTaiKhoan.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            string TaiKhoan = txtTenDocGia.Text;
            string cmnd = txtSoCMND.Text;
            string kq = DBQL_ThuVien.CHECKDG(TaiKhoan, cmnd,lbSTD, lbDiaChi);
            if(kq !="")
            {
                Yersin_University_Library tkdn = new Yersin_University_Library(txtTenDocGia.Text,kq,txtSoCMND.Text,lbSTD.Text,lbDiaChi.Text);
                    tkdn.Show();
            }else
            {
                MessageBox.Show("Log in that bai.");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có chắc muốn thoát", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ThemMoiDocGia TMDG = new ThemMoiDocGia();
            TMDG.Show();
        }
    }
}
