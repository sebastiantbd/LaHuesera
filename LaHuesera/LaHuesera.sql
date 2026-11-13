CREATE DATABASE LaHuesera;
GO

USE LaHuesera;
GO


CREATE TABLE usuarios (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombre NVARCHAR(50) NOT NULL UNIQUE,
    clave NVARCHAR(50) NOT NULL,
    rol NVARCHAR(30) NOT NULL,
);
GO

CREATE TABLE peliculas
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(255) NOT NULL,
    duracion VARCHAR(50) NOT NULL,
    codigo INT NOT NULL UNIQUE
);
GO

CREATE TABLE prestamos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    usuarioId INT NOT NULL,
    peliculaId INT NOT NULL,
    fechaPrestamo DATETIME NOT NULL,
    fechaEntrega DATETIME,
    estado VARCHAR(50) NOT NULL,

    FOREIGN KEY (usuarioId) REFERENCES usuarios(id),
    FOREIGN KEY (peliculaId) REFERENCES peliculas(id)
);
GO

INSERT INTO usuarios (nombre, clave, rol)
VALUES
('Admin', '123', 'Administrador'),
('Helem', '456', 'Administrador'),
('Sebastian T', '789', 'Administrador'),
('Luisa M', 'Juan123', 'Cliente'),
('Lina Q', 'Laura123', 'Taquillero');

INSERT INTO peliculas (nombre, descripcion, duracion, codigo)
VALUES
('El abrazo de la serpiente', 'Un chamán amazónico y dos científicos recorren la selva colombiana en busca de una planta sagrada.', '125 minutos', 1001),
('La estrategia del caracol', 'Un grupo de habitantes de una casa en Bogotá lucha por evitar su desalojo.', '116 minutos', 1002),
('Encanto', 'Una familia colombiana mágica vive en una casa encantada en las montañas de Colombia.', '102 minutos', 1003),
('Los colores de la montaña', 'Un niño colombiano sueña con recuperar su balón perdido en medio del conflicto armado.', '90 minutos', 1004),
('El paseo', 'Una familia colombiana vive una divertida aventura durante sus vacaciones.', '90 minutos', 1005);

INSERT INTO prestamos
(usuarioId, peliculaId, fechaPrestamo, fechaEntrega, estado)
VALUES
(3, 1, '2026-11-01', '2026-11-05', 'Devuelto'),
(4, 2, '2026-11-03', NULL, 'Prestado'),
(3, 3, '2026-11-05', NULL, 'Prestado'),
(5, 4, '2026-11-06', '2026-11-10', 'Devuelto'),
(2, 5, '2026-11-08', NULL, 'Prestado');

--select de cada tabla
SELECT * FROM usuarios;
SELECT * FROM peliculas;
SELECT * FROM prestamos;


---seleccion de prestamos entre usuarios y peliculas

SELECT
    p.id AS PrestamoID,
    u.nombre AS Usuario,
    u.rol AS Rol,
    pe.nombre AS Pelicula,
    p.fechaPrestamo,
    p.fechaEntrega,
    p.estado
FROM prestamos p
INNER JOIN usuarios u ON p.usuarioId = u.id
INNER JOIN peliculas pe ON p.peliculaId = pe.id;
GO