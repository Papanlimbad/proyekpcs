/*
SQLyog Community v13.1.9 (64 bit)
MySQL - 10.4.21-MariaDB : Database - bukutachi_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`bukutachi_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `bukutachi_db`;

/*Table structure for table `buku` */

DROP TABLE IF EXISTS `buku`;

CREATE TABLE `buku` (
  `bu_id` int(11) NOT NULL AUTO_INCREMENT,
  `bu_title` varchar(100) NOT NULL,
  `bu_synopsis` varchar(2000) NOT NULL,
  `bu_publish` date NOT NULL,
  `bu_type` int(11) NOT NULL,
  `bu_status` int(11) NOT NULL DEFAULT 1,
  `bu_pt_id` int(11) NOT NULL,
  `bu_rb_id` int(11) NOT NULL,
  PRIMARY KEY (`bu_id`),
  KEY `bu_rb_id` (`bu_rb_id`),
  KEY `bu_pt_id` (`bu_pt_id`),
  CONSTRAINT `buku_ibfk_2` FOREIGN KEY (`bu_rb_id`) REFERENCES `rak_buku` (`rb_id`),
  CONSTRAINT `buku_ibfk_3` FOREIGN KEY (`bu_pt_id`) REFERENCES `penerbit` (`pt_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `buku` */

/*Table structure for table `buku_penulis` */

DROP TABLE IF EXISTS `buku_penulis`;

CREATE TABLE `buku_penulis` (
  `bp_id` int(11) NOT NULL AUTO_INCREMENT,
  `bp_bu_id` int(11) NOT NULL,
  `bp_ps_id` int(11) NOT NULL,
  PRIMARY KEY (`bp_id`),
  KEY `bp_bu_id` (`bp_bu_id`),
  KEY `bp_ps_id` (`bp_ps_id`),
  CONSTRAINT `buku_penulis_ibfk_1` FOREIGN KEY (`bp_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `buku_penulis_ibfk_2` FOREIGN KEY (`bp_ps_id`) REFERENCES `penulis` (`ps_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `buku_penulis` */

/*Table structure for table `denda` */

DROP TABLE IF EXISTS `denda`;

CREATE TABLE `denda` (
  `de_id` int(11) NOT NULL AUTO_INCREMENT,
  `de_nama` varchar(100) NOT NULL,
  `de_harga` double NOT NULL,
  PRIMARY KEY (`de_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `denda` */

/*Table structure for table `detaildenda` */

DROP TABLE IF EXISTS `detaildenda`;

CREATE TABLE `detaildenda` (
  `dd_id` int(11) NOT NULL AUTO_INCREMENT,
  `dd_hp_id` int(11) NOT NULL,
  `dd_de_id` int(11) NOT NULL,
  PRIMARY KEY (`dd_id`),
  KEY `dd_hp_id` (`dd_hp_id`),
  KEY `dd_de_id` (`dd_de_id`),
  CONSTRAINT `detaildenda_ibfk_1` FOREIGN KEY (`dd_hp_id`) REFERENCES `hpinjam` (`hp_id`),
  CONSTRAINT `detaildenda_ibfk_2` FOREIGN KEY (`dd_de_id`) REFERENCES `denda` (`de_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `detaildenda` */

/*Table structure for table `dpinjam` */

DROP TABLE IF EXISTS `dpinjam`;

CREATE TABLE `dpinjam` (
  `dp_id` int(11) NOT NULL AUTO_INCREMENT,
  `dp_bu_id` int(11) NOT NULL,
  `dp_hp_id` int(11) NOT NULL,
  PRIMARY KEY (`dp_id`),
  KEY `dp_bu_id` (`dp_bu_id`),
  KEY `dp_hp_id` (`dp_hp_id`),
  CONSTRAINT `dpinjam_ibfk_1` FOREIGN KEY (`dp_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `dpinjam_ibfk_2` FOREIGN KEY (`dp_hp_id`) REFERENCES `hpinjam` (`hp_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `dpinjam` */

/*Table structure for table `genre` */

DROP TABLE IF EXISTS `genre`;

CREATE TABLE `genre` (
  `ge_id` int(11) NOT NULL AUTO_INCREMENT,
  `ge_name` varchar(50) NOT NULL,
  PRIMARY KEY (`ge_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `genre` */

/*Table structure for table `genre_buku` */

DROP TABLE IF EXISTS `genre_buku`;

CREATE TABLE `genre_buku` (
  `gb_id` int(11) NOT NULL AUTO_INCREMENT,
  `gb_bu_id` int(11) NOT NULL,
  `gb_ge_id` int(11) NOT NULL,
  PRIMARY KEY (`gb_id`),
  KEY `gb_bu_id` (`gb_bu_id`),
  KEY `gb_ge_id` (`gb_ge_id`),
  CONSTRAINT `genre_buku_ibfk_1` FOREIGN KEY (`gb_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `genre_buku_ibfk_2` FOREIGN KEY (`gb_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `genre_buku_ibfk_3` FOREIGN KEY (`gb_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `genre_buku_ibfk_4` FOREIGN KEY (`gb_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `genre_buku_ibfk_5` FOREIGN KEY (`gb_ge_id`) REFERENCES `genre` (`ge_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `genre_buku` */

/*Table structure for table `hpinjam` */

DROP TABLE IF EXISTS `hpinjam`;

CREATE TABLE `hpinjam` (
  `hp_id` int(11) NOT NULL AUTO_INCREMENT,
  `hp_borrowedat` date NOT NULL DEFAULT current_timestamp(),
  `hp_returnat` date NOT NULL,
  `hp_status` int(11) NOT NULL,
  `hp_me_id` int(11) NOT NULL,
  `hp_pe_id` int(11) NOT NULL,
  PRIMARY KEY (`hp_id`),
  KEY `hp_me_id` (`hp_me_id`),
  KEY `hp_pe_id` (`hp_pe_id`),
  CONSTRAINT `hpinjam_ibfk_1` FOREIGN KEY (`hp_me_id`) REFERENCES `member` (`me_id`),
  CONSTRAINT `hpinjam_ibfk_2` FOREIGN KEY (`hp_pe_id`) REFERENCES `pegawai` (`pe_id`),
  CONSTRAINT `hpinjam_ibfk_3` FOREIGN KEY (`hp_me_id`) REFERENCES `member` (`me_id`),
  CONSTRAINT `hpinjam_ibfk_4` FOREIGN KEY (`hp_pe_id`) REFERENCES `pegawai` (`pe_id`),
  CONSTRAINT `hpinjam_ibfk_5` FOREIGN KEY (`hp_me_id`) REFERENCES `member` (`me_id`),
  CONSTRAINT `hpinjam_ibfk_6` FOREIGN KEY (`hp_pe_id`) REFERENCES `pegawai` (`pe_id`),
  CONSTRAINT `hpinjam_ibfk_7` FOREIGN KEY (`hp_me_id`) REFERENCES `member` (`me_id`),
  CONSTRAINT `hpinjam_ibfk_8` FOREIGN KEY (`hp_pe_id`) REFERENCES `pegawai` (`pe_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `hpinjam` */

/*Table structure for table `member` */

DROP TABLE IF EXISTS `member`;

CREATE TABLE `member` (
  `me_id` int(11) NOT NULL AUTO_INCREMENT,
  `me_name` varchar(100) NOT NULL,
  `me_username` varchar(20) NOT NULL,
  `me_password` varchar(256) NOT NULL,
  `me_telephone` varchar(20) NOT NULL,
  `me_address` varchar(100) NOT NULL,
  `me_registeredat` date NOT NULL,
  `me_status` int(11) NOT NULL,
  PRIMARY KEY (`me_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `member` */

/*Table structure for table `pegawai` */

DROP TABLE IF EXISTS `pegawai`;

CREATE TABLE `pegawai` (
  `pe_id` int(11) NOT NULL AUTO_INCREMENT,
  `pe_name` varchar(100) NOT NULL,
  `pe_username` varchar(20) NOT NULL,
  `pe_password` varchar(256) NOT NULL,
  `pe_position` varchar(50) NOT NULL,
  `pe_address` varchar(100) NOT NULL,
  `pe_telephone` varchar(20) NOT NULL,
  `pe_registeredat` date NOT NULL,
  `pe_status` int(11) NOT NULL,
  PRIMARY KEY (`pe_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `pegawai` */

insert  into `pegawai`(`pe_id`,`pe_name`,`pe_username`,`pe_password`,`pe_position`,`pe_address`,`pe_telephone`,`pe_registeredat`,`pe_status`) values 
(1,'Kenny','kosmasu','kosmasu','admin','jl. bambang no 1','081123456789','2022-05-06',1);

/*Table structure for table `penerbit` */

DROP TABLE IF EXISTS `penerbit`;

CREATE TABLE `penerbit` (
  `pt_id` int(11) NOT NULL AUTO_INCREMENT,
  `pt_name` varchar(100) NOT NULL,
  `pt_address` varchar(100) NOT NULL,
  `pt_telephone` varchar(20) NOT NULL,
  PRIMARY KEY (`pt_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `penerbit` */

/*Table structure for table `penulis` */

DROP TABLE IF EXISTS `penulis`;

CREATE TABLE `penulis` (
  `ps_id` int(11) NOT NULL AUTO_INCREMENT,
  `ps_name` varchar(100) NOT NULL,
  `ps_telephone` varchar(20) NOT NULL,
  PRIMARY KEY (`ps_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `penulis` */

/*Table structure for table `rak_buku` */

DROP TABLE IF EXISTS `rak_buku`;

CREATE TABLE `rak_buku` (
  `rb_id` int(11) NOT NULL AUTO_INCREMENT,
  `rb_height` int(11) NOT NULL,
  PRIMARY KEY (`rb_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `rak_buku` */

/*Table structure for table `rating` */

DROP TABLE IF EXISTS `rating`;

CREATE TABLE `rating` (
  `ra_id` int(11) NOT NULL AUTO_INCREMENT,
  `ra_value` int(11) NOT NULL,
  `ra_bu_id` int(11) NOT NULL,
  `ra_me_id` int(11) NOT NULL,
  PRIMARY KEY (`ra_id`),
  KEY `ra_bu_id` (`ra_bu_id`),
  KEY `ra_me_id` (`ra_me_id`),
  CONSTRAINT `rating_ibfk_1` FOREIGN KEY (`ra_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `rating_ibfk_2` FOREIGN KEY (`ra_me_id`) REFERENCES `member` (`me_id`),
  CONSTRAINT `rating_ibfk_3` FOREIGN KEY (`ra_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `rating_ibfk_4` FOREIGN KEY (`ra_me_id`) REFERENCES `member` (`me_id`),
  CONSTRAINT `rating_ibfk_5` FOREIGN KEY (`ra_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `rating_ibfk_6` FOREIGN KEY (`ra_me_id`) REFERENCES `member` (`me_id`),
  CONSTRAINT `rating_ibfk_7` FOREIGN KEY (`ra_bu_id`) REFERENCES `buku` (`bu_id`),
  CONSTRAINT `rating_ibfk_8` FOREIGN KEY (`ra_me_id`) REFERENCES `member` (`me_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `rating` */

/*Table structure for table `supplier` */

DROP TABLE IF EXISTS `supplier`;

CREATE TABLE `supplier` (
  `sp_id` int(11) NOT NULL AUTO_INCREMENT,
  `sp_name` varchar(100) NOT NULL,
  `sp_address` varchar(100) NOT NULL,
  `sp_telephone` varchar(20) NOT NULL,
  PRIMARY KEY (`sp_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `supplier` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
