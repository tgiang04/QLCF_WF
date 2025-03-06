alter proc	USP_InsertBillInfo @idBill int, @idFood int, @count int
As
Begin
	
	declare @isExitBillInfo int;
	declare @foodCount int = 1;
	select @isExitBillInfo = id, @foodCount = b.count
	from dbo.BillInfo as b where id = @idBill and idFood = @idFood 
	if(@isExitBillInfo > 0)
	Begin
		declare @newCount int = @foodCount +@count
		if (@newCount > 0)
		Update dbo.BillInfo set count = @foodCount + @count where idFood = @idFood
		else 
		delete dbo.BillInfo where idBill = @idBill and idFood = @idFood
	End
	else
	begin
			insert into dbo.BillInfo
	(
		idBill,
		idFood,
		count
	)
	values (
		@idBill,
		@idFood,
		@count
		)
	end
	
End