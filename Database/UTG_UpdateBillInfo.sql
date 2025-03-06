
create trigger UTG_UpdateBillInfo
On dbo.BillInfo for insert, update
As
begin
	declare @idBill int
	select @idBill = idBill  from inserted
	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idBill and status = 0
	update dbo.TableCF set status = N'Có người' where id = @idTable
END

Go

alter trigger UTG_UpdateBill
on dbo.Bill for update
As
Begin
	declare @idBill int
	select @idBill = id from inserted
	declare @idTable int	
	select @idTable = idTable from dbo.Bill where id = @idBill
	declare @count int = 0
	select @count = count(*) from dbo.Bill where idTable = @idTable and status = 0

	if(@count = 0)
	update dbo.TableCF set status = N'Trống' where id = @idTable
end
Go

create trigger UTG_UpdateTable
on dbo.TableCF for update
As
Begin
	declare @idTable int
	declare @status nvarchar(100)
	select @idTable = id, @status = inserted.status from inserted
	declare @idBill int
	select @idBill = id from dbo.Bill where idTable = @idTable and status = 0
	declare @countBillInfo int
	select @countBillInfo = count(*) from dbo.BillInfo where idBill = @idBill

	if(@countBillInfo > 0 and @status <> N'Có người')
		update dbo.TableCF set status = N'Có người' where id = @idTable
	else if (@countBillInfo <= 0 and @status <> N'Trống')
		update dbo.TableCF set status = N'Trống' where id = @idTable
End

Go