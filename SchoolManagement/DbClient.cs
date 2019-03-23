using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagement
{
    static class DbClient
    {
        public const string _connectionString = @"Data Source=DESKTOP-CGN5PGF\SQLEXPRESS;Initial Catalog='School Management System';Integrated Security=True";
        public const string DBName = "School Management System";
        public static SqlConnection _connection;
        public static SqlCommand _commandExecute;
        public static SqlDataAdapter _dataAdapter;
        public static DataTable _dataTable;

        static DbClient()
        {

            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        //Methods

        public static void QueryExecute(string query, byte[] img)
        {
            _commandExecute = new SqlCommand();
            _commandExecute.CommandText = query;
            _commandExecute.Connection = _connection;
            _commandExecute.Parameters.AddWithValue("@img", img);
            _commandExecute.ExecuteNonQuery();
        }

        public static void QueryExecute(string query)
        {
            _commandExecute = new SqlCommand(query, _connection);
            _commandExecute.ExecuteNonQuery();
        }



        public static void DeleteDatabase(string dbName)
        {
            QueryExecute("drop database " + dbName);
        }

        public static void DeleteTable(string table)
        {
            QueryExecute("drop table " + table);
        }

        public static string CountRows(string table)  // TO Return no of rows in string 
        {
            _commandExecute = new SqlCommand("select count(*) FROM " + table, _connection);
            object count = _commandExecute.ExecuteScalar();
            return count.ToString();
        }

        public static bool RowExist(string query)
        {
            _commandExecute = new SqlCommand(query, _connection);
            SqlDataReader dataReader = _commandExecute.ExecuteReader();
            if (dataReader.HasRows == true)
                return true;
            else
                return false;
        }

        public static void DatGridFill(System.Windows.Forms.DataGridView datagridview, string query)
        {
            _dataTable = new DataTable();

            QueryExecute(query);
            _dataAdapter = new SqlDataAdapter(query, _connection);
            _dataAdapter.Fill(_dataTable);

            datagridview.DataSource = _dataTable;
        }

        public static string GetLastId(string table)
        {
            var fetchSql = new SqlCommand("SELECT MAX(id) FROM " + table, _connection);
            var dr = fetchSql.ExecuteScalar();
            return dr.ToString();
        }

        public static List<string> GetColumnData(string tableName, string columnName, string whereQuery)
        {
            SqlCommand cmd = new SqlCommand("SELECT [" + columnName + "] FROM " + tableName + " " + whereQuery + " ", DbClient._connection);
            SqlDataReader sdr = cmd.ExecuteReader();

            List<string> list = new List<string>();
            while (sdr.Read())
            {
                list.Add(sdr[0].ToString());
            }

            sdr.Close();
            return list;
        }

        public static void FillCombo(ComboBox combo, string tblName, string columnName)
        {
            SqlCommand cmd = new SqlCommand("SELECT [" + columnName + "] FROM " + tblName + " ", DbClient._connection);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                combo.Items.Add(sdr[0].ToString());
            }
            sdr.Close();
        }

        public static void ConnectionClose()
        {
            _connection.Close();
            _connection.Dispose();
        }



    }
}