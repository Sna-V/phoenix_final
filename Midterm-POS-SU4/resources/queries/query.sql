-- 2024-06-29

--CREATE TABLE tblUser
--(
--id INT PRIMARY KEY IDENTITY(1, 1),
--userName VARCHAR(50) NOT NULL UNIQUE,
--gender VARCHAR(6) NOT NULL,
--password VARCHAR(50) NOT NULL,
--email VARCHAR(50) NOT NULL,
--status BIT NOT NULL,
--createAt DATETIME NOT NULL,
--createBy INT FOREIGN KEY REFERENCES tblUser(id) NOT NULL,
--updateAt DATETIME NULL,
--updateBy INT FOREIGN KEY REFERENCES tblUser(id) NULL
--);

ALTER TABLE tblUser ALTER COLUMN status BIT NOT NULL;
ALTER TABLE tblUser DROP CONSTRAINT FK_User_CreateBy;

INSERT INTO tblUser(userName, gender, password, email, status, createAt, createBy) VALUES('@admin', 'Male', '********','Administrator511@gmail.com', 0, GETDATE(),1);
SELECT * FROM tblUser;

SELECT * FROM tblUser;
SELECT * FROM tblRole;
SELECT * FROM tblUserRole;
INSERT INTO tblRole(name, status, createAt, createBy) VALUES('admin', 1, GETDATE(), 1);

ALTER TABLE tblRole DROP CONSTRAINT FK_Role_CreateBy;
UPDATE tblRole SET createBy = 3 WHERE createBy = 1;

INSERT INTO tblUserRole (userId, roleId, createAt, createBy) VALUES (3,3, GETDATE(), 3);
SELECT * FROM tblUserRole;
CREATE VIEW view_User AS
SELECT u.id AS userId, u.userName, u.gender, u.password, u.email, u.status, r.name AS roleName FROM tblUser AS u INNER JOIN tblUserRole AS ur ON u.id = ur.userId INNER JOIN tblRole r ON r.id = ur.roleId;
SELECT * FROM view_User;