Alter TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS 
BEGIN
	PRINT 'Trigger activated for DELETE on BillInfo.';
	
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted

	PRINT 'Trigger activated for DELETE on BillInfo.';
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count INT = 0
	
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableCF SET status = N'Trống' WHERE id = @idTable
	PRINT 'Trigger activated for DELETE on BillInfo.';
END

Go

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END

go

select *from dbo.Account