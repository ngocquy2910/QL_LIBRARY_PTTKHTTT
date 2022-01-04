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
    public partial class BieuDoPhieuMuon : Form
    {
        public BieuDoPhieuMuon()
        {
            InitializeComponent();
        }
        string query; string X; string Y;  
        public BieuDoPhieuMuon(string qr, string x, string y) : this()
        {
            query = qr;
            X = x;
            Y = y;
           
        }
        private void BieuDoPhieuMuon_Load(object sender, EventArgs e)
        {
            DBQL_ThuVien.BieuDoLuotXem(query,chart1,X,Y);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
