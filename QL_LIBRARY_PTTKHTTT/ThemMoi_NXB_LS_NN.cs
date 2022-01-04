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
    public partial class ThemMoi_NXB_LS_NN : Form
    {
        private readonly QL_NXB_LS_NN _parent;
        public ThemMoi_NXB_LS_NN()
        {
            InitializeComponent();
        }
        public ThemMoi_NXB_LS_NN(QL_NXB_LS_NN parent, string text) : this()
        {
            _parent = parent;
            TEXT = text;
        }

        string TEXT = "";
        string query = "";
        string Ten = "";
        string tb = "";

        private void ThemMoi_NXB_LS_NN_Load(object sender, EventArgs e)
        {
            if (TEXT == "Nhà xuất bản")
            {
                lbTieuDe.Text += TEXT;
                lbTen.Text = "Tên NXB";
                tb = "Them moi Nhà xuất bản thành công";
                query = "INSERT INTO nhaxuatban VALUES (@Ten)";
            }
            if (TEXT == "Loại sách")
            {
                lbTieuDe.Text += TEXT;
                lbTen.Text = "Tên Loại sách";
                tb = "Them moi loại sách thành công";
                query = "INSERT INTO loaisach VALUES (@Ten)";
            }
            if (TEXT == "Ngôn ngữ")
            {
                lbTieuDe.Text += TEXT;

                lbTen.Text = "Tên ngôn ngữ";
                tb = "Them moi ngôn ngữ thành công";
                query = "INSERT INTO ngonngu VALUES (@Ten)";
            }

        }

        private void btnXNTM_Click(object sender, EventArgs e)
        {
            if(txtTMTen.Text =="")
            {
                MessageBox.Show("Vui long nhap ten "+Text+"","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            {
                Ten = txtTMTen.Text;
                DBQL_ThuVien.THemMoi_UpDateNSBLSNN(query, Ten, tb);
                _parent.HienThiNXB();
                _parent.HienThiNgonNgu();
                _parent.HienThiLoaiSach();
            }
           
        }

        private void btnHuyTm_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ban co chac muon huy them moi "+TEXT+" khong", "Thong bao", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Visible = false;
            }
        }
    }
}
