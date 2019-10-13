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
                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(3,4));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1,3));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(4,1));

                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
