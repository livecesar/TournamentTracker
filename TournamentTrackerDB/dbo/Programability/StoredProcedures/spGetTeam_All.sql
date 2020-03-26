CREATE PROCEDURE [dbo].[spGetTeam_All]
AS
BEGIN

SET NOCOUNT ON;
	SELECT * from dbo.Teams;
END
