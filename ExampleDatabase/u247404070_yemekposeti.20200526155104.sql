-- MariaDB dump 10.17  Distrib 10.4.13-MariaDB, for Linux (x86_64)
--
-- Host: localhost    Database: u247404070_yemekposeti
-- ------------------------------------------------------
-- Server version	10.4.13-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Basket`
--

DROP TABLE IF EXISTS `Basket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Basket` (
  `basketID` int(11) NOT NULL AUTO_INCREMENT,
  `OrderID` int(11) NOT NULL,
  `FoodID` int(11) NOT NULL,
  `QTY` int(11) NOT NULL,
  `unitPrice` float NOT NULL,
  PRIMARY KEY (`basketID`),
  KEY `fk_basket_order` (`OrderID`),
  KEY `fk_basket_food` (`FoodID`),
  CONSTRAINT `fk_basket_food` FOREIGN KEY (`FoodID`) REFERENCES `Foods` (`FoodID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_basket_order` FOREIGN KEY (`OrderID`) REFERENCES `Orders` (`OrderID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=228 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Basket`
--

/*!40000 ALTER TABLE `Basket` DISABLE KEYS */;
INSERT INTO `Basket` VALUES (199,93,11,2,25),(201,94,11,1,25),(202,95,49,1,54),(203,95,46,1,40),(204,96,57,2,59),(205,96,55,3,25),(206,97,11,1,25),(207,97,13,1,3),(208,97,10,2,25),(209,98,44,1,12),(210,98,45,1,12),(211,99,45,1,12),(212,99,44,2,12),(213,100,50,2,54),(214,101,11,1,25),(215,101,13,1,3),(216,102,50,2,54),(217,102,48,1,19),(218,103,9,6,16),(219,103,13,6,3),(220,104,7,3,10),(221,105,18,1,7),(222,105,16,1,12),(223,105,17,1,15),(224,105,15,1,10),(225,106,18,2,7),(226,106,16,1,12),(227,107,58,1,24);
/*!40000 ALTER TABLE `Basket` ENABLE KEYS */;

--
-- Table structure for table `Comments`
--

DROP TABLE IF EXISTS `Comments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Comments` (
  `CommentID` int(11) NOT NULL AUTO_INCREMENT,
  `CommentText` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CommentRate` int(11) NOT NULL,
  `CommentDate` date NOT NULL,
  `OrderID` int(11) NOT NULL,
  PRIMARY KEY (`CommentID`),
  KEY `fk_comment_order` (`OrderID`),
  CONSTRAINT `fk_comment_order` FOREIGN KEY (`OrderID`) REFERENCES `Orders` (`OrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Comments`
--

/*!40000 ALTER TABLE `Comments` DISABLE KEYS */;
/*!40000 ALTER TABLE `Comments` ENABLE KEYS */;

--
-- Table structure for table `FoodCategories`
--

DROP TABLE IF EXISTS `FoodCategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `FoodCategories` (
  `FoodCategoryID` int(11) NOT NULL AUTO_INCREMENT,
  `FoodCategoryName` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`FoodCategoryID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `FoodCategories`
--

/*!40000 ALTER TABLE `FoodCategories` DISABLE KEYS */;
INSERT INTO `FoodCategories` VALUES (1,'Döner');
/*!40000 ALTER TABLE `FoodCategories` ENABLE KEYS */;

--
-- Table structure for table `Foods`
--

DROP TABLE IF EXISTS `Foods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Foods` (
  `FoodID` int(11) NOT NULL AUTO_INCREMENT,
  `FoodName` varchar(42) COLLATE utf8mb4_unicode_ci NOT NULL,
  `FoodPrice` float NOT NULL,
  `FoodDesc` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `FoodCategoryID` int(11) NOT NULL,
  `RestaurantID` int(11) NOT NULL,
  PRIMARY KEY (`FoodID`),
  KEY `fk_restaurant_id` (`RestaurantID`),
  KEY `fk_food_category` (`FoodCategoryID`),
  CONSTRAINT `fk_food_category` FOREIGN KEY (`FoodCategoryID`) REFERENCES `FoodCategories` (`FoodCategoryID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_restaurant_id` FOREIGN KEY (`RestaurantID`) REFERENCES `Restaurants` (`RestaurantID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Foods`
--

/*!40000 ALTER TABLE `Foods` DISABLE KEYS */;
INSERT INTO `Foods` VALUES (7,'Zurna Tavuk Döner Dürüm',10,'Patates kızartması, turşu, domates, marul, sos, mayonez',1,1),(9,'Zurna Et Döner Dürüm',16,'Patates kızartması, turşu, domates, marul, sos, mayonez',1,1),(10,'İskender (Et Döner)',25,'Pişmiş domates, pişmiş biber, ekstra lavaş ile',1,1),(11,'Pilav Üstü Et Döner',25,'Pişmiş biber, kızarmış lavaş, salata ile',1,1),(12,'SSK Dürüm',25,'Soslu et döner',1,17),(13,'Ayran (33cl)',3,'',1,1),(15,'Köpek Maması (1kg.)',10,'Ezilmiş biftek aromasıyla..',1,18),(16,'Köpek Öldüren',12,'Dikkat kangal çıkabilir!',1,18),(17,'Kavrulmuş Kangal Tatlısı',15,'Şerbetli, köpek maması aromalı...',1,18),(18,'Kemik Çorbası',7,'Müthiş kangal kemiği...',1,18),(20,'Kaşarlı Mantarlı Tavuklu Sandviç',10,'Kaşar, mantar, tavuk, sos, çıtır patates',1,19),(21,'Orta Boy Bol Malzemos Pizza',19.99,'Kaşar, mantar, sucuk, salam, sosis, zeytin, biber',1,7),(40,'Soslu Tavuk Dürüm',12.5,'Güzelliklerle dolu tavuk dürüm.',1,8),(41,'Ayran',2.5,'',1,8),(42,'Çakma Rakı',65.99,'',1,8),(44,'Muhlama',12,'Süper hopa usulu',1,16),(45,'Gürcü Hamsisi',12,'not:  değildir',1,16),(46,'2 Adet Orta Boy Bol Malzemos Pizza Fırsatı',40,'Cazip, özel ve bol malzeme pizzalar için geçerlidir.',1,7),(47,'2 Adet Dürümos Fırsatı',21.99,'Dilediğiniz 2 Adet Dürümos',1,7),(48,'Dürümos + Kutu İçecek',19.99,'Dilediğiniz 1 Adet Dürümos + Kutu İçecek (33cl.)',1,7),(49,'Classic Pizza (Orta)',54.99,'Özel pizza sosu ve mozzarella peyniri',1,7),(50,'Sucuksever Pizza (Orta)',54.99,'Pizza sosu, mozzarella peyniri, sucuk, sarımsak sos (Sarımsak sos için malzeme değişimi yapılmamaktadır.)',1,7),(51,'King Deluxe Coca-Cola Şekersiz Kampanyası',24.95,'Big King® + Tavuklu Barbekü Deluxe Burger + Büyük Boy Patates Kızartması + 2 Adet Coca-Cola Şekersiz(33cl.)',1,10),(52,'Kral İkili',29.9,'Big King® Sandviç + King Chicken® Sandviç + King Boy Patates + Litrelik İçecek 41,40 TL yerine 29,90 TL',1,10),(53,'Whopper® Menü',27.95,'Whopper® + Büyük Boy Patates + Orta Boy (Kutu) İçecek',1,10),(54,'Tavuklu Barbekü Deluxe Burger Menü',17.5,'Tavuklu Barbekü Deluxe Burger + Büyük Boy Patates + Orta Boy (Kutu) İçecek',1,10),(55,'Big King® Menü',25.5,'Big King® + Büyük Boy Patates + Orta Boy (Kutu) İçecek',1,10),(56,'Pro Gamer Big King®',25.9,'Big King® + Büyük Boy Patates + Soğan Halkaları (4 lü) + Litrelik İçecek',1,10),(57,'Yılbaşı Menüsü',59.95,'Whopper® Menü + Etli Barbekü Deluxe Burer Menü + King Chicken® Menü + Soğan Halkaları (12 li)',1,10),(58,'BK Kral Burger Menü',24.95,'BK Kral Burger + Whopper JR. + King Chicken +  Büyük Boy Patates + Orta Boy (Kutu) İçecek',1,10),(59,'Mangalda Izgara Tavuk Menü',27.95,'Mangalda Izgara Tavuk + Büyük Boy Patates + Orta Boy (Kutu) İçecek',1,10),(60,'Chicken Royale® Menü',24.5,'Chicken Royale® + Büyük Boy Patates + Orta Boy (Kutu) İçecek',1,10),(65,'Cola (1lt)',4,'buz gibi',1,7);
/*!40000 ALTER TABLE `Foods` ENABLE KEYS */;

--
-- Table structure for table `Locations`
--

DROP TABLE IF EXISTS `Locations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Locations` (
  `LocationID` int(11) NOT NULL AUTO_INCREMENT,
  `LocationName` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`LocationID`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Locations`
--

/*!40000 ALTER TABLE `Locations` DISABLE KEYS */;
INSERT INTO `Locations` VALUES (6,'ANKARA'),(8,'ARTVIN'),(34,'ISTANBUL'),(35,'IZMIR'),(58,'SIVAS');
/*!40000 ALTER TABLE `Locations` ENABLE KEYS */;

--
-- Table structure for table `OrderStatus`
--

DROP TABLE IF EXISTS `OrderStatus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `OrderStatus` (
  `StatusID` int(11) NOT NULL AUTO_INCREMENT,
  `Status` text COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`StatusID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `OrderStatus`
--

/*!40000 ALTER TABLE `OrderStatus` DISABLE KEYS */;
INSERT INTO `OrderStatus` VALUES (1,'Siparişiniz restorana ulaştı.'),(2,'Siparişiniz hazırlanıyor...'),(3,'Siparişiniz teslim edildi.'),(4,'Siparişiniz restoran tarafından iptal edildi.');
/*!40000 ALTER TABLE `OrderStatus` ENABLE KEYS */;

--
-- Table structure for table `Orders`
--

DROP TABLE IF EXISTS `Orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Orders` (
  `OrderID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` int(11) NOT NULL,
  `UniqueKey` int(11) NOT NULL,
  `RestaurantID` int(11) NOT NULL,
  `OrderDate` datetime NOT NULL,
  `StatusID` int(4) NOT NULL DEFAULT 0,
  `Adress` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `FinalPrice` double DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `fk_order_restaurant` (`RestaurantID`),
  KEY `fk_order_user` (`UserID`),
  KEY `fk_statusID_status` (`StatusID`),
  CONSTRAINT `fk_order_user` FOREIGN KEY (`UserID`) REFERENCES `Users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_statusID_status` FOREIGN KEY (`StatusID`) REFERENCES `OrderStatus` (`StatusID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=108 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Orders`
--

/*!40000 ALTER TABLE `Orders` DISABLE KEYS */;
INSERT INTO `Orders` VALUES (93,1,6881106,1,'2019-12-29 15:22:30',3,' daire: 50 bayraklı / folkart towers blok 1',56.05),(94,1,4962940,1,'2019-12-29 15:31:53',2,'turgutlu/manisa istasyonaltı mah.',28.02),(95,1,2814593,7,'2019-12-29 20:16:21',1,'aadgggnhmgmjjyöhöuöuöutçuuttuç',90.24),(96,1,4230263,10,'2019-12-30 12:51:02',1,'23145342324235252523533443',186.58),(97,1,7685886,1,'2019-12-30 12:53:00',2,'23145342324235252523533443',74.1),(98,4,2115604,16,'2019-12-30 13:08:30',3,'234232424242424',22.8),(99,4,4796561,16,'2019-12-30 13:17:40',3,'2131232134342424',34.2),(100,1,5498343,7,'2019-12-30 13:19:42',1,'tatatataaaa',104.48),(101,1,3476335,1,'2019-12-31 09:26:53',3,'5454545455546466',26.6),(102,12,5995416,7,'2019-12-31 09:29:31',3,'454545445545455',123.47),(103,1,30840,1,'2020-01-01 19:54:22',3,'dkadksddsdsdsds',108.3),(104,1,91463,1,'2020-01-11 22:29:16',4,'6007/6 sk.  no.12 daire 2 ',28.5),(105,6,3470400,18,'2020-03-11 13:29:37',4,'6606060600',41.8),(106,6,3395500,18,'2020-03-11 13:31:00',1,'6606060600',24.7),(107,11,8838928,10,'2020-05-16 14:24:20',3,'sultangazi istanbul\r\nuhud sk. no: 54 daire :4\r\n\r\nnot: iftarda gelsin',23.7);
/*!40000 ALTER TABLE `Orders` ENABLE KEYS */;

--
-- Table structure for table `ReportResponse`
--

DROP TABLE IF EXISTS `ReportResponse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ReportResponse` (
  `ReportID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `ResponseText` varchar(256) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ResponseDate` date NOT NULL,
  `ResponseID` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ResponseID`),
  KEY `fk_response_report` (`ReportID`),
  KEY `fk_response_user` (`UserID`),
  CONSTRAINT `fk_response_report` FOREIGN KEY (`ReportID`) REFERENCES `Reports` (`ReportID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_response_user` FOREIGN KEY (`UserID`) REFERENCES `Users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ReportResponse`
--

/*!40000 ALTER TABLE `ReportResponse` DISABLE KEYS */;
/*!40000 ALTER TABLE `ReportResponse` ENABLE KEYS */;

--
-- Table structure for table `Reports`
--

DROP TABLE IF EXISTS `Reports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Reports` (
  `ReportID` int(11) NOT NULL AUTO_INCREMENT,
  `OrderID` int(11) NOT NULL,
  `ReportText` varchar(256) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ReportDate` date NOT NULL,
  `ReportClosed` tinyint(1) NOT NULL,
  PRIMARY KEY (`ReportID`),
  KEY `fk_report_user` (`OrderID`),
  CONSTRAINT `fk_report_user` FOREIGN KEY (`OrderID`) REFERENCES `Orders` (`OrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Reports`
--

/*!40000 ALTER TABLE `Reports` DISABLE KEYS */;
/*!40000 ALTER TABLE `Reports` ENABLE KEYS */;

--
-- Table structure for table `Restaurants`
--

DROP TABLE IF EXISTS `Restaurants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Restaurants` (
  `RestaurantID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` int(11) NOT NULL,
  `RestaurantName` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `LocationID` int(11) NOT NULL,
  `RestaurantRating` float NOT NULL DEFAULT 5,
  `RestaurantDesc` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `MinOrderPrice` float NOT NULL DEFAULT 10,
  PRIMARY KEY (`RestaurantID`),
  KEY `fk_restaurant_location` (`LocationID`),
  KEY `fk_restaurant_user` (`UserID`),
  CONSTRAINT `fk_restaurant_location` FOREIGN KEY (`LocationID`) REFERENCES `Locations` (`LocationID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_restaurant_user` FOREIGN KEY (`UserID`) REFERENCES `Users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Restaurants`
--

/*!40000 ALTER TABLE `Restaurants` DISABLE KEYS */;
INSERT INTO `Restaurants` VALUES (1,1,'Dönes Döner',35,9.6,'Tavuk && Et Zurna Dürüm, İskender, Tatlı...',20),(3,10,'Kimyon Steak House && Cafe',35,7.2,'Etin ve kahvaltının gerçek adresi...',25),(4,-1,'Sercan Döner && Kebap && Lahmacun',35,2.1,'Lahmacun, adana-urfa kebap, et - tavuk döner, çorba...',15),(5,-1,'Hamsi Balık Evi, Karşıyaka',35,3.7,'Balık && Deniz Ürünleri',5),(6,-1,'Shebo\'s Handmade Sandwich && Burger',35,6.3,'El yapımı burger..',30),(7,9,'Domino s Pizza',35,7.6,'Avantajlı pizzalar!',9.99),(8,0,'TRB (Gıt Gıt) Döner',6,8.5,'Hatay usulu nefis zurna döner, iskender, kebap..',9.99),(10,11,'Burger King',35,7.3,'Tavuk && Et Hamburger, Avantajlı Menüler, Kampanyalar...',9.99),(16,4,'Emin Usta',8,9.99,'Meşhur artvin et döneri',9.99),(17,-1,'ASPAVA',6,4.5,'Allah sağlık para i. melih gökçek',10),(18,6,'Kangal Kafe  && Restaurant',58,7.58,'Muhteşem lezzetler sizi bekliyor...',9.99),(19,-1,'Breadly',58,8.5,'Soslarıyla meşhur sandviçler burada!',9.99);
/*!40000 ALTER TABLE `Restaurants` ENABLE KEYS */;

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Users` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `UserPassword` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `UserMail` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `UserType` tinyint(2) NOT NULL DEFAULT 0,
  `LocationID` int(11) NOT NULL DEFAULT 1,
  `UserRegisterDate` date NOT NULL DEFAULT current_timestamp(),
  `UserPicture` varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Users`
--

/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
INSERT INTO `Users` VALUES (-1,'yemekPoseti','a3dso9f4k84lmccu4858fvlvw^+%%+!','admin@yemekposeti.com',0,35,'0000-00-00',NULL),(0,'durumert','123','duru@duru.com',0,6,'2019-12-11',NULL),(1,'sercan','123','sercanbayrambeyy@gmail.com',1,35,'2019-12-11',NULL),(4,'baha','123','baha',0,8,'2019-12-12',NULL),(6,'eren','123','eren',1,58,'2019-12-19',NULL),(8,'test13','123','test',0,8,'2019-12-28',NULL),(9,'dominosizmir','123','dominos',0,35,'2019-12-28',NULL),(10,'kimyonizmir','123','kimyonizmir',0,35,'2019-12-29',NULL),(11,'burgerizmir','123','burger',0,35,'2019-12-29',NULL),(12,'fatih','123','323@g.com',0,35,'2019-12-31',NULL);
/*!40000 ALTER TABLE `Users` ENABLE KEYS */;

--
-- Temporary table structure for view `siparisleriGoster`
--

DROP TABLE IF EXISTS `siparisleriGoster`;
/*!50001 DROP VIEW IF EXISTS `siparisleriGoster`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `siparisleriGoster` (
  `OrderID` tinyint NOT NULL,
  `UserName` tinyint NOT NULL,
  `Adress` tinyint NOT NULL,
  `RestaurantID` tinyint NOT NULL,
  `UserID` tinyint NOT NULL,
  `OrderDate` tinyint NOT NULL,
  `FoodName` tinyint NOT NULL,
  `RestaurantName` tinyint NOT NULL,
  `StatusID` tinyint NOT NULL,
  `Status` tinyint NOT NULL,
  `LocationName` tinyint NOT NULL,
  `FinalPrice` tinyint NOT NULL,
  `QTY` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Dumping routines for database 'u247404070_yemekposeti'
--

--
-- Final view structure for view `siparisleriGoster`
--

/*!50001 DROP TABLE IF EXISTS `siparisleriGoster`*/;
/*!50001 DROP VIEW IF EXISTS `siparisleriGoster`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50001 VIEW `siparisleriGoster` AS select `O`.`OrderID` AS `OrderID`,`U`.`UserName` AS `UserName`,`O`.`Adress` AS `Adress`,`R`.`RestaurantID` AS `RestaurantID`,`O`.`UserID` AS `UserID`,`O`.`OrderDate` AS `OrderDate`,`F`.`FoodName` AS `FoodName`,`R`.`RestaurantName` AS `RestaurantName`,`O`.`StatusID` AS `StatusID`,`OS`.`Status` AS `Status`,`L`.`LocationName` AS `LocationName`,`O`.`FinalPrice` AS `FinalPrice`,`B`.`QTY` AS `QTY` from ((((((`Orders` `O` join `Basket` `B` on(`B`.`OrderID` = `O`.`OrderID`)) join `Restaurants` `R` on(`R`.`RestaurantID` = `O`.`RestaurantID`)) join `Foods` `F` on(`F`.`FoodID` = `B`.`FoodID`)) join `Locations` `L` on(`L`.`LocationID` = `R`.`LocationID`)) join `OrderStatus` `OS` on(`O`.`StatusID` = `OS`.`StatusID`)) join `Users` `U` on(`U`.`UserID` = `O`.`UserID`)) order by `O`.`OrderID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-26 15:51:04
