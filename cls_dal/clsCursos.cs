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
    public class clsCursosDal
    {
        private SqlConnection _connection;
        private SqlCommand _comandSql;

        public void Insert(clsCursosModel props)
        {
            _connection = Connection.connection();

            _comandSql = new SqlCommand();
            _comandSql.Connection = _connection;
            _comandSql.CommandText = "INSERT INTO dbo.tbl_cursos (cursoNome, cursoSigla, cursoObservacao, perId) " +
                                     "VALUES (@cursoNome, @cursoSigla, @cursoObservacao, @perId)";

            _comandSql.Parameters.Add("@cursoNome", SqlDbType.VarChar).Value = props.CursoName;
            _comandSql.Parameters.Add("@cursoSigla", SqlDbType.VarChar).Value = props.CursoSigla;
            _comandSql.Parameters.Add("@cursoObservacao", SqlDbType.VarChar).Value = props.CursoObservacoes;
            _comandSql.Parameters.Add("@perId", SqlDbType.Int).Value = props.PerId;

            _comandSql.ExecuteNonQuery();

            Connection.closeConnection();
        }


        public DataTable getCursos()
        {
            DataTable dataTable = new DataTable();

            {
                _connection = Connection.connection();

                _comandSql = new SqlCommand();
                _comandSql.Connection = _connection;
                _comandSql.CommandText = "SELECT c.cursoId as cursoId, c.cursoNome as cursoNome, c.cursoSigla as cursoSigla, p.perNome " +
                        "FROM dbo.tbl_cursos c " +
                        "INNER JOIN dbo.tbl_periodos p ON c.perid = p.perid";

                _comandSql.ExecuteNonQuery();
                SqlDataReader reader = _comandSql.ExecuteReader();

                // Carregue os resultados no DataTable
                dataTable.Load(reader);

                Connection.closeConnection();

                return dataTable;
            }
        }
    }
}
