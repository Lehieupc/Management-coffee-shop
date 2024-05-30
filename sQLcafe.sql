create database SQLcafe
use SQLcafe
create table Nhanvien(
	id varchar(10) primary key,
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
create table Menu(
	[Mã món] varchar(10) primary key,
	[Tên món] nvarchar(20),
	[Đơn giá] int,
	[Danh mục] nvarchar(20)
)
select * from Menu
select [Mật khẩu] from Nhanvien where [Tài khoản] = 'hieune' and [Mật khẩu] = ''