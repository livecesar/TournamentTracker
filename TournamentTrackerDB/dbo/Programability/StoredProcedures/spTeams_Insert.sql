CREATE PROCEDURE [dbo].[spTeams_Insert]
	@TeamName nvarchar(100),
	@id int = 0 output
AS
BEGIN
	INSERT INTO dbo.Teams (TeamName)
	VALUES (@TeamName);

	SELECT @id = SCOPE_IDENTITY();
END
GO
