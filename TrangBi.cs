using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class TrangBi
    {
        //Automatic properties
        public string maPhongTro { get; set; }//foreign key
        //public string maThietBi { get; set; }//foreign key
        public DateTime ngayGio { get; set; }// thời điểm trang bị

        //Constructor
        public TrangBi() { }

        public TrangBi(TrangBi tBi)
        {
            this.maPhongTro = tBi.maPhongTro;
            //this.maThietBi = tBi.maThietBi;
            this.ngayGio = tBi.ngayGio;
            this.dsThietBi_TB = tBi.dsThietBi_TB;
            this.PTro = tBi.PTro;
        }

        public TrangBi(string maPhongTro, DateTime nGio, ICollection<ThietBi> dsTBi, PhongTro PTr)
        {
            this.maPhongTro = maPhongTro;
            //this.maThietBi = maThietBi;
            this.ngayGio = nGio;
            this.dsThietBi_TB = dsTBi;
            this.PTro = PTr;
        }

        //Related
        public ICollection<ThietBi> dsThietBi_TB { get; set; }//plural >> danh sách thiết bị được trang bị
        public PhongTro PTro { get; set; }//singular >> phòng trọ được trang bị
    }
}
