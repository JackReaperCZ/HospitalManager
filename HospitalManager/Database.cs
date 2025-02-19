using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace HospitalManager
{
    /// <summary>
    /// Represents a singleton database connection manager for MySQL.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Gets the singleton instance of the <see cref="Database"/> class.
        /// </summary>
        public static Database Instance { get; } = new Database();
        
        /// <summary>
        /// Represents the MySQL database connection.
        /// </summary>
        private static MySqlConnection sqlConnection;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// Establishes a connection to the MySQL database using configuration settings.
        /// </summary>
        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = ConfigurationManager.AppSettings["DB_HOST"];
            builder.Password = ConfigurationManager.AppSettings["DB_PASSWORD"];
            builder.UserID = ConfigurationManager.AppSettings["DB_USER"];
            builder.Database = ConfigurationManager.AppSettings["DB_DATABASE"];
            
            sqlConnection = new MySqlConnection(builder.ConnectionString);
            
            sqlConnection.Open();
        }

        /// <summary>
        /// Gets the current MySQL database connection.
        /// </summary>
        /// <returns>The active <see cref="MySqlConnection"/> instance.</returns>
        public MySqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}