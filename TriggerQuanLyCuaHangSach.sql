--Cài đặt Trigger cho các bảng
USE QuanLyCuaHangSach
GO

--1. Kiểm tra số lượng sách trên hóa đơn phải nhỏ hơn số lượng tồn kho
CREATE TRIGGER trgSoLuongChiTietHoaDon ON ChiTietHoaDon
AFTER INSERT AS
DECLARE @sl INT, @sltk INT
SELECT @sl=ChiTietHoaDon.SoLuong, @sltk = Sach.SoLuongTonKho
FROM Inserted ChiTietHoaDon JOIN Sach ON ChiTietHoaDon.ID_Sach = Sach.ID
IF (@sl > @sltk)
BEGIN 
	
	RAISERROR(N'Số lượng tồn kho không đủ', 16, 1)
	ROLLBACK
	RETURN
END
GO
sp_SetTriggerOrder @triggername= 'trgSoLuongChiTietHoaDon', @order='First', @stmttype = 'INSERT'
GO

--2. Cập nhật số lượng sách sau khi bán sách
CREATE TRIGGER trgBanSach ON ChitietHoaDon 
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
GO

--3. Cập nhật sách trong kho sau khi cập nhật bán sách
CREATE TRIGGER trgCapNhatBanSach ON ChitietHoaDon  
AFTER UPDATE AS
BEGIN
   UPDATE Sach SET SoLuongTonKho = SoLuongTonKho -
	   (SELECT SoLuong FROM inserted WHERE ID_Sach = Sach.ID) +
	   (SELECT SoLuong FROM deleted WHERE ID_Sach = Sach.ID)
   FROM Sach 
   JOIN deleted ON Sach.ID = deleted.ID_Sach
END
GO

--4. Kiểm tra số lượng sách nhập phải lớn hơn 0 
CREATE TRIGGER trgSoLuongChiTietPhieuNhap ON ChiTietPhieuNhap
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

--5. Cập nhật số lượng sách sau khi nhập sách 
CREATE TRIGGER trgNhapSach ON ChitietPhieuNhap 
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
GO

--6. Cập nhật sách trong kho sau khi cập nhật nhập sách
CREATE TRIGGER trgCapNhatNhapSach ON ChitietPhieuNhap 
AFTER UPDATE AS
BEGIN
   UPDATE Sach SET SoLuongTonKho = SoLuongTonKho +
	   (SELECT SoLuong FROM inserted WHERE ID_Sach = Sach.ID) +
	   (SELECT SoLuong FROM deleted WHERE ID_Sach = Sach.ID)
   FROM Sach 
   JOIN deleted ON Sach.ID = deleted.ID_Sach
END
GO

--7. Ngày bắt đầu của giảm giá phải trước ngày kết thúc
CREATE TRIGGER trgNgayBatDau ON GiamGia
AFTER INSERT AS 
DECLARE @NgayBatDau datetime, @NgayKetThuc datetime
SELECT @NgayBatDau = ne.NgayBatDau, @NgayKetThuc = ne.NgayKetThuc 
FROM inserted ne
IF(@NgayBatDau >= @NgayKetThuc)
BEGIN
ROLLBACK
RAISERROR(N'Ngày bắt đầu của giảm giá phải trước ngày kết thúc', 16, 1)
RETURN
END
GO

--8. Trigger kiểm tra phần trăm giảm nhỏ hơn 100
CREATE TRIGGER trgPTGG ON GiamGia
AFTER INSERT AS 
DECLARE @PhanTramGG FLOAT
SELECT @PhanTramGG=PhanTramGG FROM inserted 
IF(@PhanTramGG>100)
BEGIN
ROLLBACK
RAISERROR(N'Phần trăm giảm giá không hợp lệ', 16, 1)
RETURN
END
GO

