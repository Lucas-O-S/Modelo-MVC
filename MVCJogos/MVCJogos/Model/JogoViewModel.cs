using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCJogos.Model
{
    public class JogoViewModel
    {
        public int id {  get; set; }
        public string descricao { get; set; }
        public float valorLocacao {  get; set; }
        public DateTime dataAquicicao { get; set; }
        public int idCategoria { get; set; }
    }
}
