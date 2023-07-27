using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class ThietBi
    {
        //Automatic properties
        public string maThietBi { get; set; }//primary key
        public string maLoaiThietBi { get; set; }//foreign key
        public string tenThietBi { get; set; }
        public long giaThietBi { get; set; }
        public int soLuong { get; set; }
        public int thoiGianBaoHanh { get; set; }//thời hạn bảo hàng theo tháng

        //Constructor
        public ThietBi() { }

        public ThietBi(ThietBi tB)
        {
            this.maThietBi = tB.maThietBi;
            this.maLoaiThietBi = tB.maLoaiThietBi;
            this.tenThietBi = tB.tenThietBi;
            this.giaThietBi = tB.giaThietBi;
            this.soLuong = tB.soLuong;
            this.thoiGianBaoHanh = tB.thoiGianBaoHanh;
            this.LoaiTB = tB.LoaiTB;
            this.TrangB = tB.TrangB;
        }

        public ThietBi(string maThietBi, string maLoaiThietBi, string tenThietBi, long giaThietBi, int soLuong, int thoiGianBaoHanh, LoaiThietBi LTB, TrangBi TrBi)
        {
            this.maThietBi = maThietBi;
            this.maLoaiThietBi = maLoaiThietBi;
            this.tenThietBi = tenThietBi;
            this.giaThietBi = giaThietBi;
            this.soLuong = soLuong;
            this.thoiGianBaoHanh = thoiGianBaoHanh;
            this.LoaiTB = LTB;
            this.TrangB = TrBi;
        }

        //Related=singular
        public LoaiThietBi LoaiTB { get; set; }
        public TrangBi TrangB { get; set; }
    }
}
