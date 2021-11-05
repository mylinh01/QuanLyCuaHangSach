use QuanLyCuaHangSach
go
--- Tạo login
create login admin with password = '12345'
go
create login viet with password = '12345'
go
create login trung with password = '12345'
go
create login diem with password = '12345'
go
create login linh with password = '12345'
go
create login thang with password = '12345'
go
-- Tạo user cho login
create user admin for login admin
go
create user viet for login viet
go
create user trung for login trung
go
create user diem for login diem
go
create user linh for login linh
go
create user thang for login thang
go

--Cấp cho admin toàn bộ quyền
exec sp_addrolemember 'db_owner', admin
--Cấp quyền thêm, xóa, cập nhật dữ liệu trong các bảng cho các user
GRANT SELECT, INSERT, UPDATE, DELETE TO viet
GRANT SELECT, INSERT, UPDATE, DELETE TO trung
GRANT SELECT, INSERT, UPDATE, DELETE TO diem
GRANT SELECT, INSERT, UPDATE, DELETE TO linh
GRANT SELECT, INSERT, UPDATE, DELETE TO thang
----Từ chối quyền thêm, xóa, cập nhật dữ liệu trong bảng NhanVien của các user
DENY SELECT, INSERT, UPDATE, DELETE ON NhanVien TO viet
DENY SELECT, INSERT, UPDATE, DELETE ON NhanVien TO trung
DENY SELECT, INSERT, UPDATE, DELETE ON NhanVien TO diem
DENY SELECT, INSERT, UPDATE, DELETE ON NhanVien TO linh
DENY SELECT, INSERT, UPDATE, DELETE ON NhanVien TO thang

--Cấp quyền thực thi các Stored Procedures cho các user
GRANT EXEC TO viet
GRANT EXEC TO trung
GRANT EXEC TO diem
GRANT EXEC TO linh
GRANT EXEC TO thang

--Từ chối quyền thực thi các Stored Procedures NhanVien của các user
DENY EXEC ON spGetNhanVien TO viet
DENY EXEC ON spGetNhanVien TO trung
DENY EXEC ON spGetNhanVien TO linh
DENY EXEC ON spGetNhanVien TO thang

DENY EXEC ON spDeleteNhanVien TO viet
DENY EXEC ON spDeleteNhanVien TO trung
DENY EXEC ON spDeleteNhanVien TO diem
DENY EXEC ON spDeleteNhanVien TO linh
DENY EXEC ON spDeleteNhanVien TO thang

DENY EXEC ON spInsertNhanVien TO viet
DENY EXEC ON spInsertNhanVien TO trung
DENY EXEC ON spInsertNhanVien TO diem
DENY EXEC ON spInsertNhanVien TO linh
DENY EXEC ON spInsertNhanVien TO thang

DENY EXEC ON spUpdateNhanVien TO viet
DENY EXEC ON spUpdateNhanVien TO trung
DENY EXEC ON spUpdateNhanVien TO diem
DENY EXEC ON spUpdateNhanVien TO linh
DENY EXEC ON spUpdateNhanVien TO thang