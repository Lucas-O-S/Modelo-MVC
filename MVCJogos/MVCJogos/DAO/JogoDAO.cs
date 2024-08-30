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

        private SqlParameter[] CriarParametros(JogoViewModel jogo)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", jogo.id);
            parametros[1] = new SqlParameter("descricao", jogo.descricao);
            parametros[2] = new SqlParameter("valor_locacao", jogo.valorLocacao);
            parametros[3] = new SqlParameter("data_aquisicao", jogo.dataAquicicao);
            parametros[4] = new SqlParameter("categoriaID", jogo.idCategoria);
            return parametros;
        }
        public void Inserir(JogoViewModel jogo)
        {
            SqlConnection conexao = ConexaoBD.GetConexao();
           
                string sql = "insert into jogos(id, descricao, valor_locacao, data_aquisicao, categoriaID) " +
                    "values (@id, @descricao, @valor_locacao, @data_aquisicao ,@categoriaID)";
                HelperDAO.ExecutarSQL(sql, CriarParametros(jogo)); 
        }

        public void Alterar(JogoViewModel jogo)
        {
            string sql= "update jogos set descricao=@descricao," +
                "valor_locacao=@valor_locacao, data_aquisicao=@data_aquisicao," +
                "categoriaID=@categoriaID where id = @id";
            HelperDAO.ExecutarSQL(sql, CriarParametros(jogo));
        }

        public void Excluir(int id)
        {
            string sql = "delete jogos where id = " + id;
            HelperDAO.ExecutarSQL(sql,null);
        }


    }
}
