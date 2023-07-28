using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada) 
                {
                    Console.Clear();
                    Tela.imprimeTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Digite a posição de origem: ");
                    posicao origem = Tela.lerPosicaoXadrez().toPosicao();


                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimeTabuleiro(partida.tab, posicoesPossiveis);


                    Console.Write("Destino: ");
                    posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMoviment(origem, destino);
                }

                Tela.imprimeTabuleiro(partida.tab);

              
            }
            catch(TabulerioException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }
    }
}