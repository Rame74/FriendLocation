/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('Bruce', 1, 1)
INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('Dave', 1, 2)
INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('Adrian', 1, 3)
INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('Steve', 1, 4)
INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('Nicko', 2, 1)
INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('Rob', 2, 2)
INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('Glen', 2, 3)
INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('KK', 3, 1)
INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('Scott', 3, 2)
INSERT INTO Friend (Name, Latitude, Longitude) VALUES ('Ian', 3, 3)

INSERT INTO WhosNear (FriendId_1_FK, FriendId_2_FK) VALUES (1, 2)
INSERT INTO WhosNear (FriendId_1_FK, FriendId_2_FK) VALUES (1, 3)
INSERT INTO WhosNear (FriendId_1_FK, FriendId_2_FK) VALUES (1, 4)
INSERT INTO WhosNear (FriendId_1_FK, FriendId_2_FK) VALUES (2, 1)
INSERT INTO WhosNear (FriendId_1_FK, FriendId_2_FK) VALUES (2, 3)
INSERT INTO WhosNear (FriendId_1_FK, FriendId_2_FK) VALUES (2, 4)
INSERT INTO WhosNear (FriendId_1_FK, FriendId_2_FK) VALUES (3, 4)
INSERT INTO WhosNear (FriendId_1_FK, FriendId_2_FK) VALUES (3, 5)
INSERT INTO WhosNear (FriendId_1_FK, FriendId_2_FK) VALUES (3, 6)