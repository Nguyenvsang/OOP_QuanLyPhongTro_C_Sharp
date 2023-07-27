using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Tro
{   
    class Program
    {
        public static List<LoaiKH> dsLoaiKH = new List<LoaiKH>();
        public static List<Khach> dsKhach = new List<Khach>();
        public static List<NhanVien> dsNhanVien = new List<NhanVien>();
        public static List<HopDongThuePhong> dsHopDongThuePhong = new List<HopDongThuePhong>();
        public static List<ChiTietHDThuePhong> dsChiTietHDThuePhong = new List<ChiTietHDThuePhong>();

        public static List<PhongTro> ds_Phong_Tro = new List<PhongTro>();
        public static List<NhaTro> ds_Nha_Tro = new List<NhaTro>();
        public static List<LoaiPhong> ds_Loai_Phong = new List<LoaiPhong>();
        public static List<BangGia> ds_Bang_Gia = new List<BangGia>();

        public static List<LoaiThietBi> dsLoaiThietBi = new List<LoaiThietBi>();
        public static List<ThietBi> dsThietBi = new List<ThietBi>();
        public static List<LoaiDichVu> dsLoaiDichVu = new List<LoaiDichVu>();
        public static List<DichVu> dsDichVu = new List<DichVu>();
        public static List<TrangBi> dsTrangBi = new List<TrangBi>();
        public static List<ChiTietSuDungDichVu> dsChiTietSuDungDichVu = new List<ChiTietSuDungDichVu>();

        public static void TaodanhsachLoaiKH()
        {
            dsLoaiKH.Add(new LoaiKH("LKH001", "Bình dân",new List<Khach>()));
            dsLoaiKH.Add(new LoaiKH("LKH002", "Sinh viên", new List<Khach>()));
            dsLoaiKH.Add(new LoaiKH("LKH003", "Cao cấp", new List<Khach>()));
        }

        public static void TaodanhsachKhach()
        {
            dsKhach.Add(new Khach("K001", dsLoaiKH[0].maloaiKH, "Nguyễn Thị Cúc", "Nữ", new DateTime(1995, 11, 01),
                "087674859007", "Đồng Tháp", "Thợ May", dsLoaiKH[0], new List<HopDongThuePhong>()));
            dsKhach.Add(new Khach("K002", dsLoaiKH[0].maloaiKH, "Trần Thị Trang", "Nữ", new DateTime(1990, 07, 01),
                "074674839007", "Bình Dương", "Công Nhân", dsLoaiKH[0], new List<HopDongThuePhong>()));
            dsKhach.Add(new Khach("K003", dsLoaiKH[0].maloaiKH, "Nguyễn Công Tài", "Nam", new DateTime(1989, 03, 19),
                "074673744007", "Bình Dương", "Sửa xe", dsLoaiKH[0], new List<HopDongThuePhong>()));
            dsKhach.Add(new Khach("K004", dsLoaiKH[1].maloaiKH, "Phạm Tú Uyên", "Nữ", new DateTime(2001, 05, 16),
                "089123454007", "An Giang", "Sinh Viên", dsLoaiKH[1], new List<HopDongThuePhong>()));
            dsKhach.Add(new Khach("K005", dsLoaiKH[1].maloaiKH, "Phạm Trần Sơn", "Nam", new DateTime(2001, 06, 18),
                "095543214007", "Bạc Liêu", "Sinh Viên", dsLoaiKH[1], new List<HopDongThuePhong>()));
            dsKhach.Add(new Khach("K006", dsLoaiKH[1].maloaiKH, "Lý Thuận Tuấn", "Nam", new DateTime(2001, 06, 06),
                "083547894007", "Bến Tre", "Sinh Viên", dsLoaiKH[1], new List<HopDongThuePhong>()));
            dsKhach.Add(new Khach("K007", dsLoaiKH[1].maloaiKH, "Đỗ Thiên Toàn", "Nam", new DateTime(2001, 09, 03),
                "096645894007", "Cà Mau", "Sinh Viên", dsLoaiKH[1], new List<HopDongThuePhong>()));
            dsKhach.Add(new Khach("K008", dsLoaiKH[2].maloaiKH, "Lê Thị Ngọc Quỳnh", "Nữ", new DateTime(1990, 06, 22),
                "096654394007", "Cà Mau", "Nhân viên kinh doanh", dsLoaiKH[2], new List<HopDongThuePhong>()));
            dsKhach.Add(new Khach("K009", dsLoaiKH[2].maloaiKH, "Phạm Văn Long", "Nam", new DateTime(1980, 12, 11),
                "075660984007", "Đồng Nai", "Trưởng phòng marketing", dsLoaiKH[2], new List<HopDongThuePhong>()));
            dsKhach.Add(new Khach("K010", dsLoaiKH[2].maloaiKH, "Lê Hoàng Kim", "Nữ", new DateTime(1985, 12, 15),
                "075373774007", "Đồng Nai", "Luật sư", dsLoaiKH[2], new List<HopDongThuePhong>()));

            // Xác định các khách trong từng nhóm loại khách hàng
            dsLoaiKH[0].dskhach_loai.Add(dsKhach[0]);
            dsLoaiKH[0].dskhach_loai.Add(dsKhach[1]);
            dsLoaiKH[0].dskhach_loai.Add(dsKhach[2]);

            dsLoaiKH[1].dskhach_loai.Add(dsKhach[3]);
            dsLoaiKH[1].dskhach_loai.Add(dsKhach[4]);
            dsLoaiKH[1].dskhach_loai.Add(dsKhach[5]);
            dsLoaiKH[1].dskhach_loai.Add(dsKhach[6]);

            dsLoaiKH[2].dskhach_loai.Add(dsKhach[7]);
            dsLoaiKH[2].dskhach_loai.Add(dsKhach[8]);
            dsLoaiKH[2].dskhach_loai.Add(dsKhach[9]);
        }

        public static void TaodanhsachNhanVien()
        {
            dsNhanVien.Add(new NhanVien("NV001", "Nguyễn Bích Liên", "Nữ", new DateTime(1990,09,24), 
                "075673421597", "Đồng Nai", new List<HopDongThuePhong>()));
            dsNhanVien.Add(new NhanVien("NV002", "Trần Hạnh Ngân", "Nữ", new DateTime(1993,09,04),
                "096674321597", "Cà Mau", new List<HopDongThuePhong>()));
            dsNhanVien.Add(new NhanVien("NV003", "Nguyễn Thùy Linh", "Nữ", new DateTime(1989,01,06),
                "083673241597", "Bến Tre", new List<HopDongThuePhong>()));
            dsNhanVien.Add(new NhanVien("NV004", "Trần Quốc Tuấn", "Nam", new DateTime(1985,06,07),
                "087674321597", "Đồng Tháp", new List<HopDongThuePhong>()));
        }

        public static void TaodanhsachHopDongThuePhong()
        {
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT001", dsKhach[0].maKH, dsNhanVien[0].maNV, dsKhach[0], dsNhanVien[0], null));
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT002", dsKhach[1].maKH, dsNhanVien[0].maNV, dsKhach[1], dsNhanVien[0], null));
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT003", dsKhach[2].maKH, dsNhanVien[0].maNV, dsKhach[2], dsNhanVien[0], null));
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT004", dsKhach[3].maKH, dsNhanVien[1].maNV, dsKhach[3], dsNhanVien[1], null));
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT005", dsKhach[4].maKH, dsNhanVien[1].maNV, dsKhach[4], dsNhanVien[1], null));
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT006", dsKhach[5].maKH, dsNhanVien[1].maNV, dsKhach[5], dsNhanVien[1], null));
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT007", dsKhach[6].maKH, dsNhanVien[2].maNV, dsKhach[6], dsNhanVien[2], null));
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT008", dsKhach[7].maKH, dsNhanVien[2].maNV, dsKhach[7], dsNhanVien[2], null));
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT009", dsKhach[8].maKH, dsNhanVien[3].maNV, dsKhach[8], dsNhanVien[3], null));
            dsHopDongThuePhong.Add(new HopDongThuePhong("HDT010", dsKhach[9].maKH, dsNhanVien[3].maNV, dsKhach[9], dsNhanVien[3], null));

            // Xác định các hợp đồng thuê phòng theo từng khách hàng
            dsKhach[0].dshdthuephong_khach.Add(dsHopDongThuePhong[0]);
            dsKhach[1].dshdthuephong_khach.Add(dsHopDongThuePhong[1]);
            dsKhach[2].dshdthuephong_khach.Add(dsHopDongThuePhong[2]);
            dsKhach[3].dshdthuephong_khach.Add(dsHopDongThuePhong[3]);
            dsKhach[4].dshdthuephong_khach.Add(dsHopDongThuePhong[4]);
            dsKhach[5].dshdthuephong_khach.Add(dsHopDongThuePhong[5]);
            dsKhach[6].dshdthuephong_khach.Add(dsHopDongThuePhong[6]);
            dsKhach[7].dshdthuephong_khach.Add(dsHopDongThuePhong[7]);
            dsKhach[8].dshdthuephong_khach.Add(dsHopDongThuePhong[8]);
            dsKhach[9].dshdthuephong_khach.Add(dsHopDongThuePhong[9]);

            // Xác định các hợp đồng thuê phòng theo từng nhân viên
            dsNhanVien[0].dsHDTP_nhanvien.Add(dsHopDongThuePhong[0]);
            dsNhanVien[0].dsHDTP_nhanvien.Add(dsHopDongThuePhong[1]);
            dsNhanVien[0].dsHDTP_nhanvien.Add(dsHopDongThuePhong[2]);

            dsNhanVien[1].dsHDTP_nhanvien.Add(dsHopDongThuePhong[3]);
            dsNhanVien[1].dsHDTP_nhanvien.Add(dsHopDongThuePhong[4]);
            dsNhanVien[1].dsHDTP_nhanvien.Add(dsHopDongThuePhong[5]);

            dsNhanVien[2].dsHDTP_nhanvien.Add(dsHopDongThuePhong[6]);
            dsNhanVien[2].dsHDTP_nhanvien.Add(dsHopDongThuePhong[7]);

            dsNhanVien[3].dsHDTP_nhanvien.Add(dsHopDongThuePhong[8]);
            dsNhanVien[3].dsHDTP_nhanvien.Add(dsHopDongThuePhong[9]);
        }

        public static void TaoDanhSachChiTietHDThuePhong()
        {
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[0].maphong, new DateTime(2017, 07, 21, 08, 00, 00), dsHopDongThuePhong[0].soHDThue, "1000000", new DateTime(2017, 08, 21, 08, 00, 00),
                new DateTime(2022, 08, 21, 12, 00, 00), dsHopDongThuePhong[0], null, new List<PhongTro>()));
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[1].maphong, new DateTime(2018, 05, 21, 08, 00, 00), dsHopDongThuePhong[1].soHDThue, "1000000", new DateTime(2018, 06, 21, 08, 00, 00),
                new DateTime(2022, 06, 21, 12, 00, 00), dsHopDongThuePhong[1], null, new List<PhongTro>()));
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[2].maphong, new DateTime(2018, 07, 12, 08, 00, 00), dsHopDongThuePhong[2].soHDThue, "1000000", new DateTime(2018, 08, 12, 08, 00, 00),
                new DateTime(2022, 08, 12, 12, 00, 00), dsHopDongThuePhong[2], null, new List<PhongTro>()));
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[5].maphong, new DateTime(2019, 05, 29, 08, 00, 00), dsHopDongThuePhong[3].soHDThue, "1000000", new DateTime(2019, 06, 29, 08, 00, 00),
                new DateTime(2022, 06, 29, 12, 00, 00), dsHopDongThuePhong[3], null, new List<PhongTro>()));
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[6].maphong, new DateTime(2019, 06, 19, 08, 00, 00), dsHopDongThuePhong[4].soHDThue, "1000000", new DateTime(2019, 07, 19, 08, 00, 00),
                new DateTime(2022, 07, 19, 12, 00, 00), dsHopDongThuePhong[4], null, new List<PhongTro>()));
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[7].maphong, new DateTime(2019, 11, 09, 08, 00, 00), dsHopDongThuePhong[5].soHDThue, "1000000", new DateTime(2019, 12, 09, 08, 00, 00),
                new DateTime(2022, 12, 09, 12, 00, 00), dsHopDongThuePhong[5], null, new List<PhongTro>()));
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[8].maphong, new DateTime(2020, 05, 11, 08, 00, 00), dsHopDongThuePhong[6].soHDThue, "1000000", new DateTime(2020, 06, 11, 08, 00, 00),
                new DateTime(2022, 06, 11, 12, 00, 00), dsHopDongThuePhong[6], null, new List<PhongTro>()));
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[10].maphong, new DateTime(2020, 12, 15, 08, 00, 00), dsHopDongThuePhong[7].soHDThue, "1000000", new DateTime(2021, 01, 15, 08, 00, 00),
                new DateTime(2022, 01, 15, 12, 00, 00), dsHopDongThuePhong[7], null, new List<PhongTro>()));
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[11].maphong, new DateTime(2021, 05, 12, 08, 00, 00), dsHopDongThuePhong[8].soHDThue, "1000000", new DateTime(2021, 06, 12, 08, 00, 00),
                new DateTime(2022, 06, 12, 12, 00, 00), dsHopDongThuePhong[8], null, new List<PhongTro>()));
            dsChiTietHDThuePhong.Add(new ChiTietHDThuePhong(ds_Phong_Tro[12].maphong, new DateTime(2021, 08, 27, 08, 00, 00), dsHopDongThuePhong[9].soHDThue, "1000000", new DateTime(2021, 09, 27, 08, 00, 00),
                new DateTime(2022, 09, 27, 12, 00, 00), dsHopDongThuePhong[9], null, new List<PhongTro>()));

            //Gán chi tiết hợp đồng theo từng hợp đồng
            dsHopDongThuePhong[0].chitiethd = dsChiTietHDThuePhong[0];
            dsHopDongThuePhong[1].chitiethd = dsChiTietHDThuePhong[1];
            dsHopDongThuePhong[2].chitiethd = dsChiTietHDThuePhong[2];
            dsHopDongThuePhong[3].chitiethd = dsChiTietHDThuePhong[3];
            dsHopDongThuePhong[4].chitiethd = dsChiTietHDThuePhong[4];
            dsHopDongThuePhong[5].chitiethd = dsChiTietHDThuePhong[5];
            dsHopDongThuePhong[6].chitiethd = dsChiTietHDThuePhong[6];
            dsHopDongThuePhong[7].chitiethd = dsChiTietHDThuePhong[7];
            dsHopDongThuePhong[8].chitiethd = dsChiTietHDThuePhong[8];
            dsHopDongThuePhong[9].chitiethd = dsChiTietHDThuePhong[9];

            //Gán chi tiết hợp đồng theo từng phòng trọ
            ds_Phong_Tro[0].chitiethd = dsChiTietHDThuePhong[0];
            ds_Phong_Tro[1].chitiethd = dsChiTietHDThuePhong[1];
            ds_Phong_Tro[2].chitiethd = dsChiTietHDThuePhong[2];
            ds_Phong_Tro[5].chitiethd = dsChiTietHDThuePhong[3];
            ds_Phong_Tro[6].chitiethd = dsChiTietHDThuePhong[4];
            ds_Phong_Tro[7].chitiethd = dsChiTietHDThuePhong[5];
            ds_Phong_Tro[8].chitiethd = dsChiTietHDThuePhong[6];
            ds_Phong_Tro[10].chitiethd = dsChiTietHDThuePhong[7];
            ds_Phong_Tro[11].chitiethd = dsChiTietHDThuePhong[8];
            ds_Phong_Tro[12].chitiethd = dsChiTietHDThuePhong[9];

            // Danh sach phong tro theo chi tiet hop dong
            dsChiTietHDThuePhong[0].dsPhongTro_cthd.Add(ds_Phong_Tro[0]);//phong tro binh dan
            dsChiTietHDThuePhong[1].dsPhongTro_cthd.Add(ds_Phong_Tro[1]);
            dsChiTietHDThuePhong[2].dsPhongTro_cthd.Add(ds_Phong_Tro[2]);

            dsChiTietHDThuePhong[3].dsPhongTro_cthd.Add(ds_Phong_Tro[5]);//phong tro sinh vien
            dsChiTietHDThuePhong[4].dsPhongTro_cthd.Add(ds_Phong_Tro[6]);
            dsChiTietHDThuePhong[5].dsPhongTro_cthd.Add(ds_Phong_Tro[7]);
            dsChiTietHDThuePhong[6].dsPhongTro_cthd.Add(ds_Phong_Tro[8]);

            dsChiTietHDThuePhong[7].dsPhongTro_cthd.Add(ds_Phong_Tro[10]);//phong tro cao cap
            dsChiTietHDThuePhong[8].dsPhongTro_cthd.Add(ds_Phong_Tro[11]);
            dsChiTietHDThuePhong[9].dsPhongTro_cthd.Add(ds_Phong_Tro[12]);
        }

        //Tạo danh sách nhà trọ sẽ được thuê
        public static void TaoDanhSachNhaTro()
        {
            ds_Nha_Tro.Add(new NhaTro("NT01", "Cát Tường", "Quận 6", new List<PhongTro>()));
            ds_Nha_Tro.Add(new NhaTro("NT02", "Mỹ Tâm", "Quận 8", new List<PhongTro>()));
            ds_Nha_Tro.Add(new NhaTro("NT03", "Minh Khôi", "Quận 2", new List<PhongTro>()));
            ds_Nha_Tro.Add(new NhaTro("NT04", "Mai Linh", "Quận Bình Thạnh", new List<PhongTro>()));
            ds_Nha_Tro.Add(new NhaTro("NT06", "Thuận Sang", "Thành phố Thủ Đức", new List<PhongTro>()));
        }
        //Tạo danh sách loại phòng theo yêu cầu 
        public static void TaoDanhSachLoaiPhong()
        {
            ds_Loai_Phong.Add(new LoaiPhong("LP-A", "Trọ bình dân", 20, new List<PhongTro>()));
            ds_Loai_Phong.Add(new LoaiPhong("LP-B", "Trọ sinh viên", 15, new List<PhongTro>()));
            ds_Loai_Phong.Add(new LoaiPhong("LP-C", "Trọ cao cấp", 30, new List<PhongTro>()));
        }
        public static void TaoDanhSachBangGia()
        {
            ds_Bang_Gia.Add(new BangGia("BG-01", ds_Phong_Tro[0].maphong, 2500000, ds_Phong_Tro[0]));
            ds_Bang_Gia.Add(new BangGia("BG-02", ds_Phong_Tro[1].maphong, 2500000, ds_Phong_Tro[1]));
            ds_Bang_Gia.Add(new BangGia("BG-03", ds_Phong_Tro[2].maphong, 2500000, ds_Phong_Tro[2]));
            ds_Bang_Gia.Add(new BangGia("BG-04", ds_Phong_Tro[3].maphong, 2500000, ds_Phong_Tro[3]));
            ds_Bang_Gia.Add(new BangGia("BG-05", ds_Phong_Tro[4].maphong, 2500000, ds_Phong_Tro[4]));

            ds_Bang_Gia.Add(new BangGia("BG-06", ds_Phong_Tro[5].maphong, 1500000, ds_Phong_Tro[5]));
            ds_Bang_Gia.Add(new BangGia("BG-07", ds_Phong_Tro[6].maphong, 1500000, ds_Phong_Tro[6]));
            ds_Bang_Gia.Add(new BangGia("BG-08", ds_Phong_Tro[7].maphong, 1500000, ds_Phong_Tro[7]));
            ds_Bang_Gia.Add(new BangGia("BG-09", ds_Phong_Tro[8].maphong, 1500000, ds_Phong_Tro[8]));
            ds_Bang_Gia.Add(new BangGia("BG-10", ds_Phong_Tro[9].maphong, 1500000, ds_Phong_Tro[9]));

            ds_Bang_Gia.Add(new BangGia("BG-11", ds_Phong_Tro[10].maphong, 5500000, ds_Phong_Tro[10]));
            ds_Bang_Gia.Add(new BangGia("BG-12", ds_Phong_Tro[11].maphong, 5500000, ds_Phong_Tro[11]));
            ds_Bang_Gia.Add(new BangGia("BG-13", ds_Phong_Tro[12].maphong, 5500000, ds_Phong_Tro[12]));
            ds_Bang_Gia.Add(new BangGia("BG-14", ds_Phong_Tro[13].maphong, 5500000, ds_Phong_Tro[13]));
            ds_Bang_Gia.Add(new BangGia("BG-15", ds_Phong_Tro[14].maphong, 5500000, ds_Phong_Tro[14]));

            // Danh sach bang gia xep theo phong tro
            ds_Phong_Tro[0].dsbanggia_phongtro.Add(ds_Bang_Gia[0]);
            ds_Phong_Tro[1].dsbanggia_phongtro.Add(ds_Bang_Gia[1]);
            ds_Phong_Tro[2].dsbanggia_phongtro.Add(ds_Bang_Gia[2]);
            ds_Phong_Tro[3].dsbanggia_phongtro.Add(ds_Bang_Gia[3]);
            ds_Phong_Tro[4].dsbanggia_phongtro.Add(ds_Bang_Gia[4]);
            ds_Phong_Tro[5].dsbanggia_phongtro.Add(ds_Bang_Gia[5]);
            ds_Phong_Tro[6].dsbanggia_phongtro.Add(ds_Bang_Gia[6]);
            ds_Phong_Tro[7].dsbanggia_phongtro.Add(ds_Bang_Gia[7]);
            ds_Phong_Tro[8].dsbanggia_phongtro.Add(ds_Bang_Gia[8]);
            ds_Phong_Tro[9].dsbanggia_phongtro.Add(ds_Bang_Gia[9]);
            ds_Phong_Tro[10].dsbanggia_phongtro.Add(ds_Bang_Gia[10]);
            ds_Phong_Tro[11].dsbanggia_phongtro.Add(ds_Bang_Gia[11]);
            ds_Phong_Tro[12].dsbanggia_phongtro.Add(ds_Bang_Gia[12]);
            ds_Phong_Tro[13].dsbanggia_phongtro.Add(ds_Bang_Gia[13]);
            ds_Phong_Tro[14].dsbanggia_phongtro.Add(ds_Bang_Gia[14]);
        }

        //Tạo danh sách phòng trọ sẽ được thuê
        public static void TaoDanhSachPhongTro()
        {
            ds_Phong_Tro.Add(new PhongTro("S1", ds_Loai_Phong[0].maloaiphong, ds_Nha_Tro[0].manhatro, "Phòng A1", "A", ds_Loai_Phong[0], ds_Nha_Tro[0], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("S2", ds_Loai_Phong[0].maloaiphong, ds_Nha_Tro[1].manhatro, "Phòng A2", "A", ds_Loai_Phong[0], ds_Nha_Tro[1], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("S3", ds_Loai_Phong[0].maloaiphong, ds_Nha_Tro[2].manhatro, "Phòng A3", "A", ds_Loai_Phong[0], ds_Nha_Tro[2], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("S4", ds_Loai_Phong[0].maloaiphong, ds_Nha_Tro[3].manhatro, "Phòng A4", "A", ds_Loai_Phong[0], ds_Nha_Tro[3], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("S5", ds_Loai_Phong[0].maloaiphong, ds_Nha_Tro[4].manhatro, "Phòng A5", "A", ds_Loai_Phong[0], ds_Nha_Tro[4], null, null, new List<BangGia>()));

            ds_Phong_Tro.Add(new PhongTro("H1", ds_Loai_Phong[1].maloaiphong, ds_Nha_Tro[0].manhatro, "Phòng B1", "B", ds_Loai_Phong[1], ds_Nha_Tro[0], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("H2", ds_Loai_Phong[1].maloaiphong, ds_Nha_Tro[1].manhatro, "Phòng B2", "B", ds_Loai_Phong[1], ds_Nha_Tro[1], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("H3", ds_Loai_Phong[1].maloaiphong, ds_Nha_Tro[2].manhatro, "Phòng B3", "B", ds_Loai_Phong[1], ds_Nha_Tro[2], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("H4", ds_Loai_Phong[1].maloaiphong, ds_Nha_Tro[3].manhatro, "Phòng B4", "B", ds_Loai_Phong[1], ds_Nha_Tro[3], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("H5", ds_Loai_Phong[1].maloaiphong, ds_Nha_Tro[4].manhatro, "Phòng B5", "B", ds_Loai_Phong[1], ds_Nha_Tro[4], null, null, new List<BangGia>()));

            ds_Phong_Tro.Add(new PhongTro("T1", ds_Loai_Phong[2].maloaiphong, ds_Nha_Tro[0].manhatro, "Phòng C1", "C", ds_Loai_Phong[2], ds_Nha_Tro[0], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("T2", ds_Loai_Phong[2].maloaiphong, ds_Nha_Tro[1].manhatro, "Phòng C2", "C", ds_Loai_Phong[2], ds_Nha_Tro[1], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("T3", ds_Loai_Phong[2].maloaiphong, ds_Nha_Tro[2].manhatro, "Phòng C3", "C", ds_Loai_Phong[2], ds_Nha_Tro[2], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("T4", ds_Loai_Phong[2].maloaiphong, ds_Nha_Tro[3].manhatro, "Phòng C4", "C", ds_Loai_Phong[2], ds_Nha_Tro[3], null, null, new List<BangGia>()));
            ds_Phong_Tro.Add(new PhongTro("T5", ds_Loai_Phong[2].maloaiphong, ds_Nha_Tro[4].manhatro, "Phòng C5", "C", ds_Loai_Phong[2], ds_Nha_Tro[4], null, null, new List<BangGia>()));

            // Danh sach phong tro duoc sap xep theo tung nha tro
            ds_Nha_Tro[0].dsphongtro_nhatro.Add(ds_Phong_Tro[0]);
            ds_Nha_Tro[0].dsphongtro_nhatro.Add(ds_Phong_Tro[5]);
            ds_Nha_Tro[0].dsphongtro_nhatro.Add(ds_Phong_Tro[10]);

            ds_Nha_Tro[1].dsphongtro_nhatro.Add(ds_Phong_Tro[1]);
            ds_Nha_Tro[1].dsphongtro_nhatro.Add(ds_Phong_Tro[6]);
            ds_Nha_Tro[1].dsphongtro_nhatro.Add(ds_Phong_Tro[11]);

            ds_Nha_Tro[2].dsphongtro_nhatro.Add(ds_Phong_Tro[2]);
            ds_Nha_Tro[2].dsphongtro_nhatro.Add(ds_Phong_Tro[7]);
            ds_Nha_Tro[2].dsphongtro_nhatro.Add(ds_Phong_Tro[12]);

            ds_Nha_Tro[3].dsphongtro_nhatro.Add(ds_Phong_Tro[3]);
            ds_Nha_Tro[3].dsphongtro_nhatro.Add(ds_Phong_Tro[8]);
            ds_Nha_Tro[3].dsphongtro_nhatro.Add(ds_Phong_Tro[13]);

            ds_Nha_Tro[4].dsphongtro_nhatro.Add(ds_Phong_Tro[4]);
            ds_Nha_Tro[4].dsphongtro_nhatro.Add(ds_Phong_Tro[9]);
            ds_Nha_Tro[4].dsphongtro_nhatro.Add(ds_Phong_Tro[14]);

            // Danh sach phong duoc xep theo tung loai phong
            ds_Loai_Phong[0].dsphongtro_loai.Add(ds_Phong_Tro[0]);
            ds_Loai_Phong[0].dsphongtro_loai.Add(ds_Phong_Tro[1]);
            ds_Loai_Phong[0].dsphongtro_loai.Add(ds_Phong_Tro[2]);
            ds_Loai_Phong[0].dsphongtro_loai.Add(ds_Phong_Tro[3]);
            ds_Loai_Phong[0].dsphongtro_loai.Add(ds_Phong_Tro[4]);

            ds_Loai_Phong[1].dsphongtro_loai.Add(ds_Phong_Tro[5]);
            ds_Loai_Phong[1].dsphongtro_loai.Add(ds_Phong_Tro[6]);
            ds_Loai_Phong[1].dsphongtro_loai.Add(ds_Phong_Tro[7]);
            ds_Loai_Phong[1].dsphongtro_loai.Add(ds_Phong_Tro[8]);
            ds_Loai_Phong[1].dsphongtro_loai.Add(ds_Phong_Tro[9]);

            ds_Loai_Phong[2].dsphongtro_loai.Add(ds_Phong_Tro[10]);
            ds_Loai_Phong[2].dsphongtro_loai.Add(ds_Phong_Tro[11]);
            ds_Loai_Phong[2].dsphongtro_loai.Add(ds_Phong_Tro[12]);
            ds_Loai_Phong[2].dsphongtro_loai.Add(ds_Phong_Tro[13]);
            ds_Loai_Phong[2].dsphongtro_loai.Add(ds_Phong_Tro[14]);
 
        }

        public static void TaoDanhSachLoaiThietBi()
        {
            dsLoaiThietBi.Add(new LoaiThietBi("LTB01", "Thiết bị điện, điện tử", new List<ThietBi>()));
            dsLoaiThietBi.Add(new LoaiThietBi("LTB02", "Thiết bị gia dụng bếp", new List<ThietBi>()));
            dsLoaiThietBi.Add(new LoaiThietBi("LTB03", "Thiết bị nội thất", new List<ThietBi>()));
        }

        public static void TaoDanhSachThietBi()
        {
            dsThietBi.Add(new ThietBi("TB001", dsLoaiThietBi[0].maLoaiThietBi, "Quạt trần KDX", 1350000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB002", dsLoaiThietBi[0].maLoaiThietBi, "Quạt trần KDX", 1350000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB003", dsLoaiThietBi[0].maLoaiThietBi, "Quạt trần KDX", 1350000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB004", dsLoaiThietBi[0].maLoaiThietBi, "Quạt trần KDX", 1350000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB005", dsLoaiThietBi[0].maLoaiThietBi, "Quạt trần KDX", 1350000, 1, 12, dsLoaiThietBi[0], null));

            dsThietBi.Add(new ThietBi("TB006", dsLoaiThietBi[0].maLoaiThietBi, "Quạt đứng Sharp", 999000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB007", dsLoaiThietBi[0].maLoaiThietBi, "Quạt đứng Sharp", 999000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB008", dsLoaiThietBi[0].maLoaiThietBi, "Quạt đứng Sharp", 999000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB009", dsLoaiThietBi[0].maLoaiThietBi, "Quạt đứng Sharp", 999000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB010", dsLoaiThietBi[0].maLoaiThietBi, "Quạt đứng Sharp", 999000, 1, 12, dsLoaiThietBi[0], null));

            dsThietBi.Add(new ThietBi("TB011", dsLoaiThietBi[0].maLoaiThietBi, "Smart TV Samsung", 14190000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB012", dsLoaiThietBi[0].maLoaiThietBi, "Smart TV Samsung", 14190000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB013", dsLoaiThietBi[0].maLoaiThietBi, "Smart TV Samsung", 14190000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB014", dsLoaiThietBi[0].maLoaiThietBi, "Smart TV Samsung", 14190000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB015", dsLoaiThietBi[0].maLoaiThietBi, "Smart TV Samsung", 14190000, 1, 24, dsLoaiThietBi[0], null));

            dsThietBi.Add(new ThietBi("TB016", dsLoaiThietBi[0].maLoaiThietBi, "TV LED DARKLING", 3066000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB017", dsLoaiThietBi[0].maLoaiThietBi, "TV LED DARKLING", 3066000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB018", dsLoaiThietBi[0].maLoaiThietBi, "TV LED DARKLING", 3066000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB019", dsLoaiThietBi[0].maLoaiThietBi, "TV LED DARKLING", 3066000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB020", dsLoaiThietBi[0].maLoaiThietBi, "TV LED DARKLING", 3066000, 1, 24, dsLoaiThietBi[0], null));

            dsThietBi.Add(new ThietBi("TB021", dsLoaiThietBi[0].maLoaiThietBi, "Máy lạnh AQUA Inverter", 9990000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB022", dsLoaiThietBi[0].maLoaiThietBi, "Máy lạnh AQUA Inverter", 9990000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB023", dsLoaiThietBi[0].maLoaiThietBi, "Máy lạnh AQUA Inverter", 9990000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB024", dsLoaiThietBi[0].maLoaiThietBi, "Máy lạnh AQUA Inverter", 9990000, 1, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB025", dsLoaiThietBi[0].maLoaiThietBi, "Máy lạnh AQUA Inverter", 9990000, 1, 12, dsLoaiThietBi[0], null));

            dsThietBi.Add(new ThietBi("TB026", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 3, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB027", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 3, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB028", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 3, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB029", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 3, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB030", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 3, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB031", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 2, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB032", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 2, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB033", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 2, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB034", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 2, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB035", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 2, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB036", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 4, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB037", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 4, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB038", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 4, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB039", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 4, 12, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB040", dsLoaiThietBi[0].maLoaiThietBi, "Đèn huỳnh quang DDROYAL ", 390000, 4, 12, dsLoaiThietBi[0], null));

            dsThietBi.Add(new ThietBi("TB041", dsLoaiThietBi[0].maLoaiThietBi, "Máy giặt AQUA", 3790000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB042", dsLoaiThietBi[0].maLoaiThietBi, "Máy giặt AQUA", 3790000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB043", dsLoaiThietBi[0].maLoaiThietBi, "Máy giặt AQUA", 3790000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB044", dsLoaiThietBi[0].maLoaiThietBi, "Máy giặt AQUA", 3790000, 1, 24, dsLoaiThietBi[0], null));
            dsThietBi.Add(new ThietBi("TB045", dsLoaiThietBi[0].maLoaiThietBi, "Máy giặt AQUA", 3790000, 1, 24, dsLoaiThietBi[0], null));

            dsThietBi.Add(new ThietBi("TB046", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đôi Sunhouse", 509000, 1, 12, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB047", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đôi Sunhouse", 509000, 1, 12, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB048", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đôi Sunhouse", 509000, 1, 12, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB049", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đôi Sunhouse", 509000, 1, 12, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB050", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đôi Sunhouse", 509000, 1, 12, dsLoaiThietBi[1], null));

            dsThietBi.Add(new ThietBi("TB051", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đơn Kiwa", 350000, 1, 24, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB052", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đơn Kiwa", 350000, 1, 24, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB053", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đơn Kiwa", 350000, 1, 24, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB054", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đơn Kiwa", 350000, 1, 24, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB055", dsLoaiThietBi[1].maLoaiThietBi, "Bếp ga đơn Kiwa", 350000, 1, 24, dsLoaiThietBi[1], null));

            dsThietBi.Add(new ThietBi("TB056", dsLoaiThietBi[1].maLoaiThietBi, "Bếp hồng ngoại Sunhouse", 3663000, 1, 36, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB057", dsLoaiThietBi[1].maLoaiThietBi, "Bếp hồng ngoại Sunhouse", 3663000, 1, 36, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB058", dsLoaiThietBi[1].maLoaiThietBi, "Bếp hồng ngoại Sunhouse", 3663000, 1, 36, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB059", dsLoaiThietBi[1].maLoaiThietBi, "Bếp hồng ngoại Sunhouse", 3663000, 1, 36, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB060", dsLoaiThietBi[1].maLoaiThietBi, "Bếp hồng ngoại Sunhouse", 3663000, 1, 36, dsLoaiThietBi[1], null));

            dsThietBi.Add(new ThietBi("TB061", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh AQUA 90L", 2990000, 1, 24, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB062", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh AQUA 90L", 2990000, 1, 24, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB063", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh AQUA 90L", 2990000, 1, 24, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB064", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh AQUA 90L", 2990000, 1, 24, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB065", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh AQUA 90L", 2990000, 1, 24, dsLoaiThietBi[1], null));

            dsThietBi.Add(new ThietBi("TB066", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh Sharp Inverter 150L", 4790000, 1, 12, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB067", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh Sharp Inverter 150L", 4790000, 1, 12, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB068", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh Sharp Inverter 150L", 4790000, 1, 12, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB069", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh Sharp Inverter 150L", 4790000, 1, 12, dsLoaiThietBi[1], null));
            dsThietBi.Add(new ThietBi("TB070", dsLoaiThietBi[1].maLoaiThietBi, "Tủ lạnh Sharp Inverter 150L", 4790000, 1, 12, dsLoaiThietBi[1], null));

            dsThietBi.Add(new ThietBi("TB071", dsLoaiThietBi[2].maLoaiThietBi, "Nệm bông ép", 585000, 2, 60, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB072", dsLoaiThietBi[2].maLoaiThietBi, "Nệm bông ép", 585000, 2, 60, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB073", dsLoaiThietBi[2].maLoaiThietBi, "Nệm bông ép", 585000, 2, 60, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB074", dsLoaiThietBi[2].maLoaiThietBi, "Nệm bông ép", 585000, 2, 60, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB075", dsLoaiThietBi[2].maLoaiThietBi, "Nệm bông ép", 585000, 2, 60, dsLoaiThietBi[2], null));
        
            dsThietBi.Add(new ThietBi("TB076", dsLoaiThietBi[2].maLoaiThietBi, "Giường gỗ", 3470000, 1, 12, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB077", dsLoaiThietBi[2].maLoaiThietBi, "Giường gỗ", 3470000, 1, 12, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB078", dsLoaiThietBi[2].maLoaiThietBi, "Giường gỗ", 3470000, 1, 12, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB079", dsLoaiThietBi[2].maLoaiThietBi, "Giường gỗ", 3470000, 1, 12, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB080", dsLoaiThietBi[2].maLoaiThietBi, "Giường gỗ", 3470000, 1, 12, dsLoaiThietBi[2], null));

            dsThietBi.Add(new ThietBi("TB081", dsLoaiThietBi[2].maLoaiThietBi, "Giường sắt đơn", 850000, 1, 12, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB082", dsLoaiThietBi[2].maLoaiThietBi, "Giường sắt đơn", 850000, 1, 12, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB083", dsLoaiThietBi[2].maLoaiThietBi, "Giường sắt đơn", 850000, 1, 12, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB084", dsLoaiThietBi[2].maLoaiThietBi, "Giường sắt đơn", 850000, 1, 12, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB085", dsLoaiThietBi[2].maLoaiThietBi, "Giường sắt đơn", 850000, 1, 12, dsLoaiThietBi[2], null));

            dsThietBi.Add(new ThietBi("TB086", dsLoaiThietBi[2].maLoaiThietBi, "Kệ sách gỗ", 699000, 1, 24, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB087", dsLoaiThietBi[2].maLoaiThietBi, "Kệ sách gỗ", 699000, 1, 24, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB088", dsLoaiThietBi[2].maLoaiThietBi, "Kệ sách gỗ", 699000, 1, 24, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB089", dsLoaiThietBi[2].maLoaiThietBi, "Kệ sách gỗ", 699000, 1, 24, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB090", dsLoaiThietBi[2].maLoaiThietBi, "Kệ sách gỗ", 699000, 1, 24, dsLoaiThietBi[2], null));

            dsThietBi.Add(new ThietBi("TB091", dsLoaiThietBi[2].maLoaiThietBi, "Tủ sắt quần áo", 700000, 1, 0, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB092", dsLoaiThietBi[2].maLoaiThietBi, "Tủ sắt quần áo", 700000, 1, 0, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB093", dsLoaiThietBi[2].maLoaiThietBi, "Tủ sắt quần áo", 700000, 1, 0, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB094", dsLoaiThietBi[2].maLoaiThietBi, "Tủ sắt quần áo", 700000, 1, 0, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB095", dsLoaiThietBi[2].maLoaiThietBi, "Tủ sắt quần áo", 700000, 1, 0, dsLoaiThietBi[2], null));

            dsThietBi.Add(new ThietBi("TB096", dsLoaiThietBi[2].maLoaiThietBi, "Tủ gỗ quần áo", 1700000, 1, 24, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB097", dsLoaiThietBi[2].maLoaiThietBi, "Tủ gỗ quần áo", 1700000, 1, 24, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB098", dsLoaiThietBi[2].maLoaiThietBi, "Tủ gỗ quần áo", 1700000, 1, 24, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB099", dsLoaiThietBi[2].maLoaiThietBi, "Tủ gỗ quần áo", 1700000, 1, 24, dsLoaiThietBi[2], null));
            dsThietBi.Add(new ThietBi("TB100", dsLoaiThietBi[2].maLoaiThietBi, "Tủ gỗ quần áo", 1700000, 1, 24, dsLoaiThietBi[2], null));

            
            //Thêm danh sách thiết bị vào loại thiết bị
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[0]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[1]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[2]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[3]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[4]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[5]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[6]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[7]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[8]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[9]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[10]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[11]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[12]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[13]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[14]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[15]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[16]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[17]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[18]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[19]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[20]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[21]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[22]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[23]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[24]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[25]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[26]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[27]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[28]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[29]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[30]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[31]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[32]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[33]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[34]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[35]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[36]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[37]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[38]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[39]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[40]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[41]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[42]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[43]);
            dsLoaiThietBi[0].dsThietBi_Loai.Add(dsThietBi[44]);

            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[45]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[46]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[47]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[48]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[49]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[50]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[51]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[52]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[53]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[54]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[55]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[56]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[57]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[58]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[59]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[60]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[61]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[62]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[63]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[64]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[65]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[66]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[67]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[68]);
            dsLoaiThietBi[1].dsThietBi_Loai.Add(dsThietBi[69]);

            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[70]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[71]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[72]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[73]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[74]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[75]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[76]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[77]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[78]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[79]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[80]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[81]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[82]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[83]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[84]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[85]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[86]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[87]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[88]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[89]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[90]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[91]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[92]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[93]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[94]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[95]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[96]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[97]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[98]);
            dsLoaiThietBi[2].dsThietBi_Loai.Add(dsThietBi[99]);
        }
        public static void TaoDanhSachLoaiDichVu()
        {
            dsLoaiDichVu.Add(new LoaiDichVu("LDV01", "Vệ sinh", new List<DichVu>()));//tính tổng theo tháng
            dsLoaiDichVu.Add(new LoaiDichVu("LDV01", "Bảo trì", new List<DichVu>()));
        }

        public static void TaoDanhSachDichVu()
        {
            dsDichVu.Add(new DichVu("DV01", dsLoaiDichVu[0].maLoaiDichVu, "Dọn dẹp", "Mỗi tuần một lần, theo giờ", 30000, dsLoaiDichVu[0], new List<ChiTietSuDungDichVu>()));
            dsDichVu.Add(new DichVu("DV02", dsLoaiDichVu[0].maLoaiDichVu, "Vứt rác", "Mỗi ngày, theo tháng", 10000, dsLoaiDichVu[0], new List<ChiTietSuDungDichVu>()));
            dsDichVu.Add(new DichVu("DV03", dsLoaiDichVu[0].maLoaiDichVu, "Giặt quần áo ướt", "Mỗi ngày, trung bình theo kg", 5000, dsLoaiDichVu[0], new List<ChiTietSuDungDichVu>()));
            dsDichVu.Add(new DichVu("DV04", dsLoaiDichVu[0].maLoaiDichVu, "Giặt quần áo sấy khô", "Mỗi ngày, trung bình theo kg", 12000, dsLoaiDichVu[0], new List<ChiTietSuDungDichVu>()));
            dsDichVu.Add(new DichVu("DV05", dsLoaiDichVu[0].maLoaiDichVu, "Vệ sinh ống cống", "Mỗi năm", 100000, dsLoaiDichVu[0], new List<ChiTietSuDungDichVu>()));
            dsDichVu.Add(new DichVu("DV06", dsLoaiDichVu[1].maLoaiDichVu, "Bảo trì thiết bị điện", "Mỗi nửa năm", 200000, dsLoaiDichVu[1], new List<ChiTietSuDungDichVu>()));

            //Thêm danh sách dịch vụ vào loại dịch vụ
            dsLoaiDichVu[0].dsDichVu_Loai.Add(dsDichVu[0]);
            dsLoaiDichVu[0].dsDichVu_Loai.Add(dsDichVu[1]);
            dsLoaiDichVu[0].dsDichVu_Loai.Add(dsDichVu[2]);
            dsLoaiDichVu[0].dsDichVu_Loai.Add(dsDichVu[3]);
            dsLoaiDichVu[0].dsDichVu_Loai.Add(dsDichVu[4]);

            dsLoaiDichVu[1].dsDichVu_Loai.Add(dsDichVu[5]);

            
        }
        
        public static void TaoDanhSachTrangBi()
        {
            // Trang bi cho phong tro binh dan
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[0].maphong, new DateTime(2017,03,01), new List<ThietBi>(), ds_Phong_Tro[0]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[1].maphong, new DateTime(2017,03,02), new List<ThietBi>(), ds_Phong_Tro[1]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[2].maphong, new DateTime(2017,03,03), new List<ThietBi>(), ds_Phong_Tro[2]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[3].maphong, new DateTime(2017,03,04), new List<ThietBi>(), ds_Phong_Tro[3]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[4].maphong, new DateTime(2017,03,05), new List<ThietBi>(), ds_Phong_Tro[4]));
            // Trang bi cho phong tro sinh vien
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[5].maphong, new DateTime(2017, 04, 06), new List<ThietBi>(), ds_Phong_Tro[5]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[6].maphong, new DateTime(2017, 04, 07), new List<ThietBi>(), ds_Phong_Tro[6]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[7].maphong, new DateTime(2017, 04, 08), new List<ThietBi>(), ds_Phong_Tro[7]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[8].maphong, new DateTime(2017, 04, 09), new List<ThietBi>(), ds_Phong_Tro[8]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[9].maphong, new DateTime(2017, 04, 10), new List<ThietBi>(), ds_Phong_Tro[9]));
            // Trang bi cho phong tro cao cap
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[10].maphong, new DateTime(2017, 04, 11), new List<ThietBi>(), ds_Phong_Tro[10]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[11].maphong, new DateTime(2017, 04, 12), new List<ThietBi>(), ds_Phong_Tro[11]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[12].maphong, new DateTime(2017, 04, 13), new List<ThietBi>(), ds_Phong_Tro[12]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[13].maphong, new DateTime(2017, 04, 14), new List<ThietBi>(), ds_Phong_Tro[13]));
            dsTrangBi.Add(new TrangBi(ds_Phong_Tro[14].maphong, new DateTime(2017, 04, 15), new List<ThietBi>(), ds_Phong_Tro[14]));

            //Thêm danh sách thiết bị vào trang bị
            //Trọ gia đình bình dân
            dsTrangBi[0].dsThietBi_TB.Add(dsThietBi[5]);
            dsTrangBi[0].dsThietBi_TB.Add(dsThietBi[15]);
            dsTrangBi[0].dsThietBi_TB.Add(dsThietBi[25]);
            dsTrangBi[0].dsThietBi_TB.Add(dsThietBi[45]);
            dsTrangBi[0].dsThietBi_TB.Add(dsThietBi[60]);
            dsTrangBi[0].dsThietBi_TB.Add(dsThietBi[70]);
            dsTrangBi[0].dsThietBi_TB.Add(dsThietBi[90]);

            dsTrangBi[1].dsThietBi_TB.Add(dsThietBi[6]);
            dsTrangBi[1].dsThietBi_TB.Add(dsThietBi[16]);
            dsTrangBi[1].dsThietBi_TB.Add(dsThietBi[26]);
            dsTrangBi[1].dsThietBi_TB.Add(dsThietBi[46]);
            dsTrangBi[1].dsThietBi_TB.Add(dsThietBi[61]);
            dsTrangBi[1].dsThietBi_TB.Add(dsThietBi[71]);
            dsTrangBi[1].dsThietBi_TB.Add(dsThietBi[91]);

            dsTrangBi[2].dsThietBi_TB.Add(dsThietBi[7]);
            dsTrangBi[2].dsThietBi_TB.Add(dsThietBi[17]);
            dsTrangBi[2].dsThietBi_TB.Add(dsThietBi[27]);
            dsTrangBi[2].dsThietBi_TB.Add(dsThietBi[47]);
            dsTrangBi[2].dsThietBi_TB.Add(dsThietBi[62]);
            dsTrangBi[2].dsThietBi_TB.Add(dsThietBi[72]);
            dsTrangBi[2].dsThietBi_TB.Add(dsThietBi[92]);

            dsTrangBi[3].dsThietBi_TB.Add(dsThietBi[8]);
            dsTrangBi[3].dsThietBi_TB.Add(dsThietBi[18]);
            dsTrangBi[3].dsThietBi_TB.Add(dsThietBi[28]);
            dsTrangBi[3].dsThietBi_TB.Add(dsThietBi[48]);
            dsTrangBi[3].dsThietBi_TB.Add(dsThietBi[63]);
            dsTrangBi[3].dsThietBi_TB.Add(dsThietBi[73]);
            dsTrangBi[3].dsThietBi_TB.Add(dsThietBi[93]);

            dsTrangBi[4].dsThietBi_TB.Add(dsThietBi[9]);
            dsTrangBi[4].dsThietBi_TB.Add(dsThietBi[19]);
            dsTrangBi[4].dsThietBi_TB.Add(dsThietBi[29]);
            dsTrangBi[4].dsThietBi_TB.Add(dsThietBi[49]);
            dsTrangBi[4].dsThietBi_TB.Add(dsThietBi[64]);
            dsTrangBi[4].dsThietBi_TB.Add(dsThietBi[74]);
            dsTrangBi[4].dsThietBi_TB.Add(dsThietBi[94]);

            //Trọ sinh viên
            dsTrangBi[5].dsThietBi_TB.Add(dsThietBi[0]);
            dsTrangBi[5].dsThietBi_TB.Add(dsThietBi[30]);
            dsTrangBi[5].dsThietBi_TB.Add(dsThietBi[50]);
            dsTrangBi[5].dsThietBi_TB.Add(dsThietBi[80]);
            dsTrangBi[5].dsThietBi_TB.Add(dsThietBi[85]);

            dsTrangBi[6].dsThietBi_TB.Add(dsThietBi[1]);
            dsTrangBi[6].dsThietBi_TB.Add(dsThietBi[31]);
            dsTrangBi[6].dsThietBi_TB.Add(dsThietBi[51]);
            dsTrangBi[6].dsThietBi_TB.Add(dsThietBi[81]);
            dsTrangBi[6].dsThietBi_TB.Add(dsThietBi[86]);

            dsTrangBi[7].dsThietBi_TB.Add(dsThietBi[2]);
            dsTrangBi[7].dsThietBi_TB.Add(dsThietBi[32]);
            dsTrangBi[7].dsThietBi_TB.Add(dsThietBi[52]);
            dsTrangBi[7].dsThietBi_TB.Add(dsThietBi[82]);
            dsTrangBi[7].dsThietBi_TB.Add(dsThietBi[87]);

            dsTrangBi[8].dsThietBi_TB.Add(dsThietBi[3]);
            dsTrangBi[8].dsThietBi_TB.Add(dsThietBi[33]);
            dsTrangBi[8].dsThietBi_TB.Add(dsThietBi[53]);
            dsTrangBi[8].dsThietBi_TB.Add(dsThietBi[83]);
            dsTrangBi[8].dsThietBi_TB.Add(dsThietBi[88]);

            dsTrangBi[9].dsThietBi_TB.Add(dsThietBi[4]);
            dsTrangBi[9].dsThietBi_TB.Add(dsThietBi[34]);
            dsTrangBi[9].dsThietBi_TB.Add(dsThietBi[54]);
            dsTrangBi[9].dsThietBi_TB.Add(dsThietBi[84]);
            dsTrangBi[9].dsThietBi_TB.Add(dsThietBi[89]);

            //Trọ cao cấp
            dsTrangBi[10].dsThietBi_TB.Add(dsThietBi[10]);
            dsTrangBi[10].dsThietBi_TB.Add(dsThietBi[20]);
            dsTrangBi[10].dsThietBi_TB.Add(dsThietBi[35]);
            dsTrangBi[10].dsThietBi_TB.Add(dsThietBi[40]);
            dsTrangBi[10].dsThietBi_TB.Add(dsThietBi[55]);
            dsTrangBi[10].dsThietBi_TB.Add(dsThietBi[65]);
            dsTrangBi[10].dsThietBi_TB.Add(dsThietBi[75]);
            dsTrangBi[10].dsThietBi_TB.Add(dsThietBi[95]);

            dsTrangBi[11].dsThietBi_TB.Add(dsThietBi[11]);
            dsTrangBi[11].dsThietBi_TB.Add(dsThietBi[21]);
            dsTrangBi[11].dsThietBi_TB.Add(dsThietBi[36]);
            dsTrangBi[11].dsThietBi_TB.Add(dsThietBi[41]);
            dsTrangBi[11].dsThietBi_TB.Add(dsThietBi[56]);
            dsTrangBi[11].dsThietBi_TB.Add(dsThietBi[66]);
            dsTrangBi[11].dsThietBi_TB.Add(dsThietBi[76]);
            dsTrangBi[11].dsThietBi_TB.Add(dsThietBi[96]);

            dsTrangBi[12].dsThietBi_TB.Add(dsThietBi[12]);
            dsTrangBi[12].dsThietBi_TB.Add(dsThietBi[22]);
            dsTrangBi[12].dsThietBi_TB.Add(dsThietBi[37]);
            dsTrangBi[12].dsThietBi_TB.Add(dsThietBi[42]);
            dsTrangBi[12].dsThietBi_TB.Add(dsThietBi[57]);
            dsTrangBi[12].dsThietBi_TB.Add(dsThietBi[67]);
            dsTrangBi[12].dsThietBi_TB.Add(dsThietBi[77]);
            dsTrangBi[12].dsThietBi_TB.Add(dsThietBi[97]);

            dsTrangBi[13].dsThietBi_TB.Add(dsThietBi[13]);
            dsTrangBi[13].dsThietBi_TB.Add(dsThietBi[23]);
            dsTrangBi[13].dsThietBi_TB.Add(dsThietBi[38]);
            dsTrangBi[13].dsThietBi_TB.Add(dsThietBi[43]);
            dsTrangBi[13].dsThietBi_TB.Add(dsThietBi[58]);
            dsTrangBi[13].dsThietBi_TB.Add(dsThietBi[68]);
            dsTrangBi[13].dsThietBi_TB.Add(dsThietBi[78]);
            dsTrangBi[13].dsThietBi_TB.Add(dsThietBi[98]);

            dsTrangBi[14].dsThietBi_TB.Add(dsThietBi[14]);
            dsTrangBi[14].dsThietBi_TB.Add(dsThietBi[24]);
            dsTrangBi[14].dsThietBi_TB.Add(dsThietBi[39]);
            dsTrangBi[14].dsThietBi_TB.Add(dsThietBi[44]);
            dsTrangBi[14].dsThietBi_TB.Add(dsThietBi[59]);
            dsTrangBi[14].dsThietBi_TB.Add(dsThietBi[69]);
            dsTrangBi[14].dsThietBi_TB.Add(dsThietBi[79]);
            dsTrangBi[14].dsThietBi_TB.Add(dsThietBi[99]);

            //Gán trang bị cho từng thiết bị
            dsThietBi[5].TrangB = dsTrangBi[0];
            dsThietBi[15].TrangB = dsTrangBi[0];
            dsThietBi[25].TrangB = dsTrangBi[0];
            dsThietBi[45].TrangB = dsTrangBi[0];
            dsThietBi[60].TrangB = dsTrangBi[0];
            dsThietBi[70].TrangB = dsTrangBi[0];
            dsThietBi[90].TrangB = dsTrangBi[0];

            dsThietBi[6].TrangB = dsTrangBi[1];
            dsThietBi[16].TrangB = dsTrangBi[1];
            dsThietBi[26].TrangB = dsTrangBi[1];
            dsThietBi[46].TrangB = dsTrangBi[1];
            dsThietBi[61].TrangB = dsTrangBi[1];
            dsThietBi[71].TrangB = dsTrangBi[1];
            dsThietBi[91].TrangB = dsTrangBi[1];

            dsThietBi[7].TrangB = dsTrangBi[2];
            dsThietBi[17].TrangB = dsTrangBi[2];
            dsThietBi[27].TrangB = dsTrangBi[2];
            dsThietBi[47].TrangB = dsTrangBi[2];
            dsThietBi[62].TrangB = dsTrangBi[2];
            dsThietBi[72].TrangB = dsTrangBi[2];
            dsThietBi[92].TrangB = dsTrangBi[2];

            dsThietBi[8].TrangB = dsTrangBi[3];
            dsThietBi[18].TrangB = dsTrangBi[3];
            dsThietBi[28].TrangB = dsTrangBi[3];
            dsThietBi[48].TrangB = dsTrangBi[3];
            dsThietBi[63].TrangB = dsTrangBi[3];
            dsThietBi[73].TrangB = dsTrangBi[3];
            dsThietBi[93].TrangB = dsTrangBi[3];

            dsThietBi[9].TrangB = dsTrangBi[4];
            dsThietBi[19].TrangB = dsTrangBi[4];
            dsThietBi[29].TrangB = dsTrangBi[4];
            dsThietBi[49].TrangB = dsTrangBi[4];
            dsThietBi[64].TrangB = dsTrangBi[4];
            dsThietBi[74].TrangB = dsTrangBi[4];
            dsThietBi[94].TrangB = dsTrangBi[4];

            dsThietBi[0].TrangB = dsTrangBi[5];
            dsThietBi[30].TrangB = dsTrangBi[5];
            dsThietBi[50].TrangB = dsTrangBi[5];
            dsThietBi[80].TrangB = dsTrangBi[5];
            dsThietBi[85].TrangB = dsTrangBi[5];

            dsThietBi[1].TrangB = dsTrangBi[6];
            dsThietBi[31].TrangB = dsTrangBi[6];
            dsThietBi[51].TrangB = dsTrangBi[6];
            dsThietBi[81].TrangB = dsTrangBi[6];
            dsThietBi[86].TrangB = dsTrangBi[6];

            dsThietBi[2].TrangB = dsTrangBi[7];
            dsThietBi[32].TrangB = dsTrangBi[7];
            dsThietBi[52].TrangB = dsTrangBi[7];
            dsThietBi[82].TrangB = dsTrangBi[7];
            dsThietBi[87].TrangB = dsTrangBi[7];

            dsThietBi[3].TrangB = dsTrangBi[8];
            dsThietBi[33].TrangB = dsTrangBi[8];
            dsThietBi[53].TrangB = dsTrangBi[8];
            dsThietBi[83].TrangB = dsTrangBi[8];
            dsThietBi[88].TrangB = dsTrangBi[8];

            dsThietBi[4].TrangB = dsTrangBi[9];
            dsThietBi[34].TrangB = dsTrangBi[9];
            dsThietBi[54].TrangB = dsTrangBi[9];
            dsThietBi[84].TrangB = dsTrangBi[9];
            dsThietBi[89].TrangB = dsTrangBi[9];

            dsThietBi[10].TrangB = dsTrangBi[10];
            dsThietBi[20].TrangB = dsTrangBi[10];
            dsThietBi[35].TrangB = dsTrangBi[10];
            dsThietBi[40].TrangB = dsTrangBi[10];
            dsThietBi[55].TrangB = dsTrangBi[10];
            dsThietBi[65].TrangB = dsTrangBi[10];
            dsThietBi[75].TrangB = dsTrangBi[10];
            dsThietBi[95].TrangB = dsTrangBi[10];

            dsThietBi[11].TrangB = dsTrangBi[11];
            dsThietBi[21].TrangB = dsTrangBi[11];
            dsThietBi[36].TrangB = dsTrangBi[11];
            dsThietBi[41].TrangB = dsTrangBi[11];
            dsThietBi[56].TrangB = dsTrangBi[11];
            dsThietBi[66].TrangB = dsTrangBi[11];
            dsThietBi[76].TrangB = dsTrangBi[11];
            dsThietBi[96].TrangB = dsTrangBi[11];

            dsThietBi[12].TrangB = dsTrangBi[12];
            dsThietBi[22].TrangB = dsTrangBi[12];
            dsThietBi[37].TrangB = dsTrangBi[12];
            dsThietBi[42].TrangB = dsTrangBi[12];
            dsThietBi[57].TrangB = dsTrangBi[12];
            dsThietBi[67].TrangB = dsTrangBi[12];
            dsThietBi[77].TrangB = dsTrangBi[12];
            dsThietBi[97].TrangB = dsTrangBi[12];

            dsThietBi[13].TrangB = dsTrangBi[13];
            dsThietBi[23].TrangB = dsTrangBi[13];
            dsThietBi[38].TrangB = dsTrangBi[13];
            dsThietBi[43].TrangB = dsTrangBi[13];
            dsThietBi[58].TrangB = dsTrangBi[13];
            dsThietBi[68].TrangB = dsTrangBi[13];
            dsThietBi[78].TrangB = dsTrangBi[13];
            dsThietBi[98].TrangB = dsTrangBi[13];

            dsThietBi[14].TrangB = dsTrangBi[14];
            dsThietBi[24].TrangB = dsTrangBi[14];
            dsThietBi[39].TrangB = dsTrangBi[14];
            dsThietBi[44].TrangB = dsTrangBi[14];
            dsThietBi[59].TrangB = dsTrangBi[14];
            dsThietBi[69].TrangB = dsTrangBi[14];
            dsThietBi[79].TrangB = dsTrangBi[14];
            dsThietBi[99].TrangB = dsTrangBi[14];
            //Gán trang bị cho từng phòng trọ
            ds_Phong_Tro[0].trangBi = dsTrangBi[0];//Trang bị cho phòng trọ bình dân
            ds_Phong_Tro[1].trangBi = dsTrangBi[1];
            ds_Phong_Tro[2].trangBi = dsTrangBi[2];
            ds_Phong_Tro[3].trangBi = dsTrangBi[3];
            ds_Phong_Tro[4].trangBi = dsTrangBi[4];

            ds_Phong_Tro[5].trangBi = dsTrangBi[5];//Trang bị cho phòng trọ sinh viên
            ds_Phong_Tro[6].trangBi = dsTrangBi[6];
            ds_Phong_Tro[7].trangBi = dsTrangBi[7];
            ds_Phong_Tro[8].trangBi = dsTrangBi[8];
            ds_Phong_Tro[9].trangBi = dsTrangBi[9];

            ds_Phong_Tro[10].trangBi = dsTrangBi[10];//Trang bị cho phòng trọ cao cấp 
            ds_Phong_Tro[11].trangBi = dsTrangBi[11];
            ds_Phong_Tro[12].trangBi = dsTrangBi[12];
            ds_Phong_Tro[13].trangBi = dsTrangBi[13];
            ds_Phong_Tro[14].trangBi = dsTrangBi[14];
        }
        public static void TaoDanhSachChiTietSuDungDichVu()
        {

            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[0].maphong, new DateTime(2017, 07, 21, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[0]));
            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[1].maphong, new DateTime(2018, 05, 21, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[1]));
            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[2].maphong, new DateTime(2018, 07, 12, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[2]));
            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[5].maphong, new DateTime(2019, 05, 29, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[3]));
            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[6].maphong, new DateTime(2019, 06, 19, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[4]));
            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[7].maphong, new DateTime(2019, 11, 09, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[5]));
            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[8].maphong, new DateTime(2020, 05, 11, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[6]));
            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[10].maphong, new DateTime(2020, 12, 15, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[7]));
            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[11].maphong, new DateTime(2021, 05, 01, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[8]));
            dsChiTietSuDungDichVu.Add(new ChiTietSuDungDichVu(ds_Phong_Tro[12].maphong, new DateTime(2021, 08, 27, 12, 00, 00), new List<DichVu>(), dsChiTietHDThuePhong[9]));

            //Thêm danh sách dịch vụ vào chi tiết sử dụng dịch vụ
            dsChiTietSuDungDichVu[0].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[0].dsDichVu_ChiTiet.Add(dsDichVu[4]);
            dsChiTietSuDungDichVu[0].dsDichVu_ChiTiet.Add(dsDichVu[5]);

            dsChiTietSuDungDichVu[1].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[1].dsDichVu_ChiTiet.Add(dsDichVu[4]);

            dsChiTietSuDungDichVu[2].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[2].dsDichVu_ChiTiet.Add(dsDichVu[4]);

            dsChiTietSuDungDichVu[3].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[3].dsDichVu_ChiTiet.Add(dsDichVu[4]);

            dsChiTietSuDungDichVu[3].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[3].dsDichVu_ChiTiet.Add(dsDichVu[4]);

            dsChiTietSuDungDichVu[4].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[4].dsDichVu_ChiTiet.Add(dsDichVu[4]);

            dsChiTietSuDungDichVu[5].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[5].dsDichVu_ChiTiet.Add(dsDichVu[4]);

            dsChiTietSuDungDichVu[6].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[6].dsDichVu_ChiTiet.Add(dsDichVu[2]);
            dsChiTietSuDungDichVu[6].dsDichVu_ChiTiet.Add(dsDichVu[4]);

            dsChiTietSuDungDichVu[7].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[7].dsDichVu_ChiTiet.Add(dsDichVu[4]);
            dsChiTietSuDungDichVu[7].dsDichVu_ChiTiet.Add(dsDichVu[5]);

            dsChiTietSuDungDichVu[8].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[8].dsDichVu_ChiTiet.Add(dsDichVu[4]);

            dsChiTietSuDungDichVu[9].dsDichVu_ChiTiet.Add(dsDichVu[0]);
            dsChiTietSuDungDichVu[9].dsDichVu_ChiTiet.Add(dsDichVu[1]);
            dsChiTietSuDungDichVu[9].dsDichVu_ChiTiet.Add(dsDichVu[3]);
            dsChiTietSuDungDichVu[9].dsDichVu_ChiTiet.Add(dsDichVu[4]);
            dsChiTietSuDungDichVu[9].dsDichVu_ChiTiet.Add(dsDichVu[5]);

            //Gán danh sách chi tiết sử dụng dịch vụ theo hợp đồng thuê phòng
            dsChiTietHDThuePhong[0].chitietsddv = dsChiTietSuDungDichVu[0];
            dsChiTietHDThuePhong[1].chitietsddv = dsChiTietSuDungDichVu[1];
            dsChiTietHDThuePhong[2].chitietsddv = dsChiTietSuDungDichVu[2];
            dsChiTietHDThuePhong[3].chitietsddv = dsChiTietSuDungDichVu[3];
            dsChiTietHDThuePhong[4].chitietsddv = dsChiTietSuDungDichVu[4];
            dsChiTietHDThuePhong[5].chitietsddv = dsChiTietSuDungDichVu[5];
            dsChiTietHDThuePhong[6].chitietsddv = dsChiTietSuDungDichVu[6];
            dsChiTietHDThuePhong[7].chitietsddv = dsChiTietSuDungDichVu[7];
            dsChiTietHDThuePhong[8].chitietsddv = dsChiTietSuDungDichVu[8];
            dsChiTietHDThuePhong[9].chitietsddv = dsChiTietSuDungDichVu[9];

            //Thêm danh sách chi tiết sử dụng dịch vụ theo dịch vụ
            dsDichVu[0].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[9]);

            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[0]);
            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[1]);
            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[2]);
            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[3]);
            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[4]);
            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[5]);
            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[6]);
            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[7]);
            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[8]);
            dsDichVu[1].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[9]);

            dsDichVu[2].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[6]);

            dsDichVu[3].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[9]);

            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[0]);
            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[1]);
            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[2]);
            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[3]);
            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[4]);
            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[5]);
            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[6]);
            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[7]);
            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[8]);
            dsDichVu[4].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[9]);

            dsDichVu[5].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[0]);
            dsDichVu[5].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[7]);
            dsDichVu[5].dsChiTietSDDichVu_DV.Add(dsChiTietSuDungDichVu[9]);           
        }

        //Các linq đánh số từ 1 đến 10
        public static void Linq1()
        {
            // Linq1 dùng Count để đếm và xuất ra màn hình tổng số lượng khách thuê phòng trọ
            var soluongkhach = dsKhach.Count();
            Console.WriteLine("Số lượng khách thuê phòng trọ: {0} khách", soluongkhach);
        }
        public static void Linq2(int x)
        {
            // Linq2 dùng ElementAt để xác định và xuất ra màn hình thông tin về khách thứ x (0<x<= tổng số khách) 
            string formatdate = "dd/MM/yyyy";
            if (x > dsKhach.Count() || x < 1) Console.WriteLine("Vui lòng tìm lại, hiện tại đang có {0} khách", dsKhach.Count());
            else
            {
                var timkhachthu = dsKhach.ElementAt(x - 1);//vi du khach thu 10 se la dsKhach[9]
                Console.WriteLine("Thông tin về khách thứ {0}:", x);
                Console.WriteLine("\tMã khách hàng: {0}\tMã loại khách hàng: {1}\tHọ và tên: {2}\tGiới tính: {3}\tNgày sinh: {4}\tCăn cước công dân: {5}\tQuê quán: {6}\tNghề nghiệp: {7}",
                    timkhachthu.maKH, timkhachthu.maloaiKH, timkhachthu.hoTen, timkhachthu.gioiTinh, timkhachthu.ngaySinh.ToString(formatdate), timkhachthu.cCCD, timkhachthu.queQuan, timkhachthu.ngheNghiep);
            }
        }
        public static void Linq3()
        {
            // Linq3 dùng Where để xác định và xuất ra màn hình thông tin các nhân viên là nữ
            string formatdate = "dd/MM/yyyy";
            var nhaviennu = dsNhanVien.Where(n => n.gioiTinh == "Nữ");
            Console.WriteLine("Thông tin về các nhân viên nữ: -----------------------------------------------------------------------------------");
            foreach (var n in nhaviennu)
            {
                Console.WriteLine("\tMã nhân viên: {0}\tHọ và tên: {1}\tGiới tính: {2}\tNgày sinh: {3}\tCCCD: {4}\tQuê quán: {4}",
                    n.maNV, n.hoTen, n.gioiTinh, n.ngaySinh.ToString(formatdate), n.cCCD, n.queQuan);
            }
        }
        public static void Linq4()
        {
            // Linq4 dùng group để nhóm và xuất ra màn hình danh sách khách được nhóm theo quê quán
            string formatdate = "dd/MM/yyyy";
            var theoquequan = from q in dsKhach
                              group q by q.queQuan into g
                              select new { quequan = g.Key, khach = g };
            Console.WriteLine("Danh sách khách được nhóm theo quê quán: -----------------------------------------------------------------------");
            foreach (var g in theoquequan)
            {
                Console.WriteLine("Các khách có quê quán ở {0}:", g.quequan);
                foreach (var q in g.khach)
                {
                    Console.WriteLine("\tMã khách hàng: {0}\tMã loại khách hàng: {1}\tHọ và tên: {2}\tGiới tính: {3}\tNgày sinh: {4}\tCăn cước công dân: {5}\tQuê quán: {6}\tNghề nghiệp: {7}",
                    q.maKH, q.maloaiKH, q.hoTen, q.gioiTinh, q.ngaySinh.ToString(formatdate), q.cCCD, q.queQuan, q.ngheNghiep);
                }
            }
        }
        public static void Linq5()
        {
            // Linq5 dùng orderby để sắp xếp và xuất ra màn hình danh sách chi tiết hợp đồng thuê phòng giảm dần theo mã phòng
            string formatdatetime = "dd/MM/yyyy HH:mm:ss";
            var xepmaphong = from n in dsChiTietHDThuePhong orderby n.maphong descending select n;
            Console.WriteLine("Danh sách chi tiết hợp đồng xếp giảm dần theo mã phòng: ---------------------------------------------------------");
            foreach (var n in xepmaphong)
            {
                Console.WriteLine("\tMã phòng: {0}\tNgày giờ đăng kí: {1}\tSố hợp đồng thuê: {2}\tTiền đặt cọc: {3} vnd\tNgày dọn vào: {4}\tNgày dọn ra: {5}",
                    n.maphong, n.ngaygiodangki.ToString(formatdatetime), n.soHDThue, n.tiendatcoc,
                    n.ngaydonvao.ToString(formatdatetime), n.ngaydonra.ToString(formatdatetime));
            }
        }
        public static void Linq6()
        {
            // Linq6 dùng Concat để nối và xuất ra tất cả tên của nhân viên và khách 
            var tennhanvien = dsNhanVien.Select(n => n.hoTen);
            var tenkhach = dsKhach.Select(n => n.hoTen);
            var tenkhachnhanvien = tennhanvien.Concat(tenkhach);
            Console.WriteLine("Tên tất cả nhân viên và khách: -----------------------------------------------------------------------------------");
            foreach (var n in tenkhachnhanvien)
            {
                Console.WriteLine("\t{0}", n);
            }
        }
        public static void Linq7()
        {
            // Linq7 dùng Take để trả về 3 khách đầu tiên có tên loại khách hàng là sinh viên 
            var khachsinhvien = from c in dsLoaiKH
                                where c.tenloaiKH == "Sinh viên"
                                select c;
            var first3khachsinhvien = (from k in khachsinhvien from kk in k.dskhach_loai select kk).Take(3);
            Console.WriteLine("Ba khách sinh viên tìm thấy đầu tiên là: ------------------------------------------------------------------------");
            foreach (var k in first3khachsinhvien)
            {
                Console.WriteLine("\tMã khách hàng: {0}\tHọ tên: {1}\tQuê quán: {2}", k.maKH, k.hoTen, k.queQuan);
            }
        }
        public static void Linq8()
        {
            // Linq8 dùng select để chọn và in ra màn hình các hợp đồng thực hiện vào năm 2020 
            string formatdate = "dd/MM/yyyy";
            var hd2019 = from h in dsChiTietHDThuePhong
                         where h.ngaygiodangki.Year == 2020
                         select new { h.soHDThue, h.maphong, h.hopDong.khach.hoTen, h.ngaygiodangki };
            Console.WriteLine("Linq8 các hợp đồng thực hiện năm 2020: --------------------------------------------------------------------------");
            foreach (var hh in hd2019)
            {
                Console.WriteLine("\tSố hợp đồng thuê: {0}\tMã phòng: {1}\tHọ tên khách: {2}\tNgày đăng kí: {3}",
                    hh.soHDThue, hh.maphong, hh.hoTen, hh.ngaygiodangki.ToString(formatdate));
            }
        }
        public static void Linq9()
        {
            // Linq9 dùng Any để chọn và đưa ra màn hình bất kỳ nhóm khách (xếp theo loại khách hàng) có 1 khách dùng từ 3 dịch vụ 
            var batky3dichvu = from n in dsKhach
                               group n by n.maloaiKH into g
                               where g.Any(n => n.dshdthuephong_khach.Last().chitiethd.chitietsddv.dsDichVu_ChiTiet.Count() >= 3)
                               select new { loaikhach = g.Key, khach = g };
            Console.WriteLine("Các nhóm khách có bất kỳ 1 khách dùng từ 3 dịch vụ: -------------------------------------------------------------");
            foreach (var nn in batky3dichvu)
            {
                Console.WriteLine("Loại khách hàng: {0}", nn.loaikhach);
                foreach (var nnn in nn.khach)
                {
                    Console.WriteLine("\tMã khách hàng: {0}\tTên khách hàng: {1}\tSố lượng dịch vụ: {2}",
                        nnn.maKH, nnn.hoTen, nnn.dshdthuephong_khach.Last().chitiethd.chitietsddv.dsDichVu_ChiTiet.Count());
                }
            }
        }
        public static void Linq10()
        {
            // Linq10 dùng Intersect để tìm và in ra màn hình những năm sinh có cả ở khách và nhân viên 
            var dsnamsinhkhach = dsKhach.Select(n => n.ngaySinh.Year);
            var dsnamsinhnhanvien = dsNhanVien.Select(m => m.ngaySinh.Year);
            var cungnamsinh = dsnamsinhkhach.Intersect(dsnamsinhnhanvien);
            Console.WriteLine("Các năm sinh có cả ở nhân viên và khách hàng: -------------------------------------------------------------------");
            foreach (var k in cungnamsinh)
            {
                Console.WriteLine("\t{0}", k);
            }
        }

        public static void Linq11()
        {
            //Cho biết 3 thiết bị mà phòng trọ C1 có mã T1 sử dụng
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("//////////////CHO BIẾT 3 THIẾT BỊ MÀ PHÒNG TRỌ C1 CÓ MÃ \"T1\" SỬ DỤNG////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");

            var thietBi = (from p in dsThietBi
                          where p.TrangB.PTro.maphong == "T1"
                          select p).Take(3);

            Console.WriteLine("Ba thiết bị mà phòng C1 có mã \"T1\" sử dụng: ");
            foreach (var d in thietBi)
                Console.WriteLine("- Thiết bị \"{0}\" với số lượng là {1}", d.tenThietBi, d.soLuong);
        }
        public static void Linq12()
        {
            //Cho biết dịch vụ mắc nhất
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("//////////////////////////CHO BIẾT DỊCH VỤ CÓ GIÁ MẮC NHẤT////////////////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");

            var macNhat = dsDichVu.Max(a => a.giaDichVu);
            var dichVu = dsDichVu.First(b => b.giaDichVu == macNhat);

            Console.WriteLine("- Dịch vụ có giá mắc nhất: {0}", dichVu.tenDichVu);
            Console.WriteLine("- Mã: {0}", dichVu.maDichVu);
            Console.WriteLine("- Loại dịch vụ: {0}", dichVu.LoaiDV.tenLoaiDichVu);
            Console.WriteLine("- Chi phí: {0} VNĐ", dichVu.giaDichVu);
        }

        public static void Linq13()
        {
            //Cho biết danh sách dịch vụ theo loại dịch vụ
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////CHO BIẾT DANH SÁCH DỊCH VỤ THEO LOẠI DỊCH VỤ//////////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");

            var tenLoaiDichVu = from loai in dsLoaiDichVu
                                select loai.tenLoaiDichVu;

            var dichVu = from ldv in tenLoaiDichVu
                         join dv in dsDichVu on ldv equals dv.LoaiDV.tenLoaiDichVu
                         select new { loaidv = ldv, dv.tenDichVu };

            Console.WriteLine("Danh sách dịch vụ: ");
            foreach(var d in dichVu)
                Console.WriteLine( "- \"{0}\" thuộc loại dịch vụ \"{1}\"", d.tenDichVu, d.loaidv);
        }

        public static void Linq14()
        {
            //Cho biết những thiết bị nào có giá trên 5000000VNĐ
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////CHO BIẾT NHỮNG THIẾT BỊ NÀO CÓ GIÁ TRÊN 5 TRIỆU ĐỒNG//////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");

            var thietBi = from tb in dsThietBi
                          where tb.giaThietBi >= 5000000
                          select tb;

            Console.WriteLine("Những thiết bị có giá trên 5 triệu đồng: ");
            foreach (var t in thietBi)
            {
                Console.WriteLine("- Thiết bị: {0}", t.tenThietBi);
                Console.WriteLine(" + Mã: {0}", t.maThietBi);
                Console.WriteLine(" + Loại: {0}", t.LoaiTB.tenLoaiThietBi);
                Console.WriteLine(" + Giá: {0} VNĐ", t.giaThietBi);
                Console.WriteLine(" + Bảo hành: {0} tháng", t.thoiGianBaoHanh);
            }
        }

        public static void Linq15()
        {
            //Cho biết mỗi dịch vụ được sử dụng bởi bao nhiêu phòng
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("//////////////////CHO BIẾT MỖI DỊCH VỤ ĐƯỢC BAO NHIÊU PHÒNG SỬ DỤNG///////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");

            var demPhong = from dv in dsDichVu
                           select new { dv.tenDichVu, soLuong = dv.dsChiTietSDDichVu_DV.Count() };

            Console.WriteLine("Số phòng sử dụng các dịch vụ:");
            foreach (var d in demPhong)
                Console.WriteLine("- {0}: {1} phòng.", d.tenDichVu, d.soLuong);
        }

        public static void Linq16()
        {
            //Tính tổng tiền trang bị cho mỗi phòng
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////TÍNH TỔNG TIỀN TRANG BỊ CHO MỖI PHÒNG/////////////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");

            var trangBi = from tb in dsTrangBi
                          select new { tb, tongTien = tb.dsThietBi_TB.Sum(p=>(p.giaThietBi*p.soLuong))};

            Console.WriteLine("Số tiền dành cho trang bị mỗi phòng: ");
            foreach (var t in trangBi)
                Console.WriteLine("- {0} được trang bị vào {1} và tốn {2} VNĐ.", t.tb.PTro.tenphong, String.Format("{0:d}", t.tb.ngayGio), t.tongTien);
        }

        public static void Linq17(string s)
        {
            //Tìm thông tin dịch vụ "Dọn dẹp"
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("///////////////////////////TÌM THÔNG TIN DỊCH VỤ \"DỌN DẸP\"//////////////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            var dichVu = dsDichVu.FirstOrDefault(d => d.tenDichVu == s);

            Console.WriteLine("Tìm thông tin dịch vụ \"{0}\"! ", s);
            try
            {
                Console.WriteLine("- Mã dịch vụ: {0}", dichVu.maDichVu);
                Console.WriteLine("- Mã loại dịch vụ: {0}", dichVu.maLoaiDichVu);
                Console.WriteLine("- Loại dịch vụ: {0}", dichVu.LoaiDV.tenLoaiDichVu);
                Console.WriteLine("- Chi phí: {0} VNĐ", dichVu.giaDichVu);
                Console.WriteLine("- Ghi chú: {0}", dichVu.chiTietDichVu);
                Console.WriteLine("- Số phòng đã sử dụng: {0}", dichVu.dsChiTietSDDichVu_DV.Count());
            }
            catch
            {
                Console.WriteLine("Không có dịch vụ \"s\".", s);
            }
        }

        public static void Linq18()
        {
            //Cho biết dịch vụ nào được sử dụng nhiều nhất
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////CHO BIẾT NHỮNG DỊCH VỤ NÀO ĐƯỢC SỬ DỤNG NHIỀU NHẤT///////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");

            var dem = dsDichVu.Max(d => d.dsChiTietSDDichVu_DV.Count());
            var ketQua = from dv in dsDichVu
                         where dv.dsChiTietSDDichVu_DV.Count() == dem
                         select dv;

            Console.WriteLine("Dịch vụ được sử dụng nhiều nhất :");
            int i = 1, j=0;
            foreach (var k in ketQua)
            {
                if (ketQua.Count() == 1)
                    goto inThongTin;
                else
                {
                    Console.WriteLine("- Dịch vụ {0}: ", i);
                    i++;
                    goto inThongTin;
                }

            inThongTin:
                Console.WriteLine(" + Tên dịch vụ: {0}", k.tenDichVu);
                Console.WriteLine(" + Mã dịch vụ: {0}", k.maDichVu);
                Console.WriteLine(" + Loại dịch vụ: {0}", k.LoaiDV.tenLoaiDichVu);
                Console.WriteLine(" + Giá dịch vụ: {0} VNĐ", k.giaDichVu);
                Console.WriteLine(" + Chi tiết thêm về dịch vụ: {0}", k.chiTietDichVu);
                Console.WriteLine(" + Những phòng đã sử dụng dịch vụ này là:");
                foreach (var dsct in k.dsChiTietSDDichVu_DV)
                    Console.WriteLine("   Phòng {0}", dsct.maPhong );
            }          
        }

        public static void Linq19()
        {
            //Sắp xếp danh sách trang bị theo thứ tự ngày trang bị
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////SẮP XẾP DANH SÁCH TRANG BỊ THEO THỜI GIAN TRANG BỊ///////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");

            var sapXep = dsTrangBi.OrderBy(t => t.ngayGio);

            Console.WriteLine("Danh sách trang bị được sắp xếp theo thời gian trang bị:");
            int i = 1;
            foreach(var s in sapXep)
            {
                Console.WriteLine("- Trang bị {0}:", i++);
                Console.WriteLine(" + Ngày trang bị: {0}", String.Format("{0:d}", s.ngayGio));
                Console.WriteLine(" + Phòng trọ được trang bị: {0}", s.PTro.tenphong);
                Console.WriteLine(" + Tổng số tiền trang bị: {0} VNĐ", s.dsThietBi_TB.Sum(a=>(a.soLuong*a.giaThietBi)));
                Console.WriteLine(" + Thiết bị đã trang bị: ");
                foreach (var t in s.dsThietBi_TB)
                    Console.WriteLine("   {0} - {1} thiết bị", t.tenThietBi, t.soLuong);
            }
        }

        public static void Linq20()
        {
            //In ra thông tin của thiết bị (không bao gồm giống nhau)
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("///////////LIỆT KÊ DANH SÁCH THIẾT BỊ (KHÔNG BAO GỒM THIẾT BỊ GIỐNG NHAU)/////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");

            var thietBi = (from tb in dsThietBi
                           select new { tb.tenThietBi, tb.giaThietBi, tb.LoaiTB.tenLoaiThietBi, tb.thoiGianBaoHanh })
                        .Distinct();

            Console.WriteLine("Những thiết bị đã được trang bị (không bao gồm thiết bị giống nhau):");
            foreach (var t in thietBi)
            {
                Console.WriteLine("- Thiết bị: {0}", t.tenThietBi);
                Console.WriteLine(" + Loại: {0}", t.tenLoaiThietBi);
                Console.WriteLine(" + Giá: {0} VNĐ", t.giaThietBi);
                Console.WriteLine(" + Bảo hành: {0} tháng", t.thoiGianBaoHanh);
            }
        }

        public static void Linq21()
        {
            Console.WriteLine("");
            Console.WriteLine("********** LOẠI PHÒNG VÀ TÊN PHÒNG ĐƯỢC PHÂN THEO DÃY PHÒNG **********");
            var dayGroups =
                from p in ds_Phong_Tro
                group p by p.day into g
                select new { day = g.Key, ds_Phong_Tro = g };

            foreach (var c in dayGroups)
            {
                Console.WriteLine("Các phòng thuộc dãy: \n \t \t \t {0}", c.day);
                foreach (var p in c.ds_Phong_Tro)
                    Console.WriteLine("\t Mã  loại phòng: {0} \t Tên phòng: {1}",
                        p.maloaiphong, p.tenphong);
            }
        }

        public static void Linq22()
        {
            Console.WriteLine("");
            Console.WriteLine("********** MÃ BẢNG GIÁ VÀ GIÁ PHÒNG CỦA NHÀ TRỌ **********");
            // query
            var Counts =
                (from c in ds_Bang_Gia
                 select c.mabanggia).Count();

            foreach (var c in ds_Bang_Gia)
            {
                Console.WriteLine("Mã bảng giá: {0}\t -\t Giá tiền thuê phòng: {1} VNĐ", c.mabanggia, c.gia);
            }
        }
        public static void Linq23()
        {
            Console.WriteLine("");
            Console.WriteLine("********** MÃ PHÒNG VÀ GIÁ TIỀN PHÒNG ĐƯỢC SẮP XẾP GIẢM DẦN **********");
            var sortedmabanggia =
                from prod in ds_Bang_Gia
                orderby prod.gia descending
                select prod;
            foreach (var pp in sortedmabanggia)
            {
                Console.WriteLine("Mã phòng trọ: {0}\t -\t Giá phòng trọ: {1} VNĐ",
                    pp.maphong, pp.gia);
            }
        }

        public static void Linq24(string x, string y, string z, string t)
        {
            Console.WriteLine("");
            Console.WriteLine("********** TÌM ĐƯỢC NHÀ TRỌ THEO MÃ NHÀ TRỌ **********");
            string[] MaNhaTro = new string[] { x, y, z, t };
            // query
            var q =
                from c in MaNhaTro
                join p in ds_Nha_Tro on c equals p.manhatro
                select new { MaNhaTro = c, p.tennhatro };
            foreach (var v in q)
            {
                Console.WriteLine("Tên nhà trọ: {0} \n \t Với \t Mã nhà trọ: {1}", v.tennhatro, v.MaNhaTro);
            }
        }

        public static void Linq25()
        {
            Console.WriteLine("");
            Console.WriteLine("********** DANH SÁCH KHU VỰC VÀ LOẠI PHÒNG TRỌ HIỆN CÓ **********");
            var Akhuvuc =
                from c in ds_Nha_Tro
                select c.khuvuc;

            var Atenloaiphong =
                from p in ds_Loai_Phong
                select p.tenloaiphong;

            var allNames = Akhuvuc.Concat(Atenloaiphong);

            foreach (var n in allNames)
            {
                Console.WriteLine(n);
            }
        }

        public static void Linq26()
        {
            Console.WriteLine("");
            Console.WriteLine("********** TÊN LOẠI PHÒNG VÀ DIỆN TÍCH PHÒNG **********");
            var dsLoaiPhong = ds_Loai_Phong.Select(LoaiPhong => LoaiPhong);

            foreach (var h in dsLoaiPhong)
            {
                Console.WriteLine("Tên loại phòng: {0} - Diện tích phòng theo loại phòng: {1}m2", h.tenloaiphong, h.dientichphong);
            }
        }

        public static void Linq27()
        {
            Console.WriteLine("");
            Console.WriteLine("********** MÃ BẢNG GIÁ, MÃ PHÒNG CỦA PHÒNG CÓ GIÁ NHỎ HƠN 2.500.000 VNĐ **********");
            var Giaphong = from product in ds_Bang_Gia
                           where product.gia < 2500000
                           orderby product.gia descending
                           select product;
            foreach (var product in Giaphong)
            {
                Console.WriteLine("Mã bảng giá: {0}\t - \tMã phòng: {1}\t - \tGiá tiền: {2} VNĐ", 
                    product.mabanggia, product.maphong, product.gia);
            }
        }

        public static void Linq28()
        {
            Console.WriteLine("");
            Console.WriteLine("********** BỐN TÊN NHÀ TRỌ ĐẦU TIÊN ĐƯỢC ĐỀ CẬP TRONG DANH SÁCH NHÀ TRỌ **********");
            var first4NT = ds_Nha_Tro.Take(4);

            foreach (var n in first4NT)
            {
                Console.WriteLine("Tên nhà trọ: {0}", n.tennhatro);
            }
        }

        public static void Linq29()
        {
            Console.WriteLine("");
            Console.WriteLine("********** DANH SÁCH CÁC PHÒNG CÒN TRỐNG **********");
            var ketqua = from p in ds_Phong_Tro
                         where p.chitiethd == null
                         select p;
            foreach (var n in ketqua)
            {
                Console.WriteLine("Trọ: {0}", n.tenphong);
            }
        }

        public static void Linq30()
        {
            Console.WriteLine("");
            Console.WriteLine("********** TỔNG SỐ TIỀN THU ĐƯỢC THEO GIÁ TIỀN PHÒNG **********");
            var ketqua = from row in ds_Bang_Gia
                         group row by row.gia into grp
                         select new
                         {
                             giatien = grp.Key,
                             gia = grp.Sum(row => row.gia)
                         };
            foreach (var n in ketqua)
            {
                Console.WriteLine("Giá tiền: {0} - Giá: {1} VNĐ", n.giatien, n.gia);
            }
        }

        //Hàm main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TaodanhsachLoaiKH();
            TaodanhsachKhach();
            TaodanhsachNhanVien();
            TaodanhsachHopDongThuePhong();
            TaoDanhSachLoaiDichVu();
            TaoDanhSachDichVu();
            TaoDanhSachLoaiThietBi();
            TaoDanhSachThietBi();
            TaoDanhSachLoaiPhong();
            TaoDanhSachNhaTro();
            TaoDanhSachPhongTro();
            TaoDanhSachBangGia();
            TaoDanhSachChiTietHDThuePhong();
            TaoDanhSachChiTietSuDungDichVu();
            TaoDanhSachTrangBi();

            
            Linq1();
            Linq2(10);
            Linq3();
            Linq4();
            Linq5();
            Linq6();
            Linq7();
            Linq8();
            Linq9();
            Linq10();

            Linq11();
            Linq12();
            Linq13();
            Linq14();
            Linq15();
            Linq16();
            Linq17("Dọn dẹp");
            Linq18();
            Linq19();
            Linq20();

            Linq21();
            Linq22();
            Linq23();
            Linq24("NT01", "NT02", "NT04", "NT06");
            Linq25();
            Linq26();
            Linq27();
            Linq28();
            Linq29();
            Linq30();

            Console.ReadKey();
        }
    }
}
