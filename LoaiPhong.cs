using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class LoaiPhong
    {
        // khoa chinh maloaiphong
        public string maloaiphong { get; set; }
        public string tenloaiphong { get; set; }
        public int dientichphong { get; set; }// đơn vị mét vuông
        // Danh sach phong duoc xep theo tung loai phong
        public ICollection<PhongTro> dsphongtro_loai { get; set; }
        // constructor
        public LoaiPhong() { }
        public LoaiPhong(LoaiPhong loaiPhong)
        {
            this.maloaiphong = loaiPhong.maloaiphong;
            this.tenloaiphong = loaiPhong.tenloaiphong;
            this.dientichphong = loaiPhong.dientichphong;
            this.dsphongtro_loai = loaiPhong.dsphongtro_loai;
        }
        public LoaiPhong(string maloaiphong, string tenloaiphong, int dientichphong, ICollection<PhongTro> dsphongtro_loai)
        {
            this.maloaiphong = maloaiphong;
            this.tenloaiphong = tenloaiphong;
            this.dientichphong = dientichphong;
            this.dsphongtro_loai = dsphongtro_loai;
        }
    }
}
