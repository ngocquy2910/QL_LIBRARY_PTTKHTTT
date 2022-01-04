using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_LIBRARY_PTTKHTTT
{
    class Sach
    {
        public Sach(string tenSach, string taGia, int loaiSachID, int ngonNguID, int nXB, string ngayNhap, string gaiTien, int soLuong, int soluongcon)
        {
            TenSach = tenSach;
            TaGia = taGia;
            LoaiSachID = loaiSachID;
            NgonNguID = ngonNguID;
            NXB = nXB;
            NgayNhap = ngayNhap;
            GaiTien = gaiTien;
            SoLuong = soLuong;
            SoLuongCon = soluongcon;
            
        }
        public Sach(string tenSach, string taGia, int loaiSachID, int ngonNguID, int nXB, string ngayNhap, string gaiTien, int soLuong)
        {
            TenSach = tenSach;
            TaGia = taGia;
            LoaiSachID = loaiSachID;
            NgonNguID = ngonNguID;
            NXB = nXB;
            NgayNhap = ngayNhap;
            GaiTien = gaiTien;
            SoLuong = soLuong;

        }

        public string TenSach { get; set; }
        public string TaGia { get; set; }
        public int LoaiSachID { get; set; }
        public int NgonNguID { get; set; }
        public int NXB { get; set; }
        public string NgayNhap { get; set; }
        public string GaiTien { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongCon { get; set; }

      
    }
}
