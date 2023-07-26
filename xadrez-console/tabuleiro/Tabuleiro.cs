
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

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }
        public bool existePeca(posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        public void colocarPeca(Peca p, posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabulerioException("Já existe uma peça nessa posição! ");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
        public Peca retirarPeca(posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.Posicao = null;
            pecas[pos.Linha, pos.Coluna] = aux;
            return aux;

        }

        public bool posicaoValida(posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= linhas || pos.Coluna < 0 || pos.Coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao(posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabulerioException("Posição invalida!");
            }
        }
    }
}
