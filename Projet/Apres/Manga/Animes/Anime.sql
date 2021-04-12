CREATE TABLE [dbo].[Anime]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nom] VARCHAR(50) NOT NULL, 
    [Genres] VARCHAR(100) NOT NULL, 
    [Synopsis] VARCHAR(1500) NOT NULL, 
    [Motif] VARCHAR(50) NOT NULL, 
    [Image] VARCHAR(60) NULL
)
