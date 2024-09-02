using MVCJogos.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        public JogoViewModel Consulta(int id)
        {
            using (SqlConnection con = ConexaoBD.GetConexao())
            {
                string sql = "select * from jogos where id = " + id;

                using (SqlDataAdapter adapter = new SqlDataAdapter(sql,con))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    if (tabela.Rows.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        DataRow registro = tabela.Rows[0];
                        return MontarModel(registro);
                    }
                }
            }
         
        }

        public static JogoViewModel MontarModel(DataRow registro)
        {
            JogoViewModel jogo = new JogoViewModel();

            jogo.id = Convert.ToInt32(registro["id"]);
            jogo.descricao = Convert.ToString(registro["descricao"]);

            jogo.valorLocacao = Convert.ToDecimal(registro["valor_locacao"]);
            jogo.dataAquicicao = Convert.ToDateTime(registro["data_aquisicao"]);

            jogo.idCategoria = Convert.ToInt32(registro["categoriaID"]);

            return jogo;

        }
    }
}
