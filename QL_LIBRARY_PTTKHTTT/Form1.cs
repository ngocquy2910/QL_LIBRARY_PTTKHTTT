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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        public static string VaiTro = "";
        public void clear()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }
        public bool check()
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Mat khau hoac tai khoan khong dc de trong!", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(check()==true)
            {
                string name = txtTenDangNhap.Text; string pass = txtMatKhau.Text;
                VaiTro = DBQL_ThuVien.getID(name, pass, lbLayID);
                if (VaiTro != "")
                {

                    QL_ThuVien child = new QL_ThuVien(txtTenDangNhap.Text, txtMatKhau.Text, VaiTro, lbLayID.Text);
                    child.Show();

                }
                else
                {
                    MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
                    clear();
                }
            }

            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemSachDNDG tks = new TimKiemSachDNDG();
            tks.Show();
        }
    }
}
