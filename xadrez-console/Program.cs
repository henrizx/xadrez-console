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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new posicao(0, 2));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new posicao(3, 7));
                Tela.imprimeTabuleiro(tab);
            }
            catch(TabulerioException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }
    }
}