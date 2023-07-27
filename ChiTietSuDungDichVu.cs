using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class ChiTietSuDungDichVu
    {
        //Automatic properties
        public string maPhong { get; set; }//foreign key
        public DateTime ngayGioDangKi { get; set; }

        //Constructor
        public ChiTietSuDungDichVu() { }

        public ChiTietSuDungDichVu(ChiTietSuDungDichVu CTSDDV)
        {
            this.maPhong = CTSDDV.maPhong;
            this.ngayGioDangKi = CTSDDV.ngayGioDangKi;
            this.dsDichVu_ChiTiet = CTSDDV.dsDichVu_ChiTiet;
            this.CTHDThuePhong = CTSDDV.CTHDThuePhong;
        }

        public ChiTietSuDungDichVu(string maPhong, DateTime ngayGioDangKi, ICollection<DichVu> dsDichVu, ChiTietHDThuePhong CTHDTP)
        {
            this.maPhong = maPhong;
            this.ngayGioDangKi = ngayGioDangKi;
            this.dsDichVu_ChiTiet = dsDichVu;
            this.CTHDThuePhong = CTHDTP;
        }

        //Related=plural
        public ICollection<DichVu> dsDichVu_ChiTiet { get; set; }
        //Related=singular
        public ChiTietHDThuePhong CTHDThuePhong { get; set; }

    }
}
