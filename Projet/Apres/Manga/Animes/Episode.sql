CREATE TABLE [dbo].[Episode]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Id_Animes] INT NOT NULL, 
    [Num_Episode] VARCHAR(50) NOT NULL, 
    [lien] VARCHAR(100) NULL, 
    CONSTRAINT [FK_Episode_ToTable] FOREIGN KEY ([Id_Animes]) REFERENCES [Anime](Id)
)
