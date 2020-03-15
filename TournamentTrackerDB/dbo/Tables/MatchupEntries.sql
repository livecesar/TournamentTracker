﻿CREATE TABLE [dbo].[MatchupEntries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MatchupId] INT NOT NULL, 
    [ParentMatchupId] NCHAR(10) NOT NULL, 
    [TeamCompetingId] INT NOT NULL, 
    [Score] INT NOT NULL, 
    CONSTRAINT [FK_MatchupEntries_ToMatchups] FOREIGN KEY ([MatchupId]) REFERENCES [Matchups]([Id])
)