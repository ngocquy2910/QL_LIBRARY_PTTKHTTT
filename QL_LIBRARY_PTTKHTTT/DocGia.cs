using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_LIBRARY_PTTKHTTT
{
    class DocGia
    {
        public DocGia(string tenDocGia, string cMND, string diaChi, string sDT)
        {
            TenDocGia = tenDocGia;
            CMND = cMND;
            DiaChi = diaChi;
            SDT = sDT;
        }

        public string TenDocGia { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
    }
}
