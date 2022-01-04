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
    
    public partial class ThayDoiThongTinDocGia : Form
    {
       
        public ThayDoiThongTinDocGia()
        {
            InitializeComponent();
          
        }
        int DocGiaID;
        string Ten; string CMND; string SDT; string DC;
        string STR;string MK; string TenNguoiDung; 
        int NDID = 0;
        int VaiTro = 0;

        public int IDND { get; }
        public string VaiTro1 { get; }

        public ThayDoiThongTinDocGia(int id, string ten, string cmnd, string sdt, string diachi): this()
        {
            DocGiaID = id;
            Ten = ten; CMND = cmnd; SDT = sdt; DC = diachi;
        }
        private void btn_TMS_Hủy_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có chắc muốn hủy", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        private void ThayDoiThongTinDocGia_Shown(object sender, EventArgs e)
        {
            if(STR == "TDTTND")
            {
                TDTTNguoiDung();
                txtTenDocGia.Text = TenNguoiDung ;
                txtDiaChi.Text = MK;
            }
            else
            {
                txtTenDocGia.Text = Ten;
                txtChungMinhThu.Text = CMND;
                txtDiaChi.Text = DC;
                txtSoDienThoai.Text = SDT;
            }
           
        }

        private void btn_TMS_ThemMoi_Click(object sender, EventArgs e)
        {
            
            string ten = txtTenDocGia.Text;
            string dc = txtDiaChi.Text;
            string sdt = txtSoDienThoai.Text;
            string cmt = txtChungMinhThu.Text;
            if(STR == "TDTTND")
            {
                NguoiDung ND = new NguoiDung(TenNguoiDung, MK, VaiTro);
                DBQL_ThuVien.CapNhatNhanVien(ND, NDID.ToString());
            }
            else
            {
                DocGia DG = new DocGia(ten, cmt, dc, sdt);
                DBQL_ThuVien.ThayDoiThongTinDG(DG, DocGiaID);
            }
          
        }

        public void TDTTNguoiDung()
        {
            lbThongTin.Text = "Thay đổi thông tin người dùng";
            lbTen.Text = "Tên người dùng";
            lbpass.Text = "Mật khẩu";
            lbdt.Visible = false;
            lbcmt.Visible = false;
            txtSoDienThoai.Visible = false;
            txtChungMinhThu.Visible = false;
        }
        public ThayDoiThongTinDocGia(string text, int iDND, string tenNguoiDung, string mK, string vaiTro) : this()
        {
            STR = text;
            IDND = iDND;
            TenNguoiDung = tenNguoiDung;
            MK = mK;
            VaiTro1 = vaiTro;
        }
    }
}
