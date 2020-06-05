IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Prescription_Medicament] (
    [IdMedicament] int NOT NULL IDENTITY,
    [IdPrescription] int NOT NULL,
    [Dose] int NOT NULL,
    [Details] nvarchar(100) NULL,
    CONSTRAINT [PK_Prescription_Medicament] PRIMARY KEY ([IdMedicament])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200604225558_AddPrescription_Medicament', N'3.1.4');

GO

