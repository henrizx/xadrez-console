
using tabuleiro;


namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            posicao p;

            p = new posicao(3, 4);

            Console.WriteLine($"posicao: {p}");
        }
    }
}