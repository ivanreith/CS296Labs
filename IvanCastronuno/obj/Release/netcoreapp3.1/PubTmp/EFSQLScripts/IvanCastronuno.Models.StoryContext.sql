IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        [Discriminator] nvarchar(max) NOT NULL,
        [Name] nvarchar(50) NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE TABLE [Story] (
        [StoryID] int NOT NULL IDENTITY,
        [StoryTitle] nvarchar(50) NOT NULL,
        [StoryTopic] nvarchar(25) NOT NULL,
        [StoryText] nvarchar(250) NOT NULL,
        [Name] nvarchar(max) NULL,
        [PosterId] nvarchar(450) NULL,
        [StoryTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Story] PRIMARY KEY ([StoryID]),
        CONSTRAINT [FK_Story_AspNetUsers_PosterId] FOREIGN KEY ([PosterId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Discriminator', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName', N'Name') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] ON;
    INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Discriminator], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName], [Name])
    VALUES (N'60a427a2-25e6-4df5-a26c-33d31eeef1b9', 0, N'cc29556a-aede-49a0-82b6-4bf9d7217b82', N'AppUser', NULL, CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, NULL, NULL, CAST(0 AS bit), N'4e6990c9-f336-4112-af76-7373edbe5c26', CAST(0 AS bit), NULL, N'Johnny'),
    (N'd2f38745-ccf3-4b43-9721-a6a557b2126a', 0, N'5f65b656-fdae-48eb-9108-2ba68e6aa9d8', N'AppUser', NULL, CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, NULL, NULL, CAST(0 AS bit), N'fc2ea4a9-0214-4261-9ea7-c74941ef269f', CAST(0 AS bit), NULL, N'Tommy'),
    (N'8588e411-47f9-4c7a-929b-3a22f2bfca5b', 0, N'622127fd-ee7c-4e86-ba6c-44f48e684eaa', N'AppUser', NULL, CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, NULL, NULL, CAST(0 AS bit), N'd7b9964f-f878-4c45-b8e5-5c432305a3bb', CAST(0 AS bit), NULL, N'Danny'),
    (N'b342a0eb-d623-4ce2-82ba-a2f793e9efec', 0, N'06448b97-948a-45f8-8090-126d8c357895', N'AppUser', NULL, CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, NULL, NULL, CAST(0 AS bit), N'55217e98-547b-4c83-b93c-2495e5cd88d7', CAST(0 AS bit), NULL, N'Mannly'),
    (N'90381cf3-eeef-4af0-bfcc-0fa26497ff0a', 0, N'a414e7d8-87e8-4fcb-af64-54955e60843e', N'AppUser', NULL, CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, NULL, NULL, CAST(0 AS bit), N'18cc037a-4e42-44b3-8780-e8b47013d4de', CAST(0 AS bit), NULL, N'Conny'),
    (N'2aab63df-014d-477a-9cfe-37910223d495', 0, N'59314fd2-80dc-4d13-85fa-2bce23538c91', N'AppUser', NULL, CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, NULL, NULL, CAST(0 AS bit), N'5138b283-b2cc-4763-89a5-5fc79742d3d5', CAST(0 AS bit), NULL, N'Sunny'),
    (N'a0dd29b9-f96f-425a-be8a-f2f8a5bcba15', 0, N'50cee1fd-88f7-4921-9246-80d739da532f', N'AppUser', NULL, CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, NULL, NULL, CAST(0 AS bit), N'a3325a4f-ea20-48e2-becf-b5ad2cf5d95b', CAST(0 AS bit), NULL, N'Diandra');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Discriminator', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName', N'Name') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StoryID', N'Name', N'PosterId', N'StoryText', N'StoryTime', N'StoryTitle', N'StoryTopic') AND [object_id] = OBJECT_ID(N'[Story]'))
        SET IDENTITY_INSERT [Story] ON;
    INSERT INTO [Story] ([StoryID], [Name], [PosterId], [StoryText], [StoryTime], [StoryTitle], [StoryTopic])
    VALUES (1, N'Johnny', NULL, N'To do a travel wearing armor isn''t fun', '2021-01-12T00:00:00.0000000-08:00', N'Viaje', N'Travel'),
    (2, N'Mannly', NULL, N'To redo your costume three times for not follow the instructions is a common noob mistake.', '2021-01-12T00:00:00.0000000-08:00', N'Crafting', N'Use instructions'),
    (3, N'Diandra', NULL, N'When on a recreation , if u have food , you''ll find friends', '2021-01-12T00:00:00.0000000-08:00', N'Food', N'Find friends');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StoryID', N'Name', N'PosterId', N'StoryText', N'StoryTime', N'StoryTitle', N'StoryTopic') AND [object_id] = OBJECT_ID(N'[Story]'))
        SET IDENTITY_INSERT [Story] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    CREATE INDEX [IX_Story_PosterId] ON [Story] ([PosterId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210112220530_Validation')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210112220530_Validation', N'3.1.9');
END;

GO

