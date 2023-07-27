using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class LoaiKH
    {
        // khoa chinh maloaiKH
        public string maloaiKH { get; set; }
        public string tenloaiKH { get; set; }
        // danh sach khach xep theo nhom loai KH
        public ICollection<Khach> dskhach_loai { get; set; }
        // constructor
        public LoaiKH() { }
        public LoaiKH(LoaiKH loaiKH)
        {
            this.maloaiKH = loaiKH.maloaiKH;
            this.tenloaiKH = loaiKH.tenloaiKH;
            this.dskhach_loai = loaiKH.dskhach_loai;
        }
        public LoaiKH(string maloaiKH,string tenloaiKH, ICollection<Khach> dskhach_loai)
        {
            this.maloaiKH = maloaiKH;
            this.tenloaiKH = tenloaiKH;
            this.dskhach_loai = dskhach_loai;
        }
    }
}
