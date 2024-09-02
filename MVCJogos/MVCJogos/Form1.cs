using MVCJogos.DAO;
using MVCJogos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCJogos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Validacao(JogoViewModel jogo)
        {
            if (jogo.id <= 0)
            {
                throw new Exception("Id menor que 0");

            }
            if(jogo.valorLocacao < 0)
            {
                throw new Exception("Preço invalido");

            }

            if (jogo.dataAquicicao > DateTime.Now)
            {
                throw new Exception("Data de aquicição invalida");
            }

            if (jogo.idCategoria <= 0)
            {
                throw new Exception("Codigo de Categoria invalida");
            }

            if (string.IsNullOrEmpty(jogo.descricao))
            {
                throw new Exception("Descrição invalida");
            }
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            try
            {
                JogoViewModel jogo = PreencherDados();
                Validacao(jogo);
                JogoDAO jogoDAO = new JogoDAO();
                jogoDAO.Inserir(jogo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private JogoViewModel PreencherDados()
        {
            JogoViewModel jogo = new JogoViewModel();
            jogo.id = int.Parse(boxId.Text);
            jogo.idCategoria = int.Parse(boxCat.Text);
            jogo.descricao = boxDesc.Text;
            jogo.dataAquicicao = DateTime.Parse(boxData.Text);
            jogo.valorLocacao = decimal.Parse(boxValor.Text);
            return jogo;
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                dao.Excluir(Int32.Parse(boxId.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            try
            {
                JogoViewModel jogo = PreencherDados();
                Validacao(jogo);
                JogoDAO dao = new JogoDAO();
                dao.Alterar(jogo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void PreencherTela(JogoViewModel jogo)
        {
            if (jogo != null)
            {
                boxId.Text = jogo.id.ToString();
                boxValor.Text = jogo.valorLocacao.ToString();
                boxDesc.Text = jogo.descricao.ToString();
                boxCat.Text = jogo.idCategoria.ToString();
                boxData.Text = jogo.dataAquicicao.ToString();

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                JogoViewModel jogo = dao.Consulta(int.Parse(boxId.Text));
                if (jogo != null)
                {
                    PreencherTela(jogo);
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
