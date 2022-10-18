using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Yazılım_Mimari_Tasarım_proje
{
    class Connection
    {
        public static string connectionString { get; set; }
        public static string tableName { get; set; }
        protected string status { get; set; }
        protected SqlConnection connection { get; set; }
        protected SqlCommand command;
        protected SqlDataReader dataReader;
        protected DataTable LoadDataWithAllColumns()
        {
            DataTable data = null;
            try
            {
                connection = new SqlConnection(connectionString);
                string query = string.Format("select * from{0}", tableName);
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        dataReader = command.ExecuteReader();
                        data = new DataTable();
                        data.Load(dataReader);
                    }
                }
                return data;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "eror");
                return data;
            }

        }
        protected DataTable LoadDataWithParticularColumns(string[] columnsName)
        {
            string columns = "";
            foreach (string column in columnsName)
            {
                columns += column + ",";
            }
            columns = columns.Remove(columns.LastIndexOf(','), 1);
            DataTable data = null;
            try
            {
                connection = new SqlConnection(connectionString);
                string query = string.Format("select {0} * from{1}", columns, tableName);
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        dataReader = command.ExecuteReader();
                        data = new DataTable();
                        data.Load(dataReader);
                    }
                }
                return data;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "eror");
                return data;
            }

        }
        protected DataTable LoadDataFromQuery(string query)
        {
            DataTable data = null;
            try
            {
                connection = new SqlConnection(connectionString);
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        dataReader = command.ExecuteReader();
                        data = new DataTable();
                        data.Load(dataReader);
                    }
                }
                return data;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "eror");
                return data;
            }
        }

    }
}
