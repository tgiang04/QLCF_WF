create proc USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar(100), @passWord nvarchar(100), @newPassword nvarchar(100)
As
Begin
	declare @isRightPass int
	select @isRightPass = count(*) from dbo.Account where userName = @userName and passWord = @passWord

	if(@isRightPass = 1)
	begin
		if(@newPassword = null or @newPassword = ' ')
		begin
			update dbo.Account set displayName = @displayName where userName = @userName
		end
		else 
			update dbo.Account set displayName = @displayName, passWord = @passWord where userName = @userName
	end
End