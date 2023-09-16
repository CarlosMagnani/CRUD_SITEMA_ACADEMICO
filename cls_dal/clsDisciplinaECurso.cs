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
    public class clsDisciplinaECursoDal
    {
        private SqlConnection _connection;
        private SqlCommand _comandSql;


        public void Inserir(clsDisECursoModel props)
        {
            _connection = Connection.connection();

            _comandSql = new SqlCommand();
            _comandSql.Connection = _connection;
            _comandSql.CommandText = "INSERT INTO dbo.tbl_disciplinaecurso (curid, disid) " +
                                     "VALUES (@curid, @disid)";

            // Adicione os parâmetros com os valores dos campos em DisciplinasModel
            _comandSql.Parameters.Add("@curid", SqlDbType.VarChar).Value = props.CursoId;
            _comandSql.Parameters.Add("@disid", SqlDbType.VarChar).Value = props.DisId;

            _comandSql.ExecuteNonQuery();

            Connection.closeConnection();
        }
        

        public DataTable getDisciplinaECurso()
        {

            try
            {
                _connection = Connection.connection();
                DataTable data = new DataTable();
                _comandSql = new SqlCommand();
                _comandSql.Connection = _connection;
                _comandSql.CommandText = @"
    SELECT
        c.cursoNome, c.cursoSigla,
        d.disNome, d.disSigla,
        p.pernome
    FROM
        dbo.tbl_disciplinaecurso AS t
    JOIN
        dbo.tbl_cursos AS c ON t.curid = c.cursoId
    JOIN
        dbo.tbl_periodos AS p ON c.perId = p.perid
    JOIN
        dbo.tbl_disciplinas AS d ON t.disid = d.disid";
                SqlDataReader reader = _comandSql.ExecuteReader();

                // Carregue os resultados no DataTable
                data.Load(reader);

                Connection.closeConnection();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }
    }
}
