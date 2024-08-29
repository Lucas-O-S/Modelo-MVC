using System;
using System.Collections.Generic;
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
            using (SqlConnection conexao = ConexãoBD.GetConexao())
            {
                using(SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    if(parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                        comando.ExecuteNonQuery();
                    }
                }
            }

        }
    }
}
