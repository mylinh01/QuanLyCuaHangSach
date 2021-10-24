--Cài đặt Trigger cho các bảng
USE QuanLyCuaHangSach
GO
--Cập nhật số lượng sách sau khi nhập sách 
CREATE TRIGGER trg_NhapSach ON ChitietPhieuNhap 
AFTER INSERT AS 
BEGIN
	UPDATE Sach
	SET SoLuongTonKho = SoLuongTonKho + (
		SELECT SoLuong
		FROM inserted
		WHERE ID_Sach = Sach.ID
	)
	FROM Sach
	JOIN inserted ON Sach.ID = inserted.ID_Sach
END
DROP TRIGGER trg_NhapSach
GO
--Cập nhật sách trong kho sau khi cập nhật nhập sách
CREATE TRIGGER trg_CapNhatNhapSach ON ChitietPhieuNhap 
AFTER UPDATE AS
BEGIN
   UPDATE Sach SET SoLuongTonKho = SoLuongTonKho +
	   (SELECT SoLuong FROM inserted WHERE ID_Sach = Sach.ID) +
	   (SELECT SoLuong FROM deleted WHERE ID_Sach = Sach.ID)
   FROM Sach 
   JOIN deleted ON Sach.ID = deleted.ID_Sach
END
GO
--Cập nhật số lượng sách sau khi bán sách
CREATE TRIGGER trg_BanSach ON ChitietHoaDon 
AFTER INSERT AS 
BEGIN
	UPDATE Sach
	SET SoLuongTonKho = SoLuongTonKho - (
		SELECT SoLuong
		FROM inserted
		WHERE ID_Sach = Sach.ID
	)
	FROM Sach
	JOIN inserted ON Sach.ID = inserted.ID_Sach
END
DROP TRIGGER trg_NhapSach
GO
--Cập nhật sách trong kho sau khi cập nhật bán sách
CREATE TRIGGER trg_CapNhatBanSach ON ChitietHoaDon  
AFTER UPDATE AS
BEGIN
   UPDATE Sach SET SoLuongTonKho = SoLuongTonKho -
	   (SELECT SoLuong FROM inserted WHERE ID_Sach = Sach.ID) +
	   (SELECT SoLuong FROM deleted WHERE ID_Sach = Sach.ID)
   FROM Sach 
   JOIN deleted ON Sach.ID = deleted.ID_Sach
END
GO
--Phần trăm giảm giá >0 và <1
CREATE TRIGGER trg_PTGG ON GiamGia
AFTER INSERT AS 
DECLARE @PhanTramGG FLOAT
SELECT @PhanTramGG = ne.PhanTramGG 
FROM inserted ne
IF(@PhanTramGG <0 AND @PhanTramGG>100)
BEGIN
ROLLBACK
RAISERROR(N'Phần trăm giảm giá không hợp lệ', 16, 1)
RETURN
END
GO

--Ngày bắt đầu của giảm giá phải trước ngày kết thúc
CREATE TRIGGER trg_NBD ON GiamGia
AFTER INSERT AS 
DECLARE @NgayBatDau datetime, @NgayKetThuc datetime
SELECT @NgayBatDau = ne.NgayBatDau, @NgayKetThuc = ne.NgayKetThuc 
FROM inserted ne
IF(@NgayBatDau >= @NgayKetThuc)
BEGIN
ROLLBACK
RAISERROR(N'Ngày bắt đầu và kết thúc giảm giá không hợp lệ', 16, 1)
RETURN
END
GO


--Kiểm tra ràng buộc IDNV
CREATE TRIGGER trg_IDNV_HoaDon ON HoaDon
AFTER INSERT AS
IF EXISTS(SELECT 1 FROM inserted WHERE ID_NV NOT IN(SELECT ID FROM NhanVien))
BEGIN
ROLLBACK
RAISERROR(N'Mã nhân viên không hợp lệ', 16, 1)
RETURN
END
GO
--Kiểm tra ràng buộc IDTV
CREATE TRIGGER trg_IDTV_HoaDon ON HoaDon
AFTER INSERT AS
IF EXISTS(SELECT 1 FROM inserted WHERE ID_TV NOT IN(SELECT ID FROM ThanhVien))
BEGIN
ROLLBACK
RAISERROR(N'Mã thành viên không hợp lệ', 16, 1)
RETURN
END
GO
--Kiểm tra chi tiết hóa đơn
--Kiểm tra IDHoaDon có tồn tại không
CREATE TRIGGER trg_IDHD_ChiTietHoaDon ON ChiTietHoaDon
AFTER INSERT AS
IF EXISTS(SELECT 1 FROM inserted WHERE ID_HD NOT IN(SELECT ID FROM HoaDon))
BEGIN 
	RAISERROR(N'Mã Hóa Đơn không hợp lệ', 16, 1)
	ROLLBACK
	RETURN
END
GO
--Kiểm tra IDSach hợp lệ
CREATE TRIGGER trg_IDSach_ChiTietHoaDon ON ChiTietHoaDon
AFTER INSERT AS
IF EXISTS(SELECT 1 FROM inserted WHERE ID_Sach NOT IN(SELECT ID FROM Sach))
BEGIN 
	RAISERROR(N'Mã sách không hợp lệ', 16, 1)
	ROLLBACK
	RETURN
END
GO
--Kiểm tra số lượng phải lớn hơn 0
CREATE TRIGGER trg_SoLuong_ChiTietHoaDon ON ChiTietHoaDon
AFTER INSERT AS
DECLARE @sl INT
SELECT @sl=chitiethoadon.SoLuong
FROM Inserted chitiethoadon
IF @sl<1
BEGIN 
	
	RAISERROR(N'Số lượng không hợp lệ', 16, 1)
	ROLLBACK
	RETURN
END
GO
--Kiểm tra chi tiết phiếu nhập
--Kiểm tra IDPhieuNhap có tồn tại không
CREATE TRIGGER trg_IDPN_ChiTietPhieuNhap ON ChiTietPhieuNhap
AFTER INSERT AS
IF EXISTS(SELECT 1 FROM inserted WHERE ID_PN NOT IN(SELECT ID FROM PhieuNhap))
BEGIN 
	RAISERROR(N'Mã phiếu nhập không hợp lệ', 16, 1)
	ROLLBACK
	RETURN
END
GO
--Kiểm tra IDSach hợp lệ
CREATE TRIGGER trg_IDSach_ChiTietPhieuNhap ON ChiTietPhieuNhap
AFTER INSERT AS
IF EXISTS(SELECT 1 FROM inserted WHERE ID_Sach NOT IN(SELECT ID FROM Sach))
BEGIN 
	RAISERROR(N'Mã sách không hợp lệ', 16, 1)
	ROLLBACK
	RETURN
END
GO
--Kiểm tra số lượng sách nhập phải lớn hơn 0 
CREATE TRIGGER trg_SoLuong_ChiTietPhieuNhap ON ChiTietPhieuNhap
AFTER INSERT AS
DECLARE @sl INT
SELECT @sl= ChiTietPhieuNhap.SoLuong
FROM Inserted ChiTietPhieuNhap
IF @sl<1
BEGIN 
	
	RAISERROR(N'Số lượng không hợp lệ', 16, 1)
	ROLLBACK
	RETURN
END
GO
-- Kiểm tra lương sau khi insert nhanvien có hợp lệ (lớn hơn 0) không? --
CREATE TRIGGER trg_InsertLuong ON NhanVien
AFTER INSERT AS
DECLARE @salary INT
SELECT @salary = ne.Luong
FROM inserted ne
IF (@salary < 0)
BEGIN
	PRINT('ERROR!');
	ROLLBACK;
END
GO
-- Kiểm tra lương sau khi updatenhanvien có hợp lệ (lớn hơn 0) không? --
CREATE TRIGGER trg_UpdateLuong ON NhanVien
AFTER UPDATE AS
DECLARE @salary INT
SELECT @salary = ne.Luong
FROM inserted ne
IF (@salary < 0)
BEGIN
	PRINT('ERROR!');
	ROLLBACK;
END
GO
-- TABLE: LOAITHANHVIEN --
CREATE TRIGGER trg_InsertMuuUuDai ON LoaiThanhVien
AFTER INSERT AS
DECLARE @mucUuDai INT
SELECT @mucUuDai = ne.MucUuDai
FROM inserted ne
IF (@mucUuDai < 0 AND @mucUuDai >100)
BEGIN
	PRINT('ERROR!');
	ROLLBACK;
END
GO
-- Kiểm tra mức ưu đãi sau khi updateloaithanhvien có hợp lệ (lớn hơn 0) không? --
CREATE TRIGGER trg_UpdateMuuUuDai ON LoaiThanhVien
AFTER UPDATE AS
DECLARE @mucUuDai INT
SELECT @mucUuDai = ne.MucUuDai
FROM inserted ne
IF (@mucUuDai < 0 AND @mucUuDai >100)
BEGIN
	PRINT('ERROR!');
	ROLLBACK;
END



