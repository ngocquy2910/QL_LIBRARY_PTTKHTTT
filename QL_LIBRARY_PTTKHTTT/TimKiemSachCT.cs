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
    public partial class TimKiemSachCT : Form
    {
        public TimKiemSachCT()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon thoat!!!","Thong bao",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Visible = false;
            }
        }
        int NXB; int LS; int NN;
        string tensach = "";
        string tentacgia = "";
        public string KQTimKiemSach(string tensach, string tentacgia)
        {
    
            string TS= "", TTG="";
          
           
            string query = "SELECT" +
                       " FROM" +
                       " WHERE";
            if (txtTenSach.Text != "")
            {
                TS = "AND sach.TenSach";
              
   
            }

            if(txtTenTacGia.Text != "")
            {

                TTG = "AND sach.TacGia";
                  
       
                
            }
        
            query = "SELECT sach.TenSach, sach.TacGia, nxb.TenNXB, ls.TenLoaiSach, nn.TenNgonNgu, sach.NgayCapNhat, sach.GiaTien " +
                    " FROM sach, LoaiSach as ls, nhaxuatban as nxb, ngonngu as nn " +
                    " WHERE   sach.LoaiSach = ls.LoaiSachID   " +
                    "   AND sach.NXB = nxb.NXBID   AND sach.NgonNgu = nn.NgonNguID  AND  ls.LoaiSachID = " + LS + " AND  nn.NgonNguID = " + NN + " AND  nxb.NXBID = " + NXB + " " + TTG + "  " + tentacgia + "   " + TS + "   " + tensach + "  ";
            return query;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {

           string query = "SELECT sach.TenSach, sach.TacGia, nxb.TenNXB, ls.TenLoaiSach, nn.TenNgonNgu, sach.NgayCapNhat, sach.GiaTien " +
                     " FROM sach, LoaiSach as ls, nhaxuatban as nxb, ngonngu as nn " +
                     " WHERE   sach.LoaiSach = ls.LoaiSachID   " +
                     "   AND sach.NXB = nxb.NXBID   AND sach.NgonNgu = nn.NgonNguID";
            DBQL_ThuVien.HienThiDB(query,dgvKQTK);

        }

        private void TimKiemSach_Shown(object sender, EventArgs e)
        {
            
            LayLoaiSach();
            LayNXB();
            LayNgonNgu();
        }

        public void LayLoaiSach()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM loaisach", "LoaiSachID", "TenLoaiSach", cbbTheLoai);
        }
        public void LayNXB()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM nhaxuatban", "NXBID", "TenNXB", cbbNXB);
        }
        public void LayNgonNgu()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM ngonngu", "NgonNguID", "TenNgonNgu", cbbNgonNgu);
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

            if (txtTenSach.Text != "")
            {
                tensach = "  LIKE N'%" + txtTenSach.Text + "%'";
            }
            if (txtTenTacGia.Text != "")
            {
                tentacgia = " LIKE N'%" + txtTenTacGia.Text + "%'";
            }
            string kqtk = KQTimKiemSach(tensach, tentacgia);
            DBQL_ThuVien.TimKiemSach(kqtk, dgvKQTK);

        }

        private void txtTenTacGia_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSach.Text != "")
            {
                tensach = "  LIKE N'%" + txtTenSach.Text + "%'";
            }
            if (txtTenTacGia.Text != "")
            {
                tentacgia = " LIKE N'%" + txtTenTacGia.Text + "%'";
            }
            string kqtk = KQTimKiemSach(tensach, tentacgia);
            DBQL_ThuVien.TimKiemSach(kqtk, dgvKQTK);

        }

        private void cbbNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            NXB = int.Parse(cbbNXB.SelectedValue.ToString());
            if (txtTenSach.Text != "")
            {
                tensach = "  LIKE N'%" + txtTenSach.Text + "%'";
            }
            if (txtTenTacGia.Text != "")
            {
                tentacgia = " LIKE N'%" + txtTenTacGia.Text + "%'";
            }
            string kqtk = KQTimKiemSach(tensach, tentacgia);
            DBQL_ThuVien.TimKiemSach(kqtk, dgvKQTK);
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LS = int.Parse(cbbTheLoai.SelectedValue.ToString());
            if (txtTenSach.Text != "")
            {
                tensach = "  LIKE N'%" + txtTenSach.Text + "%'";
            }
            if (txtTenTacGia.Text != "")
            {
                tentacgia = " LIKE N'%" + txtTenTacGia.Text + "%'";
            }
            string kqtk = KQTimKiemSach(tensach, tentacgia);
            DBQL_ThuVien.TimKiemSach(kqtk, dgvKQTK);
        }

        private void cbbNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            NN = int.Parse(cbbNgonNgu.SelectedValue.ToString());
            if (txtTenSach.Text != "")
            {
                tensach = "  LIKE N'%" + txtTenSach.Text + "%'";
            }
            if (txtTenTacGia.Text != "")
            {
                tentacgia = " LIKE N'%" + txtTenTacGia.Text + "%'";
            }
            string kqtk = KQTimKiemSach(tensach, tentacgia);
            DBQL_ThuVien.TimKiemSach(kqtk, dgvKQTK);
        }
    }
}
