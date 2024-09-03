using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCJogos.DAO
{
    public static class HelperDAO
    {
        public static void ExecutarSQL(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using(SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    if(parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }
                    comando.ExecuteNonQuery();

                }
            }

        }

        public static DataTable ExecutarSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                   
                    
                    DataTable TabelaTemp = new DataTable();
                    adapter.Fill(TabelaTemp);
                    return TabelaTemp;

                }
            }
        
        
        }
    }
}
