using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class LoaiThietBi
    {
        //Automatic properties
        public string maLoaiThietBi { get; set; }//primary key
        public string tenLoaiThietBi { get; set; }

        //Constructor
        public LoaiThietBi() { }

        public LoaiThietBi(LoaiThietBi loaiTB)
        {
            this.maLoaiThietBi = loaiTB.maLoaiThietBi;
            this.tenLoaiThietBi = loaiTB.tenLoaiThietBi;
            this.dsThietBi_Loai = loaiTB.dsThietBi_Loai;
        }

        public LoaiThietBi(string maLoaiThietBi, string tenLoaiThietBi, ICollection<ThietBi> dsTB)
        {
            this.maLoaiThietBi = maLoaiThietBi;
            this.tenLoaiThietBi = tenLoaiThietBi;
            this.dsThietBi_Loai = dsTB;
        }

        //Related=plural
        public ICollection<ThietBi> dsThietBi_Loai { get; set; }//danh sách thiết bị theo loại
    }
}
