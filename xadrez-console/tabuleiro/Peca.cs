namespace tabuleiro
{
    class Peca
    {
        public posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca( Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
            this.Posicao = null;
            this.qteMovimentos = 0;
        }
        public void incrementatQtMovimentos()
        {
            qteMovimentos++;
        }
        
    }
}
