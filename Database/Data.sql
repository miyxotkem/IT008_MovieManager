CREATE DATABASE MovieManager
GO

USE MovieManager
GO

CREATE TABLE Movie
(
	id INT IDENTITY PRIMARY KEY,
	title NVARCHAR(100) NOT NULL,
	genre NVARCHAR(50) NOT NULL,
	rated NVARCHAR(100) NOT NULL,
	release_date DATE,
	director NVARCHAR(100),
	language NVARCHAR(50),
	duration INT, -- minute
	format NVARCHAR(50) NOT NULL,
	trailer NVARCHAR(100), -- URL
	actor NVARCHAR(150),
	brief NVARCHAR(1000)
)
GO

CREATE TABLE Hall
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	location NVARCHAR(100)
)
GO

CREATE TABLE Screen
(
	id INT IDENTITY PRIMARY KEY,
	number INT NOT NULL,
	capacity INT,
	available_seat INT,
	type NVARCHAR(100),
	idhall INT

	FOREIGN KEY (idhall) REFERENCES dbo.Hall(id)
)
GO

CREATE TABLE Seat
(
	id INT IDENTITY PRIMARY KEY,
	row INT,
	number INT,
	type NVARCHAR(100),
	idscreen INT

	FOREIGN KEY (idscreen) REFERENCES dbo.Screen(id)
)
GO

CREATE TABLE Customer
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Khach',
	email VARCHAR(20) DEFAULT NULL,
	phone_number VARCHAR(11) DEFAULT NULL,
	membership INT DEFAULT 0 -- 0: none, 1: bronze, 2: silver, 3: gold, etc.
)
GO

CREATE TABLE Shift_Schedule
(
	id INT IDENTITY PRIMARY KEY,
	start_schedule TIME,
	end_schedule TIME
)
GO

CREATE TABLE Staff
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	role NVARCHAR(20),
	contact_info NVARCHAR(100),
	idshiftschedule INT,

	FOREIGN KEY (idshiftschedule) REFERENCES dbo.Shift_Schedule(id)
)
GO

CREATE TABLE Snack
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	price FLOAT,
	stock INT,
	category INT -- 0: food, 1: beverage
)
GO

CREATE TABLE ShowTime (
	id INT IDENTITY PRIMARY KEY,
	idmovie INT,
	idscreen INT,
	idhall INT,
	start_time DATETIME,
	end_time DATETIME

	FOREIGN KEY (idmovie) REFERENCES Movie(id),
	FOREIGN KEY (idscreen) REFERENCES Screen(id),
	FOREIGN KEY (idhall) REFERENCES Hall(id)
)
GO

CREATE TABLE Ticket
(
	id INT IDENTITY PRIMARY KEY,
	price FLOAT CHECK(price >= 0),
	purchase_date DATE DEFAULT GETDATE(),
	payment_method NVARCHAR(100),
	payment_status BIT DEFAULT 1, -- 0: unpaid, 1: paid
	discount INT DEFAULT 0 CHECK(discount >= 0 AND discount <= 100), -- in percent
	idseat INT,
	idcustomer INT,
	idstaff INT,
	idsnack INT,
	idshowtime INT

	FOREIGN KEY (idseat) REFERENCES dbo.Seat(id),
	FOREIGN KEY (idcustomer) REFERENCES dbo.Customer(id),
	FOREIGN KEY (idstaff) REFERENCES dbo.Staff(id),
	FOREIGN KEY (idsnack) REFERENCES dbo.Snack(id),
	FOREIGN KEY (idshowtime) REFERENCES dbo.ShowTime(id)
)
GO

CREATE TABLE TicketSnack
(
    idticket INT,
    idsnack INT,
    quantity INT DEFAULT 1,

    FOREIGN KEY (idticket) REFERENCES Ticket(id),
    FOREIGN KEY (idsnack) REFERENCES Snack(id),

	PRIMARY KEY (idticket, idsnack)
)
GO

CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	username VARCHAR(100),
	password VARCHAR(100),
	admin BIT,
	idStaff INT,
	accept BIT DEFAULT 0,

	FOREIGN KEY (idStaff) REFERENCES dbo.Staff
)
GO

CREATE PROC USP_Login
@username VARCHAR(100), @password VARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE username = @username AND password = @password
END
GO

CREATE TABLE ForgetPassword
(
	idStaff INT,
	verification VARCHAR(6),

	FOREIGN KEY (idstaff) REFERENCES dbo.Staff(id),
	PRIMARY KEY (idStaff, verification)
)
GO

CREATE PROC USP_GetMovieList
AS SELECT * FROM dbo.Movie
GO

SET DATEFORMAT dmy;
GO

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'TEE YOD: QUỶ ĂN TẠNG - PHẦN 3', N'N/A', N'N/A', '10/10/2025', N'Narit Yuvaboon', N'Tiếng Thái', 104, N'iMax', N'https://youtu.be/DMOGnGokm4c', N'Nadech Kugimiya, Denise Jelilcha Kapaun, Mim Rattawadee Wongthong, Junior Kajbhunditt Jaidee, ...');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'TAY ANH GIỮ MỘT VÌ SAO', N'N/A', N'N/A', '03/10/2025', N'Kim Sung Hoon', N'Tiếng Hàn', 117, N'N/A', N'https://youtu.be/ZsSYbAy2Ez8', N'Lee Kwang Soo, Hoàng Hà, Duy Khánh, Cù Thị Trà, Um Mun Suk, Lâm Thanh Mỹ, ...');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'TỬ CHIẾN TRÊN KHÔNG', N'N/A', N'N/A', '19/09/2025', N'Hàm Trần', N'Tiếng Việt', 118, N'4DX', N'https://youtu.be/h4O-GbuwwlM', N'Thái Hòa, Kaity Nguyễn, Thanh Sơn, Xuân Phúc, Võ Điền Gia Huy, Trần Ngọc Vàng, ...');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'THE CONJURING: NGHI LỄ CUỐI CÙNG', N'N/A', N'N/A', '12/09/2025', N'Michael Chaves', N'Tiếng Anh', 136, N'N/A', N'https://youtu.be/sbsNPOzdBg0', N'Patrick Wilson, Vera Farmiga, Ben Hardy, Beau Gadsdon, ...');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'Tron: Ares (Trò Chơi Ảo Giác: Ares)', N'N/A', N'N/A', '10/10/2025', N'Joachim Rønning', N'Tiếng Anh', 118, N'iMax', N'https://youtu.be/oQVd-gXMQ6I', N'Jared Leto, Greta Lee, Evan Peters, Hasan Minhaj, Jodie Turner-Smith, Arturo Castro, ...');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'EXIT 8: GA TÀU VÔ TẬN', N'N/A', N'N/A', '26/09/2025', N'Genki Kawamura', N'Tiếng Nhật', 95, N'N/A', N'https://youtu.be/YXR0tMXhnog', N'Kazunari Ninomiya, Yamato Kochi, Nana Komatsu');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'LỌ LEM CHƠI NGẢI', N'N/A', N'N/A', '07/11/2025', N'Hadrah Daeng Ratu', N'Tiếng Indonesia - phụ đề Tiếng Việt, Tiếng Anh', 98, N'N/A', N'https://youtu.be/u0A17Cn7Yo0', N'Yunita Siregar, Dinda Kanyadewi, Tarra Budiman');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'CỤC VÀNG CỦA NGOẠI', N'N/A', N'N/A', '17/10/2025', N'Khương Ngọc', N'Tiếng Việt', 119, N'N/A', N'https://youtu.be/YPCtgD0KnGk', N'Việt Hương, Hồng Đào, Lê Khánh, Băng Di, Lâm Thanh Mỹ, Hữu Châu, Tuấn Khải, ...');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'ZOOTOPIA 2 - Phi Vụ Động Trời 2', N'N/A', N'N/A', '28/11/2025', N'Jared Bush, Byron Howard', N'Tiếng Anh', NULL, N'N/A', N'https://youtu.be/YGITWOibh10', N'Jason Bateman, Quinta Brunson, Fortune Feimster');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)
VALUES (N'ĐIỆN THOẠI ĐEN 2', N'N/A', N'N/A', '31/10/2025', N'Scott Derrickson', N'Tiếng Anh', NULL, N'N/A', N'https://youtu.be/Uo5sNWGrFQ8', N'Ethan Hawke, Mason Thames, Madeleine McGraw, Demián Bichir, Miguel Mora, ...');
GO

UPDATE Movie
SET duration = 0
WHERE duration IS NULL;
GO

SELECT * FROM MOVIE;
GO

INSERT INTO dbo.Shift_Schedule VALUES('7:30:00', '12:30:00');
INSERT INTO dbo.Shift_Schedule VALUES('12:30:00', '17:30:00');
INSERT INTO dbo.Shift_Schedule VALUES('17:30:00', '22:30:00');
INSERT INTO dbo.Shift_Schedule VALUES('22:30:00', '2:30:00');
GO

SELECT * FROM dbo.Shift_Schedule;
GO

INSERT INTO dbo.Staff VALUES(N'Nguyễn Minh Anh', N'Giám đốc marketing', N'mlanhmlanh214@gmail.com', 1);
INSERT INTO dbo.Staff VALUES(N'Trần Minh Đức', N'Nhân viên', N'minhduct50@gmail.com', 1);
INSERT INTO dbo.Staff VALUES(N'Phạm Đan Trường', N'Quản lý', N'truongpd.a2.2124@gmail.com', 1);
INSERT INTO dbo.Staff VALUES(N'Hồ Thịnh Phát', N'Quản lý', N'phatht.a2.2124@gmail.com', 3);
INSERT INTO dbo.Staff VALUES(N'Võ Việt Thy', N'Nhân viên', N'thyvv.a2.2124@gmail.com', 2);
INSERT INTO dbo.Staff VALUES(N'Lê Phương Thúy', N'Nhân viên', N'thuylp.a2.2124@gmail.com', 3);
INSERT INTO dbo.Staff VALUES(N'Nguyễn Thanh Hiếu Thảo', N'Nhân viên', N'thaontt.a2.2124@gmail.com', 4);
GO

SELECT * FROM dbo.Staff;
GO

INSERT INTO dbo.Account VALUES('minhanh2104', 'tpnma@', '1', '1', '1');
INSERT INTO dbo.Account VALUES('minhduc2303', 'tptmd@', '0', '2', '1');
INSERT INTO dbo.Account VALUES('dantruong2007', 'tppdt@', '1', '3', '1');
INSERT INTO dbo.Account VALUES('thinhphat1512', 'tphtp@', '1', '4', '1');
INSERT INTO dbo.Account VALUES('vietthy1908', 'tpvvt@', '0', '5', '1');
INSERT INTO dbo.Account VALUES('phuongthuy2505', 'tplpt@', '0', '6', '1');
INSERT INTO dbo.Account VALUES('hieuthao2103', 'tpntht@', '0', '7', '1');
GO

SELECT * FROM dbo.Account;
GO
