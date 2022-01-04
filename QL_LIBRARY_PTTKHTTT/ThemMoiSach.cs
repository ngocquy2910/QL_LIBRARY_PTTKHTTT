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
    public partial class ThemMoiSach : Form
    {
        private readonly QL_Sach _parent;
        public ThemMoiSach(QL_Sach parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void ThemMoiSach_Shown(object sender, EventArgs e)
        {
            LayLoaiSach();
            LayNgonNgu();
            LayNXB();
        }

        private void btn_TMS_ThemMoi_Click(object sender, EventArgs e)
        {
            string text = "";
            int LoaiSach = int.Parse(cbb_TMS_LoaiSach.SelectedValue.ToString());
            int NXB = int.Parse(cbb_TMS_NXB.SelectedValue.ToString());
            int NgoNgu = int.Parse(cbb_TMS_NgonNgu.SelectedValue.ToString());
            int sl = int.Parse(txtTMS_SoLuong.Text);
            int slc = int.Parse(txtSoLuongCon.Text);
            string TenSach = txtTMS_TenSach.Text;
            string GiaTien = txtTMS_GiaTien.Text;
            string TacGia = txtTMS_TacGia.Text;
            string NgayNhapdate = datetimeNgayNhap.Value.ToString();
     
            Sach book = new Sach(TenSach,TacGia,LoaiSach,NgoNgu,NXB,NgayNhapdate,GiaTien,sl,slc);
            DBQL_ThuVien.ThemMoiSach(book);
            _parent.HienThiSach(text);
            clear();
        }

        public void LayLoaiSach()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM loaisach","LoaiSachID","TenLoaiSach",cbb_TMS_LoaiSach);
        }
        public void LayNXB()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM nhaxuatban", "NXBID", "TenNXB", cbb_TMS_NXB);
        }
        public void LayNgonNgu()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM ngonngu", "NgonNguID", "TenNgonNgu", cbb_TMS_NgonNgu);
        }

        public void clear()
        {
            txtTMS_GiaTien.Clear(); txtTMS_SoLuong.Clear();
            txtTMS_TacGia.Clear(); txtTMS_TenSach.Clear();
        }

        private void btn_TMS_Hủy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
