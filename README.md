# Tên đề tài: ỨNG DỤNG CÔNG NGHỆ LINQ TRONG MÔ PHỎNG HỆ THỐNG QUẢN LÝ PHÒNG TRỌ
#### TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT TP.HỒ CHÍ MINH, KHOA CÔNG NGHỆ THÔNG TIN
#### BỘ MÔN: LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG
#### MÃ SỐ LỚP HP: OOPR230279_21_1_08, GVHD: GVC.THS. NGUYỄN MINH ĐẠO, HỌC KỲ: I – NĂM HỌC: 2021 - 2022
#### NHÓM THỰC HIỆN: NHÓM 7
### DANH SÁCH THÀNH VIÊN THAM GIA ĐỀ TÀI
#### Phan Quan Huy	20110652
#### Nguyễn Văn Sang  20110711
#### Nguyễn Văn Thuận	20110732
### GIỚI THIỆU ĐỀ TÀI
- Mô phỏng hệ thống quản lý phòng trọ với nội dung chi tiết như sau:
- Hệ thống phòng trọ gồm nhiều loại khách hàng, nhân viên, phòng trọ, dịch vụ và thiết bị.
- Mỗi loại khách hàng có một mã phân biệt và các thông tin cụ thể liên quan.
- Mỗi khách hàng có thể kí hợp đồng thuê phòng với một nhân viên và sử dụng các dịch vụ trong phòng trọ.
- Mỗi phòng trọ thuộc về một loại phòng trọ và một nhà trọ, có một mã phòng và một bảng giá phòng.
- Mỗi phòng trọ được trang bị nhiều thiết bị thuộc nhiều loại thiết bị khác nhau.
### NỀN TẢNG THỰC HIỆN
Đồ án được thực hiện sử dụng:
-	Ngôn ngữ lập trình C#.
-	UI Framework Windows Forms.
-	Công nghệ ADO.NET
-	Cơ sở dữ liệu: SQL Server
### XÂY DỰNG SƠ ĐỒ ERD
![image](https://github.com/Nguyenvsang/OOP_QuanLyPhongTro_C_Sharp/assets/80632518/bedf83a8-bf0d-4c79-8d20-4ae8acb203fb)
### XÂY DỰNG SƠ ĐỒ QUAN HỆ
## BẢNG QUAN HỆ CƠ SỞ (ENTITY RELATIONS)
1.	LoaiKH (KC:maloaiKH, tenloaiKH)
2.	Khach (KC:maKH, KN:maloaiKH , hoTen, gioiTinh, ngaySinh, cCCD, 
queQuan, ngheNghiep)
3.	NhanVien (KC:maNV, hoTen, gioiTinh, ngaySinh, cCCD, queQuan)
4.	HopDongThuePhong (KC:soHDThue, KN:maKH, KN:maNV)
5.	LoaiDichVu (KC:maLoaiDichVu, tenLoaiDichVu)
6.	DichVu (KC:maDichVu, KN:maLoaiDichVu, tenDichVu, chiTietDichVu, giaDichVu)
7.	LoaiThietBi (KC:maLoaiThietBi, tenLoaiThietBi)
8.	ThietBi (KC:maThietBi, KN:maLoaiThietBi, tenThietBi, giaThietBi, soLuong, thoiGianBaoHanh)
9.	LoaiPhong (KC:maloaiphong, tenloaiphong, dientichphong)
10.	NhaTro (KC:manhatro, tennhatro, khuvuc)
11.	PhongTro (KC:maphong, KN:maloaiphong, KN:manhatro, tenphong, day)
12.	BangGia ( KC:mabanggia, KN:maphong, gia)
## BẢNG QUAN HỆ LIÊN KẾT (RELATIONSHIP RELATIONS)
13.	ChiTietHDThuePhong (KN:maphong, ngaygiodangki, soHDThue, tiendatcoc, ngaydonvao, ngaydonra)
14.	ChiTietSuDungDV (KN:maphong, ngayGioDangKi)
15.	TrangBi (KN:maphong, ngaygio)
#### *Ghi chú: 
- KC: khoá chính
- KN: khoá ngoại

