using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class Khach
    {
        // khoa chinh maKH
        public string maKH { get; set; }
        // khoa ngoai maloaiKH
        public string maloaiKH { get; set; }
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string cCCD { get; set; }
        public string queQuan { get; set; }
        public string ngheNghiep { get; set; }
        // 
        public LoaiKH nhomloaiKH { get; set; }
        // mot khach co the co nhieu hop dong thue phong
        public ICollection<HopDongThuePhong> dshdthuephong_khach { get; set; }
        // constructor
        public Khach() { }
        public Khach(Khach khach)
        {
            this.maKH = khach.maKH;
            this.maloaiKH = khach.maloaiKH;
            this.hoTen = khach.hoTen;
            this.gioiTinh = khach.gioiTinh;
            this.ngaySinh = khach.ngaySinh;
            this.cCCD = khach.cCCD;
            this.queQuan = khach.queQuan;
            this.ngheNghiep = khach.ngheNghiep;
            this.nhomloaiKH = khach.nhomloaiKH;
            this.dshdthuephong_khach = khach.dshdthuephong_khach;
        }
        public Khach(string maKH,string maloaiKH, string hoTen, string gioiTinh, DateTime ngaySinh, string cCCD, string queQuan, string ngheNghiep, LoaiKH nhomloaiKH,
            ICollection<HopDongThuePhong> dshdthuephong_khach)
        {
            this.maKH = maKH;
            this.maloaiKH = maloaiKH;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.cCCD = cCCD;
            this.queQuan = queQuan;
            this.ngheNghiep = ngheNghiep;
            this.nhomloaiKH = nhomloaiKH;
            this.dshdthuephong_khach = dshdthuephong_khach;
        }
    }
}
