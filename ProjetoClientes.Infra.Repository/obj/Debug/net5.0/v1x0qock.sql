IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [CLIENTE] (
    [IDCLIENTE] uniqueidentifier NOT NULL,
    [NOME] nvarchar(150) NOT NULL,
    [TELEFONE] nvarchar(25) NOT NULL,
    [CPF] nvarchar(15) NOT NULL,
    [EMAIL] nvarchar(100) NOT NULL,
    [DATACADASTRO] datetime2 NOT NULL,
    CONSTRAINT [PK_CLIENTE] PRIMARY KEY ([IDCLIENTE])
);
GO

CREATE UNIQUE INDEX [IX_CLIENTE_CPF] ON [CLIENTE] ([CPF]);
GO

CREATE UNIQUE INDEX [IX_CLIENTE_EMAIL] ON [CLIENTE] ([EMAIL]);
GO

CREATE UNIQUE INDEX [IX_CLIENTE_TELEFONE] ON [CLIENTE] ([TELEFONE]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211108235918_Initial', N'5.0.12');
GO

COMMIT;
GO

