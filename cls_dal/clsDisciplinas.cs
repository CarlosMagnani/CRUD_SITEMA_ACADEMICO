using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cls_model;

namespace cls_dal
{
    public class clsDisciplinaDal
    {
        private SqlConnection _connection;
        private SqlCommand _comandSql;

        public void Insert(clsDisciplinasModel props)
        {
            _connection = Connection.connection();

            _comandSql = new SqlCommand();
            _comandSql.Connection = _connection;
            _comandSql.CommandText = "INSERT INTO tblDisciplinas (disciplinaNome, disciplinaSigla, disciplinaObservacoes) " +
                                     "VALUES (@disciplinaNome, @disciplinaSigla, @disciplinaObservacoes)";

            // Adicione os parâmetros com os valores dos campos em DisciplinasModel
            _comandSql.Parameters.Add("@disciplinaNome", SqlDbType.VarChar).Value = props.DisciplinaNome;
            _comandSql.Parameters.Add("@disciplinaSigla", SqlDbType.VarChar).Value = props.DisciplinaSigla;
            _comandSql.Parameters.Add("@disciplinaObservacoes", SqlDbType.VarChar).Value = props.DisciplinaObservacoes;

            _comandSql.ExecuteNonQuery();

            Connection.closeConnection();
        }
    }
}
