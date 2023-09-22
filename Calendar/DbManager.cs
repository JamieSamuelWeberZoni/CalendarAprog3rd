using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        // #############################
        // The global variables of the class
        // #############################


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
        /// The list of the name of the id of each table
        /// </summary>
        Dictionary<string, string> tableIdName;

        /// <summary>
        /// The list of the function for the update statement of each table
        /// </summary>
        Dictionary<string, Func<string[], string>> tableDataModify;


        // #############################
        // The start of the object
        // #############################


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

            // The list of the name of the id of each table
            tableIdName = new Dictionary<string, string>();
            tableIdName.Add("Teachers", "idTeacher");
            tableIdName.Add("Rooms", "idRoom");
            tableIdName.Add("Classes", "idClass");
            tableIdName.Add("Schedules", "idSchedule");

            // The list of the update statement of each table
            tableDataModify = new Dictionary<string, Func<string[], string>>();
            tableDataModify.Add("Teachers", (string[] data) => "name = '" + data[0] + "', email = '" + data[1] + "', phoneNbr = '" + data[2] + "'");
            tableDataModify.Add("Rooms", (string[] data) => "name = '" + data[0] + "', capacity = " + data[1]);
            tableDataModify.Add("Classes", (string[] data) => "name = '" + data[0] + "', description = '" + data[1] + "', idTeacher = " + data[2]);
            tableDataModify.Add("Schedules", (string[] data) => "weekDay = '" + data[0] + "', startHour = '" + data[1] + "', endHour = '" + data[2] + "', idRoom = " + data[3] + ", idClass = " + data[4]);
        }


        // #############################
        // The execution of the commands
        // #############################


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

        /// <summary>
        /// Delete a given item from a given table from the database
        /// </summary>
        /// <param name="table">The table where we delete the item</param>
        /// <param name="id">The id of the item</param>
        public void DeleteData(string table, string id)
        {
            string query = "DELETE FROM " + table + " WHERE " + tableIdName[table] + " = " + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Check whether an item from a table is free to delete or if another table is referencing it
        /// </summary>
        /// <param name="orTable">The original table of the item</param>
        /// <param name="refTable">The table referencing the item</param>
        /// <param name="id">The id of the item</param>
        /// <returns>true if we can delete it, false if not</returns>
        public bool CheckIfFree(string orTable, string refTable, string id)
        {
            string query = "SELECT * FROM " + refTable + " WHERE " + tableIdName[orTable] + " = " + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable table = new DataTable();
            new MySqlDataAdapter(cmd).Fill(table);
            return (table.Rows.Count == 0);
        }

        /// <summary>
        /// Modify the data of the given item to another item hsine gr
        /// </summary>
        /// <param name="table">The table of the item to modify</param>
        /// <param name="id">The id of the item to modify</param>
        /// <param name="data">The new data of the item</param>
        public void ModifyData(string table, string id, string[] data)
        {
            string query = "UPDATE " + table + " SET " + tableDataModify[table](data) + " WHERE " + tableIdName[table] + " = " + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
