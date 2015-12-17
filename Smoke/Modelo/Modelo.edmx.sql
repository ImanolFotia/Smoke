
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2015 22:16:11
-- Generated from EDMX file: C:\Users\EmilianoAgustin\Documents\Project Smoke\Smoke\Modelo\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SMOKE];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsuariosSoftware]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Software] DROP CONSTRAINT [FK_UsuariosSoftware];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuariosPagos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagos] DROP CONSTRAINT [FK_UsuariosPagos];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuariosUsuarioSoftware]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioSoftware] DROP CONSTRAINT [FK_UsuariosUsuarioSoftware];
GO
IF OBJECT_ID(N'[dbo].[FK_SoftwareUsuarioSoftware]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioSoftware] DROP CONSTRAINT [FK_SoftwareUsuarioSoftware];
GO
IF OBJECT_ID(N'[dbo].[FK_moduloformulario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formularios] DROP CONSTRAINT [FK_moduloformulario];
GO
IF OBJECT_ID(N'[dbo].[FK_formulariopermiso_formulario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formulariopermiso] DROP CONSTRAINT [FK_formulariopermiso_formulario];
GO
IF OBJECT_ID(N'[dbo].[FK_formulariopermiso_permiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[formulariopermiso] DROP CONSTRAINT [FK_formulariopermiso_permiso];
GO
IF OBJECT_ID(N'[dbo].[FK_permisoperfil_permiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[permisoperfil] DROP CONSTRAINT [FK_permisoperfil_permiso];
GO
IF OBJECT_ID(N'[dbo].[FK_permisoperfil_perfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[permisoperfil] DROP CONSTRAINT [FK_permisoperfil_perfil];
GO
IF OBJECT_ID(N'[dbo].[FK_formularioperfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[perfils] DROP CONSTRAINT [FK_formularioperfil];
GO
IF OBJECT_ID(N'[dbo].[FK_grupoperfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[perfils] DROP CONSTRAINT [FK_grupoperfil];
GO
IF OBJECT_ID(N'[dbo].[FK_grupoUsuarios_grupo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupoUsuarios] DROP CONSTRAINT [FK_grupoUsuarios_grupo];
GO
IF OBJECT_ID(N'[dbo].[FK_grupoUsuarios_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[grupoUsuarios] DROP CONSTRAINT [FK_grupoUsuarios_Usuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuariosAuditoriaLogin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AuditoriaLogins] DROP CONSTRAINT [FK_UsuariosAuditoriaLogin];
GO
IF OBJECT_ID(N'[dbo].[FK_SoftwareAuditoriaSoftware]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AuditoriaSoftwares] DROP CONSTRAINT [FK_SoftwareAuditoriaSoftware];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Software]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Software];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Pagos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagos];
GO
IF OBJECT_ID(N'[dbo].[UsuarioSoftware]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioSoftware];
GO
IF OBJECT_ID(N'[dbo].[moduloes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[moduloes];
GO
IF OBJECT_ID(N'[dbo].[formularios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[formularios];
GO
IF OBJECT_ID(N'[dbo].[permisoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[permisoes];
GO
IF OBJECT_ID(N'[dbo].[perfils]', 'U') IS NOT NULL
    DROP TABLE [dbo].[perfils];
GO
IF OBJECT_ID(N'[dbo].[grupoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[grupoes];
GO
IF OBJECT_ID(N'[dbo].[AuditoriaLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuditoriaLogins];
GO
IF OBJECT_ID(N'[dbo].[AuditoriaSoftwares]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuditoriaSoftwares];
GO
IF OBJECT_ID(N'[dbo].[PagoMensualMontoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoMensualMontoes];
GO
IF OBJECT_ID(N'[dbo].[formulariopermiso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[formulariopermiso];
GO
IF OBJECT_ID(N'[dbo].[permisoperfil]', 'U') IS NOT NULL
    DROP TABLE [dbo].[permisoperfil];
GO
IF OBJECT_ID(N'[dbo].[grupoUsuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[grupoUsuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Software'
CREATE TABLE [dbo].[Software] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Categoria] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Edad] int  NOT NULL,
    [Lenguaje] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [Link] nvarchar(max)  NOT NULL,
    [Estado] bit  NOT NULL,
    [Usuario_Id2] int  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] nvarchar(50)  NOT NULL,
    [eMail] nvarchar(max)  NOT NULL,
    [Lenguaje] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Dev] int  NOT NULL,
    [usu_estado] bit  NOT NULL,
    [usu_Admin] bit  NOT NULL,
    [Credito] decimal(18,0)  NOT NULL,
    [Id2] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Pagos'
CREATE TABLE [dbo].[Pagos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NULL,
    [Monto] decimal(18,0)  NOT NULL,
    [Tipo] bit  NOT NULL,
    [Usuario_Id2] int  NOT NULL
);
GO

-- Creating table 'UsuarioSoftware'
CREATE TABLE [dbo].[UsuarioSoftware] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdUsuario] nvarchar(max)  NOT NULL,
    [IdSoftware] int  NOT NULL,
    [Usuario_Id2] int  NOT NULL,
    [Software_Id] int  NOT NULL
);
GO

-- Creating table 'moduloes'
CREATE TABLE [dbo].[moduloes] (
    [mod_codigo] nvarchar(5)  NOT NULL,
    [mod_descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'formularios'
CREATE TABLE [dbo].[formularios] (
    [frm_codigo] int IDENTITY(1,1) NOT NULL,
    [frm_descripcion] nvarchar(max)  NOT NULL,
    [frm_formulario] nvarchar(max)  NOT NULL,
    [frm_estado] bit  NOT NULL,
    [modulo_mod_codigo] nvarchar(5)  NOT NULL
);
GO

-- Creating table 'permisoes'
CREATE TABLE [dbo].[permisoes] (
    [per_codigo] nvarchar(1)  NOT NULL,
    [per_descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'perfils'
CREATE TABLE [dbo].[perfils] (
    [per_codigo] int IDENTITY(1,1) NOT NULL,
    [formulario_frm_codigo] int  NOT NULL,
    [grupo_gru_codigo] nvarchar(4)  NOT NULL
);
GO

-- Creating table 'grupoes'
CREATE TABLE [dbo].[grupoes] (
    [gru_codigo] nvarchar(4)  NOT NULL,
    [gru_descripcion] nvarchar(max)  NOT NULL,
    [gru_estado] bit  NOT NULL
);
GO

-- Creating table 'AuditoriaLogins'
CREATE TABLE [dbo].[AuditoriaLogins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Usuario] nvarchar(max)  NOT NULL,
    [Login] datetime  NULL,
    [Logout] datetime  NULL,
    [Usuario_Id2] int  NOT NULL
);
GO

-- Creating table 'AuditoriaSoftwares'
CREATE TABLE [dbo].[AuditoriaSoftwares] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha_Accion] datetime  NULL,
    [IdUsuario] nvarchar(max)  NOT NULL,
    [Accion] nvarchar(max)  NOT NULL,
    [Software_Id] int  NOT NULL
);
GO

-- Creating table 'PagoMensualMontoes'
CREATE TABLE [dbo].[PagoMensualMontoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Monto] decimal(18,0)  NOT NULL,
    [FechaModificacion] datetime  NOT NULL,
    [IdUsuario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'formulariopermiso'
CREATE TABLE [dbo].[formulariopermiso] (
    [formulario_frm_codigo] int  NOT NULL,
    [permisoes_per_codigo] nvarchar(1)  NOT NULL
);
GO

-- Creating table 'permisoperfil'
CREATE TABLE [dbo].[permisoperfil] (
    [permiso_per_codigo] nvarchar(1)  NOT NULL,
    [perfils_per_codigo] int  NOT NULL
);
GO

-- Creating table 'grupoUsuarios'
CREATE TABLE [dbo].[grupoUsuarios] (
    [grupo_gru_codigo] nvarchar(4)  NOT NULL,
    [Usuarios_Id2] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Software'
ALTER TABLE [dbo].[Software]
ADD CONSTRAINT [PK_Software]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id2] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id2] ASC);
GO

-- Creating primary key on [Id] in table 'Pagos'
ALTER TABLE [dbo].[Pagos]
ADD CONSTRAINT [PK_Pagos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsuarioSoftware'
ALTER TABLE [dbo].[UsuarioSoftware]
ADD CONSTRAINT [PK_UsuarioSoftware]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [mod_codigo] in table 'moduloes'
ALTER TABLE [dbo].[moduloes]
ADD CONSTRAINT [PK_moduloes]
    PRIMARY KEY CLUSTERED ([mod_codigo] ASC);
GO

-- Creating primary key on [frm_codigo] in table 'formularios'
ALTER TABLE [dbo].[formularios]
ADD CONSTRAINT [PK_formularios]
    PRIMARY KEY CLUSTERED ([frm_codigo] ASC);
GO

-- Creating primary key on [per_codigo] in table 'permisoes'
ALTER TABLE [dbo].[permisoes]
ADD CONSTRAINT [PK_permisoes]
    PRIMARY KEY CLUSTERED ([per_codigo] ASC);
GO

-- Creating primary key on [per_codigo] in table 'perfils'
ALTER TABLE [dbo].[perfils]
ADD CONSTRAINT [PK_perfils]
    PRIMARY KEY CLUSTERED ([per_codigo] ASC);
GO

-- Creating primary key on [gru_codigo] in table 'grupoes'
ALTER TABLE [dbo].[grupoes]
ADD CONSTRAINT [PK_grupoes]
    PRIMARY KEY CLUSTERED ([gru_codigo] ASC);
GO

-- Creating primary key on [Id] in table 'AuditoriaLogins'
ALTER TABLE [dbo].[AuditoriaLogins]
ADD CONSTRAINT [PK_AuditoriaLogins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AuditoriaSoftwares'
ALTER TABLE [dbo].[AuditoriaSoftwares]
ADD CONSTRAINT [PK_AuditoriaSoftwares]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PagoMensualMontoes'
ALTER TABLE [dbo].[PagoMensualMontoes]
ADD CONSTRAINT [PK_PagoMensualMontoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [formulario_frm_codigo], [permisoes_per_codigo] in table 'formulariopermiso'
ALTER TABLE [dbo].[formulariopermiso]
ADD CONSTRAINT [PK_formulariopermiso]
    PRIMARY KEY NONCLUSTERED ([formulario_frm_codigo], [permisoes_per_codigo] ASC);
GO

-- Creating primary key on [permiso_per_codigo], [perfils_per_codigo] in table 'permisoperfil'
ALTER TABLE [dbo].[permisoperfil]
ADD CONSTRAINT [PK_permisoperfil]
    PRIMARY KEY NONCLUSTERED ([permiso_per_codigo], [perfils_per_codigo] ASC);
GO

-- Creating primary key on [grupo_gru_codigo], [Usuarios_Id2] in table 'grupoUsuarios'
ALTER TABLE [dbo].[grupoUsuarios]
ADD CONSTRAINT [PK_grupoUsuarios]
    PRIMARY KEY NONCLUSTERED ([grupo_gru_codigo], [Usuarios_Id2] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Usuario_Id2] in table 'Software'
ALTER TABLE [dbo].[Software]
ADD CONSTRAINT [FK_UsuariosSoftware]
    FOREIGN KEY ([Usuario_Id2])
    REFERENCES [dbo].[Usuarios]
        ([Id2])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosSoftware'
CREATE INDEX [IX_FK_UsuariosSoftware]
ON [dbo].[Software]
    ([Usuario_Id2]);
GO

-- Creating foreign key on [Usuario_Id2] in table 'Pagos'
ALTER TABLE [dbo].[Pagos]
ADD CONSTRAINT [FK_UsuariosPagos]
    FOREIGN KEY ([Usuario_Id2])
    REFERENCES [dbo].[Usuarios]
        ([Id2])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosPagos'
CREATE INDEX [IX_FK_UsuariosPagos]
ON [dbo].[Pagos]
    ([Usuario_Id2]);
GO

-- Creating foreign key on [Usuario_Id2] in table 'UsuarioSoftware'
ALTER TABLE [dbo].[UsuarioSoftware]
ADD CONSTRAINT [FK_UsuariosUsuarioSoftware]
    FOREIGN KEY ([Usuario_Id2])
    REFERENCES [dbo].[Usuarios]
        ([Id2])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosUsuarioSoftware'
CREATE INDEX [IX_FK_UsuariosUsuarioSoftware]
ON [dbo].[UsuarioSoftware]
    ([Usuario_Id2]);
GO

-- Creating foreign key on [Software_Id] in table 'UsuarioSoftware'
ALTER TABLE [dbo].[UsuarioSoftware]
ADD CONSTRAINT [FK_SoftwareUsuarioSoftware]
    FOREIGN KEY ([Software_Id])
    REFERENCES [dbo].[Software]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SoftwareUsuarioSoftware'
CREATE INDEX [IX_FK_SoftwareUsuarioSoftware]
ON [dbo].[UsuarioSoftware]
    ([Software_Id]);
GO

-- Creating foreign key on [modulo_mod_codigo] in table 'formularios'
ALTER TABLE [dbo].[formularios]
ADD CONSTRAINT [FK_moduloformulario]
    FOREIGN KEY ([modulo_mod_codigo])
    REFERENCES [dbo].[moduloes]
        ([mod_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_moduloformulario'
CREATE INDEX [IX_FK_moduloformulario]
ON [dbo].[formularios]
    ([modulo_mod_codigo]);
GO

-- Creating foreign key on [formulario_frm_codigo] in table 'formulariopermiso'
ALTER TABLE [dbo].[formulariopermiso]
ADD CONSTRAINT [FK_formulariopermiso_formulario]
    FOREIGN KEY ([formulario_frm_codigo])
    REFERENCES [dbo].[formularios]
        ([frm_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [permisoes_per_codigo] in table 'formulariopermiso'
ALTER TABLE [dbo].[formulariopermiso]
ADD CONSTRAINT [FK_formulariopermiso_permiso]
    FOREIGN KEY ([permisoes_per_codigo])
    REFERENCES [dbo].[permisoes]
        ([per_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_formulariopermiso_permiso'
CREATE INDEX [IX_FK_formulariopermiso_permiso]
ON [dbo].[formulariopermiso]
    ([permisoes_per_codigo]);
GO

-- Creating foreign key on [permiso_per_codigo] in table 'permisoperfil'
ALTER TABLE [dbo].[permisoperfil]
ADD CONSTRAINT [FK_permisoperfil_permiso]
    FOREIGN KEY ([permiso_per_codigo])
    REFERENCES [dbo].[permisoes]
        ([per_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [perfils_per_codigo] in table 'permisoperfil'
ALTER TABLE [dbo].[permisoperfil]
ADD CONSTRAINT [FK_permisoperfil_perfil]
    FOREIGN KEY ([perfils_per_codigo])
    REFERENCES [dbo].[perfils]
        ([per_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_permisoperfil_perfil'
CREATE INDEX [IX_FK_permisoperfil_perfil]
ON [dbo].[permisoperfil]
    ([perfils_per_codigo]);
GO

-- Creating foreign key on [formulario_frm_codigo] in table 'perfils'
ALTER TABLE [dbo].[perfils]
ADD CONSTRAINT [FK_formularioperfil]
    FOREIGN KEY ([formulario_frm_codigo])
    REFERENCES [dbo].[formularios]
        ([frm_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_formularioperfil'
CREATE INDEX [IX_FK_formularioperfil]
ON [dbo].[perfils]
    ([formulario_frm_codigo]);
GO

-- Creating foreign key on [grupo_gru_codigo] in table 'perfils'
ALTER TABLE [dbo].[perfils]
ADD CONSTRAINT [FK_grupoperfil]
    FOREIGN KEY ([grupo_gru_codigo])
    REFERENCES [dbo].[grupoes]
        ([gru_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_grupoperfil'
CREATE INDEX [IX_FK_grupoperfil]
ON [dbo].[perfils]
    ([grupo_gru_codigo]);
GO

-- Creating foreign key on [grupo_gru_codigo] in table 'grupoUsuarios'
ALTER TABLE [dbo].[grupoUsuarios]
ADD CONSTRAINT [FK_grupoUsuarios_grupo]
    FOREIGN KEY ([grupo_gru_codigo])
    REFERENCES [dbo].[grupoes]
        ([gru_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Usuarios_Id2] in table 'grupoUsuarios'
ALTER TABLE [dbo].[grupoUsuarios]
ADD CONSTRAINT [FK_grupoUsuarios_Usuarios]
    FOREIGN KEY ([Usuarios_Id2])
    REFERENCES [dbo].[Usuarios]
        ([Id2])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_grupoUsuarios_Usuarios'
CREATE INDEX [IX_FK_grupoUsuarios_Usuarios]
ON [dbo].[grupoUsuarios]
    ([Usuarios_Id2]);
GO

-- Creating foreign key on [Usuario_Id2] in table 'AuditoriaLogins'
ALTER TABLE [dbo].[AuditoriaLogins]
ADD CONSTRAINT [FK_UsuariosAuditoriaLogin]
    FOREIGN KEY ([Usuario_Id2])
    REFERENCES [dbo].[Usuarios]
        ([Id2])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosAuditoriaLogin'
CREATE INDEX [IX_FK_UsuariosAuditoriaLogin]
ON [dbo].[AuditoriaLogins]
    ([Usuario_Id2]);
GO

-- Creating foreign key on [Software_Id] in table 'AuditoriaSoftwares'
ALTER TABLE [dbo].[AuditoriaSoftwares]
ADD CONSTRAINT [FK_SoftwareAuditoriaSoftware]
    FOREIGN KEY ([Software_Id])
    REFERENCES [dbo].[Software]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SoftwareAuditoriaSoftware'
CREATE INDEX [IX_FK_SoftwareAuditoriaSoftware]
ON [dbo].[AuditoriaSoftwares]
    ([Software_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------