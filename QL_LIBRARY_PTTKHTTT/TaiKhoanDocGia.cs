using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_LIBRARY_PTTKHTTT
{
    class TaiKhoanDocGia
    {
        public TaiKhoanDocGia(string tenDocGia, string diaChi, string soDienThoai, string cMND)
        {

            TenDocGia = tenDocGia;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
            CMND = cMND;
        }
        public string TenDocGia { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string CMND { get; set; }
    }
}
