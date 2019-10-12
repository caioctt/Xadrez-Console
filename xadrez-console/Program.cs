using System;
using tabuleiro;
using xadrezPecas;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Posicao P;

                P = new Posicao(3, 4);

                Tabuleiro tab = new Tabuleiro(8, 8);

                PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                Console.WriteLine("Posição: " + pos.toPosicao());
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
