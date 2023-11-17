using cls_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_dal
{
    public class cls_login
    {
        private SqlConnection _connection;
        private SqlCommand _comandSql;

        public void InserirUsuario( loginModel props)
        {
            _connection = Connection.connection();

            _comandSql = new SqlCommand();
            _comandSql.Connection = _connection;
            _comandSql.CommandText = "INSERT INTO dbo.users (nome, senha) " +
                                    "VALUES (@nome, @senha)";

            // Adicione os parâmetros com os valores dos campos em loginModel
            _comandSql.Parameters.Add("@nome", SqlDbType.VarChar).Value = props.Pername;
            _comandSql.Parameters.Add("@senha", SqlDbType.VarChar).Value = props.Password;

            _comandSql.ExecuteNonQuery();

            Connection.closeConnection();
        }


        public bool UsuarioExiste(loginModel props)
        {
            _connection = Connection.connection();

            _comandSql = new SqlCommand();
            _comandSql.Connection = _connection;
            _comandSql.CommandText = "SELECT COUNT(*) FROM dbo.users WHERE nome = @nome";

            _comandSql.Parameters.Add("@nome", SqlDbType.VarChar).Value = props.Pername;

            int count = (int)_comandSql.ExecuteScalar();

            Connection.closeConnection();

            return count > 0;
        }


        public bool SenhaCorreta(loginModel props)
        {
            _connection = Connection.connection();

            _comandSql = new SqlCommand();
            _comandSql.Connection = _connection;
            _comandSql.CommandText = "SELECT COUNT(*) FROM dbo.users WHERE nome = @nome AND senha = @senha";

            _comandSql.Parameters.Add("@nome", SqlDbType.VarChar).Value = props.Pername;
            _comandSql.Parameters.Add("@senha", SqlDbType.VarChar).Value = props.Password;

            int count = (int)_comandSql.ExecuteScalar();

            Connection.closeConnection();

            return count > 0;
        }
    }
}
