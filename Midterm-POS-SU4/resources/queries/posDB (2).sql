DROP DATABASE IF EXISTS posDB;
-- Create Database
CREATE DATABASE posDB;
GO

-- Use the new Database
USE posDB;
GO

-- Create Tables
CREATE TABLE tblUser
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    userName VARCHAR(50) NOT NULL UNIQUE,
    gender VARCHAR(6) NOT NULL,
    password VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    status BIT,
    createAt DATETIME NOT NULL,
    createBy INT NOT NULL,
    updateAt DATETIME NULL,
    updateBy INT NULL
);
GO

CREATE TABLE tblRole
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    name VARCHAR(50) NOT NULL UNIQUE,
    status BIT NOT NULL,
    createAt DATETIME NOT NULL,
    createBy INT NOT NULL,
    updateAt DATETIME NULL,
    updateBy INT NULL
);
GO

CREATE TABLE tblUserRole
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    userId INT NOT NULL,
    roleId INT NOT NULL,
    createAt DATETIME NOT NULL,
    createBy INT NOT NULL,
    updateAt DATETIME NULL,
    updateBy INT NULL
);
GO

CREATE TABLE tblCategory
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    categoryName VARCHAR(50) NOT NULL UNIQUE,
    status BIT NOT NULL,
    createAt DATETIME NOT NULL,
    createBy INT NOT NULL,
    updateAt DATETIME NULL,
    updateBy INT NULL
);
GO

CREATE TABLE tblProduct 
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    productName VARCHAR(50) NOT NULL UNIQUE,
    barcode BIGINT NOT NULL UNIQUE,
    sellPrice DECIMAL(8, 2) NOT NULL,
    qtyInStock INT NULL,
    photo VARCHAR(255) NULL,
    categoryId INT NOT NULL,
    createAt DATETIME NOT NULL,
    createBy INT NULL,
    updateAt DATETIME NULL,
    updateBy INT NULL
);
GO

CREATE TABLE tblSupplier
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    name VARCHAR(50) NOT NULL UNIQUE,
    tel VARCHAR(20) NOT NULL,
    address VARCHAR(50) NOT NULL,
    createAt DATETIME NOT NULL,
    createBy INT NOT NULL,
    updateAt DATETIME NULL,
    updateBy INT NULL
);
GO

CREATE TABLE tblAddStock 
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    supplierId INT NOT NULL,
    productId INT NOT NULL,
    qty INT NOT NULL,
    cost DECIMAL(8, 2) NOT NULL,
    total DECIMAL(8, 2) NOT NULL,
    createAt DATETIME NOT NULL,
    createBy INT NOT NULL,
    updateAt DATETIME NULL,
    updateBy INT NULL
);
GO

CREATE TABLE tblSale
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    customerId INT NULL,
    saleDate DATETIME NOT NULL,
    userId INT NOT NULL,
    totalAmount DECIMAL(8, 2) NOT NULL
);
GO

CREATE TABLE tblSaleDetail
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    saleId INT NOT NULL,
    productId INT NOT NULL,
    qty INT NOT NULL,
    price DECIMAL(8, 2) NOT NULL,
    total DECIMAL(8, 2) NOT NULL
);
GO

CREATE TABLE tblCustomer
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    name VARCHAR(50) NOT NULL,
    gender VARCHAR(6) NOT NULL,
    tel INT NOT NULL,
    address VARCHAR(50) NOT NULL,
    createAt DATETIME NOT NULL,
    createBy INT NOT NULL,
    updateAt DATETIME NULL,
    updateBy INT NULL
);
GO
INSERT INTO tblUser VALUES 
('Admin', 'male', '123', 'admin@gmail.com', 1, GETDATE(), 1, NULL, NULL),
('User', 'female', '123', 'user@gmail.com', 1, GETDATE(), 1, NULL, NULL);
GO
INSERT INTO tblRole VALUES 
('admin', 1, GETDATE(), 1, NULL, NULL),
('user', 1, GETDATE(), 1, NULL, NULL);
GO
INSERT INTO tblUserRole VALUES
(1, 1, GETDATE(), 1, NULL, NULL),
(2, 2, GETDATE(), 1, NULL, NULL);
GO

-- Add Foreign Key Constraints
--ALTER TABLE tblUser
--ADD CONSTRAINT FK_User_CreateBy FOREIGN KEY (createBy) REFERENCES tblUser(id),
--    CONSTRAINT FK_User_UpdateBy FOREIGN KEY (updateBy) REFERENCES tblUser(id);
--GO

--ALTER TABLE tblRole
--ADD CONSTRAINT FK_Role_CreateBy FOREIGN KEY (createBy) REFERENCES tblUser(id),
--    CONSTRAINT FK_Role_UpdateBy FOREIGN KEY (updateBy) REFERENCES tblUser(id);
--GO

--ALTER TABLE tblUserRole
--ADD CONSTRAINT FK_UserRole_UserId FOREIGN KEY (userId) REFERENCES tblUser(id),
--    CONSTRAINT FK_UserRole_RoleId FOREIGN KEY (roleId) REFERENCES tblRole(id),
--    CONSTRAINT FK_UserRole_CreateBy FOREIGN KEY (createBy) REFERENCES tblUser(id),
--    CONSTRAINT FK_UserRole_UpdateBy FOREIGN KEY (updateBy) REFERENCES tblUser(id);
--GO

--ALTER TABLE tblCategory
--ADD CONSTRAINT FK_Category_CreateBy FOREIGN KEY (createBy) REFERENCES tblUser(id),
--    CONSTRAINT FK_Category_UpdateBy FOREIGN KEY (updateBy) REFERENCES tblUser(id);
--GO

--ALTER TABLE tblProduct
--ADD CONSTRAINT FK_Product_CategoryId FOREIGN KEY (categoryId) REFERENCES tblCategory(id),
--    CONSTRAINT FK_Product_CreateBy FOREIGN KEY (createBy) REFERENCES tblUser(id),
--    CONSTRAINT FK_Product_UpdateBy FOREIGN KEY (updateBy) REFERENCES tblUser(id);
--GO

--ALTER TABLE tblSupplier
--ADD CONSTRAINT FK_Supplier_CreateBy FOREIGN KEY (createBy) REFERENCES tblUser(id),
--    CONSTRAINT FK_Supplier_UpdateBy FOREIGN KEY (updateBy) REFERENCES tblUser(id);
--GO

--ALTER TABLE tblAddStock
--ADD CONSTRAINT FK_AddStock_SupplierId FOREIGN KEY (supplierId) REFERENCES tblSupplier(id),
--    CONSTRAINT FK_AddStock_ProductId FOREIGN KEY (productId) REFERENCES tblProduct(id),
--    CONSTRAINT FK_AddStock_CreateBy FOREIGN KEY (createBy) REFERENCES tblUser(id),
--    CONSTRAINT FK_AddStock_UpdateBy FOREIGN KEY (updateBy) REFERENCES tblUser(id);
--GO

--ALTER TABLE tblSale
--ADD CONSTRAINT FK_Sale_CustomerId FOREIGN KEY (customerId) REFERENCES tblCustomer(id),
--    CONSTRAINT FK_Sale_UserId FOREIGN KEY (userId) REFERENCES tblUser(id);
--GO

--ALTER TABLE tblSaleDetail
--ADD CONSTRAINT FK_SaleDetail_SaleId FOREIGN KEY (saleId) REFERENCES tblSale(id),
--    CONSTRAINT FK_SaleDetail_ProductId FOREIGN KEY (productId) REFERENCES tblProduct(id);
--GO

--ALTER TABLE tblCustomer
--ADD CONSTRAINT FK_Customer_CreateBy FOREIGN KEY (createBy) REFERENCES tblUser(id),
--    CONSTRAINT FK_Customer_UpdateBy FOREIGN KEY (updateBy) REFERENCES tblUser(id);
--GO
