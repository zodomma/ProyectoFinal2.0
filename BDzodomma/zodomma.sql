-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-01-2020 a las 05:48:10
-- Versión del servidor: 10.4.10-MariaDB
-- Versión de PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `zodomma`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `SPActualizarCategoria` (IN `_id_categoria` INT, IN `_nombre` VARCHAR(20), IN `_descripcion` VARCHAR(150))  BEGIN
	UPDATE tbl_categoria set nombre=_nombre,descripcion=_descripcion WHERE id_categoria=_id_categoria;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPActualizarProducto` (IN `_id_producto` INT, IN `_id_categoria` INT, IN `_nombre` VARCHAR(20), IN `_precio` INT, IN `_cantidad` INT)  BEGIN
	UPDATE tbl_productos SET nombre=_nombre,precio=_precio,cantidad=_cantidad,id_categoria=_id_categoria WHERE id_productos=_id_producto;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPEliminarCategoria` (IN `_id_categoria` INT)  BEGIN
	DELETE FROM tbl_categoria WHERE id_categoria=_id_categoria;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPEliminarProducto` (IN `_id_producto` INT)  BEGIN
	DELETE FROM tbl_productos WHERE id_productos = _id_producto;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPInsertarProducto` (IN `_id_categoria` INT, IN `_nombre` VARCHAR(20), IN `_precio` INT, IN `_cantidad` INT)  BEGIN
	INSERT INTO tbl_productos (nombre,precio,cantidad,id_categoria) VALUES (_nombre,_precio,_cantidad,_id_categoria);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPListarCategoria` ()  BEGIN
	SELECT * FROM tbl_categoria;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPListarProductos` ()  BEGIN
	SELECT p.id_productos,p.nombre,p.cantidad,p.precio,c.nombre FROM tbl_productos AS p JOIN tbl_categoria AS c ON p.id_categoria = c.id_categoria;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPLoguin` (IN `_usuario` VARCHAR(30), IN `_pass` VARCHAR(100))  BEGIN
SELECT id_usuario,pass,tipo from tbl_usuario WHERE id_usuario=_usuario AND pass=_pass;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPMostrarCategoria` ()  BEGIN
SELECT nombre from tbl_categoria;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPRecuperar` (IN `_usuario` VARCHAR(30), IN `_respuesta` VARCHAR(50), IN `_pass` VARCHAR(100))  BEGIN
UPDATE tbl_usuario SET pass=_pass WHERE id_usuario=_usuario AND respuesta=_respuesta;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPRegistrarAdmin` (IN `_usuario` VARCHAR(30), IN `_contra` VARCHAR(100), IN `_pregunta` VARCHAR(50), IN `_respuesta` VARCHAR(50), IN `_tusuario` INT)  BEGIN
Insert into tbl_usuario(id_usuario,pass,pregunta,respuesta,tipo) VALUES (_usuario,_contra,_pregunta,_respuesta,_tusuario);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPRegistrarCategoria` (IN `_nombre` VARCHAR(20), IN `_descripcion` VARCHAR(150))  BEGIN
	INSERT INTO tbl_categoria (nombre,descripcion) VALUES (_nombre,_descripcion);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPRegistrarUsuario` (IN `_USUARIO` VARCHAR(30), IN `_CONTRA` VARCHAR(100), IN `_PREGUNTA` VARCHAR(50), IN `_RESPUESTA` VARCHAR(50), IN `_TIPO` INT)  BEGIN
insert into tbl_usuario(id_usuario,pass,pregunta,respuesta,tipo) VALUES (_USUARIO,_CONTRA,_PREGUNTA,_RESPUESTA,_TIPO);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_categoria`
--

CREATE TABLE `tbl_categoria` (
  `id_categoria` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `descripcion` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_categoria`
--

INSERT INTO `tbl_categoria` (`id_categoria`, `nombre`, `descripcion`) VALUES
(1, 'Cervesas Importadas', 'Categoria donde se guardan las cervezas que no son propias de nuestro pais'),
(2, 'vodka', 'tipos de vodka '),
(3, 'Aguardiente col', 'aguardientes de colombia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_dfactura`
--

CREATE TABLE `tbl_dfactura` (
  `id_dfactura` int(10) DEFAULT NULL,
  `id_producto` int(10) DEFAULT NULL,
  `cantidad` int(3) DEFAULT NULL,
  `subtital` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_dmesas`
--

CREATE TABLE `tbl_dmesas` (
  `id_mesas` int(10) NOT NULL,
  `id_productos` int(10) DEFAULT NULL,
  `cantidad` int(3) DEFAULT NULL,
  `subtotal` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_factura`
--

CREATE TABLE `tbl_factura` (
  `id_factura` int(20) NOT NULL,
  `mesas` int(3) DEFAULT NULL,
  `cliente` varchar(30) DEFAULT NULL,
  `total` int(10) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_gastos`
--

CREATE TABLE `tbl_gastos` (
  `id_costos` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precio` int(11) NOT NULL,
  `fecha` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_mesa`
--

CREATE TABLE `tbl_mesa` (
  `id_mesas` int(3) NOT NULL,
  `total` int(10) DEFAULT NULL,
  `estado` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_productos`
--

CREATE TABLE `tbl_productos` (
  `id_productos` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `precio` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_productos`
--

INSERT INTO `tbl_productos` (`id_productos`, `id_categoria`, `nombre`, `precio`, `cantidad`) VALUES
(4, 1, 'pilsen', 1500, 50),
(6, 2, 'old park', 600000, 4),
(7, 3, 'garrafa tapa azul', 70000, 100),
(8, 1, 'aguila', 2000, 200),
(9, 1, 'aguila ligth', 2500, 300),
(10, 2, 'black and white', 70000, 100);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario`
--

CREATE TABLE `tbl_usuario` (
  `id_usuario` varchar(30) NOT NULL,
  `pass` varchar(100) NOT NULL,
  `pregunta` varchar(50) NOT NULL,
  `respuesta` varchar(50) NOT NULL,
  `tipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_usuario`
--

INSERT INTO `tbl_usuario` (`id_usuario`, `pass`, `pregunta`, `respuesta`, `tipo`) VALUES
('Admin', '123456', '2', 'ranger', 1),
('Administrador', '123456', 'Nombre del padre', 'jesus', 1),
('faither', 'jefer1226', 'Nombre de la madre', 'amparo', 2),
('subadmin', '123456', 'Nombre del padre', 'antonio', 1),
('will', 'wilder1991', 'Nombre de la madre', 'luz dary', 2);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_categoria`
--
ALTER TABLE `tbl_categoria`
  ADD PRIMARY KEY (`id_categoria`);

--
-- Indices de la tabla `tbl_dfactura`
--
ALTER TABLE `tbl_dfactura`
  ADD KEY `id_dfactura` (`id_dfactura`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `tbl_dmesas`
--
ALTER TABLE `tbl_dmesas`
  ADD PRIMARY KEY (`id_mesas`),
  ADD KEY `id_productos` (`id_productos`);

--
-- Indices de la tabla `tbl_factura`
--
ALTER TABLE `tbl_factura`
  ADD PRIMARY KEY (`id_factura`),
  ADD KEY `mesas` (`mesas`);

--
-- Indices de la tabla `tbl_gastos`
--
ALTER TABLE `tbl_gastos`
  ADD PRIMARY KEY (`id_costos`);

--
-- Indices de la tabla `tbl_mesa`
--
ALTER TABLE `tbl_mesa`
  ADD PRIMARY KEY (`id_mesas`);

--
-- Indices de la tabla `tbl_productos`
--
ALTER TABLE `tbl_productos`
  ADD PRIMARY KEY (`id_productos`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- Indices de la tabla `tbl_usuario`
--
ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_categoria`
--
ALTER TABLE `tbl_categoria`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tbl_gastos`
--
ALTER TABLE `tbl_gastos`
  MODIFY `id_costos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_productos`
--
ALTER TABLE `tbl_productos`
  MODIFY `id_productos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_dfactura`
--
ALTER TABLE `tbl_dfactura`
  ADD CONSTRAINT `tbl_dfactura_ibfk_1` FOREIGN KEY (`id_dfactura`) REFERENCES `tbl_factura` (`id_factura`),
  ADD CONSTRAINT `tbl_dfactura_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `tbl_dmesas` (`id_productos`);

--
-- Filtros para la tabla `tbl_dmesas`
--
ALTER TABLE `tbl_dmesas`
  ADD CONSTRAINT `tbl_dmesas_ibfk_1` FOREIGN KEY (`id_mesas`) REFERENCES `tbl_mesa` (`id_mesas`),
  ADD CONSTRAINT `tbl_dmesas_ibfk_2` FOREIGN KEY (`id_productos`) REFERENCES `tbl_productos` (`id_productos`);

--
-- Filtros para la tabla `tbl_factura`
--
ALTER TABLE `tbl_factura`
  ADD CONSTRAINT `tbl_factura_ibfk_1` FOREIGN KEY (`mesas`) REFERENCES `tbl_mesa` (`id_mesas`);

--
-- Filtros para la tabla `tbl_productos`
--
ALTER TABLE `tbl_productos`
  ADD CONSTRAINT `tbl_productos_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `tbl_categoria` (`id_categoria`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
