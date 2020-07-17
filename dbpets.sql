/*
 Navicat Premium Data Transfer

 Source Server         : Laragon
 Source Server Type    : MySQL
 Source Server Version : 50724
 Source Host           : localhost:3306
 Source Schema         : dbpets

 Target Server Type    : MySQL
 Target Server Version : 50724
 File Encoding         : 65001

 Date: 16/07/2020 00:34:59
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for tblbreed
-- ----------------------------
DROP TABLE IF EXISTS `tblbreed`;
CREATE TABLE `tblbreed`  (
  `breedID` int(11) NOT NULL AUTO_INCREMENT,
  `breedname` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `typeID` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`breedID`) USING BTREE,
  INDEX `typeID`(`typeID`) USING BTREE,
  CONSTRAINT `tblbreed_ibfk_1` FOREIGN KEY (`typeID`) REFERENCES `tbltype` (`typeID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 16 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tblbreed
-- ----------------------------
INSERT INTO `tblbreed` VALUES (1, 'German Shepherd', 1);
INSERT INTO `tblbreed` VALUES (2, 'Bulldog', 1);
INSERT INTO `tblbreed` VALUES (3, 'Poodle', 1);
INSERT INTO `tblbreed` VALUES (4, 'Labrador Retriever', 1);
INSERT INTO `tblbreed` VALUES (5, 'Golden Retriever', 1);
INSERT INTO `tblbreed` VALUES (6, 'Beagle', 1);
INSERT INTO `tblbreed` VALUES (7, 'Dachshund', 1);
INSERT INTO `tblbreed` VALUES (8, 'Chihuahua', 1);
INSERT INTO `tblbreed` VALUES (9, 'French Bulldog', 1);
INSERT INTO `tblbreed` VALUES (10, 'Siberian Husky', 1);
INSERT INTO `tblbreed` VALUES (11, 'Persian Cat', 2);
INSERT INTO `tblbreed` VALUES (12, 'Bengal Cat', 2);
INSERT INTO `tblbreed` VALUES (13, 'Siamese Cat', 2);
INSERT INTO `tblbreed` VALUES (14, 'Maine Coon', 2);
INSERT INTO `tblbreed` VALUES (15, 'Sphynx Cat', 2);

-- ----------------------------
-- Table structure for tblowner
-- ----------------------------
DROP TABLE IF EXISTS `tblowner`;
CREATE TABLE `tblowner`  (
  `ownerID` int(11) NOT NULL AUTO_INCREMENT,
  `ownerName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `ownerAddress` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `ownerContactNumber` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ownerID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tblowner
-- ----------------------------
INSERT INTO `tblowner` VALUES (1, 'Caleb Randall', 'Sasa, Davao City', '2223344');
INSERT INTO `tblowner` VALUES (2, 'Catherine Smith', 'Sasa, Davao City', '2224455');

-- ----------------------------
-- Table structure for tblpet
-- ----------------------------
DROP TABLE IF EXISTS `tblpet`;
CREATE TABLE `tblpet`  (
  `petID` int(11) NOT NULL AUTO_INCREMENT,
  `ownerID` int(11) NULL DEFAULT NULL,
  `petName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `petBirthdate` date NULL DEFAULT NULL,
  `petGender` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `petStatus` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `petBreed` int(11) NULL DEFAULT NULL,
  `petNotes` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`petID`) USING BTREE,
  INDEX `ownerID`(`ownerID`) USING BTREE,
  INDEX `petBreed`(`petBreed`) USING BTREE,
  CONSTRAINT `tblpet_ibfk_1` FOREIGN KEY (`ownerID`) REFERENCES `tblowner` (`ownerID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `tblpet_ibfk_2` FOREIGN KEY (`petBreed`) REFERENCES `tblbreed` (`breedID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tblpet
-- ----------------------------
INSERT INTO `tblpet` VALUES (1, 1, 'Sky', '2019-01-05', 'Male', 'Active', 4, 'A healthy puppy.');
INSERT INTO `tblpet` VALUES (2, 2, 'Sam', '2017-01-05', 'Female', 'Active', 3, 'A healthy adult dog.');
INSERT INTO `tblpet` VALUES (3, 2, 'Seth', '2018-06-28', 'Male', 'Active', 13, 'A healthy cat.');

-- ----------------------------
-- Table structure for tbltype
-- ----------------------------
DROP TABLE IF EXISTS `tbltype`;
CREATE TABLE `tbltype`  (
  `typeID` int(11) NOT NULL AUTO_INCREMENT,
  `typeName` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`typeID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tbltype
-- ----------------------------
INSERT INTO `tbltype` VALUES (1, 'Dog');
INSERT INTO `tbltype` VALUES (2, 'Cat');

SET FOREIGN_KEY_CHECKS = 1;
