﻿using System;
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
            _comandSql.CommandText = "INSERT INTO dbo.tbl_disciplinas (disNome, disSigla, disObservacoes) " +
                                     "VALUES (@disNome, @disSigla, @disObservacoes)";

            // Adicione os parâmetros com os valores dos campos em DisciplinasModel
            _comandSql.Parameters.Add("@disNome", SqlDbType.VarChar).Value = props.DisciplinaNome;
            _comandSql.Parameters.Add("@disSigla", SqlDbType.VarChar).Value = props.DisciplinaSigla;
            _comandSql.Parameters.Add("@disObservacoes", SqlDbType.VarChar).Value = props.DisciplinaObservacoes;

            _comandSql.ExecuteNonQuery();

            Connection.closeConnection();
        }

        public DataTable getDisciplinas()
        {

            try
            {

                _connection = Connection.connection();
                DataTable data = new DataTable();
                _comandSql = new SqlCommand();
                _comandSql.Connection = _connection;
                _comandSql.CommandText = "SELECT disid, disNome, disSigla FROM dbo.tbl_disciplinas";
                _comandSql.ExecuteNonQuery();
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
