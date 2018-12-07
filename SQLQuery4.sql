CREATE procedure [dbo].[AddSuperAminRegP]
(
	@Name nvarchar(50),
	@Email nvarchar(50),
	@Password nvarchar(50),
	@Mobile nvarchar(50),
	@Address nvarchar(100),
	@GovtVerifiedCode nvarchar(50),
	@AdminCode nvarchar(50),
	@CentreCode nvarchar(50),
	@ExamCategory nvarchar(50)
)
as
begin
	Insert into SupATReg values (@Name,@Email,@Password,@Mobile,@Address,@GovtVerifiedCode,@AdminCode,@CentreCode,@ExamCategory)
End