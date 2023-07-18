
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
        private int v1;
        private int v2;

        /*public Tabuleiro(int linhas, int colunas, Peca[,] pecas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }
        */

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca ( int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
