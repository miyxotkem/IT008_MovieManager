CREATE DATABASE MovieManager
GO
USE MovieManager
GO

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
	idScreen INT not null, 
	row varchar(3),
	number INT,
	type NVARCHAR(100)

	Foreign key (idScreen) references Screen(id)
)
GO
CREATE TABLE Customer
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Guest',
	email VARCHAR(100) DEFAULT NULL,
	phone_number VARCHAR(11) DEFAULT NULL,
	membership INT DEFAULT 0, -- 0: none, 1: bronze, 2: silver, 3: gold, etc.
	money_spent FLOAT
)
GO
CREATE TABLE ShiftSchedule
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

	FOREIGN KEY (idshiftschedule) REFERENCES dbo.ShiftSchedule(id)
)
GO
CREATE TABLE Snack
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	price FLOAT,
	stock INT,
	category INT, -- 0: food, 1: beverage
	discount int
)

GO
CREATE TABLE ShowTime (
		idmovie INT,
		idscreen INT,
		start_time DATETIME,

		FOREIGN KEY (idmovie) REFERENCES Movie(id) ON DELETE CASCADE,
		FOREIGN KEY (idscreen) REFERENCES Screen(id),

		PRIMARY KEY (idmovie, start_time)
	) 
go
create table ShowTimeDetail( 
	idMovie int,
	Start_time DATETIME,
	idSeat int ,
	available int default 0,

	foreign key (idMovie, Start_time) references ShowTime(idmovie, start_time) ON DELETE CASCADE,
	foreign key (idSeat) references Seat(id),
	primary key (idMovie, Start_time, idSeat)
)
GO

create table Bill(
	idBill int identity primary key, 
	idCustomer int,
	payment_method varchar(50) default 'Cash',
	bill_status int default 0, --0: Unpaid   1: Paid
	idVoucher int default -1, -- -1: Không có voucher 
)

go

CREATE TABLE Ticket
(
	id INT IDENTITY PRIMARY KEY,
	price FLOAT CHECK(price >= 0),
	purchase_date DATE DEFAULT GETDATE(),
	idmovie INT,
	Start_time DateTime,
	idstaff INT,
	idSeat int,
	idBill int,
	FOREIGN KEY (idmovie, Start_time, idSeat) REFERENCES ShowTimeDetail(idMovie, Start_time,idSeat),
	FOREIGN KEY (idstaff) REFERENCES dbo.Staff(id),
	foreign key (idBill) references Bill(idBill)
)
GO

create table BillInfo(
	idBillInfo int identity primary key, 
	idBill int,
	Category varchar(50), -- Ticket/ Food and Drink
	idDetail int, 
	Quantity int, 
	Discount int check(Discount>=0 and Discount<=100), 
	Price float check (Price >=0),

	foreign key(idBill) references Bill(idBill)
)

go

CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	username VARCHAR(100),
	password VARCHAR(100),
	admin BIT DEFAULT 0,
	idStaff INT,
	accept BIT DEFAULT 0,

	FOREIGN KEY (idStaff) REFERENCES dbo.Staff(id)
)
GO
CREATE TABLE ForgetPassword
(
	idStaff INT,
	verification VARCHAR(6),

	FOREIGN KEY (idstaff) REFERENCES dbo.Staff(id),
	PRIMARY KEY (idStaff, verification)
)
GO
CREATE TABLE History
(
	id INT IDENTITY PRIMARY KEY,
	idSnack INT,
	quantity INT,
	date DATE,

	FOREIGN KEY (idSnack) REFERENCES dbo.Snack(id)
)

GO
SET DATEFORMAT dmy;
GO

create table Voucher 
(
	id int identity primary key, 
	type int, -- 0: áp cho Bill    1: áp cho Ticket
	code varchar(8),
	discount int, -- % giảm 
	max_money_discount float, -- Số tiền tối đa giảm được 
	min_total_bill float -- Số tiền tối thiểu trên tổng bill để được áp mã 
)

go
-- INSERT
INSERT INTO dbo.Hall (name, location)VALUES (N'CGV Binh Duong', N'3rd Floor, Aeon Mall');
INSERT INTO dbo.Hall (name, location)VALUES (N'Lotte Cinema Thu Duc', N'5th Floor, Giga Mall');

INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (1, 50, 50, N'2D', 1);
INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (2, 50, 50, N'2D', 1);
INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (3, 50, 50, N'iMax', 1);
INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (4, 50, 50, N'2D', 1);
INSERT INTO dbo.Screen (number, capacity, available_seat, type, idhall)VALUES (5, 50, 50, N'iMax', 1);

INSERT INTO Customer (name, email, phone_number, membership, money_spent) VALUES
(N'Nguyễn Minh Anh', 'mlamnhanh214@gmail.com', '0908935963', 5, 5000000.0),
(N'Nguyễn Thanh Hiếu Thảo', '31241023127@student.isb.edu.vn', '0908047268', 5, 5000000.0),
(N'Phạm Đan Trù', 'truuthao@gmail.com', '0123456789', 5, 5000000.0),
(N'Nguyễn Ngọc Thảo Như', 'tnhu2406205@gmail.com', '0766995289', 5, 5000000.0),
(N'Enzo Nguyen', 'hungatoms2025@gmail.com', '5714049575', 5, 5000000.0),
(N'Travis', 'ngobinhphuong153@gmail.com', '0982714467', 5, 5000000.0),
(N'Dũn', 'huynhchidung@gmail.com', '0373168853', 5, 5000000.0),
(N'Hàoooooo', 'Dangquanhao182006@gmail.com', '0888370684', 5, 5000000.0),
(N'Họ Nguyễn Thu An', 'Anhhte@vietjetair.com', '0707164604', 0, 0.0),
(N'Khánh Linh Nguyễn Đình', 'ndklinh.a2.2124@gmail.com', '0368750126', 5, 5000000.0),
(N'Khoa', 'khoanguyen20062020@gmail.com', '0908429637', 4, 4000000.0),
(N'Nguyễn Trần Phương Vy', '24522062@gm.uit.edu.vn', '0562318690', 2, 2000000.0),
(N'Tô Thành Nguyên', '24521207@gm.uit.edu.vn', '0383993152', 5, 5000000.0),
(N'Trần Đình Thi', 'thitd.t1.2124@gmail.com', '0963263206', 2, 2000000.0),
(N'Võ Tấn Nhã', 'sugiaxu36@gmail.com', '0123456789', 5, 5000000.0),
(N'Nguyễn Hữu Nguyên', 'huunguyen2006ks@gmail.com', '0947662347', 1, 1000000.0),
(N'Nguyễn Nam Khôi', 'nguyennamkhoi21@gmail.com', '0399590711', 5, 5000000.0),
(N'Nguyễn Bảo Nguyên', 'nguyennb.a2.2124@gmail.com', '0374483435', 2, 2000000.0),
(N'Trương Đỗ Ái Nhân', 'nhantruong.31241023050@st.ueh.edu.vn', '0961947977', 5, 5000000.0),
(N'Trịnh Hà Phương', 'phuongh7406@gmail.com', '0349645755', 5, 5000000.0),
(N'Lê Nguyên Ngọc', 'ngocnguyenlng@gmail.com', '0784811498', 5, 5000000.0),
(N'Thu Giang', 'thugiang911315@gmail.com', '0898411229', 0, 0.0),
(N'Như Anh', 'anhpham206@gmail.com', '0334474160', 1, 1000000.0),
(N'Hà Tuấn Hùng', '24520584@gm.uit.edu.vn', '0898373778', 5, 5000000.0),
(N'Trần Thị Hồng Thanh', '24521643@gm.uit.edu.vn', '0345910695', 5, 5000000.0),
(N'Cao Vĩ Trà My', 'tui nghe bài trình r', '1-0', 5, 5000000.0),
(N'Cao Vĩ Trà My', 'caomy039@gmail.com', '0328813029', 5, 5000000.0),
(N'Trọng Nguyên', 'votannha@gmail.com', '0935678910', 5, 5000000.0),
(N'Nguyễn Quỳnh Hương', 'quynhhuong160807@gmail.com', '0913343449', 5, 5000000.0),
(N'Võ Lê Yến Nhi', 'vonhi2k05@gmail.com', '0977540807', 2, 2000000.0),
(N'Nguyễn Hưng Phát', 'nguyenhungphat26112006@gmail.com', '0969261106', 3, 3000000.0),
(N'Lê Trần Uyên Nghi', 'nghile.31241023134@st.ueh.edu.vn', '0707907603', 2, 2000000.0),
(N'Nguyễn Anh Khoa', 'dannypark1201@gmail.com', '0336826679', 2, 2000000.0),
(N'Trần Thiên Ân', 'naan22526@gmail.com', '0938533198', 0, 0.0),
(N'Nguyễn Chí Nguyên', 'nathanguyen6002@gmail.com', '0865320821', 5, 5000000.0),
(N'Lương Bảo Châu', 'pouliejulie68@gmail.com', '0936788367', 5, 5000000.0),
(N'Hạnh Minh', 'minhnnnh.s.2427@gmail.com', '0337347082', 2, 2000000.0),
(N'Hà Gia Bảo', 'baogianxao1405@gmail.com', '0859238738', 5, 5000000.0),
(N'hạnh đoan', '24007819@student.westernsydney.edu.vn', '0693705102', 4, 4000000.0);

-- Phòng 1 
INSERT INTO dbo.Seat (idScreen, row, number, type)
VALUES
-- Row 1 (Row A - Normal)
(1, 'A', 1, N'Normal'),
(1, 'A', 2, N'Normal'),
(1, 'A', 3, N'Normal'),
(1, 'A', 4, N'Normal'),
(1, 'A', 5, N'Normal'),
(1, 'A', 6, N'Normal'),
(1, 'A', 7, N'Normal'),
(1, 'A', 8, N'Normal'),
(1, 'A', 9, N'Normal'),
(1, 'A', 10, N'Normal'),

-- Row 2 (Row B - Normal)
(1, 'B', 1, N'Normal'),
(1, 'B', 2, N'Normal'),
(1, 'B', 3, N'Normal'),
(1, 'B', 4, N'Normal'),
(1, 'B', 5, N'Normal'),
(1, 'B', 6, N'Normal'),
(1, 'B', 7, N'Normal'),
(1, 'B', 8, N'Normal'),
(1, 'B', 9, N'Normal'),
(1, 'B', 10, N'Normal'),

-- Row 3 (Row C - VIP)
(1, 'C', 1, N'VIP'),
(1, 'C', 2, N'VIP'),
(1, 'C', 3, N'VIP'),
(1, 'C', 4, N'VIP'),
(1, 'C', 5, N'VIP'),
(1, 'C', 6, N'VIP'),
(1, 'C', 7, N'VIP'),
(1, 'C', 8, N'VIP'),
(1, 'C', 9, N'VIP'),
(1, 'C', 10, N'VIP'),

-- Row 4 (Row D - VIP)
(1, 'D', 1, N'VIP'),
(1, 'D', 2, N'VIP'),
(1, 'D', 3, N'VIP'),
(1, 'D', 4, N'VIP'),
(1, 'D', 5, N'VIP'),
(1, 'D', 6, N'VIP'),
(1, 'D', 7, N'VIP'),
(1, 'D', 8, N'VIP'),
(1, 'D', 9, N'VIP'),
(1, 'D', 10, N'VIP'),

-- Row 5 (Row E - Couple & SVIP)
(1, 'E', 1, N'Couple'),
(1, 'E', 2, N'Couple'),
(1, 'E', 3, N'Couple'),
(1, 'E', 4, N'Couple'),
(1, 'E', 5, N'Couple'),
(1, 'E', 6, N'SVIP'),
(1, 'E', 7, N'SVIP'),
(1, 'E', 8, N'SVIP'),
(1, 'E', 9, N'SVIP'),
(1, 'E', 10, N'SVIP');

-- Phòng 2
INSERT INTO dbo.Seat (idScreen, row, number, type)
VALUES
-- Row 1 (Row A - Normal)
(2, 'A', 1, N'Normal'),
(2, 'A', 2, N'Normal'),
(2, 'A', 3, N'Normal'),
(2, 'A', 4, N'Normal'),
(2, 'A', 5, N'Normal'),
(2, 'A', 6, N'Normal'),
(2, 'A', 7, N'Normal'),
(2, 'A', 8, N'Normal'),
(2, 'A', 9, N'Normal'),
(2, 'A', 10, N'Normal'),

-- Row 2 (Row B - Normal)
(2, 'B', 1, N'Normal'),
(2, 'B', 2, N'Normal'),
(2, 'B', 3, N'Normal'),
(2, 'B', 4, N'Normal'),
(2, 'B', 5, N'Normal'),
(2, 'B', 6, N'Normal'),
(2, 'B', 7, N'Normal'),
(2, 'B', 8, N'Normal'),
(2, 'B', 9, N'Normal'),
(2, 'B', 10, N'Normal'),

-- Row 3 (Row C - VIP)
(2, 'C', 1, N'VIP'),
(2, 'C', 2, N'VIP'),
(2, 'C', 3, N'VIP'),
(2, 'C', 4, N'VIP'),
(2, 'C', 5, N'VIP'),
(2, 'C', 6, N'VIP'),
(2, 'C', 7, N'VIP'),
(2, 'C', 8, N'VIP'),
(2, 'C', 9, N'VIP'),
(2, 'C', 10, N'VIP'),

-- Row 4 (Row D - VIP)
(2, 'D', 1, N'VIP'),
(2, 'D', 2, N'VIP'),
(2, 'D', 3, N'VIP'),
(2, 'D', 4, N'VIP'),
(2, 'D', 5, N'VIP'),
(2, 'D', 6, N'VIP'),
(2, 'D', 7, N'VIP'),
(2, 'D', 8, N'VIP'),
(2, 'D', 9, N'VIP'),
(2, 'D', 10, N'VIP'),

-- Row 5 (Row E - Couple & SVIP)
(2, 'E', 1, N'Couple'),
(2, 'E', 2, N'Couple'),
(2, 'E', 3, N'Couple'),
(2, 'E', 4, N'Couple'),
(2, 'E', 5, N'Couple'),
(2, 'E', 6, N'SVIP'),
(2, 'E', 7, N'SVIP'),
(2, 'E', 8, N'SVIP'),
(2, 'E', 9, N'SVIP'),
(2, 'E', 10, N'SVIP');

INSERT INTO dbo.Seat (idScreen, row, number, type)
VALUES
-- Row 1 (Row A - Normal)
(3, 'A', 1, N'Normal'),
(3, 'A', 2, N'Normal'),
(3, 'A', 3, N'Normal'),
(3, 'A', 4, N'Normal'),
(3, 'A', 5, N'Normal'),
(3, 'A', 6, N'Normal'),
(3, 'A', 7, N'Normal'),
(3, 'A', 8, N'Normal'),
(3, 'A', 9, N'Normal'),
(3, 'A', 10, N'Normal'),

-- Row 2 (Row B - Normal)
(3, 'B', 1, N'Normal'),
(3, 'B', 2, N'Normal'),
(3, 'B', 3, N'Normal'),
(3, 'B', 4, N'Normal'),
(3, 'B', 5, N'Normal'),
(3, 'B', 6, N'Normal'),
(3, 'B', 7, N'Normal'),
(3, 'B', 8, N'Normal'),
(3, 'B', 9, N'Normal'),
(3, 'B', 10, N'Normal'),

-- Row 3 (Row C - VIP)
(3, 'C', 1, N'VIP'),
(3, 'C', 2, N'VIP'),
(3, 'C', 3, N'VIP'),
(3, 'C', 4, N'VIP'),
(3, 'C', 5, N'VIP'),
(3, 'C', 6, N'VIP'),
(3, 'C', 7, N'VIP'),
(3, 'C', 8, N'VIP'),
(3, 'C', 9, N'VIP'),
(3, 'C', 10, N'VIP'),

-- Row 4 (Row D - VIP)
(3, 'D', 1, N'VIP'),
(3, 'D', 2, N'VIP'),
(3, 'D', 3, N'VIP'),
(3, 'D', 4, N'VIP'),
(3, 'D', 5, N'VIP'),
(3, 'D', 6, N'VIP'),
(3, 'D', 7, N'VIP'),
(3, 'D', 8, N'VIP'),
(3, 'D', 9, N'VIP'),
(3, 'D', 10, N'VIP'),

-- Row 5 (Row E - Couple & SVIP)
(3, 'E', 1, N'Couple'),
(3, 'E', 2, N'Couple'),
(3, 'E', 3, N'Couple'),
(3, 'E', 4, N'Couple'),
(3, 'E', 5, N'Couple'),
(3, 'E', 6, N'SVIP'),
(3, 'E', 7, N'SVIP'),
(3, 'E', 8, N'SVIP'),
(3, 'E', 9, N'SVIP'),
(3, 'E', 10, N'SVIP');

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
GO

INSERT INTO dbo.ShowTime (idmovie, idscreen, start_time)
VALUES
-- Showtime 1: Movie 1, Screen 1 @ 18:00 on 15/12/2025
(1,1,'15/12/2025 18:00:00'),

-- Showtime 2: Movie 1, Screen 2 @ 20:30 on 15/12/2025
(1,2,'15/12/2025 20:30:00')

INSERT INTO dbo.ShiftSchedule VALUES('7:30:00', '12:30:00');
INSERT INTO dbo.ShiftSchedule VALUES('12:30:00', '17:30:00');
INSERT INTO dbo.ShiftSchedule VALUES('17:30:00', '22:30:00');
INSERT INTO dbo.ShiftSchedule VALUES('22:30:00', '2:30:00');

INSERT INTO dbo.Staff VALUES(N'Nguyễn Minh Anh', N'Giám đốc marketing', N'mlanhmlanh214@gmail.com', 1);
INSERT INTO dbo.Staff VALUES(N'Trần Minh Đức', N'Nhân viên', N'minhduct50@gmail.com', 1);
INSERT INTO dbo.Staff VALUES(N'Phạm Đan Trường', N'Quản lý', N'truongpd.a2.2124@gmail.com', 1);
INSERT INTO dbo.Staff VALUES(N'Hồ Thịnh Phát', N'Quản lý', N'phatht.a2.2124@gmail.com', 3);
INSERT INTO dbo.Staff VALUES(N'Võ Việt Thy', N'Nhân viên', N'thyvv.a2.2124@gmail.com', 2);
INSERT INTO dbo.Staff VALUES(N'Lê Phương Thúy', N'Nhân viên', N'thuylp.a2.2124@gmail.com', 3);
INSERT INTO dbo.Staff VALUES(N'Nguyễn Thanh Hiếu Thảo', N'Nhân viên', N'thaonth.a2.2124@gmail.com', 4);

INSERT INTO dbo.Account VALUES('minhanh2104', '123456789', '1', '1', '1');
INSERT INTO dbo.Account VALUES('minhduc2303', '123456789', '0', '2', '1');
INSERT INTO dbo.Account VALUES('dantruong2007', '123456789', '1', '3', '1');
INSERT INTO dbo.Account VALUES('thinhphat1512', '123456789', '1', '4', '1');
INSERT INTO dbo.Account VALUES('vietthy1908', '123456789', '0', '5', '1');
INSERT INTO dbo.Account VALUES('phuongthuy2505', '123456789', '0', '6', '1');
INSERT INTO dbo.Account VALUES('hieuthao2103', '123456789', '0', '7', '0');

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

UPDATE SNACK
SET discount = 0

INSERT INTO ShowTimeDetail (idMovie, Start_time, idSeat)
VALUES
(1, '15/12/2025 18:00:00', 1),
(1, '15/12/2025 18:00:00', 2),
(1, '15/12/2025 18:00:00', 3),
(1, '15/12/2025 18:00:00', 4),
(1, '15/12/2025 18:00:00', 5),
(1, '15/12/2025 18:00:00', 6),
(1, '15/12/2025 18:00:00', 7),
(1, '15/12/2025 18:00:00', 8),
(1, '15/12/2025 18:00:00', 9),
(1, '15/12/2025 18:00:00', 10),
(1, '15/12/2025 18:00:00', 11),
(1, '15/12/2025 18:00:00', 12),
(1, '15/12/2025 18:00:00', 13),
(1, '15/12/2025 18:00:00', 14),
(1, '15/12/2025 18:00:00', 15),
(1, '15/12/2025 18:00:00', 16),
(1, '15/12/2025 18:00:00', 17),
(1, '15/12/2025 18:00:00', 18),
(1, '15/12/2025 18:00:00', 19),
(1, '15/12/2025 18:00:00', 20),
(1, '15/12/2025 18:00:00', 21),
(1, '15/12/2025 18:00:00', 22),
(1, '15/12/2025 18:00:00', 23),
(1, '15/12/2025 18:00:00', 24),
(1, '15/12/2025 18:00:00', 25),
(1, '15/12/2025 18:00:00', 26),
(1, '15/12/2025 18:00:00', 27),
(1, '15/12/2025 18:00:00', 28),
(1, '15/12/2025 18:00:00', 29),
(1, '15/12/2025 18:00:00', 30),
(1, '15/12/2025 18:00:00', 31),
(1, '15/12/2025 18:00:00', 32),
(1, '15/12/2025 18:00:00', 33),
(1, '15/12/2025 18:00:00', 34),
(1, '15/12/2025 18:00:00', 35),
(1, '15/12/2025 18:00:00', 36),
(1, '15/12/2025 18:00:00', 37),
(1, '15/12/2025 18:00:00', 38),
(1, '15/12/2025 18:00:00', 39),
(1, '15/12/2025 18:00:00', 40),
(1, '15/12/2025 18:00:00', 41),
(1, '15/12/2025 18:00:00', 42),
(1, '15/12/2025 18:00:00', 43),
(1, '15/12/2025 18:00:00', 44),
(1, '15/12/2025 18:00:00', 45),
(1, '15/12/2025 18:00:00', 46),
(1, '15/12/2025 18:00:00', 47),
(1, '15/12/2025 18:00:00', 48),
(1, '15/12/2025 18:00:00', 49),
(1, '15/12/2025 18:00:00', 50);

INSERT INTO ShowTimeDetail (idMovie, Start_time, idSeat)
VALUES
(1, '15/12/2025 20:30:00', 51),
(1, '15/12/2025 20:30:00', 52),
(1, '15/12/2025 20:30:00', 53),
(1, '15/12/2025 20:30:00', 54),
(1, '15/12/2025 20:30:00', 55),
(1, '15/12/2025 20:30:00', 56),
(1, '15/12/2025 20:30:00', 57),
(1, '15/12/2025 20:30:00', 58),
(1, '15/12/2025 20:30:00', 59),
(1, '15/12/2025 20:30:00', 60),
(1, '15/12/2025 20:30:00', 61),
(1, '15/12/2025 20:30:00', 62),
(1, '15/12/2025 20:30:00', 63),
(1, '15/12/2025 20:30:00', 64),
(1, '15/12/2025 20:30:00', 65),
(1, '15/12/2025 20:30:00', 66),
(1, '15/12/2025 20:30:00', 67),
(1, '15/12/2025 20:30:00', 68),
(1, '15/12/2025 20:30:00', 69),
(1, '15/12/2025 20:30:00', 70),
(1, '15/12/2025 20:30:00', 71),
(1, '15/12/2025 20:30:00', 72),
(1, '15/12/2025 20:30:00', 73),
(1, '15/12/2025 20:30:00', 74),
(1, '15/12/2025 20:30:00', 75),
(1, '15/12/2025 20:30:00', 76),
(1, '15/12/2025 20:30:00', 77),
(1, '15/12/2025 20:30:00', 78),
(1, '15/12/2025 20:30:00', 79),
(1, '15/12/2025 20:30:00', 80),
(1, '15/12/2025 20:30:00', 81),
(1, '15/12/2025 20:30:00', 82),
(1, '15/12/2025 20:30:00', 83),
(1, '15/12/2025 20:30:00', 84),
(1, '15/12/2025 20:30:00', 85),
(1, '15/12/2025 20:30:00', 86),
(1, '15/12/2025 20:30:00', 87),
(1, '15/12/2025 20:30:00', 88),
(1, '15/12/2025 20:30:00', 89),
(1, '15/12/2025 20:30:00', 90),
(1, '15/12/2025 20:30:00', 91),
(1, '15/12/2025 20:30:00', 92),
(1, '15/12/2025 20:30:00', 93),
(1, '15/12/2025 20:30:00', 94),
(1, '15/12/2025 20:30:00', 95),
(1, '15/12/2025 20:30:00', 96),
(1, '15/12/2025 20:30:00', 97),
(1, '15/12/2025 20:30:00', 98),
(1, '15/12/2025 20:30:00', 99),
(1, '15/12/2025 20:30:00', 100); 

INSERT INTO Voucher (type, code, discount, max_money_discount, min_total_bill)
VALUES 
(0, 'WELCOME5', 5, 50000, 0),        -- Giảm 5% cho Bill, không giới hạn tối thiểu
(0, 'BILL100K', 10, 20000, 100000),    -- Giảm 10% cho Bill từ 100k trở lên
(0, 'BIGSALE', 20, 200000, 500000),    -- Giảm 20% cho Bill từ 500k trở lên
(1, 'TICKET2', 15, 30000, 50000),      -- Giảm 15% cho Ticket từ 50k trở lên
(1, 'VIPONLY', 50, 500000, 1000000),   -- Giảm 50% cho Ticket từ 1tr trở lên
(1, 'FREETKT', 100, 100000, 0),        -- Giảm 100% (tối đa 100k) cho Ticket
(0, 'PROMO99', 9, 99000, 99000),       -- Mã hỗn hợp số và chữ thường
(0, 'SUMMER24', 25, 150000, 300000),   -- Mã có năm
(1, 'abc123XY', 12, 45000, 200000),    -- Mã lẫn lộn hoa thường
(0, 'LUCKY7', 7, 77000, 77000),       -- Mã may mắn
(1, 'HSSV', 50, 10000000, 0)

GO


-- VIEW
-- Bảng view liên kết account với staff
create view AccountStaff as
select ac.idStaff as ID,  ac.username, ac.password, st.contact_info as email , st.name, st.role as Role
from Account ac join Staff st on ac.idStaff = st.id; 
GO


-- PROC
CREATE PROC USP_Login
@username VARCHAR(100), @password VARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE username = @username AND password = @password
END
GO
CREATE PROC USP_GetMovieList
AS SELECT * FROM dbo.Movie
GO
CREATE PROC USP_GetSnackList
AS SELECT * FROM dbo.Snack
GO
CREATE PROC USP_GetShowTimeList
AS SELECT * FROM dbo.ShowTime
GO
CREATE PROC USP_GetHistoryList
AS SELECT * FROM dbo.History
GO
CREATE PROC USP_GetAccountList
AS SELECT * FROM dbo.Account
GO
CREATE PROC USP_GetStaffList
AS SELECT * FROM dbo.Staff
GO
CREATE PROC USP_GetShiftList
AS SELECT * FROM dbo.ShiftSchedule
GO
CREATE PROC USP_GetCustomerList
AS SELECT * FROM dbo.Customer
GO
create proc USP_ForgetPassUsername
@username varchar(100) 
as 
begin 
	select * from Account 
	where username = @username;
end
GO
-- Lấy idStaff từ username của Account 
create proc USP_ForgetPassGetIDStaff
@username varchar(100)
as select idStaff from Account where username = @username
GO
-- Thêm verification vào bảng Forget
create proc USP_InsertIntoForgetTable
@id int, @verify varchar(6)
as
begin 
	insert into dbo.ForgetPassword
	values (@id, @verify)
end
GO
-- Lấy email từ username của account 
create proc USP_GetEmailFromUser
@username varchar(100)
as
begin
	select email from AccountStaff
	where username = @username
end
GO
-- Xóa mã từ bảng Forget 
create proc USP_EraseVerification
@id int , @verify varchar(6)
as 
begin
	delete from ForgetPassword
	where idStaff = @id and verification = @verify
end 
GO
-- Kiểm tra verificationCode trong Forget
create proc USP_CheckVerify
@id int , @verify varchar(6)
as 
begin 
	select idStaff, verification 
	from ForgetPassword
	where idStaff = @id and verification = @verify;
end
GO

-- Cập nhật Password mới sau khi reset password vào Account 
create proc USP_UpdateNewPassword 
@username varchar(100), @pass varchar(100)
as 
begin 
	update Account 
	set password = @pass
	where username = @username
end
GO

-- Lấy các thông tin khi user đăng nhập vào 
create proc USP_GetAccountInfoFromUser
@username varchar(100)
as 
begin 
	select * from AccountStaff
	where username = @username
end
GO

-- Thêm tài khoản vào khi người dùng nhấn đăng kí
-- Thêm vào Staff 
create proc USP_AddStaff
@name nvarchar(100), @email nvarchar(100) 
as 
begin 
	insert into Staff (name, role , contact_info , idshiftschedule)
	values 
			(@name , N'Nhân viên', @email, 1)
end
go

-- Thêm vào Account 
-- Select id from Staff where name = N'Nguyễn Võ Minh Quang' -- lấy idStaff

create proc USP_AddAccount 
@user varchar(100), @pass varchar(100), @idStaff int 
as 
begin 
	insert into Account (username, password, admin, idStaff, accept)
		values 
				(@user , @pass, 0, @idStaff, 0)
end 


-- TEST - DONT EXEC THESE
select *from Account
select * from Staff
select * from AccountStaff

-- Ngày 18/11/2025
-- Đổi row thành varchar(1) với các hàng ghế là A, B, C, D, E

-- Ngày 20/11/2025 
-- Tạo proc cho phần forget 
-- Tạo một số bảng ảo View


select * from movie
select * from snack

Exec USP_GetAccountInfoFromUser 'dantruong2007'

select * from Account

select * from Staff
update Staff set name = N'Phạm Đan Trường', contact_info = 'truongpd.a2.2124@gmail.com' where id = 3;

update Account
set username = 'thichcodedao'
where idStaff = 3;

select * from Account

select * from Account where username = 'dantruong2007'

select * from Seat where idScreen = 1;

set dateformat dmy
select idSeat from ShowTimeDetail where idMovie = 1 and Start_time = '15/12/2025 20:30:00'
select * from Seat where id = 1;
select * from Customer
select * from Bill
select * from Ticket
select * from BillInfo

select * from ShowTimeDetail
select * from Bill
select * from BillInfo
select * from Ticket
select * from Voucher
select * from Hall
update ShowTimeDetail
set available = 0
where available = 1
drop table BillInfo
drop table Ticket
drop table Bill

update Bill
set bill_status = 1
where bill_status = 0


delete from Customer
where name = N'Guest'

select * from Customer

update Bill set bill_status = 1, payment_method = @method where idBill = @id and bill_status = 0

update Bill set bill_status =1, payment_method = 'Banking' where idBill = 3

select * from BillInfo

select * from Screen
select * from Hall
select * from Staff
select * from customer
select * from voucher
select * from account
update BillInfo set Quantity = Quantity + @quan where idBill = @id and Category = 'Food and Drink' and idDetail = @detail 

