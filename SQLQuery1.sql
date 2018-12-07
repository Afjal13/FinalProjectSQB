Create  procedure [dbo].[SubAdminReg]
(
	@Name nvarchar(50),
	@Email nvarchar(50),
	@Password nvarchar(50),
	@Mobile nvarchar(50),
	@Address nvarchar(100),
	@Organization nvarchar(50),
	@Admincode nvarchar(50),
	@Personalcode nvarchar(50),
	@Examcategory nvarchar(50)
)
as
begin
	Insert into SuATReg(Name,Email,Password,Mobile,Address,Organization,Admincode,Personalcode,Examcategory) values(@Name,@Email,@Password,@Mobile,@Address,@Organization,@Admincode,@Personalcode,@Examcategory)
End