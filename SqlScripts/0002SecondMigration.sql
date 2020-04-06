ALTER TABLE [FirstModel] ADD [OtherField] nvarchar(50) NULL;

GO

CREATE TABLE [SecondModel] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    CONSTRAINT [PK_SecondModel] PRIMARY KEY ([Id])
);

GO

UPDATE [FirstModel] SET [Name] = N'VueJS'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'OtherField') AND [object_id] = OBJECT_ID(N'[FirstModel]'))
    SET IDENTITY_INSERT [FirstModel] ON;
INSERT INTO [FirstModel] ([Id], [Name], [OtherField])
VALUES (2, N'Webpack', NULL);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'OtherField') AND [object_id] = OBJECT_ID(N'[FirstModel]'))
    SET IDENTITY_INSERT [FirstModel] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[SecondModel]'))
    SET IDENTITY_INSERT [SecondModel] ON;
INSERT INTO [SecondModel] ([Id], [Name])
VALUES (1, N'Shankhu'),
(2, N'Bhumethumka');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[SecondModel]'))
    SET IDENTITY_INSERT [SecondModel] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200406123537_SecondMigration', N'3.1.3');

GO

