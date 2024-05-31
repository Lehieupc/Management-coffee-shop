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
create table Danhmuc(
	[Mã danh mục] varchar(10),
	[Tên danh mục] nvarchar(30)
)
select * from Danhmuc
create table Hoadon(
	[Mã hóa đơn] int identity(1,1) primary key,
	[Tổng tiền] int,
	CreatedAt DATETIME DEFAULT GETDATE()
)
select * from Hoadon
create table DSbanchay(
	[Tên món] nvarchar(30),
	[Số lượng] int
)
select * from DSbanchay
select * from Hoadon where CreatedAt >= '2024-06-01 ' and CreatedAt <= '2024-07-01'