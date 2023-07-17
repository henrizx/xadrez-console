using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Peca
    {
        public posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca(posicao Posicao, Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
            this.Posicao = Posicao;
            this.qteMovimentos = 0;
        }
        
    }
}
