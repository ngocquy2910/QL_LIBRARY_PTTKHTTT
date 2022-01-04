using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_LIBRARY_PTTKHTTT
{
    class PhieuMuonTamThoi
    {
        public PhieuMuonTamThoi(int sachid, int docgiaid, string ngaymuon, string ngayhentra, int soluongmuon, string tinhtrang)
        {
            this.sachid = sachid;
            this.docgiaid = docgiaid;
            this.ngaymuon = ngaymuon;
            this.ngayhentra = ngayhentra;
            this.soluongmuon = soluongmuon;
            this.tinhtrang = tinhtrang;
        }

        public PhieuMuonTamThoi (string TinhTrang)
        {
            tinhtrang = TinhTrang;
        }
        public int sachid { get; set; }
        public int docgiaid { get; set; }
        public string ngaymuon { get; set; }
        public string ngayhentra { get; set; }
        public int soluongmuon { get; set; }
        public string tinhtrang { get; set; }

        public PhieuMuonTamThoi(int sachid, int docgiaid, string ngaymuon, string ngayhentra, int soluongmuon)
        {
            this.sachid = sachid;
            this.docgiaid = docgiaid;
            this.ngaymuon = ngaymuon;
            this.ngayhentra = ngayhentra;
            this.soluongmuon = soluongmuon;
        }

    }
}
