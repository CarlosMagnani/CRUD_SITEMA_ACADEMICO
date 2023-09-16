using System;
using System.Data;
using System.Data.SqlClient;

namespace cls_dal
{
    public class Connection
    {
        private static SqlConnection _connection;
        private static SqlCommand _comando;
        private static SqlDataAdapter _adaptador;
        private static SqlDataReader _reader;
        private static DataTable _tabela;

        private static String _stringConexao = "Data Source=NOTEBOOKCARLOS\\SQLEXPRESS;" +
                                                "Initial Catalog=process;" +
                                                "Integrated Security=True";

        public static SqlConnection connection()
        {
            try
            {
                _connection = new SqlConnection();
                _connection.ConnectionString = _stringConexao;
                _connection.Open();
                return _connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void closeConnection() 
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

        }
    }


    
}