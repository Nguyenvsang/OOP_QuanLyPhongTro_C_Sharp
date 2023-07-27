using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class BangGia
    {
        // khoa chinh mabanggia
        public string mabanggia { get; set; }
        // khoa ngoai maphong
        public string maphong { get; set; }
        public int gia { get; set; }
        //
        public PhongTro phongTro { get; set; }
        // constructor
        public BangGia() { }
        public BangGia(BangGia bangGia)
        {
            this.mabanggia = bangGia.mabanggia;
            this.maphong = bangGia.maphong;
            this.gia = bangGia.gia;
            this.phongTro = bangGia.phongTro;
        }
        public BangGia(string mabanggia, string maphong, int gia, PhongTro phongTro)
        {
            this.mabanggia = mabanggia;
            this.maphong = maphong;
            this.gia = gia;
            this.phongTro = phongTro;
        }
    }
}
