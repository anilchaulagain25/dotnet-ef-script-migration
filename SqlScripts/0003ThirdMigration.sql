DELETE FROM [FirstModel]
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200406124022_ThirdMigration', N'3.1.3');

GO

