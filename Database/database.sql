
USE QLCF

Go

Create table TableCF(
	id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(90) not null DEFAULT N'Bàn chưa có tên',
    status NVARCHAR(100) not null DEFAULT N'Trống'
);

Create table Account(
    displayName nvarchar(100) not null DEFAULT N'TGiang',
    userName nvarchar(100) primary key,
    passWord nvarchar(1000) not null DEFAULT 0,
    type INT not null DEFAULT 0
);

Create table Category(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
);

Create table Food(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.Category(id)
);

Create table Bill(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableCF(id)
);

Create table BillInfo(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
);
