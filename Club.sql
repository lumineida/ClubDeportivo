/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Tabla 'cliente'
--

DROP TABLE IF EXISTS `cliente`;

/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;

CREATE TABLE `cliente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) DEFAULT NULL,
  `apellido` varchar(20) DEFAULT NULL,
  `tipo_doc` varchar(10) DEFAULT NULL,
  `nro_doc` varchar(20) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `socio` tinyint(1) DEFAULT '0',
  `ficha_med` tinyint(1) DEFAULT '0',
  `fecha_ingreso` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
--
--
LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'ffg','gfsdgf','DNI',5345435,'353453','grgerg',0,0,NULL),
(2,'aaa','sss','DNI',222,'333','www',0,0,NULL),
(3,'ce','fo','Pasaporte',30,'11','aa 33',0,0,'2024-10-07 19:58:37'),
(4,'ce','fo','Extranjero',301,'22','222',0,0,'2024-10-07 19:59:41'),
(5,'eee','rrr','DNI',333333,'4444444','eee 444',0,0,'2024-10-08 19:45:08'),
(6,'11','11','DNI',11,'11','11',1,0,'2024-10-08 19:49:23'),
(7,'112','112','DNI',112,'112','112',0,0,'2024-10-08 19:49:40'),
(8,'aaa','ssss','DNI',11222,'11111','111',1,0,'2024-10-08 20:32:47'),
(9,'aads','fgsdfg','DNI',65465,'654645','teytyt',0,0,'2024-10-08 20:35:19'),
(10,'hdhgfdhgf','gfhdfg','DNI',6554645,'54645','ghdfhf',1,0,'2024-10-08 20:39:46'),
(11,'fhgh','hgfdhf','Pasaporte',54545,'5454','gsggf',0,0,'2024-10-08 20:44:34'),
(12,'hgfdh','hghd','DNI',56654,'546','ytyh',1,0,'2024-10-08 20:45:13'),
(13,'hgfdh','hghd','DNI',56644,'546','ytyh',1,0,'2024-10-08 20:45:33'),
(14,'ytrytyr','ytrye','DNI',654645,'654654','hdhg',1,0,'2024-10-08 20:47:18'),
(15,'ggt','tgrr','DNI',55454,'5453','gfhgfdh',1,0,'2024-10-08 20:48:26'),
(16,'kkjuk','khjk','DNI',8989,'877','jhkut',1,0,'2024-10-08 20:49:48'),
(17,'ytuyt','uytru','DNI',8767,'65765','hhgh',1,0,'2024-10-08 20:50:55');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

select * from cliente;

--
-- Tabla 'usuario'
--

DROP TABLE IF EXISTS `usuario`;

/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;

CREATE TABLE `usuario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) DEFAULT NULL,
  `contrasena` varchar(15) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
--
--
LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'admin','admin',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
--
/*!50003 DROP PROCEDURE IF EXISTS `IngresoLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;

DELIMITER ;;

-- 1) Iniciar sesión

CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin`(in Usu varchar(20),in Pass varchar(15))
begin
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  select *
	from usuario
		where nombre = Usu and contrasena = Pass /* se compara con los parametros */
			and activo = 1; /* el usuario debe estar activo */


end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `NuevoCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;

DELIMITER ;;

-- 2) Ingresar nuevo cliente

CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoCliente`(in Nom varchar(30),in Ape varchar(40), in TipoDoc varchar(10), in NroDoc varchar(20), in Tel varchar(40), in Dir varchar(40), in Soc tinyint(1), in FichaMed tinyint(1), out rta tinyint(1))
begin
	 declare existe int default 0;
	 set existe = (select count(*) from cliente where nro_doc = NroDoc);
	 
	  if existe = 0 then	 
		 insert into cliente  (`nombre`, `apellido`, `tipo_doc`, `nro_doc`, `telefono`, `direccion`, `socio`,`ficha_med`)  values(Nom,Ape,TipoDoc,NroDoc,Tel,Dir,Soc,FichaMed);
      end if;		 
    
    set rta = existe;
     end$$
  
  
DELIMITER ;

/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
