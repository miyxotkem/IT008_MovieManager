CREATE DATABASE MovieManager
USE MovieManager

-- Table
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
	trailer VARCHAR(100), -- URL
	actor NVARCHAR(150),
	brief NVARCHAR(300)
)
CREATE TABLE Hall
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	location NVARCHAR(100)
)
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
CREATE TABLE Seat
(
	id INT IDENTITY PRIMARY KEY,
	row varchar(3),
	number INT,
	type NVARCHAR(100)
)
CREATE TABLE Customer
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Guest',
	email VARCHAR(20) DEFAULT NULL,
	phone_number VARCHAR(11) DEFAULT NULL,
	membership INT DEFAULT 0 -- 0: none, 1: bronze, 2: silver, 3: gold, etc.
)
CREATE TABLE ShiftSchedule
(
	id INT IDENTITY PRIMARY KEY,
	start_schedule TIME,
	end_schedule TIME
)
CREATE TABLE Staff
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	role NVARCHAR(20),
	contact_info NVARCHAR(100),
	idshiftschedule INT,

	FOREIGN KEY (idshiftschedule) REFERENCES dbo.Shift_Schedule(id)
)
CREATE TABLE Snack
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	price FLOAT,
	stock INT,
	category INT -- 0: food, 1: beverage
)
CREATE TABLE ShowTime (
	idmovie INT,
	idscreen INT,
	idseat INT,
	start_time DATETIME,
	available BIT DEFAULT 0

	FOREIGN KEY (idmovie) REFERENCES Movie(id),
	FOREIGN KEY (idscreen) REFERENCES Screen(id),
	FOREIGN KEY (idseat) REFERENCES Seat(id),

	PRIMARY KEY (idmovie, idscreen, idseat, start_time)
)
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
	FOREIGN KEY (idsnack) REFERENCES dbo.Snack(id)
)
CREATE TABLE TicketSnack
(
    idticket INT,
    idsnack INT,
    quantity INT DEFAULT 1,

    FOREIGN KEY (idticket) REFERENCES Ticket(id),
    FOREIGN KEY (idsnack) REFERENCES Snack(id),

	PRIMARY KEY (idticket, idsnack)
)
CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	username VARCHAR(100),
	password VARCHAR(100),
	admin BIT DEFAULT 0,
	idStaff INT,
	accept BIT DEFAULT 0,

	FOREIGN KEY (idStaff) REFERENCES dbo.Staff
)
CREATE TABLE ForgetPassword
(
	idStaff INT,
	verification VARCHAR(6),

	FOREIGN KEY (idstaff) REFERENCES dbo.Staff(id),
	PRIMARY KEY (idStaff, verification)
)

SET DATEFORMAT dmy;

-- INSERT
INSERT INTO dbo.Hall (name, location)VALUES (N'CGV Binh Duong', N'3rd Floor, Aeon Mall');
INSERT INTO dbo.Hall (name, location)VALUES (N'Lotte Cinema Thu Duc', N'5th Floor, Giga Mall');

INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (1, 50, 50, N'2D', 1);
INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (2, 50, 50, N'2D', 1);
INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (3, 50, 50, N'iMax', 1);
INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (4, 50, 50, N'2D', 1);
INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (5, 50, 50, N'iMax', 1);

INSERT INTO dbo.Seat (row, number, type)
VALUES
-- Row 1 (Row A - Normal)
('A', 1, N'Normal'),
('A', 2, N'Normal'),
('A', 3, N'Normal'),
('A', 4, N'Normal'),
('A', 5, N'Normal'),
('A', 6, N'Normal'),
('A', 7, N'Normal'),
('A', 8, N'Normal'),
('A', 9, N'Normal'),
('A', 10, N'Normal'),

-- Row 2 (Row B - Normal) -> Đổi số 2 thành 'B'
('B', 1, N'Normal'),
('B', 2, N'Normal'),
('B', 3, N'Normal'), -- Đã sửa lỗi thiếu dấu nháy ở đây
('B', 4, N'Normal'),
('B', 5, N'Normal'),
('B', 6, N'Normal'),
('B', 7, N'Normal'),
('B', 8, N'Normal'),
('B', 9, N'Normal'),
('B', 10, N'Normal'),

-- Row 3 (Row C - VIP) -> Đổi số 3 thành 'C'
('C', 1, N'VIP'),
('C', 2, N'VIP'),
('C', 3, N'VIP'),
('C', 4, N'VIP'),
('C', 5, N'VIP'),
('C', 6, N'VIP'),
('C', 7, N'VIP'),
('C', 8, N'VIP'),
('C', 9, N'VIP'),
('C', 10, N'VIP'),

-- Row 4 (Row D - VIP) -> Đổi số 4 thành 'D'
('D', 1, N'VIP'),
('D', 2, N'VIP'),
('D', 3, N'VIP'),
('D', 4, N'VIP'),
('D', 5, N'VIP'),
('D', 6, N'VIP'),
('D', 7, N'VIP'),
('D', 8, N'VIP'),
('D', 9, N'VIP'),
('D', 10, N'VIP'),

-- Row 5 (Row E - Couple & SVIP) -> Đổi số 5 thành 'E'
('E', 1, N'Couple'),
('E', 2, N'Couple'),
('E', 3, N'Couple'),
('E', 4, N'Couple'),
('E', 5, N'Couple'),
('E', 6, N'SVIP'),
('E', 7, N'SVIP'),
('E', 8, N'SVIP'),
('E', 9, N'SVIP'),
('E', 10, N'SVIP');

INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'TEE YOD: QUỶ ĂN TẠNG - PHẦN 3', N'N/A', N'N/A', '10/10/2025', N'Narit Yuvaboon', N'Tiếng Thái', 104, N'iMax', N'https://youtu.be/DMOGnGokm4c', N'Nadech Kugimiya, Denise Jelilcha Kapaun, Mim Rattawadee Wongthong, Junior Kajbhunditt Jaidee, ...');
INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'TAY ANH GIỮ MỘT VÌ SAO', N'N/A', N'N/A', '03/10/2025', N'Kim Sung Hoon', N'Tiếng Hàn', 117, N'N/A', N'https://youtu.be/ZsSYbAy2Ez8', N'Lee Kwang Soo, Hoàng Hà, Duy Khánh, Cù Thị Trà, Um Mun Suk, Lâm Thanh Mỹ, ...');
INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'TỬ CHIẾN TRÊN KHÔNG', N'N/A', N'N/A', '19/09/2025', N'Hàm Trần', N'Tiếng Việt', 118, N'4DX', N'https://youtu.be/h4O-GbuwwlM', N'Thái Hòa, Kaity Nguyễn, Thanh Sơn, Xuân Phúc, Võ Điền Gia Huy, Trần Ngọc Vàng, ...');
INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'THE CONJURING: NGHI LỄ CUỐI CÙNG', N'N/A', N'N/A', '12/09/2025', N'Michael Chaves', N'Tiếng Anh', 136, N'N/A', N'https://youtu.be/sbsNPOzdBg0', N'Patrick Wilson, Vera Farmiga, Ben Hardy, Beau Gadsdon, ...');
INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'Tron: Ares (Trò Chơi Ảo Giác: Ares)', N'N/A', N'N/A', '10/10/2025', N'Joachim Rønning', N'Tiếng Anh', 118, N'iMax', N'https://youtu.be/oQVd-gXMQ6I', N'Jared Leto, Greta Lee, Evan Peters, Hasan Minhaj, Jodie Turner-Smith, Arturo Castro, ...');
INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'EXIT 8: GA TÀU VÔ TẬN', N'N/A', N'N/A', '26/09/2025', N'Genki Kawamura', N'Tiếng Nhật', 95, N'N/A', N'https://youtu.be/YXR0tMXhnog', N'Kazunari Ninomiya, Yamato Kochi, Nana Komatsu');
INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'LỌ LEM CHƠI NGẢI', N'N/A', N'N/A', '07/11/2025', N'Hadrah Daeng Ratu', N'Tiếng Indonesia - phụ đề Tiếng Việt, Tiếng Anh', 98, N'N/A', N'https://youtu.be/u0A17Cn7Yo0', N'Yunita Siregar, Dinda Kanyadewi, Tarra Budiman');
INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'CỤC VÀNG CỦA NGOẠI', N'N/A', N'N/A', '17/10/2025', N'Khương Ngọc', N'Tiếng Việt', 119, N'N/A', N'https://youtu.be/YPCtgD0KnGk', N'Việt Hương, Hồng Đào, Lê Khánh, Băng Di, Lâm Thanh Mỹ, Hữu Châu, Tuấn Khải, ...');
INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'ZOOTOPIA 2 - Phi Vụ Động Trời 2', N'N/A', N'N/A', '28/11/2025', N'Jared Bush, Byron Howard', N'Tiếng Anh', NULL, N'N/A', N'https://youtu.be/YGITWOibh10', N'Jason Bateman, Quinta Brunson, Fortune Feimster');
INSERT INTO Movie (title, genre, rated, release_date, director, language, duration, format, trailer, actor)VALUES (N'ĐIỆN THOẠI ĐEN 2', N'N/A', N'N/A', '31/10/2025', N'Scott Derrickson', N'Tiếng Anh', NULL, N'N/A', N'https://youtu.be/Uo5sNWGrFQ8', N'Ethan Hawke, Mason Thames, Madeleine McGraw, Demián Bichir, Miguel Mora, ...');

UPDATE Movie
SET duration = 0
WHERE duration IS NULL;

INSERT INTO dbo.ShowTime (idmovie, idscreen, idseat, start_time, available)
VALUES
-- Showtime 1: Movie 1, Screen 1 @ 18:00 on 15/12/2025
(1, 1, 1, '15/12/2025 18:00:00', 1),
(1, 1, 2, '15/12/2025 18:00:00', 1),
(1, 1, 3, '15/12/2025 18:00:00', 1),
(1, 1, 4, '15/12/2025 18:00:00', 1),
(1, 1, 5, '15/12/2025 18:00:00', 1),
(1, 1, 6, '15/12/2025 18:00:00', 1),
(1, 1, 7, '15/12/2025 18:00:00', 1),
(1, 1, 8, '15/12/2025 18:00:00', 1),
(1, 1, 9, '15/12/2025 18:00:00', 1),
(1, 1, 10, '15/12/2025 18:00:00', 1),
(1, 1, 11, '15/12/2025 18:00:00', 1),
(1, 1, 12, '15/12/2025 18:00:00', 1),
(1, 1, 13, '15/12/2025 18:00:00', 1),
(1, 1, 14, '15/12/2025 18:00:00', 1),
(1, 1, 15, '15/12/2025 18:00:00', 1),
(1, 1, 16, '15/12/2025 18:00:00', 1),
(1, 1, 17, '15/12/2025 18:00:00', 1),
(1, 1, 18, '15/12/2025 18:00:00', 1),
(1, 1, 19, '15/12/2025 18:00:00', 1),
(1, 1, 20, '15/12/2025 18:00:00', 1),
(1, 1, 21, '15/12/2025 18:00:00', 1),
(1, 1, 22, '15/12/2025 18:00:00', 1),
(1, 1, 23, '15/12/2025 18:00:00', 1),
(1, 1, 24, '15/12/2025 18:00:00', 1),
(1, 1, 25, '15/12/2025 18:00:00', 1),
(1, 1, 26, '15/12/2025 18:00:00', 1),
(1, 1, 27, '15/12/2025 18:00:00', 1),
(1, 1, 28, '15/12/2025 18:00:00', 1),
(1, 1, 29, '15/12/2025 18:00:00', 1),
(1, 1, 30, '15/12/2025 18:00:00', 1),
(1, 1, 31, '15/12/2025 18:00:00', 1),
(1, 1, 32, '15/12/2025 18:00:00', 1),
(1, 1, 33, '15/12/2025 18:00:00', 1),
(1, 1, 34, '15/12/2025 18:00:00', 1),
(1, 1, 35, '15/12/2025 18:00:00', 1),
(1, 1, 36, '15/12/2025 18:00:00', 1),
(1, 1, 37, '15/12/2025 18:00:00', 1),
(1, 1, 38, '15/12/2025 18:00:00', 1),
(1, 1, 39, '15/12/2025 18:00:00', 1),
(1, 1, 40, '15/12/2025 18:00:00', 1),
(1, 1, 41, '15/12/2025 18:00:00', 1),
(1, 1, 42, '15/12/2025 18:00:00', 1),
(1, 1, 43, '15/12/2025 18:00:00', 1),
(1, 1, 44, '15/12/2025 18:00:00', 1),
(1, 1, 45, '15/12/2025 18:00:00', 1),
(1, 1, 46, '15/12/2025 18:00:00', 1),
(1, 1, 47, '15/12/2025 18:00:00', 1),
(1, 1, 48, '15/12/2025 18:00:00', 1),
(1, 1, 49, '15/12/2025 18:00:00', 1),
(1, 1, 50, '15/12/2025 18:00:00', 1),

-- Showtime 2: Movie 1, Screen 2 @ 20:30 on 15/12/2025
(1, 2, 1, '15/12/2025 20:30:00', 1),
(1, 2, 2, '15/12/2025 20:30:00', 1),
(1, 2, 3, '15/12/2025 20:30:00', 1),
(1, 2, 4, '15/12/2025 20:30:00', 1),
(1, 2, 5, '15/12/2025 20:30:00', 1),
(1, 2, 6, '15/12/2025 20:30:00', 1),
(1, 2, 7, '15/12/2025 20:30:00', 1),
(1, 2, 8, '15/12/2025 20:30:00', 1),
(1, 2, 9, '15/12/2025 20:30:00', 1),
(1, 2, 10, '15/12/2025 20:30:00', 1),
(1, 2, 11, '15/12/2025 20:30:00', 1),
(1, 2, 12, '15/12/2025 20:30:00', 1),
(1, 2, 13, '15/12/2025 20:30:00', 1),
(1, 2, 14, '15/12/2025 20:30:00', 1),
(1, 2, 15, '15/12/2025 20:30:00', 1),
(1, 2, 16, '15/12/2025 20:30:00', 1),
(1, 2, 17, '15/12/2025 20:30:00', 1),
(1, 2, 18, '15/12/2025 20:30:00', 1),
(1, 2, 19, '15/12/2025 20:30:00', 1),
(1, 2, 20, '15/12/2025 20:30:00', 1),
(1, 2, 21, '15/12/2025 20:30:00', 1),
(1, 2, 22, '15/12/2025 20:30:00', 1),
(1, 2, 23, '15/12/2025 20:30:00', 1),
(1, 2, 24, '15/12/2025 20:30:00', 1),
(1, 2, 25, '15/12/2025 20:30:00', 1),
(1, 2, 26, '15/12/2025 20:30:00', 1),
(1, 2, 27, '15/12/2025 20:30:00', 1),
(1, 2, 28, '15/12/2025 20:30:00', 1),
(1, 2, 29, '15/12/2025 20:30:00', 1),
(1, 2, 30, '15/12/2025 20:30:00', 1),
(1, 2, 31, '15/12/2025 20:30:00', 1),
(1, 2, 32, '15/12/2025 20:30:00', 1),
(1, 2, 33, '15/12/2025 20:30:00', 1),
(1, 2, 34, '15/12/2025 20:30:00', 1),
(1, 2, 35, '15/12/2025 20:30:00', 1),
(1, 2, 36, '15/12/2025 20:30:00', 1),
(1, 2, 37, '15/12/2025 20:30:00', 1),
(1, 2, 38, '15/12/2025 20:30:00', 1),
(1, 2, 39, '15/12/2025 20:30:00', 1),
(1, 2, 40, '15/12/2025 20:30:00', 1),
(1, 2, 41, '15/12/2025 20:30:00', 1),
(1, 2, 42, '15/12/2025 20:30:00', 1),
(1, 2, 43, '15/12/2025 20:30:00', 1),
(1, 2, 44, '15/12/2025 20:30:00', 1),
(1, 2, 45, '15/12/2025 20:30:00', 1),
(1, 2, 46, '15/12/2025 20:30:00', 1),
(1, 2, 47, '15/12/2025 20:30:00', 1),
(1, 2, 48, '15/12/2025 20:30:00', 1),
(1, 2, 49, '15/12/2025 20:30:00', 1),
(1, 2, 50, '15/12/2025 20:30:00', 1);

INSERT INTO dbo.Shift_Schedule VALUES('7:30:00', '12:30:00');
INSERT INTO dbo.Shift_Schedule VALUES('12:30:00', '17:30:00');
INSERT INTO dbo.Shift_Schedule VALUES('17:30:00', '22:30:00');
INSERT INTO dbo.Shift_Schedule VALUES('22:30:00', '2:30:00');

INSERT INTO dbo.Staff VALUES(N'Nguyễn Minh Anh', N'Giám đốc marketing', N'mlanhmlanh214@gmail.com', 1);
INSERT INTO dbo.Staff VALUES(N'Trần Minh Đức', N'Nhân viên', N'minhduct50@gmail.com', 1);
INSERT INTO dbo.Staff VALUES(N'Phạm Đan Trường', N'Quản lý', N'truongpd.a2.2124@gmail.com', 1);
INSERT INTO dbo.Staff VALUES(N'Hồ Thịnh Phát', N'Quản lý', N'phatht.a2.2124@gmail.com', 3);
INSERT INTO dbo.Staff VALUES(N'Võ Việt Thy', N'Nhân viên', N'thyvv.a2.2124@gmail.com', 2);
INSERT INTO dbo.Staff VALUES(N'Lê Phương Thúy', N'Nhân viên', N'thuylp.a2.2124@gmail.com', 3);
INSERT INTO dbo.Staff VALUES(N'Nguyễn Thanh Hiếu Thảo', N'Nhân viên', N'thaontt.a2.2124@gmail.com', 4);

INSERT INTO dbo.Account VALUES('minhanh2104', 'tpnma@', '1', '1', '1');
INSERT INTO dbo.Account VALUES('minhduc2303', 'tptmd@', '0', '2', '1');
INSERT INTO dbo.Account VALUES('dantruong2007', 'tppdt@', '1', '3', '1');
INSERT INTO dbo.Account VALUES('thinhphat1512', 'tphtp@', '1', '4', '1');
INSERT INTO dbo.Account VALUES('vietthy1908', 'tpvvt@', '0', '5', '1');
INSERT INTO dbo.Account VALUES('phuongthuy2505', 'tplpt@', '0', '6', '1');
INSERT INTO dbo.Account VALUES('hieuthao2103', 'tpntht@', '0', '7', '1');

INSERT INTO Snack (name, price, stock, category)
VALUES
(N'Bắp rang truyền thống', 55000, 100, 0),
(N'Bắp rang phô mai', 59000, 100, 0),
(N'Bắp rang caramel', 59000, 100, 0),
(N'Hot dog', 39000, 100, 0),
(N'Lays', 19000, 100, 0),
(N'Gà viên', 49000, 100, 0),
(N'Coca Cola', 39000, 100, 1),
(N'Sprite', 39000, 100, 1),
(N'Fanta', 39000, 100, 1),
(N'Pepsi', 39000, 100, 1),
(N'Matcha latte', 49000, 100, 1),
(N'Trà vải', 49000, 100, 1),
(N'Bạc xỉu', 39000, 100, 1),
(N'Trà sữa truyền thống', 49000, 100, 1),
(N'Bánh quy', 25000, 100, 0),
(N'Croissant truyền thống', 39000, 100, 0),
(N'Croissant phô mai thịt nguội', 55000, 100, 0),
(N'Bánh chuối', 39000, 100, 0),
(N'Bánh waffle', 39000, 100, 0),
(N'Khoai tây chiên', 35000, 100, 0),
(N'Cơm chiên', 49000, 100, 0),
(N'Cơm trắng', 5000, 100, 0),
(N'Cơm gà sốt phô mai', 59000, 100, 0),
(N'Cơm bò sốt tiêu đen', 65000, 100, 0),
(N'Cơm thịt heo chiên xù', 65000, 100, 0);


-- PROC
CREATE PROC USP_Login
@username VARCHAR(100), @password VARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE username = @username AND password = @password
END

CREATE PROC USP_GetMovieList
AS SELECT * FROM dbo.Movie

CREATE PROC USP_GetSnackList
AS SELECT * FROM dbo.Snack

CREATE PROC USP_GetShowTimeList
AS SELECT * FROM dbo.ShowTime

-- Ngày 18/11/2025
-- Đổi row thành varchar(1) với các hàng ghế là A, B, C, D, E

