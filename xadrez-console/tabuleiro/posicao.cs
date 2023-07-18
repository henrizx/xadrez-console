namespace tabuleiro
{
    class posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha + ", " + Coluna.ToString();
        }
    }
}
