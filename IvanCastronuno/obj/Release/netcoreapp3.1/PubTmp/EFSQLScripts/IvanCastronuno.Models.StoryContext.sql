IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201105053726_Initial')
BEGIN
    CREATE TABLE [User] (
        [UserId] nvarchar(450) NOT NULL,
        [UserName] nvarchar(max) NULL,
        CONSTRAINT [PK_User] PRIMARY KEY ([UserId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201105053726_Initial')
BEGIN
    CREATE TABLE [Stories] (
        [StoryID] int NOT NULL IDENTITY,
        [StoryTitle] nvarchar(max) NULL,
        [StoryTopic] nvarchar(max) NULL,
        [StoryText] nvarchar(max) NULL,
        [UserId] nvarchar(450) NULL,
        CONSTRAINT [PK_Stories] PRIMARY KEY ([StoryID]),
        CONSTRAINT [FK_Stories_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([UserId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201105053726_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[User]'))
        SET IDENTITY_INSERT [User] ON;
    INSERT INTO [User] ([UserId], [UserName])
    VALUES (N'1', N'Johnny'),
    (N'2', N'Tommy'),
    (N'3', N'Danny'),
    (N'4', N'Mannly'),
    (N'5', N'Conny'),
    (N'6', N'Sunny'),
    (N'7', N'Diandra');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[User]'))
        SET IDENTITY_INSERT [User] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201105053726_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StoryID', N'StoryText', N'StoryTitle', N'StoryTopic', N'UserId') AND [object_id] = OBJECT_ID(N'[Stories]'))
        SET IDENTITY_INSERT [Stories] ON;
    INSERT INTO [Stories] ([StoryID], [StoryText], [StoryTitle], [StoryTopic], [UserId])
    VALUES (1, N'To do a travel wearing armor isn''t fun', N'Viaje', N'Travel', N'1');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StoryID', N'StoryText', N'StoryTitle', N'StoryTopic', N'UserId') AND [object_id] = OBJECT_ID(N'[Stories]'))
        SET IDENTITY_INSERT [Stories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201105053726_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StoryID', N'StoryText', N'StoryTitle', N'StoryTopic', N'UserId') AND [object_id] = OBJECT_ID(N'[Stories]'))
        SET IDENTITY_INSERT [Stories] ON;
    INSERT INTO [Stories] ([StoryID], [StoryText], [StoryTitle], [StoryTopic], [UserId])
    VALUES (2, N'To redo your costume three times for not follow the instructions is a common noob mistake.', N'Crafting', N'Use instructions', N'6');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StoryID', N'StoryText', N'StoryTitle', N'StoryTopic', N'UserId') AND [object_id] = OBJECT_ID(N'[Stories]'))
        SET IDENTITY_INSERT [Stories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201105053726_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StoryID', N'StoryText', N'StoryTitle', N'StoryTopic', N'UserId') AND [object_id] = OBJECT_ID(N'[Stories]'))
        SET IDENTITY_INSERT [Stories] ON;
    INSERT INTO [Stories] ([StoryID], [StoryText], [StoryTitle], [StoryTopic], [UserId])
    VALUES (3, N'When on a recreation , if u have food , you''ll find friends', N'Food', N'Find friends', N'7');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StoryID', N'StoryText', N'StoryTitle', N'StoryTopic', N'UserId') AND [object_id] = OBJECT_ID(N'[Stories]'))
        SET IDENTITY_INSERT [Stories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201105053726_Initial')
BEGIN
    CREATE INDEX [IX_Stories_UserId] ON [Stories] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201105053726_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201105053726_Initial', N'3.1.9');
END;

GO

