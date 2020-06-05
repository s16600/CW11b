IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Prescription] (
    [Id] int NOT NULL IDENTITY,
    [Date] datetime2 NOT NULL,
    [DueDate] datetime2 NOT NULL,
    [IdPatient] int NOT NULL,
    [IdDoctor] int NOT NULL,
    CONSTRAINT [PK_Prescription] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200604214152_AddPrescription', N'3.1.4');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200604220224_AddPrescriptionForeignKey', N'3.1.4');

GO

