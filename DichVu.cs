using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class DichVu
    {
        //Automatic properties
        public string maDichVu { get; set; }//primary key
        public string maLoaiDichVu { get; set; }//foreign key
        public string tenDichVu { get; set; }
        public string chiTietDichVu { get; set; }
        public long giaDichVu { get; set; }

        //Constructor
        public DichVu() { }

        public DichVu(DichVu dv)
        {
            this.maDichVu = dv.maDichVu;
            this.maLoaiDichVu = dv.maLoaiDichVu;
            this.tenDichVu = dv.tenDichVu;
            this.chiTietDichVu = dv.chiTietDichVu;
            this.giaDichVu = dv.giaDichVu;
            this.LoaiDV = dv.LoaiDV;
            this.dsChiTietSDDichVu_DV = dv.dsChiTietSDDichVu_DV;
        }

        public DichVu(string maDichVu, string maLoaiDichVu, string tenDichVu, string chiTietDichVu, long giaDichVu, LoaiDichVu LDV, ICollection<ChiTietSuDungDichVu> dsCTSDDV)
        {
            this.maDichVu = maDichVu;
            this.maLoaiDichVu = maLoaiDichVu;
            this.tenDichVu = tenDichVu;
            this.chiTietDichVu = chiTietDichVu;
            this.giaDichVu = giaDichVu;
            this.LoaiDV = LDV;
            this.dsChiTietSDDichVu_DV = dsCTSDDV;
        }

        //Related=singular
        public LoaiDichVu LoaiDV { get; set; }
        //Realated=plural
        public ICollection<ChiTietSuDungDichVu> dsChiTietSDDichVu_DV { get; set; }
    }
}
