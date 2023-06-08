using Dapper;
using Deepser.Framework.Request;
using MaterialSkin;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.SQLite;
using System.Reflection;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using static Dapper.SqlMapper;
using static Deepser.Framework.Request.Filter;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Deepser_Desktop
{
    public class Collection_Fav
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public string Filters { get; set; }
        public string Parameters { get; set; }
        public string Name { get; set; }
    }

    public class CollectionActivity_Fav
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public int EntityID { get; set; }
        public string Filters { get; set; }
        public string Parameters { get; set; }
        public string Name { get; set; }
    }

    public class Load_History
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public string EntityID { get; set; }
        public string Attribute { get; set; }
        public string Single { get; set; }
        public string Date { get; set; }
    }

    public class Collection_History
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public string Filters { get; set; }
        public string Parameters { get; set; }
        public string Date { get; set; }
    }

    public class LoadActivity_History
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public int EntityID { get; set; }
        public int ActivityID { get; set; }
        public string Single { get; set; }
        public string Date { get; set; }
    }

    public class CollectionActivity_History
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public int EntityID { get; set; }
        public string Filters { get; set; }
        public string Parameters { get; set; }
        public string Date { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public byte[] ProfilePicture { get; set; }
    }

    public class DepartmentUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
    }

    internal class SqliteDataAccess
    {
        //FAV

        public static void ChangeNameFavColl(string text, string entity, string filters = null, string parameters = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string query = "UPDATE Collection_Fav SET Name = @Text WHERE Entity = @Entity";
                if (!string.IsNullOrEmpty(parameters))
                {
                    query += " AND Parameters = @Parameters";
                }
                if (!string.IsNullOrEmpty(filters))
                {
                    query += " AND Filters = @Filters";
                }

                conn.Execute(query, new { Text = text, Entity = entity, Parameters = parameters, Filters = filters });

                conn.Close();
            }
        }


        public static void ChangeNameFavCollAct(string text, string entity, string entityId, string? filters = null, string? parameters = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string query = "UPDATE CollectionActivity_Fav SET Name = @Text WHERE Entity = @Entity AND EntityId = @EntityId";
                if (!string.IsNullOrEmpty(parameters))
                {
                    query += " AND Parameters = @Parameters";
                }
                if (!string.IsNullOrEmpty(filters))
                {
                    query += " AND Filters = @Filters";
                }

                conn.Execute(query, new { Text = text, Entity = entity, EntityId = entityId, Parameters = parameters, Filters = filters });

                conn.Close();
            }
        }

        public static void DeleteFromFavColl(string entity, string filters = null, string parameters = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                if (filters != null && parameters != null)
                {
                    conn.Execute($"DELETE FROM Collection_Fav WHERE Entity = @Entity AND Filters = @Filters AND Parameters = @Parameters", new { Entity = entity, Filters = filters, Parameters = parameters });
                }
                else if (filters != null)
                {
                    conn.Execute($"DELETE FROM Collection_Fav WHERE Entity = @Entity AND Filters = @Filters AND Parameters IS NULL", new { Entity = entity, Filters = filters });
                }
                else if (parameters != null)
                {
                    conn.Execute($"DELETE FROM Collection_Fav WHERE Entity = @Entity AND Filters IS NULL AND Parameters = @Parameters", new { Entity = entity, Parameters = parameters });
                }
                else
                {
                    conn.Execute($"DELETE FROM Collection_Fav WHERE Entity = @Entity AND Filters IS NULL AND Parameters IS NULL", new { Entity = entity });
                }

                conn.Close();
            }
        }

        public static void DeleteFromFavActColl(string entity, string entityId, string filters = null, string parameters = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                if (filters != null && parameters != null)
                {
                    conn.Execute($"DELETE FROM CollectionActivity_Fav WHERE Entity = @Entity AND EntityID = @EntityID AND Filters = @Filters AND Parameters = @Parameters", new { Entity = entity, EntityID = entityId, Filters = filters, Parameters = parameters });
                }
                else if (filters != null)
                {
                    conn.Execute($"DELETE FROM CollectionActivity_Fav WHERE Entity = @Entity AND EntityID = @EntityID AND Filters = @Filters AND Parameters IS NULL", new { Entity = entity, EntityID = entityId, Filters = filters });
                }
                else if (parameters != null)
                {
                    conn.Execute($"DELETE FROM CollectionActivity_Fav WHERE Entity = @Entity AND EntityID = @EntityID AND Filters IS NULL AND Parameters = @Parameters", new { Entity = entity, EntityID = entityId, Parameters = parameters });
                }
                else
                {
                    conn.Execute($"DELETE FROM CollectionActivity_Fav WHERE Entity = @Entity AND EntityID = @EntityID AND Filters IS NULL AND Parameters IS NULL", new { Entity = entity, EntityID = entityId });
                }

                conn.Close();
            }
        }

        public static bool CheckIsFav()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();


                var dash = Dashboard.GetIstance();
                if (dash.main.Controls[0] is Collection)
                {
                    var last = GetLastInsertColl();
                    var result = conn.Query<Collection_Fav>("SELECT * FROM Collection_Fav").ToList();
                    foreach (var item in result)
                    {
                        if (item.Entity == last.Entity && item.Parameters == last.Parameters && item.Filters == last.Filters)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    var last = GetLastInsertCollAct();
                    var result = conn.Query<CollectionActivity_Fav>("SELECT * FROM CollectionActivity_Fav").ToList();
                    foreach (var item in result)
                    {
                        if (item.Entity == last.Entity && item.Parameters == last.Parameters && item.Filters == last.Filters)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
        }

        public static void InsertCollectionFav(string entity, string filters = null, string parameters = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                conn.Execute(@"
            INSERT INTO Collection_Fav (Entity, Filters, Parameters)
            SELECT @Entity, @Filters, @Parameters
            WHERE NOT EXISTS (
                SELECT 1
                FROM Collection_Fav
                WHERE Entity = @Entity
                    AND Filters = @Filters
                    AND Parameters = @Parameters
            );",
                    new { Entity = entity, Filters = filters, Parameters = parameters });

                conn.Close();
            }
        }


        public static void InsertCollectionActivityFav(string entity, int entityID, string filters = null, string parameters = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                conn.Execute(@"
            INSERT INTO CollectionActivity_Fav (Entity, EntityID, Filters, Parameters)
            SELECT @Entity, @EntityID, @Filters, @Parameters
            WHERE NOT EXISTS (
                SELECT 1
                FROM CollectionActivity_Fav
                WHERE Entity = @Entity
                    AND EntityID = @EntityID
                    AND Filters = @Filters
                    AND Parameters = @Parameters
            );",
                    new { Entity = entity, EntityID = entityID, Filters = filters, Parameters = parameters });

                conn.Close();
            }
        }


        public static List<Collection_Fav> GetCollectionFav()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var result = conn.Query<Collection_Fav>("SELECT * FROM Collection_Fav").ToList();

                conn.Close();
                return result;
            }
        }

        public static List<CollectionActivity_Fav> GetCollectionActivityFav()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var result = conn.Query<CollectionActivity_Fav>("SELECT * FROM CollectionActivity_Fav").ToList();

                conn.Close();
                return result;
            }
        }

        //
        //END FAV
        //
        //
        //
        //HISTORY
        //
        public static void InsertLoadHistory(string entity, string entityID, string attribute = null, string single = null)
        {

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string currentDate = DateTime.UtcNow.ToString("F");
                conn.Execute(@"
                INSERT INTO Load_History (Entity, EntityID, Attribute, Single, Date)
                VALUES (@Entity, @EntityID, @Attribute, @Single, @Date);",
                    new { Entity = entity, EntityID = entityID, Attribute = attribute, Single = single, Date = currentDate });
                
                conn.Close();
            }
        }

        public static void InsertCollectionHistory(string entity, string filters = null, string parameters = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string currentDate = DateTime.UtcNow.ToString("F");

                conn.Execute(@"
                        INSERT INTO Collection_History (Entity, Filters, Parameters, Date)
                        VALUES (@Entity, @Filters, @Parameters, @Date);",
                    new { Entity = entity, Filters = filters, Parameters = parameters, Date = currentDate });

                conn.Close();
            }
        }

        public static void InsertLoadActivityHistory(string entity, int entityID, int activityID, string single = null)
        {

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string currentDate = DateTime.UtcNow.ToString("F");

                conn.Execute(@"
            INSERT INTO LoadActivity_History (Entity, EntityID, ActivityID, Single, Date)
            VALUES (@Entity, @EntityID, @ActivityID, @Single, @Date);",
                    new { Entity = entity, EntityID = entityID, ActivityID = activityID, Single = single, Date = currentDate });

                conn.Close();
            }
        }

        public static void InsertCollectionActivityHistory(string entity, int entityID, string filters = null, string parameters = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string currentDate = DateTime.UtcNow.ToString("F");

                conn.Execute(@"
                        INSERT INTO CollectionActivity_History (Entity, EntityID, Filters, Parameters, Date)
                        VALUES (@Entity, @EntityID, @Filters, @Parameters, @Date);",
                    new { Entity = entity, EntityID = entityID, Filters = filters, Parameters = parameters, Date = currentDate });

                conn.Close();
            }
        }

        public static Collection_History GetLastInsertColl()
        {

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var result = conn.QueryFirstOrDefault<Collection_History>(@"SELECT * FROM Collection_History ORDER BY Id DESC LIMIT 1");
                
                conn.Close();
                return result;
            }
        }

        public static CollectionActivity_History GetLastInsertCollAct()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var result = conn.QueryFirstOrDefault<CollectionActivity_History>(@"SELECT * FROM CollectionActivity_History ORDER BY Id DESC LIMIT 1");

                conn.Close();
                return result;
            }
        }

        public static List<Load_History> GetLoadHistory()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var result = conn.Query<Load_History>("SELECT * FROM Load_History ORDER BY Load_History.Id DESC").ToList();

                conn.Close();
                return result;
            }
        }

        public static List<Collection_History> GetCollectionHistory()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var result = conn.Query<Collection_History>("SELECT * FROM Collection_History ORDER BY Collection_History.Id DESC").ToList();

                conn.Close();
                return result;
            }
        }

        public static List<LoadActivity_History> GetLoadActivityHistory()
        {

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var result = conn.Query<LoadActivity_History>("SELECT * FROM LoadActivity_History ORDER BY LoadActivity_History.Id DESC").ToList();

                conn.Close();
                return result;
            }
        }

        public static List<CollectionActivity_History> GetCollectionActivityHistory()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var result = conn.Query<CollectionActivity_History>("SELECT * FROM CollectionActivity_History ORDER BY CollectionActivity_History.Id DESC").ToList();

                conn.Close();
                return result;
            }
        }



        public static void DeleteAllFromHistory(string form)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                if (form == "collection")
                {
                    conn.Execute("DELETE FROM Collection_History");
                }
                else if (form == "load")
                {
                    conn.Execute("DELETE FROM Load_History");
                }
                else if (form == "loadActivity")
                {
                    conn.Execute("DELETE FROM LoadActivity_History");
                }
                else
                {
                    conn.Execute("DELETE FROM CollectionActivity_History");
                }
                conn.Close();
            }
        }
        //
        //
        // END HISTORY

        public static List<string> UserForDepartment(string department)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Department", department);
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                List<string> user = conn.Query<string>("SELECT Username FROM DepartmentUser INNER JOIN User ON DepartmentUser.UserId = User.Id INNER JOIN Department ON DepartmentUser.DepartmentId = Department.Id WHERE Department.name = @Department", parameters).ToList();
                conn.Close();
                return user;
            }
        }
        public static int Table()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                int table = conn.QuerySingleOrDefault<int>("SELECT COUNT(*) FROM sqlite_master WHERE Type = 'table'");
                conn.Close();
                return table;
            }
            
        }

        public static void DeleteDatabase()
        {
            string debugFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dbFilePath = Path.Combine(debugFolderPath, "Company.db");

            if (File.Exists(dbFilePath))
            {
                File.Delete(dbFilePath);
                Console.WriteLine("Database file deleted successfully.");
            }
            else
            {
                Console.WriteLine("Database file not found.");
            }
        }

        public static void EnsureDatabaseExists()
        {
            if (!File.Exists(LoadConnectionString()))
            {
                CreateDatabase();
            }
        }

        public static User Login(string username)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new { Username = username};
                var user = conn.QuerySingleOrDefault<User>("SELECT * FROM User WHERE Username = @Username", parameters);
                return user;
            }
        }

        public static User Login(string username, string department)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new { Username = username, Department = department };
                var user = conn.QuerySingleOrDefault<User>("SELECT * FROM DepartmentUser INNER JOIN User ON UserId = User.Id INNER JOIN Department ON DepartmentId = Department.Id WHERE Department.name = @Department AND User.Username = @Username", parameters);
                return user;
            }
        }


        public static bool CheckDatabase()
        {
            string debugFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dbFilePath = Path.Combine(debugFolderPath, "Company.db");

            if (File.Exists(dbFilePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckDepartment()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                int result = conn.QueryFirstOrDefault<int>("SELECT COUNT(*) FROM sqlite_sequence WHERE name='Department'");
                conn.Close();

                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public static void CreateDepartment()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                conn.Execute("CREATE TABLE \"Department\" (\"Id\"INTEGER NOT NULL UNIQUE,\"Name\"TEXT NOT NULL UNIQUE,PRIMARY KEY(\"Id\" AUTOINCREMENT))");

                conn.Close();
            }
        }

        public static void CreateDepartmentUser()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                conn.Execute(@"CREATE TABLE ""DepartmentUser"" (""Id"" INTEGER NOT NULL UNIQUE,  ""UserId"" INTEGER NOT NULL,  ""DepartmentId"" INTEGER NOT NULL,  PRIMARY KEY(""Id"" AUTOINCREMENT), FOREIGN KEY(""DepartmentId"") REFERENCES ""Department""(""Id""),  FOREIGN KEY(""UserId"") REFERENCES ""User""(""Id""))");

                conn.Close();
            }
        }

        public static List<User> AdminAccess(string Password)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Password", Password);
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    conn.Open();

                    List<User> list = conn.Query<User>("SELECT * FROM User WHERE Password = @Password", parameters).ToList();
                    conn.Close();
                    
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 
        public static void AddDepartment(string department)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    conn.Open();

                    conn.Execute("INSERT INTO Department (Name) VALUES (@Department)", new { Department = department });

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Database error, probably '{department}' is already used");
            }
        }

        public static void AddUser(string host, string username, string password, string token, string role, byte[] profilePicture)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Host", host);
            parameters.Add("@Username", username);
            parameters.Add("@Password", password);
            parameters.Add("@Token", token);
            parameters.Add("@Role", role);
            parameters.Add("@ProfilePicture", profilePicture);

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                conn.Execute("INSERT INTO User (Host, Username, Password, Token, Role, ProfilePicture) VALUES (@Host, @Username, @Password, @Token, @Role, @ProfilePicture)", parameters);

                conn.Close();
            }

        }

    public static void DeleteUser(string username)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Username", username);
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                if (Table() == 8)
                { 
                    conn.Execute("DELETE FROM User WHERE Username = @Username", parameters);
                    conn.Close();
                }
                else
                {
                    parameters.Add("Username", username);
                    string UserId = conn.QueryFirstOrDefault<string>("SELECT Id FROM User WHERE Username = @Username", parameters);
                    parameters.Add("UserId", UserId);
                    conn.Execute("DELETE FROM DepartmentUser WHERE UserId = @UserId", parameters);
                    conn.Execute("DELETE FROM User WHERE Username = @Username", parameters);
                    conn.Close();
                }
            }
        }

        public static void DeleteDepartment(string Department)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var parameters = new DynamicParameters();
                parameters.Add("Department", Department);

                conn.Execute("DELETE FROM Department WHERE Name = @Department", parameters);
                conn.Close();
            }
        }

        public static void RemoveFromDepartment(string Username, string Department)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Username", Username);
            parameters.Add("Department", Department);

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string userId = conn.QuerySingleOrDefault<string>("SELECT Id FROM User WHERE Username = @Username", parameters);
                string departmentId = conn.QuerySingleOrDefault<string>("SELECT Id FROM Department WHERE Name = @Department", parameters);

                parameters.Add("UserId", userId);
                parameters.Add("DepartmentId", departmentId);

                List<string> list = conn.Query<string>("SELECT * FROM DepartmentUser WHERE UserId = @UserId AND DepartmentId = @DepartmentId", parameters).ToList();

                conn.Execute("DELETE FROM DepartmentUser WHERE UserId = @UserId AND  DepartmentId = @DepartmentId", parameters);

                conn.Close();
            }
        }
        public static List<string> Users()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                List<string> output = conn.Query<string>("SELECT Username FROM User").ToList();

                conn.Close();
                return output;
            }
        }

        public static List<string> UsersWithoutAdmin()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                List<string> output = conn.Query<string>("SELECT Username FROM User WHERE Id != 1").ToList();

                conn.Close();
                return output;
            }
            
        }

        public static List<User> AllUsers()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                List<User> output = conn.Query<User>("SELECT * FROM User").ToList();

                conn.Close();
                return output;
            }
        }

        public static void AddUserToDepartment(string Username, string Department)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Username", Username);
            parameters.Add("Department", Department);

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string userId = conn.QuerySingleOrDefault<string>("SELECT Id FROM User WHERE Username = @Username", parameters);
                string departmentId = conn.QuerySingleOrDefault<string>("SELECT Id FROM Department WHERE Name = @Department", parameters);

                parameters.Add("UserId", userId);
                parameters.Add("DepartmentId", departmentId);

                List<string> list= conn.Query<string>("SELECT * FROM DepartmentUser WHERE UserId = @UserId AND DepartmentId = @DepartmentId", parameters).ToList();
                if (list.Count == 0)
                {
                    conn.Execute("INSERT INTO DepartmentUser (UserId, DepartmentId) VALUES (@UserId, @DepartmentId)", parameters);
                }
                else
                {
                    throw new Exception($"{Username} is already in {Department} department");
                }

                conn.Close();
            }
        }

        public static List<string> GetDepartments()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                List<string> output = conn.Query<string>("SELECT Name FROM Department").ToList();
                return output;

            }
        }

        public static List<string> GetUsers(string department)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string departmentId = conn.QuerySingleOrDefault<string>("SELECT Id FROM Department WHERE Name = @Department", new { Department = department });

                List<string> output = conn.Query<string>("SELECT Username FROM User WHERE Id IN (SELECT UserId FROM DepartmentUser WHERE DepartmentId = @DepartmentId)", new { DepartmentId = departmentId }).ToList();

                return output;
            }
        }

        internal static string GetFilePath()
        {
            string debugFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dbFilePath = Path.Combine(debugFolderPath, "Company.db");
            return dbFilePath;
        }

        public static string LoadConnectionString(string id = "Default")
        {
            string connectionString = ConfigurationManager.ConnectionStrings[id].ConnectionString;

            if (!File.Exists(GetFilePath()))
            {
                CreateDatabase();
            }

            return connectionString;
        }


        public static void CreateDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={GetFilePath()}"))
            {
                conn.Open();

                conn.Execute(@"CREATE TABLE IF NOT EXISTS User (
                    Id INTEGER NOT NULL UNIQUE,
                    Host TEXT,
                    Username TEXT,
                    Password TEXT,
                    Token TEXT,
                    Role TEXT,
                    ProfilePicture BLOB,
                    PRIMARY KEY(Id AUTOINCREMENT)
                );");

                conn.Execute(@"CREATE TABLE IF NOT EXISTS Load_History (
                    Id INTEGER,
                    Entity TEXT NOT NULL,
                    EntityID TEXT NOT NULL,
                    Attribute TEXT,
                    Single TEXT,
                    Date TEXT,
                    PRIMARY KEY(Id AUTOINCREMENT)
                );");

                conn.Execute(@"CREATE TABLE IF NOT EXISTS Collection_History (
	                Id	INTEGER,
	                Entity	TEXT NOT NULL,
	                Filters	TEXT,
	                Parameters	TEXT,
                    Date TEXT,
	                PRIMARY KEY(Id AUTOINCREMENT)
                );");

                conn.Execute(@"CREATE TABLE IF NOT EXISTS LoadActivity_History (
                    Id INTEGER,
                    Entity TEXT NOT NULL,
                    EntityID INTEGER NOT NULL,
                    ActivityID INTEGER NOT NULL,
                    Single TEXT,
                    Date TEXT,
                    PRIMARY KEY(Id AUTOINCREMENT)
                );");

                conn.Execute(@"CREATE TABLE IF NOT EXISTS CollectionActivity_History (
                    Id INTEGER,
                    Entity TEXT NOT NULL,
                    EntityID INTEGER NOT NULL,
                    Filters TEXT,
                    Parameters TEXT,
                    Date TEXT,
                    PRIMARY KEY(Id AUTOINCREMENT)
                );");

                conn.Execute(@"CREATE TABLE IF NOT EXISTS Collection_Fav (
	                Id	INTEGER,
	                Entity	TEXT NOT NULL,
	                Filters	TEXT,
	                Parameters	TEXT,
                    Name TEXT,
	                PRIMARY KEY(Id AUTOINCREMENT)
                );");

                conn.Execute(@"CREATE TABLE IF NOT EXISTS CollectionActivity_Fav (
                    Id INTEGER,
                    Entity TEXT NOT NULL,
                    EntityID INTEGER NOT NULL,
                    Filters TEXT,
                    Parameters TEXT,
                    Name TEXT,
                    PRIMARY KEY(Id AUTOINCREMENT)
                );");

                conn.Close();
            }
        }

        internal static int AllRelation()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var output = conn.QueryFirstOrDefault<int>("SELECT COUNT(*) FROM DepartmentUser");

                return output;
            }
        }
    }
}
