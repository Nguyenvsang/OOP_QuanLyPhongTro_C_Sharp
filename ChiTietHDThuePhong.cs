using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class ChiTietHDThuePhong
    {
        // khoa chinh maphong, ngaygio, soHDThue
        public string maphong { get; set; }
        public DateTime ngaygiodangki { get; set; }
        public string soHDThue { get; set; }
        public string tiendatcoc { get; set; }
        public DateTime ngaydonvao { get; set; }
        public DateTime ngaydonra { get; set; }
        //
        public HopDongThuePhong hopDong { get; set; }
        public ChiTietSuDungDichVu chitietsddv { get; set; }
        // Danh sach phong tro theo chi tiet hop dong
        public ICollection<PhongTro> dsPhongTro_cthd { get; set; }
        // constructor
        public ChiTietHDThuePhong() { }
        public ChiTietHDThuePhong(ChiTietHDThuePhong ct)
        {
            this.maphong = ct.maphong;
            this.ngaygiodangki = ct.ngaygiodangki;
            this.soHDThue = ct.soHDThue;
            this.tiendatcoc = ct.tiendatcoc;
            this.ngaydonvao = ct.ngaydonvao;
            this.ngaydonra = ct.ngaydonra;
            this.hopDong = ct.hopDong;
            this.chitietsddv = ct.chitietsddv;
            this.dsPhongTro_cthd = ct.dsPhongTro_cthd;
        }
        public ChiTietHDThuePhong(string maphong, DateTime ngaygiodangki, string soHDThue, string tiendatcoc, DateTime ngaydonvao, DateTime ngaydonra, HopDongThuePhong hopDong,
            ChiTietSuDungDichVu chitietsddv, ICollection<PhongTro> dsPhongTro_cthd)
        {
            this.maphong = maphong;
            this.ngaygiodangki = ngaygiodangki;
            this.soHDThue = soHDThue;
            this.tiendatcoc = tiendatcoc;
            this.ngaydonvao = ngaydonvao;
            this.ngaydonra = ngaydonra;
            this.hopDong = hopDong;
            this.chitietsddv = chitietsddv;
            this.dsPhongTro_cthd = dsPhongTro_cthd;
        }
    }
}
