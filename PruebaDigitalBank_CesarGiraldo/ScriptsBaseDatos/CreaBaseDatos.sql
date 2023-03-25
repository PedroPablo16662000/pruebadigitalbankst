CREATE DATABASE PruebaDigitalBankST;
GO
USE PruebaDigitalBankST;
GO
CREATE TABLE Usuarios
(
	idUsuario int Primary Key identity(1,1),
	nombreUsuario nvarchar(100) unique not null,
	fechaNacimientoUsuario datetime,
	sexoUsuario nvarchar(1)
);
GO

CREATE PROC CRUD_Usuario
@idUsuario int =null,
@nombreUsuario nvarchar(100) =null,
@fechaNacimientoUsuario datetime =null,
@sexoUsuario nvarchar(1)=null,
@operacion nvarchar(1)=null
AS
--CREATE
IF @operacion='C'
	BEGIN
		INSERT INTO Usuarios(nombreUsuario,fechaNacimientoUsuario,sexoUsuario) 
		VALUES(@nombreUsuario,@fechaNacimientoUsuario,@sexoUsuario);
		SELECT 1;
	END
--READ
ELSE IF @operacion = 'R'
	BEGIN
		SELECT * FROM Usuarios;
	END
ELSE IF @operacion = 'U'
	BEGIN
		UPDATE Usuarios SET nombreUsuario = @nombreUsuario, fechaNacimientoUsuario = @fechaNacimientoUsuario, sexoUsuario = @sexoUsuario
		WHERE idUsuario = @idUsuario;
		SELECT 1;
	END
ELSE IF @operacion = 'D'
	BEGIN
		DELETE Usuarios WHERE idUsuario = @idUsuario;
		SELECT 1;
	END