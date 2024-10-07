INSERT INTO tblRole (name, status, createAt, createBy) 
VALUES
('admin', 1, GETDATE(), 1),
('user', 1, GETDATE(), 1);
SELECT * FROM tblRole;

INSERT INTO tblUser (userName, gender, password, email, status, createAt, createBy)
VALUES 
('Admin', 'Male', '123', 'admin@gmail.com', 1, GETDATE(), 1),
('User', 'Male', '123', 'user@gmail.com', 1, GETDATE(), 1);
SELECT * FROM tblUser;

INSERT INTO tblUserRole (userId, roleId, createAt, createBy)
VALUES 
(1, 1, GETDATE(), 1),
(1, 2, GETDATE(), 1);
SELECT * FROM tblUserRole;

UPDATE tblUserRole SET createBy = 1 WHERE createBy = 3;
UPDATE tblUser SET userName = 'Simple User', gender = 'Female', password = '123', email = 'simpleuser@gmail.com' WHERE id = 3;
 
SELECT * FROM tblRole;
SELECT * FROM tblUser;
SELECT * FROM tblUserRole;