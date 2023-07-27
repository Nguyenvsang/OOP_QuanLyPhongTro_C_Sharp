using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{
    public class NhaTro
    {
        // khoa chinh manhatro
        public string manhatro { get; set; }
        public string tennhatro { get; set; }
        public string khuvuc { get; set; }
        // Danh sach phong tro duoc sap xep theo tung loai nha tro
        public ICollection<PhongTro> dsphongtro_nhatro { get; set; }
        // constructor
        public NhaTro() { }
        public NhaTro(NhaTro nhaTro)
        {
            this.manhatro = nhaTro.manhatro;
            this.tennhatro = nhaTro.tennhatro;
            this.khuvuc = nhaTro.khuvuc;
            this.dsphongtro_nhatro = nhaTro.dsphongtro_nhatro;
        }
        public NhaTro(string manhatro, string tennhatro, string khuvuc, ICollection<PhongTro> dsphongtro_nhatro)
        {
            this.manhatro = manhatro;
            this.tennhatro = tennhatro;
            this.khuvuc = khuvuc;
            this.dsphongtro_nhatro = dsphongtro_nhatro;
        }
    }
}
