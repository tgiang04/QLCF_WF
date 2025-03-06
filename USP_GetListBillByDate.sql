select t.name, b.totalPrice, DateCheckIn, DateCheckOut, discount from dbo.Bill As b, dbo.TableCF as t
where DateCheckIn >= '20250301' and DateCheckOut <= '20250331' and b.status = 1
and t.id = b.idTable 

Go

alter proc USP_GetListBillByDate
@checkIn date, @checkOut date
As
Begin
	select t.name As [Tên bàn], b.totalPrice As [Tổng tiền], DateCheckIn As [Ngày vào], DateCheckOut As [Ngày ra], discount As [Giảm giá] from dbo.Bill As b, dbo.TableCF as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1
	and t.id = b.idTable 
End

go

select *from dbo.Bill