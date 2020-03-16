CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId int
	
AS
begin
SET NOCOUNT ON;
	SELECT p.*
	from dbo.Prizes p
	inner join dbo.TournamentPrizes t on p.Id=t.PrizeId
	where t.TournamentId = @TournamentId
end
