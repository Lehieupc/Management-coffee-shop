create database SQLcafe
use SQLcafe
create table Nhanvien(
	id varchar(10),
	[Họ tên] nvarchar(20), 
	[Ngày sinh] date,
	[Giới tính] nvarchar(3),
	[SDT] nvarchar(11),
	[Địa chỉ] nvarchar(20),
	[Tài khoản] varchar(20),
	[Mật khẩu] varchar(20),
	[Vai trò] nvarchar(10)
)
select * from Nhanvien