USE QuanLyCuaHangSach
GO

-- NhanVien

CREATE PROCEDURE spGetNhanVien
AS
BEGIN
	SELECT * FROM NhanVien
END
GO

CREATE PROCEDURE spUpdateNhanVien
	@ID bigint,
	@Username varchar(50),
	@Password varchar(50),
	@HoTen nvarchar(50),
	@DiaChi nvarchar(200),
	@SDT varchar(11),
	@Luong bigint,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE NhanVien
	SET 
		Username = @Username,
		Password = @Password,
		HoTen = @HoTen,
		DiaChi = @DiaChi,
		SDT = @SDT,
		Luong = @Luong,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO

CREATE PROCEDURE spDeleteNhanVien
	@ID bigint
AS
BEGIN
	DELETE FROM NhanVien
	WHERE ID = @ID
END
GO

CREATE PROCEDURE spInsertNhanVien
	@Username varchar(50),
	@Password varchar(50),
	@HoTen nvarchar(50),
	@DiaChi nvarchar(200),
	@SDT varchar(11),
	@Luong bigint,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO NhanVien (Username, Password, HoTen, DiaChi, SDT, Luong, NgayTao, NgayUpdate) 
	VALUES 
	(
		@Username,
		@Password,
		@HoTen,
		@DiaChi,
		@SDT,
		@Luong,
		@NgayTao,
		@NgayUpdate
	)
END
GO

-- LoaiThanhVien

CREATE PROCEDURE spGetLoaiThanhVien
AS
BEGIN
	SELECT * FROM LoaiThanhVien
END
GO

CREATE PROCEDURE spInsertLoaiThanhVien
	@TenLoaiTV nvarchar(50),
	@MucUuDai float,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO LoaiThanhVien(TenLoaiTV, MucUuDai, NgayTao, NgayUpdate) 
	VALUES 
	(
		@TenLoaiTV,
		@MucUuDai,
		@NgayTao,
		@NgayUpdate
	)
END
GO

CREATE PROCEDURE spUpdateLoaiThanhVien
	@ID bigint,
	@TenLoaiTV nvarchar(50),
	@MucUuDai float,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE LoaiThanhVien
	SET 
		TenLoaiTV = @TenLoaiTV,
		MucUuDai = @MucUuDai,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO

CREATE PROCEDURE spDeleteLoaiThanhVien
	@ID bigint
AS
BEGIN
	DELETE FROM LoaiThanhVien
	WHERE ID = @ID
END
GO

--ThanhVien
CREATE PROCEDURE spGetThanhVien
AS
BEGIN
	SELECT * FROM ThanhVien
END
GO

CREATE PROC spUpdateThanhVien
	@ID BIGINT,
	@HoTen NVARCHAR(50),
	@DiaChi NVARCHAR(200), 
	@SDT VARCHAR(11), 
	@NgayTao DATETIME,
	@NgayUpdate DATETIME, 
	@ID_LoaiTV BIGINT
AS
BEGIN
	UPDATE ThanhVien 
	SET 
		HoTen = @HoTen, 
		DiaChi = @DiaChi, 
		SDT = @SDT, 
		NgayTao = @NgayTao, 
		NgayUpdate = @NgayUpdate,
		ID_LoaiTV = @ID_LoaiTV
	WHERE ID = @ID
END
GO

CREATE PROC spInsertThanhVien
	@HoTen NVARCHAR(50),
	@DiaChi NVARCHAR(200), 
	@SDT VARCHAR(11), 
	@NgayTao DATETIME,
	@NgayUpdate DATETIME, 
	@ID_LoaiTV BIGINT
AS
BEGIN
	INSERT INTO ThanhVien (HoTen, DiaChi, SDT, NgayTao,  NgayUpdate, ID_LoaiTV) 
	VALUES 
	( 
		@HoTen, 
		@DiaChi, 
		@SDT, @NgayTao, 
		@NgayUpdate, 
		@ID_LoaiTV
	)
END
GO

CREATE PROC spDeleteThanhVien
@ID BIGINT
AS
BEGIN
	DELETE FROM ThanhVien WHERE ID=@ID
END
GO

-- TacGia

CREATE PROCEDURE spDeleteTacGia
	@ID bigint
AS
BEGIN
	DELETE FROM TacGia
	WHERE ID = @ID
END
GO

CREATE PROCEDURE spInsertTacGia
	@TenTacGia nvarchar(50),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO TacGia(TenTacGia, NgayTao, NgayUpdate) 
	VALUES 
	(
		@TenTacGia,
		@NgayTao,
		@NgayUpdate
	)
END
GO

CREATE PROCEDURE spUpdateTacGia
	@ID bigint,
	@TenTacGia nvarchar(50),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE TacGia
	SET 
		TenTacGia = @TenTacGia,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO

CREATE PROCEDURE spGetTacGia
AS
BEGIN
	SELECT * FROM TacGia
END
GO

--LOAI SACH
CREATE PROCEDURE spGetLoaiSach
AS
BEGIN
	SELECT * FROM LoaiSach
END
go

CREATE PROCEDURE spUpdateLoaiSach
	@ID bigint,
	@TenLoaiSach nvarchar(200),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE LoaiSach
	SET 
		TenLoaiSach = @TenLoaiSach,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
go

CREATE PROCEDURE spDeleteLoaiSach
	@ID bigint
AS
BEGIN
	DELETE FROM LoaiSach
	WHERE ID = @ID
END
go

CREATE PROCEDURE spInsertLoaiSach
	@TenLoaiSach nvarchar(200),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO LoaiSach (TenLoaiSach,NgayTao,NgayUpdate) 
	VALUES 
	(
		@TenLoaiSach,
		@NgayTao,
		@NgayUpdate
	)
END
go

-- Sach

CREATE PROCEDURE spGetSach
AS
BEGIN
	SELECT * FROM Sach
END
GO

CREATE PROCEDURE spUpdateSach
	@ID bigint,
	@TenSach nvarchar(200),
	@ID_LoaiSach bigint,
	@ID_NXB bigint,
	@ID_TacGia bigint,
	@GiaBan bigint,
	@SoLuongTonKho int,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE Sach
	SET 
		TenSach = @TenSach,
		ID_LoaiSach = @ID_LoaiSach,
		ID_NXB = @ID_NXB,
		ID_TacGia = @ID_TacGia,
		GiaBan = @GiaBan,
		SoLuongTonKho=@SoLuongTonKho,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO

CREATE PROCEDURE spDeleteSach
	@ID bigint
AS
BEGIN
	DELETE FROM Sach
	WHERE ID = @ID
END
GO

CREATE PROCEDURE spInsertSach
	@TenSach nvarchar(200),
	@ID_LoaiSach bigint,
	@ID_NXB bigint,
	@ID_TacGia bigint,
	@GiaBan bigint,
	@SoLuongTonKho int,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO Sach (TenSach,ID_LoaiSach,ID_NXB,ID_TacGia,GiaBan,SoLuongTonKho,NgayTao,NgayUpdate) 
	VALUES 
	(
		@TenSach,
		@ID_LoaiSach,
		@ID_NXB,
		@ID_TacGia,
		@GiaBan,
		@SoLuongTonKho,
		@NgayTao,
		@NgayUpdate
	)
END
GO

-- NXB

CREATE PROCEDURE spGetNXB
AS
BEGIN
	SELECT * FROM NXB
END
GO

CREATE PROCEDURE spInsertNXB
	@TenNXB nvarchar(200),
	@DiaChi nvarchar(200),
	@SDT varchar(11),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO NXB(TenNXB, DiaChi,SDT, NgayTao, NgayUpdate) 
	VALUES 
	(
		@TenNXB,
		@DiaChi,
		@SDT,
		@NgayTao,
		@NgayUpdate
	)
END
GO

CREATE PROCEDURE spUpdateNXB
	@ID bigint,
	@TenNXB nvarchar(200),
	@DiaChi nvarchar(200),
	@SDT varchar(11),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE NXB
	SET 
		TenNXB = @TenNXB,
		DiaChi=@DiaChi,
		SDT=@SDT,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO

CREATE PROCEDURE spDeleteNXB
	@ID bigint
AS
BEGIN
	DELETE FROM NXB
	WHERE ID = @ID
END
GO

-- PhieuNhap
CREATE PROCEDURE spGetPhieuNhap
AS
BEGIN
	SELECT * FROM PhieuNhap
END
GO

CREATE PROCEDURE spDeletePhieuNhap
	@ID bigint
AS
BEGIN
	DELETE FROM PhieuNhap
	WHERE ID = @ID
END
GO

CREATE PROCEDURE spInsertPhieuNhap
	@ID_NV bigint,
	@ID_NXB bigint,
	@NgayNhap datetime,
	@ThanhTien bigint,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO PhieuNhap(ID_NV,ID_NXB,NgayNhap,ThanhTien, NgayTao, NgayUpdate) 
	VALUES 
	(
		@ID_NV,
		@ID_NXB,
		@NgayNhap,
		@ThanhTien,
		@NgayTao,
		@NgayUpdate
	)
END
GO

CREATE PROCEDURE spUpdatePhieuNhap
	@ID bigint,
	@ID_NV bigint,
	@ID_NXB bigint,
	@NgayNhap datetime,
	@ThanhTien bigint,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE PhieuNhap
	SET 
		ID_NV=@ID_NV,
		ID_NXB=@ID_NXB,
		NgayNhap=@NgayNhap,
		ThanhTien=@ThanhTien,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO

--ChiTietPhieuNhap

CREATE PROCEDURE spGetChiTietPhieuNhap
AS
BEGIN
	SELECT * FROM ChiTietPhieuNhap
END

CREATE PROC spUpdateChiTietPhieuNhap
	@ID_PN BIGINT,
	@ID_Sach BIGINT,
	@SoLuong INT,
	@GiaTong BIGINT,
	@NgayTao DATETIME,
	@NgayUpdate DATETIME

AS
BEGIN
	UPDATE ChiTietPhieuNhap
	SET 
		ID_PN = @ID_PN,
		ID_Sach = @ID_Sach,
		SoLuong = @SoLuong,
		GiaTong = @GiaTong,
		NgayTao = @NgayTao, 
		NgayUpdate = @NgayUpdate
	WHERE ID_PN = @ID_PN AND ID_Sach = @ID_Sach
END
GO

CREATE PROC spInsertChiTietPhieuNhap
	@ID_PN BIGINT,
	@ID_Sach BIGINT,
	@SoLuong INT,
	@GiaTong BIGINT,
	@NgayTao DATETIME,
	@NgayUpdate DATETIME
AS
BEGIN
	INSERT INTO ChiTietPhieuNhap (ID_PN, ID_Sach, GiaTong, NgayTao, NgayUpdate)
	VALUES 
	(
		@ID_PN,
		@ID_Sach,
		@SoLuong, 
		@GiaTong, 
		@NgayTao, 
		@NgayUpdate
	)
END
GO

CREATE PROC spDeleteChiTietPhieuNhap
@ID_PN BIGINT,
@ID_Sach BIGINT
AS
BEGIN
	DELETE FROM ChiTietPhieuNhap WHERE ID_PN = @ID_PN AND ID_Sach = ID_Sach
END
GO

--HoaDon
CREATE PROCEDURE spGetHoaDon
AS
BEGIN
	SELECT * FROM HoaDon
END
Go
CREATE PROCEDURE spUpdateHoaDon
	@ID bigint,
	@ID_NV bigint,
	@ID_TV bigint,
	@ID_GG bigint,
	@NgayMua datetime,
	@ThanhTien bigint,
	@NgayBatDau datetime,
	@NgayKetThuc datetime,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE HoaDon
	SET 
		ID_NV=@ID_NV,
		ID_TV=@ID_TV,
		ID_GG=@ID_GG,
		NgayMua=@NgayMua,
		ThanhTien=@ThanhTien,
		NgayBatDau=@NgayBatDau,
		NgayKetThuc=@NgayKetThuc,
		NgayTao=@NgayTao,
		NgayUpdate=@NgayUpdate
	WHERE ID = @ID
END
Go

CREATE PROCEDURE spDeleteHoaDon
	@ID bigint
AS
BEGIN
	DELETE FROM HoaDon
	WHERE ID = @ID
END
Go

CREATE PROCEDURE spInsertHoaDon
	@ID_NV bigint,
	@ID_TV bigint,
	@ID_GG bigint,
	@NgayMua datetime,
	@ThanhTien bigint,
	@NgayBatDau datetime,
	@NgayKetThuc datetime,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO HoaDon (ID_NV,ID_TV,ID_GG,NgayMua,ThanhTien,NgayBatDau,NgayKetThuc,NgayTao,NgayUpdate) 
	VALUES 
	(
		@ID_NV,
		@ID_TV,
		@ID_GG,
		@NgayMua,
		@ThanhTien,
		@NgayBatDau,
		@NgayKetThuc,
		@NgayTao,
		@NgayUpdate
	)
END
Go

--Chi Tiet Hoa Don
CREATE PROCEDURE spGetChiTietHoaDon
AS
BEGIN
	SELECT * FROM ChiTietHoaDon
END
go

CREATE PROCEDURE spUpdateChiTietHoaDon
	@ID_HD bigint,
	@ID_Sach bigint,
	@SoLuong int,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE ChiTietHoaDon
	SET 
		ID_HD = @ID_HD,
		ID_Sach= @ID_Sach,
		SoLuong= @SoLuong,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID_HD = @ID_HD AND ID_Sach=@ID_Sach
END
go

CREATE PROCEDURE spDeleteChiTietHoaDon
	@ID_HD bigint,
	@ID_Sach bigint
AS
BEGIN
	DELETE FROM ChiTietHoaDon
	WHERE ID_HD = @ID_HD AND ID_Sach = @ID_Sach
END
go

CREATE PROCEDURE spInsertChiTietHoaDon
	@ID_HD bigint,
	@ID_Sach bigint,
	@SoLuong int,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO ChiTietHoaDon (ID_HD,ID_Sach,SoLuong,NgayTao,NgayUpdate) 
	VALUES 
	(
		@ID_HD,
		@ID_Sach,
		@SoLuong ,
		@NgayTao,
		@NgayUpdate
	)
END
Go

--GiamGia
CREATE PROCEDURE spGetGiamGia
AS
BEGIN
	SELECT * FROM GiamGia
END
Go

CREATE PROCEDURE spUpdateGiamGia
	@ID bigint,
	@NgayBatDau datetime,
	@NgayKetThuc datetime,
	@PhanTramGG float,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE GiamGia
	SET 
		NgayBatDau = @NgayBatDau,
		NgayKetThuc = @NgayKetThuc,
		PhanTramGG = @PhanTramGG,
		NgayTao = @NgayTao,
		NgayUpdate= @NgayUpdate
	WHERE ID = @ID
END
Go

CREATE PROCEDURE spDeleteGiamGia
	@ID bigint
AS
BEGIN
	DELETE FROM GiamGia
	WHERE ID = @ID
END
Go

CREATE PROCEDURE spInsertGiamGia
	@NgayBatDau datetime,
	@NgayKetThuc datetime,
	@PhanTramGG float,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO GiamGia (NgayBatDau,NgayKetThuc,PhanTramGG,NgayTao,NgayUpdate) 
	VALUES 
	(
		@NgayBatDau,
		@NgayKetThuc,
		@PhanTramGG,
		@NgayTao,
		@NgayUpdate
	)
END
Go





