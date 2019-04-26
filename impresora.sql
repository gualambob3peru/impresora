-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-04-2019 a las 16:16:33
-- Versión del servidor: 10.1.38-MariaDB
-- Versión de PHP: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `impresora`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden`
--

CREATE TABLE `orden` (
  `codCentro` varchar(90) NOT NULL,
  `codRecurso` varchar(90) NOT NULL,
  `codOrden` varchar(90) NOT NULL,
  `codProducto` varchar(90) NOT NULL,
  `Producto` varchar(90) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `TipoPal` varchar(90) NOT NULL,
  `Fecha` date NOT NULL,
  `Duracion` int(11) NOT NULL,
  `CajXPal` int(11) NOT NULL,
  `Unidad` varchar(90) NOT NULL,
  `NumEtiqueta` varchar(90) NOT NULL,
  `UltEtiqueta` varchar(90) NOT NULL,
  `IPImpresora` varchar(90) NOT NULL,
  `CentroLote` varchar(90) NOT NULL,
  `RecursoLote` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `orden`
--

INSERT INTO `orden` (`codCentro`, `codRecurso`, `codOrden`, `codProducto`, `Producto`, `Cantidad`, `TipoPal`, `Fecha`, `Duracion`, `CajXPal`, `Unidad`, `NumEtiqueta`, `UltEtiqueta`, `IPImpresora`, `CentroLote`, `RecursoLote`) VALUES
('5040', '', '000040144289', '252433', 'INCA KOLA PET2500X6', 250, 'pallet', '2019-04-09', 20, 250, 'Caj', '0000001', '', '', 'R', '5');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `orden`
--
ALTER TABLE `orden`
  ADD PRIMARY KEY (`codOrden`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
