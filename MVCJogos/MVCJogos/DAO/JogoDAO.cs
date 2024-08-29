using MVCJogos.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCJogos.DAO
{
    internal class JogoDAO
    {
        public void Inserir(JogoViewModel jogo)
        {
            SqlConnection conexao = ConexãoBD.GetConexao();
            try
            {
                string valorLocacao = jogo.valorLocacao.ToString().Replace(',', '.');
                string sql = string.Format("set dateformat dmy; " +
                    "insert into jogos(id, descricao, valor_locacao, data_aquisicao, categoriaID)" +
                    "  values ({0}, '{1}', {2},'{3}',{4}) ",
                    jogo.id, jogo.descricao, valorLocacao, jogo.dataAquicicao, jogo.idCategoria) ;
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally {
                conexao.Close(); 
            }
        }
    }
}
