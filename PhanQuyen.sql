use QuanLyCuaHangSach
go
--- tạo login
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
-- tạo user
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

exec sp_addrolemember 'db_owner', admin

exec sp_addrolemember 'db_datareader', viet
exec sp_addrolemember 'db_datareader', trung
exec sp_addrolemember 'db_datareader', diem
exec sp_addrolemember 'db_datareader', linh
exec sp_addrolemember 'db_datareader', thang

exec sp_addrolemember 'db_datawriter', viet
exec sp_addrolemember 'db_datawriter', trung
exec sp_addrolemember 'db_datawriter', diem
exec sp_addrolemember 'db_datawriter', linh
exec sp_addrolemember 'db_datawriter', thang


GRANT EXEC TO viet
GRANT EXEC TO trung
GRANT EXEC TO diem
GRANT EXEC TO linh
GRANT EXEC TO thang

REVOKE SELECT, INSERT, UPDATE, DELETE ON NhanVien FROM viet
REVOKE SELECT, INSERT, UPDATE, DELETE ON NhanVien FROM trung
REVOKE SELECT, INSERT, UPDATE, DELETE ON NhanVien FROM diem
REVOKE SELECT, INSERT, UPDATE, DELETE ON NhanVien FROM linh
REVOKE SELECT, INSERT, UPDATE, DELETE ON NhanVien FROM thang

REVOKE EXEC ON spGetNhanVien FROM viet
REVOKE EXEC ON spGetNhanVien FROM trung
REVOKE EXEC ON spGetNhanVien FROM linh
REVOKE EXEC ON spGetNhanVien FROM thang

REVOKE EXEC ON spDeleteNhanVien FROM viet
REVOKE EXEC ON spDeleteNhanVien FROM trung
REVOKE EXEC ON spDeleteNhanVien FROM diem
REVOKE EXEC ON spDeleteNhanVien FROM linh
REVOKE EXEC ON spDeleteNhanVien FROM thang

REVOKE EXEC ON spInsertNhanVien FROM viet
REVOKE EXEC ON spInsertNhanVien FROM trung
REVOKE EXEC ON spInsertNhanVien FROM diem
REVOKE EXEC ON spInsertNhanVien FROM linh
REVOKE EXEC ON spInsertNhanVien FROM thang

REVOKE EXEC ON spUpdateNhanVien FROM viet
REVOKE EXEC ON spUpdateNhanVien FROM trung
REVOKE EXEC ON spUpdateNhanVien FROM diem
REVOKE EXEC ON spUpdateNhanVien FROM linh
REVOKE EXEC ON spUpdateNhanVien FROM thang