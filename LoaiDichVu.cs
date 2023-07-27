using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class LoaiDichVu
    {
        //Automatic properties
        public string maLoaiDichVu { get; set; } //primary key
        public string tenLoaiDichVu { get; set; }

        //Constructor
        public LoaiDichVu() { }

        public LoaiDichVu(LoaiDichVu loaiDV)
        {
            this.maLoaiDichVu = loaiDV.maLoaiDichVu;
            this.tenLoaiDichVu = loaiDV.tenLoaiDichVu;
            this.dsDichVu_Loai = loaiDV.dsDichVu_Loai;
        }

        public LoaiDichVu(string maLoaiDichVu, string tenLoaiDichVu, ICollection<DichVu> dsDV)
        {
            this.maLoaiDichVu = maLoaiDichVu;
            this.tenLoaiDichVu = tenLoaiDichVu;
            this.dsDichVu_Loai = dsDV;
        }

        //Related=plural
        public ICollection<DichVu> dsDichVu_Loai { get; set; }//danh sách dịch vụ theo loại
    }
}
