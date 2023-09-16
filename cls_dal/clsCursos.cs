using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cls_model;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace cls_dal
{
    public class clsCursos
    {
        private SqlConnection _connection;
        private SqlCommand _comandSql;

        public void Insert(clsCursosModel props)
        {
            _connection = Connection.connection();

            _comandSql = new SqlCommand();
            _comandSql.Connection = _connection;
            _comandSql.CommandText = "INSERT INTO tblCursos (cursoName, cursoSigla, cursoObservacoes, perId) " +
                                     "VALUES (@cursoName, @cursoSigla, @cursoObservacoes, @perId)";

            _comandSql.Parameters.Add("@cursoName", SqlDbType.VarChar).Value = props.CursoName;
            _comandSql.Parameters.Add("@cursoSigla", SqlDbType.VarChar).Value = props.CursoSigla;
            _comandSql.Parameters.Add("@cursoObservacoes", SqlDbType.VarChar).Value = props.CursoObservacoes;
            _comandSql.Parameters.Add("@perId", SqlDbType.Int).Value = props.PerId;

            _comandSql.ExecuteNonQuery();

            Connection.closeConnection();
        }
    }
}
