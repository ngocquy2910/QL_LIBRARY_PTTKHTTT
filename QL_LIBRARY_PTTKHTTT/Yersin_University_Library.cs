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
    public partial class Yersin_University_Library : Form
    {
        public Yersin_University_Library()
        {
            InitializeComponent();
        }
        int counter = 0;
        int len = 0;
        string txt;
        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter > len)
            {
                counter = 0;
                lbTitle.Text = "";
            }else
            {
                lbTitle.Text = txt.Substring(0, counter);
                if (lbTitle.ForeColor == Color.Blue)
                    lbTitle.ForeColor = Color.Orange;
                else
                    lbTitle.ForeColor = Color.Blue;
            }

                
                    
        }

        public int DocGiaID;
        string TenDocGia; string CMND; string DiaChi; string SDT;
        string TenSach;
        public int SachID;
        public int vt;
        public Yersin_University_Library(string str, string id,string cmnd, string std, string dc) : this()
        {
            TenDocGia = str;
            DocGiaID = int.Parse(id.ToString());
            lbTenADMIN.Text += TenDocGia;
            CMND = cmnd; DiaChi = dc; SDT = std;
        }
        private void Yersin_University_Library_Load(object sender, EventArgs e)
        {
            txt = lbTitle.Text;
            len = txt.Length;
            lbTitle.Text = "";
            timer1.Start();
        }
        public void HienThiSach()
        {
            string query = "SELECT  s.SachID, " +
                "s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.TacGia, s.GiaTien, s.SoLuong, s.NgayCapNhat  FROM sach as s, loaisach as ls, ngonngu as nn, nhaxuatban as nxb " +
                "WHERE s.LoaiSach = ls.LoaiSachID AND s.NgonNgu = nn.NgonNguID AND s.NXB = nxb.NXBID ";
            DBQL_ThuVien.HienThiDB(query, dgvKQTK);
        }
        public string KQTimKiemSach(string tensach, string tentacgia, string giatien)
        {

            string TS = "", TTG = "",Gia = "";


            string query = "SELECT" +
                       " FROM" +
                       " WHERE";
            if (txtTenSach.Text != "")
            {
                TS = "AND sach.TenSach";
            }

            if (txtTacGia.Text != "")
            {

                TTG = "AND sach.TacGia";
            }
            if (txtGiaBia.Text != "")
            {

                TTG = "AND sach.GiaTien";
            }

            query = "SELECT sach.TenSach, sach.TacGia, nxb.TenNXB, ls.TenLoaiSach, nn.TenNgonNgu, sach.NgayCapNhat, sach.GiaTien " +
                    " FROM sach, LoaiSach as ls, nhaxuatban as nxb, ngonngu as nn " +
                    " WHERE   sach.LoaiSach = ls.LoaiSachID   " +
                    "   AND sach.NXB = nxb.NXBID   AND sach.NgonNgu = nn.NgonNguID  " + TTG + "  " + tentacgia + "   " + TS + "   " + tensach + " "+Gia+" "+giatien+" ";
            return query;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string tensach = "";
            string tentacgia = "";
            string giatien = "";
            if (txtTenSach.Text != "")
            {
                tensach = " LIKE N'" + txtTenSach.Text + "'";
            }
            if (txtTacGia.Text != "")
            {
                tentacgia = "LIKE N'" + txtTacGia.Text + "'";
            }
            if (txtGiaBia.Text != "")
            {
                giatien = "LIKE N'" + txtGiaBia.Text + "'";
            }
            string kqtk = KQTimKiemSach(tensach, tentacgia,giatien);

            DBQL_ThuVien.TimKiemSach(kqtk, dgvKQTK);
        }

        private void Yersin_University_Library_Shown(object sender, EventArgs e)
        {
            HienThiSach();
            LayLoaiSach();  LayNgonNgu(); LayNXB();
        }

        public void LayLoaiSach()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM loaisach", "LoaiSachID", "TenLoaiSach", cbbLoaiSach);
        }
        public void LayNXB()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM nhaxuatban", "NXBID", "TenNXB", cbbNXB);
        }
        public void LayNgonNgu()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM ngonngu", "NgonNguID", "TenNgonNgu", cbbNgonNgu);
        }

        private void btLoc_Click(object sender, EventArgs e)
        {
            int loaisach = int.Parse(cbbLoaiSach.SelectedValue.ToString());
            int nxb = int.Parse(cbbNXB.SelectedValue.ToString());
            int nn = int.Parse(cbbNgonNgu.SelectedValue.ToString());
            string query = "";
            query = "SELECT sach.TenSach, sach.TacGia, nxb.TenNXB, ls.TenLoaiSach, nn.TenNgonNgu, sach.NgayCapNhat, sach.GiaTien " +
                 " FROM sach, LoaiSach as ls, nhaxuatban as nxb, ngonngu as nn " +
                 " WHERE   sach.LoaiSach = ls.LoaiSachID   " +
                 "   AND sach.NXB = nxb.NXBID   AND sach.NgonNgu = nn.NgonNguID AND ls.LoaiSachID = "+loaisach+"  " +
                 " AND nxb.NXBID = "+nxb+" AND nn.NgonNguID = "+nn+" ";
            DBQL_ThuVien.TimKiemSach(query, dgvKQTK);
        }
    
        private void btMuon_Click(object sender, EventArgs e)
        {
            TaoPhieuMuonTamThoi pm = new TaoPhieuMuonTamThoi(SachID, DocGiaID,TenSach,TenDocGia);
            pm.Show();  
        }

        private void dgvKQTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if(vt != -1 || vt < dgvKQTK.Columns.Count)
            {
                DataGridViewRow dognchon = this.dgvKQTK.Rows[vt];
                SachID = int.Parse(dognchon.Cells[0].Value.ToString());
                TenSach = dognchon.Cells[1].Value.ToString();
            }
            
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            DanhSachPMDG DSPMXN = new DanhSachPMDG(TenDocGia,DocGiaID,CMND,SDT,DiaChi);
            DSPMXN.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có chắc muốn đăng xuất", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        private void btnThayDoiThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            ThayDoiThongTinDocGia TDTTDG = new ThayDoiThongTinDocGia(DocGiaID,TenDocGia,CMND,SDT,DiaChi);
            TDTTDG.Show();
        }

        private void txtQLDG_Click(object sender, EventArgs e)
        {
            QLDocGia qldg = new QLDocGia();
            qldg.Show();
        }
    }
}
