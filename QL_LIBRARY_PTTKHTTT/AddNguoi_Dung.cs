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
    public partial class AddNguoi_Dung : Form
    {
        private readonly QL_ThuVien _parent;
        public AddNguoi_Dung(QL_ThuVien parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public AddNguoi_Dung()
        {
        }

        public void clear()
        {
            txtAddTenNguoiDung.Clear();
            txtADDMatKhauNguoiDung.Clear();
        }
        public bool checkTXT()
        {
            if(txtADDMatKhauNguoiDung.Text=="" || txtAddTenNguoiDung.Text == "")
            {
                MessageBox.Show("Mat khau hoac tai khoan khong dc de trong!", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
          
            return true;
        }
        private void btnLuuND_Click(object sender, EventArgs e)
        {
            if(checkTXT()==true)
            {
                NguoiDung a = new NguoiDung(txtAddTenNguoiDung.Text, txtADDMatKhauNguoiDung.Text, int.Parse(cbbADDVaitro.SelectedValue.ToString()));
                DBQL_ThuVien.ThemNhanVien(a);
                _parent.HienThiNhanVien();
                clear();
            }
           
        }
        public void LayVaiTro()
        {
            DBQL_ThuVien.LayVaiTro("SELECT * FROM vaitro", "VaiTroID", "TenVaiTro", cbbADDVaitro);
        }
        private void AddNguoi_Dung_Shown(object sender, EventArgs e)
        {
            LayVaiTro();
        }

        private void btn_AddND_Huy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
