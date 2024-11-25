CREATE DATABASE ProgramacionWeb;
GO

USE ProgramacionWeb;
GO

-- Tabla: TipoEvento
CREATE TABLE TipoEvento (
    IdTipoEvento INT PRIMARY KEY IDENTITY(1,1),
    NombreTipo VARCHAR(50) NOT NULL
);

-- Tabla: TipoUsuario
CREATE TABLE TipoUsuario (
    IdTipoUsuario INT PRIMARY KEY IDENTITY(1,1),
    NombreTipo VARCHAR(50) NOT NULL
);

-- Tabla: Usuarios
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    NombreCompleto VARCHAR(100) NOT NULL,
    Usuario VARCHAR(50) NOT NULL,
    Contrasena VARCHAR(50) NOT NULL,
    Edad INT NOT NULL,
    IdTipoUsuario INT NOT NULL,
    FOREIGN KEY (IdTipoUsuario) REFERENCES TipoUsuario(IdTipoUsuario)
);

-- Tabla: Eventos
CREATE TABLE Eventos (
    IdEvento INT PRIMARY KEY IDENTITY(1,1),
    NombreEvento VARCHAR(100) NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Lugar VARCHAR(500),
    IdTipoEvento INT NOT NULL,
    FOREIGN KEY (IdTipoEvento) REFERENCES TipoEvento(IdTipoEvento)
);

-- Tabla: AsistenciaEventos
CREATE TABLE AsistenciaEventos (
    IdEvento INT NOT NULL,
    IdUsuario INT NOT NULL,
    ConfirmaAsistencia BIT NOT NULL,
    FechaRespuesta DATE NOT NULL,
    PRIMARY KEY (IdEvento, IdUsuario),
    FOREIGN KEY (IdEvento) REFERENCES Eventos(IdEvento),
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Tabla: Carrusel
CREATE TABLE Carrusel (
    IdImagen INT PRIMARY KEY IDENTITY(1,1),
    RutaImagen VARCHAR(500) NOT NULL,
    IdUsuario INT NOT NULL,
    TextoAlternativo VARCHAR(500),
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Tabla: Ensayos
CREATE TABLE Ensayos (
    IdEnsayo INT PRIMARY KEY IDENTITY(1,1),
    NombreEnsayo VARCHAR(100),
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Lugar VARCHAR(500)
);

-- Tabla: AsistenciaEnsayos
CREATE TABLE AsistenciaEnsayos (
    IdEnsayo INT NOT NULL,
    IdUsuario INT NOT NULL,
    ConfirmaAsistencia BIT NOT NULL,
    FechaRespuesta DATE NOT NULL,
    PRIMARY KEY (IdEnsayo, IdUsuario),
    FOREIGN KEY (IdEnsayo) REFERENCES Ensayos(IdEnsayo),
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Tabla: Audiciones
CREATE TABLE Audiciones (
    IdAudicion INT PRIMARY KEY IDENTITY(1,1),
    Titulo VARCHAR(100),
    Descripcion VARCHAR(1000),
    Link VARCHAR(500),
    IdUsuario INT NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Tabla: CatalogoSecciones
CREATE TABLE CatalogoSecciones (
    IdCatalogo INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL
);

-- Tabla: SeccionAcercaNosotrosYPortafolio
CREATE TABLE SeccionAcercaNosotrosYPortafolio (
    IdSeccion INT PRIMARY KEY IDENTITY(1,1),
    IdCatalogo INT NOT NULL,
    Titulo VARCHAR(100) NOT NULL,
    ContenidoTexto VARCHAR(8000) NOT NULL,
    Imagen VARCHAR(500),
    TextoAlternativo VARCHAR(500),
    IdUsuario INT NOT NULL,
    Orden INT NOT NULL,
    FOREIGN KEY (IdCatalogo) REFERENCES CatalogoSecciones(IdCatalogo),
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Tabla: Contactanos
CREATE TABLE Contactanos (
    IdContacto INT PRIMARY KEY IDENTITY(1,1),
    RedSocial VARCHAR(50),
    Link VARCHAR(500),
    Nombre VARCHAR(50) NOT NULL,
    IdUsuario INT NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Insertar datos en TipoEvento
INSERT INTO TipoEvento (NombreTipo) VALUES
('Estatal'),
('Nacional'),
('Internacional');

-- Insertar datos en TipoUsuario
INSERT INTO TipoUsuario (NombreTipo) VALUES
('Administrador'),
('Bailarín');

-- Insertar datos en CatalogoSecciones
INSERT INTO CatalogoSecciones (Nombre) VALUES
('Historia'),
('Misión'),
('Nuestro Equipo'),
('Valores'),
('Visión');

