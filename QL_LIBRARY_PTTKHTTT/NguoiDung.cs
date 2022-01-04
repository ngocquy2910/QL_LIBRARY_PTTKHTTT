using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_LIBRARY_PTTKHTTT
{
    class NguoiDung
    {
        private QL_ThuVien qL_ThuVien;

        public NguoiDung(QL_ThuVien qL_ThuVien)
        {
            this.qL_ThuVien = qL_ThuVien;
        }

        public NguoiDung(string tenNhanVien, string matKhau, int vaiTro)
        {
            TenNhanVien = tenNhanVien;
            MatKhau = matKhau;
            VaiTro = vaiTro;
        }

        public string TenNhanVien { get; set; }
        public string MatKhau { get; set; }
        public int VaiTro { get; set; }
    }
}
