using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class QueryOperations
    {
        private readonly string _connectionString;
        DapperSqlExecutor _executor = new DapperSqlExecutor();
        public QueryOperations(string connectionString)
        {
            _connectionString = connectionString;
        }
        #region Login Query Operations
        public bool IsValidUserInfo(string userNameOrEmail, string password)
        {
            string query = "SELECT COUNT(1) FROM tblUser WHERE (userName = @UserName OR email = @Email) AND password = @Password";
            try
            {
                int count = _executor.ExecuteScalar<int, dynamic>(query, new { UserName = userNameOrEmail, Email = userNameOrEmail, Password = password }, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public UserModel IsUserEnabled(string userNameOrEmail, string password)
        {
            UserModel user = new UserModel();
            string query = "SELECT status AS Status FROM tblUser WHERE (userName = @UserName OR email = @Email) AND password = @Password";
            user.Status = _executor.Query<string, dynamic>(query, new { UserName = userNameOrEmail, Email = userNameOrEmail, Password = password }, _connectionString).First();
            if (user.Status == "False")
            {
                return user;
            }
            query = "SELECT id AS UserId FROM tblUser WHERE (userName = @UserName OR email = @Email) AND password = @Password AND status = 1";
            user.UserId = _executor.Query<int, dynamic>(query, new { UserName = userNameOrEmail, Email = userNameOrEmail, Password = password }, _connectionString).First();
            query = "SELECT userName AS UserName FROM tblUser WHERE (userName = @UserName OR email = @Email) AND password = @Password AND status = 1";
            user.UserName = _executor.Query<string, dynamic>(query, new { UserName = userNameOrEmail, Email = userNameOrEmail, Password = password }, _connectionString).First();
            return user;
        }
        public bool IsAdmin(string userNameOrEmail, string password)
        {
            string query = @"SELECT COUNT(1) AS IsAdmin FROM tblUser u 
                            INNER JOIN tblUserRole ur ON u.id = ur.userId
                            INNER JOIN tblRole r ON r.id = ur.roleId
                            WHERE (userName = @UserName OR email = @Email) AND password = @Password AND u.status = 1 AND r.id = (SELECT MIN(id) FROM tblRole);";
            try
            {
                int count = _executor.ExecuteScalar<int, dynamic>(query, new { UserName = userNameOrEmail, Email = userNameOrEmail, Password = password }, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region User Query Operations
        public List<UserModel> FetchUserData(string searchTerm)
        {
            string query = @"WITH cteStatus AS
                            (
                                SELECT 0 AS StatusId,
                                'False' AS Status
                                UNION ALL
                                SELECT 1 AS StatusId,
                                'True' AS Status
                            )
                            SELECT 
                                u.id AS UserId,
                                u.userName AS UserName,
                                u.gender AS Gender,
                                u.password AS Password,
                                u.email AS Email,
                                r.name AS Role,
                                s.Status,
                                u.createAt AS CreateAt,
                                c.userName AS CreateBy,
                                u.updateAt AS UpdateAt,
                                d.userName AS UpdateBy
                            FROM tblUser u
                            INNER JOIN tblUserRole ur ON u.id = ur.userId
                            INNER JOIN tblRole r ON ur.roleId = r.id
                            INNER JOIN tblUser c ON u.createBy = c.id
                            LEFT JOIN tblUser d ON u.updateBy = d.id
                            INNER JOIN cteStatus s ON u.status = s.StatusId
                            WHERE u.userName LIKE @SearchTerm OR u.gender LIKE @SearchTerm
                            OR u.password LIKE @SearchTerm OR u.email LIKE @SearchTerm
                            OR r.name LIKE @SearchTerm OR s.Status LIKE @SearchTerm
                            OR c.userName LIKE @searchTerm;";
            return _executor.Query<UserModel, dynamic>(query, new { SearchTerm = "%" + searchTerm + "%" }, _connectionString);
        }
        public bool CheckIfUserNameExists(string userName)
        {
            string query = "SELECT COUNT(1) AS IsUserNameExist FROM tblUser WHERE userName = @UserName;";
            try
            {
                int count = _executor.ExecuteScalar<int, dynamic>(query, new { UserName = userName }, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertUser(string userName, string password, string email, string gender, string role, int status, int createBy)
        {
            try
            {
                string query = @"BEGIN TRY
                                    BEGIN TRANSACTION
                                        DECLARE @RoleId INT;
                                        SELECT @RoleId = id FROM tblRole WHERE name = @Role;
                                        INSERT INTO tblUser (userName, password, email, gender, status, createAt, createBy, updateAt, updateBy)
                                        VALUES (@UserName, @Password, @Email, @Gender, @Status, GETDATE(), @CreateBy, NULL, NULL);
                                        DECLARE @UserId INT = SCOPE_IDENTITY();
                                        INSERT INTO tblUserRole (userId, roleId, createAt, createBy, updateAt, updateBy)
                                        VALUES (@UserId, @RoleId, GETDATE(), @CreateBy, NULL, NULL);
                                    COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH;";
                _executor.Execute<dynamic>(query, new { UserName = userName, Password = password, Email = email, Gender = gender, Role = role, Status = status, CreateBy = createBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateUser(int userId, string userName, string password, string email, string gender, string role, int status, int updateBy)
        {
            try
            {
                string query = @"BEGIN TRY
                                    BEGIN TRANSACTION
                                        DECLARE @RoleId INT;
                                        UPDATE tblUser SET
                                            userName = @UserName,
                                            password = @Password,
                                            email = @Email,
                                            gender = @Gender,
                                            status = @Status,
                                            updateAt = GETDATE(),
                                            updateBy = @UpdateBy
                                        WHERE id = @UserId;
                                        SELECT @RoleId = id FROM tblRole WHERE name = @Role;
                                        UPDATE tblUserRole SET
                                            roleId = @RoleId
                                        WHERE userId = @UserId;
                                        COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                        ROLLBACK TRANSACTION;
                                        THROW;
                                END CATCH";
                _executor.Execute<dynamic>(query, new {UserId = userId, UserName = userName, Password = password, Email = email, Gender = gender, Role = role, Status = status, UpdateBy = updateBy}, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void DeleteUser(int userId)
        {
            string query = @"BEGIN TRY
                                BEGIN TRANSACTION
                                    DELETE FROM tblUser WHERE id = @UserId
                                COMMIT TRANSACTION
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION;
                                THROW;
                            END CATCH;";
            _executor.Execute<dynamic>(query, new { UserId = userId }, _connectionString);
        }
        #endregion
        #region Role Query Operations
        public List<RoleModel> FetchRoleData()
        {
            string query = @"WITH cteStatus AS
                    (
                        SELECT 0 AS StatusId,
                        'False' AS Status
                        UNION ALL
                        SELECT 1 AS StatusId,
                        'True' AS Status
                    )
                    SELECT r.id AS RoleId, r.name AS Role, s.Status, r.createAt AS CreateAt, c.userName AS CreateBy, r.updateAt AS UpdateAt, u.userName AS UpdateBy 
                    FROM tblRole r 
                    INNER JOIN tblUser c ON r.createBy = c.id 
                    LEFT JOIN tblUser u ON r.updateBy = u.id
                    INNER JOIN cteStatus s ON r.status = s.StatusId
                    WHERE r.status = 1";
            return _executor.Query<RoleModel, dynamic>(query, new { }, _connectionString);
        }
        public List<RoleModel> FetchRoleData(string searchTerm)
        {
            string query = @"WITH cteStatus AS
                    (
                        SELECT 0 AS StatusId,
                        'False' AS Status
                        UNION ALL
                        SELECT 1 AS StatusId,
                        'True' AS Status
                    )
                    SELECT r.id AS RoleId, r.name AS Role, s.Status, r.createAt AS CreateAt, c.userName AS CreateBy, r.updateAt AS UpdateAt, u.userName AS UpdateBy 
                    FROM tblRole r 
                    INNER JOIN tblUser c ON r.createBy = c.id 
                    LEFT JOIN tblUser u ON r.updateBy = u.id
                    INNER JOIN cteStatus s ON r.status = s.StatusId
                    WHERE r.name LIKE @SearchTerm OR s.Status LIKE @SearchTerm OR c.userName LIKE @SearchTerm";
            return _executor.Query<RoleModel, dynamic>(query, new { SearchTerm = "%" + searchTerm + "%" }, _connectionString);
        }
        public bool CheckIfRoleExists(string role)
        {
            string query = "SELECT COUNT(1) AS IsRoleExist FROM tblRole WHERE name = @Role;";
            try
            {
                int count = _executor.ExecuteScalar<int, dynamic>(query, new {Role = role}, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertRole(string role, int status, int createBy)
        {
            try
            {
                string query = @"BEGIN TRY
                                    BEGIN TRANSACTION
                                        INSERT INTO tblRole (name, status, createAt, createBy) VALUES (@Role, @Status, GETDATE(), @CreateBy);
                                    COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH;";
                _executor.Execute<dynamic>(query, new { Role = role, Status = status, CreateBy = createBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateRole(int roleId, string role, int status, int updateBy)
        {
            try
            {
                string query = @"BEGIN TRY
                                    BEGIN TRANSACTION
                                        UPDATE tblRole SET name = @Role, status = @Status, updateAt = GETDATE(), updateBy = @UpdateBy WHERE id = @RoleId;
                                    COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                THROW;
                            END CATCH;";
                _executor.Execute<dynamic>(query, new { RoleId = roleId, Role = role, Status = status, UpdateBy = updateBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void DeleteRole(int roleId)
        {
            string query = @"BEGIN TRY
                                BEGIN TRANSACTION
                                    DELETE FROM tblRole WHERE id = @RoleId
                                COMMIT TRANSACTION
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION;
                                THROW;
                            END CATCH;";
            _executor.Execute<dynamic>(query, new { RoleId = roleId }, _connectionString);
        }
        #endregion
        #region Category Query Operations
        public List<CategoryModel> FetchCategoryData()
        {
            string query = @"WITH cteStatus AS
            (
	            SELECT 0 AS StatusId,
	            'False' AS Status
	            UNION ALL
	            SELECT 1 AS StatusId,
	            'True' AS Status
                )
            SELECT c.id AS CategoryId, 
            c.categoryName AS Category, 
            s.Status, 
            c.createAt AS CreateAt, 
            cr.userName AS CreateBy, 
            c.updateAt AS UpdateAt,
            up.userName AS UpdateBy 
            FROM tblCategory c
            INNER JOIN tblUser cr ON c.createBy = cr.id
            LEFT JOIN tblUser up ON c.updateBy = up.id
            INNER JOIN cteStatus s ON s.StatusId = c.status
            WHERE c.status = 1;";
            return _executor.Query<CategoryModel, dynamic>(query, new { }, _connectionString);
        }
        public List<CategoryModel> FetchCategoryData(string searchTerm)
        {
            string query = @"WITH cteStatus AS
            (
	            SELECT 0 AS StatusId,
	            'False' AS Status
	            UNION ALL
	            SELECT 1 AS StatusId,
	            'True' AS Status
                )
            SELECT c.id AS CategoryId, 
            c.categoryName AS Category, 
            s.Status, 
            c.createAt AS CreateAt, 
            cr.userName AS CreateBy, 
            c.updateAt AS UpdateAt,
            up.userName AS UpdateBy 
            FROM tblCategory c
            INNER JOIN tblUser cr ON c.createBy = cr.id
            LEFT JOIN tblUser up ON c.updateBy = up.id
            INNER JOIN cteStatus s ON s.StatusId = c.status
            WHERE categoryName LIKE @SearchTerm OR s.Status LIKE @SearchTerm OR cr.userName LIKE @SearchTerm;";
            return _executor.Query<CategoryModel, dynamic>(query, new { SearchTerm = "%" + searchTerm + "%"}, _connectionString);
        }
        public bool CheckIfCategoryExists(string category)
        {     
            try
            {
                string query = "SELECT COUNT(1) AS IsCategoryExist FROM tblCategory WHERE categoryName = @Category;";
                int count = _executor.ExecuteScalar<int, dynamic>(query, new { Category = category }, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertCategory(string category, int status, int createBy)
        {
            try
            {
                string query = @"BEGIN TRY
                                BEGIN TRANSACTION
                                    INSERT INTO tblCategory (categoryName, status, createAt, createBy) VALUES (@Category, @Status, GETDATE(), @CreateBy)
                                COMMIT TRANSACTION;
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION;
                                THROW;
                            END CATCH;";
                _executor.Execute<dynamic>(query, new { Category = category, Status = status, CreateBy = createBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCategory(int categoryId, string category, int status, int updateBy)
        {
            try
            {
                string query = @"BEGIN TRY
                                BEGIN TRANSACTION 
                                    UPDATE tblCategory SET categoryName = @Category, status = @Status, updateAt = GETDATE(), updateBy = @UpdateBy
                                    WHERE id = @CategoryId;
                                COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH;";
                _executor.Execute<dynamic>(query, new { CategoryId = categoryId, Category = category, Status = status, UpdateBy = updateBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void DeleteCategory(int categoryId)
        {
            string query = @"BEGIN TRY
                                BEGIN TRANSACTION
                                    DELETE FROM tblCategory WHERE id = @CategoryId
                                COMMIT TRANSACTION
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION;
                                THROW;
                            END CATCH;";
            _executor.Execute<dynamic>(query, new { CategoryId = categoryId}, _connectionString);
        }
        #endregion
        #region Product Query Operations
        public List<ProductModel> FetchProductData(string searchTerm)
        {
            string query = @"
                            WITH cteProduct AS
                            (
                            SELECT 
                            p.id AS ProductId,
                            p.productName AS Product,
                            p.barcode AS Barcode,
                            p.sellPrice AS SellPrice,
                            p.qtyInStock AS QtyInStock,
                            CASE 
                            WHEN p.photo IS NULL THEN
                            ''
                            ELSE
                            p.photo
                            END AS PhotoUrl,
                            CASE
                            WHEN c.categoryName IS NULL THEN
                            'Deleted'
                            ELSE c.categoryName
                            END AS Category,
                            p.createAt AS CreateAt,
                            cr.userName AS CreateBy,
                            p.updateAt AS UpdateAt,
                            up.userName AS UpdateBy
                            FROM tblProduct p 
                            LEFT JOIN tblCategory c ON p.categoryId = c.id
                            INNER JOIN tblUser cr ON p.createBy = cr.id
                            LEFT JOIN tblUser up ON p.updateBy = up.id
                            )
                            SELECT * FROM cteProduct p WHERE
                            p.Product LIKE @SearchTerm OR p.Barcode LIKE @SearchTerm
                            OR p.SellPrice LIKE @SearchTerm OR p.QtyInStock LIKE @SearchTerm
                            OR p.Category LIKE @SearchTerm OR p.CreateBy LIKE @SearchTerm;";
            return _executor.Query<ProductModel, dynamic>(query, new { SearchTerm = "%" +searchTerm+ "%"}, _connectionString);
        }
        public bool CheckIfProductExists(string product)
        {
            string query = "SELECT COUNT(1) AS IsProductExist FROM tblProduct WHERE productName = @Product;";
            try
            {
                int count = _executor.ExecuteScalar<int, dynamic>(query, new { Product = product }, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool CheckIfBarcodeExists(long barcode)
        {
            string query = "SELECT COUNT(1) AS IsBarcodeExist FROM tblProduct WHERE barcode = @Barcode";
            try
            {
                int count = _executor.ExecuteScalar<int, dynamic>(query, new{ Barcode = barcode}, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertProduct(string product, long barcode, double sellPrice, string photoUrl, string category, int createBy)
        {
            try
            {
                string query = @"BEGIN TRY
                                    BEGIN TRANSACTION
                                        DECLARE @CategoryId INT;
                                        SELECT @CategoryId = id FROM tblCategory WHERE categoryName = @Category;
                                        INSERT INTO tblProduct (productName, barcode, sellPrice, photo, categoryId, createAt, createBy, updateAt, updateBy)
                                        VALUES (@Product, @Barcode, @SellPrice, @PhotoUrl, @CategoryId, GETDATE(), @CreateBy, NULL, NULL);
                                        UPDATE tblProduct SET photo = NULL WHERE photo = '';
                                    COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH;";
                _executor.Execute<dynamic>(query, new { Product = product, Barcode = barcode, SellPrice = sellPrice, PhotoUrl = photoUrl, Category = category, CreateBy = createBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateProduct(int productId, string product, long barcode, double sellPrice, string photoUrl, string category, int updateBy)
        {
            try
            {
                string query = @"BEGIN TRY
                                BEGIN TRANSACTION
                                    DECLARE @CategoryId INT;
                                    SELECT @CategoryId = id FROM tblCategory WHERE categoryName = @Category
                                    UPDATE tblProduct SET
                                        productName = @Product,
                                        barcode = @Barcode,
                                        sellPrice = @SellPrice,
                                        photo = @PhotoUrl,
                                        categoryId = @CategoryId,
                                        updateAt = GETDATE(),
                                        updateBy = @UpdateBy
                                    WHERE id = @ProductId;
                                    UPDATE tblProduct SET photo = NULL WHERE photo = '';
                                COMMIT TRANSACTION;
                            END TRY
                            BEGIN CATCH 
                                ROLLBACK TRANSACTION;
                                THROW;
                            END CATCH";
                _executor.Execute<dynamic>(query, new { ProductId = productId, Product = product, Barcode = barcode, SellPrice = sellPrice, PhotoUrl = photoUrl, Category = category, UpdateBy = updateBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void DeleteProduct(int productId)
        {
            string query = @"BEGIN TRY
                                BEGIN TRANSACTION
                                    DELETE FROM tblProduct WHERE id = @ProductId
                                COMMIT TRANSACTION
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION;
                                THROW
                            END CATCH;";
            _executor.Execute<dynamic>(query, new { ProductId = productId }, _connectionString);
        }
        #endregion
        #region Supplier Query Operations
        public List<SupplierModel> FetchSupplierData()
        {
            string query = @"
                            SELECT name AS SupplierName FROM tblSupplier;
                            ";
            return _executor.Query<SupplierModel, dynamic>(query, new { }, _connectionString);
        }
        public List<SupplierModel> FetchSupplierData(string searchTerm)
        {
            string query = @"
                            SELECT 
                            s.id AS SupplierId, 
                            s.name AS SupplierName, 
                            s.tel AS PhoneNumber, 
                            s.address AS Address, 
                            s.createAt AS CreateAt, 
                            cr.userName AS CreateBy, 
                            s.updateAt AS UpdateAt, 
                            up.userName AS UpdateBy FROM tblSupplier s 
                            INNER JOIN tblUser cr ON s.createBy = cr.id 
                            LEFT JOIN tblUser up ON s.updateBy = up.id 
                            WHERE s.name LIKE @SearchTerm OR s.tel LIKE @SearchTerm
                            OR s.address LIKE @SearchTerm OR cr.userName LIKE @SearchTerm;";
            return _executor.Query<SupplierModel, dynamic>(query, new { SearchTerm = "%" + searchTerm + "%" }, _connectionString);
        }
        public bool CheckIfSupplierExists(string supplierName)
        {
            string query = "SELECT COUNT(1) AS IsSupplierExist FROM tblSupplier WHERE name = @SupplierName;";
            try
            {
                int count = _executor.ExecuteScalar<int, dynamic>(query, new { SupplierName = supplierName }, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool CheckIfSupplierPhoneNumberExists(string phoneNumber)
        {
            string query = "SELECT COUNT(1) AS IsPhoneNumberExist FROM tblSupplier WHERE tel = @PhoneNumber;";
            try
            {
                int count = _executor.ExecuteScalar<int, dynamic>(query, new { PhoneNumber = phoneNumber }, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertSupplier(string supplierName, string phoneNumber, string address, int createBy)
        {
            try
            {
                string query = @"
                                BEGIN TRY
                                    BEGIN TRANSACTION
                                        INSERT INTO tblSupplier (name, tel, address, createAt, createBy, updateAt, updateBy)
                                        VALUES (@SupplierName, @PhoneNumber, @Address, GETDATE(), @CreateBy, NULL, NULL);
                                    COMMIT TRANSACTION
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH;";
                _executor.Execute<dynamic>(query, new { SupplierName = supplierName, PhoneNumber = phoneNumber, Address = address, CreateBy = createBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateSupplier(int supplierId, string supplierName, string phoneNumber, string address, int updateBy)
        {
            try
            {
                string query = @"
                                BEGIN TRY
                                    BEGIN TRANSACTION
                                        UPDATE tblSupplier SET name = @SupplierName, tel = @PhoneNumber, address = @Address, updateAt = GETDATE(), updateBy = @UpdateBy
                                        WHERE id = @SupplierId;
                                    COMMIT TRANSACTION
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH;";
                _executor.Execute<dynamic>(query, new { SupplierId = supplierId, SupplierName = supplierName, PhoneNumber = phoneNumber, Address = address, UpdateBy = updateBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void DeleteSupplier(int supplierId)
        {
            string query = @"
                            BEGIN TRY
                                BEGIN TRANSACTION
                                    DELETE FROM tblSupplier WHERE id = @SupplierId
                                COMMIT TRANSACTION
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION;
                                THROW
                            END CATCH;";
            _executor.Execute<dynamic>(query, new { SupplierId = supplierId }, _connectionString);
        }
        #endregion
        #region Customer Query Operations
        public List<CustomerModel> FetchCustomerData()
        {
            string query = @"
                        	SELECT
                        	name AS CustomerName,
                            gender AS Gender,
                        	tel AS PhoneNumber,
                            address AS Address
                            FROM tblCustomer;
                            ";
            return _executor.Query<CustomerModel, dynamic>(query, new { }, _connectionString);
        }
        public List<CustomerModel> FetchCustomerData(string searchTerm)
        {
            string query = @"
                            WITH cteCustomer AS
                            (
                        	SELECT 
                        	c.id AS CustomerId,
                        	c.name AS CustomerName,
                        	c.gender AS Gender,
                        	c.tel AS PhoneNumber,
                        	c.address AS Address,
                        	c.createAt AS CreateAt,
                        	cr.userName AS CreateBy,
                        	c.updateAt AS UpdateAt,
                        	up.userName AS UpdateBy
                        	FROM tblCustomer c
                        	INNER JOIN tblUser cr ON c.createBy = cr.id
                        	LEFT JOIN tblUser up ON c.updateBy = up.id
                            )
                            SELECT * FROM cteCustomer c WHERE
                            c.CustomerName LIKE @SearchTerm OR
                            c.Gender LIKE @SearchTerm OR
                            c.PhoneNumber LIKE @SearchTerm OR 
                            c.Address LIKE @SearchTerm OR
                            c.CreateBy LIKE @SearchTerm;
                            ";
            return _executor.Query<CustomerModel, dynamic>(query, new { SearchTerm = "%" + searchTerm + "%" }, _connectionString);
        }
        public bool CheckIfCustomerPhoneNumberExists(string phoneNumber)
        {
            try
            {
                string query = @"
                            SELECT COUNT(1) FROM tblCustomer WHERE tel = @PhoneNumber;
                            ";
                int count = _executor.ExecuteScalar<int, dynamic>(query, new { PhoneNumber = phoneNumber }, _connectionString);
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertCustomer(string customerName, string gender, string phoneNumber, string address, int createBy)
        {
            try
            {
                string query = @"
                            BEGIN TRY
                                BEGIN TRANSACTION
                                    INSERT INTO tblCustomer (name, gender, tel, address, createAt, createBy, updateAt, updateBy)
                                    VALUES (@CustomerName, @Gender, @PhoneNumber, @Address, GETDATE(), @CreateBy, NULL, NULL);
                                COMMIT TRANSACTION
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION;
                                THROW;
                            END CATCH;
                            ";
                _executor.Execute<dynamic>(query, new { CustomerName = customerName, Gender = gender, PhoneNumber = phoneNumber, Address = address, CreateBy = createBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(int customerId, string customerName, string gender, string phoneNumber, string address, int updateBy)
        {
            try
            {
                string query = @"
                            BEGIN TRY
                                BEGIN TRANSACTION
                                    UPDATE tblCustomer SET name = @CustomerName, gender = @Gender, tel = @PhoneNumber, address = @Address, updateAt = GETDATE(), updateBy = @UpdateBy
                                    WHERE id = @CustomerId;
                                COMMIT TRANSACTION
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION;
                                THROW
                            END CATCH;
                            ";
                _executor.Execute<dynamic>(query, new { CustomerId = customerId, CustomerName = customerName, Gender = gender, PhoneNumber = phoneNumber, Address = address, UpdateBy = updateBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void DeleteCustomer(int customerId)
        {
            string query = @"
                        BEGIN TRY
                            BEGIN TRANSACTION
                                DELETE FROM tblCustomer WHERE id = @CustomerId;
                            COMMIT TRANSACTION
                        END TRY
                        BEGIN CATCH
                            ROLLBACK TRANSACTION
                            TRHOW;
                        END CATCH;
                            ";
            _executor.Execute<dynamic>(query, new { customerId }, _connectionString);
        }
        #endregion
        #region Add Stock Query Operations
        public bool InsertAddStock(string supplier, int productId, int quantity, double cost, double total, int createBy)
        {
            try
            {
                string query = @"
                                BEGIN TRY
                                    BEGIN TRANSACTION
                                        DECLARE @SupplierId INT;
                                        SELECT @SupplierId = id FROM tblSupplier WHERE name = @Supplier;
                                        INSERT INTO tblAddStock (supplierId, productId, qty, cost, total, createAt, createBy, updateAt, updateBy)
                                        VALUES (@SupplierId, @ProductId, @Quantity, @Cost, @Total, GETDATE(), @CreateBy, NULL, NULL);
                                        UPDATE tblProduct SET qtyInStock = qtyInStock + @Quantity WHERE id = @ProductId;
                                    COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH;
                                ";
                _executor.Execute<dynamic>(query, new { Supplier = supplier, ProductId = productId, Quantity = quantity, Cost = cost, Total = total, CreateBy = createBy }, _connectionString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Sale Query Operations
        public List<SaleModel> ScanBarcode(long barcode)
        {
            string query = @"
                            SELECT
                            barcode AS Barcode,
                            id AS ProductId,
                            photo AS PhotoUrl,
                            productName AS Description,
                            1 AS Quantity,
                            sellPrice AS Price,
                            qtyInStock AS QtyInStock
                            FROM tblProduct WHERE barcode = @Barcode;
                            ";
            return _executor.Query<SaleModel, dynamic>(query, new {Barcode = barcode}, _connectionString);
        }
        public int InsertSale(string phoneNumber, int userId, double totalAmount)
        {
            string query = @"
                                BEGIN TRY
                                    BEGIN TRANSACTION
                                        DECLARE @CustomerId INT;
                                        SELECT @CustomerId = id FROM tblCustomer WHERE tel = @PhoneNumber;

                                        INSERT INTO tblSale (customerId, saleDate, userId, totalAmount)
                                        VALUES (@CustomerId, GETDATE(), @UserId, @TotalAmount);

                                        DECLARE @SaleId INT = SCOPE_IDENTITY();
                                        SELECT @SaleId;
                                    COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH;
                                ";
            return _executor.ExecuteScalar<int, dynamic>(query, new { PhoneNumber = phoneNumber, UserId = userId, TotalAmount = totalAmount}, _connectionString);
        }
        public bool InsertSaleDetail(int saleId, List<SaleDetailModel> saleDetails)
        {
            try
            {
                foreach (SaleDetailModel saleDetail in saleDetails)
                {
                    string query = @"
                                BEGIN TRY
                                    BEGIN TRANSACTION
                                        INSERT INTO tblSaleDetail (saleId, productId, qty, price, total)
                                        VALUES (@SaleId, @ProductId, @Quantity, @Price, @Subtotal);

                                        UPDATE tblProduct SET qtyInStock = qtyInStock - @Quantity WHERE id = @ProductId;
                                    COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH;
                                ";
                    _executor.Execute<dynamic>(query, new { SaleId = saleId, saleDetail.ProductId, saleDetail.Quantity, saleDetail.Price, saleDetail.SubTotal }, _connectionString);               
                }
                return true;
            }
            catch
            {
                return false;
            }
        }           
        public void DeleteSale(int saleId)
        {
            string query = @"
                            BEGIN TRY
                                BEGIN TRANSACTION
                                    DELETE FROM tblSale WHERE id = @SaleId;
                                COMMIT TRANSACTION;
                            END TRY
                            BEGIN CATCH
                                ROLLBACK TRANSACTION;
                                THROW;
                            END CATCH;
                            ";
            _executor.Execute<dynamic>(query, new { SaleId = saleId }, _connectionString);
        }
        public DateTime GetSaleDate(int saleId)
        {
            string query = @"SELECT saleDate FROM tblSale WHERE id = @SaleId";
            return _executor.ExecuteScalar<DateTime, dynamic>(query, new { SaleId = saleId }, _connectionString);
        }
        #endregion
        #region Invoice Query Operations
        public List<InvoiceModel> FetchInvoiceData()
        {
            string query = @"
                            SELECT DISTINCT s.id AS SaleId, c.name AS CustomerName, s.saleDate AS SaleDate, s.totalAmount AS Total FROM tblSale s
                            INNER JOIN tblCustomer c ON s.customerId = c.id;
                            ";
            return _executor.Query<InvoiceModel, dynamic>(query, null, _connectionString);
        }
        public List<InvoiceModel> FetchInvoiceData(string searchTerm)
        {
            string query = @"
                            SELECT DISTINCT s.id AS SaleId, c.name AS CustomerName, s.saleDate AS SaleDate, s.totalAmount AS Total FROM tblSale s
                            INNER JOIN tblCustomer c ON s.customerId = c.id WHERE s.id LIKE @SearchTerm OR c.name LIKE @SearchTerm OR s.saleDate
                            LIKE @SearchTerm OR s.totalAmount LIKE @SearchTerm;
                            ";
            return _executor.Query<InvoiceModel, dynamic>(query, new {SearchTerm = "%" + searchTerm + "%"}, _connectionString);
        }
        public InvoiceModel FetchInvoiceHeader(int saleId)
        {
            string query = @"
                            SELECT 
                            c.name AS CustomerName,
                            c.gender AS Gender,
                            c.tel AS PhoneNumber,
                            c.address AS Address,
                            u.userName AS RepName,
                            s.saleDate AS SaleDate
                            FROM tblSale s
                            INNER JOIN tblCustomer c ON s.customerId = c.id
                            INNER JOIN tblUser u ON u.id = s.userId
                            WHERE s.id = @SaleId;
                            ";
            return _executor.QuerySingle<InvoiceModel, dynamic>(query, new { SaleId = saleId }, _connectionString);
        }
        public List<InvoiceModel> FetchInvoiceDataGridView(int saleId)
        {
            string query = @"
                            SELECT
                            p.productName AS Description,
                            sd.qty AS Quantity,
                            sd.price AS Price,
                            sd.total AS SubTotal
                            FROM tblSale s
                            INNER JOIN tblSaleDetail sd ON s.id = sd.saleId
                            INNER JOIN tblProduct p ON p.id = sd.productId
                            WHERE s.id = @SaleId;
                            ";
            return _executor.Query<InvoiceModel, dynamic>(query, new { SaleId = saleId}, _connectionString);
        }
        public double GetInvoiceTotal(int saleId)
        {
            string query = @"
                            SELECT totalAmount AS Total FROM tblSale WHERE id = @SaleId;
                            ";
            return _executor.QuerySingle<double, dynamic>(query, new { SaleId = saleId }, _connectionString);
        }
        #endregion
    }
}
