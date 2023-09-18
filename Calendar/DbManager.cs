using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Project      : Calendar
 * File         : DbManager.cs
 * Description  : A calendar app for a school where you can add/modify/delete teachers, rooms, classes and schedules
 * Author       : Weber Jamie
 * Date         : 08 September 2023 - 
**/
namespace Calendar
{
    /// <summary>
    /// The class that manage the connection and command to the database
    /// </summary>
    internal class DbManager
    {
        /// <summary>
        /// The connection to the database
        /// </summary>
        MySqlConnection connection;

        /// <summary>
        /// The list of all the columns for each tables
        /// </summary>
        Dictionary<string, string> tableColumns;

        /// <summary>
        /// The list of the function for the insert statement of each table
        /// </summary>
        Dictionary<string, Func<string[], string>> tableDataInsert;


        /// <summary>
        /// The constructor of the class, connect to the database and set the values for each elements in the two lists above
        /// </summary>
        public DbManager()
        {
            // Connection to the database
            string server = "localhost";
            string database = "calendarClasses";
            string uid = "jamiewbr";
            string password = "Super";
            string connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            // The list of the columns of each tables
            tableColumns = new Dictionary<string, string>();
            tableColumns.Add("Teachers", "(name,email,phoneNbr)");
            tableColumns.Add("Rooms", "(name,capacity)");
            tableColumns.Add("Classes", "(name,description,idTeacher)");
            tableColumns.Add("Schedules", "(weekDay,startHour,endHour,idRoom,idClass)");
            // The list of the insert statement of each tables
            tableDataInsert = new Dictionary<string, Func<string[], string>>();
            tableDataInsert.Add("Teachers", (string[] data) => "('" + data[0] + "','" + data[1] + "','" + data[2] + "');");
            tableDataInsert.Add("Rooms", (string[] data) => "('" + data[0] + "'," + data[1] + ");");
            tableDataInsert.Add("Classes", (string[] data) => "('" + data[0] + "','" + data[1] + "'," + data[2] + ");");
            tableDataInsert.Add("Schedules", (string[] data) => "('" + data[0] + "','" + data[1] + "','" + data[2] + "'," + data[3] + "," + data[4] + ");");
        }

        /// <summary>
        /// Get from the database the objects of a given table
        /// </summary>
        /// <param name="table">The table to get the objects</param>
        /// <param name="columns">The columns to get</param>
        /// <param name="filter">The hypothetical WHERE statement if needed</param>
        /// <returns>An object containing all the infos of the table</returns>
        public MySqlDataAdapter GetListObject(string table, string columns, string filter = "")
        {
            string query = "SELECT " + columns + " FROM " + table + ((filter == "") ? ";" : (" " + filter + ";"));
            MySqlCommand cmd = new MySqlCommand(query, connection);
            return new MySqlDataAdapter(cmd);
        }

        /// <summary>
        /// Add an item to a given table in the database
        /// </summary>
        /// <param name="table">The table where we add the item</param>
        /// <param name="data">The data of the item</param>
        public void AddData(string table, string[] data)
        {
            string query = "INSERT INTO " + table + tableColumns[table] + " VALUES " + tableDataInsert[table](data);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
