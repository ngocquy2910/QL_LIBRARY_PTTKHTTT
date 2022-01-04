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
    
    public partial class ThemMoiDocGia : Form
    {
        private readonly QLDocGia _parent;

        public ThemMoiDocGia(QLDocGia paren)
        {
            _parent = paren;
            InitializeComponent();
        }
        public ThemMoiDocGia()
        {
            InitializeComponent();
        }

        private void btn_AddND_Huy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac muon huy","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        private void btnLuuND_Click(object sender, EventArgs e)
        {
            string TenDocGia = txtTenDocGia.Text;
            string SDT = txtSoDienThoi.Text;
            string ADDRESS = txtDiachi.Text;
            string CMND = txtCMND.Text;
            DocGia DG = new DocGia(TenDocGia,CMND,ADDRESS,SDT);
            DBQL_ThuVien.ThemMoiTaiKhoan(DG);
           
        }
        
    }
}
