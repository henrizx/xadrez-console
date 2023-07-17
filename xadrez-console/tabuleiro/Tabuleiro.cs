using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
        private int v1;
        private int v2;

        public Tabuleiro(int linhas, int colunas, Peca[,] pecas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }

        public Tabuleiro(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
