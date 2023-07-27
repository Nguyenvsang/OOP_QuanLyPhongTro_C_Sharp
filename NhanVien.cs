using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class NhanVien
    {
        // khoa chinh maNV
        public string maNV { get; set; }
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string cCCD { get; set; }
        public string queQuan { get; set; }
        // danh sach hop dong thue phong ma moi nhan vien dam nhiem
        public ICollection<HopDongThuePhong> dsHDTP_nhanvien { get; set; }
        // constructor
        public NhanVien() { }
        public NhanVien(NhanVien nhanVien)
        {
            this.maNV = nhanVien.maNV;
            this.hoTen = nhanVien.hoTen;
            this.gioiTinh = nhanVien.gioiTinh;
            this.ngaySinh = nhanVien.ngaySinh;
            this.cCCD = nhanVien.cCCD;
            this.queQuan = nhanVien.queQuan;
            this.dsHDTP_nhanvien = nhanVien.dsHDTP_nhanvien;
        }
        public NhanVien(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string cCCD, string queQuan, ICollection<HopDongThuePhong> dsHDTP_nhanvien)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.cCCD = cCCD;
            this.queQuan = queQuan;
            this.dsHDTP_nhanvien = dsHDTP_nhanvien;
        }
    }
}
