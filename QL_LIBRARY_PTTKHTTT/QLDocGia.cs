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
    public partial class QLDocGia : Form
    {
       

        public QLDocGia()
        {
            InitializeComponent();
        }
        public void HienThiDocGia()
        {
            string query = "SELECT  *from docgia ";
            DBQL_ThuVien.HienThiDB(query, dgvQLDG);
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void QLDocGia_Shown(object sender, EventArgs e)
        {
            lbTenADMIN.Text += TenNguoiDung;
            HienThiDocGia();
        }
        public void clear()
        {
            txtTenDocGia.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtCMND.Clear();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemMoiDocGia TMDG = new ThemMoiDocGia(this);
            TMDG.Show();
           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you want to delete book record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int vt = dgvQLDG
                    .CurrentRow.Index;
                DataGridViewRow dongchon = dgvQLDG.Rows[vt];

                string id = (dongchon.Cells[0].Value.ToString());
                DBQL_ThuVien.XoaTaiKhoan(id);
                HienThiDocGia();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int vt = dgvQLDG.CurrentRow.Index;
            DataGridViewRow dongchon = dgvQLDG.Rows[vt];
            string id = dongchon.Cells[0].Value.ToString();
            TaiKhoanDocGia a = new TaiKhoanDocGia(txtTenDocGia.Text, txtDiaChi.Text, txtSDT.Text, txtCMND.Text);;
            DBQL_ThuVien.CapNhatTaiKhoan(a, id);
            HienThiDocGia();
        }

        private void dgvQLDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if(vt == -1 || vt > dgvQLDG.Columns.Count)
            {
                
            }else
            {
                DataGridViewRow dongchon = this.dgvQLDG.Rows[vt];
                txtMaDocGia.Text = dongchon.Cells[0].Value.ToString();
                txtTenDocGia.Text = dongchon.Cells[1].Value.ToString();
                txtDiaChi.Text = dongchon.Cells[2].Value.ToString();
                txtCMND.Text = dongchon.Cells[3].Value.ToString();
                txtSDT.Text = dongchon.Cells[4].Value.ToString();
                IDDG = dongchon.Cells[0].Value.ToString();
            }
            
        }
        string IDDG ="";
        string text = "PMDGFROMQLDG";
        private void btnSachDaMuon_Click(object sender, EventArgs e)
        {
            if(IDDG == "")
            {
                MessageBox.Show("Vui long chon 1 doc gia","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            else {
                DanhSachPMDG DSPMDG = new DanhSachPMDG(text, IDDG, TenNguoiDung, MatKhau, VaiTro, NDID);
                DSPMDG.Show();
            }

           
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        string TenNguoiDung;
        string MatKhau;
        string VaiTro;
        int NDID;
        public QLDocGia(string TND, string Mk, String VT, int ID) : this()
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
                TimKiemDocGia TKDG = new TimKiemDocGia(TenNguoiDung, MatKhau, VaiTro, NDID);  
                TKDG.Show();
                
        }

        private void dgvQLDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
