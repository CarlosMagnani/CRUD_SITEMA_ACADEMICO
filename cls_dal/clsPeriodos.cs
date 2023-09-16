using System;
using System.Collections.Generic;
using System.Linq;
using cls_model;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace cls_dal
{
    public class clsPeriodosDal
    {
        private SqlConnection _connection;
        private SqlCommand _comandSql;
        private SqlDataAdapter _adapter;
        private SqlDataReader _reader;


        public void insert(clsPeriodosModel props)
        {
            _connection = Connection.connection();
            try
            {
                _comandSql = new SqlCommand();
                _comandSql.Connection = _connection;
                _comandSql.CommandText = "insert into dbo.tbl_periodos values(@pernome, @persigla)";
                _comandSql.Parameters.Add("@pernome", SqlDbType.VarChar).Value = props.Pername;
                _comandSql.Parameters.Add("@persigla", SqlDbType.VarChar).Value = props.Persigla;
                _comandSql.ExecuteNonQuery();

                Connection.closeConnection();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataTable getPeriodos()
        {
            _connection = Connection.connection();
            DataTable dataTable = new DataTable();
            try
            {
                _comandSql = new SqlCommand();
                _comandSql.Connection = _connection;
                _comandSql.CommandText = "SELECT perid, pernome FROM dbo.tbl_periodos";
                _comandSql.ExecuteNonQuery();
                SqlDataReader reader = _comandSql.ExecuteReader();

                // Carregue os resultados no DataTable
                dataTable.Load(reader);

                Connection.closeConnection();
                return dataTable;

            }
            catch (Exception ex)
            {

                Connection.closeConnection();
                throw ex;

            }

            finally { }
        }
    }
}
