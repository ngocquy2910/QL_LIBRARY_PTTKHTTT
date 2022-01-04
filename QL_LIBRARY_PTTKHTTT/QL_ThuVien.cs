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
    public partial class QL_ThuVien : Form
    {
        string strNhan;
        AddNguoi_Dung nguoidung;
     
        public QL_ThuVien()
        {
            InitializeComponent();
            nguoidung = new AddNguoi_Dung(this);
        }

        public void openControllerAdmin()
        {
            btnQuanLyDocGia.Enabled = true;
            btnQuanLySach.Enabled = true;
            btnQuanLyTraMuon.Enabled = true;
            btnThayDoiThongTinTaiKhoan.Enabled = true;
            btnThongKe.Enabled = true;
            btnXoaTaiKhoan.Enabled = true;
            btnThemTaiKhoan.Enabled = true;
            btnCapNhatNguoiDung.Enabled = true;
        }

        public void openControllerThuThu()
        {
            btnQuanLyDocGia.Enabled = true;
            btnQuanLySach.Enabled = true;
            btnQuanLyTraMuon.Enabled = true;
            btnThayDoiThongTinTaiKhoan.Enabled = true;
            btnThongKe.Enabled = true;
            btnXoaTaiKhoan.Enabled = false;
            btnThemTaiKhoan.Enabled = false;
            btnCapNhatNguoiDung.Enabled = false;
        }

        public void openControllerThuKho()
        {
            btnQuanLyDocGia.Enabled = false;
            btnQuanLySach.Enabled = true;
            btnQuanLyTraMuon.Enabled = false;
            btnThayDoiThongTinTaiKhoan.Enabled = true;
            btnThongKe.Enabled = true;
            btnXoaTaiKhoan.Enabled = false;
            btnThemTaiKhoan.Enabled = false;
            btnCapNhatNguoiDung.Enabled = false;
        }
        int IDND = 0;
        public QL_ThuVien(string giatrinhan,string mk, string vaitro, string ID): this()
        {
            IDND = int.Parse(ID.ToString());
            TenNguoiDung = giatrinhan; MK = mk;  
            strNhan = giatrinhan;
            lbTenADMIN.Text += strNhan;
            VaiTro = vaitro;
            if(VaiTro=="1")
            {
                openControllerAdmin();
            }
            if (vaitro == "2")
            {
                openControllerThuThu();
            }
            if(VaiTro=="3")
            {
                openControllerThuKho();
            }
        }

      
        public void HienThiNhanVien()
        {
            string query = "SELECT NguoiDungID, TenNguoiDung,MatKhau, vaitro.TenVaiTro From nguoidung, vaitro WHERE vaitro.VaiTRoID = nguoidung.VaiTro";
            DBQL_ThuVien.HienThiDB(query, dgvNguoiDung);
        }

        private void QL_ThuVien_Shown(object sender, EventArgs e)
        {
            HienThiNhanVien();
            LayVaiTro();
        }

        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            string timkiem =  txtTimKiemNhanVien.Text;
            string query = "SELECT NguoiDungID, TenNguoiDung,  vaitro.TenVaiTro  " +
                " From nguoidung, vaitro  " +
                " WHERE vaitro.VaiTRoID = nguoidung.VaiTro AND TenNguoiDung LIKE '%" + timkiem+ "%'";
            DBQL_ThuVien.HienThiDB(query, dgvNguoiDung);
        }

        public  void LayVaiTro()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM vaitro", "VaiTroID", "TenVaiTro", cbbVaiTro);
        }
     
     
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có chắc muốn đăng xuất","Thông Báo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if(tb == DialogResult.Yes)
            {
                this.Visible = false;
            }
          
        }
        int NguoiDngID;
        string MK; string TenNguoiDung; string VaiTro;
        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if(vt >= -1 || vt <= dgvNguoiDung.Rows.Count )
            {
                DataGridViewRow dongchon = this.dgvNguoiDung.Rows[vt];
                txtTenDangNhap.Text = dongchon.Cells[1].Value.ToString();
                txtMaKhau.Text = dongchon.Cells[2].Value.ToString();
                cbbVaiTro.Text = dongchon.Cells[3].Value.ToString();
                NguoiDngID = int.Parse(dongchon.Cells[0].Value.ToString());
            }
           
  
        }

        private void txtThemTaiKhoan_Click(object sender, EventArgs e)
        {
            nguoidung.clear();
            nguoidung.ShowDialog();
        }

        private void txtXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you want to delete NguoiDUng record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int vt = dgvNguoiDung.CurrentRow.Index;
                DataGridViewRow dongchon = dgvNguoiDung.Rows[vt];
          
                string id = (dongchon.Cells[0].Value.ToString());
                DBQL_ThuVien.DeleteNguoiDung(id);
                HienThiNhanVien();
            }
        }

        private void txtThayDoiThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you want to Update NguoiDUng ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int vt = dgvNguoiDung.CurrentRow.Index;
                DataGridViewRow dongchon = dgvNguoiDung.Rows[vt];
                int VaiTro = int.Parse(cbbVaiTro.SelectedValue.ToString());
                string id = dongchon.Cells[0].Value.ToString();
                NguoiDung a = new NguoiDung(txtTenDangNhap.Text, txtMaKhau.Text, VaiTro);
                DBQL_ThuVien.CapNhatNhanVien(a, id);
                HienThiNhanVien();
            }
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            QL_Sach Form_QLS = new QL_Sach(TenNguoiDung,MK,VaiTro,IDND);
            Form_QLS.Show();
        }

        private void btnQuanLyTraMuon_Click(object sender, EventArgs e)
        {
            QuanLyMuonTra QLMT = new QuanLyMuonTra(TenNguoiDung, MK, VaiTro, IDND);
            QLMT.Show();
        }

        private void btnThayDoiThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            string text = "TDTTND";
            ThayDoiThongTinDocGia TDTTND = new ThayDoiThongTinDocGia(text, IDND, TenNguoiDung,MK,VaiTro);
            TDTTND.Show();
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            QLDocGia QLDG = new QLDocGia(TenNguoiDung,MK,VaiTro,IDND);
            QLDG.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe TK = new ThongKe(TenNguoiDung, MK, VaiTro, IDND);
            TK.Show();
        }
    }
}
