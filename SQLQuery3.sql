CREATE procedure [dbo].[AddAdRegP]
(
	@Name nvarchar(50),
	@Email nvarchar(50),
	@Password nvarchar(50),
	@Mobile nvarchar(50),
	@Address nvarchar(100),
	@SuperAdminCode nvarchar(50),
	@PersonalCode nvarchar(50),
	@Organization nvarchar(50),
	@ExamCategory nvarchar(50)
)
as
begin
	Insert into AdTReg values (@Name,@Email,@Password,@Mobile,@Address,@SuperAdminCode,@PersonalCode,@Organization,@ExamCategory)
End