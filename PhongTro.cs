using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class PhongTro
    {
        // khoa chinh maphong
        public string maphong { get; set; }
        // khoa ngoai maloaiphong, manhatro
        public string maloaiphong { get; set; }
        public string manhatro { get; set; }
        public string tenphong { get; set; }
        public string day { get; set; }
        // 
        public LoaiPhong loaiPhong { get; set; }
        public NhaTro nhaTro { get; set; }
        public TrangBi trangBi { get; set; }
        public ChiTietHDThuePhong chitiethd { get; set; }
        // Danh sach bang gia xep theo phong tro
        public ICollection<BangGia> dsbanggia_phongtro { get; set; }
        // constructor
        public PhongTro() { }
        public PhongTro(PhongTro phongTro)
        {
            this.maphong = phongTro.maphong;
            this.maloaiphong = phongTro.maloaiphong;
            this.manhatro = phongTro.manhatro;
            this.tenphong = phongTro.tenphong;
            this.day = phongTro.day;
            this.loaiPhong = phongTro.loaiPhong;
            this.nhaTro = phongTro.nhaTro;
            this.trangBi = phongTro.trangBi;
            this.chitiethd = phongTro.chitiethd;
            this.chitiethd = phongTro.chitiethd;
            
            this.dsbanggia_phongtro = phongTro.dsbanggia_phongtro;
        }
        public PhongTro(string maphong, string maloaiphong, string manhatro, string tenphong, 
            string day, LoaiPhong loaiphong, NhaTro nhatro, TrangBi trangBi, ChiTietHDThuePhong chitiethd, ICollection<BangGia> dsbanggia_phongtro)
        {
            this.maphong = maphong;
            this.maloaiphong = maloaiphong;
            this.manhatro = manhatro;
            this.tenphong = tenphong;
            this.day = day;
            this.loaiPhong = loaiPhong;
            this.nhaTro = nhaTro;
            this.trangBi = trangBi;
            this.chitiethd = chitiethd;
            this.dsbanggia_phongtro = dsbanggia_phongtro;
        }
    }
}
