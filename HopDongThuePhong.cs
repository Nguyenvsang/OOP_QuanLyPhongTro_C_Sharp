using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class HopDongThuePhong
    {
        // khoa chinh soHDThue
        public string soHDThue { get; set; }
        // khoa ngoai maKH va maNV
        public string maKH { get; set; }
        public string maNV { get; set; }
        // mot hop dong co mot khach va mot nhan vien thuc hien
        public Khach khach { get; set; }
        public NhanVien nhanVien { get; set; }
        public ChiTietHDThuePhong chitiethd { get; set; }
        // constructor
        public HopDongThuePhong() { }
        public HopDongThuePhong(HopDongThuePhong hd)
        {
            this.soHDThue = hd.soHDThue;
            this.maKH = hd.maKH;
            this.maNV = hd.maNV;
            this.khach = hd.khach;
            this.nhanVien = hd.nhanVien;
            this.chitiethd = hd.chitiethd;
        }
        public HopDongThuePhong(string soHDThue, string maKH, string maNV, Khach khach, NhanVien nhanVien, ChiTietHDThuePhong chitiethd)
        {
            this.soHDThue = soHDThue;
            this.maKH = maKH;
            this.maNV = maNV;
            this.khach = khach;
            this.nhanVien = nhanVien;
            this.chitiethd = chitiethd;
        }
    }
}
