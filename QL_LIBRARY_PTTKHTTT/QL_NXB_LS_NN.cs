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
    public partial class QL_NXB_LS_NN : Form
    {
        public QL_NXB_LS_NN()
        {
            InitializeComponent();
        }

        private void QL_NXB_LS_NN_Shown(object sender, EventArgs e)
        {
            HienThiNXB();
            HienThiLoaiSach();
            HienThiNgonNgu();
        }


        public void HienThiNXB()
        {
            string query_NXB = "SELECT * FROM nhaxuatban";
            DBQL_ThuVien.HienThiDB(query_NXB, dgvNXB);
        }

        public void HienThiLoaiSach()
        {
            string query_LS = "SELECT * FROM loaisach";
            DBQL_ThuVien.HienThiDB(query_LS, dgvLS);
        }

        public void HienThiNgonNgu()
        {
            string query_NN = "SELECT * FROM ngonngu";

            DBQL_ThuVien.HienThiDB(query_NN, dgvNN);
        }
        private void btnTMNXB_Click(object sender, EventArgs e)
        {
            string text = "Nhà xuất bản";
            ThemMoi_NXB_LS_NN TMNXB = new ThemMoi_NXB_LS_NN(this, text);
            TMNXB.Show();
        }

        private void btnTMLS_Click(object sender, EventArgs e)
        {
            string text = "Loại sách";
            ThemMoi_NXB_LS_NN TMLS = new ThemMoi_NXB_LS_NN(this, text);
            TMLS.Show();
        }

        private void btnTMNN_Click(object sender, EventArgs e)
        {
            string text = "Ngôn ngữ";
            ThemMoi_NXB_LS_NN TMNN = new ThemMoi_NXB_LS_NN(this, text);
            TMNN.Show();
        }
        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt == -1 )
            {

            }
            else
            {
                DataGridViewRow dongchon = dgvNXB.Rows[vt];
                txtMaNXB.Text = dongchon.Cells[0].Value.ToString();
                txtTenNXB.Text = dongchon.Cells[1].Value.ToString();
                ID = int.Parse(dongchon.Cells[0].Value.ToString());
                Ten = dongchon.Cells[1].Value.ToString();
            }

        }


        private void dgvLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if (vt == -1)
            {

            }
            else
            {
                DataGridViewRow dongchon = dgvLS.Rows[vt];
                txtMaLoaiSach.Text = dongchon.Cells[0].Value.ToString();
                txtTenLoaiSach.Text = dongchon.Cells[1].Value.ToString();
                ID = int.Parse(dongchon.Cells[0].Value.ToString());
                Ten = dongchon.Cells[1].Value.ToString();
            }
        }
        int vt = -1;
        private void dgvNN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             vt = e.RowIndex;
            if (vt == -1)
            {

            }
            else
            {
                DataGridViewRow dongchon = dgvNN.Rows[vt];
                txtMaNgonNgu.Text = dongchon.Cells[0].Value.ToString();
                txtTenNgonNgu.Text = dongchon.Cells[1].Value.ToString();
                ID = int.Parse(dongchon.Cells[0].Value.ToString());
            }
        }
        int ID;
        string tb = "";
        string Ten = "";
        // NXB
        private void btnCNNXB_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Vui long chon mot nha xuat ban muon cap nhat","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Ten = txtTenNXB.Text;
                tb = "Cap nhat nha xuat ban thanh cong";
                if (MessageBox.Show("ban co chac muon Update NXB:  " + Ten + " khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query_NXB = "UPDATE nhaxuatban set TenNXB = @Ten WHERE NXBID = " + ID + "";
                    DBQL_ThuVien.THemMoi_UpDateNSBLSNN(query_NXB, Ten, tb);
                    HienThiNXB();
                }
                  
                
            }  
        }
     
        private void btnXNXB_Click(object sender, EventArgs e)
        {
            if(ID==0)
            {
                MessageBox.Show("Vui long chon mot nha xuat ban muon xoa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("ban co chac muon Xoa NXB:  " +Ten+ " khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    tb = "Xoa nha xuat ban thanh cong";
                    string query_NXB = "DELETE FROM nhaxuatban  WHERE NXBID = " + ID + "";
                    DBQL_ThuVien.Xoa_NXBLSNN(query_NXB, tb);
                    HienThiNXB();
                }    
                 
            }
        }
        // Loại sách
        private void btnCNLS_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Vui long chon mot Loai sach ban muon cap nhat", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Ten = txtTenLoaiSach.Text;
                tb = "Cap nhat loai sach thanh cong";
                if (MessageBox.Show("ban co chac muon Update Loai sach:  " + Ten + " khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query_NXB = "UPDATE loaisach set TenLoaiSach = @Ten WHERE LoaiSachID = " + ID + "";
                    DBQL_ThuVien.THemMoi_UpDateNSBLSNN(query_NXB, Ten, tb);
                    HienThiLoaiSach();
                }


            }
        }

        private void btnXLS_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Vui long chon mot Loai sach muon xoa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("ban co chac muon Xoa khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    tb = "Xoa loai sach thanh cong";
                    string query_NXB = "DELETE FROM loaisach  WHERE LoaiSachID = " + ID + "";
                    DBQL_ThuVien.Xoa_NXBLSNN(query_NXB, tb);
                    HienThiLoaiSach();
                }

            }
        }
        // Ngôn ngữ
        private void btnCNNN_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Vui long chon mot ngon ngu ban muon cap nhat", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Ten = txtTenNgonNgu.Text;
                tb = "Cap nhat ngon ngu thanh cong";
                if (MessageBox.Show("ban co chac muon Update ngon ngu khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string query_NXB = "UPDATE ngongnu set TenNgonNgu = @Ten WHERE NgonNguID = " + ID + "";
                    DBQL_ThuVien.THemMoi_UpDateNSBLSNN(query_NXB, Ten, tb);
                    HienThiNgonNgu();
                }


            }
        }

        private void btnXoaNN_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Vui long chon mot ngon ngu muon xoa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("ban co chac muon Xoa khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    tb = "Xoa ngon ngu thanh cong";
                    string query_NXB = "DELETE FROM ngonngu  WHERE NgonNguID = " + ID + "";
                    DBQL_ThuVien.Xoa_NXBLSNN(query_NXB, tb);
                    HienThiNgonNgu();
                }

            }
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
