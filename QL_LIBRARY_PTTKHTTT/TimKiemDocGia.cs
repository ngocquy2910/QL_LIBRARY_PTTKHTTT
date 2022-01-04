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
    public partial class TimKiemDocGia : Form
    {
        public TimKiemDocGia()
        {
            InitializeComponent();
        }

        public void HienThiDocGia()
        {
            string queery = "SELECT dg.DocGiaID, dg.TenDocGia, dg.DiaChi, dg.ChungMinhThu, dg.DienThoai, pm.PhieuMuonID From docgia as dg, phieumuon as pm " +
                              " WHERE  dg.DocGiaID = pm.DocGia  ";
            DBQL_ThuVien.HienThiDB(queery, dgvDocGia);
        }
        private void TimKiemDocGia_Shown(object sender, EventArgs e)
        {
            lbTenADMIN.Text += TenNguoiDung;
            HienThiDocGia();
        }
        int dem = 0;
        public int demnhap()
        {
            if (txtMaDG.Text != "")
            {
                dem++;
            }
            if (txtTenDG.Text != "")
            {
               
                dem++;
            }
            if (txtDC.Text != "")
            {
             
                dem++;
            }
            if (txtCMND.Text != "")
            {
               
                dem++;
            }
            if (txtSDT.Text != "")
            {
              
                dem++;
            }
            return dem++;
           
        }
        private void btHienThiTatCa_Click(object sender, EventArgs e)
        {
            HienThiDocGia();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string TenDocGia = "", DiaChi="", CMND="", SDT="";
            string DocGiaID="";
             string AND = "";
            demnhap();
            if (dem > 1)
            {
                AND = "AND";
            }
            if (txtMaDG.Text != "")
            {
                DocGiaID = " "+AND+" DocGiaID = '"+int.Parse(txtMaDG.Text) +"'";
               
            }
            if(txtTenDG.Text != "")
            {
                TenDocGia = " " + AND + " TenDocGia LIKE'%" + txtTenDG.Text + "%'"; 
              
            }
            if (txtDC.Text != "")
            {
                DiaChi = " " + AND + " Diachi LIKE'%" + txtDC.Text + "%'";
               
            }
            if (txtCMND.Text != "")
            {
                CMND = " " + AND + " ChungMinhThu LIKE'%" + txtCMND.Text + "%'";
             
            }
            if (txtSDT.Text != "")
            {
                SDT = " " + AND + " DienThoai LIKE'%" + txtSDT.Text + "%'";
              
            }

        
            string query = "SELECT dg.DocGiaID, dg.TenDocGia, dg.DiaChi, dg.ChungMinhThu, dg.DienThoai, pm.PhieuMuonID From docgia as dg, phieumuon as pm " +
                           " WHERE  dg.DocGiaID = pm.DocGia  "+DocGiaID+ "  " + TenDocGia+ "  " + DiaChi+ "   " + CMND+ "  " + SDT+" ";
            MessageBox.Show(query);
            DBQL_ThuVien.HienThiDB(query,dgvDocGia);
        }
        string TenNguoiDung;
        string MatKhau;
        string VaiTro;
        int NDID;
        string text = "";
        string IDDG = "";
        public TimKiemDocGia(string TND, string Mk, String VT, int ID) : this()
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

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if(vt == -1)
            {

            }
            else {
                DataGridViewRow dongchon = this.dgvDocGia.Rows[vt];
                IDDG = dongchon.Cells[0].Value.ToString();
            }

           
        }

        private void btHienThiCTPM_Click(object sender, EventArgs e)
        {
            
            text = "PMDGFROMQLDG";
            if (IDDG == "")
            {
                MessageBox.Show("Vui long chon 1 doc gia", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                DanhSachPMDG DSPMDG = new DanhSachPMDG(text, IDDG, TenNguoiDung, MatKhau, VaiTro, NDID);
                DSPMDG.Show();
            }
        }
    }
}
