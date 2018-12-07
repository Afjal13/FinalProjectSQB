CREATE procedure [dbo].[AddCentreAminRegP]
(
	@Name nvarchar(50),
	@Email nvarchar(50),
	@Password nvarchar(50),
	@Mobile nvarchar(50),
	@Address nvarchar(100),
	@Organization nvarchar(50),
	@EmisCode nvarchar(50),
	@ExamCategory nvarchar(50),
	@SuperAdminCode nvarchar(50)
)
as
begin
	Insert into CenATReg values (@Name,@Email,@Password,@Mobile,@Address,@Organization,@EmisCode,@ExamCategory,@SuperAdminCode)
End