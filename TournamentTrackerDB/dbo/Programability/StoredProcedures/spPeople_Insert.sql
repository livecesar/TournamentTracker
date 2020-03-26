CREATE PROCEDURE [dbo].[spPeople_Insert]
	@FirstName NVARCHAR(100),
	@LastName NVARCHAR(100),
	@EmailAddress NVARCHAR(100),
	@CellphoneNumber NVARCHAR(50),
	@id INT = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO DBO.People(FirstName, LastName, Email, Cellphone)
	VALUES (@FirstName, @LastName, @EmailAddress, @CellphoneNumber);

	SELECT @id = SCOPE_IDENTITY();
END
GO