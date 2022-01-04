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
    public partial class DangKyDocGia : Form
    {
        public DangKyDocGia()
        {
            InitializeComponent();
        }

        private void btn_TMS_ThemMoi_Click(object sender, EventArgs e)
        {
             TaiKhoanDocGia a = new TaiKhoanDocGia(txtTenDocGia.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtChungMinhThu.Text);
            DBQL_ThuVien.ThemMoiTaiKhoan(a);
            Clear();
        }
        public void Clear()
        {
            txtChungMinhThu.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtTenDocGia.Clear();

        }

        private void btn_TMS_Hủy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon tro lai!", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }
    }
}
