CREATE TABLE [dbo].[SiteObjects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] TEXT NULL, 
    [Type] INT NULL, 
    [Path] TEXT NULL,
    [Category] INT NULL, 
    CONSTRAINT FK_SiteObjects_SiteObjectTypes FOREIGN KEY ([Type]) REFERENCES [dbo].[SiteObjectTypes]([Id]),
    CONSTRAINT FK_SiteObjects_SiteObjectCategories FOREIGN KEY ([Category]) REFERENCES [dbo].[SiteObjectCategories]([Id])
)
