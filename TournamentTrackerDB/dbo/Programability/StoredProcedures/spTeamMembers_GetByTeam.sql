CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
set nocount on;

	SELECT * from dbo.TeamMembers m
	inner join dbo.People p on m.PersonId = p.Id
	where m.TeamId = @TeamId;
end
